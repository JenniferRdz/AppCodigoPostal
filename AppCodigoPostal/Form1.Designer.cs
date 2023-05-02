namespace AppCodigoPostal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardarconOpenxml = new System.Windows.Forms.Button();
            this.btnGuardarconInterop = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAabrir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvDatos
            // 
            this.lstvDatos.HideSelection = false;
            this.lstvDatos.Location = new System.Drawing.Point(2, 66);
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(767, 334);
            this.lstvDatos.TabIndex = 0;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(139, 48);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardarconOpenxml
            // 
            this.btnGuardarconOpenxml.Location = new System.Drawing.Point(325, 12);
            this.btnGuardarconOpenxml.Name = "btnGuardarconOpenxml";
            this.btnGuardarconOpenxml.Size = new System.Drawing.Size(165, 48);
            this.btnGuardarconOpenxml.TabIndex = 2;
            this.btnGuardarconOpenxml.Text = "Guardar con OpenXml";
            this.btnGuardarconOpenxml.UseVisualStyleBackColor = true;
            this.btnGuardarconOpenxml.Click += new System.EventHandler(this.btnGuardarconOpenxml_Click);
            // 
            // btnGuardarconInterop
            // 
            this.btnGuardarconInterop.Location = new System.Drawing.Point(169, 12);
            this.btnGuardarconInterop.Name = "btnGuardarconInterop";
            this.btnGuardarconInterop.Size = new System.Drawing.Size(139, 48);
            this.btnGuardarconInterop.TabIndex = 3;
            this.btnGuardarconInterop.Text = "Guardar con Interop";
            this.btnGuardarconInterop.UseVisualStyleBackColor = true;
            this.btnGuardarconInterop.Click += new System.EventHandler(this.btnGuardarconInterop_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(775, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(752, 397);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(2, 647);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 40);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAabrir
            // 
            this.btnAabrir.Location = new System.Drawing.Point(2, 460);
            this.btnAabrir.Name = "btnAabrir";
            this.btnAabrir.Size = new System.Drawing.Size(121, 40);
            this.btnAabrir.TabIndex = 7;
            this.btnAabrir.Text = "Abrir";
            this.btnAabrir.UseVisualStyleBackColor = true;
            this.btnAabrir.Click += new System.EventHandler(this.btnAabrir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(983, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Abrir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(130, 407);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(635, 290);
            this.treeView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 699);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAabrir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnGuardarconInterop);
            this.Controls.Add(this.btnGuardarconOpenxml);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lstvDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardarconOpenxml;
        private System.Windows.Forms.Button btnGuardarconInterop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAabrir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeView1;
    }
}

