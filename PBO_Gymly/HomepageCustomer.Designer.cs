namespace PBO_Gymly
{
    partial class HomepageCustomer
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
            Button_Jadwal = new Button();
            SuspendLayout();
            // 
            // Button_Jadwal
            // 
            Button_Jadwal.Location = new Point(396, 342);
            Button_Jadwal.Name = "Button_Jadwal";
            Button_Jadwal.Size = new Size(75, 23);
            Button_Jadwal.TabIndex = 0;
            Button_Jadwal.Text = "Jadwal";
            Button_Jadwal.UseVisualStyleBackColor = true;
            Button_Jadwal.Click += Button_Jadwal_Click;
            // 
            // HomepageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Jadwal);
            Name = "HomepageCustomer";
            Text = "HomepageCustomer";
            ResumeLayout(false);
        }

        #endregion

        private Button Button_Jadwal;
    }
}