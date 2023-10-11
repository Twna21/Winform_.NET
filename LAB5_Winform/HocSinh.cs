using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_Winform
{
    internal class HocSinh
    {
        private string name;

        private double toan;
        private double ly;
        private double hoa;

        public HocSinh()
        {
        }

        public HocSinh(string name, double toan, double ly, double hoa)
        {
            this.Name = name;
            this.Toan = toan;
            this.Ly = ly;
            this.Hoa = hoa;
        }

        public string Name { get => name; set => name = value; }
        public double Toan { get => toan; set => toan = value; }
        public double Ly { get => ly; set => ly = value; }
        public double Hoa { get => hoa; set => hoa = value; }

        public override string? ToString()
        {
            return $"{Name} + {Toan,2} + {Ly,2} + {Hoa,2}";
        }
    }
  
}
