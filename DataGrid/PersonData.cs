using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    public class PersonData
    {
        public enum Gender
        {
            Male,
            Female,
            None,
            UnDecided
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public Uri WebSite { get; set; }
        public Gender GenderType { get; set; }
        public string  Image { get; set; }
        public string Description { get; set; }
    }
}
