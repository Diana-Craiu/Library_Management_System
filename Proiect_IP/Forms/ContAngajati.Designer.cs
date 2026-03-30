
namespace Proiect_IP.Forms
{
    partial class ContAngajati
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
            this.auxUserBox = new System.Windows.Forms.TextBox();
            this.auxPassBox = new System.Windows.Forms.TextBox();
            this.persUsernameLabel = new System.Windows.Forms.Label();
            this.persPasswordLabel = new System.Windows.Forms.Label();
            this.persNivLabel = new System.Windows.Forms.Label();
            this.comboBoxAccessLevel = new System.Windows.Forms.ComboBox();
            this.ListaAbonatiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // auxUserBox
            // 
            this.auxUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.auxUserBox.Location = new System.Drawing.Point(167, 39);
            this.auxUserBox.Name = "auxUserBox";
            this.auxUserBox.Size = new System.Drawing.Size(166, 38);
            this.auxUserBox.TabIndex = 16;
            // 
            // auxPassBox
            // 
            this.auxPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.auxPassBox.Location = new System.Drawing.Point(167, 103);
            this.auxPassBox.Name = "auxPassBox";
            this.auxPassBox.Size = new System.Drawing.Size(166, 38);
            this.auxPassBox.TabIndex = 18;
            this.auxPassBox.UseSystemPasswordChar = true;
            // 
            // persUsernameLabel
            // 
            this.persUsernameLabel.AutoSize = true;
            this.persUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.persUsernameLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persUsernameLabel.Location = new System.Drawing.Point(40, 49);
            this.persUsernameLabel.Name = "persUsernameLabel";
            this.persUsernameLabel.Size = new System.Drawing.Size(92, 28);
            this.persUsernameLabel.TabIndex = 20;
            this.persUsernameLabel.Text = "Username:";
            // 
            // persPasswordLabel
            // 
            this.persPasswordLabel.AutoSize = true;
            this.persPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.persPasswordLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persPasswordLabel.Location = new System.Drawing.Point(40, 113);
            this.persPasswordLabel.Name = "persPasswordLabel";
            this.persPasswordLabel.Size = new System.Drawing.Size(87, 28);
            this.persPasswordLabel.TabIndex = 21;
            this.persPasswordLabel.Text = "Password:";
            // 
            // persNivLabel
            // 
            this.persNivLabel.AutoSize = true;
            this.persNivLabel.BackColor = System.Drawing.Color.Transparent;
            this.persNivLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persNivLabel.Location = new System.Drawing.Point(40, 182);
            this.persNivLabel.Name = "persNivLabel";
            this.persNivLabel.Size = new System.Drawing.Size(102, 28);
            this.persNivLabel.TabIndex = 22;
            this.persNivLabel.Text = "Nivel acces:";
            // 
            // comboBoxAccessLevel
            // 
            this.comboBoxAccessLevel.FormattingEnabled = true;
            this.comboBoxAccessLevel.Items.AddRange(new object[] {
            "Bibliotecar",
            "Administrator"});
            this.comboBoxAccessLevel.Location = new System.Drawing.Point(167, 182);
            this.comboBoxAccessLevel.Name = "comboBoxAccessLevel";
            this.comboBoxAccessLevel.Size = new System.Drawing.Size(166, 24);
            this.comboBoxAccessLevel.TabIndex = 23;
            // 
            // ListaAbonatiButton
            // 
            this.ListaAbonatiButton.Font = new System.Drawing.Font("Microsoft Himalaya", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAbonatiButton.Location = new System.Drawing.Point(57, 277);
            this.ListaAbonatiButton.Name = "ListaAbonatiButton";
            this.ListaAbonatiButton.Size = new System.Drawing.Size(375, 45);
            this.ListaAbonatiButton.TabIndex = 19;
            this.ListaAbonatiButton.Text = "Adaugare angajat";
            this.ListaAbonatiButton.UseVisualStyleBackColor = true;
            this.ListaAbonatiButton.Click += new System.EventHandler(this.ListaAbonatiButton_Click);
            // 
            // ContAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_IP.Properties.Resources._342911537_890876065335725_8432234170368341158_n;
            this.ClientSize = new System.Drawing.Size(484, 367);
            this.Controls.Add(this.comboBoxAccessLevel);
            this.Controls.Add(this.persNivLabel);
            this.Controls.Add(this.persPasswordLabel);
            this.Controls.Add(this.persUsernameLabel);
            this.Controls.Add(this.ListaAbonatiButton);
            this.Controls.Add(this.auxPassBox);
            this.Controls.Add(this.auxUserBox);
            this.Name = "ContAngajati";
            this.Text = "ContAngajati";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox auxUserBox;
        private System.Windows.Forms.TextBox auxPassBox;
        private System.Windows.Forms.Button ListaAbonatiButton;
        private System.Windows.Forms.Label persUsernameLabel;
        private System.Windows.Forms.Label persPasswordLabel;
        private System.Windows.Forms.Label persNivLabel;
        private System.Windows.Forms.ComboBox comboBoxAccessLevel;
    }
}