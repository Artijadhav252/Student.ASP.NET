using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task4.Models;

public partial class Student
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Gender { get; set; }

    [Required]
    public int? Class { get; set; }

    [Required]
    public string? Address { get; set; }
}
