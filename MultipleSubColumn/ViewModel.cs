using MultipleSubColumn.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSubColumn
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students { get => _students; set => SetPropertyChange(ref _students, value); }

        public ViewModel()
        {
            _students = new ObservableCollection<Student>() {
                new Student(){Id=1,Info=new Info(){FirstName="Nguyen",MiddleName="Trong",LastName="Dao"}
            }};
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SetPropertyChange<T>(ref T member, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(member, value)) {
                return;
            }
            member = value;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}