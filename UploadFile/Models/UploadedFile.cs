using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UploadFile.Models
{
    public class UploadedFile
    {
        public string Filename { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }
    }
}