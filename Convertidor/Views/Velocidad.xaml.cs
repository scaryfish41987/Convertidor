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
    public partial class Velocidad : ContentPage
    {
        double Ms, Kmh, Ps, Mh, N;
        string conversion,conversion2;


        public Velocidad()
        {
            InitializeComponent();
            Title = "Velocidad";
            PickUnidades.Items.Add("Milla por Hora");
            PickUnidades.Items.Add("Pie por Segundo");
            PickUnidades.Items.Add("Metro por Segundo");
            PickUnidades.Items.Add("Kilometro por Hora");
            PickUnidades.Items.Add("Nudo");
    
            PickUnidades2.Items.Add("Milla por Hora");
            PickUnidades2.Items.Add("Pie por Segundo");
            PickUnidades2.Items.Add("Metro por Segundo");
            PickUnidades2.Items.Add("Kilometro por Hora");
            PickUnidades2.Items.Add("Nudo");
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
                case "Milla por Hora":
                    Mh = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Milla por Hora":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Pie por Segundo":
                            Ps = Mh * 1.467;
                            lblResultado.Text = Convert.ToString(Math.Round(Ps, 5)) + " ft/s";
                            break;

                        case "Metro por Segundo":
                            Ms = Mh / 2.237;
                            lblResultado.Text = Convert.ToString(Math.Round(Ms, 5)) + " m/s";
                            break;

                        case "Kilometro por Hora":
                            Kmh = Mh * 1.609;
                            lblResultado.Text = Convert.ToString(Math.Round(Kmh, 5)) + " km/h";
                            break;

                        case "Nudo":
                            N = Mh / 1.151;
                            lblResultado.Text = Convert.ToString(Math.Round(N, 5)) + " kn";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pie por Segundo":
                    Ps = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Milla por Hora":
                            Mh = Ps / 1.467;
                            lblResultado.Text = Convert.ToString(Math.Round(Mh, 5)) + " mph";
                            break;

                        case "Pie por Segundo":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Metro por Segundo":
                            Ms = Ps / 3.281;
                            lblResultado.Text = Convert.ToString(Math.Round(Ms, 5)) + " m/s";
                            break;

                        case "Kilometro por Hora":
                            Kmh = Ps * 1.097;
                            lblResultado.Text = Convert.ToString(Math.Round(Kmh, 5)) + " km/h";
                            break;

                        case "Nudo":
                            N = Ps / 1.688;
                            lblResultado.Text = Convert.ToString(Math.Round(N, 5)) + " kn";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Metro por Segundo":
                    Ms = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Milla por Hora":
                            Mh = Ms * 2.237;
                            lblResultado.Text = Convert.ToString(Math.Round(Mh, 5)) + " mph";
                            break;

                        case "Pie por Segundo":
                            Ps = Ms * 3.281;
                            lblResultado.Text = Convert.ToString(Math.Round(Ps, 5)) + " ft/s";
                            break;

                        case "Metro por Segundo":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Kilometro por Hora":
                            Kmh = Ms * 3.6;
                            lblResultado.Text = Convert.ToString(Math.Round(Kmh, 5)) + " km/h";
                            break;

                        case "Nudo":
                            N = Ms * 1.944;
                            lblResultado.Text = Convert.ToString(Math.Round(N, 5)) + " kn";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Kilometro por Hora":
                    Kmh = Convert.ToDouble(NumericEntry.Value);
                    switch(conversion2)
                    {
                        case "Milla por Hora":
                            Mh = Kmh / 1.609;
                            lblResultado.Text = Convert.ToString(Math.Round(Mh, 5)) + " mph";
                            break;

                        case "Pie por Segundo":
                            Ps = Kmh / 1.097;
                            lblResultado.Text = Convert.ToString(Math.Round(Ps, 5)) + " ft/s";
                            break;

                        case "Metro por Segundo":
                            Ms = Kmh / 3.6;
                            lblResultado.Text = Convert.ToString(Math.Round(Ms, 5)) + " m/s";
                            break;

                        case "Kilometro por Hora":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Nudo":
                            N = Kmh / 1.852;
                            lblResultado.Text = Convert.ToString(Math.Round(N, 5)) + " kn";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Nudo":
                    Kmh = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Milla por Hora":
                            Mh = N * 1.151;
                            lblResultado.Text = Convert.ToString(Math.Round(Mh, 5)) + " mph";
                            break;

                        case "Pie por Segundo":
                            Ps = N * 1.688;
                            lblResultado.Text = Convert.ToString(Math.Round(Ps, 5)) + " ft/s";
                            break;

                        case "Metro por Segundo":
                            Ms = N / 1.944;
                            lblResultado.Text = Convert.ToString(Math.Round(Ms, 5)) + " m/s";
                            break;

                        case "Kilometro por Hora":
                            Kmh = N * 1.852;
                            lblResultado.Text = Convert.ToString(Math.Round(Kmh, 5)) + " km/h";
                            break;

                        case "Nudo":
                            lblResultado.Text = "Elige otra unidad ";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                default:
                    lblResultado.Text = "Elige una unidad para convertir";
                    break;
            }
        }
    }
}