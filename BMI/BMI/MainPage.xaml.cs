using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI

{
    public partial class MainPage : ContentPage

    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            Double h = Double.Parse(height.Text);
            Double w = Double.Parse(weight.Text);
            //DisplayAlert("身長", Height.Text, "OK");
            //DisplayAlert("体重", Weight.Text, "OK");

            if (h >= 3)
            {
                h /= 100;
            }
            double bmi = w / h / h;

            if (bmi < 18.5)
            {
                DisplayAlert("判定", bmi.ToString() + "で痩せすぎ。", "OK");
            }
            else if (bmi < 25)
            {
                DisplayAlert("判定", bmi.ToString() + "で普通です。", "OK");
            }
            else if (bmi < 30)
            {
                DisplayAlert("判定", bmi.ToString() + "ちょっとデブです。", "OK");
            }
            else if (bmi < 35)
            {
                DisplayAlert("判定", bmi.ToString() + "割とデブです。", "OK");

            }
            else if (bmi < 40)
            {
                DisplayAlert("判定", bmi.ToString() + "結構デブです。", "OK");
            }
            else
            {
                DisplayAlert("判定", "デブです。", "OK");

            }
        }
    }
}
