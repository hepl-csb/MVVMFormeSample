using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVMSample.Infrastructure;
using MVVMSample.Model;

namespace MVVMSample.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<PersonneWrapper>
            {
                new PersonneWrapper(new Personne("Karl", "Wilvers", "a@a.com", "+32456789", new DateTime(1976, 8, 3))),
                new PersonneWrapper(
                    new Personne("Patrice", "Wilvers", "a@a.com", "+32456789", new DateTime(1976, 8, 3))),
                new PersonneWrapper(new Personne("Mike", "Wilvers", "a@a.com", "+32456789", new DateTime(1973, 4, 18)))
            };
            _selectedPersonne = Items[0];
            AddCommand = new DelegateCommand(AddPersonne);
        }

        public void AddPersonne(object obj)
        {
            var v = new PersonneWrapper(new Personne("Margot", "Wilvers", "a@a.com", "+324569",
                new DateTime(2010, 11, 20)));
            Items.Add(v);
            SelectedPersonne = v;
        }

        public ObservableCollection<PersonneWrapper> Items { get; set; }

        private PersonneWrapper _selectedPersonne;

        public PersonneWrapper SelectedPersonne
        {
            get => _selectedPersonne;
            set
            {
                if (_selectedPersonne == value) return;
                _selectedPersonne = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }

    }
}
