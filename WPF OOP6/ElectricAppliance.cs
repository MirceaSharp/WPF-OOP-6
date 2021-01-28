using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP6
{
    class ElectricAppliance
    {
        private string _image;
        private string _brand;
        private bool _power;
        private string _type;

        public string Image { get; set; }
        public string Brand { get; set; }
        public bool Power { get; set; }
        public string Type { get; set; }




        public ElectricAppliance(string brand, string type, string image)
        {
            this.Brand = brand;
            this.Type = type;
            this.Image = image;

        }
        public override string ToString()
        {
            return base.ToString();
        }



    }
}
