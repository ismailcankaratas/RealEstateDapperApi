﻿namespace RealEstate_Dapper_Api.Dtos.EmployeeDtos
{
    public class ResultEmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
    }
}
