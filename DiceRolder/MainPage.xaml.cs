namespace DiceRolder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public virtual int Next { get; }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //Pegar o numero que o usuario selecionou
            int selectedSides = Convert.ToInt32(SlidesPicker.SelectedItem);

            //Usar o numero como "limitador do metodo random'
            //Sortear um numero utilizando metodo random 
           
            /*Random random = new Random();
            int drawnNumber = random.Next(1,selectedSides + 1);
            */
            int drawnNumber = new Random().Next(1, selectedSides + 1);
            DADOS.Text = drawnNumber.ToString();
            //Pegar ees resultado e exibir no label
           //  OUTRA OPÇÃO int numero = gerando.Next(1, 101);
           // DADOS.Text = $"{numero}";
        }

    }

}
