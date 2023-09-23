using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEFwebApp.Models;

namespace MVCEFwebApp.Controllers
{
    public class DoctorController : Controller
    {
        // GET: DoctorController
        public ActionResult Index()
        {
            List<Doctor> docs = RepositoryDr.GetDoctors();
            if(docs != null && docs.Count > 0) { return View(docs); }
            return RedirectToAction("Create");
        }

        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {
            Doctor doc = RepositoryDr.GetDoctorById(id);
            return View(doc);
        }

        // GET: DoctorController/Create
        public ActionResult Create(Doctor dr)
        {
            
            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Doctor pdoctor)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositoryDr.AddNewDoctor(pdoctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                return View();
            }
        }

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            Doctor doc = RepositoryDr.GetDoctorById(id);
            return View(doc);
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Doctor dr)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryDr.ModifyDr(dr);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            RepositoryDr.Removedr(id);
            return View();
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryDr.Removedr(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
