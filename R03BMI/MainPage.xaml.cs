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

            string height = weighit.Text;
            string weight = heighit.Text;

                double h = double.Parse(height);
                double w = double.Parse(weight);

                if (h > 10)
                {
                    h = h / 100;
                    double b = w / h / h;
                    result.Text = "身長" + h*100 + "cm、体重" + w + "kgの人のBMIは" + Math.Round(b * 10) / 10 + "です。";

                }
                else
                {

                    double b = w / h / h;

                    result.Text = "身長" + h + "m、体重" + w + "kgの人のBMIは" + Math.Round(b * 10) / 10 + "です。";
                }
                
        }
    }
}
