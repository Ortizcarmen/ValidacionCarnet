namespace ValidacionCarnet
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_qr = new System.Windows.Forms.Button();
            this.textBox_nuevoCarnet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_carnet = new System.Windows.Forms.TextBox();
            this.button_agregarDigito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nueva Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "CODIGO QR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(420, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_qr);
            this.panel2.Controls.Add(this.textBox_nuevoCarnet);
            this.panel2.Location = new System.Drawing.Point(29, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 159);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo Carnet(con digito de validación):";
            // 
            // button_qr
            // 
            this.button_qr.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_qr.Location = new System.Drawing.Point(70, 104);
            this.button_qr.Margin = new System.Windows.Forms.Padding(5);
            this.button_qr.Name = "button_qr";
            this.button_qr.Size = new System.Drawing.Size(250, 31);
            this.button_qr.TabIndex = 4;
            this.button_qr.Text = "Obtener codigo QR";
            this.button_qr.UseVisualStyleBackColor = true;
            this.button_qr.Click += new System.EventHandler(this.button_qr_Click);
            // 
            // textBox_nuevoCarnet
            // 
            this.textBox_nuevoCarnet.Location = new System.Drawing.Point(70, 57);
            this.textBox_nuevoCarnet.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_nuevoCarnet.Name = "textBox_nuevoCarnet";
            this.textBox_nuevoCarnet.ReadOnly = true;
            this.textBox_nuevoCarnet.Size = new System.Drawing.Size(250, 20);
            this.textBox_nuevoCarnet.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_carnet);
            this.panel1.Controls.Add(this.button_agregarDigito);
            this.panel1.Location = new System.Drawing.Point(29, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 169);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el carnet del estudiante:";
            // 
            // textBox_carnet
            // 
            this.textBox_carnet.Location = new System.Drawing.Point(70, 60);
            this.textBox_carnet.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_carnet.Name = "textBox_carnet";
            this.textBox_carnet.Size = new System.Drawing.Size(250, 20);
            this.textBox_carnet.TabIndex = 0;
            this.textBox_carnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carnet_KeyPress);
            // 
            // button_agregarDigito
            // 
            this.button_agregarDigito.Font = new System.Drawing.Font("Eras Demi ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregarDigito.Location = new System.Drawing.Point(70, 107);
            this.button_agregarDigito.Margin = new System.Windows.Forms.Padding(5);
            this.button_agregarDigito.Name = "button_agregarDigito";
            this.button_agregarDigito.Size = new System.Drawing.Size(250, 31);
            this.button_agregarDigito.TabIndex = 1;
            this.button_agregarDigito.Text = "Agregar digito de validación";
            this.button_agregarDigito.UseVisualStyleBackColor = true;
            this.button_agregarDigito.Click += new System.EventHandler(this.button_agregarDigito_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ValidacionCarnet.Properties.Resources.edificio_ingenieria_desenfocado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_qr;
        private System.Windows.Forms.TextBox textBox_nuevoCarnet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_carnet;
        private System.Windows.Forms.Button button_agregarDigito;
    }
}