﻿using HRIS.Domain.Enums;

namespace HRIS.Service.DTOs
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? TimeSchedule { get; set; }
        public string? DateHired { get; set; }
        public string? BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? TinNo { get; set; }
        public string? SSS { get; set; }
        public string? PagIbigNo { get; set; }
        public string? PhilHealthNo { get; set; }
        public string? Status { get; set; }
        public string? HMO { get; set; }

    }
}
