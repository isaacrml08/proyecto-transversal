/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 14/11/2024
 * Time: 07:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtNumeroPersonas = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAserrin = new System.Windows.Forms.TextBox();
			this.txtPintura = new System.Windows.Forms.TextBox();
			this.txtFrutosSecos = new System.Windows.Forms.TextBox();
			this.txtFlores = new System.Windows.Forms.TextBox();
			this.txtAlimentos = new System.Windows.Forms.TextBox();
			this.txtAgua = new System.Windows.Forms.TextBox();
			this.txtTiempoDiseno = new System.Windows.Forms.TextBox();
			this.txtManoObra = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(108, 423);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(172, 42);
			this.btnCalcular.TabIndex = 0;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(197, 47);
			this.txtArea.Margin = new System.Windows.Forms.Padding(4);
			this.txtArea.Multiline = true;
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(171, 27);
			this.txtArea.TabIndex = 1;
			// 
			// txtNumeroPersonas
			// 
			this.txtNumeroPersonas.Location = new System.Drawing.Point(197, 82);
			this.txtNumeroPersonas.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumeroPersonas.Multiline = true;
			this.txtNumeroPersonas.Name = "txtNumeroPersonas";
			this.txtNumeroPersonas.Size = new System.Drawing.Size(171, 25);
			this.txtNumeroPersonas.TabIndex = 2;
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(32, 489);
			this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(320, 50);
			this.lblResultado.TabIndex = 3;
			this.lblResultado.Text = "Costo total: $";
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Area en m2:";
			// 
			// txtAserrin
			// 
			this.txtAserrin.Location = new System.Drawing.Point(197, 131);
			this.txtAserrin.Margin = new System.Windows.Forms.Padding(4);
			this.txtAserrin.Multiline = true;
			this.txtAserrin.Name = "txtAserrin";
			this.txtAserrin.Size = new System.Drawing.Size(171, 25);
			this.txtAserrin.TabIndex = 5;
			// 
			// txtPintura
			// 
			this.txtPintura.Location = new System.Drawing.Point(197, 164);
			this.txtPintura.Margin = new System.Windows.Forms.Padding(4);
			this.txtPintura.Multiline = true;
			this.txtPintura.Name = "txtPintura";
			this.txtPintura.Size = new System.Drawing.Size(171, 25);
			this.txtPintura.TabIndex = 6;
			// 
			// txtFrutosSecos
			// 
			this.txtFrutosSecos.Location = new System.Drawing.Point(197, 197);
			this.txtFrutosSecos.Margin = new System.Windows.Forms.Padding(4);
			this.txtFrutosSecos.Multiline = true;
			this.txtFrutosSecos.Name = "txtFrutosSecos";
			this.txtFrutosSecos.Size = new System.Drawing.Size(171, 25);
			this.txtFrutosSecos.TabIndex = 7;
			// 
			// txtFlores
			// 
			this.txtFlores.Location = new System.Drawing.Point(197, 231);
			this.txtFlores.Margin = new System.Windows.Forms.Padding(4);
			this.txtFlores.Multiline = true;
			this.txtFlores.Name = "txtFlores";
			this.txtFlores.Size = new System.Drawing.Size(171, 25);
			this.txtFlores.TabIndex = 8;
			// 
			// txtAlimentos
			// 
			this.txtAlimentos.Location = new System.Drawing.Point(197, 266);
			this.txtAlimentos.Margin = new System.Windows.Forms.Padding(4);
			this.txtAlimentos.Multiline = true;
			this.txtAlimentos.Name = "txtAlimentos";
			this.txtAlimentos.Size = new System.Drawing.Size(171, 25);
			this.txtAlimentos.TabIndex = 9;
			// 
			// txtAgua
			// 
			this.txtAgua.Location = new System.Drawing.Point(197, 299);
			this.txtAgua.Margin = new System.Windows.Forms.Padding(4);
			this.txtAgua.Multiline = true;
			this.txtAgua.Name = "txtAgua";
			this.txtAgua.Size = new System.Drawing.Size(171, 25);
			this.txtAgua.TabIndex = 10;
			// 
			// txtTiempoDiseno
			// 
			this.txtTiempoDiseno.Location = new System.Drawing.Point(197, 332);
			this.txtTiempoDiseno.Margin = new System.Windows.Forms.Padding(4);
			this.txtTiempoDiseno.Multiline = true;
			this.txtTiempoDiseno.Name = "txtTiempoDiseno";
			this.txtTiempoDiseno.Size = new System.Drawing.Size(171, 25);
			this.txtTiempoDiseno.TabIndex = 11;
			// 
			// txtManoObra
			// 
			this.txtManoObra.Location = new System.Drawing.Point(197, 365);
			this.txtManoObra.Margin = new System.Windows.Forms.Padding(4);
			this.txtManoObra.Multiline = true;
			this.txtManoObra.Name = "txtManoObra";
			this.txtManoObra.Size = new System.Drawing.Size(171, 25);
			this.txtManoObra.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 76);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 24);
			this.label2.TabIndex = 13;
			this.label2.Text = "Personas:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 133);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 24);
			this.label3.TabIndex = 14;
			this.label3.Text = "KG de Aserrin:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 166);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 24);
			this.label4.TabIndex = 15;
			this.label4.Text = "Pintura:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 198);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 24);
			this.label5.TabIndex = 16;
			this.label5.Text = "Frutos Secos:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 232);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 24);
			this.label6.TabIndex = 17;
			this.label6.Text = "Flores:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(18, 265);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 24);
			this.label7.TabIndex = 18;
			this.label7.Text = "Alimentos:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(18, 299);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(171, 24);
			this.label8.TabIndex = 19;
			this.label8.Text = "Litro de agua:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(18, 332);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(178, 24);
			this.label9.TabIndex = 20;
			this.label9.Text = "Hora de Diseño:";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(18, 365);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(161, 24);
			this.label10.TabIndex = 21;
			this.label10.Text = "Mano de Obra:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 548);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtManoObra);
			this.Controls.Add(this.txtTiempoDiseno);
			this.Controls.Add(this.txtAgua);
			this.Controls.Add(this.txtAlimentos);
			this.Controls.Add(this.txtFlores);
			this.Controls.Add(this.txtFrutosSecos);
			this.Controls.Add(this.txtPintura);
			this.Controls.Add(this.txtAserrin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtNumeroPersonas);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.btnCalcular);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Proyecto";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtManoObra;
		private System.Windows.Forms.TextBox txtTiempoDiseno;
		private System.Windows.Forms.TextBox txtAgua;
		private System.Windows.Forms.TextBox txtAlimentos;
		private System.Windows.Forms.TextBox txtFlores;
		private System.Windows.Forms.TextBox txtFrutosSecos;
		private System.Windows.Forms.TextBox txtPintura;
		private System.Windows.Forms.TextBox txtAserrin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumeroPersonas;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Button btnCalcular;
	}
}
