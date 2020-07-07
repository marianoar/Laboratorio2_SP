namespace AriasMariano_2D_SP
{
    partial class FrmAulaExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAulaExamen));
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.textBoxAlumno = new System.Windows.Forms.TextBox();
            this.textBoxDocente = new System.Windows.Forms.TextBox();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProximo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(31, 49);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno";
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(65, 82);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(103, 13);
            this.lblTxt.TabIndex = 1;
            this.lblTxt.Text = "siendo evaluado por";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(31, 116);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 2;
            this.lblDocente.Text = "Docente";
            // 
            // textBoxAlumno
            // 
            this.textBoxAlumno.Location = new System.Drawing.Point(99, 45);
            this.textBoxAlumno.Name = "textBoxAlumno";
            this.textBoxAlumno.Size = new System.Drawing.Size(120, 20);
            this.textBoxAlumno.TabIndex = 3;
            // 
            // textBoxDocente
            // 
            this.textBoxDocente.Location = new System.Drawing.Point(99, 112);
            this.textBoxDocente.Name = "textBoxDocente";
            this.textBoxDocente.Size = new System.Drawing.Size(120, 20);
            this.textBoxDocente.TabIndex = 4;
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(99, 197);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(120, 20);
            this.textBoxNota1.TabIndex = 5;
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(99, 233);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(120, 20);
            this.textBoxNota2.TabIndex = 6;
            this.textBoxNota2.Text = "l";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(31, 201);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(34, 13);
            this.lblNota1.TabIndex = 7;
            this.lblNota1.Text = "nota1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(31, 237);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(34, 13);
            this.lblNota2.TabIndex = 8;
            this.lblNota2.Text = "nota2";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(143, 377);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 23);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(111, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(165, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Finalizar / Cerrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNota2);
            this.groupBox1.Controls.Add(this.lblNota1);
            this.groupBox1.Controls.Add(this.textBoxNota2);
            this.groupBox1.Controls.Add(this.textBoxNota1);
            this.groupBox1.Controls.Add(this.textBoxDocente);
            this.groupBox1.Controls.Add(this.textBoxAlumno);
            this.groupBox1.Controls.Add(this.lblDocente);
            this.groupBox1.Controls.Add(this.lblTxt);
            this.groupBox1.Controls.Add(this.lblAlumno);
            this.groupBox1.Location = new System.Drawing.Point(74, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 281);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno en evaluacion";
            // 
            // textBoxProximo
            // 
            this.textBoxProximo.Location = new System.Drawing.Point(97, 20);
            this.textBoxProximo.Name = "textBoxProximo";
            this.textBoxProximo.Size = new System.Drawing.Size(124, 20);
            this.textBoxProximo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alumno";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProximo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(75, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 54);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proximo Alumno";
            // 
            // FrmAulaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAulaExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula de Examen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAulaExamen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAulaExamen_FormClosed);
            this.Load += new System.EventHandler(this.FrmAulaExamen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.TextBox textBoxAlumno;
        private System.Windows.Forms.TextBox textBoxDocente;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxProximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}