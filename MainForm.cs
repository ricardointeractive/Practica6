/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 31/10/2013
 * Time: 07:09 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica6
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int aciertos=0;
				
			if(this.DF.Checked){
				aciertos++;
			}
			if(this.port.Checked){
				aciertos++;
			}
			if(this.UK.Checked){
				aciertos++;
			}
			if(this.mcd.Checked){
				aciertos++;
			}
			if(this.estados.Text=="32"){
				aciertos++;
			}
			DateTime fec=fecha.SelectionStart;
			if(fec.ToShortDateString()=="07/05/1945"){
				aciertos++;
			}
			MessageBox.Show("Codigo:"+codigo.Text+"\nNombre: "+nombre.Text+"\nAciertos "+aciertos);
		}
	}
}
