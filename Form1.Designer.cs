namespace PickColorCombinations
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ChangeMode = new System.Windows.Forms.Button();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonCombine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 250);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(513, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 250);
            this.button2.TabIndex = 1;
            this.button2.Text = "Click!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeMode
            // 
            this.ChangeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeMode.Location = new System.Drawing.Point(294, 12);
            this.ChangeMode.Name = "ChangeMode";
            this.ChangeMode.Size = new System.Drawing.Size(211, 38);
            this.ChangeMode.TabIndex = 2;
            this.ChangeMode.Text = "Change Mode";
            this.ChangeMode.UseVisualStyleBackColor = true;
            this.ChangeMode.Click += new System.EventHandler(this.ChangeMode_Click);
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMode.Location = new System.Drawing.Point(0, 388);
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.Size = new System.Drawing.Size(800, 62);
            this.TextBoxMode.TabIndex = 3;
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.Color.Red;
            this.textBoxR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.ForeColor = System.Drawing.Color.White;
            this.textBoxR.HideSelection = false;
            this.textBoxR.Location = new System.Drawing.Point(513, 133);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(287, 42);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Visible = false;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxG
            // 
            this.textBoxG.BackColor = System.Drawing.Color.Lime;
            this.textBoxG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxG.ForeColor = System.Drawing.Color.White;
            this.textBoxG.HideSelection = false;
            this.textBoxG.Location = new System.Drawing.Point(513, 181);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(287, 42);
            this.textBoxG.TabIndex = 5;
            this.textBoxG.Visible = false;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.Blue;
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.ForeColor = System.Drawing.Color.White;
            this.textBoxB.HideSelection = false;
            this.textBoxB.Location = new System.Drawing.Point(513, 229);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(287, 42);
            this.textBoxB.TabIndex = 6;
            this.textBoxB.Visible = false;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonCombine
            // 
            this.buttonCombine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCombine.Location = new System.Drawing.Point(220, 94);
            this.buttonCombine.Name = "buttonCombine";
            this.buttonCombine.Size = new System.Drawing.Size(287, 260);
            this.buttonCombine.TabIndex = 7;
            this.buttonCombine.Text = "Combine";
            this.buttonCombine.UseVisualStyleBackColor = true;
            this.buttonCombine.Visible = false;
            this.buttonCombine.Click += new System.EventHandler(this.buttonCombine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCombine);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.TextBoxMode);
            this.Controls.Add(this.ChangeMode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ChangeMode;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonCombine;
    }
}

