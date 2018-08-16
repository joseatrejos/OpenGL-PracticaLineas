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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Sol
            for(float i=0; i<=360; i++)
            {
                plnLinea.Points.Add(new Point(Math.Cos(i) * 50 + 100, Math.Sin(i) * 50 + 100));
            }

            // Suelo
            plnLinea1.Points.Add(new Point(0, 350));
            plnLinea1.Points.Add(new Point(700, 350));

            // Pasto
            plnLinea2.Points.Add(new Point(25, 330));
            plnLinea2.Points.Add(new Point(30, 349));
            plnLinea2.Points.Add(new Point(35, 330));

            plnLinea3.Points.Add(new Point(102, 330));
            plnLinea3.Points.Add(new Point(107, 349));
            plnLinea3.Points.Add(new Point(112, 330));

            plnLinea4.Points.Add(new Point(180, 330));
            plnLinea4.Points.Add(new Point(185, 349));
            plnLinea4.Points.Add(new Point(190, 330));

            // Puerta
            plnLinea5.Points.Add(new Point(350, 350));
            plnLinea5.Points.Add(new Point(350, 310));
            plnLinea5.Points.Add(new Point(380, 310));
            plnLinea5.Points.Add(new Point(380, 350));

            // División de Ventana
            plnLinea7.Points.Add(new Point(422, 288));
            plnLinea7.Points.Add(new Point(422, 247));
            plnLinea9.Points.Add(new Point(402, 267.5));
            plnLinea9.Points.Add(new Point(443, 267.5));

            // Ventana
            plnLinea6.Points.Add(new Point(400, 290));
            plnLinea6.Points.Add(new Point(445, 290));
            plnLinea6.Points.Add(new Point(445, 245));
            plnLinea6.Points.Add(new Point(400, 245));
            plnLinea6.Points.Add(new Point(400, 290));
            
            // Casa
            plnLinea8.Points.Add(new Point(260, 350));
            plnLinea8.Points.Add(new Point(470, 350));
            plnLinea8.Points.Add(new Point(470, 220));
            plnLinea8.Points.Add(new Point(260, 220));
            plnLinea8.Points.Add(new Point(260, 350));

            // Techo
            plnLinea10.Points.Add(new Point(240, 220));
            plnLinea10.Points.Add(new Point(365, 170));
            plnLinea10.Points.Add(new Point(490, 220));
            plnLinea10.Points.Add(new Point(240, 220));

            // Tronco del Arbol
            plnLinea11.Points.Add(new Point(545, 350));
            plnLinea11.Points.Add(new Point(585, 350));
            plnLinea11.Points.Add(new Point(585, 210));
            plnLinea11.Points.Add(new Point(545, 210));
            plnLinea11.Points.Add(new Point(545, 350));

            // Hojas del Arbol
            plnLinea12.Points.Add(new Point(545, 225));
            plnLinea12.Points.Add(new Point(525, 187.5));
            plnLinea12.Points.Add(new Point(565, 150));
            plnLinea12.Points.Add(new Point(600, 187.5));
            plnLinea12.Points.Add(new Point(585, 225));
        }
    }
}
