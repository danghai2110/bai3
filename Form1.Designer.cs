namespace bai3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btthoat = new Button();
            txtN = new TextBox();
            txtktsnt = new TextBox();
            txtktn = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 58);
            label1.Name = "label1";
            label1.Size = new Size(366, 36);
            label1.TabIndex = 0;
            label1.Text = "KIỂM TRA SỐ NGUYÊN TỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 130);
            label2.Name = "label2";
            label2.Size = new Size(114, 36);
            label2.TabIndex = 1;
            label2.Text = "Nhập N";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 221);
            label3.Name = "label3";
            label3.Size = new Size(191, 36);
            label3.TabIndex = 2;
            label3.Text = "Kiểm tra SNT";
            // 
            // btthoat
            // 
            btthoat.Location = new Point(448, 480);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(281, 50);
            btthoat.TabIndex = 3;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // txtN
            // 
            txtN.Location = new Point(323, 127);
            txtN.Name = "txtN";
            txtN.Size = new Size(402, 44);
            txtN.TabIndex = 4;
            txtN.TextChanged += txtN_TextChanged;
            // 
            // txtktsnt
            // 
            txtktsnt.Location = new Point(323, 221);
            txtktsnt.Name = "txtktsnt";
            txtktsnt.Size = new Size(395, 44);
            txtktsnt.TabIndex = 5;
            // 
            // txtktn
            // 
            txtktn.Location = new Point(605, 318);
            txtktn.Name = "txtktn";
            txtktn.Size = new Size(395, 44);
            txtktn.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 326);
            label4.Name = "label4";
            label4.Size = new Size(456, 36);
            label4.TabIndex = 7;
            label4.Text = "Kiểm tra số nguyên tố nhỏ hơn N";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 648);
            Controls.Add(label4);
            Controls.Add(txtktn);
            Controls.Add(txtktsnt);
            Controls.Add(txtN);
            Controls.Add(btthoat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btthoat;
        private TextBox txtN;
        private TextBox txtktsnt;
        private TextBox txtktn;
        private Label label4;
    }
}
