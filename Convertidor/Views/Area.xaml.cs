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
    public partial class Area : ContentPage
    {
        double km2, m2, mi2, yd2, ft2, in2, ha, ac;
        string conversion, conversion2;
        public Area()
        {
            InitializeComponent();
            Title = "Área";
            PickUnidades.Items.Add("Kilómetro cuadrado");
            PickUnidades.Items.Add("Metro cuadrado");
            PickUnidades.Items.Add("Milla cuadrada");
            PickUnidades.Items.Add("Yarda cuadrada");
            PickUnidades.Items.Add("Pie cuadrado");
            PickUnidades.Items.Add("Pulgada cuadrada");
            PickUnidades.Items.Add("Hectárea");
            PickUnidades.Items.Add("Acre");

            PickUnidades2.Items.Add("Kilómetro cuadrado");
            PickUnidades2.Items.Add("Metro cuadrado");
            PickUnidades2.Items.Add("Milla cuadrada");
            PickUnidades2.Items.Add("Yarda cuadrada");
            PickUnidades2.Items.Add("Pie cuadrado");
            PickUnidades2.Items.Add("Pulgada cuadrada");
            PickUnidades2.Items.Add("Hectárea");
            PickUnidades2.Items.Add("Acre");
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
                case "Kilómetro cuadrado":
                    km2 = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro cuadrado":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Metro cuadrado":
                            m2 = km2 * 1000000;
                            lblResultado.Text = Convert.ToString(Math.Round(m2, 5)) + " m²";
                            break;

                        case "Milla cuadrada":
                            mi2 = km2 / 2.58999;
                            lblResultado.Text = Convert.ToString(Math.Round(mi2, 5)) + " mi²";
                            break;

                        case "Yarda cuadrada":
                            yd2 = km2 * (1.196 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(yd2, 5)) + " yd²";
                            break;

                        case "Pie cuadrado":
                            ft2 = km2 * (1.076 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(ft2, 5)) + " ft²";
                            break;

                        case "Pulgada cuadrada":
                            in2 = km2 * (1.55 * Math.Pow(10, 9));
                            lblResultado.Text = Convert.ToString(Math.Round(in2, 5)) + " in²";
                            break;

                        case "Hectárea":
                            ha = km2 * 1000;
                            lblResultado.Text = Convert.ToString(Math.Round(ha, 5)) + " ha";
                            break;

                        case "Acre":
                            ac = km2 * 247.105;
                            lblResultado.Text = Convert.ToString(Math.Round(ac, 5)) + " ac";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Metro cuadrado":
                    m2 = Convert.ToDouble(NumericEntry.Value);                    
                    switch (conversion2)
                    {                        
                        case "Kilómetro cuadrado":
                            km2 = m2 / 1000000;
                            lblResultado.Text = Convert.ToString(Math.Round(km2, 5)) + " km²";
                            break;

                        case "Metro cuadrado":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Milla cuadrada":
                            mi2 = m2 / (2.58999 * Math.Pow(10,6));
                            lblResultado.Text = Convert.ToString(Math.Round(mi2, 5)) + " mi²";
                            break;

                        case "Yarda cuadrada":
                            yd2 = m2 * 1.19599; 
                            lblResultado.Text = Convert.ToString(Math.Round(yd2, 5)) + " yd²";
                            break;

                        case "Pie cuadrado":
                            ft2 = m2 * 10.7639;
                            lblResultado.Text = Convert.ToString(Math.Round(ft2, 5)) + " ft²";
                            break;

                        case "Pulgada cuadrada":
                            in2 = m2 * 1550;
                            lblResultado.Text = Convert.ToString(Math.Round(in2, 5)) + " in²";
                            break; 

                        case "Hectárea":
                            ha = m2 / 10000;
                            lblResultado.Text = Convert.ToString(Math.Round(ha, 5)) + " ha";
                            break;

                        case "Acre":
                            ac = m2 / 4046.86;  
                            lblResultado.Text = Convert.ToString(Math.Round(ac, 5)) + " ac";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Milla cuadrada":
                    mi2 = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro cuadrado":
                            km2 = mi2 * 2.58999;
                            lblResultado.Text = Convert.ToString(Math.Round(km2, 5)) + " km²";
                            break;

                        case "Metro cuadrado":
                            m2 = mi2 * (2.58999 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(m2, 5)) + " m²";
                            break;

                        case "Milla cuadrada":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Yarda cuadrada":
                            yd2 = mi2 * (3.098 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(yd2, 5)) + " yd²";
                            break;

                        case "Pie cuadrado":
                            ft2 = mi2 * (2.788 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(ft2, 5)) + " ft²";
                            break;

                        case "Pulgada cuadrada":
                            in2 = mi2 * (4.014 * Math.Pow(10, 9));
                            lblResultado.Text = Convert.ToString(Math.Round(in2, 5)) + " in²";
                            break;

                        case "Hectárea":
                            ha = mi2 * 258.999;
                            lblResultado.Text = Convert.ToString(Math.Round(ha, 5)) + " ha";
                            break;

                        case "Acre":
                            ac = mi2 * 640;
                            lblResultado.Text = Convert.ToString(Math.Round(ac, 5)) + " ac";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Yarda cuadrada":
                    yd2 = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro cuadrado":
                            km2 = yd2 / (1.196 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(km2, 5)) + " km²";
                            break;

                        case "Metro cuadrado":
                            m2 = yd2 / 1.196;
                            lblResultado.Text = Convert.ToString(Math.Round(m2, 5)) + " m²";
                            break;

                        case "Milla cuadrada":
                            mi2 = yd2 / (3.098 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(mi2, 5)) + " mi²";
                            break;

                        case "Yarda cuadrada":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Pie cuadrado":
                            ft2 = yd2 * 9;
                            lblResultado.Text = Convert.ToString(Math.Round(ft2, 5)) + " ft²";
                            break;

                        case "Pulgada cuadrada":
                            in2 = yd2 * 1296;
                            lblResultado.Text = Convert.ToString(Math.Round(in2, 5)) + " in²";
                            break;

                        case "Hectárea":
                            ha = yd2 / 11959.9;
                            lblResultado.Text = Convert.ToString(Math.Round(ha, 5)) + " ha";
                            break;

                        case "Acre":
                            ac = yd2 / 4840;
                            lblResultado.Text = Convert.ToString(Math.Round(ac, 5)) + " ac";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pie cuadrado":
                    ft2 = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro cuadrado":
                            km2 = ft2 / (2.58999 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(km2, 5)) + " km²";
                            break;

                        case "Metro cuadrado":
                            m2 = ft2 / 10.764;
                            lblResultado.Text = Convert.ToString(Math.Round(m2, 5)) + " m²";
                            break;

                        case "Milla cuadrada":
                            ft2 = mi2 / (2.788 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(mi2, 5)) + " mi²";
                            break;

                        case "Yarda cuadrada":
                            yd2 = ft2 / 9;
                            lblResultado.Text = Convert.ToString(Math.Round(yd2, 5)) + " yd²";
                            break;

                        case "Pie cuadrado":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Pulgada cuadrada":
                            in2 = ft2 * 144;
                            lblResultado.Text = Convert.ToString(Math.Round(in2, 5)) + " in²";
                            break;

                        case "Hectárea":
                            ha = ft2 / 107639;
                            lblResultado.Text = Convert.ToString(Math.Round(ha, 5)) + " ha";
                            break;

                        case "Acre":
                            ac = ft2 / 43560;
                            lblResultado.Text = Convert.ToString(Math.Round(ac, 5)) + " ac";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Pulgada cuadrada":
                    in2 = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro cuadrado":
                            m2 = in2 / (1.55 * Math.Pow(10, 9));
                            lblResultado.Text = Convert.ToString(Math.Round(km2, 5)) + " km²";
                            break;

                        case "Metro cuadrado":
                            m2 = in2 / 155;
                            lblResultado.Text = Convert.ToString(Math.Round(m2, 5)) + " m²";
                            break;

                        case "Milla cuadrada":
                            mi2 = in2 / (2.58999 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(mi2, 5)) + " mi²";
                            break;

                        case "Yarda cuadrada":
                            yd2 = in2 / 1296;
                            lblResultado.Text = Convert.ToString(Math.Round(yd2, 5)) + " yd²";
                            break;

                        case "Pie cuadrado":
                            ft2 = in2 / 144;
                            lblResultado.Text = Convert.ToString(Math.Round(ft2, 5)) + " ft²";
                            break;

                        case "Pulgada cuadrada":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Hectárea":
                            ha = in2 / (1.55 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(ha, 5)) + " ha";
                            break;

                        case "Acre":
                            ac = in2 / (6.273 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(ac, 5)) + " ac";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Hectárea":
                    ha = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro cuadrado":
                            km2 = ha / 100;
                            lblResultado.Text = Convert.ToString(Math.Round(km2, 5)) + " km²";
                            break;

                        case "Metro cuadrado":
                            m2 = ha * 10000;
                            lblResultado.Text = Convert.ToString(Math.Round(m2, 5)) + " m²";
                            break;

                        case "Milla cuadrada":
                            mi2 = ha / 258.999;
                            lblResultado.Text = Convert.ToString(Math.Round(mi2, 5)) + " mi²";
                            break;

                        case "Yarda cuadrada":
                            yd2 = ha * 11959.9;
                            lblResultado.Text = Convert.ToString(Math.Round(yd2, 5)) + " yd²";
                            break;

                        case "Pie cuadrado":
                            ft2 = ha * 107639;
                            lblResultado.Text = Convert.ToString(Math.Round(ft2, 5)) + " ft²";
                            break;

                        case "Pulgada cuadrada":
                            in2 = ha * (1.55 * Math.Pow(10, 7));
                            lblResultado.Text = Convert.ToString(Math.Round(in2, 5)) + " in²";
                            break;

                        case "Hectárea":
                            lblResultado.Text = "Escoge otra unidad";
                            break;

                        case "Acre":
                            ac = ha * 2.47105;
                            lblResultado.Text = Convert.ToString(Math.Round(ac, 5)) + " ac";
                            break;

                        default:
                            lblResultado.Text = "Elige una unidad";
                            break;
                    }
                    break;

                case "Acre":
                    ac = Convert.ToDouble(NumericEntry.Value);
                    switch (conversion2)
                    {
                        case "Kilómetro cuadrado":
                            km2 = ac * 207.105;
                            lblResultado.Text = Convert.ToString(Math.Round(km2, 5)) + " km²";
                            break;

                        case "Metro cuadrado":
                            m2 = ac * 4044.86;
                            lblResultado.Text = Convert.ToString(Math.Round(m2, 5)) + " m²";
                            break;

                        case "Milla cuadrada":
                            mi2 = ac / 640;
                            lblResultado.Text = Convert.ToString(Math.Round(mi2, 5)) + " mi²";
                            break;

                        case "Yarda cuadrada":
                            yd2 = ac * 4840;
                            lblResultado.Text = Convert.ToString(Math.Round(yd2, 5)) + " yd²";
                            break;

                        case "Pie cuadrado":
                            ft2 = ac * 43560;
                            lblResultado.Text = Convert.ToString(Math.Round(ft2, 5)) + " ft²";
                            break;

                        case "Pulgada cuadrada":
                            in2 = ac * (6.273 * Math.Pow(10, 6));
                            lblResultado.Text = Convert.ToString(Math.Round(in2, 5)) + " in²";
                            break;

                        case "Hectárea":
                            ha = ac / 2.47105;
                            lblResultado.Text = Convert.ToString(Math.Round(ha, 5)) + " ha";
                            break;

                        case "Acre":
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