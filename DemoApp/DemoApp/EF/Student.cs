//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoApp.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<float> Cgpa { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
