using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadFile.BusinessLogic;
using UploadFile.Models;

namespace UploadFile.Controllers
{
    public class UploadController : Controller
    {
        private readonly UploadedFileLogic _fileLogic;
        public UploadController()
        {
             _fileLogic= new  UploadedFileLogic();
        }

        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        // GET: Upload/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Upload/Create
        public ActionResult UploadFile()
        {
            return View("~/Views/Upload/UploadFile.cshtml");
        }
        [HttpPost]
        // POST: Upload/Create
        public ActionResult UploadFile(HttpPostedFileBase photo)
        {

            //sprawdzammy czy wczytany plik nie jest pusty
            if (photo != null)
                if (_fileLogic.CheckFileNameCorrectLength(Path.GetFileName(photo.FileName)))
                {
                    
                    return View("FileInfo", _fileLogic.Createmodel(photo));
                }
               
            return View("FileNameTooLong");
        }
        // GET: Upload/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Upload/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Upload/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Upload/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
