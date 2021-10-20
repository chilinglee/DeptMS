using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeptMS.ViewModel
{
    public class DepartmentViewModel
    {
        [Required]
        [StringLength(10)]
        public string DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(120)]
        public string DEPARTMENT_CNAME { get; set; }

        [Required]
        [StringLength(200)]
        public string DEPARTMENT_ENAME { get; set; }

        [Required]
        [StringLength(120)]
        public string DEPARTMENT_ABBR { get; set; }

        [Required]
        [StringLength(10)]
        public string PART_DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(32)]
        public string DEPARTMENT_LEADER_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string GL_DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(1)]
        public string DEPARTMENT_STATUS { get; set; }

        [Required]
        [StringLength(32)]
        public string DEPT_LEVEL_CODE { get; set; }

        [Required]
        [StringLength(32)]
        public string DEPT_LEVEL_CNAME { get; set; }

        [Required]
        [StringLength(32)]
        public string DEPT_LEVEL_LEVEL { get; set; }

        [Required]
        public String ACTIVATE_DATE { get; set; }

        [Required]
        public String EXPIRED_DATE { get; set; }

        [Required]
        public String MODIFIED_DATE { get; set; }

        [Required]
        [StringLength(32)]
        public string DEPT_LEADER_NO { get; set; }

        [Required]
        [StringLength(50)]
        public string EMPLOYEE_EMAIL_1 { get; set; }

        public string OLD_DEPARTMENT_ID { get; set; }
    }
}