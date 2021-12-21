using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Azami.Framework;
using Azami.Framework.DbHelper;
using DTO;

namespace BLL.BO
{
    public sealed class ArticleBO : BusinessBase<Article>
    {
        protected override void CheckConstraint(IConnectionHandler connectionHandler, Article item)
        {
            if (string.IsNullOrEmpty(item.Title))
                throw new KnownException("Please insert title");
            if (string.IsNullOrEmpty(item.Abstract))
                throw new KnownException("Please insert abstract");
            base.CheckConstraint(connectionHandler, item);
        }
        public async Task<List<Article>> SearchBlog(IConnectionHandler connectionHandler, Expression<Func<Article, bool>> expression, bool simpleload = false)
        {
            var result = await base.WhereAsync(connectionHandler, expression);
            return result;
        }

    }
}
