using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A14 小林　龍成";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double d1 = double.Parse("5.12345");

            string weight = weighit.Text;
            string height = heighit.Text;

                double h = double.Parse(height);
                double w = double.Parse(weight);
                double BMI;

                if (h > 10)
                {
                    h = h / 100;
                }
                if (w > 1000)
                {
                    w = w / 1000;
                }


            double b = w / h / h;
            BMI = Math.Round(b * 10) / 10;

            String joutai;
            if (BMI >= 40.00)
            {
                joutai = "肥満(4度)";
            }else if(BMI >= 35.00)
            {
                joutai = "肥満(3度)";
            }
            else if (BMI >= 30.00)
            {
                joutai = "肥満(2度)";
            }
            else if (BMI >= 25.00)
            {
                joutai = "肥満(1度)";
            }
            else if (BMI >= 18.50)
            {
                joutai = "普通体重";
            }
            else
            {
                joutai = "低体重(痩せ)";
            }


            result.Text = "身長" + h + "m、体重" + w + "kgの人のBMIは" + BMI + "("+joutai+")です。";

        }
    }
}
