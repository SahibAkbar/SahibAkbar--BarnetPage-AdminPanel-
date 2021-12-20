using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarnetPages.Models.ViewModels
{
    public class VmService
    {
        public List<Service> Services { get; set; }
        public List<Client> Clients { get; set; }
        public Setting Setting { get; set; }
        public List<Social> Socials { get; set; }
        public Subscribe Subscribe { get; set; }
    }
}
