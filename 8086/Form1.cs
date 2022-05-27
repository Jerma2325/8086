namespace _8086
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();

                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public Button MOV_Button
        {
            get { return MOV_btn; }
            set { MOV_btn = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _obj = this;

            moVwind1.Hide();
            xchGwid1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void MOV_Click(object sender, EventArgs e)
        {
            xchGwid1.Hide();
            moVwind1.Show();
        }

        private void XCHG_btn_Click(object sender, EventArgs e)
        {
            moVwind1.Hide();
            xchGwid1.Show();
        }

        private void xchGwind1_Load(object sender, EventArgs e)
        {

        }
    }
}