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
    
    public partial class Recepcion
    {
        public int Id { get; set; }
        public System.DateTime FechaYHora { get; set; }
        public string Puerto { get; set; }
        public string Productor { get; set; }
        public string Variedad { get; set; }
        public string LoteCultivo { get; set; }
        public string LotePoscosecha { get; set; }
        public string Categoria { get; set; }
        public float Peso { get; set; }
    }
}