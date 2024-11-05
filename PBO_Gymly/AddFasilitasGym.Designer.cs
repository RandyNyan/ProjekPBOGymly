﻿namespace PBO_Gymly
{
    partial class AddFasilitasGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFasilitasGym));
            ButtonCancel = new Button();
            ButtonAdd = new Button();
            TextBoxJumlahFasilitas = new TextBox();
            TextBoxNamaFasilitas = new TextBox();
            Label_JumlahFasilitas = new Label();
            Label_NamaFasilitas = new Label();
            SuspendLayout();
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.FromArgb(127, 200, 248);
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCancel.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonCancel.Location = new Point(256, 402);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(63, 36);
            ButtonCancel.TabIndex = 0;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click_1;
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.FromArgb(127, 200, 248);
            ButtonAdd.FlatAppearance.BorderSize = 0;
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.Font = new Font("Anton", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonAdd.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonAdd.Location = new Point(325, 402);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(63, 36);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // TextBoxJumlahFasilitas
            // 
            TextBoxJumlahFasilitas.BackColor = Color.FromArgb(109, 106, 117);
            TextBoxJumlahFasilitas.BorderStyle = BorderStyle.None;
            TextBoxJumlahFasilitas.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxJumlahFasilitas.ForeColor = Color.FromArgb(249, 249, 249);
            TextBoxJumlahFasilitas.Location = new Point(42, 242);
            TextBoxJumlahFasilitas.Name = "TextBoxJumlahFasilitas";
            TextBoxJumlahFasilitas.Size = new Size(250, 24);
            TextBoxJumlahFasilitas.TabIndex = 7;
            // 
            // TextBoxNamaFasilitas
            // 
            TextBoxNamaFasilitas.BackColor = Color.FromArgb(109, 106, 117);
            TextBoxNamaFasilitas.BorderStyle = BorderStyle.None;
            TextBoxNamaFasilitas.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            TextBoxNamaFasilitas.ForeColor = Color.FromArgb(249, 249, 249);
            TextBoxNamaFasilitas.Location = new Point(42, 161);
            TextBoxNamaFasilitas.Name = "TextBoxNamaFasilitas";
            TextBoxNamaFasilitas.Size = new Size(250, 24);
            TextBoxNamaFasilitas.TabIndex = 6;
            // 
            // Label_JumlahFasilitas
            // 
            Label_JumlahFasilitas.AutoSize = true;
            Label_JumlahFasilitas.BackColor = Color.Transparent;
            Label_JumlahFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_JumlahFasilitas.ForeColor = Color.FromArgb(249, 249, 249);
            Label_JumlahFasilitas.Location = new Point(35, 209);
            Label_JumlahFasilitas.Name = "Label_JumlahFasilitas";
            Label_JumlahFasilitas.Size = new Size(152, 28);
            Label_JumlahFasilitas.TabIndex = 5;
            Label_JumlahFasilitas.Text = "Jumlah Fasilitas";
            // 
            // Label_NamaFasilitas
            // 
            Label_NamaFasilitas.AutoSize = true;
            Label_NamaFasilitas.BackColor = Color.Transparent;
            Label_NamaFasilitas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            Label_NamaFasilitas.ForeColor = Color.FromArgb(249, 249, 249);
            Label_NamaFasilitas.Location = new Point(35, 128);
            Label_NamaFasilitas.Name = "Label_NamaFasilitas";
            Label_NamaFasilitas.Size = new Size(140, 28);
            Label_NamaFasilitas.TabIndex = 4;
            Label_NamaFasilitas.Text = "Nama Fasilitas";
            // 
            // AddFasilitasGym
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 450);
            Controls.Add(TextBoxJumlahFasilitas);
            Controls.Add(TextBoxNamaFasilitas);
            Controls.Add(Label_JumlahFasilitas);
            Controls.Add(Label_NamaFasilitas);
            Controls.Add(ButtonAdd);
            Controls.Add(ButtonCancel);
            Name = "AddFasilitasGym";
            Text = "AddFasilitasGym";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCancel;
        private Button ButtonAdd;
        private TextBox TextBoxJumlahFasilitas;
        private TextBox TextBoxNamaFasilitas;
        private Label Label_JumlahFasilitas;
        private Label Label_NamaFasilitas;
    }
}