using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasifProject.Model
{
    class Car
    {
        public int Id { get; set; }
        public string Name  { get; set; }

        public float Price  { get; set; }

        public List<Order> Orders { get; set; }
        public bool State { get; set; }


    }
}
