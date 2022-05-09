
namespace VanzariClient
{
    partial class Manage
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
            this.label1 = new System.Windows.Forms.Label();
            this.produseDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.descriereTextBox = new System.Windows.Forms.TextBox();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.modificaButton = new System.Windows.Forms.Button();
            this.strgeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produse";
            // 
            // produseDataGridView
            // 
            this.produseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseDataGridView.Location = new System.Drawing.Point(12, 47);
            this.produseDataGridView.Name = "produseDataGridView";
            this.produseDataGridView.RowHeadersWidth = 51;
            this.produseDataGridView.RowTemplate.Height = 29;
            this.produseDataGridView.Size = new System.Drawing.Size(457, 370);
            this.produseDataGridView.TabIndex = 1;
            this.produseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produseDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descriere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantitate";
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Location = new System.Drawing.Point(559, 47);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(229, 27);
            this.denumireTextBox.TabIndex = 5;
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.Location = new System.Drawing.Point(559, 209);
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(229, 27);
            this.cantitateTextBox.TabIndex = 6;
            // 
            // descriereTextBox
            // 
            this.descriereTextBox.Location = new System.Drawing.Point(559, 80);
            this.descriereTextBox.Multiline = true;
            this.descriereTextBox.Name = "descriereTextBox";
            this.descriereTextBox.Size = new System.Drawing.Size(229, 123);
            this.descriereTextBox.TabIndex = 7;
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(694, 254);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(94, 29);
            this.adaugaButton.TabIndex = 8;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // modificaButton
            // 
            this.modificaButton.Location = new System.Drawing.Point(559, 254);
            this.modificaButton.Name = "modificaButton";
            this.modificaButton.Size = new System.Drawing.Size(94, 29);
            this.modificaButton.TabIndex = 9;
            this.modificaButton.Text = "Modifica";
            this.modificaButton.UseVisualStyleBackColor = true;
            this.modificaButton.Click += new System.EventHandler(this.modificaButton_Click);
            // 
            // strgeButton
            // 
            this.strgeButton.Location = new System.Drawing.Point(497, 388);
            this.strgeButton.Name = "strgeButton";
            this.strgeButton.Size = new System.Drawing.Size(94, 29);
            this.strgeButton.TabIndex = 10;
            this.strgeButton.Text = "Sterge";
            this.strgeButton.UseVisualStyleBackColor = true;
            this.strgeButton.Click += new System.EventHandler(this.strgeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(625, 299);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 29);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.strgeButton);
            this.Controls.Add(this.modificaButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.descriereTextBox);
            this.Controls.Add(this.cantitateTextBox);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.produseDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView produseDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.TextBox cantitateTextBox;
        private System.Windows.Forms.TextBox descriereTextBox;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button modificaButton;
        private System.Windows.Forms.Button strgeButton;
        private System.Windows.Forms.Button clearButton;
    }
}