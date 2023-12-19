using EmpaquePesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepciónPesosSierraBlue.Controllers
{
    public class VariedadController
    {
        ComboBox cmbProductores;
        DataGridView dtgVariedades;
        public VariedadController(ComboBox cmbProductores, DataGridView dtgVariedades) 
        { 
            this.cmbProductores = cmbProductores;
            this.dtgVariedades = dtgVariedades;
        }
        public void InicializarVariedades()
        {
            dtgVariedades.Columns.Add("ID", "ID");
            dtgVariedades.Columns.Add("Nombre", "Nombre");
            dtgVariedades.Columns.Add("Iniciales", "Iniciales");
            dtgVariedades.Columns.Add("Productor", "Productor");
            dtgVariedades.Columns.Add("Estado", "Estado");
        }
        public void MostrarVariedades()
        {
            dtgVariedades.Rows.Clear();

            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    var variedades = db.Variedades
                       .Include(p => p.Productor)
                    .ToList();


                    foreach (var variedad in variedades)
                    {
                        dtgVariedades.Rows.Add(variedad.Id,
                            variedad.Nombre,
                            variedad.Iniciales,
                            variedad.Productor.Nombre,
                            variedad.Estado);

                    }

                }
            }catch(Exception)
            {
                throw;
            }
            
        }
        public void MostrarProductoresHabilitados()
        {
            cmbProductores.Items.Clear();
            try
            {
                foreach (var item in DevolverProductoresHabilitados())
                {
                    cmbProductores.Items.Add(item);
                }
            }catch(Exception)
            {
                throw;
            }
            
        }
        public List<string> DevolverProductoresHabilitados()
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Productores.Where(e => e.Estado.Equals("habilitado"))
                        .Select(n => n.Nombre)
                        .ToList();
                }
            }catch (Exception)
            {
                throw;
            }
            
        }
        public List<Variedad> DevolverVariedades()
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Variedades.ToList();
                }
            }catch(Exception)
            {
                throw;
            }
            
        }
        public Productor DevolverProductorPorNombre(string nombre)
        {
            try
            {
                using (SierraBlueDB dB = new SierraBlueDB())
                {
                    return dB.Productores.Where(n => n.Nombre.Equals(nombre)).FirstOrDefault();
                }
            }catch(Exception)
            {
                throw;
            }
            
        }
        public void AgregarVariedad(string nombre, string iniciales, string productor)
        {
            try
            {
                if (!CamposVacios(nombre, iniciales, productor))
                {
                    Productor prod = DevolverProductorPorNombre(productor);
                    var variedad = new Variedad
                    {
                        Nombre = nombre,
                        Iniciales = iniciales,
                        ProductorId = prod.Id,
                        Estado="Habilitado"
                    };

                    using (SierraBlueDB db = new SierraBlueDB())
                    {
                        db.Variedades.Add(variedad);
                        db.SaveChanges();
                    }
                    MostrarVariedades();
                }
            }catch(Exception)
            {
                throw;
            }
            
            
        }
        public bool CamposVacios(string nombre, string iniciales, string productor)
        {
            if(nombre.Equals(string.Empty) || iniciales.Equals(string.Empty) || productor.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Variedad GetVariedad(int id)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Variedades.Where(i => i.Id == id).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
        public void CambiarEstado(Variedad variedad)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    if (variedad.Estado.Equals("Habilitado"))
                    {
                        variedad.Estado = "Deshabilitado";

                    }
                    else
                    {
                        variedad.Estado = "Habilitado";
                    }
                    db.Entry(variedad).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
        public void EliminarVariedad(Variedad variedad)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    db.Entry(variedad).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
