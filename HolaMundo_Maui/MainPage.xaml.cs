using Biblioteca;

namespace HolaMundo_Maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private clsPersona persona = new clsPersona();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            string apellidos= await DisplayPromptAsync("Hello ", "Apellidos: ");
            persona.Nombre = txtNombre.Text;
            persona.Apellidos = apellidos;
            if (!string.IsNullOrEmpty(persona.Nombre) && !string.IsNullOrEmpty(persona.Apellidos))
            {
                Hola.Text = "Hello " + persona.NombreCompleto;
                await DisplayAlert("Hola", persona.NombreCompleto, "ok");
            }
            else Hola.Text = "Hello World";
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}