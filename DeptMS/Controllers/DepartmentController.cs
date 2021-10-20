using DeptMS.Data;
using DeptMS.Repository;
using DeptMS.Service;
using DeptMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DeptMS.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentService _deService;
        public DepartmentController()
        {
            _deService = new DepartmentService();
        }
        
        public ActionResult Read()
        {
            List<DepartmentViewModel> allDept = _deService.GetAllDep();
            return View(allDept);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentViewModel newdept)
        {
            if (ModelState.IsValid)
            {
                _deService.CreateNewDept(newdept);
                return RedirectToAction("Read");
            }
            return View(newdept);
        }
        
        public ActionResult Update(string id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DepartmentViewModel dept = _deService.GetById(id);
            if(dept == null)
            {
                return HttpNotFound();
            }
            return View(dept);
        }
        [HttpPost]
        public ActionResult Update(DepartmentViewModel updateDept)
        {
            if (ModelState.IsValid)
            {
                _deService.UpdateDept(updateDept);
                return RedirectToAction("Read");
            }
            return View(updateDept);
        }
        public ActionResult Delete(string id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bool IsSuccess = _deService.DeleteById(id);
            if (IsSuccess)
            {
                return RedirectToAction("Read");
            }
            else
            {
                return HttpNotFound();
            }
            
        }
    }
}