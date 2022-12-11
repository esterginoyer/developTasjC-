using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CitiesBL
    {
        public static List<CityDTO> GetCities()
        {
            try
            {

                using (DevelopmentTaskEntities db = new DevelopmentTaskEntities())
                {
                    return Converters.CityConverters.GetListCitiesDTO(db.cities.ToList());

                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }



        public static void SaveCities(List<CityDTO> cityDTO)
        {
            try
            {
                using (DevelopmentTaskEntities db = new DevelopmentTaskEntities())
                {

                    cities cities = Converters.CityConverters.GetListCitiesDAL(cityDTO.ToList());
                    db.cities.Add(cities);
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
