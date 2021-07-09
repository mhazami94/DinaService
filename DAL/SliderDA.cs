using Azami.Framework;
using Azami.Framework.DbHelper;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public sealed class SliderDA : DALBase<Slider>
    {
        public SliderDA(IConnectionHandler connectionHandler) : base(connectionHandler)
        {
        }
    }
}
