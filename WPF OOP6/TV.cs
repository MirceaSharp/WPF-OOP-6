using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP6
{
    class TV:ElectricAppliance
    {
        private int _imageSize;
        private int _herz;
        private int _channel;
        private bool _teletext;
        private int _volume;

        public int ImageSize { get; set; }
        public int Herz { get; set; }
        public int Channel { get; set; }
        public bool Teletext { get; set; }

        public int Volume { get; set; }




        public TV(string brand, string type, int herz, int imageSize, string image) : base(brand,type,image)
        {
            this.Brand = brand;
            this.Type = type;
            this.Herz = herz;
            this.ImageSize = imageSize;
            this.Image = image;
        }
        


    }
}
