using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Ejercicio_Tarea
{
    class rectangulo:  INotifyPropertyChanged
    {

        private string primerNumero;
        private string segundoNumero;
        private string resultado;
        private string resultado2;
        public string PrimerNumero
        {
            get { return primerNumero; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) primerNumero = value;
                OnPropertyChanged("PrimerNumero");
                OnPropertyChanged("Resultado");
            }
        }

        public string SegundoNumero
        {
            get { return segundoNumero; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) segundoNumero = value;
                OnPropertyChanged("SegundoNumero");
                OnPropertyChanged("Resultado");
            }
        }

        public string Resultado
        {
            get
            {
                int resultado = int.Parse(PrimerNumero) + int.Parse(SegundoNumero);
                return resultado.ToString();
            }
            set
            {
                int suma = int.Parse(PrimerNumero) * int.Parse(SegundoNumero);
                resultado = suma.ToString();
                OnPropertyChanged("Resultado");
            }
        }
        public string Resultado2
        {
            get
            {
                int resultado2 = int.Parse(PrimerNumero) + int.Parse(SegundoNumero);
                return resultado2.ToString();
            }
            set
            {
                int perime = (int.Parse(PrimerNumero)*2) + (int.Parse(SegundoNumero)*2);
                resultado = perime.ToString();
                OnPropertyChanged("Resultado");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        // Métodos
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }



}
}
