using BLL.BO;
using BLL.Interfaces;
using DTO;
using DTO.Tools;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Facade
{
    public sealed class ArticleFacade : DinaServiceBaseFacade<Article>, IArticleFacade
    {
        public void AddView(int id)
        {
            var blog = base.Get(id);
            blog.Views++;
            //this.Update(blog, null);
        }

        public bool Delete(int id)
        {
            base.ConnectionHandler.StartTransaction(IsolationLevel.ReadUncommitted);
            var fileBO = new FilesBO();
            var blogBO = new ArticleBO();
            try
            {
                var cat = blogBO.Get(base.ConnectionHandler, id);
                //if (cat.ImageId != 0)
                //    if (!fileBO.Delete(base.ConnectionHandler, cat.ImageId))
                //        throw new Exception("Error in deleting");



                if (!blogBO.Delete(base.ConnectionHandler, cat))
                    throw new Exception("Error in deleting");

                base.ConnectionHandler.CommitTransaction();
                return true;

            }
            catch (Exception ex)
            {
                base.ConnectionHandler.RollBack();
                throw new Exception(ex.Message, ex);
            }
        }



        public async Task<bool> InsertAsync(Article blog, IFormFile fileId)
        {
            base.ConnectionHandler.StartTransaction(IsolationLevel.ReadUncommitted);
            try
            {
                var fileBO = new FilesBO();
                var blogBO = new ArticleBO();
                var url = blog.Url.StartsWith('/') ? blog.Url : $"/{blog.Url}";
                var getUrl = await this.FirstOrDefaultAsync(x => x.Url == url);
                if (getUrl != null)
                    throw new Exception("There is an article with this Url");

                await Task.Run(() =>
                {
                    if (fileId != null)
                    {
                        var file = new Files()
                        {
                        };
                        var imageId = fileBO.Insert(base.ConnectionHandler, fileId, file);
                        if (imageId == Guid.Empty)
                        {
                            throw new Exception("Error In Registration");
                        }
                        blog.ImageId = imageId;
                    }
                });


                blog.RegisterDate = DateTime.Now;

                if (!await blogBO.InsertAsync(base.ConnectionHandler, blog))
                {
                    throw new Exception("Error In Registration");
                }
                base.ConnectionHandler.CommitTransaction();
                return true;

            }
            catch (Exception ex)
            {
                base.ConnectionHandler.RollBack();
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Article>> SearchBlog(Expression<Func<Article, bool>> expression)
        {
            return await new ArticleBO().SearchBlog(ConnectionHandler, expression);
        }

        public bool Update(Article blog, IFormFile fileId)
        {
            base.ConnectionHandler.StartTransaction(IsolationLevel.ReadUncommitted);
            var fileBO = new FilesBO();
            var oldObj = new ArticleBO().Get(base.ConnectionHandler, blog.Id);

            try
            {
                //if (fileId != null)
                //{
                //    var file = new File();

                //    if (oldObj.ImageId != 0)
                //        if (!fileBO.Delete(base.ConnectionHandler, oldObj.ImageId))
                //            throw new Exception("Error in Reistration");
                //    var imageId = fileBO.Insert(base.ConnectionHandler, fileId, file);
                //    if (imageId ==0)
                //        throw new Exception("Error in Reistration");

                //    oldObj.ImageId = imageId;
                //}



                oldObj.Title = blog.Title;
                oldObj.Abstract = blog.Abstract.FixTextEditorOutput();
                oldObj.Context = blog.Context.FixTextEditorOutput();
                oldObj.Order = blog.Order;
                oldObj.Views = blog.Views;
                oldObj.PageTitle = blog.PageTitle;
                oldObj.MetaDescription = blog.MetaDescription;
                oldObj.Publish = blog.Publish;

                if (!new ArticleBO().Update(base.ConnectionHandler, oldObj))
                    throw new Exception("Error in Reistration");

                base.ConnectionHandler.CommitTransaction();
                return true;

            }
            catch (Exception ex)
            {
                base.ConnectionHandler.RollBack();
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateAsync(Article blog, IFormFile fileId)
        {
            base.ConnectionHandler.StartTransaction(IsolationLevel.ReadUncommitted);

            var fileBO = new FilesBO();
            var blogBO = new ArticleBO();

            var oldObj = await blogBO.GetAsync(base.ConnectionHandler, blog.Id);

            try
            {
                await Task.Run(() =>
                {
                    if (fileId != null)
                    {
                        var file = new Files();
                        if (oldObj.ImageId != null && oldObj.ImageId != Guid.Empty)
                            if (!fileBO.Delete(base.ConnectionHandler, oldObj.ImageId))
                                throw new Exception("Error in Reistration");
                        var imageId = fileBO.Insert(base.ConnectionHandler, fileId, file);
                        if (imageId == Guid.Empty)
                            throw new Exception("Error in Reistration");

                        oldObj.ImageId = imageId;
                    }
                });

                oldObj.Title = blog.Title;
                oldObj.Abstract = blog.Abstract.FixTextEditorOutput();
                oldObj.Context = blog.Context.FixTextEditorOutput();
                oldObj.Order = blog.Order;
                oldObj.Views = blog.Views;
                oldObj.PageTitle = blog.PageTitle;
                oldObj.MetaDescription = blog.MetaDescription;
                oldObj.Publish = blog.Publish;

                if (!await blogBO.UpdateAsync(base.ConnectionHandler, oldObj))
                    throw new Exception("Error in Reistration");

                base.ConnectionHandler.CommitTransaction();
                return true;

            }
            catch (Exception ex)
            {
                base.ConnectionHandler.RollBack();
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
