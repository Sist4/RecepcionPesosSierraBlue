using RecepciónPesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepciónPesosSierraBlue.Controllers
{
    public class CategoriaController
    {
        DataGridView dtgCategorias;
        public CategoriaController(DataGridView dtgCategorias)
        {
            this.dtgCategorias = dtgCategorias;
        }
        public void InicializarCategorias()
        {
            dtgCategorias.Columns.Add("ID", "ID");
            dtgCategorias.Columns.Add("Nombre", "Nombre");
            dtgCategorias.Columns.Add("Estado", "Estado");
        }
        public void MostrarCategorias()
        {
            dtgCategorias.Rows.Clear();
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    var categorias = db.Categorias.ToList();
                    foreach (var cat in categorias)
                    {
                        dtgCategorias.Rows.Add(cat.Id,
                            cat.Nombre,
                            cat.Estado);
                    }

                }
            }
            catch (Exception) { throw; }

            

        }
        public void AgregarCategoria(string nombre)
        {
            try
            {
                if (!CamposVacios(nombre))
                {
                    var cat = new Categoria
                    { Nombre = nombre, Estado = "Habilitado" };

                    using (SierraBlueDB context = new SierraBlueDB())
                    {
                        context.Categorias.Add(cat);
                        context.SaveChanges();
                    }

                    MostrarCategorias();
                }
            }catch (Exception) { throw; }
            

        }
        public bool CamposVacios(string nombre)
        {
            if(nombre.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Categoria GetCategoria(int id)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Categorias.Where(i => i.Id == id).FirstOrDefault();
                }
            }catch(Exception) { throw; }
            

        }
        public void CambiarEstado(Categoria categoria)
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
        public void EliminarCategoria(Categoria categoria)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    db.Entry(categoria).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
