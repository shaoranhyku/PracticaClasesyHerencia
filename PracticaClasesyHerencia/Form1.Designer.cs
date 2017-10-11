namespace PracticaClasesyHerencia
{
    partial class Form1
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
            this.lblRectangulo = new System.Windows.Forms.Label();
            this.txtRectanguloBase = new System.Windows.Forms.NumericUpDown();
            this.lblRectanguloBase = new System.Windows.Forms.Label();
            this.lblRectanguloAltura = new System.Windows.Forms.Label();
            this.lblTrianguloBase = new System.Windows.Forms.Label();
            this.lblTrianguloAltura = new System.Windows.Forms.Label();
            this.lblCirculoRadio = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.lblCirculo = new System.Windows.Forms.Label();
            this.txtRectanguloAltura = new System.Windows.Forms.NumericUpDown();
            this.txtTrianguloBase = new System.Windows.Forms.NumericUpDown();
            this.txtTrianguloAltura = new System.Windows.Forms.NumericUpDown();
            this.txtCirculoRadio = new System.Windows.Forms.NumericUpDown();
            this.btnCalcularPerimetroRectangulo = new System.Windows.Forms.Button();
            this.btnCalcularPerimetroTriangulo = new System.Windows.Forms.Button();
            this.btnCalcularPerimetroCirculo = new System.Windows.Forms.Button();
            this.txtResultadoRectangulo = new System.Windows.Forms.TextBox();
            this.txtResultadoTriangulo = new System.Windows.Forms.TextBox();
            this.txtResultadoCirculo = new System.Windows.Forms.TextBox();
            this.btnCalcularAreaRectangulo = new System.Windows.Forms.Button();
            this.btnCalcularAreaTriangulo = new System.Windows.Forms.Button();
            this.btnCalcularAreaCirculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtRectanguloBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRectanguloAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrianguloBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrianguloAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCirculoRadio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRectangulo
            // 
            this.lblRectangulo.AutoSize = true;
            this.lblRectangulo.Location = new System.Drawing.Point(13, 9);
            this.lblRectangulo.Name = "lblRectangulo";
            this.lblRectangulo.Size = new System.Drawing.Size(62, 13);
            this.lblRectangulo.TabIndex = 0;
            this.lblRectangulo.Text = "Rectángulo";
            // 
            // txtRectanguloBase
            // 
            this.txtRectanguloBase.DecimalPlaces = 2;
            this.txtRectanguloBase.Location = new System.Drawing.Point(73, 28);
            this.txtRectanguloBase.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtRectanguloBase.Name = "txtRectanguloBase";
            this.txtRectanguloBase.Size = new System.Drawing.Size(100, 20);
            this.txtRectanguloBase.TabIndex = 1;
            // 
            // lblRectanguloBase
            // 
            this.lblRectanguloBase.AutoSize = true;
            this.lblRectanguloBase.Location = new System.Drawing.Point(16, 31);
            this.lblRectanguloBase.Name = "lblRectanguloBase";
            this.lblRectanguloBase.Size = new System.Drawing.Size(31, 13);
            this.lblRectanguloBase.TabIndex = 2;
            this.lblRectanguloBase.Text = "Base";
            // 
            // lblRectanguloAltura
            // 
            this.lblRectanguloAltura.AutoSize = true;
            this.lblRectanguloAltura.Location = new System.Drawing.Point(196, 31);
            this.lblRectanguloAltura.Name = "lblRectanguloAltura";
            this.lblRectanguloAltura.Size = new System.Drawing.Size(34, 13);
            this.lblRectanguloAltura.TabIndex = 3;
            this.lblRectanguloAltura.Text = "Altura";
            // 
            // lblTrianguloBase
            // 
            this.lblTrianguloBase.AutoSize = true;
            this.lblTrianguloBase.Location = new System.Drawing.Point(16, 111);
            this.lblTrianguloBase.Name = "lblTrianguloBase";
            this.lblTrianguloBase.Size = new System.Drawing.Size(31, 13);
            this.lblTrianguloBase.TabIndex = 4;
            this.lblTrianguloBase.Text = "Base";
            // 
            // lblTrianguloAltura
            // 
            this.lblTrianguloAltura.AutoSize = true;
            this.lblTrianguloAltura.Location = new System.Drawing.Point(196, 111);
            this.lblTrianguloAltura.Name = "lblTrianguloAltura";
            this.lblTrianguloAltura.Size = new System.Drawing.Size(34, 13);
            this.lblTrianguloAltura.TabIndex = 5;
            this.lblTrianguloAltura.Text = "Altura";
            // 
            // lblCirculoRadio
            // 
            this.lblCirculoRadio.AutoSize = true;
            this.lblCirculoRadio.Location = new System.Drawing.Point(16, 198);
            this.lblCirculoRadio.Name = "lblCirculoRadio";
            this.lblCirculoRadio.Size = new System.Drawing.Size(35, 13);
            this.lblCirculoRadio.TabIndex = 7;
            this.lblCirculoRadio.Text = "Radio";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(13, 88);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(51, 13);
            this.lblTriangulo.TabIndex = 8;
            this.lblTriangulo.Text = "Triángulo";
            // 
            // lblCirculo
            // 
            this.lblCirculo.AutoSize = true;
            this.lblCirculo.Location = new System.Drawing.Point(13, 171);
            this.lblCirculo.Name = "lblCirculo";
            this.lblCirculo.Size = new System.Drawing.Size(41, 13);
            this.lblCirculo.TabIndex = 9;
            this.lblCirculo.Text = "Círculo";
            // 
            // txtRectanguloAltura
            // 
            this.txtRectanguloAltura.DecimalPlaces = 2;
            this.txtRectanguloAltura.Location = new System.Drawing.Point(236, 28);
            this.txtRectanguloAltura.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtRectanguloAltura.Name = "txtRectanguloAltura";
            this.txtRectanguloAltura.Size = new System.Drawing.Size(100, 20);
            this.txtRectanguloAltura.TabIndex = 10;
            // 
            // txtTrianguloBase
            // 
            this.txtTrianguloBase.DecimalPlaces = 2;
            this.txtTrianguloBase.Location = new System.Drawing.Point(73, 108);
            this.txtTrianguloBase.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtTrianguloBase.Name = "txtTrianguloBase";
            this.txtTrianguloBase.Size = new System.Drawing.Size(100, 20);
            this.txtTrianguloBase.TabIndex = 11;
            // 
            // txtTrianguloAltura
            // 
            this.txtTrianguloAltura.DecimalPlaces = 2;
            this.txtTrianguloAltura.Location = new System.Drawing.Point(236, 108);
            this.txtTrianguloAltura.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtTrianguloAltura.Name = "txtTrianguloAltura";
            this.txtTrianguloAltura.Size = new System.Drawing.Size(100, 20);
            this.txtTrianguloAltura.TabIndex = 12;
            // 
            // txtCirculoRadio
            // 
            this.txtCirculoRadio.DecimalPlaces = 2;
            this.txtCirculoRadio.Location = new System.Drawing.Point(73, 195);
            this.txtCirculoRadio.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtCirculoRadio.Name = "txtCirculoRadio";
            this.txtCirculoRadio.Size = new System.Drawing.Size(100, 20);
            this.txtCirculoRadio.TabIndex = 13;
            // 
            // btnCalcularPerimetroRectangulo
            // 
            this.btnCalcularPerimetroRectangulo.Location = new System.Drawing.Point(351, 12);
            this.btnCalcularPerimetroRectangulo.Name = "btnCalcularPerimetroRectangulo";
            this.btnCalcularPerimetroRectangulo.Size = new System.Drawing.Size(116, 23);
            this.btnCalcularPerimetroRectangulo.TabIndex = 14;
            this.btnCalcularPerimetroRectangulo.Text = "CalcularPerimetro";
            this.btnCalcularPerimetroRectangulo.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetroRectangulo.Click += new System.EventHandler(this.btnCalcularPerimetroRectangulo_Click);
            // 
            // btnCalcularPerimetroTriangulo
            // 
            this.btnCalcularPerimetroTriangulo.Location = new System.Drawing.Point(351, 101);
            this.btnCalcularPerimetroTriangulo.Name = "btnCalcularPerimetroTriangulo";
            this.btnCalcularPerimetroTriangulo.Size = new System.Drawing.Size(116, 23);
            this.btnCalcularPerimetroTriangulo.TabIndex = 15;
            this.btnCalcularPerimetroTriangulo.Text = "CalcularPerimetro";
            this.btnCalcularPerimetroTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetroTriangulo.Click += new System.EventHandler(this.btnCalcularPerimetroTriangulo_Click);
            // 
            // btnCalcularPerimetroCirculo
            // 
            this.btnCalcularPerimetroCirculo.Location = new System.Drawing.Point(351, 178);
            this.btnCalcularPerimetroCirculo.Name = "btnCalcularPerimetroCirculo";
            this.btnCalcularPerimetroCirculo.Size = new System.Drawing.Size(116, 23);
            this.btnCalcularPerimetroCirculo.TabIndex = 16;
            this.btnCalcularPerimetroCirculo.Text = "CalcularPerimetro";
            this.btnCalcularPerimetroCirculo.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetroCirculo.Click += new System.EventHandler(this.btnCalcularPerimetroCirculo_Click);
            // 
            // txtResultadoRectangulo
            // 
            this.txtResultadoRectangulo.Enabled = false;
            this.txtResultadoRectangulo.Location = new System.Drawing.Point(485, 28);
            this.txtResultadoRectangulo.Name = "txtResultadoRectangulo";
            this.txtResultadoRectangulo.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoRectangulo.TabIndex = 17;
            // 
            // txtResultadoTriangulo
            // 
            this.txtResultadoTriangulo.Enabled = false;
            this.txtResultadoTriangulo.Location = new System.Drawing.Point(485, 108);
            this.txtResultadoTriangulo.Name = "txtResultadoTriangulo";
            this.txtResultadoTriangulo.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoTriangulo.TabIndex = 18;
            // 
            // txtResultadoCirculo
            // 
            this.txtResultadoCirculo.Enabled = false;
            this.txtResultadoCirculo.Location = new System.Drawing.Point(485, 195);
            this.txtResultadoCirculo.Name = "txtResultadoCirculo";
            this.txtResultadoCirculo.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoCirculo.TabIndex = 19;
            // 
            // btnCalcularAreaRectangulo
            // 
            this.btnCalcularAreaRectangulo.Location = new System.Drawing.Point(351, 41);
            this.btnCalcularAreaRectangulo.Name = "btnCalcularAreaRectangulo";
            this.btnCalcularAreaRectangulo.Size = new System.Drawing.Size(116, 23);
            this.btnCalcularAreaRectangulo.TabIndex = 20;
            this.btnCalcularAreaRectangulo.Text = "CalcularArea";
            this.btnCalcularAreaRectangulo.UseVisualStyleBackColor = true;
            this.btnCalcularAreaRectangulo.Click += new System.EventHandler(this.btnCalcularAreaRectangulo_Click);
            // 
            // btnCalcularAreaTriangulo
            // 
            this.btnCalcularAreaTriangulo.Location = new System.Drawing.Point(351, 130);
            this.btnCalcularAreaTriangulo.Name = "btnCalcularAreaTriangulo";
            this.btnCalcularAreaTriangulo.Size = new System.Drawing.Size(116, 23);
            this.btnCalcularAreaTriangulo.TabIndex = 21;
            this.btnCalcularAreaTriangulo.Text = "CalcularArea";
            this.btnCalcularAreaTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularAreaTriangulo.Click += new System.EventHandler(this.btnCalcularAreaTriangulo_Click);
            // 
            // btnCalcularAreaCirculo
            // 
            this.btnCalcularAreaCirculo.Location = new System.Drawing.Point(351, 207);
            this.btnCalcularAreaCirculo.Name = "btnCalcularAreaCirculo";
            this.btnCalcularAreaCirculo.Size = new System.Drawing.Size(116, 23);
            this.btnCalcularAreaCirculo.TabIndex = 22;
            this.btnCalcularAreaCirculo.Text = "CalcularArea";
            this.btnCalcularAreaCirculo.UseVisualStyleBackColor = true;
            this.btnCalcularAreaCirculo.Click += new System.EventHandler(this.btnCalcularAreaCirculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 242);
            this.Controls.Add(this.btnCalcularAreaCirculo);
            this.Controls.Add(this.btnCalcularAreaTriangulo);
            this.Controls.Add(this.btnCalcularAreaRectangulo);
            this.Controls.Add(this.txtResultadoCirculo);
            this.Controls.Add(this.txtResultadoTriangulo);
            this.Controls.Add(this.txtResultadoRectangulo);
            this.Controls.Add(this.btnCalcularPerimetroCirculo);
            this.Controls.Add(this.btnCalcularPerimetroTriangulo);
            this.Controls.Add(this.btnCalcularPerimetroRectangulo);
            this.Controls.Add(this.txtCirculoRadio);
            this.Controls.Add(this.txtTrianguloAltura);
            this.Controls.Add(this.txtTrianguloBase);
            this.Controls.Add(this.txtRectanguloAltura);
            this.Controls.Add(this.lblCirculo);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.lblCirculoRadio);
            this.Controls.Add(this.lblTrianguloAltura);
            this.Controls.Add(this.lblTrianguloBase);
            this.Controls.Add(this.lblRectanguloAltura);
            this.Controls.Add(this.lblRectanguloBase);
            this.Controls.Add(this.txtRectanguloBase);
            this.Controls.Add(this.lblRectangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtRectanguloBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRectanguloAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrianguloBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrianguloAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCirculoRadio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRectangulo;
        private System.Windows.Forms.NumericUpDown txtRectanguloBase;
        private System.Windows.Forms.Label lblRectanguloBase;
        private System.Windows.Forms.Label lblRectanguloAltura;
        private System.Windows.Forms.Label lblTrianguloBase;
        private System.Windows.Forms.Label lblTrianguloAltura;
        private System.Windows.Forms.Label lblCirculoRadio;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Label lblCirculo;
        private System.Windows.Forms.NumericUpDown txtRectanguloAltura;
        private System.Windows.Forms.NumericUpDown txtTrianguloBase;
        private System.Windows.Forms.NumericUpDown txtTrianguloAltura;
        private System.Windows.Forms.NumericUpDown txtCirculoRadio;
        private System.Windows.Forms.Button btnCalcularPerimetroRectangulo;
        private System.Windows.Forms.Button btnCalcularPerimetroTriangulo;
        private System.Windows.Forms.Button btnCalcularPerimetroCirculo;
        private System.Windows.Forms.TextBox txtResultadoRectangulo;
        private System.Windows.Forms.TextBox txtResultadoTriangulo;
        private System.Windows.Forms.TextBox txtResultadoCirculo;
        private System.Windows.Forms.Button btnCalcularAreaRectangulo;
        private System.Windows.Forms.Button btnCalcularAreaTriangulo;
        private System.Windows.Forms.Button btnCalcularAreaCirculo;
    }
}

