
namespace Taschenrechner
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtZahl1 = new System.Windows.Forms.TextBox();
			this.rBtnPlus = new System.Windows.Forms.RadioButton();
			this.rBtnMinus = new System.Windows.Forms.RadioButton();
			this.rBtnMal = new System.Windows.Forms.RadioButton();
			this.rBtnGeteilt = new System.Windows.Forms.RadioButton();
			this.txtZahl2 = new System.Windows.Forms.TextBox();
			this.btnLöschen = new System.Windows.Forms.Button();
			this.btnErgebnis = new System.Windows.Forms.Button();
			this.btnAns = new System.Windows.Forms.Button();
			this.lstVerlauf = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblFehler = new System.Windows.Forms.Label();
			this.lblSumme = new System.Windows.Forms.Label();
			this.lblMittelwert = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtZahl1
			// 
			this.txtZahl1.Location = new System.Drawing.Point(12, 46);
			this.txtZahl1.Name = "txtZahl1";
			this.txtZahl1.Size = new System.Drawing.Size(100, 20);
			this.txtZahl1.TabIndex = 0;
			this.txtZahl1.Enter += new System.EventHandler(this.FehlermeldungRücksetzen);
			// 
			// rBtnPlus
			// 
			this.rBtnPlus.AutoSize = true;
			this.rBtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtnPlus.Location = new System.Drawing.Point(152, 12);
			this.rBtnPlus.Name = "rBtnPlus";
			this.rBtnPlus.Size = new System.Drawing.Size(34, 20);
			this.rBtnPlus.TabIndex = 1;
			this.rBtnPlus.TabStop = true;
			this.rBtnPlus.Text = "+";
			this.rBtnPlus.UseVisualStyleBackColor = true;
			this.rBtnPlus.Enter += new System.EventHandler(this.FehlermeldungRücksetzen);
			// 
			// rBtnMinus
			// 
			this.rBtnMinus.AutoSize = true;
			this.rBtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtnMinus.Location = new System.Drawing.Point(152, 36);
			this.rBtnMinus.Name = "rBtnMinus";
			this.rBtnMinus.Size = new System.Drawing.Size(31, 20);
			this.rBtnMinus.TabIndex = 2;
			this.rBtnMinus.TabStop = true;
			this.rBtnMinus.Text = "-";
			this.rBtnMinus.UseVisualStyleBackColor = true;
			this.rBtnMinus.Enter += new System.EventHandler(this.FehlermeldungRücksetzen);
			// 
			// rBtnMal
			// 
			this.rBtnMal.AutoSize = true;
			this.rBtnMal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtnMal.Location = new System.Drawing.Point(152, 60);
			this.rBtnMal.Name = "rBtnMal";
			this.rBtnMal.Size = new System.Drawing.Size(32, 20);
			this.rBtnMal.TabIndex = 3;
			this.rBtnMal.TabStop = true;
			this.rBtnMal.Text = "*";
			this.rBtnMal.UseVisualStyleBackColor = true;
			this.rBtnMal.Enter += new System.EventHandler(this.FehlermeldungRücksetzen);
			// 
			// rBtnGeteilt
			// 
			this.rBtnGeteilt.AutoSize = true;
			this.rBtnGeteilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBtnGeteilt.Location = new System.Drawing.Point(152, 84);
			this.rBtnGeteilt.Name = "rBtnGeteilt";
			this.rBtnGeteilt.Size = new System.Drawing.Size(31, 20);
			this.rBtnGeteilt.TabIndex = 4;
			this.rBtnGeteilt.TabStop = true;
			this.rBtnGeteilt.Text = "/";
			this.rBtnGeteilt.UseVisualStyleBackColor = true;
			this.rBtnGeteilt.Enter += new System.EventHandler(this.FehlermeldungRücksetzen);
			// 
			// txtZahl2
			// 
			this.txtZahl2.Location = new System.Drawing.Point(238, 46);
			this.txtZahl2.Name = "txtZahl2";
			this.txtZahl2.Size = new System.Drawing.Size(100, 20);
			this.txtZahl2.TabIndex = 5;
			this.txtZahl2.Enter += new System.EventHandler(this.FehlermeldungRücksetzen);
			this.txtZahl2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZahl2_KeyDown);
			// 
			// btnLöschen
			// 
			this.btnLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLöschen.Location = new System.Drawing.Point(47, 131);
			this.btnLöschen.Name = "btnLöschen";
			this.btnLöschen.Size = new System.Drawing.Size(75, 34);
			this.btnLöschen.TabIndex = 6;
			this.btnLöschen.Text = "DEL";
			this.btnLöschen.UseVisualStyleBackColor = true;
			this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
			// 
			// btnErgebnis
			// 
			this.btnErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnErgebnis.Location = new System.Drawing.Point(129, 131);
			this.btnErgebnis.Name = "btnErgebnis";
			this.btnErgebnis.Size = new System.Drawing.Size(75, 34);
			this.btnErgebnis.TabIndex = 7;
			this.btnErgebnis.Text = "=";
			this.btnErgebnis.UseVisualStyleBackColor = true;
			this.btnErgebnis.Click += new System.EventHandler(this.btnErgebnis_Click);
			// 
			// btnAns
			// 
			this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAns.Location = new System.Drawing.Point(211, 131);
			this.btnAns.Name = "btnAns";
			this.btnAns.Size = new System.Drawing.Size(75, 34);
			this.btnAns.TabIndex = 8;
			this.btnAns.Text = "Ans";
			this.btnAns.UseVisualStyleBackColor = true;
			this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
			// 
			// lstVerlauf
			// 
			this.lstVerlauf.FormattingEnabled = true;
			this.lstVerlauf.Location = new System.Drawing.Point(354, 38);
			this.lstVerlauf.Name = "lstVerlauf";
			this.lstVerlauf.Size = new System.Drawing.Size(284, 368);
			this.lstVerlauf.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(354, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Verlauf";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFehler
			// 
			this.lblFehler.AutoSize = true;
			this.lblFehler.Location = new System.Drawing.Point(13, 184);
			this.lblFehler.Name = "lblFehler";
			this.lblFehler.Size = new System.Drawing.Size(35, 13);
			this.lblFehler.TabIndex = 11;
			this.lblFehler.Text = "label2";
			// 
			// lblSumme
			// 
			this.lblSumme.AutoSize = true;
			this.lblSumme.Location = new System.Drawing.Point(354, 413);
			this.lblSumme.Name = "lblSumme";
			this.lblSumme.Size = new System.Drawing.Size(35, 13);
			this.lblSumme.TabIndex = 12;
			this.lblSumme.Text = "label2";
			// 
			// lblMittelwert
			// 
			this.lblMittelwert.AutoSize = true;
			this.lblMittelwert.Location = new System.Drawing.Point(508, 413);
			this.lblMittelwert.Name = "lblMittelwert";
			this.lblMittelwert.Size = new System.Drawing.Size(35, 13);
			this.lblMittelwert.TabIndex = 13;
			this.lblMittelwert.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 450);
			this.Controls.Add(this.lblMittelwert);
			this.Controls.Add(this.lblSumme);
			this.Controls.Add(this.lblFehler);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstVerlauf);
			this.Controls.Add(this.btnAns);
			this.Controls.Add(this.btnErgebnis);
			this.Controls.Add(this.btnLöschen);
			this.Controls.Add(this.txtZahl2);
			this.Controls.Add(this.rBtnGeteilt);
			this.Controls.Add(this.rBtnMal);
			this.Controls.Add(this.rBtnMinus);
			this.Controls.Add(this.rBtnPlus);
			this.Controls.Add(this.txtZahl1);
			this.Name = "Form1";
			this.Text = "Taschenrechner";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtZahl1;
		private System.Windows.Forms.RadioButton rBtnPlus;
		private System.Windows.Forms.RadioButton rBtnMinus;
		private System.Windows.Forms.RadioButton rBtnMal;
		private System.Windows.Forms.RadioButton rBtnGeteilt;
		private System.Windows.Forms.TextBox txtZahl2;
		private System.Windows.Forms.Button btnLöschen;
		private System.Windows.Forms.Button btnErgebnis;
		private System.Windows.Forms.Button btnAns;
		private System.Windows.Forms.ListBox lstVerlauf;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFehler;
		private System.Windows.Forms.Label lblSumme;
		private System.Windows.Forms.Label lblMittelwert;
	}
}

