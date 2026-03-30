
namespace Proiect_IP
{
    partial class Abonati
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
            this.abonatiLabel = new System.Windows.Forms.Label();
            this.IDpersLabel = new System.Windows.Forms.Label();
            this.updateUserTextBox = new System.Windows.Forms.TextBox();
            this.AddPenalizareButton = new System.Windows.Forms.Button();
            this.DeletePenalizareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(915, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // abonatiLabel
            // 
            this.abonatiLabel.AutoSize = true;
            this.abonatiLabel.BackColor = System.Drawing.Color.Transparent;
            this.abonatiLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonatiLabel.Location = new System.Drawing.Point(362, 26);
            this.abonatiLabel.Name = "abonatiLabel";
            this.abonatiLabel.Size = new System.Drawing.Size(217, 47);
            this.abonatiLabel.TabIndex = 1;
            this.abonatiLabel.Text = "Lista abonati";
            // 
            // IDpersLabel
            // 
            this.IDpersLabel.AutoSize = true;
            this.IDpersLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDpersLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDpersLabel.Location = new System.Drawing.Point(275, 489);
            this.IDpersLabel.Name = "IDpersLabel";
            this.IDpersLabel.Size = new System.Drawing.Size(118, 30);
            this.IDpersLabel.TabIndex = 2;
            this.IDpersLabel.Text = "ID persoana:";
            // 
            // updateUserTextBox
            // 
            this.updateUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateUserTextBox.Location = new System.Drawing.Point(469, 481);
            this.updateUserTextBox.Name = "updateUserTextBox";
            this.updateUserTextBox.Size = new System.Drawing.Size(210, 38);
            this.updateUserTextBox.TabIndex = 3;
            // 
            // AddPenalizareButton
            // 
            this.AddPenalizareButton.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPenalizareButton.Location = new System.Drawing.Point(118, 588);
            this.AddPenalizareButton.Name = "AddPenalizareButton";
            this.AddPenalizareButton.Size = new System.Drawing.Size(275, 53);
            this.AddPenalizareButton.TabIndex = 5;
            this.AddPenalizareButton.Text = "Adauga penalizare";
            this.AddPenalizareButton.UseVisualStyleBackColor = true;
            this.AddPenalizareButton.Click += new System.EventHandler(this.AddPenalizareButton_Click);
            // 
            // DeletePenalizareButton
            // 
            this.DeletePenalizareButton.Font = new System.Drawing.Font("Microsoft Himalaya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePenalizareButton.Location = new System.Drawing.Point(543, 588);
            this.DeletePenalizareButton.Name = "DeletePenalizareButton";
            this.DeletePenalizareButton.Size = new System.Drawing.Size(275, 53);
            this.DeletePenalizareButton.TabIndex = 6;
            this.DeletePenalizareButton.Text = "Sterge penalizare";
            this.DeletePenalizareButton.UseVisualStyleBackColor = true;
            this.DeletePenalizareButton.Click += new System.EventHandler(this.DeletePenalizareButton_Click);
            // 
            // Abonati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_IP.Properties.Resources._342911537_890876065335725_8432234170368341158_n;
            this.ClientSize = new System.Drawing.Size(939, 691);
            this.Controls.Add(this.DeletePenalizareButton);
            this.Controls.Add(this.AddPenalizareButton);
            this.Controls.Add(this.updateUserTextBox);
            this.Controls.Add(this.IDpersLabel);
            this.Controls.Add(this.abonatiLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Abonati";
            this.Text = "Abonati";
            this.Load += new System.EventHandler(this.Abonati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label abonatiLabel;
        private System.Windows.Forms.Label IDpersLabel;
        private System.Windows.Forms.TextBox updateUserTextBox;
        private System.Windows.Forms.Button AddPenalizareButton;
        private System.Windows.Forms.Button DeletePenalizareButton;
    }
}