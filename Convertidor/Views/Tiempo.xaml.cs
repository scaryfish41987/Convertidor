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
    public partial class Tiempo : ContentPage
    {
        double seg, min, hr, dd, sem, mm, yy;
        string conversion, conversion2;
        public Tiempo()
        {
            InitializeComponent();
            Title = "Tiempo";
            PickUnidades.Items.Add("Segundo");
            PickUnidades.Items.Add("Minuto");
            PickUnidades.Items.Add("Hora");
            PickUnidades.Items.Add("Dia");
            PickUnidades.Items.Add("Semana");
            PickUnidades.Items.Add("Mes");
            PickUnidades.Items.Add("Año");

            PickUnidades2.Items.Add("Segundo");
            PickUnidades2.Items.Add("Minuto");
            PickUnidades2.Items.Add("Hora");
            PickUnidades2.Items.Add("Dia");
            PickUnidades2.Items.Add("Semana");
            PickUnidades2.Items.Add("Mes");
            PickUnidades2.Items.Add("Año");
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
                case "Segundo":
                    seg = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Segundo":                            
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Minuto":
                            min = seg / 60;
                            lblResultado.Text = Convert.ToString(Math.Round(min, 5)) + " min";
                            break;

                        case "Hora":
                            hr = seg / 3600;
                            lblResultado.Text = Convert.ToString(Math.Round(hr, 5)) + " hr";
                            break;

                        case "Dia":
                            dd = seg / 86400;
                            lblResultado.Text = Convert.ToString(Math.Round(dd, 5)) + " d";
                            break;

                        case "Semana":
                            sem = seg / 604800;
                            lblResultado.Text = Convert.ToString(Math.Round(sem, 5)) + " semana/s";
                            break;

                        case "Mes":
                            mm = seg / (2.628 * Math.Pow(10,6));
                            lblResultado.Text = Convert.ToString(Math.Round(mm, 5)) + " mes";
                            break;

                        case "Año":
                            yy = seg / (3.157 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(yy, 5)) + " yr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Minuto":
                    min = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Segundo":
                            seg = min * 60;
                            lblResultado.Text = Convert.ToString(Math.Round(seg, 5)) + " seg";                            
                            break;

                        case "Minuto":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Hora":
                            hr = min / 60;
                            lblResultado.Text = Convert.ToString(Math.Round(hr, 5)) + " hr";
                            break;

                        case "Dia":
                            dd = min / 1440;
                            lblResultado.Text = Convert.ToString(Math.Round(dd, 5)) + " d";
                            break;

                        case "Semana":
                            sem = min / 10080;
                            lblResultado.Text = Convert.ToString(Math.Round(sem, 5)) + " semana/s";
                            break;

                        case "Mes":
                            mm = min / 43800;
                            lblResultado.Text = Convert.ToString(Math.Round(mm, 5)) + " mes";
                            break;

                        case "Año":
                            yy = min / 525600;
                            lblResultado.Text = Convert.ToString(Math.Round(yy, 5)) + " yr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Hora":
                    hr = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Segundo":
                            seg = hr * 3600;
                            lblResultado.Text = Convert.ToString(Math.Round(seg, 5)) + " seg";
                            break;

                        case "Minuto":
                            min = hr * 60;
                            lblResultado.Text = Convert.ToString(Math.Round(min, 5)) + " min";
                            break;

                        case "Hora":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Dia":
                            dd = hr / 24;
                            lblResultado.Text = Convert.ToString(Math.Round(dd, 5)) + " d";
                            break;

                        case "Semana":
                            sem = hr / 168;
                            lblResultado.Text = Convert.ToString(Math.Round(sem, 5)) + " semana/s";
                            break;

                        case "Mes":
                            mm = hr / 730.001;
                            lblResultado.Text = Convert.ToString(Math.Round(mm, 5)) + " mes";
                            break;

                        case "Año":
                            yy = hr / 8760;
                            lblResultado.Text = Convert.ToString(Math.Round(yy, 5)) + " yr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Dia":
                    dd = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Segundo":
                            seg = dd * 86400;
                            lblResultado.Text = Convert.ToString(Math.Round(seg, 5)) + " seg";
                            break;

                        case "Minuto":
                            min = dd * 1440;
                            lblResultado.Text = Convert.ToString(Math.Round(min, 5)) + " min";
                            break;

                        case "Hora":
                            hr = dd * 24;
                            lblResultado.Text = Convert.ToString(Math.Round(hr, 5)) + " hr";
                            break;

                        case "Dia":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Semana":
                            sem = dd / 7;
                            lblResultado.Text = Convert.ToString(Math.Round(sem, 5)) + " semana/s";
                            break;

                        case "Mes":
                            mm = dd / 730.001;
                            lblResultado.Text = Convert.ToString(Math.Round(mm, 5)) + " mes";
                            break;

                        case "Año":
                            yy = dd / 365;
                            lblResultado.Text = Convert.ToString(Math.Round(yy, 5)) + " yr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;                    

                case "Semana":
                    sem = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Segundo":
                            seg = sem * 604800;
                            lblResultado.Text = Convert.ToString(Math.Round(seg, 5)) + " seg";
                            break;

                        case "Minuto":
                            min = sem * 10080;
                            lblResultado.Text = Convert.ToString(Math.Round(min, 5)) + " min";
                            break;

                        case "Hora":
                            hr = sem * 168;
                            lblResultado.Text = Convert.ToString(Math.Round(hr, 5)) + " hr";
                            break;

                        case "Dia":
                            dd = sem * 7;
                            lblResultado.Text = Convert.ToString(Math.Round(dd, 5)) + " d";
                            break;

                        case "Semana":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Mes":
                            mm = sem / 4.345;
                            lblResultado.Text = Convert.ToString(Math.Round(mm, 5)) + " mes";
                            break;

                        case "Año":
                            yy = sem / 52.143;
                            lblResultado.Text = Convert.ToString(Math.Round(yy, 5)) + " yr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Mes":
                    mm = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Segundo":
                            seg = mm * (2.628 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(seg, 5)) + " seg";
                            break;

                        case "Minuto":
                            min = mm * 43800;
                            lblResultado.Text = Convert.ToString(Math.Round(min, 5)) + " min";
                            break;

                        case "Hora":
                            hr = mm * 730;
                            lblResultado.Text = Convert.ToString(Math.Round(hr, 5)) + " hr";
                            break;

                        case "Dia":
                            dd = mm * 30.417;
                            lblResultado.Text = Convert.ToString(Math.Round(dd, 5)) + " d";
                            break;

                        case "Semana":
                            sem = mm * 4.345;
                            lblResultado.Text = Convert.ToString(Math.Round(sem, 5)) + " semana/s";
                            break;

                        case "Mes":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Año":
                            yy = mm / 12;
                            lblResultado.Text = Convert.ToString(Math.Round(yy, 5)) + " yr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Año":
                    yy = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Segundo":
                            seg = mm * (3.154 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(seg, 5)) + " seg";
                            break;

                        case "Minuto":
                            min = yy * 525600;
                            lblResultado.Text = Convert.ToString(Math.Round(min, 5)) + " min";
                            break;

                        case "Hora":
                            hr = yy * 8760;
                            lblResultado.Text = Convert.ToString(Math.Round(hr, 5)) + " hr";
                            break;

                        case "Dia":
                            dd = yy * 365;
                            lblResultado.Text = Convert.ToString(Math.Round(dd, 5)) + " d";
                            break;

                        case "Semana":
                            sem = yy *52.143;
                            lblResultado.Text = Convert.ToString(Math.Round(sem, 5)) + " semana/s";
                            break;

                        case "Mes":
                            mm = yy * 12;
                            lblResultado.Text = Convert.ToString(Math.Round(mm, 5)) + " mes";
                            break;

                        case "Año":
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