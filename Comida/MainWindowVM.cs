using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {

        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set
            { 
                platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        private ObservableCollection<string> tipos;

        public ObservableCollection<string> Tipos
        {
            get { return tipos; }
            set
            {
                tipos = value;
                NotifyPropertyChanged("Tipos");
            }
        }


        public MainWindowVM()
        {
            Platos = Plato.GetSamples("./Assets/");
            Tipos = Plato.GetTipos();
            PlatoSeleccionado = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
