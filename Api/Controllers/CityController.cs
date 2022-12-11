using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("api/Client")]
    public class CityController : ApiController
    {
   
        [HttpGet]
        [Route("GetAllCity")]
        public IEnumerable<CityDTO> Get()
        {
            try
            {
                return BL.CitiesBL.GetCities();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

       
        [HttpPost]
        [Route("SaveAllCities")]

        public IHttpActionResult Post(List<CityDTO> cityDTO)
        {
            try
            {
                CitiesBL.SaveCities(cityDTO);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
