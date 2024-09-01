using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campany.data.Entity
{
    public class Employee : BaseEntity
    {
     
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public decimal salary { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime hiringdate { get; set; }
        public string imageUrl { get; set; }
        public Department department { get; set; } 
        public int? departmentId { get; set; }






    }
}
