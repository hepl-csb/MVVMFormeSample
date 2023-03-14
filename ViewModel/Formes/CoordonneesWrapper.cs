﻿using Infrastructure;
using Model;

namespace ViewModel.Formes
{
    public class CoordonneesWrapper : WrapperBase<Coordonnees>, ICoordonnees
    {
        public CoordonneesWrapper(Coordonnees content) : base(content)
        {
        }

        public int X
        {
            get => Content.X;
            set
            {
                if (Content.X == value)
                    return;
                Content.X = value;
                OnPropertyChanged();
            }
        }

        public int Y
        {
            get => Content.Y;
            set
            {
                if (value == Content.Y) return;
                Content.Y = value;
                OnPropertyChanged();
            }
        }

    }
}
