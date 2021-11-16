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
                double weight = weightit;
                double height = heightit * heightit;
            if(weight < 1000){
                weight = weight / 1000;
                Console.WriteLine(Math.Round(weight));
            }
            if(height < 100){
                height = height / 100;
                Console.WriteLine(Math.Round(height));
            }

                double BMI = weight / height
                Console.WriteLine(Math.Round(BMI));
        }
    }
}
