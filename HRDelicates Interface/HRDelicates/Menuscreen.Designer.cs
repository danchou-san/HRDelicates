namespace HRDelicates
{
    partial class Menuscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuscreen));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gerechten_button = new System.Windows.Forms.Button();
            this.dranken_button = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
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
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "wm.png");
            this.imageList2.Images.SetKeyName(1, "WhatsApp Image 2020-03-17 at 22.39.51.jpeg");
            this.imageList2.Images.SetKeyName(2, "Testplan (1).PNG");
            this.imageList2.Images.SetKeyName(3, "spaghetti+pretty.jpg");
            // 
            // gerechten_button
            // 
            this.gerechten_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(2)))), ((int)(((byte)(69)))));
            this.gerechten_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gerechten_button.FlatAppearance.BorderSize = 0;
            this.gerechten_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gerechten_button.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gerechten_button.ForeColor = System.Drawing.Color.White;
            this.gerechten_button.Location = new System.Drawing.Point(0, 0);
            this.gerechten_button.Name = "gerechten_button";
            this.gerechten_button.Size = new System.Drawing.Size(434, 40);
            this.gerechten_button.TabIndex = 56;
            this.gerechten_button.Text = "Gerechten";
            this.gerechten_button.UseVisualStyleBackColor = false;
            this.gerechten_button.Click += new System.EventHandler(this.gerechten_button_Click);
            // 
            // dranken_button
            // 
            this.dranken_button.BackColor = System.Drawing.SystemColors.Control;
            this.dranken_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dranken_button.FlatAppearance.BorderSize = 0;
            this.dranken_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dranken_button.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dranken_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dranken_button.Location = new System.Drawing.Point(440, 0);
            this.dranken_button.Name = "dranken_button";
            this.dranken_button.Size = new System.Drawing.Size(450, 40);
            this.dranken_button.TabIndex = 57;
            this.dranken_button.Text = "Dranken";
            this.dranken_button.UseVisualStyleBackColor = false;
            this.dranken_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.Control;
            this.panel16.Controls.Add(this.dranken_button);
            this.panel16.Controls.Add(this.gerechten_button);
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(890, 43);
            this.panel16.TabIndex = 46;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataSource = typeof(HRDelicates.Dishes);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(HRDelicates.Dishes);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(HRDelicates.Dishes);
            // 
            // Menuscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel16);
            this.Name = "Menuscreen";
            this.Size = new System.Drawing.Size(890, 467);
            this.Load += new System.EventHandler(this.Menuscreen_Load);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button gerechten_button;
        private System.Windows.Forms.Button dranken_button;
        private System.Windows.Forms.Panel panel16;
    }
}
