using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtedad.TextChanged += validarEdad;
            //tbTelefono.TextChanged += validarTelefono;
            txttelefono.Leave += validarTelefono;
            txtnombre.TextChanged += validarNombre;
            txtapellidos.TextChanged += validarApellidos;
            txtestatura.TextChanged += validarEstatura;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombres = txtnombre.Text;
            string apellidos = txtapellidos.Text;
            string edad = txtedad.Text;
            string estatura = txtestatura.Text;
            string telefono = txttelefono.Text;
            string genero = " ";
            if (rbhombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbmujer.Checked)
            {
                genero = "Mujer";
            }
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValido10Digitos(telefono) && EsTextoValido(nombres) && EsTextoValido(apellidos))
            {
                //Aqui invovar validación
                string datos = $"Nombres: {nombres}\r\nApellidos:{apellidos}\r\nEdad: {edad}\r\n" +
                    $"Estatura: {estatura}\r\nTelefono: {telefono}\r\nGenero: {genero}";
                string rutaArchivo = "C:/Users/sebas/Downloads/practica005.txt";
                // Verificar si el archivo ya existe
                bool archivoExiste = File.Exists(rutaArchivo);
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        // Si el archivo existe, añadir un separador antes del nuevo registro
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
                // Mostrar un mensaje con los datos capturados
                MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algunos de los valores esta mal", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValido10Digitos(string valor)
        {
            //long resultado;
            //return long.TryParse(valor, out resultado) && valor.Length == 10;
            return valor.Length == 10 && valor.All(char.IsDigit) && long.TryParse(valor, out _);
            //string formato = @"^\d{10}$";
            //return Regex.IsMatch(valor, formato);
        }
        private bool EsTextoValido(string valor)
        {
            //string formato = @"^[a-zA-Z\s]+$";
            //return Regex.IsMatch(valor, formato);
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsEnteroValido(textbox.Text))
            {
                MessageBox.Show("Ingrese una edad validad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
                MessageBox.Show("Ingrese una estatura validad", "Error estatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Length == 10 && EsEnteroValido10Digitos(textbox.Text))
            {
                textbox.BackColor = Color.Green;
            }
            else
            {
                textbox.BackColor = Color.Red;
                MessageBox.Show("Ingrese un telefono de 10 digitos", "Error telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textbox.Clear();
            }

        }
        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Ingrese una Apellido valido", "Error apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Ingrese una nombre valido", "Error nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellidos.Clear();
            txtapellidos.Clear();
            txtedad.Clear();
            txtestatura.Clear();
            rbhombre.Checked = false;
            rbmujer.Checked = false;
        }

        private void Edad_Click(object sender, EventArgs e)
        {

        }
    }
    
}
