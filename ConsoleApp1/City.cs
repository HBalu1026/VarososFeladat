using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class City
    {
        string city_code, city_name;
        int y2010, y2020, y2030, y2040, y2050;

        public City(string[] cityes)
        {
            this.city_code = cityes[0];
            this.city_name = cityes[1];
            this.y2010 = int.Parse(cityes[2]);
            this.y2020 = int.Parse(cityes[3]);
            this.y2030 = int.Parse(cityes[4]);
            this.y2040 = int.Parse(cityes[5]);
            this.y2050 = int.Parse(cityes[6]);
        }

        public string City_code { get => city_code; }
        public string City_name { get => city_name; }
        public int Y2010 { get => y2010; }
        public int Y2020 { get => y2020; }
        public int Y2030 { get => y2030; }
        public int Y2040 { get => y2040; }
        public int Y2050 { get => y2050; }
    }
}
