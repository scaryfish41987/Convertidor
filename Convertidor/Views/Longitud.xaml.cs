using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Convertidor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Longitud : ContentPage
    {
        double Km, M, Cm, Mm, Mi, Yd, Ft, In;
        string conversion, conversion2;
        public Longitud()
        {
            InitializeComponent();
            Title = "Longitud";
            PickUnidades.Items.Add("Kilómetro");
            PickUnidades.Items.Add("Metro");
            PickUnidades.Items.Add("Centimetro");
            PickUnidades.Items.Add("Milimetro");
            PickUnidades.Items.Add("Milla");
            PickUnidades.Items.Add("Yarda");
            PickUnidades.Items.Add("Pie");
            PickUnidades.Items.Add("Pulgada");

            PickUnidades2.Items.Add("Kilómetro");
            PickUnidades2.Items.Add("Metro");
            PickUnidades2.Items.Add("Centimetro");
            PickUnidades2.Items.Add("Milimetro");
            PickUnidades2.Items.Add("Milla");
            PickUnidades2.Items.Add("Yarda");
            PickUnidades2.Items.Add("Pie");
            PickUnidades2.Items.Add("Pulgada");
        }

        private void PickUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            conversion = Convert.ToString(PickUnidades.SelectedItem);
            NumericEntry.Value = 0;
            lblResultado.Text = "0,0";
        }

        private void PickUnidades2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conversion2 = Convert.ToString(PickUnidades2.SelectedItem);
            lblResultado.Text = "0,0";
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            switch (conversion)
            {
                case "Kilómetro":
                    Km = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Metro":
                            M = Km * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(M, 5)) + " m";
                            break;

                        case "Centimetro":
                            Cm = Km * 100000;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " cm";
                            break;

                        case "Milimetro":
                            Mm = Km * 1000000;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " mm";
                            break;

                        case "Milla":
                            Mi = Km / 1.609;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " mi";
                            break;

                        case "Yarda":
                            Yd = Km * 1093.61;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " yd";
                            break;

                        case "Pie":
                            Ft = Km * 3280.84;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " ft";
                            break;

                        case "Pulgada":
                            In = Km * 39370.1;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " in";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Metro":
                    M = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            Km = M / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Km, 5)) + " km";
                            break;

                        case "Metro":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Centimetro":
                            Cm = M * 100;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " cm";
                            break;

                        case "Milimetro":
                            Mm = M * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " mm";
                            break;

                        case "Milla":
                            Mi = M / 1609;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " mi";
                            break;

                        case "Yarda":
                            Yd = M * 1.09361;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " yd";
                            break;

                        case "Pie":
                            Ft = M * 3.28084;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " ft";
                            break;

                        case "Pulgada":
                            In = Km * 39.3701;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " in";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Centimetro":
                    Cm = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            Km = Cm / 100000;
                            lblResultado.Text = Convert.ToString(Math.Round(Km, 5)) + " km";
                            break;

                        case "Metro":
                            M = Cm / 100;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " m";
                            break;

                        case "Centimetro":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Milimetro":
                            Mm = Cm * 10;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " mm";
                            break;

                        case "Milla":
                            Mi = M / 160900;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " mi";
                            break;

                        case "Yarda":
                            Yd = Cm / 91.44;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " yd";
                            break;

                        case "Pie":
                            Ft = Cm / 30.48;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " ft";
                            break;

                        case "Pulgada":
                            In = Cm / 2.54;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " in";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Milimetro":
                    Mm = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            Km = Mm / 1000000;
                            lblResultado.Text = Convert.ToString(Math.Round(Km, 5)) + " km";
                            break;

                        case "Metro":
                            M = Mm / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " m";
                            break;

                        case "Centimetro":
                            Cm = Mm / 10;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " cm";
                            break;

                        case "Milimetro":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Milla":
                            Mi = Mm / 1609000;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " mi";
                            break;

                        case "Yarda":
                            Yd = Mm / 914.4;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " yd";
                            break;

                        case "Pie":
                            Ft = Cm / 304.8;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " ft";
                            break;

                        case "Pulgada":
                            In = Cm / 25.4;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " in";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Milla":
                    Mi = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            Km = Mi * 1.609;
                            lblResultado.Text = Convert.ToString(Math.Round(Km, 5)) + " km";
                            break;

                        case "Metro":
                            M = Mi * 1609;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " mm";
                            break;

                        case "Centimetro":
                            Cm = Mi * 160900;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " cm";
                            break;

                        case "Milimetro":
                            Mm = Mi * 1609000;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " mm";
                            break;

                        case "Milla":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Yarda":
                            Yd = Mi * 1760;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " yd";
                            break;

                        case "Pie":
                            Ft = Mi * 5280;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " ft";
                            break;

                        case "Pulgada":
                            In = Mi * 63360;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " in";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Yarda":
                    Yd = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            Km = Yd / 1093.61;
                            lblResultado.Text = Convert.ToString(Math.Round(Km, 5)) + " km";
                            break;

                        case "Metro":
                            M = Yd / 1.09361;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " m";
                            break;

                        case "Centimetro":
                            Cm = Yd * 91.44;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " cm";
                            break;

                        case "Milimetro":
                            Mm = Yd * 914.4;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " mm";
                            break;

                        case "Milla":
                            Mi = Yd / 1760;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " mi";
                            break;

                        case "Yarda":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Pie":
                            Ft = Yd * 3;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " ft";
                            break;

                        case "Pulgada":
                            In = Yd * 36;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " in";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pie":
                    Ft = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            Km = Ft / 3280.84;
                            lblResultado.Text = Convert.ToString(Math.Round(Km, 5)) + " km";
                            break;

                        case "Metro":
                            M = Ft / 3.28084;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " m";
                            break;

                        case "Centimetro":
                            Cm = Ft * 30.48;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " cm";
                            break;

                        case "Milimetro":
                            Mm = Ft * 304.8;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " mm";
                            break;

                        case "Milla":
                            Mi = Ft / 5280;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " mi";
                            break;

                        case "Yarda":
                            Yd = Ft / 3;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " yd";
                            break;

                        case "Pie":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Pulgada":
                            In = Ft * 12;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " in";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pulgada":
                    In = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro":
                            Km = In / 39370.1;
                            lblResultado.Text = Convert.ToString(Math.Round(Km, 5)) + " km";
                            break;

                        case "Metro":
                            M = In / 39.3701;
                            lblResultado.Text = Convert.ToString(Math.Round(Cm, 5)) + " m";
                            break;

                        case "Centimetro":
                            Cm = In * 2.54;
                            lblResultado.Text = Convert.ToString(Math.Round(Yd, 5)) + " cm";
                            break;

                        case "Milimetro":
                            Mm = In * 25.4;
                            lblResultado.Text = Convert.ToString(Math.Round(Mm, 5)) + " mm";
                            break;

                        case "Milla":
                            Mi = In / 63360;
                            lblResultado.Text = Convert.ToString(Math.Round(Mi, 5)) + " mi";
                            break;

                        case "Yarda":
                            Yd = In / 36;
                            lblResultado.Text = Convert.ToString(Math.Round(Ft, 5)) + " yd";
                            break;

                        case "Pie":
                            Ft = In / 12;
                            lblResultado.Text = Convert.ToString(Math.Round(In, 5)) + " ft";
                            break;

                        case "Pulgada":
                            lblResultado.Text = "Escoge otra unidad";
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