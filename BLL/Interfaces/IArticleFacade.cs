using Azami.Framework;
using DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IArticleFacade : IBaseFacade<Article>
    {
        bool Update(Article blog, IFormFile image);

        bool Delete(int id);
        Task<bool> InsertAsync(Article blog, IFormFile image);
        void AddView(int id);
        Task<List<Article>> SearchBlog(Expression<Func<Article, bool>> expression);
        Task<bool> UpdateAsync(Article blog, IFormFile image);
    }
}
