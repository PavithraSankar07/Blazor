using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore.Models
{
    public class OrderInfo
    {
        
    public string OrderID { get; set; }
        public string MedicineName { get; set; }
        public string MedicineID { get; set; }
        public string UserID { get; set; }
        public string TotalPrice { get; set; }
        public string MedicineCount { get; set; }
        public string PurchaseStatus { get; set; }
        public DateTime OrderDate { get; set; }

    }
}