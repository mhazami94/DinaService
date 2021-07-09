using Azami.Framework;
using Azami.Framework.DbHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public abstract class DinaServiceBaseFacade<T> : BaseFacade<T> where T : class
    {
        protected DinaServiceBaseFacade()
         : base(new DinaServiceConnectionHandler(), false)
        {

        }
        protected DinaServiceBaseFacade(IConnectionHandler connectionHandler)
            : base(connectionHandler)
        {

        }
    }
    public class DinaServiceConnectionHandler : ConnectionHandler
    {
        public DinaServiceConnectionHandler()
        {
            base.ConnectionString = DinaServiceComponent.ConnectionString;
        }

    }
}
