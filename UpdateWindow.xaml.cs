using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Semana13BDk
{
    /// <summary>
    /// Lógica de interacción para InsertWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow(int id)
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            Alumno alumno = dataAccess.GetById(id);
            txtId.Text = alumno.Id.ToString();
            txtNombres.Text = alumno.Nombres;
            txtApellidos.Text = alumno.Apellidos;
            txtCarnet.Text = alumno.Carnet;
            txtTelefono.Text = alumno.Telefono;
            cbCarreras.ItemsSource = dataAccess.GetCarreras();
            cbCarreras.SelectedValue = alumno.IdCarrera;
        }
            private void btnGuardar_Click(object sender, RoutedEventArgs e)
            {
                DataAccess dataAccess = new DataAccess();
                Alumno alumno = new Alumno
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Telefono = txtTelefono.Text,
                    Id = int.Parse(txtId.Text),
                    IdCarrera = int.Parse(cbCarreras.SelectedValue?.ToString() ?? "0")
                };
                int result = dataAccess.Update(alumno);
                if (result > 0)
                {
                    MessageBox.Show("Alumno guardado correctamente");
                }
            this.Close();
            }
    }
}
