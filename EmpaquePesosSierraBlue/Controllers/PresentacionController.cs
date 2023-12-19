using DocumentFormat.OpenXml.Office2010.Excel;
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
    public class PresentacionController
    {
        DataGridView dtgPresentaciones;
        public PresentacionController(DataGridView dtgPresentaciones)
        {
            this.dtgPresentaciones = dtgPresentaciones;
        }
        public void InicializarPresentaciones()
        {
            dtgPresentaciones.Columns.Add("ID", "ID");
            dtgPresentaciones.Columns.Add("Nombre", "Nombre");
            dtgPresentaciones.Columns.Add("Estado", "Estado");
        }
        public void MostrarPresentaciones()
        {
            dtgPresentaciones.Rows.Clear();

            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    var categorias = db.Presentaciones.ToList();
                    foreach (var cat in categorias)
                    {
                        dtgPresentaciones.Rows.Add(cat.Id,
                            cat.Nombre,
                            cat.Estado);
                    }

                }
            }catch (Exception)
            {
                throw;
            }
            

        }
        public void AgregarPresentacion(string nombre)
        {
            try
            {
                if (!CamposVacios(nombre))
                {
                    var cat = new Presentacion
                    { Nombre = nombre, Estado = "Habilitado" };

                    using (SierraBlueDB context = new SierraBlueDB())
                    {
                        context.Presentaciones.Add(cat);
                        context.SaveChanges();
                    }

                    MostrarPresentaciones();
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
        public Presentacion GetPresentacion(int id)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Presentaciones.Where(i => i.Id == id).FirstOrDefault();
                }
            }
            catch (Exception) { throw; }


        }
        public void CambiarEstado(Presentacion presentacion)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    if (presentacion.Estado.Equals("Habilitado"))
                    {
                        presentacion.Estado = "Deshabilitado";

                    }
                    else
                    {
                        presentacion.Estado = "Habilitado";
                    }
                    db.Entry(presentacion).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }


        }
        public void EliminarPresentacion(Presentacion presentacion)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    //db.Presentaciones.Remove(presentacion);
                    db.Entry(presentacion).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
