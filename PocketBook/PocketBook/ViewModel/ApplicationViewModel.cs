using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PocketBook.Model.Enttity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Navigation;
using PocketBook.Model;
using System.Windows.Controls;

namespace PocketBook.ViewModel
{
    class ApplicationViewModel : BaseViewModel
    {
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        notes.Add(new Note { Id = Notes.Count, Name = "Игорь" });
                        RebildNote();
                    }));
            }
        }

        private RelayCommand changeCommand;
        public RelayCommand ChangeCommand
        {
            get
            {
                return changeCommand ??
                    (changeCommand = new RelayCommand(obj =>
                    {
                        SaveChangeInNote(outNote);
                        RebildNote();
                    }));
            }
        }

        public Note SelectedNote
        {
            get { return selectedNote; }
            set
            {
                selectedNote = value;
                OutNote = new Note(selectedNote);
                OnPropertyChanged(nameof(SelectedNote));
            }
        }
        private Note selectedNote = null;

        public Note OutNote
        {
            get
            {
                return outNote;
            }
            set
            {
                outNote = value;
                OnPropertyChanged(nameof(OutNote));
            }
        }
        private Note outNote=new Note();

        public ObservableCollection<Note> Notes
        {
            get;
            set;
        }
        private ObservableCollection<Note> notes;

        public List<Char> Alfavite { get; set; }

        private Char AllLiteral = '-';

        public Char SelectedChar
        {
            get
            {
                return selectedChar;
            }
            set
            {
                selectedChar = value;
                OnPropertyChanged(nameof(SelectedChar));
                RebildNote();
            }
        }
        public Char selectedChar;

        private void RebildNote()
        {
            Notes.Clear();
            if (selectedChar == AllLiteral)
            {
                foreach (var v in notes.OrderBy(e => e.Name))
                {
                    Notes.Add(v);
                }
            }
            else
            {
                foreach (var v in notes.Where(e=>e.Name.ToLower()[0]== selectedChar).OrderBy(e => e.Name))
                {
                    Notes.Add(v);
                }
            }
        }

        public ApplicationViewModel()
        {
            Alfavite = new List<char> { AllLiteral };

            selectedChar = AllLiteral;

            for(int i=0;i<32;i++)
            {
                if(i==6)
                    Alfavite.Add((char)('ё'));
                Alfavite.Add((char)('а' + i));
            }

            notes = new ObservableCollection<Note>
            {
                new Note{ Id=0,Name="Павел"},
                new Note{ Id=1,Name="Андрей"}
            };

            notes[0].Number = "8(919)665-33-11";
            notes[0].EMailString = "sassa@mro.ru";
            notes[0].Commentary = "vbu relbetrv ojbnbtaeon jbvbaerj kblovaer bjklbvadefbjkblg raekljbgrae kjhbvaerbj kbdfgkjnbh dfhngelvhf kjlghjkfia gjkerhg lncvdbne dag lfda";

            notes[1].Number = "8(923)565-33-42";
            notes[1].EMailString = "shkmto@vdv.ru";
            notes[1].Commentary = "пуащшгр укпгрорукпдрлшвапожлрдлджор ва мп олрддл ор вапл орд лор вало рп лор вало рвпалоррваи лодр гвапрва мшд гп вап и ш упр й3лкпиаду шкп";

            using (var DB = new PocketBookDB())
            {
                DB.Notes.AddRange(notes);
                DB.SaveChangesAsync();
            }

            Notes = new ObservableCollection<Note>();

            foreach(var v in notes.OrderBy(e => e.Name))
            {
                Notes.Add(v);
            }
        }

        public void SaveChangeInNote(Note note)
        {
            var concreteNote=notes.FirstOrDefault(n => n.Id == note.Id);
            concreteNote.SetItems(note);
            using (var DB = new PocketBookDB())
            {
                concreteNote = notes.FirstOrDefault(n => n.Id == note.Id);
                concreteNote.SetItems(note);
                DB.SaveChangesAsync();
            }
        }
    }
}
