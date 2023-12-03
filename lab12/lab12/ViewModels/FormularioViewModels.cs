using lab12.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lab12.ViewModels
{
    public class FormularioViewModels : ViewModeloBase
    {
        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (descripcion != value)
                {
                    descripcion = value;
                    OnPropertyChanged();
                }
            }
        }

        bool status;
        public bool Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<FormularioModel> tasks;
        public ObservableCollection<FormularioModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        public FormularioViewModels()
        {
            tasks = new ObservableCollection<FormularioModel>();

            Save = new Command(() =>
            {
                tasks.Add(new FormularioModel(Title, Status ,Descripcion));
            });

            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<FormularioModel>(tasks);
            });
        }
    }
}