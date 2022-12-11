using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public class ClientConverters
    {
        public static List<ClientDTO> GetListClientDTO(List<DAL.clients> Clients)
        {
            if (Clients == null)
                return null;
            List<ClientDTO> clientDTO = new List<ClientDTO>();
            foreach (var client in Clients)
                clientDTO.Add(GetClientDTO(client));
            return clientDTO;
        }

        public static DAL.clients GetClientDAL(ClientDTO clientDTO)
        {
            if (clientDTO == null)
                return null;
            clients clients = new clients()
            {
                clientId = clientDTO.clientId,
                hebrew_name = clientDTO.hebrew_name,
                english_name = clientDTO.english_name,
                tz = clientDTO.tz,
                born_date =clientDTO.born_date,
                account_number = clientDTO.account_number,
                bank = clientDTO.bank,
                branch = clientDTO.branch,
                cityId = clientDTO.cityId  

            };
            return clients;
        }

        public static ClientDTO GetClientDTO(DAL.clients clientDAL)
        {
            if (clientDAL == null)
                return null;
            ClientDTO clientDTO = new ClientDTO()
            {
                clientId = clientDAL.clientId,
                hebrew_name = clientDAL.hebrew_name,
                english_name = clientDAL.english_name,
                tz = clientDAL.tz,
                born_date = clientDAL.born_date,
                account_number = clientDAL.account_number,
                bank = clientDAL.bank,
                branch = clientDAL.branch,
                cityId = clientDAL.cityId

            };
            return clientDTO;

        }
    }
}
