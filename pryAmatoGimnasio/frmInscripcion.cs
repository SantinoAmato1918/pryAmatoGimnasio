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
        // Son valores que no cambian mientras se ejecuta el programa.
        // Se declaran con la palabra const y se escriben en mayúsculas
        // para identificarlas mas facil. Al ser plata o porcentajes
        // usamos decimal, mientras que EDAD_MINIMA es int porque es un número entero
        // La "m" indica que el número es decimal
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


        //El struct sirve para agrupar en una sola estructura los datos
        // de una misma persona (nombre, edad, plan, total)
        struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formaPago;
            public decimal total;
            public decimal valorCuota;
        }
        //Declara array de 1 dimension
        string[] vecSocio = new string[3];

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            //EstadoInicial es un método que usamos para dejar el formulario
            //siempre en su estado inicial. Se llama cuando se abre el formulario y
            //también cuando apretamos Limpiar. De esta manera no repetimos el mismo
            //código en diferentes eventos
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
            //El Evento Load del formulario se ejecuta automáticamente cuando se abre
            //el formulario. Acá llamamos al método EstadoInicial() para que todos
            //los controles queden configurados con el estado inicial que pusimos arriba
            EstadoInicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Para Edad y Meses usamos int.Parse porque el TextBox
            //devuelve texto tipo string, pero necesitamos convertirlo a número entero tipo int
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            //Variables para el cálculo
            //Son decimal porque representan plata o porcentajes
            //Se inicializan en 0 porque todavía no tienen un valor calculado
            decimal precioMensual = 0;
            decimal subtotal = 0;
            decimal porcentajeDescuento = 0;
            decimal porcentajeAjuste = 0;
            decimal total = 0;
            decimal valorCuota = 0;

            //Mostrar mensaje de error si la edad es menor a 14 años
            //Si la edad es menor que la constante EDAD_MINIMA
            //se muestra un mensaje de error y se usa return para detener
            //el método y evitar que el programa continúe con el cálculo
            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.");
                return;
            }

            //Mostrar mensaje de error si la cantidad de meses es menor a 1 o mayor a 12
            //Verificamos que los meses no sean menores que 1 NI mayores que 12
            // || significa "O": alcanza con que una de las dos condiciones sea verdadera
            //para que se ejecute el if. Si está fuera del rango return detiene el cálculo
            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.");
                return;
            }
            //Guardamos en una variable string el texto que está seleccionado en cboPlan.
            //string se usa porque el nombre del plan es un texto
            string plan = cboPlan.Text;
            //switch compara el valor de una variable con diferentes opciones
            //break termina los case y sale del switch para seguir con el código siguiente
            switch (plan)
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
                //default se ejecuta si ninguno de los case de antes coincide
                //con el valor de la variable plan
                default:
                    MessageBox.Show("Seleccione un plan válido.");
                    //return termina el método porque no podemos seguir
                    //con el cálculo si el plan no es ninguno de los 3
                    return;
            }
            //Guardamos en una variable string el horario del turno elegido
            //Se inicializa vacío porque todavía no conocemos el turno
            string horario = "";
            //SelectedIndex va a decir la posición del elemento seleccionado en el ComboBox
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "7 a 12";
                    break;

                case 1:
                    horario = "14 a 18";
                    break;

                case 2:
                    horario = "18 a 23";
                    break;

                default:
                    MessageBox.Show("Seleccione un turno válido.");
                    return;
            }
            // += significa "sumar a la variable y guardar el nuevo resultado".
            if (chkAdicional.Checked) precioMensual += PRECIO_CASILLERO;
            subtotal = precioMensual * meses;

            if (edad < 18)
            {
                porcentajeDescuento = DESCUENTO_MENOR;
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = DESCUENTO_MAYOR;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        porcentajeDescuento = DESCUENTO_ESTUDIANTE;
                    }
                    else
                    {
                        porcentajeDescuento = 0;
                    }
                }
            }
            subtotal = subtotal - (subtotal * porcentajeDescuento);


            int cuotas = 0;

            if (rbtEfectivo.Checked)
            {
                //El - es para que sea un descuento
                porcentajeAjuste = -DESCUENTO_EFECTIVO;
            }
            else
            {
                //Esto va adentro porque si es en efectivo va a intentar convertir algo vacio y puede tirar error
                cuotas = int.Parse(cboCuotas.Text);

                if (cuotas == 1)
                {
                    porcentajeAjuste = 0;
                }
                else if (cuotas == 3)
                {
                    porcentajeAjuste = RECARGO_3_CUOTAS;
                }
                else if (cuotas == 6)
                {
                    porcentajeAjuste = RECARGO_6_CUOTAS;
                }
            }
            total = subtotal + (subtotal * porcentajeAjuste);

            //Operador ternario
            string categoria = edad < 18 ? "Menor" : "Mayor";
            string formaPago = rbtEfectivo.Checked
                ? "Efectivo"
                : "Tarjeta en " + cuotas + " cuotas";

            //Aca si es efectivo, el valor de la cuota es el total
            //y si es tarjeta el total se divide por la cantidad de cuotas
            valorCuota = rbtEfectivo.Checked ? total : total / cuotas;

            SOCIO socio;
            socio.nombre = nombre;
            socio.edad = edad;
            socio.categoria = categoria;
            socio.plan = plan;
            socio.horario = horario;
            socio.meses = meses;
            socio.formaPago = formaPago;
            socio.total = total;
            socio.valorCuota = valorCuota;

            // Armar mensaje con todos los datos del socio
            // \n es un salto de línea.
            string mensaje =
                "DATOS DEL SOCIO\n\n" +
                "Nombre: " + socio.nombre + "\n" +
                "Edad: " + socio.edad + " años\n" +
                "Categoría: " + socio.categoria + "\n" +
                "Plan: " + socio.plan + "\n" +
                "Horario: " + socio.horario + "\n" +
                "Meses: " + socio.meses + "\n" +
                "Forma de pago: " + socio.formaPago + "\n" +
                //ToString("C2") convierte los valores a texto y los muestra con formato
                //de moneda y dos decimales
                "Total: " + socio.total.ToString("C2") + "\n" +
                "Valor de cuota: " + socio.valorCuota.ToString("C2");

            //Grabar array
            //Concatenar lo que tengo en el struct
            //El indice tiene que incrementarse con cada click
            //y tiene tope, 3 elementos (no permitir grabar mas)
            vecSocio[0] = socio.nombre;


            //Grabar en un txt
            StreamWriter swDatosGimnasio = new StreamWriter("BaseDatos.txt", true);
            swDatosGimnasio.WriteLine(socio.nombre);

            swDatosGimnasio.WriteLine(socio.plan);
            swDatosGimnasio.WriteLine(socio.valorCuota);
            swDatosGimnasio.WriteLine(socio.total);

            swDatosGimnasio.Close();

            // Mostrar el mensaje con título e ícono de información.
            MessageBox.Show(mensaje, "Datos del Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EstadoInicial();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo números y tecla de retroceso
            //e.KeyChar es el carácter de la tecla que se presiona
            //char.IsDigit() verifica si ese carácter es un dígito
            //El signo ! significa "NO", o sea que !char.IsDigit() significa "no es un número"
            //Keys.Back es la tecla de retroceso
            //Si la tecla no es un número Y tampoco es Backspace, se bloquea
            // && Significa "Y". O sea que Las dos condiciones tienen que cumplirse
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                //Handled indica que nosotros ya manejamos esa tecla
                //Si ponemos true la tecla se descarta y no aparece en el TextBox
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo letras, espacio y tecla de retroceso
            //e.KeyChar != ' ' comprueba que la tecla presionada
            //sea diferente de un espacio. ' ' es un espacio como un carácter
            //Lo usamos para permitir escribir nombres compuestos
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

            //Cambiar minusculas a mayúsculas
            //Si es minúscula, char.ToUpper() la convierte a mayúscula
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
            //Comprobamos que los tres campos necesarios para calcular tengan contenido
            // != "" significa "distinto de vacío"
            // && significa "Y", por lo que las tres condiciones deben cumplirse
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                // SelectedIndex = 0 selecciona la primera opción del ComboBox
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                // SelectedIndex = -1 significa que no queda ninguna opción seleccionada
                cboCuotas.SelectedIndex = -1;
            }
        }




    }
}
