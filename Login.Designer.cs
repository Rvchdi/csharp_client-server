namespace C_S
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            usernameTXT = new TextBox();
            passwordTXT = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(174, 166);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 45);
            label1.TabIndex = 0;
            label1.Text = "Nom d'utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(174, 256);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 45);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe";
            // 
            // usernameTXT
            // 
            usernameTXT.Location = new Point(490, 170);
            usernameTXT.Margin = new Padding(4);
            usernameTXT.Name = "usernameTXT";
            usernameTXT.Size = new Size(281, 39);
            usernameTXT.TabIndex = 2;
            // 
            // passwordTXT
            // 
            passwordTXT.Location = new Point(490, 260);
            passwordTXT.Margin = new Padding(4);
            passwordTXT.Name = "passwordTXT";
            passwordTXT.Size = new Size(281, 39);
            passwordTXT.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(411, 439);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(261, 88);
            button1.TabIndex = 4;
            button1.Text = "Se connecter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(451, 366);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(305, 36);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Afficher le mot de passe";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(306, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(451, 51);
            label3.TabIndex = 6;
            label3.Text = "Gestion de marchandise";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1040, 576);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(passwordTXT);
            Controls.Add(usernameTXT);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTXT;
        private TextBox passwordTXT;
        private Button button1;
        private CheckBox checkBox1;
        private Label label3;
    }
}