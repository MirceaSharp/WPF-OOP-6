using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP6
{
    class Boiler:ElectricAppliance
    {
        private decimal _capacity;
        public decimal Capacity { get; set; }
        public Boiler(string brand, string type, string image, decimal capacity ):base(brand,type,image)
        {
            this.Brand = brand;
            this.Type = type;
            this.Image = image;
            this.Capacity = capacity;

        }



    }
}
