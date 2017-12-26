using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL
{
    public interface IClient
    {
        bool addClient(Model.Client client);
        void deleteClient(List<Model.Client> clientList);
    }
}
