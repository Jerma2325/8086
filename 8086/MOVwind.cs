namespace _8086
{
    public partial class MOVwind : UserControl
    {
        public int AX = 1;
        public int BX = 2;
        public int CX = 3;
        public int DX = 4;

        public int from;
        public int to;


        public MOVwind()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            to = AX;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            to = BX;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            to = CX;
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            to = DX;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MOVwind_Load(object sender, EventArgs e)
        {

            ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();
        }

        private void ax_value_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void bx_value_box_TextChanged(object sender, EventArgs e)
        {


        }

        private void cx_value_box_TextChanged(object sender, EventArgs e)
        {


        }

        private void dx_value_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            from = AX;

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            from = BX;

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            from = CX;

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            from = DX;

        }

        private void exec_btn_Click(object sender, EventArgs e)
        {

            if (to == AX)
            {
                AX = from;

            }
            else if (to == BX)
            {
                BX = from;

            }
            else if (to == CX)
            {
                CX = from;

            }
            else if (to == DX)
            {
                DX = from;

            }
            ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();
            AX1_btn.Checked = false;
            BX1_btn.Checked = false;
            CX1_btn.Checked = false;
            DX1_btn.Checked = false;
            AX2_btn.Checked = false;
            BX2_btn.Checked = false;
            CX2_btn.Checked = false;
            DX2_btn.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AX1_btn.Checked = false;
            BX1_btn.Checked = false;
            CX1_btn.Checked = false;
            DX1_btn.Checked = false;
            AX2_btn.Checked = false;
            BX2_btn.Checked = false;
            CX2_btn.Checked = false;
            DX2_btn.Checked = false;
            AX = 1;
            BX = 2;
            CX = 3;
            DX = 4;
            ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();

        }
    }
}
