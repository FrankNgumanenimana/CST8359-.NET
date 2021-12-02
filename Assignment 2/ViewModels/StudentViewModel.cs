using System.Collections.Generic;
using Lab4.Models;

namespace Lab4.ViewModels
{
    public class StudentsViewModel
    {
        public IList<Student> Students { get; set; }
        public Student isSelected { get; set; }
    }
}
