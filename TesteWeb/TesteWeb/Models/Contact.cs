using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWeb.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string FormattedName { get; set; }
        public List<string> Addresses { get; set; } = new List<string>();
        public List<string> Telephones { get; set; } = new List<string>();
        public List<string> Emails { get; set; } = new List<string>();

        public Contact()
        {
        }

        public Contact(string name, string formattedName)
        {
            Name = name;
            FormattedName = formattedName;
        }

       


    }
}
