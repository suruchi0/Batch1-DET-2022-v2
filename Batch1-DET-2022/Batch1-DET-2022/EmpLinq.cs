using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class EmpLinq
    {
        public EmpLinq()
        {
            

        }

        public EmpLinq(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    }
}
