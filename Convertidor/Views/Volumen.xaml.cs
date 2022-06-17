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
    public partial class Volumen : ContentPage
    {
        double L, Ml, Mc, Ftc, Pc, Ole, Ge;
        string conversion, conversion2;
        public Volumen()
        {
            InitializeComponent();
            Title = "Volumen";
            PickUnidades.Items.Add("Litro");
            PickUnidades.Items.Add("Mililitro");
            PickUnidades.Items.Add("Metro Cubico");
            PickUnidades.Items.Add("Pie Cubico");
            PickUnidades.Items.Add("Pulgada Cubica");
            PickUnidades.Items.Add("Onza liquida estadounidense");
            PickUnidades.Items.Add("Galón estadounidense");

            PickUnidades2.Items.Add("Litro");
            PickUnidades2.Items.Add("Mililitro");
            PickUnidades2.Items.Add("Metro Cubico");
            PickUnidades2.Items.Add("Pie Cubico");
            PickUnidades2.Items.Add("Pulgada Cubica");
            PickUnidades2.Items.Add("Onza liquida estadounidense");
            PickUnidades2.Items.Add("Galón estadounidense");
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
                case "Litro":
                    L = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Litro":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Mililitro":
                            Ml = L * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Ml, 5)) + " mL";
                            break;

                        case "Metro Cubico":
                            Mc = L / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Mc, 5)) + " m³";
                            break;

                        case "Pie Cubico":
                            Ftc = L / 28.317;
                            lblResultado.Text = Convert.ToString(Math.Round(Ftc, 5)) + " ft³";
                            break;

                        case "Pulgada Cubica":
                            Pc = L / 61.024;
                            lblResultado.Text = Convert.ToString(Math.Round(Pc, 5)) + " in³";
                            break;

                        case "Onza liquida estadounidense":
                            Ole = L * 33.814;
                            lblResultado.Text = Convert.ToString(Math.Round(Ole, 5)) + " us fl oz";
                            break;

                        case "Galón estadounidense":
                            Ge = L / 3.785;
                            lblResultado.Text = Convert.ToString(Math.Round(Ge, 5)) + " gal";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Mililitro":
                    Ml = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Litro":
                            L = Ml / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(L, 5)) + " L";
                            break;

                        case "Mililitro":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Metro Cubico":
                            Mc = Ml / 1000000;
                            lblResultado.Text = Convert.ToString(Math.Round(Mc, 5)) + " m³";
                            break;

                        case "Pie Cubico":
                            Ftc = Ml / 28318;
                            lblResultado.Text = Convert.ToString(Math.Round(Ftc, 5)) + " ft³";
                            break;

                        case "Pulgada Cubica":
                            Pc = Ml / 16.387;
                            lblResultado.Text = Convert.ToString(Math.Round(Pc, 5)) + " in³";
                            break;

                        case "Onza liquida estadounidense":
                            Ole = Ml / 29.574;
                            lblResultado.Text = Convert.ToString(Math.Round(Ole, 5)) + " us fl oz";
                            break;

                        case "Galón estadounidense":
                            Ge = Ml / 3785;
                            lblResultado.Text = Convert.ToString(Math.Round(Ge, 5)) + " gal";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Metro Cubico":
                    Mc = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Litro":
                            L = Mc * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(L, 5)) + " L";
                            break;

                        case "Mililitro":
                            Ml = Mc * 100000;
                            lblResultado.Text = Convert.ToString(Math.Round(Ml, 5)) + " mL";
                            break;

                        case "Metro Cubico":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Pie Cubico":
                            Ftc = Mc * 35.315;
                            lblResultado.Text = Convert.ToString(Math.Round(Ftc, 5)) + " ft³";
                            break;

                        case "Pulgada Cubica":
                            Pc = Mc * 61024;
                            lblResultado.Text = Convert.ToString(Math.Round(Pc, 5)) + " in³";
                            break;

                        case "Onza liquida estadounidense":
                            Ole = Mc * 33814;
                            lblResultado.Text = Convert.ToString(Math.Round(Ole, 5)) + " us fl oz";
                            break;

                        case "Galón estadounidense":
                            Ge = Mc * 264;
                            lblResultado.Text = Convert.ToString(Math.Round(Ge, 5)) + " gal";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pie Cubico":
                    Ftc = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Litro":
                            L = Ftc * 28.317;
                            lblResultado.Text = Convert.ToString(Math.Round(L, 5)) + " L";
                            break;

                        case "Mililitro":
                            Ml = Ftc * 28316.8;
                            lblResultado.Text = Convert.ToString(Math.Round(Ml, 5)) + " mL";
                            break;

                        case "Metro Cubico":
                            Mc = Ftc / 35.315;
                            lblResultado.Text = Convert.ToString(Math.Round(Mc, 5)) + " m³";
                            break;

                        case "Pie Cubico":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Pulgada Cubica":
                            Pc = Ftc * 1728;
                            lblResultado.Text = Convert.ToString(Math.Round(Pc, 5)) + " in³";
                            break;

                        case "Onza liquida estadounidense":
                            Ole = Ftc * 957.506;
                            lblResultado.Text = Convert.ToString(Math.Round(Ole, 5)) + " us fl oz";
                            break;

                        case "Galón estadounidense":
                            Ge = Ftc * 7.481;
                            lblResultado.Text = Convert.ToString(Math.Round(Ge, 5)) + " gal";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pulgada Cubica":
                    Pc = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Litro":
                            L = Pc / 61.024;
                            lblResultado.Text = Convert.ToString(Math.Round(L, 5)) + " L";
                            break;

                        case "Mililitro":
                            Ml = Pc * 16.387;
                            lblResultado.Text = Convert.ToString(Math.Round(Ml, 5)) + " mL";
                            break;

                        case "Metro Cubico":
                            Mc = Pc / 61024;
                            lblResultado.Text = Convert.ToString(Math.Round(Mc, 5)) + " m³";
                            break;

                        case "Pie Cubico":
                            Ftc = Pc / 1728;
                            lblResultado.Text = Convert.ToString(Math.Round(Ftc, 5)) + " ft³";
                            break;

                        case "Pulgada Cubica":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Onza liquida estadounidense":
                            Ole = Pc / 1.805;
                            lblResultado.Text = Convert.ToString(Math.Round(Ole, 5)) + " us fl oz";
                            break;

                        case "Galón estadounidense":
                            Ge = Pc / 231;
                            lblResultado.Text = Convert.ToString(Math.Round(Ge, 5)) + " gal";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Onza liquida estadounidense":
                    Ole = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Litro":
                            L = Ole / 33.814;
                            lblResultado.Text = Convert.ToString(Math.Round(L, 5)) + " L";
                            break;

                        case "Mililitro":
                            Ml = Ole * 29.574;
                            lblResultado.Text = Convert.ToString(Math.Round(Ml, 5)) + " mL";
                            break;

                        case "Metro Cubico":
                            Mc = Ole / 33814;
                            lblResultado.Text = Convert.ToString(Math.Round(Mc, 5)) + " m³";
                            break;

                        case "Pie Cubico":
                            Ftc = Ole / 958;
                            lblResultado.Text = Convert.ToString(Math.Round(Ftc, 5)) + " ft³";
                            break;

                        case "Pulgada Cubica":
                            Pc = Ole * 1.805;
                            lblResultado.Text = Convert.ToString(Math.Round(Pc, 5)) + " in³";
                            break;

                        case "Onza liquida estadounidense":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        case "Galón estadounidense":
                            Ge = Ole / 128;
                            lblResultado.Text = Convert.ToString(Math.Round(Ge, 5)) + " gal";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Galón estadounidense":
                    Ge = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Litro":
                            L = Ge * 3.785;
                            lblResultado.Text = Convert.ToString(Math.Round(L, 5)) + " L";
                            break;

                        case "Mililitro":
                            Ml = Ge * 3785;
                            lblResultado.Text = Convert.ToString(Math.Round(Ml, 5)) + " mL";
                            break;

                        case "Metro Cubico":
                            Mc = Ge / 264;
                            lblResultado.Text = Convert.ToString(Math.Round(Mc, 5)) + " m³";
                            break;

                        case "Pie Cubico":
                            Ftc = Ge / 7.481;
                            lblResultado.Text = Convert.ToString(Math.Round(Ftc, 5)) + " ft³";
                            break;

                        case "Pulgada Cubica":
                            Pc = Ge * 231;
                            lblResultado.Text = Convert.ToString(Math.Round(Pc, 5)) + " in³";
                            break;

                        case "Onza liquida estadounidense":
                            Ole = Ge * 128;
                            lblResultado.Text = Convert.ToString(Math.Round(Ole, 5)) + " us fl oz";
                            break;

                        case "Galón estadounidense":
                            lblResultado.Text = "Elige otra unidad";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                default:
                    lblResultado.Text = "Elige una unidad";
                    break;
            }
        }

    }
}