using BLL.BO;
using BLL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Facade
{
    public sealed class UserFacade : DinaServiceBaseFacade<Users>, IUserFacade
    {
        public Users Login(string username, string password)
        {
            return new UserBO().Login(base.ConnectionHandler, username, password);
        }
        public override Users Get(params object[] keys)
        {
            return new UserBO().Get(ConnectionHandler, keys);
        }

    }
}
