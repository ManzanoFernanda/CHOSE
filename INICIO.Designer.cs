namespace CHOSE
{
    partial class INICIO
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
            this.circularButton1 = new CHOSE.CircularButton();
            this.circularButton2 = new CHOSE.CircularButton();
            this.circularButton3 = new CHOSE.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circularButton1
            // 
            this.circularButton1.BackgroundImage = global::CHOSE.Properties.Resources.bt1;
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularButton1.Location = new System.Drawing.Point(29, 321);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(135, 135);
            this.circularButton1.TabIndex = 0;
            this.circularButton1.Text = "PUNTOS";
            this.circularButton1.UseVisualStyleBackColor = true;
            this.circularButton1.Click += new System.EventHandler(this.CircularButton1_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackgroundImage = global::CHOSE.Properties.Resources.btpardo;
            this.circularButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton2.FlatAppearance.BorderSize = 0;
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularButton2.Location = new System.Drawing.Point(226, 321);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(135, 135);
            this.circularButton2.TabIndex = 1;
            this.circularButton2.Text = "JUGAR";
            this.circularButton2.UseVisualStyleBackColor = true;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click_1);
            // 
            // circularButton3
            // 
            this.circularButton3.BackgroundImage = global::CHOSE.Properties.Resources.btpanda;
            this.circularButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton3.FlatAppearance.BorderSize = 0;
            this.circularButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularButton3.Location = new System.Drawing.Point(420, 321);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(135, 135);
            this.circularButton3.TabIndex = 2;
            this.circularButton3.Text = "SALIR";
            this.circularButton3.UseVisualStyleBackColor = true;
            this.circularButton3.Click += new System.EventHandler(this.CircularButton3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CHOSE.Properties.Resources.AAAABc9dWyJLLdJUZ0jT6n8fOedFXPDhvx8lXDhfOQxwTxgrLIvUP7BTgjcefxqPaI9QCoX6lYRzbsY4y_VrlTTkucedcR9p_BLtohfX;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 241);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CHOSE.Properties.Resources.ea24747361f8dbc210e03374866d2e48;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.circularButton1);
            this.Name = "INICIO";
            this.Text = "INICIO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton circularButton1;
        private CircularButton circularButton2;
        private CircularButton circularButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}