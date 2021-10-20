using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DeptMS.Models
{
    public class View_Department
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string COMPANY_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(120)]
        public string DEPARTMENT_CNAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string DEPARTMENT_ENAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(120)]
        public string DEPARTMENT_ABBR { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string PART_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(32)]
        public string DEPARTMENT_LEADER_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string GL_DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string DEPARTMENT_STATUS { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(32)]
        public string DEPT_LEVEL_CODE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(32)]
        public string DEPT_LEVEL_CNAME { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(32)]
        public string DEPT_LEVEL_LEVEL { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime ACTIVATE_DATE { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime EXPIRED_DATE { get; set; }

        [Key]
        [Column(Order = 15)]
        public DateTime MODIFIED_DATE { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(32)]
        public string DEPT_LEADER_NO { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string EMPLOYEE_EMAIL_1 { get; set; }
    }
}