namespace Laboratorio_12._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSemi_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double ladoA = double.Parse(txtLadoA.Text);
            double ladoB = double.Parse(txtLadoB.Text);
            double ladoC = double.Parse(txtLadoC.Text);

            double semi = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semi * (semi - ladoA) * (semi - ladoB) * (semi - ladoC));
            txtAreaTrian.Text = area.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtAreaTrian.Clear();
            txtCalcSemi.Clear();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCalcSemi_TextChanged(object sender, EventArgs e)
        {
            double ladoA = double.Parse(txtLadoA.Text);
            double ladoB = double.Parse(txtLadoB.Text);
            double ladoC = double.Parse(txtLadoC.Text);

            double semi = (ladoA + ladoB + ladoC) / 2;
            txtCalcSemi.Text = semi.ToString();
        }

        private void txtAreaTrian_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
