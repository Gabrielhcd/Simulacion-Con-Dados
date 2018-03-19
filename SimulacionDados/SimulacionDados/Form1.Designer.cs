namespace SimulacionDados
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnlanzar = new System.Windows.Forms.Button();
			this.txtlanzamientos = new System.Windows.Forms.TextBox();
			this.btnlanzar100 = new System.Windows.Forms.Button();
			this.btn2x100 = new System.Windows.Forms.Button();
			this.btn1p1x100 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnlanzar
			// 
			this.btnlanzar.Location = new System.Drawing.Point(13, 13);
			this.btnlanzar.Name = "btnlanzar";
			this.btnlanzar.Size = new System.Drawing.Size(92, 28);
			this.btnlanzar.TabIndex = 0;
			this.btnlanzar.Text = "Lanzar";
			this.btnlanzar.UseVisualStyleBackColor = true;
			this.btnlanzar.Click += new System.EventHandler(this.btnlanzar_Click);
			// 
			// txtlanzamientos
			// 
			this.txtlanzamientos.Location = new System.Drawing.Point(13, 66);
			this.txtlanzamientos.Multiline = true;
			this.txtlanzamientos.Name = "txtlanzamientos";
			this.txtlanzamientos.Size = new System.Drawing.Size(327, 238);
			this.txtlanzamientos.TabIndex = 1;
			// 
			// btnlanzar100
			// 
			this.btnlanzar100.Location = new System.Drawing.Point(228, 13);
			this.btnlanzar100.Name = "btnlanzar100";
			this.btnlanzar100.Size = new System.Drawing.Size(112, 28);
			this.btnlanzar100.TabIndex = 2;
			this.btnlanzar100.Text = "Lanzar 100";
			this.btnlanzar100.UseVisualStyleBackColor = true;
			this.btnlanzar100.Click += new System.EventHandler(this.btnlanzar100_Click);
			// 
			// btn2x100
			// 
			this.btn2x100.Location = new System.Drawing.Point(388, 66);
			this.btn2x100.Name = "btn2x100";
			this.btn2x100.Size = new System.Drawing.Size(136, 36);
			this.btn2x100.TabIndex = 3;
			this.btn2x100.Text = "2 veces 100";
			this.btn2x100.UseVisualStyleBackColor = true;
			this.btn2x100.Click += new System.EventHandler(this.btn2x100_Click);
			// 
			// btn1p1x100
			// 
			this.btn1p1x100.Location = new System.Drawing.Point(388, 185);
			this.btn1p1x100.Name = "btn1p1x100";
			this.btn1p1x100.Size = new System.Drawing.Size(136, 36);
			this.btn1p1x100.TabIndex = 4;
			this.btn1p1x100.Text = "2 dados 100";
			this.btn1p1x100.UseVisualStyleBackColor = true;
			this.btn1p1x100.Click += new System.EventHandler(this.btn1p1x100_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 316);
			this.Controls.Add(this.btn1p1x100);
			this.Controls.Add(this.btn2x100);
			this.Controls.Add(this.btnlanzar100);
			this.Controls.Add(this.txtlanzamientos);
			this.Controls.Add(this.btnlanzar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnlanzar;
		private System.Windows.Forms.TextBox txtlanzamientos;
		private System.Windows.Forms.Button btnlanzar100;
		private System.Windows.Forms.Button btn2x100;
		private System.Windows.Forms.Button btn1p1x100;
	}
}

