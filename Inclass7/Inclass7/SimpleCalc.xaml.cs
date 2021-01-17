using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclass7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleCalc : ContentPage
    {

        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void Addition_Clicked(object sender, EventArgs e)
        {
            if (Num1Box.Text != null && Num2Box.Text != null)
            {
                ResultBox.Text = (Convert.ToInt32(Num1Box.Text) + Convert.ToInt32(Num2Box.Text)).ToString();
            }
        }

        private void Subtraction_Clicked(object sender, EventArgs e)
        {
            if (Num1Box.Text != null && Num2Box.Text != null)
            {
                ResultBox.Text = (Convert.ToInt32(Num1Box.Text) - Convert.ToInt32(Num2Box.Text)).ToString();
            }
        }

        private void Multiplication_Clicked(object sender, EventArgs e)
        {
            if (Num1Box.Text != null && Num2Box.Text != null)
            {
                ResultBox.Text = (Convert.ToInt32(Num1Box.Text) * Convert.ToInt32(Num2Box.Text)).ToString();
            }
        }

        private void Division_Clicked(object sender, EventArgs e)
        {
            if (Num1Box.Text != null && Num2Box.Text != null)
            {
                ResultBox.Text = (Convert.ToInt32(Num1Box.Text) / Convert.ToInt32(Num2Box.Text)).ToString();
            }
        }

        private void Remainder_Clicked(object sender, EventArgs e)
        {
            if (Num1Box.Text != null && Num2Box.Text != null)
            {
                ResultBox.Text = (Convert.ToInt32(Num1Box.Text) % Convert.ToInt32(Num2Box.Text)).ToString();
            }
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            ResultBox.Text = " ";
            Num1Box.Text = null;
            Num2Box.Text = null;
        }
    }
}