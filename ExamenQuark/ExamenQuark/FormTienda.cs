using ExamenQuark.Controladores;
using ExamenQuark.Modelo;
using ExamenQuark.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenQuark
{
    public partial class FormTienda : Form
    {
        internal Tienda Tienda;
        public FormTienda()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Se carga el formulario, creo los datos hardcodeados, Tienda, Vendedor y las prendas de la tienda, asigno los valores visuales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.rbCamisa.Click += new System.EventHandler(this.GetStock_Handler);
            this.rbPantalon.Click += new System.EventHandler(this.GetStock_Handler);

            Vendedor vendedor = new Vendedor("Theo", "Katz", 109015);

            TiendaController tiendaController = new TiendaController();

            //Acá se llama a una función que crea una lista de prendas, pero idealmente estas deberían ser cargadas previamente por un usuario del programa.
            List<Prenda> prendas = tiendaController.HardcodePrendas();

            Tienda tienda = new Tienda("Armando Lío", "Amenabar 322", prendas);
            tienda += vendedor;

            this.Tienda = tienda;

            this.lblNombreTienda.Text = tienda.Nombre;
            this.lblDireccionTienda.Text = tienda.Direccion;
            this.lblVendedor.Text = vendedor.ToString();
        }

        /// <summary>
        /// El botón de cotizar crea los cotizadores que necesita, captura los valores necesarios y llama a crear una cotización, al igual que agregarla al historial del vendedor, restar el stock y mostrar el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                CotizacionController cotizacionController = new CotizacionController();
                Vendedor vendedor = this.Tienda.Vendedores.FirstOrDefault(x => x.Codigo == Int32.Parse(this.lblVendedor.Text.Substring(this.lblVendedor.Text.LastIndexOf('|') + 1)));

                Prenda prenda = this.CreatePrenda(this.txtPrecio.Text, this.txtCantidad.Text);

                Cotizacion newCotizacion = cotizacionController.CreateCotizacion(vendedor, prenda);

                TiendaController tiendaController = new TiendaController();

                this.Tienda = tiendaController.RestarStock(this.Tienda, newCotizacion);

                vendedor.AgregarCotizacion(newCotizacion);

                this.lblResultado.Text = newCotizacion.PrecioFinal.ToString("c2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que llama al PrendaController para crear una prenda, ya sea pantalón o camisa.
        /// </summary>
        /// <param name="Precio"></param>
        /// <param name="Cantidad"></param>
        /// <returns></returns>
        private Prenda CreatePrenda(string Precio, string Cantidad)
        {
            Prenda aux = null;

            try
            {
                PrendaController prendaController = new PrendaController();

                if (this.rbPantalon.Checked)
                {
                    aux = prendaController.CreatePrenda(this.rbStandard.Checked, Precio, Cantidad, this.cboChupin.Checked);
                }
                else
                {
                    aux = prendaController.CreatePrenda(this.rbStandard.Checked, Precio, Cantidad, !this.cboMangaCorta.Checked, this.cboMao.Checked);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aux;
        }

        /// <summary>
        /// Evento de click del label de historial, captura al vendedor del programa, y a través de un CotizacionesController las muestra en un MessageBox, si no tiene ninguna lo avisa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblHistorial_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = this.Tienda.Vendedores.FirstOrDefault(x => x.Codigo == Int32.Parse(this.lblVendedor.Text.Substring(this.lblVendedor.Text.LastIndexOf('|') + 1)));
            if (vendedor.Cotizaciones.Count > 0)
            {
                List<Cotizacion> cotizaciones = vendedor.Cotizaciones;
                CotizacionController cotizacionController = new CotizacionController();

                MessageBox.Show(cotizacionController.MostrarCotizaciones(cotizaciones), "Historial Cotizaciones");
            }
            else
            {
                MessageBox.Show("El vendedor todavía no tiene cotizaciones.", "Historial Cotizaciones");
            }
        }

        /// <summary>
        /// Se deshabilitan las opciones que no están relacionadas con Camisa y se habilitan las que sí.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            this.cboMangaCorta.Enabled = true;
            this.cboMao.Enabled = true;
            this.cboChupin.Enabled = false;
        }

        /// <summary>
        /// Se deshabilitan las opciones que no están relacionadas con Pantalón y se habilitan las que sí.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            this.cboMangaCorta.Enabled = false;
            this.cboMao.Enabled = false;
            this.cboChupin.Enabled = true;
        }

        /// <summary>
        /// Handler que se usa para llamar al metodo que muestra el stock en tiempo real cuando se hace un cambio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetStock_Handler(object sender, EventArgs e)
        {
            this.GetStock();
        }

        /// <summary>
        /// Metodo que captura y muestra el stock disponible en el formulario.
        /// </summary>
        private void GetStock()
        {
            Prenda prenda = this.CreatePrenda("1", "1");

            TiendaController controller = new TiendaController();

            this.lblStock.Text = "Unidades de stock disponibles: " + controller.GetStock(prenda, this.Tienda.Prendas);
        }

        /// <summary>
        /// Efecto visual para subrayar el label del historial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblHistorial_MouseEnter(object sender, EventArgs e)
        {
            this.lblHistorial.Font = new Font(this.lblHistorial.Font.Name, this.lblHistorial.Font.SizeInPoints, FontStyle.Underline);
            this.lblHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        /// <summary>
        /// Efecto visual para subrayar el label del historial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblHistorial_MouseLeave(object sender, EventArgs e)
        {
            this.lblHistorial.Font = new Font(this.lblHistorial.Font.Name, this.lblHistorial.Font.SizeInPoints, FontStyle.Regular);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }
    }
}
