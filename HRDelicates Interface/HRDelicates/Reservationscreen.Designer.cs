namespace HRDelicates
{
    partial class Reservationscreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.naam_box = new System.Windows.Forms.TextBox();
            this.achternaam_box = new System.Windows.Forms.TextBox();
            this.adres_box = new System.Windows.Forms.TextBox();
            this.postcode_box = new System.Windows.Forms.TextBox();
            this.plaats_box = new System.Windows.Forms.TextBox();
            this.verder_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.personen_box = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table_panel = new System.Windows.Forms.Panel();
            this.verification_panel = new System.Windows.Forms.Panel();
            this.finish_panel = new System.Windows.Forms.Panel();
            this.finish_text = new System.Windows.Forms.Label();
            this.back_begin = new System.Windows.Forms.Button();
            this.confirm_button = new System.Windows.Forms.Button();
            this.confirmation_back = new System.Windows.Forms.Button();
            this.email_value = new System.Windows.Forms.TextBox();
            this.time_value = new System.Windows.Forms.TextBox();
            this.table_value = new System.Windows.Forms.TextBox();
            this.name_value = new System.Windows.Forms.TextBox();
            this.phone_value = new System.Windows.Forms.TextBox();
            this.date_value = new System.Windows.Forms.TextBox();
            this.tijd_label = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.table_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.confirmation_title = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.table_back = new System.Windows.Forms.Button();
            this.table_next = new System.Windows.Forms.Button();
            this.table_header_text = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.table_combo = new System.Windows.Forms.ComboBox();
            this.time_box = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.datum_box = new System.Windows.Forms.DateTimePicker();
            this.telefoon_Box = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Verplicht_text = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capaciteitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tablesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personen_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.table_panel.SuspendLayout();
            this.verification_panel.SuspendLayout();
            this.finish_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // naam_box
            // 
            this.naam_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naam_box.Location = new System.Drawing.Point(99, 94);
            this.naam_box.Name = "naam_box";
            this.naam_box.Size = new System.Drawing.Size(309, 27);
            this.naam_box.TabIndex = 0;
            this.naam_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.naam_box.Validating += new System.ComponentModel.CancelEventHandler(this.naam_box_Validating);
            // 
            // achternaam_box
            // 
            this.achternaam_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achternaam_box.Location = new System.Drawing.Point(428, 94);
            this.achternaam_box.Name = "achternaam_box";
            this.achternaam_box.Size = new System.Drawing.Size(370, 27);
            this.achternaam_box.TabIndex = 1;
            this.achternaam_box.Validating += new System.ComponentModel.CancelEventHandler(this.achternaam_box_Validating);
            // 
            // adres_box
            // 
            this.adres_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adres_box.Location = new System.Drawing.Point(99, 149);
            this.adres_box.Name = "adres_box";
            this.adres_box.Size = new System.Drawing.Size(284, 27);
            this.adres_box.TabIndex = 3;
            // 
            // postcode_box
            // 
            this.postcode_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postcode_box.Location = new System.Drawing.Point(404, 149);
            this.postcode_box.Name = "postcode_box";
            this.postcode_box.Size = new System.Drawing.Size(88, 27);
            this.postcode_box.TabIndex = 4;
            // 
            // plaats_box
            // 
            this.plaats_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaats_box.Location = new System.Drawing.Point(514, 149);
            this.plaats_box.Name = "plaats_box";
            this.plaats_box.Size = new System.Drawing.Size(284, 27);
            this.plaats_box.TabIndex = 5;
            // 
            // verder_button
            // 
            this.verder_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(2)))), ((int)(((byte)(69)))));
            this.verder_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verder_button.FlatAppearance.BorderSize = 0;
            this.verder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verder_button.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.verder_button.ForeColor = System.Drawing.Color.White;
            this.verder_button.Location = new System.Drawing.Point(346, 312);
            this.verder_button.Name = "verder_button";
            this.verder_button.Size = new System.Drawing.Size(170, 61);
            this.verder_button.TabIndex = 8;
            this.verder_button.Text = "Verder";
            this.verder_button.UseVisualStyleBackColor = false;
            this.verder_button.Click += new System.EventHandler(this.verder_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(315, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vul uw gegevens in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(95, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Voornaam *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(429, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Achternaam *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(95, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(401, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(512, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Plaats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(95, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefoonnummer *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(632, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Datum reservering";
            // 
            // personen_box
            // 
            this.personen_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personen_box.Location = new System.Drawing.Point(533, 203);
            this.personen_box.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.personen_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personen_box.Name = "personen_box";
            this.personen_box.Size = new System.Drawing.Size(79, 27);
            this.personen_box.TabIndex = 17;
            this.personen_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(530, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Personen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nummerDataGridViewTextBoxColumn,
            this.capaciteitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablesBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(63, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(415, 299);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Visible = false;
            // 
            // table_panel
            // 
            this.table_panel.Controls.Add(this.verification_panel);
            this.table_panel.Controls.Add(this.table_back);
            this.table_panel.Controls.Add(this.table_next);
            this.table_panel.Controls.Add(this.table_header_text);
            this.table_panel.Controls.Add(this.label11);
            this.table_panel.Controls.Add(this.label10);
            this.table_panel.Controls.Add(this.table_combo);
            this.table_panel.Controls.Add(this.dataGridView1);
            this.table_panel.Controls.Add(this.time_box);
            this.table_panel.Controls.Add(this.label13);
            this.table_panel.Location = new System.Drawing.Point(0, 0);
            this.table_panel.Name = "table_panel";
            this.table_panel.Size = new System.Drawing.Size(890, 465);
            this.table_panel.TabIndex = 21;
            this.table_panel.Visible = false;
            // 
            // verification_panel
            // 
            this.verification_panel.Controls.Add(this.finish_panel);
            this.verification_panel.Controls.Add(this.confirm_button);
            this.verification_panel.Controls.Add(this.confirmation_back);
            this.verification_panel.Controls.Add(this.email_value);
            this.verification_panel.Controls.Add(this.time_value);
            this.verification_panel.Controls.Add(this.table_value);
            this.verification_panel.Controls.Add(this.name_value);
            this.verification_panel.Controls.Add(this.phone_value);
            this.verification_panel.Controls.Add(this.date_value);
            this.verification_panel.Controls.Add(this.tijd_label);
            this.verification_panel.Controls.Add(this.label_email);
            this.verification_panel.Controls.Add(this.table_label);
            this.verification_panel.Controls.Add(this.phone_label);
            this.verification_panel.Controls.Add(this.name_label);
            this.verification_panel.Controls.Add(this.confirmation_title);
            this.verification_panel.Controls.Add(this.date_label);
            this.verification_panel.Location = new System.Drawing.Point(0, 0);
            this.verification_panel.Name = "verification_panel";
            this.verification_panel.Size = new System.Drawing.Size(890, 467);
            this.verification_panel.TabIndex = 26;
            this.verification_panel.Visible = false;
            this.verification_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.verification_screen_Paint);
            // 
            // finish_panel
            // 
            this.finish_panel.Controls.Add(this.finish_text);
            this.finish_panel.Controls.Add(this.back_begin);
            this.finish_panel.Location = new System.Drawing.Point(0, 0);
            this.finish_panel.Name = "finish_panel";
            this.finish_panel.Size = new System.Drawing.Size(890, 467);
            this.finish_panel.TabIndex = 39;
            this.finish_panel.Visible = false;
            this.finish_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.finish_panel_Paint);
            // 
            // finish_text
            // 
            this.finish_text.AutoSize = true;
            this.finish_text.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.finish_text.Location = new System.Drawing.Point(324, 142);
            this.finish_text.Name = "finish_text";
            this.finish_text.Size = new System.Drawing.Size(244, 25);
            this.finish_text.TabIndex = 40;
            this.finish_text.Text = "U heeft gereserveerd!";
            this.finish_text.Visible = false;
            // 
            // back_begin
            // 
            this.back_begin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(2)))), ((int)(((byte)(69)))));
            this.back_begin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_begin.FlatAppearance.BorderSize = 0;
            this.back_begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_begin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.back_begin.ForeColor = System.Drawing.Color.White;
            this.back_begin.Location = new System.Drawing.Point(344, 223);
            this.back_begin.Name = "back_begin";
            this.back_begin.Size = new System.Drawing.Size(198, 61);
            this.back_begin.TabIndex = 40;
            this.back_begin.Text = "Terug naar reserveren";
            this.back_begin.UseVisualStyleBackColor = false;
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(2)))), ((int)(((byte)(69)))));
            this.confirm_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_button.FlatAppearance.BorderSize = 0;
            this.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_button.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.confirm_button.ForeColor = System.Drawing.Color.White;
            this.confirm_button.Location = new System.Drawing.Point(450, 273);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(170, 61);
            this.confirm_button.TabIndex = 29;
            this.confirm_button.Text = "Reserveren";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // confirmation_back
            // 
            this.confirmation_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(2)))), ((int)(((byte)(69)))));
            this.confirmation_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmation_back.FlatAppearance.BorderSize = 0;
            this.confirmation_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmation_back.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.confirmation_back.ForeColor = System.Drawing.Color.White;
            this.confirmation_back.Location = new System.Drawing.Point(265, 273);
            this.confirmation_back.Name = "confirmation_back";
            this.confirmation_back.Size = new System.Drawing.Size(170, 61);
            this.confirmation_back.TabIndex = 38;
            this.confirmation_back.Text = "Terug";
            this.confirmation_back.UseVisualStyleBackColor = false;
            this.confirmation_back.Click += new System.EventHandler(this.confirmation_back_Click);
            // 
            // email_value
            // 
            this.email_value.BackColor = System.Drawing.SystemColors.Control;
            this.email_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_value.Enabled = false;
            this.email_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_value.Location = new System.Drawing.Point(248, 158);
            this.email_value.Name = "email_value";
            this.email_value.ReadOnly = true;
            this.email_value.Size = new System.Drawing.Size(446, 20);
            this.email_value.TabIndex = 43;
            // 
            // time_value
            // 
            this.time_value.BackColor = System.Drawing.SystemColors.Control;
            this.time_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_value.Enabled = false;
            this.time_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_value.Location = new System.Drawing.Point(231, 208);
            this.time_value.Name = "time_value";
            this.time_value.ReadOnly = true;
            this.time_value.Size = new System.Drawing.Size(450, 20);
            this.time_value.TabIndex = 36;
            this.time_value.TextChanged += new System.EventHandler(this.time_value_TextChanged);
            // 
            // table_value
            // 
            this.table_value.BackColor = System.Drawing.SystemColors.Control;
            this.table_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_value.Enabled = false;
            this.table_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_value.Location = new System.Drawing.Point(244, 231);
            this.table_value.Name = "table_value";
            this.table_value.ReadOnly = true;
            this.table_value.Size = new System.Drawing.Size(450, 20);
            this.table_value.TabIndex = 35;
            // 
            // name_value
            // 
            this.name_value.BackColor = System.Drawing.SystemColors.Control;
            this.name_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_value.Enabled = false;
            this.name_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_value.Location = new System.Drawing.Point(329, 103);
            this.name_value.Name = "name_value";
            this.name_value.ReadOnly = true;
            this.name_value.Size = new System.Drawing.Size(450, 20);
            this.name_value.TabIndex = 34;
            this.name_value.TextChanged += new System.EventHandler(this.name_value_TextChanged);
            // 
            // phone_value
            // 
            this.phone_value.BackColor = System.Drawing.SystemColors.Control;
            this.phone_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_value.Enabled = false;
            this.phone_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_value.Location = new System.Drawing.Point(333, 129);
            this.phone_value.Name = "phone_value";
            this.phone_value.ReadOnly = true;
            this.phone_value.Size = new System.Drawing.Size(450, 20);
            this.phone_value.TabIndex = 28;
            this.phone_value.TextChanged += new System.EventHandler(this.phone_value_TextChanged);
            // 
            // date_value
            // 
            this.date_value.BackColor = System.Drawing.SystemColors.Control;
            this.date_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_value.Enabled = false;
            this.date_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_value.Location = new System.Drawing.Point(347, 185);
            this.date_value.Name = "date_value";
            this.date_value.ReadOnly = true;
            this.date_value.Size = new System.Drawing.Size(450, 20);
            this.date_value.TabIndex = 41;
            this.date_value.TextChanged += new System.EventHandler(this.date_value_TextChanged);
            // 
            // tijd_label
            // 
            this.tijd_label.AutoSize = true;
            this.tijd_label.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tijd_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tijd_label.Location = new System.Drawing.Point(193, 210);
            this.tijd_label.Name = "tijd_label";
            this.tijd_label.Size = new System.Drawing.Size(39, 21);
            this.tijd_label.TabIndex = 37;
            this.tijd_label.Text = "Tijd:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_email.Location = new System.Drawing.Point(192, 157);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(55, 21);
            this.label_email.TabIndex = 42;
            this.label_email.Text = "Email:";
            // 
            // table_label
            // 
            this.table_label.AutoSize = true;
            this.table_label.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.table_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.table_label.Location = new System.Drawing.Point(193, 233);
            this.table_label.Name = "table_label";
            this.table_label.Size = new System.Drawing.Size(51, 21);
            this.table_label.TabIndex = 33;
            this.table_label.Text = "Tafel:";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.phone_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.phone_label.Location = new System.Drawing.Point(193, 129);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(149, 21);
            this.phone_label.TabIndex = 31;
            this.phone_label.Text = "Telefoonnummer :";
            this.phone_label.Click += new System.EventHandler(this.phone_label_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.name_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name_label.Location = new System.Drawing.Point(193, 102);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(137, 21);
            this.name_label.TabIndex = 29;
            this.name_label.Text = "Volledige naam:";
            // 
            // confirmation_title
            // 
            this.confirmation_title.AutoSize = true;
            this.confirmation_title.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.confirmation_title.Location = new System.Drawing.Point(292, 33);
            this.confirmation_title.Name = "confirmation_title";
            this.confirmation_title.Size = new System.Drawing.Size(285, 25);
            this.confirmation_title.TabIndex = 27;
            this.confirmation_title.Text = "Controleer uw gegevens:";
            this.confirmation_title.Visible = false;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.date_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.date_label.Location = new System.Drawing.Point(193, 185);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(158, 21);
            this.date_label.TabIndex = 40;
            this.date_label.Text = "Datum reservering:";
            this.date_label.Click += new System.EventHandler(this.date_label_Click);
            // 
            // table_back
            // 
            this.table_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(2)))), ((int)(((byte)(69)))));
            this.table_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.table_back.FlatAppearance.BorderSize = 0;
            this.table_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table_back.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.table_back.ForeColor = System.Drawing.Color.White;
            this.table_back.Location = new System.Drawing.Point(488, 237);
            this.table_back.Name = "table_back";
            this.table_back.Size = new System.Drawing.Size(170, 61);
            this.table_back.TabIndex = 24;
            this.table_back.Text = "Terug";
            this.table_back.UseVisualStyleBackColor = false;
            this.table_back.Click += new System.EventHandler(this.table_back_Click);
            // 
            // table_next
            // 
            this.table_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(2)))), ((int)(((byte)(69)))));
            this.table_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.table_next.FlatAppearance.BorderSize = 0;
            this.table_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table_next.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.table_next.ForeColor = System.Drawing.Color.White;
            this.table_next.Location = new System.Drawing.Point(664, 237);
            this.table_next.Name = "table_next";
            this.table_next.Size = new System.Drawing.Size(170, 61);
            this.table_next.TabIndex = 25;
            this.table_next.Text = "Verder";
            this.table_next.UseVisualStyleBackColor = false;
            this.table_next.Click += new System.EventHandler(this.table_next_Click);
            // 
            // table_header_text
            // 
            this.table_header_text.AutoSize = true;
            this.table_header_text.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.table_header_text.Location = new System.Drawing.Point(346, 33);
            this.table_header_text.Name = "table_header_text";
            this.table_header_text.Size = new System.Drawing.Size(161, 25);
            this.table_header_text.TabIndex = 22;
            this.table_header_text.Text = "Kies een tafel:";
            this.table_header_text.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(484, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tafelnummer:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(59, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Beschikbare tafels";
            // 
            // table_combo
            // 
            this.table_combo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_combo.FormattingEnabled = true;
            this.table_combo.Location = new System.Drawing.Point(488, 94);
            this.table_combo.Name = "table_combo";
            this.table_combo.Size = new System.Drawing.Size(112, 29);
            this.table_combo.TabIndex = 21;
            this.table_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // time_box
            // 
            this.time_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_box.FormattingEnabled = true;
            this.time_box.Items.AddRange(new object[] {
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.time_box.Location = new System.Drawing.Point(488, 169);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(89, 29);
            this.time_box.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(484, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 21);
            this.label13.TabIndex = 28;
            this.label13.Text = "Tijd:";
            // 
            // datum_box
            // 
            this.datum_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_box.Location = new System.Drawing.Point(634, 203);
            this.datum_box.MinDate = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            this.datum_box.Name = "datum_box";
            this.datum_box.Size = new System.Drawing.Size(170, 27);
            this.datum_box.TabIndex = 7;
            // 
            // telefoon_Box
            // 
            this.telefoon_Box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoon_Box.Location = new System.Drawing.Point(98, 203);
            this.telefoon_Box.Name = "telefoon_Box";
            this.telefoon_Box.Size = new System.Drawing.Size(184, 27);
            this.telefoon_Box.TabIndex = 22;
            this.telefoon_Box.Validating += new System.ComponentModel.CancelEventHandler(this.telefoon_Box_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Verplicht_text
            // 
            this.Verplicht_text.AutoSize = true;
            this.Verplicht_text.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verplicht_text.Location = new System.Drawing.Point(97, 263);
            this.Verplicht_text.Name = "Verplicht_text";
            this.Verplicht_text.Size = new System.Drawing.Size(114, 15);
            this.Verplicht_text.TabIndex = 23;
            this.Verplicht_text.Text = "* Verplichte velden";
            // 
            // email_box
            // 
            this.email_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(302, 202);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(204, 27);
            this.email_box.TabIndex = 24;
            this.email_box.Validating += new System.ComponentModel.CancelEventHandler(this.email_box_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label12.Location = new System.Drawing.Point(299, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email *";
            // 
            // nummerDataGridViewTextBoxColumn
            // 
            this.nummerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nummerDataGridViewTextBoxColumn.DataPropertyName = "Nummer";
            this.nummerDataGridViewTextBoxColumn.HeaderText = "Nummer";
            this.nummerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nummerDataGridViewTextBoxColumn.Name = "nummerDataGridViewTextBoxColumn";
            this.nummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capaciteitDataGridViewTextBoxColumn
            // 
            this.capaciteitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capaciteitDataGridViewTextBoxColumn.DataPropertyName = "Capaciteit";
            this.capaciteitDataGridViewTextBoxColumn.HeaderText = "Capaciteit";
            this.capaciteitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capaciteitDataGridViewTextBoxColumn.Name = "capaciteitDataGridViewTextBoxColumn";
            this.capaciteitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablesBindingSource2
            // 
            this.tablesBindingSource2.DataSource = typeof(HRDelicates.Tables);
            // 
            // tablesBindingSource1
            // 
            this.tablesBindingSource1.DataSource = typeof(HRDelicates.Tables);
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataSource = typeof(HRDelicates.Tables);
            // 
            // Reservationscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_panel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.personen_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verder_button);
            this.Controls.Add(this.datum_box);
            this.Controls.Add(this.plaats_box);
            this.Controls.Add(this.postcode_box);
            this.Controls.Add(this.adres_box);
            this.Controls.Add(this.achternaam_box);
            this.Controls.Add(this.naam_box);
            this.Controls.Add(this.telefoon_Box);
            this.Controls.Add(this.Verplicht_text);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.label12);
            this.Name = "Reservationscreen";
            this.Size = new System.Drawing.Size(890, 467);
            this.Load += new System.EventHandler(this.Reservationscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personen_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.table_panel.ResumeLayout(false);
            this.table_panel.PerformLayout();
            this.verification_panel.ResumeLayout(false);
            this.verification_panel.PerformLayout();
            this.finish_panel.ResumeLayout(false);
            this.finish_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private System.Windows.Forms.TextBox naam_box;
        private System.Windows.Forms.TextBox achternaam_box;
        private System.Windows.Forms.TextBox adres_box;
        private System.Windows.Forms.TextBox postcode_box;
        private System.Windows.Forms.TextBox plaats_box;
        private System.Windows.Forms.Button verder_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown personen_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tablesBindingSource1;
        private System.Windows.Forms.BindingSource tablesBindingSource2;
        private System.Windows.Forms.Panel table_panel;
        private System.Windows.Forms.ComboBox table_combo;
        private System.Windows.Forms.Label table_header_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button table_back;
        private System.Windows.Forms.Button table_next;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capaciteitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel verification_panel;
        private System.Windows.Forms.TextBox phone_value;
        private System.Windows.Forms.Label confirmation_title;
        private System.Windows.Forms.TextBox table_value;
        private System.Windows.Forms.TextBox name_value;
        private System.Windows.Forms.Label table_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox time_box;
        private System.Windows.Forms.DateTimePicker datum_box;
        private System.Windows.Forms.Label tijd_label;
        private System.Windows.Forms.TextBox time_value;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button confirmation_back;
        private System.Windows.Forms.Panel finish_panel;
        private System.Windows.Forms.Button back_begin;
        private System.Windows.Forms.Label finish_text;
        private System.Windows.Forms.TextBox telefoon_Box;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox date_value;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Verplicht_text;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox email_value;
        private System.Windows.Forms.Label label_email;
    }
}
