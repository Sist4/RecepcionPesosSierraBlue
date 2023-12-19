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
    
    public class CalibreController
    {
        DataGridView dtgCalibres;
        public CalibreController(DataGridView dtgCalibres)
        {
            this.dtgCalibres = dtgCalibres;
        }
        public void InicializarCategorias()
        {
            dtgCalibres.Columns.Add("ID", "ID");
            dtgCalibres.Columns.Add("Nombre", "Nombre");
            dtgCalibres.Columns.Add("Estado", "Estado");
        }
        public void MostrarCalibres()
        {
            dtgCalibres.Rows.Clear();

            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    var calibres = db.Calibres.ToList();
                    foreach (var cat in calibres)
                    {
                        dtgCalibres.Rows.Add(cat.Id,
                            cat.Nombre,
                            cat.Estado);
                    }

                }
            }catch (Exception ex)
            {
                throw;
            }
            

        }
        public void AgregarCalibre(string nombre)
        {
            try
            {
                if (!CamposVacios(nombre))
                {
                    var cal = new Calibre
                    { Nombre = nombre, Estado = "Habilitado" };

                    using (SierraBlueDB context = new SierraBlueDB())
                    {
                        context.Calibres.Add(cal);
                        context.SaveChanges();
                    }

                    MostrarCalibres();
                }
            }catch(Exception)
            {
                throw;
            }
            

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
        public Calibre GetCalibre(int id)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Calibres.Where(i => i.Id == id).FirstOrDefault();
                }
            }
            catch (Exception) { throw; }


        }
        public void CambiarEstado(Calibre calibre)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    if (calibre.Estado.Equals("Habilitado"))
                    {
                        calibre.Estado = "Deshabilitado";

                    }
                    else
                    {
                        calibre.Estado = "Habilitado";
                    }
                    db.Entry(calibre).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }


        }
        public void EliminarCalibre(Calibre calibre)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    //db.Presentaciones.Remove(presentacion);
                    db.Entry(calibre).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
