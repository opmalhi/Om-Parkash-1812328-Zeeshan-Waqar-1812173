//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FYP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FamousPlace
    {
        public int Place_ID { get; set; }
        public int City_ID { get; set; }
        public string Place_Name { get; set; }
        public string Place_Pic1 { get; set; }
        public string Place_Pic2 { get; set; }
        public string Place_Pic3 { get; set; }
        public string Place_Pic4 { get; set; }
        public string Place_Details { get; set; }
    
        public virtual City City { get; set; }
    }
}
