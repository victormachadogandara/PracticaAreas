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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            float rbase = float.Parse(Rbase.Text);
            float raltura = float.Parse(Raltura.Text);
            float resutado = rbase * raltura;
            Area.Text = resutado.ToString();
        }

        private void Calcular2_Click(object sender, RoutedEventArgs e)
        {
            float tbase = float.Parse(Tbase.Text);
            float taltura = float.Parse(Taltura.Text);
            float resultado2 = (tbase * taltura) / 2;
            Area2.Text = resultado2.ToString();
        }

        private void Calcular3_Click(object sender, RoutedEventArgs e)
        {
            float cradio = float.Parse(Cradio.Text);
            float resultado = (cradio * cradio) * 3.140f;
            Area3.Text = resultado.ToString();
        }

        private void Calcular4_Click(object sender, RoutedEventArgs e)
        {
            float tbmayor = float.Parse(TBmayor.Text);
            float tbmenor = float.Parse(TBmenor.Text);
            float tbaltura = float.Parse(TBaltura.Text);
            float resultado3 = (tbmayor + tbmenor) * tbaltura / 2;
            Area4.Text = resultado3.ToString();
        }
    }
}
