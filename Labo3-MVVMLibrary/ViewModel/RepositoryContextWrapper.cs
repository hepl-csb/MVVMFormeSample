using System;
using System.Collections.ObjectModel;
using Labo3_MVVMLibrary.Infrastructure;
using Labo3_MVVMLibrary.Model;

namespace Labo3_MVVMLibrary.ViewModel
{
    public class RepositoryContextWrapper : WrapperBase<RepositoryContext>
    {
        public ObservableCollection<IForme> Items { get; set; }

        public RepositoryContextWrapper(RepositoryContext content) : base(content)
        {
            Items = new ObservableCollection<IForme>();

            //Creation des Wrappers sur base des modèles 
            Content.Formes.ForEach(i =>
            {
                Add(i);
            });
        }

        public IForme Add(IForme forme)
        {
            //Create Wrapper base on the model type
            switch (forme)
            {
                case Carre carre:
                    return Add(carre, typeof(CarreWrapper));
                case Rectangle rectangle:
                    return Add(rectangle, typeof(RectangleWrapper));
                case Cercle cercle:
                    return Add<CercleWrapper>(cercle);
            }
            throw new Exception("Try to add abstract type");
        }

        public IForme Add(Forme item, Type T)
        {
            if (!Content.Formes.Contains(item))
                Content.AddForme(item);
            //Call the constructor of the type pass by parameter
            var fw = Activator.CreateInstance(T, item) as IForme;
            Items.Add(fw);
            return fw;
        }

        //Pass type in an generic method
        public IForme Add<T>(Forme item)
        {
            return Add(item, typeof(T));
        }
    }
}
