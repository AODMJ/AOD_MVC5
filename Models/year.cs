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
    
    public partial class year
    {
        public year()
        {
            this.auto_model = new HashSet<auto_model>();
            this.jobber_catalog = new HashSet<jobber_catalog>();
        }
    
        public int year_id { get; set; }
        public string year_desc { get; set; }
        public int year_code { get; set; }
        public System.DateTime eff_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public string row_eff_user_id { get; set; }
        public System.DateTime row_eff_date { get; set; }
    
        public virtual ICollection<auto_model> auto_model { get; set; }
        public virtual ICollection<jobber_catalog> jobber_catalog { get; set; }
    }
}
