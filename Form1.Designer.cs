namespace AlqCoche
{
    partial class ventaApp
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
            this.kmInitCount = new System.Windows.Forms.NumericUpDown();
            this.kmEndCount = new System.Windows.Forms.NumericUpDown();
            this.kmInitial = new System.Windows.Forms.Label();
            this.kmEnd = new System.Windows.Forms.Label();
            this.buttonCalcCash = new System.Windows.Forms.Button();
            this.totalCash = new System.Windows.Forms.Label();
            this.totalCashCalc = new System.Windows.Forms.Label();
            this.buttonShowKm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kmInitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmEndCount)).BeginInit();
            this.SuspendLayout();
            // 
            // kmInitCount
            // 
            this.kmInitCount.Location = new System.Drawing.Point(144, 34);
            this.kmInitCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.kmInitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kmInitCount.Name = "kmInitCount";
            this.kmInitCount.Size = new System.Drawing.Size(183, 20);
            this.kmInitCount.TabIndex = 0;
            this.kmInitCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kmEndCount
            // 
            this.kmEndCount.Location = new System.Drawing.Point(144, 60);
            this.kmEndCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.kmEndCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kmEndCount.Name = "kmEndCount";
            this.kmEndCount.Size = new System.Drawing.Size(183, 20);
            this.kmEndCount.TabIndex = 1;
            this.kmEndCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kmInitial
            // 
            this.kmInitial.AutoSize = true;
            this.kmInitial.Location = new System.Drawing.Point(40, 36);
            this.kmInitial.Name = "kmInitial";
            this.kmInitial.Size = new System.Drawing.Size(89, 13);
            this.kmInitial.TabIndex = 2;
            this.kmInitial.Text = "Kilometraje Inicio:";
            // 
            // kmEnd
            // 
            this.kmEnd.AutoSize = true;
            this.kmEnd.Location = new System.Drawing.Point(40, 62);
            this.kmEnd.Name = "kmEnd";
            this.kmEnd.Size = new System.Drawing.Size(78, 13);
            this.kmEnd.TabIndex = 3;
            this.kmEnd.Text = "Kilometraje Fin:";
            // 
            // buttonCalcCash
            // 
            this.buttonCalcCash.Location = new System.Drawing.Point(43, 153);
            this.buttonCalcCash.Name = "buttonCalcCash";
            this.buttonCalcCash.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcCash.TabIndex = 4;
            this.buttonCalcCash.Text = "CALCULAR";
            this.buttonCalcCash.UseVisualStyleBackColor = true;
            this.buttonCalcCash.Click += new System.EventHandler(this.buttonCalcCash_Click);
            // 
            // totalCash
            // 
            this.totalCash.AutoSize = true;
            this.totalCash.Location = new System.Drawing.Point(43, 120);
            this.totalCash.Name = "totalCash";
            this.totalCash.Size = new System.Drawing.Size(111, 13);
            this.totalCash.TabIndex = 5;
            this.totalCash.Text = "Cantidad obtenida (€):";
            // 
            // totalCashCalc
            // 
            this.totalCashCalc.AutoSize = true;
            this.totalCashCalc.Location = new System.Drawing.Point(173, 120);
            this.totalCashCalc.Name = "totalCashCalc";
            this.totalCashCalc.Size = new System.Drawing.Size(0, 13);
            this.totalCashCalc.TabIndex = 6;
            // 
            // buttonShowKm
            // 
            this.buttonShowKm.Location = new System.Drawing.Point(208, 153);
            this.buttonShowKm.Name = "buttonShowKm";
            this.buttonShowKm.Size = new System.Drawing.Size(119, 23);
            this.buttonShowKm.TabIndex = 7;
            this.buttonShowKm.Text = "Muestra Kilómetros";
            this.buttonShowKm.UseVisualStyleBackColor = true;
            this.buttonShowKm.Click += new System.EventHandler(this.buttonShowKm_Click);
            // 
            // ventaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 208);
            this.Controls.Add(this.buttonShowKm);
            this.Controls.Add(this.totalCashCalc);
            this.Controls.Add(this.totalCash);
            this.Controls.Add(this.buttonCalcCash);
            this.Controls.Add(this.kmEnd);
            this.Controls.Add(this.kmInitial);
            this.Controls.Add(this.kmEndCount);
            this.Controls.Add(this.kmInitCount);
            this.Name = "ventaApp";
            this.Text = "Calculadora Viajes";
            ((System.ComponentModel.ISupportInitialize)(this.kmInitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmEndCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown kmInitCount;
        private System.Windows.Forms.NumericUpDown kmEndCount;
        private System.Windows.Forms.Label kmInitial;
        private System.Windows.Forms.Label kmEnd;
        private System.Windows.Forms.Button buttonCalcCash;
        private System.Windows.Forms.Label totalCash;
        private System.Windows.Forms.Label totalCashCalc;
        private System.Windows.Forms.Button buttonShowKm;
    }
}

