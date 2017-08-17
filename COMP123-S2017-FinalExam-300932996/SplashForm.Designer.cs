namespace COMP123_S2017_FinalExam_300932996
{
    partial class SplashForm
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
            this.FormTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FormTimer
            // 
            this.FormTimer.Enabled = true;
            this.FormTimer.Interval = 3000;
            this.FormTimer.Tick += new System.EventHandler(this.FormTimer_Tick);
            // 
            // WelcomeText
            // 
            this.WelcomeText.BackColor = System.Drawing.Color.SpringGreen;
            this.WelcomeText.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.Location = new System.Drawing.Point(50, 134);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.ReadOnly = true;
            this.WelcomeText.Size = new System.Drawing.Size(486, 43);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "Welcome To  PickmyCard";
            this.WelcomeText.TextChanged += new System.EventHandler(this.WelcomeText_TextChanged);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.WelcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer FormTimer;
        private System.Windows.Forms.TextBox WelcomeText;
    }
}