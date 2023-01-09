using First_Checkpoint.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using File = First_Checkpoint.Models.File;

namespace First_Checkpoint.Controllers
{
    [Authorize]
    public class ImageController : Controller
    {
        /* // GET: Image
         public ActionResult Index()
         {
             return View();
         }
         [HttpGet]
         public ActionResult UploadImages()
         {
             return View();
         }

         [HttpPost]

         public ActionResult UploadImages(HttpPostedFileBase uploadFile)
         {
             Entities ODB = new Entities(); // DbContext  

             //File objfiletb = new File(); // object of table  
             File objfiletb = new File();

             HttpPostedFileBase httpobj = Request.Files["file"];

             string[] Filename = httpobj.FileName.Split('.');  //Spliting Image Name to Get FileName  

             objfiletb.FileId = 0;
             objfiletb.FileName = Filename[0];

             using (Stream inputStream = Request.Files[0].InputStream) //File Stream which is Uploaded  
             {
                 MemoryStream memoryStream = inputStream as MemoryStream;
                 if (memoryStream == null)
                 {
                     memoryStream = new MemoryStream();
                     inputStream.CopyTo(memoryStream);
                 }
                 objfiletb.Filebytes = memoryStream.ToArray();
             }

             ODB.Files.Add(objfiletb);
             ODB.SaveChanges(); //Inserting Image and details in Database  
             return RedirectToAction("ShowImages");
         }

         [HttpGet]
         public ActionResult ShowImages()
         {
             Entities ODB = new Entities(); //DBcontext class   
             var listofpic = ODB.Files.ToList(); // Get List of images stored in FileTB table  
             return View(listofpic);
         }*/



        // GET: Posts/Create
      /*  public ActionResult Create()
        {
            return View();
        }
        Entities ODB = new Entities();
        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FileId,FileName,Filebytes")] File file)
        {
            if (ModelState.IsValid)
            {
                ODB.Files.Add(file);
                ODB.SaveChanges();
                return RedirectToAction("UploadImages");
            }

            return View(file);
        }

        */







        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UploadImages()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadImages(HttpPostedFileBase uploadFile)
        {
            try
            {
                Entities ODB = new Entities(); // DbContext  
                File objfiletb = new File(); // object of table  
                HttpPostedFileBase httpobj = Request.Files["file"];
                string[] Filename = httpobj.FileName.Split('.'); //Spliting Image Name to Get FileName  
                objfiletb.FileId = 0;
                objfiletb.FileName = Filename[0];
                using (Stream inputStream = Request.Files[0].InputStream) //File Stream which is Uploaded  
                {
                    MemoryStream memoryStream = inputStream as MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new MemoryStream();
                        inputStream.CopyTo(memoryStream);
                    }
                    objfiletb.Filebytes = memoryStream.ToArray();
                }
                ODB.Files.Add(objfiletb);
                ODB.SaveChanges(); //Inserting Image in Database  
                TempData["Message"] = "Data Saved Successfully";
                return RedirectToAction("ShowImages");
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public ActionResult ShowImages()
        {
            Entities ODB = new Entities(); //DBcontext class   
            var listofpic = ODB.Files.ToList(); // Get List of images stored in FileTB table  
            return View(listofpic);
            return RedirectToAction("UploadImages");
        }
    }
}