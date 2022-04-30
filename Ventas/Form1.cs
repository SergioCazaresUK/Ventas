using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void Z_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto memoria = new Producto();
            memoria.Codigo = "KWO1031JW";
            memoria.Descripcion = "Memoria Ram";
            memoria.PrecioUnitario = 700.10m;

            Producto DiscoDuro = new Producto()
            {
                Codigo = "MAOD21",
                Descripcion = "Disco Duro",
                PrecioUnitario = 1234.34m
            };

            List<Producto> productos = new List<Producto>();
            productos.Add(memoria);
            productos.Add(DiscoDuro);

            dgvProducto DataSource = productos;
        }
    }
}
