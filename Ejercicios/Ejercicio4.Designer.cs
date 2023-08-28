namespace CursoCSharp.Ejercicios
{
    partial class Ejercicio4
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEjercicio4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTallaL = new System.Windows.Forms.RadioButton();
            this.rbTallaS = new System.Windows.Forms.RadioButton();
            this.rbTallaM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbBlanco = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEjercicio4
            // 
            this.lblEjercicio4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEjercicio4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio4.Location = new System.Drawing.Point(0, 0);
            this.lblEjercicio4.Name = "lblEjercicio4";
            this.lblEjercicio4.Size = new System.Drawing.Size(656, 55);
            this.lblEjercicio4.TabIndex = 1;
            this.lblEjercicio4.Text = "Ejercicio 4";
            this.lblEjercicio4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Casacas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTallaL);
            this.groupBox1.Controls.Add(this.rbTallaS);
            this.groupBox1.Controls.Add(this.rbTallaM);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talla";
            // 
            // rbTallaL
            // 
            this.rbTallaL.AutoSize = true;
            this.rbTallaL.Location = new System.Drawing.Point(15, 77);
            this.rbTallaL.Name = "rbTallaL";
            this.rbTallaL.Size = new System.Drawing.Size(99, 23);
            this.rbTallaL.TabIndex = 4;
            this.rbTallaL.TabStop = true;
            this.rbTallaL.Text = "L ($200)";
            this.rbTallaL.UseVisualStyleBackColor = true;
            // 
            // rbTallaS
            // 
            this.rbTallaS.AutoSize = true;
            this.rbTallaS.Location = new System.Drawing.Point(15, 125);
            this.rbTallaS.Name = "rbTallaS";
            this.rbTallaS.Size = new System.Drawing.Size(90, 23);
            this.rbTallaS.TabIndex = 4;
            this.rbTallaS.TabStop = true;
            this.rbTallaS.Text = "S ($50)";
            this.rbTallaS.UseVisualStyleBackColor = true;
            // 
            // rbTallaM
            // 
            this.rbTallaM.AutoSize = true;
            this.rbTallaM.Location = new System.Drawing.Point(15, 35);
            this.rbTallaM.Name = "rbTallaM";
            this.rbTallaM.Size = new System.Drawing.Size(99, 23);
            this.rbTallaM.TabIndex = 4;
            this.rbTallaM.TabStop = true;
            this.rbTallaM.Text = "M ($100)";
            this.rbTallaM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRojo);
            this.groupBox2.Controls.Add(this.rbBlanco);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(262, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 181);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(15, 77);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(63, 23);
            this.rbRojo.TabIndex = 4;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbBlanco
            // 
            this.rbBlanco.AutoSize = true;
            this.rbBlanco.Location = new System.Drawing.Point(15, 35);
            this.rbBlanco.Name = "rbBlanco";
            this.rbBlanco.Size = new System.Drawing.Size(81, 23);
            this.rbBlanco.TabIndex = 4;
            this.rbBlanco.TabStop = true;
            this.rbBlanco.Text = "Blanco";
            this.rbBlanco.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(490, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 39);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.SystemColors.Info;
            this.txtDetalle.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtDetalle.Location = new System.Drawing.Point(5, 270);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(457, 86);
            this.txtDetalle.TabIndex = 8;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEjercicio4);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Name = "Ejercicio4";
            this.Size = new System.Drawing.Size(656, 373);
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjercicio4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTallaL;
        private System.Windows.Forms.RadioButton rbTallaS;
        private System.Windows.Forms.RadioButton rbTallaM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbBlanco;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDetalle;
    }
}
