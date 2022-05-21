
namespace Salon_Marilucy
{
    partial class Ingresos_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinicio = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboservicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbmetododepago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.AutoSize = true;
            this.btncerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncerrar.Location = new System.Drawing.Point(771, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(17, 17);
            this.btncerrar.TabIndex = 12;
            this.btncerrar.Text = "X";
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingresos";
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(57, 101);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(63, 27);
            this.lblinicio.TabIndex = 16;
            this.lblinicio.Text = "D/M/A";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre del trabajador :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre del servicio :";
            // 
            // comboservicio
            // 
            this.comboservicio.FormattingEnabled = true;
            this.comboservicio.Location = new System.Drawing.Point(28, 208);
            this.comboservicio.Name = "comboservicio";
            this.comboservicio.Size = new System.Drawing.Size(234, 21);
            this.comboservicio.TabIndex = 20;
            this.comboservicio.SelectedIndexChanged += new System.EventHandler(this.comboservicio_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio del Servicio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(28, 313);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(234, 26);
            this.txtprecio.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 295);
            this.dataGridView1.TabIndex = 23;
            // 
            // cmbmetododepago
            // 
            this.cmbmetododepago.FormattingEnabled = true;
            this.cmbmetododepago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cmbmetododepago.Location = new System.Drawing.Point(28, 262);
            this.cmbmetododepago.Name = "cmbmetododepago";
            this.cmbmetododepago.Size = new System.Drawing.Size(234, 21);
            this.cmbmetododepago.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Metodo de Pago :";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnfinalizar.FlatAppearance.BorderSize = 0;
            this.btnfinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfinalizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.White;
            this.btnfinalizar.Image = global::Salon_Marilucy.Properties.Resources.finalizar_la_sesion;
            this.btnfinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfinalizar.Location = new System.Drawing.Point(538, 41);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(250, 40);
            this.btnfinalizar.TabIndex = 15;
            this.btnfinalizar.Text = "Finalizar Jornada";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btniniciar.FlatAppearance.BorderSize = 0;
            this.btniniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.Color.White;
            this.btniniciar.Image = global::Salon_Marilucy.Properties.Resources.iniciar_sesion;
            this.btniniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniniciar.Location = new System.Drawing.Point(12, 41);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(250, 40);
            this.btniniciar.TabIndex = 14;
            this.btniniciar.Text = "Iniciar Jornada";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btngenerar.FlatAppearance.BorderSize = 0;
            this.btngenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.ForeColor = System.Drawing.Color.White;
            this.btngenerar.Image = global::Salon_Marilucy.Properties.Resources.editar1;
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerar.Location = new System.Drawing.Point(12, 356);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(250, 40);
            this.btngenerar.TabIndex = 13;
            this.btngenerar.Text = "Registrar";
            this.btngenerar.UseVisualStyleBackColor = false;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // Ingresos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbmetododepago);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.comboservicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresos_Form";
            this.Text = "Ingresos_Form";
            this.Load += new System.EventHandler(this.Ingresos_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboservicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbmetododepago;
        private System.Windows.Forms.Label label5;
    }
}