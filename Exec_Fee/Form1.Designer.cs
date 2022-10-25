namespace Exec_Fee
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.custumorIntro = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.resultIntro = new System.Windows.Forms.Label();
			this.lblFee = new System.Windows.Forms.Label();
			this.lblReason = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.rdoM = new System.Windows.Forms.RadioButton();
			this.rdoF = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.resultReason = new System.Windows.Forms.Label();
			this.resultFee = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// custumorIntro
			// 
			this.custumorIntro.AutoSize = true;
			this.custumorIntro.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.custumorIntro.Location = new System.Drawing.Point(27, 24);
			this.custumorIntro.Name = "custumorIntro";
			this.custumorIntro.Size = new System.Drawing.Size(73, 20);
			this.custumorIntro.TabIndex = 0;
			this.custumorIntro.Text = "客戶資訊";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAge.Location = new System.Drawing.Point(40, 63);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(45, 20);
			this.lblAge.TabIndex = 0;
			this.lblAge.Text = "年齡:";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGender.Location = new System.Drawing.Point(284, 63);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(45, 20);
			this.lblGender.TabIndex = 0;
			this.lblGender.Text = "性別:";
			// 
			// resultIntro
			// 
			this.resultIntro.AutoSize = true;
			this.resultIntro.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultIntro.Location = new System.Drawing.Point(27, 160);
			this.resultIntro.Name = "resultIntro";
			this.resultIntro.Size = new System.Drawing.Size(73, 20);
			this.resultIntro.TabIndex = 0;
			this.resultIntro.Text = "計算結果";
			// 
			// lblFee
			// 
			this.lblFee.AutoSize = true;
			this.lblFee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblFee.Location = new System.Drawing.Point(40, 210);
			this.lblFee.Name = "lblFee";
			this.lblFee.Size = new System.Drawing.Size(45, 20);
			this.lblFee.TabIndex = 0;
			this.lblFee.Text = "車資:";
			// 
			// lblReason
			// 
			this.lblReason.AutoSize = true;
			this.lblReason.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblReason.Location = new System.Drawing.Point(40, 243);
			this.lblReason.Name = "lblReason";
			this.lblReason.Size = new System.Drawing.Size(45, 20);
			this.lblReason.TabIndex = 0;
			this.lblReason.Text = "原因:";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCalculate.Location = new System.Drawing.Point(101, 107);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 1;
			this.btnCalculate.Text = "Go!";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// rdoM
			// 
			this.rdoM.AutoSize = true;
			this.rdoM.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rdoM.Location = new System.Drawing.Point(335, 64);
			this.rdoM.Name = "rdoM";
			this.rdoM.Size = new System.Drawing.Size(39, 21);
			this.rdoM.TabIndex = 2;
			this.rdoM.TabStop = true;
			this.rdoM.Text = "男";
			this.rdoM.UseVisualStyleBackColor = true;
			// 
			// rdoF
			// 
			this.rdoF.AutoSize = true;
			this.rdoF.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rdoF.Location = new System.Drawing.Point(397, 63);
			this.rdoF.Name = "rdoF";
			this.rdoF.Size = new System.Drawing.Size(39, 21);
			this.rdoF.TabIndex = 3;
			this.rdoF.TabStop = true;
			this.rdoF.Text = "女";
			this.rdoF.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(101, 63);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 4;
			// 
			// resultReason
			// 
			this.resultReason.AutoSize = true;
			this.resultReason.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultReason.Location = new System.Drawing.Point(109, 243);
			this.resultReason.Name = "resultReason";
			this.resultReason.Size = new System.Drawing.Size(36, 20);
			this.resultReason.TabIndex = 0;
			this.resultReason.Text = "123";
			// 
			// resultFee
			// 
			this.resultFee.AutoSize = true;
			this.resultFee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultFee.Location = new System.Drawing.Point(109, 210);
			this.resultFee.Name = "resultFee";
			this.resultFee.Size = new System.Drawing.Size(18, 20);
			this.resultFee.TabIndex = 0;
			this.resultFee.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 323);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.rdoF);
			this.Controls.Add(this.rdoM);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.resultFee);
			this.Controls.Add(this.resultReason);
			this.Controls.Add(this.lblReason);
			this.Controls.Add(this.lblFee);
			this.Controls.Add(this.resultIntro);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.custumorIntro);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label custumorIntro;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label resultIntro;
		private System.Windows.Forms.Label lblFee;
		private System.Windows.Forms.Label lblReason;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.RadioButton rdoM;
		private System.Windows.Forms.RadioButton rdoF;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label resultReason;
		private System.Windows.Forms.Label resultFee;
	}
}

