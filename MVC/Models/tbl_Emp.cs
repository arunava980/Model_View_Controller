//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Emp
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        public virtual tbl_Dept tbl_Dept { get; set; }
    }
}