using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAmatoGimnasio
{
    public partial class frmInscripcion : Form
    {
        //Constantes
        const decimal PRECIO_MUSCULACION = 15000;
        const decimal PRECIO_FUNCIONAL = 18000;
        const decimal PRECIO_NATACION = 22000;
        const decimal PRECIO_CASILLERO = 3000;
        const int EDAD_MINIMA = 14;
        const decimal DESCUENTO_MENOR = 0.25m;
        const decimal DESCUENTO_MAYOR = 0.30m;
        const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        const decimal DESCUENTO_EFECTIVO = 0.10m;
        const decimal RECARGO_3_CUOTAS = 0.10m;
        const decimal RECARGO_6_CUOTAS = 0.20m;
        const decimal SUBTOTAL = 0;


        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            //Limpiar los campos y establecer valores predeterminados
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkEstudiante.Checked = false;
            chkAdicional.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            //Invocar Método
            EstadoInicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Invocar Método    
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variables
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            //Variables para el cálculo
            decimal precioMensual = 0;
            decimal subtotal = 0;
            decimal porcentajeDescuento = 0;
            decimal porcentajeAjuste = 0;
            decimal total = 0;
            decimal valorCuota = 0;

            //Mostrar mensaje de error si la edad es menor a 14 años o si la cantidad de meses es menor a 1 o mayor a 12
            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.");
                return;
            }

            //Mostrar mensaje de error si la cantidad de meses es menor a 1 o mayor a 12
            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.");
                return;
            }

            string plan = cboPlan.Text;
            switch(plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Seleccione un plan válido.");
                    return;
            }   

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo números y tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo letras, espacio y tecla de retroceso
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }

            //Cambiar minusculas a mayúsculas
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo números y tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //Desactivar el botón Calcular si los campos están vacíos
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
    }
}
