namespace PBO_Gymly
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            ButtonFasilitasGym = new Button();
            ButtonLogout = new Button();
            SuspendLayout();
            // 
            // ButtonFasilitasGym
            // 
            ButtonFasilitasGym.BackColor = Color.FromArgb(127, 200, 248);
            ButtonFasilitasGym.FlatAppearance.BorderSize = 0;
            ButtonFasilitasGym.FlatStyle = FlatStyle.Flat;
            ButtonFasilitasGym.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonFasilitasGym.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonFasilitasGym.Location = new Point(525, 56);
            ButtonFasilitasGym.Name = "ButtonFasilitasGym";
            ButtonFasilitasGym.Size = new Size(201, 40);
            ButtonFasilitasGym.TabIndex = 0;
            ButtonFasilitasGym.Text = "Fasilitas Gym";
            ButtonFasilitasGym.UseVisualStyleBackColor = true;
            ButtonFasilitasGym.Click += ButtonFasilitasGym_Click;
            // 
            // ButtonLogout
            // 
            ButtonLogout.BackColor = Color.FromArgb(127, 200, 248);
            ButtonLogout.FlatAppearance.BorderSize = 0;
            ButtonLogout.FlatStyle = FlatStyle.Flat;
            ButtonLogout.Font = new Font("Anton", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLogout.ForeColor = Color.FromArgb(249, 249, 249);
            ButtonLogout.Location = new Point(525, 382);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(201, 40);
            ButtonLogout.TabIndex = 1;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonLogout);
            Controls.Add(ButtonFasilitasGym);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonFasilitasGym;
        private Button ButtonLogout;
    }
}