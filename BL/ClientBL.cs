using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClientBL
    {
        public static List<ClientDTO> GetClients()
        {
            try
            {

                using (DevelopmentTaskEntities db = new DevelopmentTaskEntities())
                {
                    return Converters.ClientConverters.GetListClientDTO(db.clients.ToList());

                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }
    


        public static void CreateClient(ClientDTO clientDTO)
        {
            try
            {
                using (DevelopmentTaskEntities db = new DevelopmentTaskEntities())
                {

                        clients clients = Converters.ClientConverters.GetClientDAL(clientDTO);
                        db.clients.Add(clients);
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
