using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models.ViewModels
{
    public class MembershipViewModel
    {
        public Student Student { get; set; }
        public IList<Community> Communities { get; set; }
    }
}
