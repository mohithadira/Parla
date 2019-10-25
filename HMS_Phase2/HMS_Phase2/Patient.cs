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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Billings = new HashSet<Billing>();
            this.Labs = new HashSet<Lab>();
            this.Treatments = new HashSet<Treatment>();
        }
    
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> PatientAge { get; set; }
        public Nullable<int> PatientWeight { get; set; }
        public string PatientGender { get; set; }
        public string PatientAddress { get; set; }
        public string PatientContact { get; set; }
        public string PatientDisease { get; set; }
        public string DoctorId { get; set; }
        public string PatientType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing> Billings { get; set; }
        public virtual doctor doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lab> Labs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}