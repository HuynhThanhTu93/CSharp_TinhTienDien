namespace CSharp_TinhTienDien
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
            txtSoDien = new TextBox();
            label2 = new Label();
            listBoxKQ = new ListBox();
            button1 = new Button();
            lblKQ = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 81);
            label1.Name = "label1";
            label1.Size = new Size(149, 33);
            label1.TabIndex = 0;
            label1.Text = "Số KG Điện";
            // 
            // txtSoDien
            // 
            txtSoDien.Location = new Point(184, 74);
            txtSoDien.Name = "txtSoDien";
            txtSoDien.Size = new Size(182, 40);
            txtSoDien.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(196, 33);
            label2.TabIndex = 2;
            label2.Text = "Số tiền phải trả";
            // 
            // listBoxKQ
            // 
            listBoxKQ.FormattingEnabled = true;
            listBoxKQ.ItemHeight = 33;
            listBoxKQ.Location = new Point(12, 200);
            listBoxKQ.Name = "listBoxKQ";
            listBoxKQ.Size = new Size(262, 367);
            listBoxKQ.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(236, 120);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 4;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(306, 200);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(85, 33);
            lblKQ.TabIndex = 5;
            lblKQ.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(556, 75);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(372, 120);
            button3.Name = "button3";
            button3.Size = new Size(130, 39);
            button3.TabIndex = 4;
            button3.Text = "Tiếp tục";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 579);
            Controls.Add(lblKQ);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxKQ);
            Controls.Add(label2);
            Controls.Add(txtSoDien);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoDien;
        private Label label2;
        private ListBox listBoxKQ;
        private Button button1;
        private Label lblKQ;
        private Button button2;
        private Button button3;
    }
}
