namespace Avaliacao
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;
        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            _listConta = contaBancaria.geraContas();
        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}