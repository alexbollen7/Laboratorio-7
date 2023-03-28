namespace Laboratorio_7
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
            this.dataGridViewCasas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOrdMan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCuotaMayor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCasas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCasas
            // 
            this.dataGridViewCasas.AllowUserToAddRows = false;
            this.dataGridViewCasas.AllowUserToDeleteRows = false;
            this.dataGridViewCasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCasas.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewCasas.Name = "dataGridViewCasas";
            this.dataGridViewCasas.ReadOnly = true;
            this.dataGridViewCasas.Size = new System.Drawing.Size(456, 293);
            this.dataGridViewCasas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Condominio Los Altos";
            // 
            // buttonOrdMan
            // 
            this.buttonOrdMan.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdMan.Location = new System.Drawing.Point(496, 94);
            this.buttonOrdMan.Name = "buttonOrdMan";
            this.buttonOrdMan.Size = new System.Drawing.Size(123, 69);
            this.buttonOrdMan.TabIndex = 2;
            this.buttonOrdMan.Text = "Ordenar por Mantenimiento";
            this.buttonOrdMan.UseVisualStyleBackColor = true;
            this.buttonOrdMan.Click += new System.EventHandler(this.buttonOrdMan_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(496, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "3 cuotas más altas y más bajas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCuotaMayor
            // 
            this.buttonCuotaMayor.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCuotaMayor.Location = new System.Drawing.Point(496, 276);
            this.buttonCuotaMayor.Name = "buttonCuotaMayor";
            this.buttonCuotaMayor.Size = new System.Drawing.Size(123, 69);
            this.buttonCuotaMayor.TabIndex = 4;
            this.buttonCuotaMayor.Text = "Propietario con cuota mayor";
            this.buttonCuotaMayor.UseVisualStyleBackColor = true;
            this.buttonCuotaMayor.Click += new System.EventHandler(this.buttonCuotaMayor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 53);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(643, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCuotaMayor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOrdMan);
            this.Controls.Add(this.dataGridViewCasas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCasas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCasas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOrdMan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCuotaMayor;
        private System.Windows.Forms.Panel panel1;
    }
}

