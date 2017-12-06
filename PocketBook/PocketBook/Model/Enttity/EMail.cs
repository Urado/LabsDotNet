using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketBook.Model.Enttity
{
    public class EMail
    {
        public int Id;
        public string EMaill { get; set; }

        public int? NoteId { get; set; }
        public Note Note { get; set; }
    }
}
