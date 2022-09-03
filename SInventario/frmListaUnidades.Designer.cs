namespace SInventario
{
    partial class frmListaUnidades
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
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Location = new System.Drawing.Point(24, 61);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.RowTemplate.Height = 25;
            this.dgvUnidades.Size = new System.Drawing.Size(709, 302);
            this.dgvUnidades.TabIndex = 0;
            this.dgvUnidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListaUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvUnidades);
            this.Name = "frmListaUnidades";
            this.Text = "frmListaUnidades";
            this.Activated += new System.EventHandler(this.frmListaUnidades_Activated);
            this.Load += new System.EventHandler(this.frmListaUnidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUnidades;
        private Button button1;
    }
}