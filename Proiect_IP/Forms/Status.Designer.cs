
namespace Proiect_IP
{
    partial class Status
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ISBNStatusBox = new System.Windows.Forms.TextBox();
            this.ModifcaButton = new System.Windows.Forms.Button();
            this.nrExBox = new System.Windows.Forms.TextBox();
            this.ExemplareLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(354, 23);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(188, 47);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status carti";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.BackColor = System.Drawing.Color.Transparent;
            this.ISBNLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLabel.Location = new System.Drawing.Point(34, 479);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(65, 30);
            this.ISBNLabel.TabIndex = 2;
            this.ISBNLabel.Text = "ISBN:";
            // 
            // ISBNStatusBox
            // 
            this.ISBNStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ISBNStatusBox.Location = new System.Drawing.Point(121, 468);
            this.ISBNStatusBox.Name = "ISBNStatusBox";
            this.ISBNStatusBox.Size = new System.Drawing.Size(223, 38);
            this.ISBNStatusBox.TabIndex = 3;
            // 
            // ModifcaButton
            // 
            this.ModifcaButton.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifcaButton.Location = new System.Drawing.Point(560, 566);
            this.ModifcaButton.Name = "ModifcaButton";
            this.ModifcaButton.Size = new System.Drawing.Size(201, 45);
            this.ModifcaButton.TabIndex = 6;
            this.ModifcaButton.Text = "Modifica";
            this.ModifcaButton.UseVisualStyleBackColor = true;
            this.ModifcaButton.Click += new System.EventHandler(this.ModifcaButton_Click);
            // 
            // nrExBox
            // 
            this.nrExBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nrExBox.Location = new System.Drawing.Point(660, 468);
            this.nrExBox.Name = "nrExBox";
            this.nrExBox.Size = new System.Drawing.Size(169, 38);
            this.nrExBox.TabIndex = 7;
            // 
            // ExemplareLabel
            // 
            this.ExemplareLabel.AutoSize = true;
            this.ExemplareLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExemplareLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExemplareLabel.Location = new System.Drawing.Point(462, 476);
            this.ExemplareLabel.Name = "ExemplareLabel";
            this.ExemplareLabel.Size = new System.Drawing.Size(166, 30);
            this.ExemplareLabel.TabIndex = 8;
            this.ExemplareLabel.Text = "Numar exemplare:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Sala de lectura",
            "Imprumutat"});
            this.statusComboBox.Location = new System.Drawing.Point(121, 585);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(223, 24);
            this.statusComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status:";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_IP.Properties.Resources._342911537_890876065335725_8432234170368341158_n;
            this.ClientSize = new System.Drawing.Size(901, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.ExemplareLabel);
            this.Controls.Add(this.nrExBox);
            this.Controls.Add(this.ModifcaButton);
            this.Controls.Add(this.ISBNStatusBox);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox ISBNStatusBox;
        private System.Windows.Forms.Button ModifcaButton;
        private System.Windows.Forms.TextBox nrExBox;
        private System.Windows.Forms.Label ExemplareLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label1;
    }
}