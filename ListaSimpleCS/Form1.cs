namespace ListaSimpleCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Crearnodo_Click(object sender, EventArgs e)
        {
            Nodo Minodo = new Nodo();
            Minodo.Dato = int.Parse(txtDato.Text);
            MessageBox.Show(Minodo.ToString());
        }
    }
}