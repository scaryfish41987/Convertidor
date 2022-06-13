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
    public partial class Energia : ContentPage
    {
        double J, Kj, Cal, Kcal, Vh, Kvh, Elec, Btu, Te, Plf;
        string conversion,conversion2;
        public Energia()
        {
            InitializeComponent();
            Title = "Energia";
            PickUnidades.Items.Add("Joule");
            PickUnidades.Items.Add("Kilojoule");
            PickUnidades.Items.Add("Caloria");
            PickUnidades.Items.Add("Kilocaloria");
            PickUnidades.Items.Add("Vatio-Hora");
            PickUnidades.Items.Add("Kilovatio-Hora");
            PickUnidades.Items.Add("Electronvoltio");
            PickUnidades.Items.Add("BTU");
            PickUnidades.Items.Add("Termia");
            PickUnidades.Items.Add("Pie-Libra fuerza");

            PickUnidades2.Items.Add("Joule");
            PickUnidades2.Items.Add("Kilojoule");
            PickUnidades2.Items.Add("Caloria");
            PickUnidades2.Items.Add("Kilocaloria");
            PickUnidades2.Items.Add("Vatio-Hora");
            PickUnidades2.Items.Add("Kilovatio-Hora");
            PickUnidades2.Items.Add("Electronvoltio");
            PickUnidades2.Items.Add("BTU");
            PickUnidades2.Items.Add("Termia");
            PickUnidades2.Items.Add("Pie-Libra fuerza");
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
                case "Joule":
                    J = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Kilojoule":
                            Kj = J / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = J / 4.184;
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = J / 4184;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = J / 3600;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = J / 3600000;
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " KWh";
                            break;

                        case "Electronvoltio":
                            Elec = J * (6.242 * Math.Pow(10, 18));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = J / 1055;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            Te = J / (1.055 * Math.Pow(10, 8));
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = J / 1.356;
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Kilojoule":
                    Kj = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Kj * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Caloria":
                            Cal = Kj * 239.006;
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = Kj / 4.184;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = Kj / 3.6;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Kj / 3600;
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " KWh";
                            break;

                        case "Electronvoltio":
                            Elec = Kj * (6.242 * Math.Pow(10, 21));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = Kj / 1.055;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            Te = Kj / 105480;
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Kj * 738;
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Caloria":
                    Cal = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Cal * 4.184;
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Cal / 239.006;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " cal";
                            break;

                        case "Caloria":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Kilocaloria":
                            Kcal = Cal / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = Cal / 860;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Cal / 860424;
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " kWh";
                            break;

                        case "Electronvoltio":
                            Elec = Cal * (2.611 * Math.Pow(10, 21));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = Cal / 252;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;
                            
                        case "Termia":
                            Te = Cal * (2.521 * Math.Pow(10,7));
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Cal * 3.086;
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Kilocaloria":
                    Kcal = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Kcal * 4184;
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Kcal * 4.184;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = Kcal * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Vatio-Hora":
                            Vh = Kcal / 1.162;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Kcal / 860;
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " kWh";
                            break;

                        case "Electronvoltio":
                            Elec = Kcal * (2.611 * Math.Pow(10, 22));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = Kcal * 3.966;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            Te = Kcal / 25210;
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Kcal * 3085.96;
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Vatio-Hora":
                    Vh = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Vh * 3600;
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Vh * 3.6;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = Vh * 860.421;
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = Vh / 1.162;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Vh / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " kWh";
                            break;

                        case "Electronvoltio":
                            Elec = Vh * (2.247 * Math.Pow(10, 22));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = Vh * 3.412;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            Te = Vh / 29300;
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Vh * 2655;
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Kilovatio-Hora":
                    Kvh = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Kvh * (3.6 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Kvh * 3600;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = Kvh * 860421;
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = Kvh * 860.421;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = Kvh * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Electronvoltio":
                            Elec = Kvh * (2.247 * Math.Pow(10, 25));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = Kvh * 3412.14;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            Te = Kvh / 29.3;
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Kvh * (2.655 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Electronvoltio":
                    Elec = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Elec / (6.242 * Math.Pow(10, 18));
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Elec / (6.242 * Math.Pow(10, 21));
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = Elec / (2.611 * Math.Pow(10, 18));
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = Elec / (2.611 * Math.Pow(10, 22));
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = Elec / (2.247 * Math.Pow(10, 22));
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Elec / (2.247 * Math.Pow(10, 25));
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " kWh";
                            break;

                        case "Electronvoltio":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "BTU":
                            Btu = Elec / (6.585 * Math.Pow(10, 21));
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            Te = Elec / (6.584 * Math.Pow(10, 26));
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Elec / (8.462 * Math.Pow(10, 18));
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "BTU":
                    Btu = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Btu * 1055.06; 
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Btu * 1.055;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = Btu * 252.164;
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = Btu / 3.966;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = Btu / 3.412;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Btu / 3412;
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " kWh";
                            break;

                        case "Electronvoltio":
                            Elec = Btu * (6.585 * Math.Pow(10, 21));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Termia":
                            Te = Btu / 99976;
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Btu * 778;
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Termia":
                    Te = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Te * (1.05480 * Math.Pow(10, 8));
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Te * 105480;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = Te * (2.52104 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = Te * 25210.4;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = Te * 29300.1;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Te * 29.3001;
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " kWh";
                            break;

                        case "Electronvoltio":
                            Elec = Te * (6.584 * Math.Pow(10, 26));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = Te * 99976.1;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Pie-Libra fuerza":
                            Plf = Te * (7.78 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(Plf, 5)) + " ft/lbf";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pie-Libra fuerza":
                    Plf = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Joule":
                            J = Plf * 1.3582;
                            lblResultado.Text = Convert.ToString(Math.Round(J, 5)) + " j";
                            break;

                        case "Kilojoule":
                            Kj = Plf / 738;
                            lblResultado.Text = Convert.ToString(Math.Round(Kj, 5)) + " kj";
                            break;

                        case "Caloria":
                            Cal = Plf / 3.086;
                            lblResultado.Text = Convert.ToString(Math.Round(Cal, 5)) + " cal";
                            break;

                        case "Kilocaloria":
                            Kcal = Plf / 3086;
                            lblResultado.Text = Convert.ToString(Math.Round(Kcal, 5)) + " kcal";
                            break;

                        case "Vatio-Hora":
                            Vh = Plf / 2655;
                            lblResultado.Text = Convert.ToString(Math.Round(Vh, 5)) + " Wh";
                            break;

                        case "Kilovatio-Hora":
                            Kvh = Plf / (2.655 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(Kvh, 5)) + " kWh";
                            break;

                        case "Electronvoltio":
                            Elec = Plf * (8.462 * Math.Pow(10, 18));
                            lblResultado.Text = Convert.ToString(Math.Round(Elec, 5)) + " eV";
                            break;

                        case "BTU":
                            Btu = Plf / 778;
                            lblResultado.Text = Convert.ToString(Math.Round(Btu, 5)) + " BTU";
                            break;

                        case "Termia":
                            Te = Plf / (7.78 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(Te, 5)) + " th";
                            break;

                        case "Pie-Libra fuerza":
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