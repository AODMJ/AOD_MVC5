//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AOD_MVC5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class client_auto_make_xref
    {
        public int client_auto_make_xref_id { get; set; }
        public int client_id { get; set; }
        public int auto_make_id { get; set; }
        public bool is_selected { get; set; }
        public System.DateTime eff_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public string row_eff_user_id { get; set; }
        public System.DateTime row_eff_date { get; set; }
    
        public virtual auto_make auto_make { get; set; }
        public virtual client client { get; set; }
    }
}
