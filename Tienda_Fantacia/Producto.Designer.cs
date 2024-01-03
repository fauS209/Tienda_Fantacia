namespace Tienda_Fantacia
{
    partial class Producto
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
            this.BT_Modificar = new System.Windows.Forms.Button();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBT_Nombre = new System.Windows.Forms.TextBox();
            this.BT_Añadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBT_ID_Producto = new System.Windows.Forms.TextBox();
            this.CB_ID_Productos = new System.Windows.Forms.ComboBox();
            this.V_Oro = new System.Windows.Forms.Label();
            this.TBT_V_Oro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBT_V_Gemas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_Modificar
            // 
            this.BT_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BT_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Modificar.Location = new System.Drawing.Point(353, 397);
            this.BT_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Modificar.Name = "BT_Modificar";
            this.BT_Modificar.Size = new System.Drawing.Size(132, 44);
            this.BT_Modificar.TabIndex = 40;
            this.BT_Modificar.Text = "Modificar";
            this.BT_Modificar.UseVisualStyleBackColor = false;
            this.BT_Modificar.Click += new System.EventHandler(this.BT_Modificar_Click_1);
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BT_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Eliminar.Location = new System.Drawing.Point(277, 449);
            this.BT_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(132, 44);
            this.BT_Eliminar.TabIndex = 39;
            this.BT_Eliminar.Text = "Eliminar";
            this.BT_Eliminar.UseVisualStyleBackColor = false;
            this.BT_Eliminar.Click += new System.EventHandler(this.BT_Eliminar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID Producto";
            // 
            // TBT_Nombre
            // 
            this.TBT_Nombre.Location = new System.Drawing.Point(227, 267);
            this.TBT_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBT_Nombre.Multiline = true;
            this.TBT_Nombre.Name = "TBT_Nombre";
            this.TBT_Nombre.Size = new System.Drawing.Size(227, 26);
            this.TBT_Nombre.TabIndex = 33;
            this.TBT_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Añadir
            // 
            this.BT_Añadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BT_Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Añadir.Location = new System.Drawing.Point(202, 397);
            this.BT_Añadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Añadir.Name = "BT_Añadir";
            this.BT_Añadir.Size = new System.Drawing.Size(132, 44);
            this.BT_Añadir.TabIndex = 31;
            this.BT_Añadir.Text = "Añadir";
            this.BT_Añadir.UseVisualStyleBackColor = false;
            this.BT_Añadir.Click += new System.EventHandler(this.BT_Añadir_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Productos";
            // 
            // TBT_ID_Producto
            // 
            this.TBT_ID_Producto.Location = new System.Drawing.Point(227, 205);
            this.TBT_ID_Producto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBT_ID_Producto.Multiline = true;
            this.TBT_ID_Producto.Name = "TBT_ID_Producto";
            this.TBT_ID_Producto.Size = new System.Drawing.Size(227, 26);
            this.TBT_ID_Producto.TabIndex = 29;
            this.TBT_ID_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_ID_Productos
            // 
            this.CB_ID_Productos.FormattingEnabled = true;
            this.CB_ID_Productos.Location = new System.Drawing.Point(265, 145);
            this.CB_ID_Productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_ID_Productos.Name = "CB_ID_Productos";
            this.CB_ID_Productos.Size = new System.Drawing.Size(143, 21);
            this.CB_ID_Productos.TabIndex = 28;
            this.CB_ID_Productos.SelectedIndexChanged += new System.EventHandler(this.CB_ID_Productos_SelectedIndexChanged_1);
            // 
            // V_Oro
            // 
            this.V_Oro.AutoSize = true;
            this.V_Oro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_Oro.Location = new System.Drawing.Point(424, 306);
            this.V_Oro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.V_Oro.Name = "V_Oro";
            this.V_Oro.Size = new System.Drawing.Size(80, 24);
            this.V_Oro.TabIndex = 42;
            this.V_Oro.Text = "Colones";
            // 
            // TBT_V_Oro
            // 
            this.TBT_V_Oro.Location = new System.Drawing.Point(353, 338);
            this.TBT_V_Oro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBT_V_Oro.Multiline = true;
            this.TBT_V_Oro.Name = "TBT_V_Oro";
            this.TBT_V_Oro.Size = new System.Drawing.Size(227, 26);
            this.TBT_V_Oro.TabIndex = 41;
            this.TBT_V_Oro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dolares";
            // 
            // TBT_V_Gemas
            // 
            this.TBT_V_Gemas.Location = new System.Drawing.Point(108, 338);
            this.TBT_V_Gemas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBT_V_Gemas.Multiline = true;
            this.TBT_V_Gemas.Name = "TBT_V_Gemas";
            this.TBT_V_Gemas.Size = new System.Drawing.Size(227, 26);
            this.TBT_V_Gemas.TabIndex = 43;
            this.TBT_V_Gemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 640);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBT_V_Gemas);
            this.Controls.Add(this.V_Oro);
            this.Controls.Add(this.TBT_V_Oro);
            this.Controls.Add(this.BT_Modificar);
            this.Controls.Add(this.BT_Eliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBT_Nombre);
            this.Controls.Add(this.BT_Añadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBT_ID_Producto);
            this.Controls.Add(this.CB_ID_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Modificar;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBT_Nombre;
        private System.Windows.Forms.Button BT_Añadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBT_ID_Producto;
        private System.Windows.Forms.ComboBox CB_ID_Productos;
        private System.Windows.Forms.Label V_Oro;
        private System.Windows.Forms.TextBox TBT_V_Oro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBT_V_Gemas;
    }
}