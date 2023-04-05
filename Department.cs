using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSerialization
{
    [Serializable]
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Location { get; set; }
    }
}
