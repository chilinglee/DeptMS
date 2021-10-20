using DeptMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeptMS.Repository
{
    public class DepartmentRepository:GeneralRepository
    {
        private DbContext _context;
        public DepartmentRepository(DbContext context) : base(context)
        {
            _context = context;
        }
        public void RevisedUpdate(View_Department entity, string old_id)
        {
            using(var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    View_Department oldEntity = GetAll<View_Department>().FirstOrDefault(x => x.DEPARTMENT_ID == old_id);
                    Delete(oldEntity);

                    Create<View_Department>(entity);
                    SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
        }
    }
}