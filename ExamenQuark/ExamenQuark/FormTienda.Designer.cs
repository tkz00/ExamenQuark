
namespace ExamenQuark
{
    partial class FormTienda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.gbxPrenda = new System.Windows.Forms.GroupBox();
            this.cboMao = new System.Windows.Forms.CheckBox();
            this.cboChupin = new System.Windows.Forms.CheckBox();
            this.cboMangaCorta = new System.Windows.Forms.CheckBox();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.gbxCalidad = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxPrenda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxCalidad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.lblNombreTienda.Location = new System.Drawing.Point(12, 98);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(159, 25);
            this.lblNombreTienda.TabIndex = 1;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.lblDireccionTienda.Location = new System.Drawing.Point(258, 98);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(357, 25);
            this.lblDireccionTienda.TabIndex = 2;
            this.lblDireccionTienda.Text = "Dirección Tienda";
            this.lblDireccionTienda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVendedor.Location = new System.Drawing.Point(14, 141);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(299, 16);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Nombre y Apellido Vendedor | Código Vendedor";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHistorial.Location = new System.Drawing.Point(478, 141);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(137, 16);
            this.lblHistorial.TabIndex = 4;
            this.lblHistorial.Text = "Historial Cotizaciones";
            this.lblHistorial.Click += new System.EventHandler(this.lblHistorial_Click);
            this.lblHistorial.MouseEnter += new System.EventHandler(this.lblHistorial_MouseEnter);
            this.lblHistorial.MouseLeave += new System.EventHandler(this.lblHistorial_MouseLeave);
            // 
            // gbxPrenda
            // 
            this.gbxPrenda.BackColor = System.Drawing.SystemColors.Control;
            this.gbxPrenda.Controls.Add(this.cboMao);
            this.gbxPrenda.Controls.Add(this.cboChupin);
            this.gbxPrenda.Controls.Add(this.cboMangaCorta);
            this.gbxPrenda.Controls.Add(this.rbPantalon);
            this.gbxPrenda.Controls.Add(this.rbCamisa);
            this.gbxPrenda.Controls.Add(this.label2);
            this.gbxPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPrenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxPrenda.Location = new System.Drawing.Point(17, 184);
            this.gbxPrenda.Name = "gbxPrenda";
            this.gbxPrenda.Size = new System.Drawing.Size(598, 160);
            this.gbxPrenda.TabIndex = 5;
            this.gbxPrenda.TabStop = false;
            this.gbxPrenda.Text = "Prenda";
            // 
            // cboMao
            // 
            this.cboMao.AutoSize = true;
            this.cboMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMao.Location = new System.Drawing.Point(429, 34);
            this.cboMao.Name = "cboMao";
            this.cboMao.Size = new System.Drawing.Size(125, 28);
            this.cboMao.TabIndex = 5;
            this.cboMao.Text = "Cuello mao";
            this.cboMao.UseVisualStyleBackColor = true;
            this.cboMao.CheckedChanged += new System.EventHandler(this.GetStock_Handler);
            // 
            // cboChupin
            // 
            this.cboChupin.AutoSize = true;
            this.cboChupin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChupin.Location = new System.Drawing.Point(241, 106);
            this.cboChupin.Name = "cboChupin";
            this.cboChupin.Size = new System.Drawing.Size(90, 28);
            this.cboChupin.TabIndex = 4;
            this.cboChupin.Text = "Chupín";
            this.cboChupin.UseVisualStyleBackColor = true;
            this.cboChupin.CheckedChanged += new System.EventHandler(this.GetStock_Handler);
            // 
            // cboMangaCorta
            // 
            this.cboMangaCorta.AutoSize = true;
            this.cboMangaCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMangaCorta.Location = new System.Drawing.Point(241, 34);
            this.cboMangaCorta.Name = "cboMangaCorta";
            this.cboMangaCorta.Size = new System.Drawing.Size(133, 28);
            this.cboMangaCorta.TabIndex = 3;
            this.cboMangaCorta.Text = "Manga corta";
            this.cboMangaCorta.UseVisualStyleBackColor = true;
            this.cboMangaCorta.CheckedChanged += new System.EventHandler(this.GetStock_Handler);
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPantalon.Location = new System.Drawing.Point(24, 106);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(101, 28);
            this.rbPantalon.TabIndex = 2;
            this.rbPantalon.TabStop = true;
            this.rbPantalon.Text = "Pantalón";
            this.rbPantalon.UseVisualStyleBackColor = true;
            this.rbPantalon.CheckedChanged += new System.EventHandler(this.GetStock_Handler);
            this.rbPantalon.Click += new System.EventHandler(this.rbPantalon_CheckedChanged);
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCamisa.Location = new System.Drawing.Point(24, 33);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(90, 28);
            this.rbCamisa.TabIndex = 1;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            this.rbCamisa.CheckedChanged += new System.EventHandler(this.GetStock_Handler);
            this.rbCamisa.Click += new System.EventHandler(this.rbCamisa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 2);
            this.label2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(629, 2);
            this.label6.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Location = new System.Drawing.Point(17, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(7, 20);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(306, 24);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Unidades de stock disponibles: ___";
            // 
            // gbxCalidad
            // 
            this.gbxCalidad.Controls.Add(this.rbPremium);
            this.gbxCalidad.Controls.Add(this.rbStandard);
            this.gbxCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCalidad.Location = new System.Drawing.Point(17, 436);
            this.gbxCalidad.Name = "gbxCalidad";
            this.gbxCalidad.Size = new System.Drawing.Size(285, 66);
            this.gbxCalidad.TabIndex = 7;
            this.gbxCalidad.TabStop = false;
            this.gbxCalidad.Text = "Calidad de Prenda";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(154, 28);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(86, 22);
            this.rbPremium.TabIndex = 1;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            this.rbPremium.CheckedChanged += new System.EventHandler(this.GetStock_Handler);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(24, 28);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(85, 22);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.GetStock_Handler);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(327, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 66);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio unitario y Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(196, 24);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(78, 29);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "$";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(32, 24);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(78, 29);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.Text = "100";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(45)))), ((int)(((byte)(177)))));
            this.btnCotizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.White;
            this.btnCotizar.Location = new System.Drawing.Point(84, 549);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(159, 47);
            this.btnCotizar.TabIndex = 9;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(98)))), ((int)(((byte)(220)))));
            this.lblResultado.Location = new System.Drawing.Point(322, 561);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(263, 25);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "$                                  ";
            // 
            // FormTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 625);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxCalidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxPrenda);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTienda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxPrenda.ResumeLayout(false);
            this.gbxPrenda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxCalidad.ResumeLayout(false);
            this.gbxCalidad.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.GroupBox gbxPrenda;
        private System.Windows.Forms.CheckBox cboMao;
        private System.Windows.Forms.CheckBox cboChupin;
        private System.Windows.Forms.CheckBox cboMangaCorta;
        private System.Windows.Forms.RadioButton rbPantalon;
        private System.Windows.Forms.RadioButton rbCamisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox gbxCalidad;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label lblResultado;
    }
}

