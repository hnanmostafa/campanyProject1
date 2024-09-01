using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campany.data.Entity
{
    public class BaseEntity
    {
        public int id { get; set; }
        public DateTime creatAt { get; set; } = DateTime.Now;
        public bool isdeleted { get; set; }
    }
}
