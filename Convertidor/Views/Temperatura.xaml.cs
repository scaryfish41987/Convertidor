using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;
using Syncfusion.SfNumericUpDown;

namespace Convertidor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Temperatura : ContentPage
    {
        double C, F, K;
        string conversion,conversion2;
        public Temperatura()
        {
            InitializeComponent();
            Title = "Temperatura";
            PickUnidades.Items.Add("Celsius");
            PickUnidades.Items.Add("Fahrenheit");
            PickUnidades.Items.Add("Kelvin");

            PickUnidades2.Items.Add("Celsius");
            PickUnidades2.Items.Add("Fahrenheit");
            PickUnidades2.Items.Add("Kelvin");
        }


        private void PickUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            conversion = Convert.ToString(PickUnidades.SelectedItem);
            NumericEntry.Value = 0;
            lblResultado.Text = "0.0";
        }
        private void PickUnidades2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conversion2 = Convert.ToString(PickUnidades2.SelectedItem);
            lblResultado.Text = "0.0";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            switch (conversion)
            {
                case "Celsius":
                    C = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Celsius":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Fahrenheit":
                            F = (C * 9 / 5) + 32;
                            lblResultado.Text = Convert.ToString(Math.Round(F, 5)) + " F°";
                            break;

                        case "Kelvin":
                            K = C + 273.15;
                            lblResultado.Text = Convert.ToString(Math.Round(K, 5)) + " K°";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Fahrenheit":
                    F = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Celsius":
                            C = (F - 32) * 5 / 9;
                            lblResultado.Text = Convert.ToString(Math.Round(C, 5)) + " C°";
                            break;

                        case "Fahrenheit":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Kelvin":
                            K = (F - 32) * 5 / 9 + 273.15;
                            lblResultado.Text = Convert.ToString(Math.Round(K, 5)) + " K°";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Kelvin":
                    K = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Celsius":
                            C = K - 273.15;
                            lblResultado.Text = Convert.ToString(Math.Round(C, 5)) + " C°";
                            break;

                        case "Fahrenheit":
                            F = (K - 273.15) * 9 / 5 + 32;
                            lblResultado.Text = Convert.ToString(Math.Round(F, 5)) + " F°";
                            break;

                        case "Kelvin":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                default:
                    lblResultado.Text = "Elige una opcion";
                    break;
            }

        }
    }
}