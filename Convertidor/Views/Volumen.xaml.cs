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
        double L, Ml, Mc, Ftc, Pc, Oi, Gi;
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
            PickUnidades.Items.Add("Onza Imperial");
            PickUnidades.Items.Add("Galon Imperial");

            PickUnidades2.Items.Add("Litro");
            PickUnidades2.Items.Add("Mililitro");
            PickUnidades2.Items.Add("Metro Cubico");
            PickUnidades2.Items.Add("Pie Cubico");
            PickUnidades2.Items.Add("Pulgada Cubica");
            PickUnidades2.Items.Add("Onza Imperial");
            PickUnidades2.Items.Add("Galon Imperial");
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
                    switch (conversion)
                    {
                        case "Litro":
                            break;

                        case "Mililitro":
                            break;

                        case "Metro Cubico":
                            break;

                        case "Pie Cubico":
                            break;

                        case "Pulgada Cubica":
                            break;

                        case "Onza Imperial":
                            break;

                        case "Galon Imperial":
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Mililitro":
                    Ml = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion)
                    {
                        case "Litro":
                            break;

                        case "Mililitro":
                            break;

                        case "Metro Cubico":
                            break;

                        case "Pie Cubico":
                            break;

                        case "Pulgada Cubica":
                            break;

                        case "Onza Imperial":
                            break;

                        case "Galon Imperial":
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Metro Cubico":
                    Mc = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion)
                    {
                        case "Litro":
                            break;

                        case "Mililitro":
                            break;

                        case "Metro Cubico":
                            break;

                        case "Pie Cubico":
                            break;

                        case "Pulgada Cubica":
                            break;

                        case "Onza Imperial":
                            break;

                        case "Galon Imperial":
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pie Cubico":
                    Ftc = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion)
                    {
                        case "Litro":
                            break;

                        case "Mililitro":
                            break;

                        case "Metro Cubico":
                            break;

                        case "Pie Cubico":
                            break;

                        case "Pulgada Cubica":
                            break;

                        case "Onza Imperial":
                            break;

                        case "Galon Imperial":
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pulgada Cubica":
                    Pc = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion)
                    {
                        case "Litro":
                            break;

                        case "Mililitro":
                            break;

                        case "Metro Cubico":
                            break;

                        case "Pie Cubico":
                            break;

                        case "Pulgada Cubica":
                            break;

                        case "Onza Imperial":
                            break;

                        case "Galon Imperial":
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Onza Imperial":
                    Oi = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion)
                    {
                        case "Litro":
                            break;

                        case "Mililitro":
                            break;

                        case "Metro Cubico":
                            break;

                        case "Pie Cubico":
                            break;

                        case "Pulgada Cubica":
                            break;

                        case "Onza Imperial":
                            break;

                        case "Galon Imperial":
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Galon Imperial":
                    Gi = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion)
                    {
                        case "Litro":
                            break;

                        case "Mililitro":
                            break;

                        case "Metro Cubico":
                            break;

                        case "Pie Cubico":
                            break;

                        case "Pulgada Cubica":
                            break;

                        case "Onza Imperial":
                            break;

                        case "Galon Imperial":
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