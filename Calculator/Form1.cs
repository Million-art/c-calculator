namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string total,option;
        int num1,num2,result;
        
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtdisplay.Clear();
            num1 = (0);
            num2 = (0);
            result = (0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + button9.Text;

        }

        private void btndot_Click(object sender, EventArgs e)
        {
             

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn0.Text;

        }

        private void txtplus_Click(object sender, EventArgs e)
        {
             option = "+";
            num1=int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2=int.Parse(txtdisplay.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
                result = num1 / num2;
            txtdisplay.Text=result+"";
        }

        private void btnradio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
         }
    }
}