using Azami.Framework;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IUserFacade : IBaseFacade<Users>
    {
        Users Login(string username, string password);
    }
}
