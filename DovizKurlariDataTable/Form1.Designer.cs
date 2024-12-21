namespace DovizKurlariDataTable
{
    partial class Form1
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
            this.dgv_kurlar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.lbl_yapar = new System.Windows.Forms.Label();
            this.tb_neKadar = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_secilen1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_neKadar1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_yapar1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kurlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kurlar
            // 
            this.dgv_kurlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kurlar.Location = new System.Drawing.Point(17, 16);
            this.dgv_kurlar.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_kurlar.Name = "dgv_kurlar";
            this.dgv_kurlar.RowHeadersWidth = 51;
            this.dgv_kurlar.Size = new System.Drawing.Size(681, 897);
            this.dgv_kurlar.TabIndex = 0;
            this.dgv_kurlar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_kurlar_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(919, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çevir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ne kadar?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "TL yapar";
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.Location = new System.Drawing.Point(959, 73);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(0, 16);
            this.lbl_secilen.TabIndex = 4;
            // 
            // lbl_yapar
            // 
            this.lbl_yapar.AutoSize = true;
            this.lbl_yapar.Location = new System.Drawing.Point(768, 126);
            this.lbl_yapar.Name = "lbl_yapar";
            this.lbl_yapar.Size = new System.Drawing.Size(0, 16);
            this.lbl_yapar.TabIndex = 3;
            // 
            // tb_neKadar
            // 
            this.tb_neKadar.Location = new System.Drawing.Point(750, 70);
            this.tb_neKadar.Mask = "00000";
            this.tb_neKadar.Name = "tb_neKadar";
            this.tb_neKadar.Size = new System.Drawing.Size(189, 22);
            this.tb_neKadar.TabIndex = 5;
            this.tb_neKadar.ValidatingType = typeof(int);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(929, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Çevir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ne kadar?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(982, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "yapar";
            // 
            // lbl_secilen1
            // 
            this.lbl_secilen1.AutoSize = true;
            this.lbl_secilen1.Location = new System.Drawing.Point(827, 342);
            this.lbl_secilen1.Name = "lbl_secilen1";
            this.lbl_secilen1.Size = new System.Drawing.Size(0, 16);
            this.lbl_secilen1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(959, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "TL";
            // 
            // tb_neKadar1
            // 
            this.tb_neKadar1.Location = new System.Drawing.Point(760, 286);
            this.tb_neKadar1.Mask = "00000";
            this.tb_neKadar1.Name = "tb_neKadar1";
            this.tb_neKadar1.Size = new System.Drawing.Size(189, 22);
            this.tb_neKadar1.TabIndex = 5;
            this.tb_neKadar1.ValidatingType = typeof(int);
            // 
            // lbl_yapar1
            // 
            this.lbl_yapar1.AutoSize = true;
            this.lbl_yapar1.Location = new System.Drawing.Point(768, 342);
            this.lbl_yapar1.Name = "lbl_yapar1";
            this.lbl_yapar1.Size = new System.Drawing.Size(0, 16);
            this.lbl_yapar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 554);
            this.Controls.Add(this.tb_neKadar1);
            this.Controls.Add(this.tb_neKadar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_secilen);
            this.Controls.Add(this.lbl_yapar1);
            this.Controls.Add(this.lbl_secilen1);
            this.Controls.Add(this.lbl_yapar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_kurlar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Doviz Kurlari";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kurlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kurlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_secilen;
        private System.Windows.Forms.Label lbl_yapar;
        private System.Windows.Forms.MaskedTextBox tb_neKadar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_secilen1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tb_neKadar1;
        private System.Windows.Forms.Label lbl_yapar1;
    }
}

