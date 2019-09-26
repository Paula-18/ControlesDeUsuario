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

namespace ControlesDeUsuario
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

        private void CdFiguraC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
            switch (cdFiguraC.SelectedIndex)
            {
                case 0:
                    grdParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;
                case 1:
                    grdParametrosFigura.Children.Add(new ParametrosTriangulo());
                    break;
                case 2:
                    grdParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;
                case 3:
                    grdParametrosFigura.Children.Add(new ParametrosPentagono());
                    break;
                case 4:
                    grdParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;
                case 5:
                    grdParametrosFigura.Children.Add(new ParametrosTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void BtnCalcularArea_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;

            switch(cdFiguraC.SelectedIndex)
            {
                case 0:
                    double radio =
                        double.Parse(
                    ((ParametrosCirculo)
                        (grdParametrosFigura.Children[0])).
                        txtRadio.Text);
                    area = Math.PI * radio * radio;
                    break;
                case 1:
                    double base1 =
                        double.Parse(
                            ((ParametrosTriangulo)(grdParametrosFigura.Children[0])).
                            txtBase.Text);
                    double altura =
                        double.Parse(
                            ((ParametrosTriangulo)(grdParametrosFigura.Children[0])).
                            txtAltura.Text);
                    area = base1 * altura / 2;    
                    break;
                case 2:
                    double base2 =
                        double.Parse(
                            ((ParametrosRectangulo)(grdParametrosFigura.Children[0])).
                            txtBase.Text
                            );
                    double altura2 =
                        double.Parse(
                            ((ParametrosRectangulo)(grdParametrosFigura.Children[0])).
                            txtAltura.Text
                            );
                    area = base2 * altura2;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
            lblResultado.Text = area.ToString();
        }
    }
}
