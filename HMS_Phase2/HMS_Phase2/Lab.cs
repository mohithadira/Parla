//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS_Phase2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lab()
        {
            this.Treatments = new HashSet<Treatment>();
        }
    
        public string LabId { get; set; }
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public Nullable<System.DateTime> TestDate { get; set; }
        public string TestType { get; set; }
        public string PatientType { get; set; }
    
        public virtual doctor doctor { get; set; }
        public virtual Patient Patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}