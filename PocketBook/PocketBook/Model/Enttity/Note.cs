using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBook.Model.Enttity
{
    public class Note
    {
        public int Id { get; set; }
        public string Name {get;set;}

        public DateTime Birthday { get; set; }

        public String Commentary { get; set; }

        public ICollection<EMail> EMails { get; set; }

        public ICollection<Telephone> Telephones { get; set; }

        public Note()
        {
            EMails = new List<EMail> ();
            Telephones = new LinkedList<Telephone>();
        }

    }
}
