using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Labo3_MoreSimple.Infrastructure;
using Labo3_MoreSimple.Model;

namespace Labo3_MoreSimple.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private string _listName;
        public string ListName
        {
            get => _listName;
            set
            {
                _listName = value;
                OnPropertyChanged();
            }
        }

        private FormeWrapper _selectedForme;
        public ObservableCollection<FormeWrapper> Items { get; set; }

        public FormeWrapper SelectedForme
        {
            get => _selectedForme;
            set
            {
                if( _selectedForme == value) return;
                _selectedForme = value;
                OnPropertyChanged(nameof(SelectedForme));
            }
        }

        public ICommand AddCarreCommand { get; set; }
        public ICommand AddCercleCommand { get; set; }
        public ICommand AddRectangleCommand { get; set; }

        public MainViewModel()
        {
            ListName = "DefaultName";
            Items = new ObservableCollection<FormeWrapper>();
            AddCarreCommand = new DelegateCommand(AddCarre);
            AddCercleCommand = new DelegateCommand(AddCercle);
            AddRectangleCommand = new DelegateCommand(AddRectangle);
            Add(new CarreWrapper(new Carre(0,0,10)));
        }

        private void Add(FormeWrapper v)
        {
            Items.Add(v);
            SelectedForme = v;
        }

        public void AddCarre(object args)
        {
            Add(new CarreWrapper(new Carre()));
        }

        public void AddRectangle(object args)
        {
            Add(new RectangleWrapper(new Rectangle()));
        }

        public void AddCercle(object args)
        {
            Add(new CercleWrapper(new Cercle()));
        }
    }
}
