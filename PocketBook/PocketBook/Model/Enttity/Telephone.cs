using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBook.Model.Enttity
{
    public class Telephone
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Number { get; set; }

        public int? NoteId { get; set; }
        public Note Note { get; set; }
    }
}
