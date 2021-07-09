﻿using System;
using System.Collections.Generic;
using System.Text;
using Azami.Framework;
using Azami.Framework.DbHelper;
using DTO;

namespace DAL
{
    public sealed class UserDA : DALBase<User>
    {
        public UserDA(IConnectionHandler connectionHandler) : base(connectionHandler)
        {
        }
    }
}
