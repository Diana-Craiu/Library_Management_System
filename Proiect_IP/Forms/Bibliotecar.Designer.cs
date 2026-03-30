
namespace Proiect_IP
{
    partial class Biblio
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
            this.bibliotecarLabel = new System.Windows.Forms.Label();
            this.ImprumutaButton = new System.Windows.Forms.Button();
            this.cartiGridView = new System.Windows.Forms.DataGridView();
            this.RestituieButton = new System.Windows.Forms.Button();
            this.numeLabel = new System.Windows.Forms.Label();
            this.numeBox = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNBox = new System.Windows.Forms.TextBox();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.prenumeBox = new System.Windows.Forms.TextBox();
            this.IDpersLabel = new System.Windows.Forms.Label();
            this.IDpersBox = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.userGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cartiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecarLabel
            // 
            this.bibliotecarLabel.AutoSize = true;
            this.bibliotecarLabel.BackColor = System.Drawing.Color.Transparent;
            this.bibliotecarLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bibliotecarLabel.Location = new System.Drawing.Point(475, 37);
            this.bibliotecarLabel.Name = "bibliotecarLabel";
            this.bibliotecarLabel.Size = new System.Drawing.Size(204, 50);
            this.bibliotecarLabel.TabIndex = 0;
            this.bibliotecarLabel.Text = "Bibliotecar";
            // 
            // ImprumutaButton
            // 
            this.ImprumutaButton.BackColor = System.Drawing.Color.Thistle;
            this.ImprumutaButton.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprumutaButton.Location = new System.Drawing.Point(803, 565);
            this.ImprumutaButton.Name = "ImprumutaButton";
            this.ImprumutaButton.Size = new System.Drawing.Size(230, 53);
            this.ImprumutaButton.TabIndex = 1;
            this.ImprumutaButton.Text = "Imprumuta";
            this.ImprumutaButton.UseVisualStyleBackColor = false;
            this.ImprumutaButton.Click += new System.EventHandler(this.ImprumutaButton_Click);
            // 
            // cartiGridView
            // 
            this.cartiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartiGridView.Location = new System.Drawing.Point(12, 120);
            this.cartiGridView.Name = "cartiGridView";
            this.cartiGridView.RowHeadersWidth = 51;
            this.cartiGridView.RowTemplate.Height = 24;
            this.cartiGridView.Size = new System.Drawing.Size(555, 211);
            this.cartiGridView.TabIndex = 2;
            // 
            // RestituieButton
            // 
            this.RestituieButton.BackColor = System.Drawing.Color.Thistle;
            this.RestituieButton.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestituieButton.Location = new System.Drawing.Point(201, 565);
            this.RestituieButton.Name = "RestituieButton";
            this.RestituieButton.Size = new System.Drawing.Size(230, 53);
            this.RestituieButton.TabIndex = 3;
            this.RestituieButton.Text = "Restituie";
            this.RestituieButton.UseVisualStyleBackColor = false;
            this.RestituieButton.Click += new System.EventHandler(this.RestituieButton_Click);
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.BackColor = System.Drawing.Color.Transparent;
            this.numeLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLabel.Location = new System.Drawing.Point(422, 390);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(69, 30);
            this.numeLabel.TabIndex = 4;
            this.numeLabel.Text = "Nume:";
            // 
            // numeBox
            // 
            this.numeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeBox.Location = new System.Drawing.Point(359, 457);
            this.numeBox.Name = "numeBox";
            this.numeBox.Size = new System.Drawing.Size(193, 38);
            this.numeBox.TabIndex = 6;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.BackColor = System.Drawing.Color.Transparent;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(1007, 390);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(65, 30);
            this.ISBNLabel.TabIndex = 8;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // ISBNBox
            // 
            this.ISBNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ISBNBox.Location = new System.Drawing.Point(952, 457);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.Size = new System.Drawing.Size(186, 38);
            this.ISBNBox.TabIndex = 9;
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.prenumeLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeLabel.Location = new System.Drawing.Point(712, 390);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(91, 30);
            this.prenumeLabel.TabIndex = 5;
            this.prenumeLabel.Text = "Prenume:";
            // 
            // prenumeBox
            // 
            this.prenumeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prenumeBox.Location = new System.Drawing.Point(671, 457);
            this.prenumeBox.Name = "prenumeBox";
            this.prenumeBox.Size = new System.Drawing.Size(178, 38);
            this.prenumeBox.TabIndex = 7;
            // 
            // IDpersLabel
            // 
            this.IDpersLabel.AutoSize = true;
            this.IDpersLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDpersLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDpersLabel.Location = new System.Drawing.Point(87, 390);
            this.IDpersLabel.Name = "IDpersLabel";
            this.IDpersLabel.Size = new System.Drawing.Size(118, 30);
            this.IDpersLabel.TabIndex = 10;
            this.IDpersLabel.Text = "ID persoana:";
            // 
            // IDpersBox
            // 
            this.IDpersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDpersBox.Location = new System.Drawing.Point(52, 457);
            this.IDpersBox.Name = "IDpersBox";
            this.IDpersBox.Size = new System.Drawing.Size(188, 38);
            this.IDpersBox.TabIndex = 11;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Thistle;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(1012, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(143, 43);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(585, 120);
            this.userGridView.Name = "userGridView";
            this.userGridView.RowHeadersWidth = 51;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(570, 211);
            this.userGridView.TabIndex = 13;
            // 
            // Biblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_IP.Properties.Resources._6;
            this.ClientSize = new System.Drawing.Size(1167, 676);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.IDpersBox);
            this.Controls.Add(this.IDpersLabel);
            this.Controls.Add(this.ISBNBox);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.prenumeBox);
            this.Controls.Add(this.numeBox);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.numeLabel);
            this.Controls.Add(this.RestituieButton);
            this.Controls.Add(this.cartiGridView);
            this.Controls.Add(this.ImprumutaButton);
            this.Controls.Add(this.bibliotecarLabel);
            this.Name = "Biblio";
            this.Text = "Bibliotecar";
            this.Load += new System.EventHandler(this.Biblio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bibliotecarLabel;
        private System.Windows.Forms.Button ImprumutaButton;
        private System.Windows.Forms.DataGridView cartiGridView;
        private System.Windows.Forms.Button RestituieButton;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.TextBox numeBox;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox ISBNBox;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.TextBox prenumeBox;
        private System.Windows.Forms.Label IDpersLabel;
        private System.Windows.Forms.TextBox IDpersBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridView userGridView;
    }
}