using EmpaquePesosSierraBlue.Model;
using EmpaquePesosSierraBlue.Views;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpaquePesosSierraBlue.Controllers
{
    internal class EmpaqueController
    {
        DataGridView dtgEmpaques;
        DataGridView dtgPesos;
        ComboBox cmbProductores;
        ComboBox cmbVariedades;
        ComboBox cmbPresentaciones;
        ComboBox cmbCalibres;
        ComboBox cmbClientes;
        ComboBox cmbPuertos;

        public Dictionary<SerialPort, Empaque> empaquesPorPuerto = new Dictionary<SerialPort, Empaque>();
        public List<SerialPort> serialPorts = new List<SerialPort>();
        public Dictionary<SerialPort, int> numeroLotes;

        public EmpaqueController(DataGridView dtgEmpaques, DataGridView dtgPesos,ComboBox cmbProductores,
            ComboBox cmbVariedades, ComboBox cmbPresentaciones, ComboBox cmbCalibres, ComboBox cmbClientes,
            ComboBox cmbPuertos)
        {
            this.dtgEmpaques = dtgEmpaques;
            this.dtgPesos = dtgPesos;
            this.cmbProductores = cmbProductores;
            this.cmbVariedades=cmbVariedades;
            this.cmbPresentaciones=cmbPresentaciones;
            this.cmbCalibres=cmbCalibres;
            this.cmbClientes = cmbClientes;
            this.cmbPuertos=cmbPuertos;
            numeroLotes = new Dictionary<SerialPort, int>();
        }
        public void MostrarPesosRecibidos(Empaque empaque)
        {

            dtgPesos.BeginInvoke((MethodInvoker)delegate
            {

                dtgPesos.Rows.Add(empaque.FechaYHora, empaque.Puerto,
                empaque.Productor, empaque.Variedad, empaque.Presentacion,
                empaque.Calibre, empaque.Cliente,empaque.LotePoscosecha, empaque.Peso);
            });

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
        public void MostrarVariedadesHabilitadas(string nombreProductor)
        {
            cmbVariedades.Items.Clear();
            try
            {
                foreach (var item in DevolverVariedadesHabilitadas(nombreProductor))
                {
                    cmbVariedades.Items.Add(item);
                }
            }catch(Exception) { throw; }
            
        }
        public void MostrarPresentacionesHabilitadas()
        {
            cmbPresentaciones.Items.Clear();
            try
            {
                foreach (var item in DevolverPresentacionesHabilitadas())
                {
                    cmbPresentaciones.Items.Add(item);
                }
            }catch(Exception) { throw; }    
            
        }
        public void MostrarCalibresHabilitados()
        {
            cmbCalibres.Items.Clear();
            try
            {
                foreach (var item in DevolverCalibresHabilitados())
                {
                    cmbCalibres.Items.Add(item);
                }
            }catch(Exception) { throw; }
            
        }
        public void MostrarClientessHabilitados()
        {
            cmbClientes.Items.Clear();
            try
            {
                foreach (var item in DevolverClientesHabilitados())
                {
                    cmbClientes.Items.Add(item);
                }
            }catch(Exception) { throw; }    
            
        }
        public void MostrarPuertosHabilitados()
        {
            try
            {
                List<string> lista = ListarPuertosDisponibles().Except(DevolverPuertosEmpaques()).ToList();
                cmbPuertos.Items.Clear();
                cmbPuertos.Text = string.Empty;
                cmbPuertos.Items.AddRange(lista.ToArray());
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
            }catch (Exception) { throw; }
            
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
            }catch(Exception) { throw; }
            
        }
        public List<string> DevolverPresentacionesHabilitadas()
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Presentaciones.Where(e => e.Estado.Equals("habilitado"))
                        .Select(n => n.Nombre)
                        .ToList();
                }
            }catch { throw; }
           
        }
        public List<string> DevolverCalibresHabilitados()
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Calibres.Where(e => e.Estado.Equals("habilitado"))
                        .Select(n => n.Nombre)
                        .ToList();
                }
            }catch(Exception) { throw; }
            
        }
        public List<string> DevolverClientesHabilitados()
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    return db.Clientes.Where(e => e.Estado.Equals("habilitado"))
                        .Select(n => n.Nombre)
                        .ToList();
                }
            }catch(Exception) { throw; }
            
        }
        public List<string> DevolverPuertosEmpaques()
        {
            var lista = new List<string>();
            foreach (DataGridViewRow fila in dtgEmpaques.Rows)
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
            }catch (Exception) { throw; }
            

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
        public void InicializarEmpaques()
        {
            dtgEmpaques.Columns.Add("Puerto", "Puerto");
            dtgEmpaques.Columns.Add("Productor", "Productor");
            dtgEmpaques.Columns.Add("Variedad", "Variedad");
            dtgEmpaques.Columns.Add("Presentación", "Presentación");
            dtgEmpaques.Columns.Add("Calibre","Calibre");
            dtgEmpaques.Columns.Add("Cliente", "Cliente");
            dtgEmpaques.Columns.Add("Numeración", "Numeración");

            dtgPesos.Columns.Add("FechaHora", "FechaHora");
            dtgPesos.Columns.Add("Puerto", "Puerto");
            dtgPesos.Columns.Add("Productor", "Productor");
            dtgPesos.Columns.Add("Variedad", "Variedad");
            dtgPesos.Columns.Add("Presentación", "Presentación");
            dtgPesos.Columns.Add("Calibre", "Calibre");
            dtgPesos.Columns.Add("Cliente", "Cliente");
            dtgPesos.Columns.Add("LotePoscosecha", "LotePoscosecha");
            dtgPesos.Columns.Add("Peso(kg)", "Peso(kg)");

        }
        public void AgregarEmpaque(Empaque empaque, string numeración)
        {
            if (!CamposVacios(empaque.Productor,empaque.Variedad,empaque.Presentacion,empaque.Calibre,
                empaque.Cliente,empaque.Puerto,numeración))
            {
                dtgEmpaques.Rows.Add(empaque.Puerto, empaque.Productor,
                empaque.Variedad, empaque.Presentacion, empaque.Calibre,
                empaque.Cliente,empaque.Puerto, numeración);

                SerialPort serialport = new SerialPort(empaque.Puerto);
                serialPorts.Add(serialport);
                numeroLotes[serialport] = int.Parse(numeración);
                empaquesPorPuerto[serialport] = empaque;
            }

        }
        public bool CamposVacios(string productor, string variedad, string presentacion, string calibre,
            string cliente, string puerto, string numeracion)
        {
            if (productor.Equals(string.Empty) || variedad.Equals(string.Empty) || presentacion.Equals(string.Empty)
                || calibre.Equals(string.Empty) || cliente.Equals(string.Empty) || puerto.Equals(string.Empty)
                || numeracion.Equals(string.Empty))
            {
                return true;
            }
            else
            {
                return false;
            }

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
            catch (Exception ex)
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
                empaquesPorPuerto= new Dictionary<SerialPort, Empaque>();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(1000);
            SerialPort serialPort = (SerialPort)sender;
            string newData = serialPort.ReadExisting();

            empaquesPorPuerto[serialPort].PesoTexto += newData;

            if (empaquesPorPuerto[serialPort].PesoTexto.EndsWith("\r"))
            {
                try
                {
                    empaquesPorPuerto[serialPort].PesoTexto = empaquesPorPuerto[serialPort].PesoTexto.TrimStart('\r');
                    int crIndex = empaquesPorPuerto[serialPort].PesoTexto.IndexOf('\r');
                    string data = empaquesPorPuerto[serialPort].PesoTexto.Substring(1, crIndex - 1);

                    if (empaquesPorPuerto.ContainsKey(serialPort))
                    {
                        empaquesPorPuerto[serialPort].Peso = ObtenerSoloPeso2(empaquesPorPuerto[serialPort].PesoTexto);
                        empaquesPorPuerto[serialPort].FechaYHora = DateTime.Now;
                        empaquesPorPuerto[serialPort].LotePoscosecha = empaquesPorPuerto[serialPort].InicialesProductor
                            + StrPad(numeroLotes[serialPort].ToString())
                            + "-" + empaquesPorPuerto[serialPort].InicialesVariedad;
                        var recep = empaquesPorPuerto[serialPort];
                        MostrarPesosRecibidos(recep);
                        GuardarEmpaquePesos(recep);
                        numeroLotes[serialPort] = numeroLotes[serialPort] + 1;
                        empaquesPorPuerto[serialPort].PesoTexto = empaquesPorPuerto[serialPort].PesoTexto.Substring(crIndex + 1);
                        empaquesPorPuerto[serialPort].PesoTexto = "";

                    }
                }
                catch (Exception ex)
                {
                   
                }


            }

        }
        public void GuardarEmpaquePesos(Empaque empaque)
        {
            try
            {
                using (var context = new SierraBlueDB())
                {
                    Empaque emp = new Empaque
                    {
                        Productor = empaque.Productor,
                        Variedad = empaque.Variedad,
                        LotePoscosecha = empaque.LotePoscosecha,
                        Calibre = empaque.Calibre,
                        Peso = empaque.Peso,
                        Presentacion = empaque.Presentacion,
                        FechaYHora = empaque.FechaYHora,
                        Puerto = empaque.Puerto
                    };
                    context.Empaques.Add(emp);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
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
                    lista.Add("COM" + numeroPuerto);
                }
            }

            using (var searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var obj = searcher2.Get();
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
