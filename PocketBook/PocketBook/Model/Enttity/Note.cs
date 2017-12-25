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

        public string EMailString { get; set; }

        public string Number { get; set; }

        public Note()
        {

        }
        public Note(Note Nt) : this()
        {
            SetItems(Nt);
        }
        public void SetItems(Note Nt)
        {
            //Id = Nt.Id;
            Name = Nt.Name;
            Birthday = Nt.Birthday;
            Commentary = Nt.Commentary;
            EMailString = Nt.EMailString;
            Number = Nt.Number;
        }
    }
}
