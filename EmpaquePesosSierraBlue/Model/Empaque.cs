//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpaquePesosSierraBlue.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Empaque
    {
        public int Id { get; set; }
        public System.DateTime FechaYHora { get; set; }
        public string Puerto { get; set; }
        public string Productor { get; set; }
        public string Variedad { get; set; }
        public string LotePoscosecha { get; set; }
        public string Presentacion { get; set; }
        public string Calibre { get; set; }
        public string Cliente { get; set; }
        public float Peso { get; set; }
        [NotMapped]
        public string InicialesProductor { get; set; }
        [NotMapped]
        public string InicialesVariedad { get; set; }
        [NotMapped]
        public string PesoTexto { get; set; }
    }
}