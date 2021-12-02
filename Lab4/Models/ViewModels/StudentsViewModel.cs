using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models.ViewModels
{

        public class StudentsViewModel
        {
            public IList<Student> Students { get; set; }
            public Student isSelected { get; set; }
        }
    
}
