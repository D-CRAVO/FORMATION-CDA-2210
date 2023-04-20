using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLCities
{
    internal class WorkCity
    {
        private string workCityName;
        private string workCountryCode;

        public string WorkCityName { get { return workCityName; } set { workCityName = value; } }
        public string WorkCountryCode { get { return workCountryCode; } set { workCountryCode = value; } }

        public WorkCity(string _cityName, string _countryCode) 
        {
            workCityName = _cityName;
            workCountryCode = _countryCode;
        }
    }
}
