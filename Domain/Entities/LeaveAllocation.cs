﻿using Domain.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class LeaveAllocation : Auditable, IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        public int LeaveTypeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public virtual LeaveType LeaveType { get; set; }

        public string EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual AppUser Employee { get; set; }

        public int NumberOfDays { get; set; }

        public int Period { get; set; }
    }
}