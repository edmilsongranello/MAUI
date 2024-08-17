//using Intents;

namespace Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txtEtanol.Text);
                double gasolina = Convert.ToDouble(txtGasolina.Text);
                string msg = "";
                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol esta compensando";
                }
                else
                {
                    msg = "A Gasolina esta compensando";
                }

                DisplayAlert("calculado", msg, "Ok");
            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Fechar");
            }
        }//fecha metodo
                
    }//fecha class
}

