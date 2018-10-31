namespace EVM
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBoxScheme = new System.Windows.Forms.PictureBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.buttonDNF = new System.Windows.Forms.Button();
			this.buttonKNF = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScheme)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxScheme
			// 
			this.pictureBoxScheme.Location = new System.Drawing.Point(13, 81);
			this.pictureBoxScheme.Name = "pictureBoxScheme";
			this.pictureBoxScheme.Size = new System.Drawing.Size(192, 277);
			this.pictureBoxScheme.TabIndex = 13;
			this.pictureBoxScheme.TabStop = false;
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(13, 13);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(206, 20);
			this.textBox.TabIndex = 14;
			// 
			// buttonDNF
			// 
			this.buttonDNF.Location = new System.Drawing.Point(13, 39);
			this.buttonDNF.Name = "buttonDNF";
			this.buttonDNF.Size = new System.Drawing.Size(100, 23);
			this.buttonDNF.TabIndex = 15;
			this.buttonDNF.Text = "ДНФ";
			this.buttonDNF.UseVisualStyleBackColor = true;
			this.buttonDNF.Click += new System.EventHandler(this.buttonDNF_Click);
			// 
			// buttonKNF
			// 
			this.buttonKNF.Location = new System.Drawing.Point(119, 39);
			this.buttonKNF.Name = "buttonKNF";
			this.buttonKNF.Size = new System.Drawing.Size(100, 23);
			this.buttonKNF.TabIndex = 16;
			this.buttonKNF.Text = "КНФ";
			this.buttonKNF.UseVisualStyleBackColor = true;
			this.buttonKNF.Click += new System.EventHandler(this.buttonKNF_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 370);
			this.Controls.Add(this.buttonKNF);
			this.Controls.Add(this.buttonDNF);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.pictureBoxScheme);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScheme)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxScheme;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button buttonDNF;
		private System.Windows.Forms.Button buttonKNF;
	}
}

