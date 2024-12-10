namespace Caesar
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_text = new System.Windows.Forms.TextBox();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.output_text = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.key_text_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_text
            // 
            this.input_text.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.input_text.Location = new System.Drawing.Point(180, 120);
            this.input_text.Multiline = true;
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(524, 89);
            this.input_text.TabIndex = 0;
            this.input_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.encrypt_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_button.ForeColor = System.Drawing.Color.White;
            this.encrypt_button.Location = new System.Drawing.Point(307, 281);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(275, 57);
            this.encrypt_button.TabIndex = 3;
            this.encrypt_button.Text = "Зашифровать";
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // output_text
            // 
            this.output_text.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.output_text.Location = new System.Drawing.Point(183, 397);
            this.output_text.Multiline = true;
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(524, 89);
            this.output_text.TabIndex = 4;
            this.output_text.TextChanged += new System.EventHandler(this.output_text_TextChanged);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.back_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(112, 40);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите исходный текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Зашифрованный текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ключ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // key_text_box
            // 
            this.key_text_box.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.key_text_box.Location = new System.Drawing.Point(242, 221);
            this.key_text_box.Name = "key_text_box";
            this.key_text_box.Size = new System.Drawing.Size(87, 27);
            this.key_text_box.TabIndex = 9;
            this.key_text_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(556, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Копировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(553, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Вставить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.key_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.output_text);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.input_text);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_text;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.TextBox output_text;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox key_text_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}