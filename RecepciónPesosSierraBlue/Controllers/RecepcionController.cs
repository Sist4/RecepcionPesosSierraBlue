using RecepciónPesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepciónPesosSierraBlue.Controllers
{
    public class RecepcionController
    {
        DataGridView dtgRecepciones;
        DataGridView dtgPesos;
        ComboBox cmbPuertos;
        ComboBox cmbProductores;
        ComboBox cmbVariedades;
        ComboBox cmbLotesCultivo;
        ComboBox cmbCategorias;

        public Dictionary<SerialPort, Recepcion> recepcionesPorPuerto = new Dictionary<SerialPort, Recepcion>();
        public List<SerialPort> serialPorts = new List<SerialPort>();
        public Dictionary<SerialPort, int> numeroLotes;
        public RecepcionController(DataGridView dtgRecepciones, DataGridView dtgPesos, ComboBox cmbProductores,
            ComboBox cmbVariedades, ComboBox cmbLotesCultivo, ComboBox cmbCategorias, ComboBox cmbPuertos)
        {
            this.cmbProductores = cmbProductores;
            this.cmbLotesCultivo = cmbLotesCultivo;
            this.cmbVariedades = cmbVariedades;
            this.cmbPuertos = cmbPuertos;
            this.cmbCategorias = cmbCategorias;
            this.dtgPesos = dtgPesos;
            this.dtgRecepciones = dtgRecepciones;
            numeroLotes = new Dictionary<SerialPort, int>();
           // puertosHabilitados = DevolverPuertosHabilitados();
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
            }catch { throw; }
            
        }
        public void MostrarVariedadesHabilitadas(string nombreProductor)
        {
            cmbVariedades.Items.Clear();
            try
            {
                foreach (var item in DevolverVariedadesHabilitadas(nombreProductor))
                {
                    cmbVariedades.Items.Add(item);
                }
            }catch { throw; }
            
        }
        public void MostrarLotesCultivoHabilitados(string nombreProductor)
        {
            cmbLotesCultivo.Items.Clear();
            try
            {
                foreach (var item in DevolverLotesCultivoHabilitados(nombreProductor))
                {
                    cmbLotesCultivo.Items.Add(item);
                }
            }catch { throw; }
            
        }
        public void MostrarCategoriasHabilitadas()
        {
            cmbCategorias.Items.Clear();
            try
            {
                foreach (var item in DevolverCategoriasHabilitadas())
                {
                    cmbCategorias.Items.Add(item);
                }
            }catch{ throw; }
            
        }
        public void MostrarPuertosHabilitados()
        {
           List<string> lista = ListarPuertosDisponibles().Except(DevolverPuertosRecepciones()).ToList();
            cmbPuertos.Items.Clear();
            cmbPuertos.Text = string.Empty;
            cmbPuertos.Items.AddRange(lista.ToArray());


        }
        public void MostrarPesosRecibidos(Recepcion recepcion)
        {

            dtgPesos.BeginInvoke((MethodInvoker)delegate
            {

                dtgPesos.Rows.Add(recepcion.FechaYHora, recepcion.Puerto,
                recepcion.Productor, recepcion.Variedad, recepcion.LoteCultivo,
                recepcion.Categoria,recepcion.LotePoscosecha, recepcion.Peso);
            });

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
            }
            catch { throw; }
            
        }
        public List<string> DevolverVariedadesHabilitadas(string nombreProductor)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Variedades.Where(e => e.Estado.Equals("habilitado") &&
                    e.Productor.Nombre.Equals(nombreProductor))
                        .Select(n => n.Nombre)
                        .ToList();
                }
            }catch { throw; }
            
        }
        public List<string> DevolverLotesCultivoHabilitados(string nombreProductor)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.LotesCultivos.Where(e => e.Estado.Equals("Habilitado") &&
                    e.Productor.Nombre.Equals(nombreProductor))
                    .Select(n => n.Nombre).ToList();
                }
            }
            catch { throw; }
            
        }
        public List<string> DevolverCategoriasHabilitadas()
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Categorias.Where(e => e.Estado.Equals("Habilitado"))
                        .Select(n => n.Nombre).ToList();
                }
            }
            catch { throw; }
            
        }
        public List<string> DevolverPuertosHabilitados()
        {
            List<string> lista = new List<string>();    
            try
            {
                var portnames = SerialPort.GetPortNames();

                foreach (string s in portnames)
                {
                    if (!PuertoOcupado2(s))
                    {
                        //bool encontrado = DevolverPuertosRecepciones().Contains(s);
                        //if (!encontrado)
                        //{
                            lista.Add(s);
                        //}
                            
                    }

                }
                return lista;
            }
            catch (Exception ex)
            {
                return lista;
            }
        }
        public List<string> DevolverPuertosRecepciones()
        {
            var lista = new List<string>();
            foreach (DataGridViewRow fila in dtgRecepciones.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    lista.Add(fila.Cells[0].Value.ToString());
                }

            }
            return lista;
        }
        public string DevolverInicialesProductor(string nombre)
        {
            try
            {
                using (var context = new SierraBlueDB())
                {
                    return context.Productores.Where(n => n.Nombre.Equals(nombre))
                    .Select(i => i.Iniciales)
                    .FirstOrDefault();
                }
            }
            catch {throw; }
            

        }
        public string DevolverInicialesVariedad(string nombre)
        {
            try
            {
                using (var context = new SierraBlueDB())
                {
                    return context.Variedades.Where(v => v.Nombre.Equals(nombre))
                    .Select(i => i.Iniciales)
                    .FirstOrDefault();
                }
            }catch { throw; }
            

        }
        public void InicializarRecepciones()
        {
            dtgRecepciones.Columns.Add("Puerto", "Puerto");
            dtgRecepciones.Columns.Add("Productor", "Productor");
            dtgRecepciones.Columns.Add("Variedad", "Variedad");
            dtgRecepciones.Columns.Add("LoteCultivo", "LoteCultivo");
            dtgRecepciones.Columns.Add("Categoría", "Categoría");
            dtgRecepciones.Columns.Add("Numeración", "Numeración");

            dtgPesos.Columns.Add("FechaHora", "FechaHora");
            dtgPesos.Columns.Add("Puerto", "Puerto");
            dtgPesos.Columns.Add("Productor", "Productor");
            dtgPesos.Columns.Add("Variedad", "Variedad");
            dtgPesos.Columns.Add("LoteCultivo", "LoteCultivo");
            dtgPesos.Columns.Add("Categoría", "Categoría");
            dtgPesos.Columns.Add("LotePoscosecha", "LotePoscosecha");
            dtgPesos.Columns.Add("Peso(kg)", "Peso(kg)");

        }
        public void AgregarRecepcion(Recepcion recepcion, string numeración)
        {
            try
            {
                if (!CamposVacios(recepcion.Productor, recepcion.Variedad, recepcion.LoteCultivo,
                recepcion.Categoria, recepcion.Puerto, numeración))
                {
                    dtgRecepciones.Rows.Add(recepcion.Puerto, recepcion.Productor,
                    recepcion.Variedad, recepcion.LoteCultivo, recepcion.Categoria, numeración);

                    SerialPort serialport = new SerialPort(recepcion.Puerto);
                    serialPorts.Add(serialport);
                    numeroLotes[serialport] = int.Parse(numeración);
                    recepcionesPorPuerto[serialport] = recepcion;
                }
            }
            catch { throw; }
            
            
        }
        public void GuardarRecepcionPesos(Recepcion recepcion)
        {
            try
            {
                using (var context = new SierraBlueDB())
                {
                    Recepcion recep = new Recepcion
                    {
                        Productor = recepcion.Productor,
                        Variedad = recepcion.Variedad,
                        LoteCultivo = recepcion.LoteCultivo,
                        LotePoscosecha = recepcion.LotePoscosecha,
                        Categoria = recepcion.Categoria,
                        Peso = recepcion.Peso,
                        FechaYHora = recepcion.FechaYHora,
                        Puerto = recepcion.Puerto
                    };
                    context.Recepciones.Add(recep);
                    context.SaveChanges();
                }
            }
            catch { throw; }
            
        }
        public void IniciarCapturaPesos()
        {
            try
            {
                foreach (SerialPort serialport in serialPorts)
                {
                    serialport.BaudRate = 9600;
                    serialport.DataReceived += SerialPort_DataReceived;
                    serialport.Open();
                }
            }
            catch
            {
                throw;
            }

        }
        public void DetenerCapturaPesos()
        {
            try
            {
                foreach (SerialPort serialport in serialPorts)
                {
                    serialport.Close();
                }

                serialPorts.Clear();
                numeroLotes = new Dictionary<SerialPort, int>();
                recepcionesPorPuerto = new Dictionary<SerialPort, Recepcion>();
            }
            catch
            {
                throw;
            }

        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(1000);
            SerialPort serialPort = (SerialPort)sender;
            string newData = serialPort.ReadExisting();

            recepcionesPorPuerto[serialPort].PesoTexto += newData;

            if (recepcionesPorPuerto[serialPort].PesoTexto.EndsWith("\r"))
            {
                try
                {
                    recepcionesPorPuerto[serialPort].PesoTexto = recepcionesPorPuerto[serialPort].PesoTexto.TrimStart('\r');
                    int crIndex = recepcionesPorPuerto[serialPort].PesoTexto.IndexOf('\r');
                    string data = recepcionesPorPuerto[serialPort].PesoTexto.Substring(1, crIndex - 1);

                    if (recepcionesPorPuerto.ContainsKey(serialPort))
                    {
                        recepcionesPorPuerto[serialPort].Peso = ObtenerSoloPeso2(recepcionesPorPuerto[serialPort].PesoTexto);
                        recepcionesPorPuerto[serialPort].FechaYHora = DateTime.Now;
                        recepcionesPorPuerto[serialPort].LotePoscosecha = recepcionesPorPuerto[serialPort].IncialesProductor
                            + StrPad(numeroLotes[serialPort].ToString())
                            + "-" + recepcionesPorPuerto[serialPort].InicialesVariedad;
                        var recep = recepcionesPorPuerto[serialPort];
                        MostrarPesosRecibidos(recep);
                        GuardarRecepcionPesos(recep);
                        numeroLotes[serialPort] = numeroLotes[serialPort] + 1;
                        recepcionesPorPuerto[serialPort].PesoTexto = recepcionesPorPuerto[serialPort].PesoTexto.Substring(crIndex + 1);
                        recepcionesPorPuerto[serialPort].PesoTexto = "";

                    }
                }
                catch
                {

                }


            }

        }
        public string StrPad(string input, bool padRight = false)
        {

            int length = 3;
            char paddingChar = '0';

            int inputLength = input.Length;

            if (length <= inputLength)
                return input;

            int paddingLength = length - inputLength;

            string padding = new string(paddingChar, paddingLength);

            return padRight ? input + padding : padding + input;
        }
        public bool CamposVacios(string productor,string variedad, string lote, string categoria,
            string puerto, string numeracion)
        {
            if(productor.Equals(string.Empty)|| variedad.Equals(string.Empty)|| lote.Equals(string.Empty)
                || categoria.Equals(string.Empty) ||puerto.Equals(string.Empty) || numeracion.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void GuardarPesos(Recepcion recepcion)
        {
            try
            {
                using (var context = new SierraBlueDB())
                {
                    Recepcion recep = new Recepcion
                    {
                        Productor = recepcion.Productor,
                        Variedad = recepcion.Variedad,
                        LoteCultivo = recepcion.LoteCultivo,
                        LotePoscosecha = recepcion.LotePoscosecha,
                        Categoria = recepcion.Categoria,
                        Peso = recepcion.Peso,
                        FechaYHora = recepcion.FechaYHora,
                        Puerto = recepcion.Puerto
                    };
                    context.Recepciones.Add(recep);
                    context.SaveChanges();
                }
            }
            catch { throw; }
            
        }

        public float ObtenerSoloPeso2(string texto)
        {
            texto = texto.Trim();
            string soloNumeros = string.Empty;

            string patron = @"^\d{1,3}\.\d{1,3} kg$";

            // Comprueba si la cadena coincide con el patrón
            if (Regex.IsMatch(texto, patron))
            {
                string nuevoString = texto.Substring(0, texto.Length - 2);
                soloNumeros = nuevoString.Replace('.', ',');
            }

            return float.Parse(soloNumeros);
        }
        public float ObtenerSoloPeso(string texto)
        {
            texto = texto.Trim();
            // Patrón de expresión regular para encontrar números decimales
            string patron = @"[-+]?\b\d+(\.\d+)?\b";
            string soloNumeros = string.Empty;

            // Encuentra todas las coincidencias en el texto
            MatchCollection coincidencias = Regex.Matches(texto, patron);


            // Concatena las coincidencias para obtener solo los números
            foreach (Match match in coincidencias)
            {
                if (match.Success)
                {
                    soloNumeros = string.Join("", coincidencias[match.Index]);
                }
            }
            soloNumeros = soloNumeros.Replace('.', ',');


            return float.Parse(soloNumeros);
        }
        public bool PuertoOcupado(string puerto)
        {
            try
            {
                using (SerialPort serialPort = new SerialPort(puerto))
                {
                    serialPort.Open();
                    //serialPort.Close();
                    if(serialPort.IsOpen)
                        return false;
                    else
                        return true;

                }
            }catch
            {
                return true;
            }

        }
        public bool PuertoOcupado2(string s)
        {
            SerialPort puerto = new SerialPort(s);
            try
            {
                puerto.Open();
                puerto.Close();
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                return true; // Si se produce una excepción, el puerto está en uso
            }
            catch (Exception)
            {
                return false; // Otro tipo de excepción, asumimos que el puerto no está en uso
            }
            finally
            {
                if (puerto.IsOpen)
                {
                    puerto.Close();
                }
            }


        }
        static List<string> ListarPuertosDisponibles()
        {
            List<string> lista = new List<string>();
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                string nombrePuerto = queryObj["Caption"].ToString();

                // Extraer el número del puerto de la cadena de la descripción
                int indiceInicio = nombrePuerto.IndexOf("(COM") + 4;
                int indiceFin = nombrePuerto.IndexOf(")", indiceInicio);
                string numeroPuerto = nombrePuerto.Substring(indiceInicio, indiceFin - indiceInicio);

                if (!PuertoEnUso(numeroPuerto))
                {
                    //Console.WriteLine("Puerto COM disponible: " + numeroPuerto);
                    lista.Add("COM"+numeroPuerto);
                }
            }

            using (var searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var obj=searcher2.Get();
            }


            return lista;
        }

        static bool PuertoEnUso(string numeroPuerto)
        {
            SerialPort serialPort = new SerialPort("COM" + numeroPuerto);

            try
            {
                serialPort.Open();
                serialPort.Close();
                return false; // Si se abre y cierra correctamente, el puerto no está en uso
            }
            catch (UnauthorizedAccessException)
            {
                return true; // Si se produce una excepción, el puerto está en uso
            }
            catch (Exception)
            {
                return false; // Otro tipo de excepción, asumimos que el puerto no está en uso
            }
            finally
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }

    }
}
