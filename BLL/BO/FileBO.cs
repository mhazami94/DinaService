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
    public sealed class FileBO : BusinessBase<DTO.File>
    {
        public override bool Insert(IConnectionHandler connectionHandler, DTO.File obj)
        {
            var da = new FileDA(connectionHandler);
            return da.Insert(obj) > 0;
        }

        public override DTO.File Get(IConnectionHandler connectionHandler, params object[] keys)
        {
            //var file = FileCacheManager.FileCache.GetItem(keys[0].ToString().ToInt());
            DTO.File file = null;
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

        public int InsertFile(IConnectionHandler connectionHandler, DTO.File file)
        {
            if (this.Insert(connectionHandler, file))
                return file.Id;
            return 0;
        }

        public int Insert(IConnectionHandler connectionHandler, IFormFile file)
        {
            try
            {
                var picture = new byte[file.Length];
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyToAsync(memoryStream);
                    picture = memoryStream.ToArray();
                }

                var fileContent = new DTO.File
                {
                    Content = picture,
                    ContentType = file.ContentType,
                    Extension = Path.GetExtension(file.FileName),
                    Name = Path.GetFileNameWithoutExtension(file.FileName),

                };

                return base.Insert(connectionHandler, fileContent) ? fileContent.Id : 0;
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
        public int Insert(IConnectionHandler connectionHandler, IFormFile file, DTO.File fileoptions)
        {
            try
            {

                var picture = new byte[file.Length];
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyToAsync(memoryStream);
                    picture = memoryStream.ToArray();
                }
                fileoptions.Content = picture;
                fileoptions.ContentType = file.ContentType;
                fileoptions.Extension = Path.GetExtension(file.FileName);
                if (string.IsNullOrEmpty(fileoptions.Name))
                    fileoptions.Name = Path.GetFileNameWithoutExtension(file.FileName);
                fileoptions.CreateDate = DateTime.Now;
                fileoptions.Size = picture.Length / 1024;

                if (!this.Insert(connectionHandler, fileoptions))
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



        public override bool Update(IConnectionHandler connectionHandler, DTO.File obj)
        {
            var da = new FileDA(connectionHandler);
            if (da.Update(obj) <= 0) return false;
            //FileCacheManager.FileCache.RemoveItem(obj.Id);
            return true;
        }

        protected override void CheckConstraint(IConnectionHandler connectionHandler, DTO.File item)
        {
            if (item.Size > 150)
                throw new KnownException("The maximum size of the photo is 150 KB");
            base.CheckConstraint(connectionHandler, item);
        }
    }
}
