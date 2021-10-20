using DeptMS.Data;
using DeptMS.Models;
using DeptMS.Repository;
using DeptMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeptMS.Service
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _repo;
        public DepartmentService()
        {
            _repo = new DepartmentRepository(new DeptMSContext());
        }

        public List<DepartmentViewModel> GetAllDep()
        {
            List<DepartmentViewModel> allDep = new List<DepartmentViewModel>();
            List<View_Department> data = _repo.GetAll<View_Department>().ToList();
            foreach (var item in data)
            {
                string active_date = item.ACTIVATE_DATE.Date.ToString("yyyy-MM-dd");
                string expired_date = item.EXPIRED_DATE.Date.ToString("yyyy-MM-dd");
                string modified_date = item.MODIFIED_DATE.Date.ToString("yyyy-MM-dd");
                allDep.Add(new DepartmentViewModel
                {
                    DEPARTMENT_ID = item.DEPARTMENT_ID,
                    COMPANY_ID = item.COMPANY_ID,
                    DEPARTMENT_CODE = item.DEPARTMENT_CODE,
                    DEPARTMENT_CNAME = item.DEPARTMENT_CNAME,
                    DEPARTMENT_ENAME = item.DEPARTMENT_ENAME,
                    DEPARTMENT_ABBR = item.DEPARTMENT_ABBR,
                    PART_DEPARTMENT_ID = item.PART_DEPARTMENT_ID,
                    DEPARTMENT_LEADER_ID = item.DEPARTMENT_LEADER_ID,
                    GL_DEPARTMENT_CODE = item.GL_DEPARTMENT_CODE,
                    DEPARTMENT_STATUS = item.DEPARTMENT_STATUS,
                    DEPT_LEVEL_CODE = item.DEPT_LEVEL_CODE,
                    DEPT_LEVEL_CNAME = item.DEPT_LEVEL_CNAME,
                    DEPT_LEVEL_LEVEL = item.DEPT_LEVEL_LEVEL,
                    ACTIVATE_DATE = active_date,
                    EXPIRED_DATE = expired_date,
                    MODIFIED_DATE = modified_date,
                    DEPT_LEADER_NO = item.DEPT_LEADER_NO,
                    EMPLOYEE_EMAIL_1 = item.EMPLOYEE_EMAIL_1
                });
            }
            return allDep;
        }

        public void CreateNewDept(DepartmentViewModel newDept)
        {
            _repo.Create(new View_Department
            {
                DEPARTMENT_ID = newDept.DEPARTMENT_ID,
                COMPANY_ID = newDept.COMPANY_ID,
                DEPARTMENT_CODE = newDept.DEPARTMENT_CODE,
                DEPARTMENT_CNAME = newDept.DEPARTMENT_CNAME,
                DEPARTMENT_ENAME = newDept.DEPARTMENT_ENAME,
                DEPARTMENT_ABBR = newDept.DEPARTMENT_ABBR,
                PART_DEPARTMENT_ID = newDept.PART_DEPARTMENT_ID,
                DEPARTMENT_LEADER_ID = newDept.DEPARTMENT_LEADER_ID,
                GL_DEPARTMENT_CODE = newDept.GL_DEPARTMENT_CODE,
                DEPARTMENT_STATUS = newDept.DEPARTMENT_STATUS,
                DEPT_LEVEL_CODE = newDept.DEPT_LEVEL_CODE,
                DEPT_LEVEL_CNAME = newDept.DEPT_LEVEL_CNAME,
                DEPT_LEVEL_LEVEL = newDept.DEPT_LEVEL_LEVEL,
                ACTIVATE_DATE = DateTime.Parse(newDept.ACTIVATE_DATE),
                EXPIRED_DATE = DateTime.Parse(newDept.EXPIRED_DATE),
                MODIFIED_DATE = DateTime.Parse(newDept.MODIFIED_DATE),
                DEPT_LEADER_NO = newDept.DEPT_LEADER_NO,
                EMPLOYEE_EMAIL_1 = newDept.EMPLOYEE_EMAIL_1
            });
            _repo.SaveChanges();
        }
        public DepartmentViewModel GetById(string dept_id)
        {
            View_Department dept = _repo.GetAll<View_Department>().FirstOrDefault(x => x.DEPARTMENT_ID == dept_id);
            return new DepartmentViewModel
            {
                DEPARTMENT_ID = dept.DEPARTMENT_ID,
                COMPANY_ID = dept.COMPANY_ID,
                DEPARTMENT_CODE = dept.DEPARTMENT_CODE,
                DEPARTMENT_CNAME = dept.DEPARTMENT_CNAME,
                DEPARTMENT_ENAME = dept.DEPARTMENT_ENAME,
                DEPARTMENT_ABBR = dept.DEPARTMENT_ABBR,
                PART_DEPARTMENT_ID = dept.PART_DEPARTMENT_ID,
                DEPARTMENT_LEADER_ID = dept.DEPARTMENT_LEADER_ID,
                GL_DEPARTMENT_CODE = dept.GL_DEPARTMENT_CODE,
                DEPARTMENT_STATUS = dept.DEPARTMENT_STATUS,
                DEPT_LEVEL_CODE = dept.DEPT_LEVEL_CODE,
                DEPT_LEVEL_CNAME = dept.DEPT_LEVEL_CNAME,
                DEPT_LEVEL_LEVEL = dept.DEPT_LEVEL_LEVEL,
                ACTIVATE_DATE = dept.ACTIVATE_DATE.Date.ToString("yyyy-MM-dd"),
                EXPIRED_DATE = dept.EXPIRED_DATE.Date.ToString("yyyy-MM-dd"),
                MODIFIED_DATE = dept.MODIFIED_DATE.Date.ToString("yyyy-MM-dd"),
                DEPT_LEADER_NO = dept.DEPT_LEADER_NO,
                EMPLOYEE_EMAIL_1 = dept.EMPLOYEE_EMAIL_1
            };
        }

        public void UpdateDept(DepartmentViewModel updateDept)
        {

            View_Department newEntity = new View_Department
            {
                DEPARTMENT_ID = updateDept.DEPARTMENT_ID,
                COMPANY_ID = updateDept.COMPANY_ID,
                DEPARTMENT_CODE = updateDept.DEPARTMENT_CODE,
                DEPARTMENT_CNAME = updateDept.DEPARTMENT_CNAME,
                DEPARTMENT_ENAME = updateDept.DEPARTMENT_ENAME,
                DEPARTMENT_ABBR = updateDept.DEPARTMENT_ABBR,
                PART_DEPARTMENT_ID = updateDept.PART_DEPARTMENT_ID,
                DEPARTMENT_LEADER_ID = updateDept.DEPARTMENT_LEADER_ID,
                GL_DEPARTMENT_CODE = updateDept.GL_DEPARTMENT_CODE,
                DEPARTMENT_STATUS = updateDept.DEPARTMENT_STATUS,
                DEPT_LEVEL_CODE = updateDept.DEPT_LEVEL_CODE,
                DEPT_LEVEL_CNAME = updateDept.DEPT_LEVEL_CNAME,
                DEPT_LEVEL_LEVEL = updateDept.DEPT_LEVEL_LEVEL,
                ACTIVATE_DATE = DateTime.Parse(updateDept.ACTIVATE_DATE),
                EXPIRED_DATE = DateTime.Parse(updateDept.EXPIRED_DATE),
                MODIFIED_DATE = DateTime.Parse(updateDept.MODIFIED_DATE),
                DEPT_LEADER_NO = updateDept.DEPT_LEADER_NO,
                EMPLOYEE_EMAIL_1 = updateDept.EMPLOYEE_EMAIL_1
            };
            _repo.RevisedUpdate(newEntity, updateDept.OLD_DEPARTMENT_ID);
        }
        public void DeleteById(string id)
        {
            View_Department item = _repo.GetAll<View_Department>().FirstOrDefault(x => x.DEPARTMENT_ID == id);
            _repo.Delete(item);
            _repo.SaveChanges();
        }
    }
}