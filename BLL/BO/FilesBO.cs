using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Azami.Framework;
using Azami.Framework.DbHelper;
using Azami.Utility;
using DAL;
using DTO;
using Microsoft.AspNetCore.Http;

namespace BLL.BO
{
    public sealed class FilesBO : BusinessBase<Files>
    {
        public override bool Insert(IConnectionHandler connectionHandler, Files obj)
        {
            var da = new FilesDA(connectionHandler);
            return da.Insert(obj) > 0;
        }

        public override Files Get(IConnectionHandler connectionHandler, params object[] keys)
        {
            //var file = FileCacheManager.FileCache.GetItem(keys[0].ToString().ToInt());
            Files file = null;
            if (file == null)
            {
                file = base.Get(connectionHandler, keys);
                //if (file != null)
                //FileCacheManager.FileCache.AddItem(file);
            }
            return file;

        }

        public override bool Delete(IConnectionHandler connectionHandler, params object[] keys)
        {
            //FileCacheManager.FileCache.RemoveItem(keys[0].ToString().ToGuid());
            return base.Delete(connectionHandler, keys);
        }

        public Guid InsertFile(IConnectionHandler connectionHandler, Files file)
        {
            if (this.Insert(connectionHandler, file))
                return file.Id;
            return Guid.Empty;
        }

        public Guid Insert(IConnectionHandler connectionHandler, IFormFile file)
        {
            try
            {
                var picture = new byte[file.Length];
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyToAsync(memoryStream);
                    picture = memoryStream.ToArray();
                }

                var fileContent = new Files
                {
                    Context = picture,
                    ContentType = file.ContentType,
                    Extension = Path.GetExtension(file.FileName),
                    Title = Path.GetFileNameWithoutExtension(file.FileName),

                };

                return base.Insert(connectionHandler, fileContent) ? fileContent.Id : Guid.Empty;
            }

            catch (KnownException knownException)
            {
                throw new KnownException(knownException.Message, knownException);
            }
            catch (Exception ex)
            {
                throw new KnownException(ex.Message, ex);
            }

        }
        public Guid Insert(IConnectionHandler connectionHandler, IFormFile file, Files fileoptions)
        {
            try
            {

                var picture = new byte[file.Length];
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyToAsync(memoryStream);
                    picture = memoryStream.ToArray();
                }
                fileoptions.Context = picture;
                fileoptions.ContentType = file.ContentType;
                fileoptions.Extension = Path.GetExtension(file.FileName);
                if (string.IsNullOrEmpty(fileoptions.Title))
                    fileoptions.Title = Path.GetFileNameWithoutExtension(file.FileName);
                fileoptions.CreateDate = DateTime.Now;
                fileoptions.Size = picture.Length / 1024;
                fileoptions.Id = Guid.NewGuid();

                if (!base.Insert(connectionHandler, fileoptions))
                    throw new KnownException("Error In Saving File");
                return fileoptions.Id;

            }
            catch (KnownException knownException)
            {
                throw new KnownException(knownException.Message, knownException);
            }
            catch (Exception ex)
            {
                throw new KnownException(ex.Message, ex);
            }

        }



        public override bool Update(IConnectionHandler connectionHandler, Files obj)
        {
            var da = new FilesDA(connectionHandler);
            if (da.Update(obj) <= 0) return false;
            //FileCacheManager.FileCache.RemoveItem(obj.Id);
            return true;
        }

        protected override void CheckConstraint(IConnectionHandler connectionHandler, Files item)
        {
            if (item.Size > 150)
                throw new KnownException("The maximum size of the photo is 150 KB");
            base.CheckConstraint(connectionHandler, item);
        }
    }
}
