using CalcProject.Entities.Services;
using CalcProject.Entities;
namespace CalcProject
{
    public partial class Form1 : Form
    {
        public CountService countService { get; set; }
        public Operation op { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countService = new CountService("");
            op = new Operation();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            countService.AddValue("1");
            TxtCount.Text = countService.Count();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            countService.AddValue("2");
            TxtCount.Text = countService.Count();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            countService.AddValue("3");
            TxtCount.Text = countService.Count();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            countService.AddValue("4");
            TxtCount.Text = countService.Count();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            countService.AddValue("5");
            TxtCount.Text = countService.Count();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            countService.AddValue("6");
            TxtCount.Text = countService.Count();
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            countService.AddValue("7");
            TxtCount.Text = countService.Count();
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            countService.AddValue("8");
            TxtCount.Text = countService.Count();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            countService.AddValue("9");
            TxtCount.Text = countService.Count();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            TxtCount.Text = "";
            txtResult.Text = "";
            countService.Value = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            countService.AddValue(" / ");
            TxtCount.Text = countService.Count();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            countService.AddValue(" * ");
            TxtCount.Text = countService.Count();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            countService.AddValue(" - ");
            TxtCount.Text = countService.Count();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            countService.AddValue(" + ");
            TxtCount.Text = countService.Count();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string[] values = op.Exec(countService.Value);

            txtResult.Text = op.ExecAcc(values);

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            countService.AddValue("0");
            TxtCount.Text= countService.Count();
        }
    }
}