﻿using System;
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

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();
                switch(cbFigura.SelectedIndex)
            {
                case 0: //Circulo
                    grdParametrosFigura.Children.Add(new ParametroCirculo());
                    break;
                case 1: //Triangulo
                    grdParametrosFigura.Children.Add(new ParametrosTriangulo());
                    break;
                case 2: //Rectangulo
                    grdParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;
                case 3: //Pentagono
                    grdParametrosFigura.Children.Add(new ParametrosPentagono());
                    break;
                case 4: //Cuadrado
                    grdParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;
                case 5: //Trpaecio
                    grdParametrosFigura.Children.Add(new ParametrosTrapecio());
                    break;
                default:
                    break;
            }
        }
    }
}
