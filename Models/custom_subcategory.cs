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
    
    public partial class custom_subcategory
    {
        public custom_subcategory()
        {
            this.custom_part = new HashSet<custom_part>();
        }
    
        public int custom_subcategory_id { get; set; }
        public int custom_category_id { get; set; }
        public int custom_company_id { get; set; }
        public string custom_subcategory_short_desc { get; set; }
        public string custom_subcategory_long_desc { get; set; }
        public int custom_subcategory_code { get; set; }
        public int custom_index_id { get; set; }
        public System.DateTime eff_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public int client_id { get; set; }
        public string row_eff_user_id { get; set; }
        public System.DateTime row_eff_date { get; set; }
    
        public virtual client client { get; set; }
        public virtual custom_category custom_category { get; set; }
        public virtual custom_company custom_company { get; set; }
        public virtual custom_index custom_index { get; set; }
        public virtual ICollection<custom_part> custom_part { get; set; }
    }
}
