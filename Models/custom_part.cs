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
    
    public partial class custom_part
    {
        public custom_part()
        {
            this.auto_package_custom_part_xref = new HashSet<auto_package_custom_part_xref>();
            this.quote_jobber_part_xref = new HashSet<quote_jobber_part_xref>();
        }
    
        public int custom_part_id { get; set; }
        public int custom_subcategory_id { get; set; }
        public string custom_part_desc { get; set; }
        public string custom_part_no { get; set; }
        public System.DateTime eff_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public int custom_image_id { get; set; }
        public string row_eff_user_id { get; set; }
        public System.DateTime row_eff_date { get; set; }
        public Nullable<decimal> suggested_retail_price { get; set; }
        public int client_id { get; set; }
        public Nullable<decimal> mechanical_hours { get; set; }
        public Nullable<decimal> body_hours { get; set; }
        public Nullable<decimal> paint_hours { get; set; }
    
        public virtual ICollection<auto_package_custom_part_xref> auto_package_custom_part_xref { get; set; }
        public virtual client client { get; set; }
        public virtual custom_image custom_image { get; set; }
        public virtual custom_subcategory custom_subcategory { get; set; }
        public virtual ICollection<quote_jobber_part_xref> quote_jobber_part_xref { get; set; }
    }
}
