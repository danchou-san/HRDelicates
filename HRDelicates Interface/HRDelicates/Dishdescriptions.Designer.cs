namespace HRDelicates
{
    partial class Dishdescriptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dishdescriptions));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dish_descriptions = new System.Windows.Forms.TextBox();
            this.dish_title = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "wm.png");
            this.imageList1.Images.SetKeyName(1, "WhatsApp Image 2020-03-17 at 22.39.51.jpeg");
            this.imageList1.Images.SetKeyName(2, "Testplan (1).PNG");
            this.imageList1.Images.SetKeyName(3, "spaghetti+pretty.jpg");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.textBox1.Location = new System.Drawing.Point(12, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(187, 33);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "$1,50";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dish_descriptions
            // 
            this.dish_descriptions.BackColor = System.Drawing.SystemColors.Control;
            this.dish_descriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dish_descriptions.Enabled = false;
            this.dish_descriptions.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dish_descriptions.Location = new System.Drawing.Point(12, 195);
            this.dish_descriptions.Multiline = true;
            this.dish_descriptions.Name = "dish_descriptions";
            this.dish_descriptions.ReadOnly = true;
            this.dish_descriptions.Size = new System.Drawing.Size(187, 59);
            this.dish_descriptions.TabIndex = 40;
            this.dish_descriptions.Text = "iusdhgisudghuierghiuerghergjehrgkdfjgldfg";
            this.dish_descriptions.TextChanged += new System.EventHandler(this.dish_descriptions_TextChanged);
            // 
            // dish_title
            // 
            this.dish_title.BackColor = System.Drawing.SystemColors.Control;
            this.dish_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dish_title.Enabled = false;
            this.dish_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dish_title.Location = new System.Drawing.Point(12, 169);
            this.dish_title.Name = "dish_title";
            this.dish_title.ReadOnly = true;
            this.dish_title.Size = new System.Drawing.Size(187, 20);
            this.dish_title.TabIndex = 39;
            this.dish_title.Text = "Bami";
            this.dish_title.TextChanged += new System.EventHandler(this.dish_title_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataSource = typeof(HRDelicates.Dishes);
            // 
            // Dishdescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dish_descriptions);
            this.Controls.Add(this.dish_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dishdescriptions";
            this.Size = new System.Drawing.Size(212, 307);
            this.Load += new System.EventHandler(this.Dishdescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox dish_descriptions;
        private System.Windows.Forms.TextBox dish_title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
