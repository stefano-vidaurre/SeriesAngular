//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeriesAngularDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comentarios
    {
        public int idcomment { get; set; }
        public int iduser { get; set; }
        public int idserie { get; set; }
        public string comment { get; set; }
        public Nullable<System.DateTime> commentdate { get; set; }
    
        public virtual Series Series { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
