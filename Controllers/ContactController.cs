using First_Checkpoint.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace First_Checkpoint.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        Entities Context;
        public ContactController()
        {
            Context = new Entities();
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View(Context.Contacts.ToList());
        }
        public ActionResult Create()
        {
            return View(new Contact());
        }
          [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> Create(Contact Model)
            {
                if (ModelState.IsValid) 
                {
                    Context.Contacts.Add(Model);
                    await Context.SaveChangesAsync();
                    return RedirectToAction("Create");
                }
                return View(Model);
            }







        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = Context.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Admins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = Context.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,Email,Message,PhoneNumber")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                Context.Entry(contact).State = EntityState.Modified;
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Admins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = Context.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = Context.Contacts.Find(id);
            Context.Contacts.Remove(contact);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}