using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos_de_Acceso_Directo
{
    public partial class Form1 : Form
    {
        // Ruta del archivo de acceso directo
        private const string filePath = "randomAccessFile.bin";

        // Tamaño del registro
        private const int recordSize = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = (int)numIndex.Value;
            string text = txtInput.Text;

            // Crear array de tamaño fijo para el registro
            byte[] data = new byte[recordSize];
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);

            // Copiar texto en el array y rellenar con ceros si es necesario
            Array.Copy(textBytes, data, Math.Min(recordSize, textBytes.Length));

            using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                // Posicionar el puntero
                stream.Seek(index * recordSize, SeekOrigin.Begin);

                // Escribir datos
                stream.Write(data, 0, recordSize);
            }

            txtInput.Clear(); // Limpiar TextBox
            lblOutput.Text = $"Text written at index {index}.";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = (int)numIndex.Value;

            if (File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // Posicionar el puntero
                    stream.Seek(index * recordSize, SeekOrigin.Begin);

                    byte[] data = new byte[recordSize];
                    stream.Read(data, 0, recordSize);

                    string text = System.Text.Encoding.UTF8.GetString(data).Trim('\0');
                    lblOutput.Text = $"Read from index {index}: {text}";
                }
            }
            else
            {
                lblOutput.Text = "File does not exist.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = (int)numIndex.Value;

            if (File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Write))
                {
                    // Posicionar el puntero
                    stream.Seek(index * recordSize, SeekOrigin.Begin);

                    // Escribir ceros para eliminar
                    byte[] emptyData = new byte[recordSize];
                    stream.Write(emptyData, 0, recordSize);

                    lblOutput.Text = $"Deleted at index {index}.";
                }
            }
            else
            {
                lblOutput.Text = "File does not exist.";
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int currentIndex = 0;
                    byte[] data = new byte[recordSize];
                    string content = "";

                    while (stream.Read(data, 0, recordSize) > 0)
                    {
                        string text = System.Text.Encoding.UTF8.GetString(data).Trim('\0');

                        content += $"Index {currentIndex}: {text}\n";
                        currentIndex++;
                    }

                    lblOutput.Text = "All file content:\n" + content;
                }
            }
            else
            {
                lblOutput.Text = "File does not exist.";
            }
        }
    }
}
