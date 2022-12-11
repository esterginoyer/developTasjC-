using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public class CityConverters
    {
        public static List<CityDTO> GetListCitiesDTO(List<DAL.cities> Cities)
        {
            if (Cities == null)
                return null;
            List<CityDTO> cityDTO = new List<CityDTO>();
            foreach (var city in Cities)
                cityDTO.Add(GetCityDTO(city));
            return cityDTO;
        }

        public static List<DAL.cities> GetListCitiesDAL(List<CityDTO> cityDTO)
        {
            if (cityDTO == null)
                return null;
            List<DAL.cities> Cities = new List<DAL.cities>();
            foreach (var city in cityDTO)
                Cities.Add(GetCityDAL(city));
            return Cities;
        }
        public static DAL.cities GetCityDAL(CityDTO cityDTO)
        {
            if (cityDTO == null)
                return null;
            cities cities = new cities()
            {
                city_code = cityDTO.city_code,
                city_name = cityDTO.city_name,
                

            };
            return cities;
        }

        public static CityDTO GetCityDTO(DAL.cities cityDAL)
        {
            if (cityDAL == null)
                return null;
            CityDTO cityDTO = new CityDTO()
            {
                city_code = cityDAL.city_code,
                city_name = cityDAL.city_name,

            };
            return cityDTO;

        }

    }
}
