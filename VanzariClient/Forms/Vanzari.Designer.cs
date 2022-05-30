
namespace VanzariClient
{
    partial class Vanzari
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
            this.produseDataGridView = new System.Windows.Forms.DataGridView();
            this.adaugaCosBtn = new System.Windows.Forms.Button();
            this.comenziDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.trimiteComandaBtn = new System.Windows.Forms.Button();
            this.descriereTextBox = new System.Windows.Forms.TextBox();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.viewComenziBtn = new System.Windows.Forms.Button();
            this.descComadanTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produseDataGridView
            // 
            this.produseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseDataGridView.Location = new System.Drawing.Point(12, 12);
            this.produseDataGridView.Name = "produseDataGridView";
            this.produseDataGridView.RowHeadersWidth = 51;
            this.produseDataGridView.RowTemplate.Height = 29;
            this.produseDataGridView.Size = new System.Drawing.Size(457, 395);
            this.produseDataGridView.TabIndex = 2;
            this.produseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produseDataGridView_CellContentClick);
            // 
            // adaugaCosBtn
            // 
            this.adaugaCosBtn.Location = new System.Drawing.Point(644, 240);
            this.adaugaCosBtn.Name = "adaugaCosBtn";
            this.adaugaCosBtn.Size = new System.Drawing.Size(136, 41);
            this.adaugaCosBtn.TabIndex = 4;
            this.adaugaCosBtn.Text = "Adauga in cos";
            this.adaugaCosBtn.UseVisualStyleBackColor = true;
            this.adaugaCosBtn.Click += new System.EventHandler(this.adaugaCosBtn_Click);
            // 
            // comenziDataGridView
            // 
            this.comenziDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comenziDataGridView.Location = new System.Drawing.Point(786, 29);
            this.comenziDataGridView.Name = "comenziDataGridView";
            this.comenziDataGridView.RowHeadersWidth = 51;
            this.comenziDataGridView.RowTemplate.Height = 29;
            this.comenziDataGridView.Size = new System.Drawing.Size(273, 329);
            this.comenziDataGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(786, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vizualizare cos";
            // 
            // trimiteComandaBtn
            // 
            this.trimiteComandaBtn.Location = new System.Drawing.Point(902, 366);
            this.trimiteComandaBtn.Name = "trimiteComandaBtn";
            this.trimiteComandaBtn.Size = new System.Drawing.Size(157, 41);
            this.trimiteComandaBtn.TabIndex = 8;
            this.trimiteComandaBtn.Text = "Trimite comanda";
            this.trimiteComandaBtn.UseVisualStyleBackColor = true;
            this.trimiteComandaBtn.Click += new System.EventHandler(this.trimiteComandaBtn_Click);
            // 
            // descriereTextBox
            // 
            this.descriereTextBox.Location = new System.Drawing.Point(551, 62);
            this.descriereTextBox.Multiline = true;
            this.descriereTextBox.Name = "descriereTextBox";
            this.descriereTextBox.ReadOnly = true;
            this.descriereTextBox.Size = new System.Drawing.Size(229, 75);
            this.descriereTextBox.TabIndex = 14;
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.Location = new System.Drawing.Point(551, 191);
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(229, 27);
            this.cantitateTextBox.TabIndex = 13;
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Location = new System.Drawing.Point(551, 29);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.ReadOnly = true;
            this.denumireTextBox.Size = new System.Drawing.Size(229, 27);
            this.denumireTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantitate\r\nDorita :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descriere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Denumire";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(673, 311);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 41);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // viewComenziBtn
            // 
            this.viewComenziBtn.Location = new System.Drawing.Point(472, 277);
            this.viewComenziBtn.Name = "viewComenziBtn";
            this.viewComenziBtn.Size = new System.Drawing.Size(107, 54);
            this.viewComenziBtn.TabIndex = 16;
            this.viewComenziBtn.Text = "Vizualizare Comenzi";
            this.viewComenziBtn.UseVisualStyleBackColor = true;
            this.viewComenziBtn.Click += new System.EventHandler(this.viewComenziBtn_Click);
            // 
            // descComadanTextBox
            // 
            this.descComadanTextBox.Location = new System.Drawing.Point(560, 373);
            this.descComadanTextBox.Name = "descComadanTextBox";
            this.descComadanTextBox.Size = new System.Drawing.Size(229, 27);
            this.descComadanTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 60);
            this.label5.TabIndex = 17;
            this.label5.Text = "Introduceti\r\ndescriere\r\nComanda :";
            // 
            // Vanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 418);
            this.Controls.Add(this.descComadanTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viewComenziBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.descriereTextBox);
            this.Controls.Add(this.cantitateTextBox);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trimiteComandaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comenziDataGridView);
            this.Controls.Add(this.adaugaCosBtn);
            this.Controls.Add(this.produseDataGridView);
            this.Name = "Vanzari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanzari";
            this.Load += new System.EventHandler(this.Vanzari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView produseDataGridView;
        private System.Windows.Forms.Button adaugaCosBtn;
        private System.Windows.Forms.DataGridView comenziDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trimiteComandaBtn;
        private System.Windows.Forms.TextBox descriereTextBox;
        private System.Windows.Forms.TextBox cantitateTextBox;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button viewComenziBtn;
        private System.Windows.Forms.TextBox descComadanTextBox;
        private System.Windows.Forms.Label label5;
    }
}