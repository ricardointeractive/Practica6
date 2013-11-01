/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 31/10/2013
 * Time: 07:09 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica6
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
			this.nomAlu = new System.Windows.Forms.Label();
			this.nombre = new System.Windows.Forms.TextBox();
			this.codAlum = new System.Windows.Forms.Label();
			this.codigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.DF = new System.Windows.Forms.RadioButton();
			this.gdl = new System.Windows.Forms.RadioButton();
			this.mty = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.port = new System.Windows.Forms.CheckBox();
			this.chil = new System.Windows.Forms.CheckBox();
			this.UK = new System.Windows.Forms.CheckBox();
			this.mcd = new System.Windows.Forms.CheckBox();
			this.aust = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.estados = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.fecha = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.estados)).BeginInit();
			this.SuspendLayout();
			// 
			// nomAlu
			// 
			this.nomAlu.Location = new System.Drawing.Point(28, 21);
			this.nomAlu.Name = "nomAlu";
			this.nomAlu.Size = new System.Drawing.Size(100, 23);
			this.nomAlu.TabIndex = 0;
			this.nomAlu.Text = "Nombre:";
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(97, 18);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(100, 20);
			this.nombre.TabIndex = 1;
			// 
			// codAlum
			// 
			this.codAlum.Location = new System.Drawing.Point(28, 44);
			this.codAlum.Name = "codAlum";
			this.codAlum.Size = new System.Drawing.Size(100, 23);
			this.codAlum.TabIndex = 2;
			this.codAlum.Text = "Codigo:";
			// 
			// codigo
			// 
			this.codigo.Location = new System.Drawing.Point(97, 47);
			this.codigo.Name = "codigo";
			this.codigo.Size = new System.Drawing.Size(100, 20);
			this.codigo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(73, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "1.- Capital de Mexico:";
			// 
			// DF
			// 
			this.DF.Location = new System.Drawing.Point(28, 105);
			this.DF.Name = "DF";
			this.DF.Size = new System.Drawing.Size(52, 24);
			this.DF.TabIndex = 5;
			this.DF.TabStop = true;
			this.DF.Text = "D.F.";
			this.DF.UseVisualStyleBackColor = true;
			// 
			// gdl
			// 
			this.gdl.Location = new System.Drawing.Point(84, 110);
			this.gdl.Name = "gdl";
			this.gdl.Size = new System.Drawing.Size(81, 15);
			this.gdl.TabIndex = 6;
			this.gdl.TabStop = true;
			this.gdl.Text = "Guadalajara";
			this.gdl.UseVisualStyleBackColor = true;
			// 
			// mty
			// 
			this.mty.Location = new System.Drawing.Point(159, 110);
			this.mty.Name = "mty";
			this.mty.Size = new System.Drawing.Size(84, 20);
			this.mty.TabIndex = 7;
			this.mty.TabStop = true;
			this.mty.Text = "Monterrey";
			this.mty.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(73, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "2-Paises de Europa:";
			// 
			// port
			// 
			this.port.Location = new System.Drawing.Point(56, 173);
			this.port.Name = "port";
			this.port.Size = new System.Drawing.Size(104, 24);
			this.port.TabIndex = 9;
			this.port.Text = "Portugal.";
			this.port.UseVisualStyleBackColor = true;
			// 
			// chil
			// 
			this.chil.Location = new System.Drawing.Point(56, 194);
			this.chil.Name = "chil";
			this.chil.Size = new System.Drawing.Size(104, 26);
			this.chil.TabIndex = 10;
			this.chil.Text = "Chile.";
			this.chil.UseVisualStyleBackColor = true;
			// 
			// UK
			// 
			this.UK.Location = new System.Drawing.Point(56, 217);
			this.UK.Name = "UK";
			this.UK.Size = new System.Drawing.Size(104, 15);
			this.UK.TabIndex = 11;
			this.UK.Text = "Reino Unido.";
			this.UK.UseVisualStyleBackColor = true;
			// 
			// mcd
			// 
			this.mcd.Location = new System.Drawing.Point(56, 238);
			this.mcd.Name = "mcd";
			this.mcd.Size = new System.Drawing.Size(104, 15);
			this.mcd.TabIndex = 12;
			this.mcd.Text = "Macedonia.";
			this.mcd.UseVisualStyleBackColor = true;
			// 
			// aust
			// 
			this.aust.Location = new System.Drawing.Point(56, 259);
			this.aust.Name = "aust";
			this.aust.Size = new System.Drawing.Size(104, 24);
			this.aust.TabIndex = 13;
			this.aust.Text = "Australia.";
			this.aust.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(306, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "3.-Cantidad de estados que se compone México:";
			// 
			// estados
			// 
			this.estados.Location = new System.Drawing.Point(320, 52);
			this.estados.Name = "estados";
			this.estados.Size = new System.Drawing.Size(120, 20);
			this.estados.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(272, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(255, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "4.-Dia en que termino la seguunda guerra mundial:";
			// 
			// fecha
			// 
			this.fecha.Location = new System.Drawing.Point(272, 100);
			this.fecha.Name = "fecha";
			this.fecha.TabIndex = 17;
			this.fecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.FechaDateChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(364, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "TERMINAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 328);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.fecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.estados);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.aust);
			this.Controls.Add(this.mcd);
			this.Controls.Add(this.UK);
			this.Controls.Add(this.chil);
			this.Controls.Add(this.port);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mty);
			this.Controls.Add(this.gdl);
			this.Controls.Add(this.DF);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.codigo);
			this.Controls.Add(this.codAlum);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.nomAlu);
			this.Name = "MainForm";
			this.Text = "Practica6";
			((System.ComponentModel.ISupportInitialize)(this.estados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar fecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown estados;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox aust;
		private System.Windows.Forms.CheckBox mcd;
		private System.Windows.Forms.CheckBox UK;
		private System.Windows.Forms.CheckBox chil;
		private System.Windows.Forms.CheckBox port;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton mty;
		private System.Windows.Forms.RadioButton gdl;
		private System.Windows.Forms.RadioButton DF;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox codigo;
		private System.Windows.Forms.Label codAlum;
		private System.Windows.Forms.TextBox nombre;
		private System.Windows.Forms.Label nomAlu;
	}
}
