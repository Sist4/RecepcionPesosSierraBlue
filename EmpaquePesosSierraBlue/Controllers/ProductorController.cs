using EmpaquePesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepciónPesosSierraBlue.Controllers
{
    public class ProductorController
    {
        DataGridView dtgProductores;
        
        public ProductorController(DataGridView dtgProductores)
        {
            this.dtgProductores = dtgProductores;

        }
        public void InicializarProductores()
        {
            dtgProductores.Columns.Add("ID", "ID");
            dtgProductores.Columns.Add("Nombre", "Nombre");
            dtgProductores.Columns.Add("Iniciales", "Iniciales");
            dtgProductores.Columns.Add("Estado", "Estado");
        }
        public void MostrarProductores()
        {
            dtgProductores.Rows.Clear();
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    var productores = db.Productores.ToList();
                    foreach (var productor in productores)
                    {
                        dtgProductores.Rows.Add(productor.Id,
                            productor.Nombre,
                            productor.Iniciales,
                            productor.Estado);

                    }

                }
            }catch(Exception)
            {
                throw;
            }
            
            
        }

        public void AgregarNuevoProductor(string nombre, string iniciales)
        {
            try
            {
                if (!CamposVacios(nombre, iniciales))
                {
                    var prod = new Productor
                    { Nombre = nombre, Iniciales = iniciales, Estado = "Habilitado" };

                    using (SierraBlueDB context = new SierraBlueDB())
                    {
                        context.Productores.Add(prod);
                        context.SaveChanges();
                    }

                    MostrarProductores();
                }
            }catch (Exception) { throw; }
            
            
        }
        public bool CamposVacios(string nombre, string iniciales)
        {
            if(nombre.Equals(string.Empty)|| iniciales.Equals(string.Empty)) 
                return true;              
            else
                return false;
        }
        public Productor GetProductor(int id)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Productores.Where(i => i.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        public void CambiarEstado(Productor productor)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    if (productor.Estado.Equals("Habilitado"))
                    {
                        productor.Estado = "Deshabilitado";

                    }
                    else
                    {
                        productor.Estado = "Habilitado";
                    }
                    db.Entry(productor).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        public void EliminarProductor(Productor productor)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    //db.Presentaciones.Remove(presentacion);
                    db.Entry(productor).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("¡No se pudo eliminar! " +
                    " Existen registros asociados a este registo, eliminelos primero");
            }
        }

    }
}
