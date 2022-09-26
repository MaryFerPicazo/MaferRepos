namespace Practica_manejo_de_datos_a_partir_de_archivos_de_texto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_list = new System.Windows.Forms.RadioButton();
            this.rb_grid = new System.Windows.Forms.RadioButton();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rb_list);
            this.panel1.Controls.Add(this.rb_grid);
            this.panel1.Location = new System.Drawing.Point(23, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 55);
            this.panel1.TabIndex = 1;
            // 
            // rb_list
            // 
            this.rb_list.AutoSize = true;
            this.rb_list.Location = new System.Drawing.Point(18, 29);
            this.rb_list.Name = "rb_list";
            this.rb_list.Size = new System.Drawing.Size(77, 20);
            this.rb_list.TabIndex = 2;
            this.rb_list.TabStop = true;
            this.rb_list.Text = "ListView";
            this.rb_list.UseVisualStyleBackColor = true;
            // 
            // rb_grid
            // 
            this.rb_grid.AutoSize = true;
            this.rb_grid.Location = new System.Drawing.Point(18, 3);
            this.rb_grid.Name = "rb_grid";
            this.rb_grid.Size = new System.Drawing.Size(109, 20);
            this.rb_grid.TabIndex = 1;
            this.rb_grid.TabStop = true;
            this.rb_grid.Text = "DataGridview";
            this.rb_grid.UseVisualStyleBackColor = true;
            this.rb_grid.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.Location = new System.Drawing.Point(233, 100);
            this.txt_Consulta.Multiline = true;
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.Size = new System.Drawing.Size(971, 233);
            this.txt_Consulta.TabIndex = 2;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.BackgroundImage")));
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.Location = new System.Drawing.Point(189, 57);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(59, 21);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 218);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(236, 371);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(982, 218);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(97)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 631);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Consulta);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Practica Acceso a Datos en Grids";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_list;
        private System.Windows.Forms.RadioButton rb_grid;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
    }
}

