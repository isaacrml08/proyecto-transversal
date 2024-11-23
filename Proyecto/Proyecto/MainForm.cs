/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 14/11/2024
 * Time: 07:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
        void BtnCalcularClick(object sender, EventArgs e)
		{
            // Variables de entrada obtenidas desde el formulario
            double area = Convert.ToDouble(txtArea.Text);
            int numeroPersonas = Convert.ToInt32(txtNumeroPersonas.Text);

            // Calculo del costo total
            double totalCosto = CalcularCostoTotal(area, numeroPersonas);

            // Mostrar resultado en el formulario
            lblResultado.Text = "Costo total: $" + totalCosto.ToString("F2");
        }
		
		private double CalcularCostoTotal(double area, int numeroPersonas)
        {
			// Incializamos variables
			double costoAserrin = Convert.ToDouble(txtAserrin.Text);
        	double costoPintura = Convert.ToDouble(txtPintura.Text);
        	double costoFrutosSecos = Convert.ToDouble(txtFrutosSecos.Text);
        	double costoFlores = Convert.ToDouble(txtFlores.Text);
        	double costoAgua = Convert.ToDouble(txtAgua.Text);
        	double costoAlimentos = Convert.ToDouble(txtAlimentos.Text);
        	double costoTiempoDiseno = Convert.ToDouble(txtTiempoDiseno.Text);
        	double costoManoObra = Convert.ToDouble(txtManoObra.Text);
            // Cálculo del costo total considerando todos los elementos
            double total = (area * costoAserrin) + (area * costoPintura) + 
                           (area * costoFrutosSecos) + (area * costoFlores) +
                           (area * costoAgua) + (numeroPersonas * costoAlimentos) +
                           costoTiempoDiseno + (numeroPersonas * costoManoObra);

            return total;
        }
	}
}
