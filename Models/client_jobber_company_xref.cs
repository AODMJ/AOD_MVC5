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
    
    public partial class client_jobber_company_xref
    {
        public client_jobber_company_xref()
        {
            this.client_jobber_company_xref_jobber_part_xref = new HashSet<client_jobber_company_xref_jobber_part_xref>();
        }
    
        public int client_jobber_company_xref_id { get; set; }
        public int client_id { get; set; }
        public int jobber_company_id { get; set; }
        public System.DateTime eff_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public string row_eff_user_id { get; set; }
        public System.DateTime row_eff_date { get; set; }
    
        public virtual client client { get; set; }
        public virtual jobber_company jobber_company { get; set; }
        public virtual ICollection<client_jobber_company_xref_jobber_part_xref> client_jobber_company_xref_jobber_part_xref { get; set; }
    }
}