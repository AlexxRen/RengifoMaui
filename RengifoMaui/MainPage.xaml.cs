namespace RengifoMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            string myText = input_telf.Text;
        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

        public void showRecarga (RadioButton radio1, RadioButton radio2, RadioButton radio3) 
        {
            string voz;
            if (radio1.IsChecked == true) { 
                voz = "Se ha escojido una recarga de 3$";
                this.mensaje.Text = voz;
            }
            else if (radio2.IsChecked == true) {
                voz = "Se ha escojido una recarga de 5$";
                this.mensaje.Text = voz;
            }

            else if (radio2.IsChecked == true){
                voz = "Se ha escojido una recarga de 5$";
                this.mensaje.Text = voz;
            }
                
        }


    }

}
