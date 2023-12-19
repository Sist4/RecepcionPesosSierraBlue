using RecepciónPesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace RecepciónPesosSierraBlue.Controllers
{
    public class LoteCultivoController
    {
        ComboBox cmbProductores;
        DataGridView dtgLotesCultivo;
        public LoteCultivoController(ComboBox cmbProductores,DataGridView dtgLotesCultivo)
        {
            this.cmbProductores = cmbProductores;
            this.dtgLotesCultivo = dtgLotesCultivo;
        }
        public void InicializarLotesCultivo()
        {
            dtgLotesCultivo.Columns.Add("ID", "ID");
            dtgLotesCultivo.Columns.Add("Nombre", "Nombre");
            dtgLotesCultivo.Columns.Add("Productor", "Productor");
            dtgLotesCultivo.Columns.Add("Estado", "Estado");
        }
        public void MostrarLotesCultivo()
        {
            dtgLotesCultivo.Rows.Clear();
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    var lotes = db.LotesCultivos
                        .Include(p => p.Productor).ToList();

                    foreach (var lote in lotes)
                    {
                        dtgLotesCultivo.Rows.Add(lote.Id,
                            lote.Nombre,
                            lote.Productor.Nombre,
                            lote.Estado);

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
            }catch(Exception) { throw; }
            
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
            }catch(Exception) { throw; }
            
        }
        public Productor DevolverProductorPorNombre(string nombre)
        {
            try
            {
                using (SierraBlueDB dB = new SierraBlueDB())
                {
                    return dB.Productores.Where(n => n.Nombre.Equals(nombre)).FirstOrDefault();
                }
            }catch(Exception) { throw; }
            
        }
        public void AgregarLoteCultivo(string nombre, string productor)
        {
            try
            {
                if (!CamposVacios(nombre, productor))
                {
                    Productor prod = DevolverProductorPorNombre(productor);
                    var lote = new LotesCultivo
                    {
                        Nombre = nombre,
                        ProductorId = prod.Id,
                        Estado = "Habilitado"
                    };

                    using (SierraBlueDB db = new SierraBlueDB())
                    {
                        db.LotesCultivos.Add(lote);
                        db.SaveChanges();
                    }
                    MostrarLotesCultivo();
                }
            }catch(Exception)
            {
                throw;
            }
            
            
        }
        public bool CamposVacios(string nombre, string productor)
        {
            if(nombre.Equals(string.Empty) || productor.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public LotesCultivo GetLoteCultivo(int id)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.LotesCultivos.Where(i => i.Id == id).FirstOrDefault();
                }
            }catch(Exception) { throw; }
            

        }
        public void CambiarEstado(LotesCultivo lote)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    if (lote.Estado.Equals("Habilitado"))
                    {
                        lote.Estado = "Deshabilitado";

                    }
                    else
                    {
                        lote.Estado = "Habilitado";
                    }
                    db.Entry(lote).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }catch(Exception)
            {  throw; }
           

        }
        public void EliminarLoteCultivo(LotesCultivo lote)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    db.Entry(lote).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
