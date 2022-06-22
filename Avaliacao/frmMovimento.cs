namespace Avaliacao
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;
        bool FecharForm;
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

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            groupBox1.Enabled = false;
            this.Size = new Size(685, 365);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            groupBox1.Enabled = false;
            this.Size = new Size(685, 365);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
            groupBox1.Enabled = false;
            this.Size = new Size(685, 365);
            this.FecharForm = true;
            this.Close();
        }

        private void frmMovimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !this.FecharForm;
        }
    }
}