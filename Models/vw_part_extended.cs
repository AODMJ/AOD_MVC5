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
    
    public partial class vw_part_extended
    {
        public int part_id { get; set; }
        public string part_no { get; set; }
        public string part_desc { get; set; }
        public int subcategory_id { get; set; }
        public string subcategory_long_desc { get; set; }
        public string subcategory_short_desc { get; set; }
        public int index_id { get; set; }
        public string index_desc { get; set; }
        public Nullable<decimal> suggested_retail_price { get; set; }
        public Nullable<decimal> retail_price { get; set; }
        public int auto_package_id { get; set; }
        public int client_id { get; set; }
        public string image_name { get; set; }
        public Nullable<decimal> mechanical_hours { get; set; }
        public Nullable<decimal> paint_hours { get; set; }
        public Nullable<decimal> body_hours { get; set; }
        public int is_custom { get; set; }
    }
}