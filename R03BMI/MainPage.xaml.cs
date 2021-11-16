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
                double weight = double.Parse(weighit);
                double height = double.Parse(heighit);

             if(weight < 1000){
                weight = weight / 1000;
                (Math.Round(weight);
            }
            if(height < 100){
                height = height / 100;
               (Math.Round(height);
            }

                double height = heighit * heighit;
           

                double BMI = weight / height
                (Math.Round(BMI);

            result.Text="身長："+height+"体重："+weight"のあなたのBIMは"+BMI+"です。";
        }
    }
}
