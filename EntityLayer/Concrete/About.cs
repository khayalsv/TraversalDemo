using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }

    public class Guide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public bool Status { get; set; }
    }

    public class Contact
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
