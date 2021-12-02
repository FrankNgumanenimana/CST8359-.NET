using System.Collections.Generic;
using Lab4.Models;

namespace Lab4.ViewModels
{
    public class StudentMembershipsViewModel
    {
        public Student Student { get; set; }
        public IList<Community> Communities { get; set; }
    }
}
