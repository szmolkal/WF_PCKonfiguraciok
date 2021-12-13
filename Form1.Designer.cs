
namespace WF_PCKonfiguraciok
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
            this.label_Konfiguracio = new System.Windows.Forms.Label();
            this.label_Oprendszer = new System.Windows.Forms.Label();
            this.label_Tulajdonos = new System.Windows.Forms.Label();
            this.label_Alkatrészek = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton_Gamer = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Konfiguracio
            // 
            this.label_Konfiguracio.AutoSize = true;
            this.label_Konfiguracio.Location = new System.Drawing.Point(12, 12);
            this.label_Konfiguracio.Name = "label_Konfiguracio";
            this.label_Konfiguracio.Size = new System.Drawing.Size(93, 13);
            this.label_Konfiguracio.TabIndex = 0;
            this.label_Konfiguracio.Text = "Konfiguráció neve";
            // 
            // label_Oprendszer
            // 
            this.label_Oprendszer.AutoSize = true;
            this.label_Oprendszer.Location = new System.Drawing.Point(7, 39);
            this.label_Oprendszer.Name = "label_Oprendszer";
            this.label_Oprendszer.Size = new System.Drawing.Size(98, 13);
            this.label_Oprendszer.TabIndex = 1;
            this.label_Oprendszer.Text = "Operációs rendszer";
            // 
            // label_Tulajdonos
            // 
            this.label_Tulajdonos.AutoSize = true;
            this.label_Tulajdonos.Location = new System.Drawing.Point(19, 66);
            this.label_Tulajdonos.Name = "label_Tulajdonos";
            this.label_Tulajdonos.Size = new System.Drawing.Size(86, 13);
            this.label_Tulajdonos.TabIndex = 2;
            this.label_Tulajdonos.Text = "Tulajdonos neve";
            // 
            // label_Alkatrészek
            // 
            this.label_Alkatrészek.AutoSize = true;
            this.label_Alkatrészek.Location = new System.Drawing.Point(43, 120);
            this.label_Alkatrészek.Name = "label_Alkatrészek";
            this.label_Alkatrészek.Size = new System.Drawing.Size(62, 13);
            this.label_Alkatrészek.TabIndex = 4;
            this.label_Alkatrészek.Text = "Alkatrészek";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 7;
            // 
            // radioButton_Gamer
            // 
            this.radioButton_Gamer.AutoSize = true;
            this.radioButton_Gamer.Location = new System.Drawing.Point(117, 91);
            this.radioButton_Gamer.Name = "radioButton_Gamer";
            this.radioButton_Gamer.Size = new System.Drawing.Size(117, 17);
            this.radioButton_Gamer.TabIndex = 8;
            this.radioButton_Gamer.TabStop = true;
            this.radioButton_Gamer.Text = "Gamer konfiguráció";
            this.radioButton_Gamer.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton_Gamer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Alkatrészek);
            this.Controls.Add(this.label_Tulajdonos);
            this.Controls.Add(this.label_Oprendszer);
            this.Controls.Add(this.label_Konfiguracio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Konfiguracio;
        private System.Windows.Forms.Label label_Oprendszer;
        private System.Windows.Forms.Label label_Tulajdonos;
        private System.Windows.Forms.Label label_Alkatrészek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton_Gamer;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

