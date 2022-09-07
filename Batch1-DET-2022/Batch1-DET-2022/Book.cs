using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public Author author { get; set; }  //containment

        public override string ToString()
        {
            return $"Book[name={Name},Author={this.author.ToString()},price={Price},qty={Qty}";
        }
    }
}
