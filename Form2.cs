using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ValidacionCarnet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_agregarDigito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_carnet.Text))
            {
                MessageBox.Show("Debe ingresar un carnet antes de agregar el dígito de validación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Entradas del carnet
            int carnet, x;
            //Almacenar el carnet original en una variable int
            carnet = Convert.ToInt32(textBox_carnet.Text);
            if ((carnet >= 202000000) && (carnet <= 202499999))
            {
                //Convertir la variable anterior en un array
                var carnetArray = carnet.ToString().Select(t => int.Parse(t.ToString())).ToArray();
                //Array del vectorCarnet basado en ISBN10
                int[] vectorCarnet = new int[10];
                vectorCarnet[0] = 10;
                vectorCarnet[1] = 9;
                vectorCarnet[2] = 8;
                vectorCarnet[3] = 7;
                vectorCarnet[4] = 6;
                vectorCarnet[5] = 5;
                vectorCarnet[6] = 4;
                vectorCarnet[7] = 3;
                vectorCarnet[8] = 2;
                vectorCarnet[9] = 1;

                //Proceso ISBN10
                int total, suma = 0, modulo, resultado;

                for (int contador = 0; contador < 9; contador++)
                {
                    total = carnetArray[contador] * vectorCarnet[contador];
                    suma = suma + total;
                }
                modulo = suma % 11;
                resultado = 11 - modulo;
                //Imprimir el numero oculto en un nuevo textbox
                string nuevoCarnet;
                nuevoCarnet = Convert.ToString(carnet) + Convert.ToString(resultado);
                if (nuevoCarnet.Length > 0)
                {
                    char[] nuevoCarnetArray = nuevoCarnet.ToCharArray();
                    nuevoCarnetArray[nuevoCarnetArray.Length - 1] = 'x'; // Reemplaza el último carácter con 'x'
                    nuevoCarnet = new string(nuevoCarnetArray);
                }
                textBox_nuevoCarnet.Text = nuevoCarnet;
            }
            else if (carnet > 202499999)
            {
                MessageBox.Show("Debe de ingresar un carnet entre los ciclos escolares 2020-2024", "Error! Carnet invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_carnet.Text = "";
                textBox_carnet.Select();
            }
            /*else if (carnet != Int32)
             {
                 MessageBox.Show("Debe de ingresar caracteres numericos", "Error! Carnet invalido");
                 textBox_carnet.Text = "";
                 textBox_carnet.Select();
             }*/
            else
            {
                MessageBox.Show("Debe de ingresar un carnet entre los ciclos escolares 2009-2023", "Error! Carnet invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_carnet.Text = "";
                textBox_carnet.Select();
            }
        }

        private void button_qr_Click(object sender, EventArgs e)
        {
            /*Form form_codigoQR = new Form2_codigoQR();
            form_codigoQR.Show();*/

            string carpetaDestino = @"C:\Users\50236\Downloads\proyecto algebra\ValidacionCarnet\QRS\";

            // Contenido del código QR
            string contenido = textBox_nuevoCarnet.Text;

            // Generar el código QR
            QRCodeGenerator qrGenerador = new QRCodeGenerator();
            QRCodeData qrDatos = qrGenerador.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
            QRCode qrCodigo = new QRCode(qrDatos);

            // Crear la imagen del código QR
            Bitmap qrImagen = qrCodigo.GetGraphic(5, Color.Black, Color.White, true);

            // Nombre del archivo con el nombre del nuevo carnet
            string nombreArchivo = $"{contenido}.png"; // Utiliza el contenido como nombre de archivo
            string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

            // Guardar la imagen en la carpeta destino
            qrImagen.Save(rutaCompleta, ImageFormat.Png);

            // Mostrar la imagen en el pictureBox
            pictureBox1.Image = qrImagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_carnet.Text = "";
            textBox_nuevoCarnet.Text = "";
            pictureBox1.Image = null;
            textBox_carnet.Select();
        }

        private void textBox_carnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe de ingresar unicamente numeros", "Error! Carácteres invalidos...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
