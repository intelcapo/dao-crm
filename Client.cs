//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.branch = new HashSet<branch>();
            this.Request = new HashSet<Request>();
        }
    
        public string cli_document { get; set; }
        public Nullable<int> kod_id { get; set; }
        public string cli_name { get; set; }
        public string cli_lastName { get; set; }
        public string cli_phone { get; set; }
        public string cli_cellPhone { get; set; }
        public Nullable<int> ea_id { get; set; }
        public Nullable<int> cty_id { get; set; }
        public Nullable<bool> cli_state { get; set; }
        public Nullable<System.DateTime> cli_registrationDate { get; set; }
        public string cli_email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<branch> branch { get; set; }
        public virtual Cities Cities { get; set; }
        public virtual EconomicActivity EconomicActivity { get; set; }
        public virtual kindOfDocument kindOfDocument { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
    }
}
