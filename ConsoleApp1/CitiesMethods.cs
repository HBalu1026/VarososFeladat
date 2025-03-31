using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class CitiesMethods
    {
        public List<City> Cityes = [];

        void LoadFromCSV(string path) => Cityes = File.ReadAllLines(path).Skip(1).Where(x => x.Contains("NaN")).Select(x => new City(x.Split(';'))).ToList();

        /// <summary>
        /// Elmenti a városok adatait CSV fájlba
        /// </summary>
        /// <param name="path">A megadott útvonalon lévő fájlba írja ki az adatokat</param>
        /// <param name="cities">A városok listája</param>
        /// <param name="charCode">A karakterkódolást határozzsa meg</param>
        void SaveToCSV(string path, List<City> cities, string charCode = "UTF-8")
        {

        }

        int CityCount() => Cityes.Count;

        /// <summary>
        /// Folyamatosan növekvő-e a megadott népességi adatok sorozata?
        /// </summary>
        /// <returns>true esetén igen</returns>
        bool IsContinuousGrowing(List<int> populationDatas)
        {

        }

        List<City> Top10City(int year)
        {
            return Cityes.OrderByDescending(x =>
            year == 2010 ? x.Y2010 :
            year == 2020 ? x.Y2020 :
            year == 2030 ? x.Y2030 :
            year == 2040 ? x.Y2040 :
            year == 2050 ? x.Y2050 :
            0).Where((x, i) => i <= 10).ToList();
        }
    }
}
