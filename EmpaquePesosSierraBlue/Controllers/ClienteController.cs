using EmpaquePesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpaquePesosSierraBlue.Controllers
{
    public class ClienteController
    {
        DataGridView dtgClientes;
        public ClienteController(DataGridView dtgClientes)
        {
            this.dtgClientes = dtgClientes;
        }
        public void InicializarClientes()
        {
            dtgClientes.Columns.Add("ID", "ID");
            dtgClientes.Columns.Add("Nombre", "Nombre");
            dtgClientes.Columns.Add("Estado", "Estado");
        }
        public void MostrarClientes()
        {
            dtgClientes.Rows.Clear();

            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    var clientes = db.Clientes.ToList();
                    foreach (var cat in clientes)
                    {
                        dtgClientes.Rows.Add(cat.Id,
                            cat.Nombre,
                            cat.Estado);
                    }

                }
            }catch(Exception)
            {
                throw;
            }
            

        }
        public void AgregarCliente(string nombre)
        {
            try
            {
                if (!CamposVacios(nombre))
                {
                    var cat = new Cliente
                    { Nombre = nombre, Estado = "Habilitado" };

                    using (SierraBlueDB context = new SierraBlueDB())
                    {
                        context.Clientes.Add(cat);
                        context.SaveChanges();
                    }

                    MostrarClientes();
                }
            }catch(Exception) { throw; }
            

        }
        public bool CamposVacios(string nombre)
        {
            if (nombre.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Cliente GetCliente(int id)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Clientes.Where(i => i.Id == id).FirstOrDefault();
                }
            }
            catch (Exception) { throw; }


        }
        public void CambiarEstado(Cliente categoria)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    if (categoria.Estado.Equals("Habilitado"))
                    {
                        categoria.Estado = "Deshabilitado";

                    }
                    else
                    {
                        categoria.Estado = "Habilitado";
                    }
                    db.Entry(categoria).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }


        }
        public void EliminarCliente(Cliente cliente)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    //db.Presentaciones.Remove(presentacion);
                    db.Entry(cliente).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
