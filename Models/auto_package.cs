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
    
    public partial class auto_package
    {
        public auto_package()
        {
            this.auto_package_custom_part_xref = new HashSet<auto_package_custom_part_xref>();
            this.auto_package_jobber_part_xref = new HashSet<auto_package_jobber_part_xref>();
            this.quotes = new HashSet<quote>();
        }
    
        public int auto_package_id { get; set; }
        public int auto_model_id { get; set; }
        public string auto_package_desc { get; set; }
        public int auto_package_code { get; set; }
        public System.DateTime eff_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public string row_eff_user_id { get; set; }
        public System.DateTime row_eff_date { get; set; }
    
        public virtual auto_model auto_model { get; set; }
        public virtual ICollection<auto_package_custom_part_xref> auto_package_custom_part_xref { get; set; }
        public virtual ICollection<auto_package_jobber_part_xref> auto_package_jobber_part_xref { get; set; }
        public virtual ICollection<quote> quotes { get; set; }
    }
}
