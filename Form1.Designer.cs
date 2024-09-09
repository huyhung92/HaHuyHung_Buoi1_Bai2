namespace HaHuyHung_Buoi1_Bai2
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtns = new TextBox();
            txtdvn = new TextBox();
            txttong = new TextBox();
            txtchan = new TextBox();
            txtle = new TextBox();
            btnnhap = new Button();
            btntt = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 18);
            label1.Name = "label1";
            label1.Size = new Size(287, 29);
            label1.TabIndex = 0;
            label1.Text = "Nhập dãy số và Tính tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(73, 91);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(73, 148);
            label3.Name = "label3";
            label3.Size = new Size(141, 24);
            label3.TabIndex = 2;
            label3.Text = "Dãy vừa nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(73, 209);
            label4.Name = "label4";
            label4.Size = new Size(263, 24);
            label4.TabIndex = 3;
            label4.Text = "Tổng các phần tử trong dãy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(73, 266);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 4;
            label5.Text = "Tổng chẵn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(389, 266);
            label6.Name = "label6";
            label6.Size = new Size(77, 24);
            label6.TabIndex = 5;
            label6.Text = "Tổng lẻ";
            // 
            // txtns
            // 
            txtns.Location = new Point(216, 85);
            txtns.Name = "txtns";
            txtns.Size = new Size(309, 27);
            txtns.TabIndex = 6;
            // 
            // txtdvn
            // 
            txtdvn.Location = new Point(220, 145);
            txtdvn.Name = "txtdvn";
            txtdvn.Size = new Size(309, 27);
            txtdvn.TabIndex = 7;
            // 
            // txttong
            // 
            txttong.Location = new Point(342, 206);
            txttong.Name = "txttong";
            txttong.Size = new Size(187, 27);
            txttong.TabIndex = 8;
            // 
            // txtchan
            // 
            txtchan.Location = new Point(182, 263);
            txtchan.Name = "txtchan";
            txtchan.Size = new Size(201, 27);
            txtchan.TabIndex = 9;
            // 
            // txtle
            // 
            txtle.Location = new Point(472, 263);
            txtle.Name = "txtle";
            txtle.Size = new Size(220, 27);
            txtle.TabIndex = 10;
            // 
            // btnnhap
            // 
            btnnhap.Location = new Point(580, 80);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(112, 29);
            btnnhap.TabIndex = 11;
            btnnhap.Text = "Nhập";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += btnnhap_Click;
            // 
            // btntt
            // 
            btntt.Location = new Point(216, 314);
            btntt.Name = "btntt";
            btntt.Size = new Size(112, 29);
            btntt.TabIndex = 12;
            btntt.Text = "Tiếp tục";
            btntt.UseVisualStyleBackColor = true;
            btntt.Click += btntt_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(472, 314);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(112, 29);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoat";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(btntt);
            Controls.Add(btnnhap);
            Controls.Add(txtle);
            Controls.Add(txtchan);
            Controls.Add(txttong);
            Controls.Add(txtdvn);
            Controls.Add(txtns);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtns;
        private TextBox txtdvn;
        private TextBox txttong;
        private TextBox txtchan;
        private TextBox txtle;
        private Button btnnhap;
        private Button btntt;
        private Button btnthoat;
    }
}
