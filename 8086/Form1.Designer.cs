namespace _8086
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XCHG_btn = new System.Windows.Forms.Button();
            this.MOV_btn = new System.Windows.Forms.Button();
            this.moVwind1 = new _8086.MOVwind();
            this.xchGwid1 = new _8086.XCHGwid();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.XCHG_btn);
            this.panel1.Controls.Add(this.MOV_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 311);
            this.panel1.TabIndex = 14;
            // 
            // XCHG_btn
            // 
            this.XCHG_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.XCHG_btn.Location = new System.Drawing.Point(21, 158);
            this.XCHG_btn.Name = "XCHG_btn";
            this.XCHG_btn.Size = new System.Drawing.Size(75, 23);
            this.XCHG_btn.TabIndex = 0;
            this.XCHG_btn.Text = "XCHG";
            this.XCHG_btn.UseVisualStyleBackColor = true;
            this.XCHG_btn.Click += new System.EventHandler(this.XCHG_btn_Click);
            // 
            // MOV_btn
            // 
            this.MOV_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MOV_btn.Location = new System.Drawing.Point(21, 118);
            this.MOV_btn.Name = "MOV_btn";
            this.MOV_btn.Size = new System.Drawing.Size(75, 23);
            this.MOV_btn.TabIndex = 0;
            this.MOV_btn.Text = "MOV";
            this.MOV_btn.UseVisualStyleBackColor = true;
            this.MOV_btn.Click += new System.EventHandler(this.MOV_Click);
            // 
            // moVwind1
            // 
            this.moVwind1.Location = new System.Drawing.Point(127, 0);
            this.moVwind1.Name = "moVwind1";
            this.moVwind1.Size = new System.Drawing.Size(460, 310);
            this.moVwind1.TabIndex = 15;
            // 
            // xchGwid1
            // 
            this.xchGwid1.Location = new System.Drawing.Point(127, 0);
            this.xchGwid1.Name = "xchGwid1";
            this.xchGwid1.Size = new System.Drawing.Size(460, 310);
            this.xchGwid1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xchGwid1);
            this.Controls.Add(this.moVwind1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "8086 MOV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Button XCHG_btn;
        private Button MOV_btn;
        private MOVwind moVwind1;
        private XCHGwid xchGwid1;
    }
}