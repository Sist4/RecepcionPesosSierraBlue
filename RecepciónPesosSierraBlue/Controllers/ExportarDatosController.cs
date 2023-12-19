using RecepciónPesosSierraBlue.Model;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace RecepciónPesosSierraBlue.Controllers
{
    public class ExportarDatosController
    {
        public List<Recepcion> ExtraerDatosRecepciones(DateTime fecha)
        {
            using (SierraBlueDB db = new SierraBlueDB())
            {
                return db.Recepciones
                 .Where(x =>DbFunctions.TruncateTime(x.FechaYHora)==(fecha)).ToList();
            }

        }
        public List<Empaque> ExtraerDatosEmpaques(DateTime fecha)
        {
            using (SierraBlueDB db = new SierraBlueDB())
            {
                return db.Empaques
                 .Where(x => DbFunctions.TruncateTime(x.FechaYHora) == (fecha)).ToList();
            }

        }

        public void GuardarExcelRecepciones(string filePath, DateTime fecha)
        {
            //string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            SLDocument sl = new SLDocument();
            var datos = ExtraerDatosRecepciones(fecha);
            int iC = 1;

            string[] encabezados = { "FechaYHora", "Puerto", "Productor", "Variedad", "Lote cultivo", "Categoría", "Lote poscosecha", "Peso(kg)" };

            foreach (var encabezado in encabezados)
            {
                sl.SetCellValue(1, iC, encabezado);
                iC++;
            }



            int iR = 2;
            foreach (var dato in datos)
            {
                sl.SetCellValue(iR, 1, dato.FechaYHora.ToString());
                sl.SetCellValue(iR, 2, dato.Puerto);
                sl.SetCellValue(iR, 3, dato.Productor);
                sl.SetCellValue(iR, 4, dato.Variedad);
                sl.SetCellValue(iR, 5, dato.LoteCultivo);
                sl.SetCellValue(iR, 6, dato.Categoria);
                sl.SetCellValue(iR, 7, dato.LotePoscosecha);
                sl.SetCellValue(iR, 8, dato.Peso);
                iR++;
            }
            sl.SaveAs(filePath);
            //MessageBox.Show("Se exportó el archivo excel");
        }
        public void GuardarExcelEmpaques(string filePath, DateTime fecha)
        {
            //string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            SLDocument sl = new SLDocument();
            var datos = ExtraerDatosEmpaques(fecha);
            int iC = 1;

            string[] encabezados = { "FechaYHora", "Puerto", "Productor", "Variedad", "Presentación", "Calibre", "Cliente", "Lote poscosecha", "Peso(kg)" };

            foreach (var encabezado in encabezados)
            {
                sl.SetCellValue(1, iC, encabezado);
                iC++;
            }



            int iR = 2;
            foreach (var dato in datos)
            {
                sl.SetCellValue(iR, 1, dato.FechaYHora.ToString());
                sl.SetCellValue(iR, 2, dato.Puerto);
                sl.SetCellValue(iR, 3, dato.Productor);
                sl.SetCellValue(iR, 4, dato.Variedad);
                sl.SetCellValue(iR, 5, dato.Presentacion);
                sl.SetCellValue(iR, 6, dato.Calibre);
                sl.SetCellValue(iR, 7, dato.Cliente);
                sl.SetCellValue(iR, 8, dato.LotePoscosecha);
                sl.SetCellValue(iR, 9, dato.Peso);
                iR++;
            }
            sl.SaveAs(filePath);
            //MessageBox.Show("Se exportó el archivo excel");
        }
    }
}
