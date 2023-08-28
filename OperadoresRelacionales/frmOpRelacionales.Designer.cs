namespace CursoCSharp.OperadoresRelacionales
{
    partial class frmOpRelacionales
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnmayor = new System.Windows.Forms.Button();
            this.btnmenor = new System.Windows.Forms.Button();
            this.btnmayoreigual = new System.Windows.Forms.Button();
            this.btnmenoreigual = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btndistinto = new System.Windows.Forms.Button();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnmayor);
            this.flowLayoutPanel1.Controls.Add(this.btnmenor);
            this.flowLayoutPanel1.Controls.Add(this.btnmayoreigual);
            this.flowLayoutPanel1.Controls.Add(this.btnmenoreigual);
            this.flowLayoutPanel1.Controls.Add(this.btnigual);
            this.flowLayoutPanel1.Controls.Add(this.btndistinto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(221, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(452, 62);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnmayor
            // 
            this.btnmayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnmayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayor.Location = new System.Drawing.Point(3, 3);
            this.btnmayor.Name = "btnmayor";
            this.btnmayor.Size = new System.Drawing.Size(69, 49);
            this.btnmayor.TabIndex = 0;
            this.btnmayor.Text = ">";
            this.btnmayor.UseVisualStyleBackColor = false;
            this.btnmayor.Click += new System.EventHandler(this.btnmayor_Click);
            // 
            // btnmenor
            // 
            this.btnmenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnmenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenor.Location = new System.Drawing.Point(78, 3);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(69, 49);
            this.btnmenor.TabIndex = 0;
            this.btnmenor.Text = "<";
            this.btnmenor.UseVisualStyleBackColor = false;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // btnmayoreigual
            // 
            this.btnmayoreigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnmayoreigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmayoreigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayoreigual.Location = new System.Drawing.Point(153, 3);
            this.btnmayoreigual.Name = "btnmayoreigual";
            this.btnmayoreigual.Size = new System.Drawing.Size(69, 49);
            this.btnmayoreigual.TabIndex = 0;
            this.btnmayoreigual.Text = ">=";
            this.btnmayoreigual.UseVisualStyleBackColor = false;
            this.btnmayoreigual.Click += new System.EventHandler(this.btnmayoreigual_Click);
            // 
            // btnmenoreigual
            // 
            this.btnmenoreigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnmenoreigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenoreigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenoreigual.Location = new System.Drawing.Point(228, 3);
            this.btnmenoreigual.Name = "btnmenoreigual";
            this.btnmenoreigual.Size = new System.Drawing.Size(69, 49);
            this.btnmenoreigual.TabIndex = 0;
            this.btnmenoreigual.Text = "<=";
            this.btnmenoreigual.UseVisualStyleBackColor = false;
            this.btnmenoreigual.Click += new System.EventHandler(this.btnmenoreigual_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(303, 3);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(69, 49);
            this.btnigual.TabIndex = 0;
            this.btnigual.Text = "==";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btndistinto
            // 
            this.btndistinto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndistinto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndistinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndistinto.Location = new System.Drawing.Point(378, 3);
            this.btndistinto.Name = "btndistinto";
            this.btndistinto.Size = new System.Drawing.Size(69, 49);
            this.btndistinto.TabIndex = 0;
            this.btndistinto.Text = "!=";
            this.btndistinto.UseVisualStyleBackColor = false;
            this.btndistinto.Click += new System.EventHandler(this.btndistinto_Click);
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(336, 143);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(152, 23);
            this.txtnum2.TabIndex = 11;
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(336, 92);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(152, 23);
            this.txtnum1.TabIndex = 10;
            this.txtnum1.TextChanged += new System.EventHandler(this.txtnum1_TextChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(332, 269);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(126, 35);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = " 0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero 2:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero 1:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Operadores Relacionales";
            // 
            // frmOpRelacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmOpRelacionales";
            this.Text = "frmOpRelacionales";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnmayor;
        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Button btnmayoreigual;
        private System.Windows.Forms.Button btnmenoreigual;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btndistinto;
        private System.Windows.Forms.Label label4;
    }
}