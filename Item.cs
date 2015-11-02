using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Item
    {
        public string Name { get; set; }

        public Item(){ }

        public override string ToString()
        {
            return Name;
        }
    }
}
