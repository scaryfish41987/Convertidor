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
    public partial class Presion : ContentPage
    {
        double atm, bar,kpa, psi, mpa, pa, torr;
        string conversion, conversion2;
        public Presion()
        {
            InitializeComponent();
            Title = "Presión";
            PickUnidades.Items.Add("Atmósfera");
            PickUnidades.Items.Add("Bar");
            PickUnidades.Items.Add("Kilopascal");
            PickUnidades.Items.Add("Libra por pulgada cuadrada");
            PickUnidades.Items.Add("Megapascal");
            PickUnidades.Items.Add("Pascal");
            PickUnidades.Items.Add("Torr");

            PickUnidades2.Items.Add("Atmósfera");
            PickUnidades2.Items.Add("Bar");
            PickUnidades2.Items.Add("Kilopascal");
            PickUnidades2.Items.Add("Libra por pulgada cuadrada");
            PickUnidades2.Items.Add("Megapascal");
            PickUnidades2.Items.Add("Pascal");
            PickUnidades2.Items.Add("Torr");
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
                case "Atmósfera":
                    atm = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Atmósfera":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Bar":
                            bar = atm * 1.01325;
                            lblResultado.Text = Convert.ToString(Math.Round(bar, 5)) + " bar";
                            break;

                        case "Kilopascal":
                            kpa = atm * 101.325;
                            lblResultado.Text = Convert.ToString(Math.Round(kpa, 5)) + " kPa";
                            break;

                        case "Libra por pulgada cuadrada":
                            psi = atm * 14.6959;
                            lblResultado.Text = Convert.ToString(Math.Round(psi, 5)) + " psi";
                            break;

                        case "Megapascal":
                            mpa = atm / 9.86923;
                            lblResultado.Text = Convert.ToString(Math.Round(mpa, 5)) + " MPa";
                            break;

                        case "Pascal":
                            pa = atm * 101325;
                            lblResultado.Text = Convert.ToString(Math.Round(pa, 5)) + " Pa";
                            break;

                        case "Torr":
                            torr = atm * 760;
                            lblResultado.Text = Convert.ToString(Math.Round(torr, 5)) + " torr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Bar":
                    bar = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Atmósfera":
                            atm = bar / 1.01325;
                            lblResultado.Text = Convert.ToString(Math.Round(atm, 5)) + " atm";
                            break;

                        case "Bar":
                            lblResultado.Text = "Escoge otra unidad";                                                        
                            break;

                        case "Kilopascal":
                            kpa = bar * 100;
                            lblResultado.Text = Convert.ToString(Math.Round(kpa, 5)) + " kPa";
                            break;

                        case "Libra por pulgada cuadrada":
                            psi = bar * 14.5038;
                            lblResultado.Text = Convert.ToString(Math.Round(psi, 5)) + " psi";
                            break;

                        case "Megapascal":
                            mpa = bar / 10;
                            lblResultado.Text = Convert.ToString(Math.Round(mpa, 5)) + " MPa";
                            break;

                        case "Pascal":
                            pa = bar * 100000;
                            lblResultado.Text = Convert.ToString(Math.Round(pa, 5)) + " Pa";
                            break;

                        case "Torr":
                            torr = bar * 750.062;
                            lblResultado.Text = Convert.ToString(Math.Round(torr, 5)) + " torr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Kilopascal":
                    kpa = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Atmósfera":
                            atm = kpa / 101.325;
                            lblResultado.Text = Convert.ToString(Math.Round(atm, 5)) + " atm";
                            break;

                        case "Bar":
                            bar = kpa / 100;
                            lblResultado.Text = Convert.ToString(Math.Round(bar, 5)) + " bar";
                            break;

                        case "Kilopascal":
                            lblResultado.Text = "Escoge otra unidad";                            
                            break;

                        case "Libra por pulgada cuadrada":
                            psi = kpa / 6.89476;
                            lblResultado.Text = Convert.ToString(Math.Round(psi, 5)) + " psi";
                            break;

                        case "Megapascal":
                            mpa = kpa / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(mpa, 5)) + " MPa";
                            break;

                        case "Pascal":
                            pa = kpa * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(pa, 5)) + " Pa";
                            break;

                        case "Torr":
                            torr = kpa * 7.50062;
                            lblResultado.Text = Convert.ToString(Math.Round(torr, 5)) + " torr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Libra por pulgada cuadrada":
                    psi = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Atmósfera":
                            atm = psi / 14.6959;
                            lblResultado.Text = Convert.ToString(Math.Round(atm, 5)) + " atm";
                            break;

                        case "Bar":
                            bar = psi / 14.5038;
                            lblResultado.Text = Convert.ToString(Math.Round(bar, 5)) + " bar";
                            break;

                        case "Kilopascal":
                            kpa = psi * 6.89476;
                            lblResultado.Text = Convert.ToString(Math.Round(kpa, 5)) + " kPa";
                            break;

                        case "Libra por pulgada cuadrada":
                            lblResultado.Text = "Escoge otra unidad";                           
                            break;

                        case "Megapascal":
                            mpa = psi / 145.038;
                            lblResultado.Text = Convert.ToString(Math.Round(mpa, 5)) + " MPa";
                            break;

                        case "Pascal":
                            pa = psi * 6894.76;
                            lblResultado.Text = Convert.ToString(Math.Round(pa, 5)) + " Pa";
                            break;

                        case "Torr":
                            torr = psi * 51.7149;
                            lblResultado.Text = Convert.ToString(Math.Round(torr, 5)) + " torr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Megapascal":
                    mpa = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Atmósfera":
                            atm = mpa * 9.86923;
                            lblResultado.Text = Convert.ToString(Math.Round(atm, 5)) + " atm";
                            break;

                        case "Bar":
                            bar = mpa * 10;
                            lblResultado.Text = Convert.ToString(Math.Round(bar, 5)) + " bar";
                            break;

                        case "Kilopascal":
                            kpa = mpa * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(kpa, 5)) + " kPa";
                            break;

                        case "Libra por pulgada cuadrada":
                            psi = mpa * 145.038; 
                            lblResultado.Text = Convert.ToString(Math.Round(psi, 5)) + " psi";
                            break;

                        case "Megapascal":
                            lblResultado.Text = "Escoge otra unidad";                            
                            break;

                        case "Pascal":
                            pa = mpa * 1000000;
                            lblResultado.Text = Convert.ToString(Math.Round(pa, 5)) + " Pa";
                            break;

                        case "Torr":
                            torr = mpa * 7500.62;
                            lblResultado.Text = Convert.ToString(Math.Round(torr, 5)) + " torr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pascal":
                    pa = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Atmósfera":
                            atm = pa / 101325;
                            lblResultado.Text = Convert.ToString(Math.Round(atm, 5)) + " atm";
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Bar":
                            bar = pa / 100000;
                            lblResultado.Text = Convert.ToString(Math.Round(bar, 5)) + " bar";
                            break;

                        case "Kilopascal":
                            kpa = pa / 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(kpa, 5)) + " kPa";
                            break;

                        case "Libra por pulgada cuadrada":
                            psi = pa / 6894.76;
                            lblResultado.Text = Convert.ToString(Math.Round(psi, 5)) + " psi";
                            break;

                        case "Megapascal":
                            mpa = pa / 1000000;
                            lblResultado.Text = Convert.ToString(Math.Round(mpa, 5)) + " MPa";
                            break;

                        case "Pascal":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Torr":
                            torr = pa / 133.322;
                            lblResultado.Text = Convert.ToString(Math.Round(torr, 5)) + " torr";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Torr":
                    torr = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Atmósfera":
                            atm = torr / 760;
                            lblResultado.Text = Convert.ToString(Math.Round(atm, 5)) + " atm";                            
                            break;

                        case "Bar":
                            bar = torr / 750.062;
                            lblResultado.Text = Convert.ToString(Math.Round(bar, 5)) + " bar";
                            break;

                        case "Kilopascal":
                            kpa = torr / 7.50062;
                            lblResultado.Text = Convert.ToString(Math.Round(kpa, 5)) + " kPa";
                            break;

                        case "Libra por pulgada cuadrada":
                            psi = torr / 51.7149;
                            lblResultado.Text = Convert.ToString(Math.Round(psi, 5)) + " psi";
                            break;

                        case "Megapascal":
                            mpa = torr / 7500.62;
                            lblResultado.Text = Convert.ToString(Math.Round(mpa, 5)) + " MPa";
                            break;

                        case "Pascal":
                            pa = torr * 133.322;
                            lblResultado.Text = Convert.ToString(Math.Round(pa, 5)) + " Pa";
                            break;

                        case "Torr":
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