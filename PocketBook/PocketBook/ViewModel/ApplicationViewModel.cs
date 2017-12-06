using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PocketBook.Model.Enttity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PocketBook.ViewModel
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public List<Note> Notes { get; set; }
        public ApplicationViewModel()
        {
            Notes = new List<Note>
            {
                new Note{ Id=0,Name="Pavel"},
                new Note{ Id=1,Name="Andrey"}
            };
        }
    }
}
