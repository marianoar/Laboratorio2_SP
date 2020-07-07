namespace AriasMariano_2D_SP
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.listBoxDocentes = new System.Windows.Forms.ListBox();
            this.listBoxAprobados = new System.Windows.Forms.ListBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.lblRecreo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.textBoxDocente = new System.Windows.Forms.TextBox();
            this.textBoxAlumno = new System.Windows.Forms.TextBox();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxDesaprobados = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDesaprobados = new System.Windows.Forms.Label();
            this.labelAprobados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerRecreo = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(40, 44);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(200, 472);
            this.listBoxAlumnos.TabIndex = 0;
            // 
            // listBoxDocentes
            // 
            this.listBoxDocentes.FormattingEnabled = true;
            this.listBoxDocentes.Location = new System.Drawing.Point(337, 44);
            this.listBoxDocentes.Name = "listBoxDocentes";
            this.listBoxDocentes.Size = new System.Drawing.Size(200, 147);
            this.listBoxDocentes.TabIndex = 1;
            // 
            // listBoxAprobados
            // 
            this.listBoxAprobados.FormattingEnabled = true;
            this.listBoxAprobados.Location = new System.Drawing.Point(18, 272);
            this.listBoxAprobados.Name = "listBoxAprobados";
            this.listBoxAprobados.Size = new System.Drawing.Size(200, 212);
            this.listBoxAprobados.TabIndex = 2;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(337, 467);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(200, 23);
            this.btnEvaluar.TabIndex = 3;
            this.btnEvaluar.Text = "Iniciar Evaluacion";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // lblRecreo
            // 
            this.lblRecreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecreo.Location = new System.Drawing.Point(337, 210);
            this.lblRecreo.Name = "lblRecreo";
            this.lblRecreo.Size = new System.Drawing.Size(200, 23);
            this.lblRecreo.TabIndex = 4;
            this.lblRecreo.Text = "label1";
            this.lblRecreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(617, 9);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(35, 13);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "label1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(19, 163);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(35, 13);
            this.lblNota2.TabIndex = 17;
            this.lblNota2.Text = "label5";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(19, 117);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(35, 13);
            this.lblNota1.TabIndex = 16;
            this.lblNota1.Text = "label4";
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(104, 160);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota2.TabIndex = 15;
            this.textBoxNota2.Text = "l";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(104, 114);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNota1.TabIndex = 14;
            // 
            // textBoxDocente
            // 
            this.textBoxDocente.Location = new System.Drawing.Point(104, 88);
            this.textBoxDocente.Name = "textBoxDocente";
            this.textBoxDocente.Size = new System.Drawing.Size(100, 20);
            this.textBoxDocente.TabIndex = 13;
            // 
            // textBoxAlumno
            // 
            this.textBoxAlumno.Location = new System.Drawing.Point(104, 43);
            this.textBoxAlumno.Name = "textBoxAlumno";
            this.textBoxAlumno.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlumno.TabIndex = 12;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(19, 91);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(35, 13);
            this.lblDocente.TabIndex = 11;
            this.lblDocente.Text = "label3";
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(19, 65);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(35, 13);
            this.lblTxt.TabIndex = 10;
            this.lblTxt.Text = "label2";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(19, 44);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(35, 13);
            this.lblAlumno.TabIndex = 9;
            this.lblAlumno.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNota2);
            this.groupBox2.Controls.Add(this.lblNota1);
            this.groupBox2.Controls.Add(this.textBoxNota2);
            this.groupBox2.Controls.Add(this.lblDocente);
            this.groupBox2.Controls.Add(this.textBoxNota1);
            this.groupBox2.Controls.Add(this.lblTxt);
            this.groupBox2.Controls.Add(this.textBoxDocente);
            this.groupBox2.Controls.Add(this.textBoxAlumno);
            this.groupBox2.Controls.Add(this.lblAlumno);
            this.groupBox2.Location = new System.Drawing.Point(318, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 207);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En Evaluacion";
            // 
            // listBoxDesaprobados
            // 
            this.listBoxDesaprobados.FormattingEnabled = true;
            this.listBoxDesaprobados.Location = new System.Drawing.Point(18, 35);
            this.listBoxDesaprobados.Name = "listBoxDesaprobados";
            this.listBoxDesaprobados.Size = new System.Drawing.Size(200, 212);
            this.listBoxDesaprobados.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDesaprobados);
            this.groupBox3.Controls.Add(this.labelAprobados);
            this.groupBox3.Controls.Add(this.listBoxAprobados);
            this.groupBox3.Controls.Add(this.listBoxDesaprobados);
            this.groupBox3.Location = new System.Drawing.Point(620, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 484);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alumnos Evaluados";
            // 
            // labelDesaprobados
            // 
            this.labelDesaprobados.AutoSize = true;
            this.labelDesaprobados.Location = new System.Drawing.Point(59, 256);
            this.labelDesaprobados.Name = "labelDesaprobados";
            this.labelDesaprobados.Size = new System.Drawing.Size(119, 13);
            this.labelDesaprobados.TabIndex = 25;
            this.labelDesaprobados.Text = "Alumnos Desaprobados";
            // 
            // labelAprobados
            // 
            this.labelAprobados.AutoSize = true;
            this.labelAprobados.Location = new System.Drawing.Point(68, 20);
            this.labelAprobados.Name = "labelAprobados";
            this.labelAprobados.Size = new System.Drawing.Size(101, 13);
            this.labelAprobados.TabIndex = 24;
            this.labelAprobados.Text = "Alumnos Aprobados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nomina de Alumnos a evaluar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nomina de docentes";
            // 
            // timerRecreo
            // 
            this.timerRecreo.Interval = 1000;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecreo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.listBoxDocentes);
            this.Controls.Add(this.listBoxAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin de Infantes Los Pichoncitos - Segundo Parcial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.ListBox listBoxDocentes;
        private System.Windows.Forms.ListBox listBoxAprobados;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label lblRecreo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.TextBox textBoxDocente;
        private System.Windows.Forms.TextBox textBoxAlumno;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxDesaprobados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDesaprobados;
        private System.Windows.Forms.Label labelAprobados;
        private System.Windows.Forms.Timer timerRecreo;
    }
}

