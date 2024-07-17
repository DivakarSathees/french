using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models

{
    public class Student
{
    [Key]
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int BatchID { get; set; }
    public Batch Batch { get; set; }
}
}