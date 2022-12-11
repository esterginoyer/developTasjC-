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
    public class ClientController : ApiController
    {
   
        [HttpGet]
        [Route("GetAllClient")]
        public IEnumerable<ClientDTO> Get()
        {
            try
            {
                return BL.ClientBL.GetClients();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

       
        [HttpPost]
        [Route("SaveClient")]
        public IHttpActionResult Post(ClientDTO clientDTO)
        {
            try
            {
                ClientBL.CreateClient(clientDTO);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

       
    }
}
