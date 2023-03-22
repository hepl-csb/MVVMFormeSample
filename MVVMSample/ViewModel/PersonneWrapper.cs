using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSample.Infrastructure;
using MVVMSample.Model;

namespace MVVMSample.ViewModel
{
    public class PersonneWrapper : WrapperBase<Personne>
    {
        public PersonneWrapper(Personne content) : base(content)
        {
        }

        public string FirstName
        {
            get => Content.FirstName;
            set
            {
                if (value == Content.FirstName) return;
                Content.FirstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => Content.LastName;
            set
            {
                if (value == Content.LastName) return;
                Content.LastName = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => Content.Email;
            set
            {
                if (value == Content.Email) return;
                Content.Email = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => Content.Phone;
            set
            {
                if (value == Content.Phone) return;
                Content.Phone = value;
                OnPropertyChanged();
            }
        }

        public DateTime BirthDate
        {
            get => Content.BirthDate;
            set
            {
                if (value == Content.BirthDate) return;
                Content.BirthDate = value;
                OnPropertyChanged(nameof(BirthDate));
                OnPropertyChanged(nameof(Age));
            }
        }

        public int Age => (int) ((DateTime.Now - BirthDate).TotalDays / 365);
    }
}
