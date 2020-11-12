using RuahaBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RuahaBlog.ViewModels
{
    public class DetailsViewModel
    {
        public BogPost BlogPost { get; set; }
        public string PageTitle { get; set; }
    }
}
