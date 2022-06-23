using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Convertidor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Masa : ContentPage
    {
        double T, Kg, G, lb, oz;
        string conversion, conversion2;
        public Masa()
        {
            InitializeComponent();
            Title = "Masa";
            PickUnidades.Items.Add("Tonelada");
            PickUnidades.Items.Add("Kilogramo");
            PickUnidades.Items.Add("Gramo");
            PickUnidades.Items.Add("Libra");
            PickUnidades.Items.Add("Onza");

            PickUnidades2.Items.Add("Tonelada");
            PickUnidades2.Items.Add("Kilogramo");
            PickUnidades2.Items.Add("Gramo");
            PickUnidades2.Items.Add("Libra");
            PickUnidades2.Items.Add("Onza");
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
                case "Tonelada":
                    T = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {                    
                        case "Tonelada":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Kilogramo":
                            Kg = T * 1000;
                            lblResultado.Text = Convert.ToDouble(Math.Round(Kg, 5)) + " kg";
                            break;

                        case "Gramo":
                            G = T * 1000000;
                            lblResultado.Text = Convert.ToDouble(Math.Round(G, 5)) + " g";
                            break;

                        case "Libra":
                            lb = T * 2204.62;
                            lblResultado.Text = Convert.ToDouble(Math.Round(lb, 5)) + " lb";
                            break;

                        case "Onza":
                            oz = T * 35274;
                            lblResultado.Text = Convert.ToDouble(Math.Round(oz, 5)) + " oz";
                            break;

                        default:
                            lblResultado.Text = "Escoge una unidad";
                            break;
                    }
                    break;

                case "Kilogramo":
                    Kg = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Tonelada":
                            T = Kg / 1000;
                            lblResultado.Text = Convert.ToDouble(Math.Round(T, 5)) + " tn";
                            break;

                        case "Kilogramo":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Gramo":
                            G = Kg * 1000;
                            lblResultado.Text = Convert.ToDouble(Math.Round(G, 5)) + " g";
                            break;

                        case "Libra":
                            lb = Kg * 2.20462;
                            lblResultado.Text = Convert.ToDouble(Math.Round(lb, 5)) + " lb";
                            break;

                        case "Onza":
                            oz = Kg * 35.274; 
                            lblResultado.Text = Convert.ToDouble(Math.Round(oz, 5)) + " oz";
                            break;

                        default:
                            lblResultado.Text = "Escoge una unidad";
                            break;
                    }
                    break;

                case "Gramo":
                    G = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Tonelada":
                            T = G / 1000000;
                            lblResultado.Text = Convert.ToDouble(Math.Round(T, 5)) + " tn";
                            break;

                        case "Kilogramo":
                            Kg = G * 1000;
                            lblResultado.Text = Convert.ToDouble(Math.Round(Kg, 5)) + " kg";
                            break;

                        case "Gramo":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Libra":
                            lb = G / 453.6;
                            lblResultado.Text = Convert.ToDouble(Math.Round(lb, 5)) + " lb";
                            break;

                        case "Onza":
                            oz = G / 28.35;
                            lblResultado.Text = Convert.ToDouble(Math.Round(oz, 5)) + " oz";
                            break;

                        default:
                            lblResultado.Text = "Escoge una unidad";
                            break;
                    }
                    break;

                case "Libra":
                    lb = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Tonelada":
                            T = lb / 2204.62;
                            lblResultado.Text = Convert.ToDouble(Math.Round(T, 5)) + " tn";
                            break;

                        case "Kilogramo":
                            Kg = lb / 2.20462;
                            lblResultado.Text = Convert.ToDouble(Math.Round(Kg, 5)) + " kg";
                            break;

                        case "Gramo":
                            G = lb * 453.592;
                            lblResultado.Text = Convert.ToDouble(Math.Round(G, 5)) + " g";
                            break;

                        case "Libra":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Onza":
                            oz = lb * 16;
                            lblResultado.Text = Convert.ToDouble(Math.Round(oz, 5)) + " oz";
                            break;

                        default:
                            lblResultado.Text = "Escoge una unidad";
                            break;
                    }
                    break;

                case "Onza":
                    oz = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Tonelada":
                            T = oz / 35254;
                            lblResultado.Text = Convert.ToDouble(Math.Round(T, 5)) + " tn";
                            break;

                        case "Kilogramo":
                            Kg = oz / 35.254;
                            lblResultado.Text = Convert.ToDouble(Math.Round(Kg, 5)) + " kg";
                            break;

                        case "Gramo":
                            G = oz * 28.3495;
                            lblResultado.Text = Convert.ToDouble(Math.Round(G, 5)) + " g";
                            break;

                        case "Libra":
                            lb = oz / 16;
                            lblResultado.Text = Convert.ToDouble(Math.Round(lb, 5)) + " lb";
                            break;

                        case "Onza":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        default:
                            lblResultado.Text = "Escoge una unidad";
                            break;
                    }
                    break;

                default:
                    lblResultado.Text = "Escoge una unidad";
                    break;
            }
        }

    }
}