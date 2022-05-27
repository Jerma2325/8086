namespace _8086
{
    public partial class XCHGwid : UserControl
    {
        public int AX1 = 1;
        public int BX1 = 2;
        public int CX1 = 3;
        public int DX1 = 4;



        public int from1;
        public int to1;


        public XCHGwid()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ref int to = ref to1;

            ref int AX = ref AX1;
            to = AX;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ref int to = ref to1;

            ref int BX = ref BX1;

            to = BX;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ref int CX = ref CX1;
            ref int to = ref to1;

            to = CX;
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ref int DX = ref DX1;
            ref int to = ref to1;

            to = DX;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MOVwind_Load(object sender, EventArgs e)
        {
            ref int AX = ref AX1;
            ref int BX = ref BX1;
            ref int CX = ref CX1;
            ref int DX = ref DX1;
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
            ref int AX = ref AX1;
            ref int from = ref from1;

            from = AX;

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            ref int BX = ref BX1;
            ref int from = ref from1;

            from = BX;

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            ref int CX = ref CX1;
            ref int from = ref from1;

            from = CX;

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            ref int DX = ref DX1;
            ref int from = ref from1;

            from = DX;

        }

        private void exec_btn_Click(object sender, EventArgs e)
        {
            ref int to = ref to1;
            ref int from = ref from1;
            ref int AX = ref AX1;
            ref int BX = ref BX1;
            ref int CX = ref CX1;
            ref int DX = ref DX1;

            if (to == AX)
            {

                if (from == AX)
                {

                    AX = to;
                    AX = from;
                }
                else if (from == BX)
                {
                    BX = to;
                    AX = from;
                }
                else if (from == CX)
                {
                    CX = to;
                    AX = from;
                }
                else if (from == DX)
                {
                    DX = to;
                    AX = from;
                }

            }
            else if (to == BX)
            {

                if (from == AX)
                {
                    AX = to;
                    BX = from;

                }
                else if (from == BX)
                {
                    BX = to;
                    BX = from;
                }
                else if (from == CX)
                {
                    CX = to;
                    BX = from;
                }
                else if (from == DX)
                {
                    DX = to;
                    BX = from;
                }
            }
            else if (to == CX)
            {
                if (from == AX)
                {
                    AX = to;
                    CX = from;


                }
                else if (from == BX)
                {
                    BX = to;
                    CX = from;

                }
                else if (from == CX)
                {
                    CX = to;
                    CX = from;

                }
                else if (from == DX)
                {
                    DX = to;
                    CX = from;

                }
            }
            else if (to == DX)
            {
                if (from == AX)
                {
                    AX = to;
                    DX = from;


                }
                else if (from == BX)
                {
                    BX = to;
                    DX = from;

                }
                else if (from == CX)
                {
                    CX = to;
                    DX = from;

                }
                else if (from == DX)
                {
                    DX = to;
                    DX = from;

                }
            }
            ax_value_box.Text = AX.ToString();
            bx_value_box.Text = BX.ToString();
            cx_value_box.Text = CX.ToString();
            dx_value_box.Text = DX.ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            ref int to = ref to1;
            ref int from = ref from1;
            ref int AX = ref AX1;
            ref int BX = ref BX1;
            ref int CX = ref CX1;
            ref int DX = ref DX1;

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
