using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NerdsOnWheels.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace NerdsOnWheels.Controllers
{
    public class TechniciansController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        protected UserManager<ApplicationUser> UserManager { get; set; }



        // GET: Technicians
        public ActionResult Index()
        {
            return View(db.Technicians.ToList());
        }

        // GET: Technicians/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technician technician = db.Technicians.Find(id);
            if (technician == null)
            {
                return HttpNotFound();
            }
            return View(technician);
        }

        // GET: Technicians/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Technicians/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Schedule,IsAvailable,Rating")] Technician technician)
        {
            if (ModelState.IsValid)
            {
                db.Technicians.Add(technician);
                db.SaveChanges();
                return RedirectToAction("Nerd");
            }

            return View(technician);
        }

        // GET: Technicians/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technician technician = db.Technicians.Find(id);
            if (technician == null)
            {
                return HttpNotFound();
            }
            return View(technician);
        }

        // POST: Technicians/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Schedule,IsAvailable,Rating")] Technician technician)
        {
            if (ModelState.IsValid)
            {
                db.Entry(technician).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(technician);
        }

        // GET: Technicians/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technician technician = db.Technicians.Find(id);
            if (technician == null)
            {
                return HttpNotFound();
            }
            return View(technician);
        }

        // POST: Technicians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Technician technician = db.Technicians.Find(id);
            db.Technicians.Remove(technician);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ShowOpenTickets()
        {
            //foreach(ticket in Service)
            //{
            //    if (isTicketOpen == true)
            //    {
            //        //list first name, last name, address, issue type/description , and display an Accept button
            //    }
            //}

            var openTickets = db.Services.Where(s => s.IsTicketOpen == true).ToList();
            //var isClaimed = db.Services.Where(s => s.IsTicketOpen == false).ToList();
            //if(openTickets = isClaimed)
            //{

            //}
            return View(openTickets);
        }

        //Get: Technicians/ClaimTicket
        [HttpPut]
        public ActionResult ClaimTicket(int TicketId, Service service)
        {
            var currentTech = UserManager.FindById(User.Identity.GetUserId());
            var currentTechId = currentTech.Id;

            //In ClaimTicket method, change isTicketOpen to false and assign TechnicianId, HttpPut, 

            return View();
        }


        //Post: Technician/ClaimTicket
        //[HttpPost]
        //public ActionResult ClaimTicket()
        //{
        //    return View();
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Nerd()
        {
            return View();
        }

        public ActionResult GoogleMaps()
        {
            return View();
        }

        //Get: Account/EmployeeRegister
        [AllowAnonymous]
        public ActionResult EmployeeRegister()
        {

            return View();
        }

        // POST: /Account/EmployeeRegister
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmployeeRegister([Bind(Include = "ID,FirstName,LastName,PhoneNumber,Email,Password,ConfirmPassword")] Technician technician)
        {
            if (ModelState.IsValid)
            {
                db.Technicians.Add(technician);
                db.SaveChanges();
                return RedirectToAction("Nerd");
            }

            return View(technician);

        }

        
    }
}

