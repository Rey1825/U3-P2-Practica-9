﻿namespace U3_P2_Practica_9
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(260, 24);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 0;
            label1.Text = "z = x  +  x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(336, 24);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 1;
            label2.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(406, 24);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 2;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(74, 85);
            label4.Name = "label4";
            label4.Size = new Size(33, 36);
            label4.TabIndex = 3;
            label4.Text = "x";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(25, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(133, 204);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(196, 124);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(133, 204);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(361, 124);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(133, 204);
            listBox3.TabIndex = 6;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(519, 124);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(133, 204);
            listBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(246, 85);
            label5.Name = "label5";
            label5.Size = new Size(33, 36);
            label5.TabIndex = 8;
            label5.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(406, 85);
            label6.Name = "label6";
            label6.Size = new Size(33, 36);
            label6.TabIndex = 9;
            label6.Text = "x";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(566, 85);
            label7.Name = "label7";
            label7.Size = new Size(29, 36);
            label7.TabIndex = 10;
            label7.Text = "z";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(271, 85);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 11;
            label8.Text = "2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(433, 85);
            label9.Name = "label9";
            label9.Size = new Size(19, 20);
            label9.TabIndex = 12;
            label9.Text = "3";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(260, 349);
            button1.Name = "button1";
            button1.Size = new Size(192, 34);
            button1.TabIndex = 13;
            button1.Text = "Calcular valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(673, 395);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ecuaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
    }
}