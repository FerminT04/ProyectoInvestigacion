using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoInvestigacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double i, centinela = 1, acumulador = 0, sueldo, total = 0;
            if (String.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("No puede dejar vacío el campo o nulo", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            i = Convert.ToDouble(txtEmpleados.Text);
            try
            {

                while (centinela <= i)
                {
                sueldo =  Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Sueldo del empleado: " + centinela, "Boleta de Pagos"));
 //validamos que no se ingrese un sueldo en blanco

                    validarNegativo(sueldo, centinela);
                    //Validamos que el sueldo a ingresar debe estar en el rango solicitado
                    while (sueldo <= 300 || sueldo >= 500)
                    {
                       sueldo = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("El sueldo debe ser mayor a $300 y menor a $500, Ingrese el Sueldo del empleado: " + centinela, "Boleta de Pagos"));
                     }
                    total = total + sueldo;
                    acumulador++;
                    centinela++;
                } // fin del While
                txtCantidad.Text = acumulador.ToString();
                txtSueldo.Text = total.ToString();
            }//fin de Try
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error, posiblemente ingreso un dato Null. Intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            private void txtEmpleados_TextChanged(object sender, EventArgs e)
            {

            }
    }
}
