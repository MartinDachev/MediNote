//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    
    public partial class spGetMedicalNoteByID_Result
    {
        public int ID { get; set; }
        public int DoctorID { get; set; }
        public int StudentID { get; set; }
        public int InstitutionID { get; set; }
        public string MEN { get; set; }
        public System.DateTime VisitDate { get; set; }
        public string Diagnose { get; set; }
        public string Needs { get; set; }
    }
}
