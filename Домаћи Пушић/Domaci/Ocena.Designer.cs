﻿
namespace Ednevnik2
{
    partial class Ocena
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
            this.cmb_Godina = new System.Windows.Forms.ComboBox();
            this.cmb_Profesor = new System.Windows.Forms.ComboBox();
            this.cmb_Predmet = new System.Windows.Forms.ComboBox();
            this.cmb_Odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_Ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_Ocena = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Grid_Ocene = new System.Windows.Forms.DataGridView();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.lbl_profesor = new System.Windows.Forms.Label();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.lbl_odeljenje = new System.Windows.Forms.Label();
            this.lbl_ucenik = new System.Windows.Forms.Label();
            this.lbl_ocena = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Godina
            // 
            this.cmb_Godina.FormattingEnabled = true;
            this.cmb_Godina.Location = new System.Drawing.Point(49, 48);
            this.cmb_Godina.Name = "cmb_Godina";
            this.cmb_Godina.Size = new System.Drawing.Size(121, 21);
            this.cmb_Godina.TabIndex = 0;
            this.cmb_Godina.SelectedValueChanged += new System.EventHandler(this.cmb_Godina_SelectedValueChanged);
            // 
            // cmb_Profesor
            // 
            this.cmb_Profesor.FormattingEnabled = true;
            this.cmb_Profesor.Location = new System.Drawing.Point(191, 48);
            this.cmb_Profesor.Name = "cmb_Profesor";
            this.cmb_Profesor.Size = new System.Drawing.Size(121, 21);
            this.cmb_Profesor.TabIndex = 1;
            this.cmb_Profesor.SelectedValueChanged += new System.EventHandler(this.cmb_Profesor_SelectedValueChanged);
            // 
            // cmb_Predmet
            // 
            this.cmb_Predmet.FormattingEnabled = true;
            this.cmb_Predmet.Location = new System.Drawing.Point(351, 48);
            this.cmb_Predmet.Name = "cmb_Predmet";
            this.cmb_Predmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_Predmet.TabIndex = 2;
            this.cmb_Predmet.SelectedValueChanged += new System.EventHandler(this.cmb_Predmet_SelectedValueChanged);
            // 
            // cmb_Odeljenje
            // 
            this.cmb_Odeljenje.FormattingEnabled = true;
            this.cmb_Odeljenje.Location = new System.Drawing.Point(506, 48);
            this.cmb_Odeljenje.Name = "cmb_Odeljenje";
            this.cmb_Odeljenje.Size = new System.Drawing.Size(121, 21);
            this.cmb_Odeljenje.TabIndex = 3;
            this.cmb_Odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_Odeljenje_SelectedValueChanged);
            // 
            // cmb_Ucenik
            // 
            this.cmb_Ucenik.FormattingEnabled = true;
            this.cmb_Ucenik.Location = new System.Drawing.Point(49, 119);
            this.cmb_Ucenik.Name = "cmb_Ucenik";
            this.cmb_Ucenik.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ucenik.TabIndex = 4;
            // 
            // cmb_Ocena
            // 
            this.cmb_Ocena.FormattingEnabled = true;
            this.cmb_Ocena.Location = new System.Drawing.Point(191, 119);
            this.cmb_Ocena.Name = "cmb_Ocena";
            this.cmb_Ocena.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ocena.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(506, 120);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 20);
            this.Datum.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(351, 119);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 7;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(662, 46);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Dodaj";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(662, 77);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Izmeni";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(662, 106);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Brisi";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Grid_Ocene
            // 
            this.Grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocene.Location = new System.Drawing.Point(49, 232);
            this.Grid_Ocene.Name = "Grid_Ocene";
            this.Grid_Ocene.Size = new System.Drawing.Size(688, 236);
            this.Grid_Ocene.TabIndex = 11;
            this.Grid_Ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocene_CellClick);
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Location = new System.Drawing.Point(46, 10);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(41, 13);
            this.lbl_godina.TabIndex = 12;
            this.lbl_godina.Text = "Godina";
            // 
            // lbl_profesor
            // 
            this.lbl_profesor.AutoSize = true;
            this.lbl_profesor.Location = new System.Drawing.Point(188, 10);
            this.lbl_profesor.Name = "lbl_profesor";
            this.lbl_profesor.Size = new System.Drawing.Size(46, 13);
            this.lbl_profesor.TabIndex = 13;
            this.lbl_profesor.Text = "Profesor";
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Location = new System.Drawing.Point(348, 10);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(46, 13);
            this.lbl_predmet.TabIndex = 14;
            this.lbl_predmet.Text = "Predmet";
            // 
            // lbl_odeljenje
            // 
            this.lbl_odeljenje.AutoSize = true;
            this.lbl_odeljenje.Location = new System.Drawing.Point(503, 10);
            this.lbl_odeljenje.Name = "lbl_odeljenje";
            this.lbl_odeljenje.Size = new System.Drawing.Size(51, 13);
            this.lbl_odeljenje.TabIndex = 15;
            this.lbl_odeljenje.Text = "Odeljenje";
            // 
            // lbl_ucenik
            // 
            this.lbl_ucenik.AutoSize = true;
            this.lbl_ucenik.Location = new System.Drawing.Point(46, 88);
            this.lbl_ucenik.Name = "lbl_ucenik";
            this.lbl_ucenik.Size = new System.Drawing.Size(41, 13);
            this.lbl_ucenik.TabIndex = 16;
            this.lbl_ucenik.Text = "Ucenik";
            // 
            // lbl_ocena
            // 
            this.lbl_ocena.AutoSize = true;
            this.lbl_ocena.Location = new System.Drawing.Point(188, 88);
            this.lbl_ocena.Name = "lbl_ocena";
            this.lbl_ocena.Size = new System.Drawing.Size(39, 13);
            this.lbl_ocena.TabIndex = 17;
            this.lbl_ocena.Text = "Ocena";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(348, 88);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "ID";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(503, 88);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_datum.TabIndex = 19;
            this.lbl_datum.Text = "Datum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(688, 20);
            this.textBox2.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ocena);
            this.Controls.Add(this.lbl_ucenik);
            this.Controls.Add(this.lbl_odeljenje);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.lbl_profesor);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.Grid_Ocene);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmb_Ocena);
            this.Controls.Add(this.cmb_Ucenik);
            this.Controls.Add(this.cmb_Odeljenje);
            this.Controls.Add(this.cmb_Predmet);
            this.Controls.Add(this.cmb_Profesor);
            this.Controls.Add(this.cmb_Godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Godina;
        private System.Windows.Forms.ComboBox cmb_Profesor;
        private System.Windows.Forms.ComboBox cmb_Predmet;
        private System.Windows.Forms.ComboBox cmb_Odeljenje;
        private System.Windows.Forms.ComboBox cmb_Ucenik;
        private System.Windows.Forms.ComboBox cmb_Ocena;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Grid_Ocene;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.Label lbl_profesor;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label lbl_odeljenje;
        private System.Windows.Forms.Label lbl_ucenik;
        private System.Windows.Forms.Label lbl_ocena;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.TextBox textBox2;
    }
}