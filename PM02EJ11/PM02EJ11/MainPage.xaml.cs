using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM02EJ11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Sumar(object obj, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var Num1 = double.Parse(num1.Text);
                var Num2 = double.Parse(num2.Text);

                var tt = Num1 + Num2;

                var r = new Models.Resultado
                {
                    result = tt.ToString()
                };

                Result rpage = new Result();
                rpage.BindingContext = r;
                await Navigation.PushAsync(rpage);
            }
            else
                DisplayAlert("Error", "Debe ingresar ambos valores", "OK");
        }

        async void Button_Restar(object obj, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var Num1 = double.Parse(num1.Text);
                var Num2 = double.Parse(num2.Text);

                var tt = Num1 - Num2;

                var r = new Models.Resultado
                {
                    result = tt.ToString()
                };

                Result rpage = new Result();
                rpage.BindingContext = r;
                await Navigation.PushAsync(rpage);
            }
            else
                DisplayAlert("Error", "Debe ingresar ambos valores", "OK");
        }

        async void Button_Multiplicar(object obj, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var Num1 = double.Parse(num1.Text);
                var Num2 = double.Parse(num2.Text);

                var tt = Num1 * Num2;

                var r = new Models.Resultado
                {
                    result = tt.ToString()
                };

                Result rpage = new Result();
                rpage.BindingContext = r;
                await Navigation.PushAsync(rpage);
            }
            else
                DisplayAlert("Error", "Debe ingresar ambos valores", "OK");
        }

        async void Button_Dividir(object obj, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var Num1 = double.Parse(num1.Text);
                var Num2 = double.Parse(num2.Text);

                var tt = Num1 / Num2;

                var r = new Models.Resultado
                {
                    result = tt.ToString()
                };

                Result rpage = new Result();
                rpage.BindingContext = r;
                await Navigation.PushAsync(rpage);
            }
            else
                DisplayAlert("Error", "Debe ingresar ambos valores", "OK");
        }
    }
}
