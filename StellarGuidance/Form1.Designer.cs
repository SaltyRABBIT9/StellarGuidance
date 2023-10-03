namespace StellarGuidance
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.Panel();
            this.des = new System.Windows.Forms.Label();
            this.zodiac = new System.Windows.Forms.ImageList(this.components);
            this.zod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "StellarGuidance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find everything about your Zodic";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "ENTER YOUR BIRTHDAY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(361, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(463, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Month";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Submit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.Black;
            this.Submit.Location = new System.Drawing.Point(470, 226);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 30);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(352, 178);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(70, 20);
            this.date.TabIndex = 8;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(448, 179);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(93, 20);
            this.month.TabIndex = 9;
            this.month.TextChanged += new System.EventHandler(this.month_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(428, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "/";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Clear.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(389, 226);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 30);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Transparent;
            this.image.ForeColor = System.Drawing.Color.Transparent;
            this.image.Location = new System.Drawing.Point(134, 279);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(212, 234);
            this.image.TabIndex = 12;
            this.image.Paint += new System.Windows.Forms.PaintEventHandler(this.image_Paint);
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.Color.Transparent;
            this.des.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.ForeColor = System.Drawing.Color.White;
            this.des.Location = new System.Drawing.Point(353, 279);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(235, 234);
            this.des.TabIndex = 13;
            // 
            // zodiac
            // 
            this.zodiac.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("zodiac.ImageStream")));
            this.zodiac.TransparentColor = System.Drawing.Color.Transparent;
            this.zodiac.Images.SetKeyName(0, "0.jpg");
            this.zodiac.Images.SetKeyName(1, "1.jpg");
            this.zodiac.Images.SetKeyName(2, "2.jpg");
            this.zodiac.Images.SetKeyName(3, "3.jpg");
            this.zodiac.Images.SetKeyName(4, "4.jpg");
            this.zodiac.Images.SetKeyName(5, "5.jpg");
            this.zodiac.Images.SetKeyName(6, "6.jpg");
            this.zodiac.Images.SetKeyName(7, "7.jpg");
            this.zodiac.Images.SetKeyName(8, "8.jpg");
            this.zodiac.Images.SetKeyName(9, "9.jpg");
            this.zodiac.Images.SetKeyName(10, "10.jpg");
            this.zodiac.Images.SetKeyName(11, "11.jpg");
            // 
            // zod
            // 
            this.zod.AutoSize = true;
            this.zod.BackColor = System.Drawing.Color.Transparent;
            this.zod.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zod.ForeColor = System.Drawing.Color.White;
            this.zod.Location = new System.Drawing.Point(168, 234);
            this.zod.Name = "zod";
            this.zod.Size = new System.Drawing.Size(0, 43);
            this.zod.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 589);
            this.Controls.Add(this.zod);
            this.Controls.Add(this.des);
            this.Controls.Add(this.image);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.month);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "StellarGuidance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Panel image;
        private System.Windows.Forms.Label des;
        private System.Windows.Forms.ImageList zodiac;
        private System.Windows.Forms.Label zod;
    }
}

