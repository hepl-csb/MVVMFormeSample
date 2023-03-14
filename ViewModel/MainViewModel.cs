using System.Collections.ObjectModel;
using System.Windows.Input;
using Infrastructure;
using ViewModel.Formes;
using Model;

namespace ViewModel
{
    public class MainViewModel : BindableBase
    {
        private IForme _selectedForme;
        public RepositoryContextWrapper Context { get; set; }

        public IForme SelectedForme
        {
            get => _selectedForme;
            set
            {
                if( _selectedForme == value) return;
                _selectedForme = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddFormeCommand { get; set; }

        public MainViewModel()
        {
            Context = new RepositoryContextWrapper(new RepositoryContext());
            AddFormeCommand = new DelegateCommand(Execute);
            Execute(typeof(Carre));
        }

        private void Execute(object obj)
        {
            var rand = new Random();

            if ((Type)obj == typeof(Carre))
                SelectedForme = Context.Add(new Carre(rand.Next(640), rand.Next(480), rand.Next(20)));
            else if ((Type)obj == typeof(Rectangle))
                SelectedForme = Context.Add(new Rectangle(rand.Next(640), rand.Next(480), rand.Next(20), rand.Next(20)));
            else if ((Type)obj == typeof(Cercle))
                SelectedForme = Context.Add(new Cercle(rand.Next(640), rand.Next(480), rand.Next(20)));
        }

    }
}
