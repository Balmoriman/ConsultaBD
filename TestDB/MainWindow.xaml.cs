using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestDB.Models;

namespace TestDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Lectura(); 
        }

        private ObservableCollection<VM> datosCosnulta = new ObservableCollection<VM>();
        public ObservableCollection<VM> DatosConsulta => datosCosnulta; 

        public List<VM> Consulta()
        {
            using(DSNet3_DesarrolloContext  conn = new DSNet3_DesarrolloContext())
            {
                var consulta = conn.Calendario.Select(s => new VM
                {
                    Fecha = s.Fecha,
                    Descripcion = s.Descripcion,
                    ClaveEstatus = s.ClaveEstatus,
                    Estatus = s.ClaveEstatus == 1 ? "Activo" : "inactivo",
                    FechaAlta = s.FechaAlta,
                    UsuarioAlta = s.UsuarioAlta
                }).OrderBy(o => o.FechaAlta);

                return consulta.ToList();
            }
      
        }

        public void Lectura()
        {
            //foreach(var item in Consulta())
            //{
            //    datosCosnulta.Add(item);
            //}

            dgGrid.ItemsSource = Consulta();
            
        }
       
    }
}
