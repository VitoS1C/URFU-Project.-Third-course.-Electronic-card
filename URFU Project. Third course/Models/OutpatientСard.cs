using System;
using System.ComponentModel.DataAnnotations;

namespace URFU_Project._Third_course.Models
{
    internal class OutpatientСard
    {
       
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string Complaints { get; set; }
        public string Anamnesis { get; set; }
        public string ObjectiveData { get; set; }
        public string Diagnosis { get; set; }
        public string Therapy { get; set; }

    }
}
