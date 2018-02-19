using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using UploadFile.Models;

namespace UploadFile.BusinessLogic
{
    public class UploadedFileLogic
    {
        public bool CheckFileNameCorrectLength(string fileName)
        {
            return fileName.Length < 20;
        }

        public UploadedFile Createmodel(HttpPostedFileBase photo)
        {
           
             UploadedFile file = new UploadedFile()
             {
                 FileExtension = Path.GetExtension(photo.FileName),
                 Filename = Path.GetFileName(photo.FileName),
                 FileSize = photo.ContentLength
             };
             return file;
        }
    }
}