using System.Collections.Generic;
using Lab4.Models;

namespace Lab4.ViewModels
{
    public class CommunitiesViewModel
    {
        public IList<Community> Communities { get; set; }
        public Community Selected { get; set; }
    }
}
