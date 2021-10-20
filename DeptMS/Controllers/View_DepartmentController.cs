using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DeptMS.Data;
using DeptMS.Models;

namespace DeptMS.Controllers
{
    public class View_DepartmentController : Controller
    {
        private DeptMSContext db = new DeptMSContext();

        // GET: View_Department
        public ActionResult Index()
        {
            return View(db.View_Department.ToList());
        }

        // GET: View_Department/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            View_Department view_Department = db.View_Department.Find(id);
            if (view_Department == null)
            {
                return HttpNotFound();
            }
            return View(view_Department);
        }

        // GET: View_Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: View_Department/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DEPARTMENT_ID,COMPANY_ID,DEPARTMENT_CODE,DEPARTMENT_CNAME,DEPARTMENT_ENAME,DEPARTMENT_ABBR,PART_DEPARTMENT_ID,DEPARTMENT_LEADER_ID,GL_DEPARTMENT_CODE,DEPARTMENT_STATUS,DEPT_LEVEL_CODE,DEPT_LEVEL_CNAME,DEPT_LEVEL_LEVEL,ACTIVATE_DATE,EXPIRED_DATE,MODIFIED_DATE,DEPT_LEADER_NO,EMPLOYEE_EMAIL_1")] View_Department view_Department)
        {
            if (ModelState.IsValid)
            {
                db.View_Department.Add(view_Department);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(view_Department);
        }

        // GET: View_Department/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            View_Department view_Department = db.View_Department.Find(id);
            if (view_Department == null)
            {
                return HttpNotFound();
            }
            return View(view_Department);
        }

        // POST: View_Department/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DEPARTMENT_ID,COMPANY_ID,DEPARTMENT_CODE,DEPARTMENT_CNAME,DEPARTMENT_ENAME,DEPARTMENT_ABBR,PART_DEPARTMENT_ID,DEPARTMENT_LEADER_ID,GL_DEPARTMENT_CODE,DEPARTMENT_STATUS,DEPT_LEVEL_CODE,DEPT_LEVEL_CNAME,DEPT_LEVEL_LEVEL,ACTIVATE_DATE,EXPIRED_DATE,MODIFIED_DATE,DEPT_LEADER_NO,EMPLOYEE_EMAIL_1")] View_Department view_Department)
        {
            if (ModelState.IsValid)
            {
                db.Entry(view_Department).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(view_Department);
        }

        // GET: View_Department/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            View_Department view_Department = db.View_Department.Find(id);
            if (view_Department == null)
            {
                return HttpNotFound();
            }
            return View(view_Department);
        }

        // POST: View_Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            View_Department view_Department = db.View_Department.Find(id);
            db.View_Department.Remove(view_Department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
