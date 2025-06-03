using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class MedicineInfo
    {
        
   public string MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineCount { get; set; }
        public string MedicinePrice { get; set; }
        public string ExpiryDate { get; set; }

    }
}