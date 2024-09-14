﻿namespace LearningCQRSinAspNetCoreUsingMediatR.Models
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
