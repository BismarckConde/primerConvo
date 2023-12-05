namespace pjCI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtFechaNacimiento = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvMatriculas = new ListView();
            btnIngresarMatricula = new Button();
            cmbTipoPersona = new ComboBox();
            btnIngresarPersona = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtNota = new TextBox();
            label20 = new Label();
            txtAsignatura = new TextBox();
            lvAprobados = new ListView();
            btnMostrarAprobadosReprobados = new Button();
            lvReprobados = new ListView();
            cmbEstudiantes = new ComboBox();
            cmbAsignaturas = new ComboBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(18, 63);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 24);
            txtNombres.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(140, 63);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 24);
            txtApellidos.TabIndex = 1;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(255, 63);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(100, 24);
            txtFechaNacimiento.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtFechaNacimiento);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(641, 41);
            label7.Name = "label7";
            label7.Size = new Size(56, 19);
            label7.TabIndex = 11;
            label7.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(641, 63);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 24);
            txtCodigo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 41);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 41);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 8;
            label5.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(517, 63);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 24);
            txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(395, 63);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 24);
            txtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 41);
            label3.Name = "label3";
            label3.Size = new Size(134, 19);
            label3.TabIndex = 5;
            label3.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 41);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 4;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 41);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // lvMatriculas
            // 
            lvMatriculas.Location = new Point(21, 321);
            lvMatriculas.Name = "lvMatriculas";
            lvMatriculas.Size = new Size(420, 174);
            lvMatriculas.TabIndex = 4;
            lvMatriculas.UseCompatibleStateImageBehavior = false;
            // 
            // btnIngresarMatricula
            // 
            btnIngresarMatricula.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresarMatricula.Location = new Point(416, 199);
            btnIngresarMatricula.Name = "btnIngresarMatricula";
            btnIngresarMatricula.Size = new Size(115, 52);
            btnIngresarMatricula.TabIndex = 5;
            btnIngresarMatricula.Text = "Ingresar Matricula";
            btnIngresarMatricula.UseVisualStyleBackColor = true;
            btnIngresarMatricula.Click += btnIngresarMatricula_Click;
            // 
            // cmbTipoPersona
            // 
            cmbTipoPersona.FormattingEnabled = true;
            cmbTipoPersona.Items.AddRange(new object[] { "Profesor", "Estudiante" });
            cmbTipoPersona.Location = new Point(797, 65);
            cmbTipoPersona.Name = "cmbTipoPersona";
            cmbTipoPersona.Size = new Size(121, 23);
            cmbTipoPersona.TabIndex = 6;
            cmbTipoPersona.Text = "SELECCONAR";
            // 
            // btnIngresarPersona
            // 
            btnIngresarPersona.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresarPersona.Location = new Point(797, 97);
            btnIngresarPersona.Name = "btnIngresarPersona";
            btnIngresarPersona.Size = new Size(121, 46);
            btnIngresarPersona.TabIndex = 7;
            btnIngresarPersona.Text = "Ingresar Persona";
            btnIngresarPersona.UseVisualStyleBackColor = true;
            btnIngresarPersona.Click += btnIngresarPersona_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtNota);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(txtAsignatura);
            groupBox2.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 115);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "CALIFICACIONES";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 41);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 9;
            label6.Text = "Nota";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(162, 63);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 24);
            txtNota.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(18, 41);
            label20.Name = "label20";
            label20.Size = new Size(85, 19);
            label20.TabIndex = 3;
            label20.Text = "Asignatura";
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(18, 63);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(100, 24);
            txtAsignatura.TabIndex = 0;
            // 
            // lvAprobados
            // 
            lvAprobados.Location = new Point(479, 321);
            lvAprobados.Name = "lvAprobados";
            lvAprobados.Size = new Size(420, 174);
            lvAprobados.TabIndex = 11;
            lvAprobados.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrarAprobadosReprobados
            // 
            btnMostrarAprobadosReprobados.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarAprobadosReprobados.Location = new Point(560, 199);
            btnMostrarAprobadosReprobados.Name = "btnMostrarAprobadosReprobados";
            btnMostrarAprobadosReprobados.Size = new Size(117, 52);
            btnMostrarAprobadosReprobados.TabIndex = 12;
            btnMostrarAprobadosReprobados.Text = "Mostrar";
            btnMostrarAprobadosReprobados.UseVisualStyleBackColor = true;
            btnMostrarAprobadosReprobados.Click += btnMostrarAprobadosReprobados_Click;
            // 
            // lvReprobados
            // 
            lvReprobados.Location = new Point(257, 528);
            lvReprobados.Name = "lvReprobados";
            lvReprobados.Size = new Size(420, 174);
            lvReprobados.TabIndex = 13;
            lvReprobados.UseCompatibleStateImageBehavior = false;
            // 
            // cmbEstudiantes
            // 
            cmbEstudiantes.FormattingEnabled = true;
            cmbEstudiantes.Location = new Point(797, 199);
            cmbEstudiantes.Name = "cmbEstudiantes";
            cmbEstudiantes.Size = new Size(121, 23);
            cmbEstudiantes.TabIndex = 14;
            cmbEstudiantes.Text = "SELECCONAR";
            // 
            // cmbAsignaturas
            // 
            cmbAsignaturas.FormattingEnabled = true;
            cmbAsignaturas.Location = new Point(797, 241);
            cmbAsignaturas.Name = "cmbAsignaturas";
            cmbAsignaturas.Size = new Size(121, 23);
            cmbAsignaturas.TabIndex = 15;
            cmbAsignaturas.Text = "SELECCONAR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(316, 9);
            label8.Name = "label8";
            label8.Size = new Size(291, 35);
            label8.TabIndex = 12;
            label8.Text = "REGISTRO DE NOTAS ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 714);
            Controls.Add(label8);
            Controls.Add(cmbAsignaturas);
            Controls.Add(cmbEstudiantes);
            Controls.Add(lvReprobados);
            Controls.Add(btnMostrarAprobadosReprobados);
            Controls.Add(lvAprobados);
            Controls.Add(groupBox2);
            Controls.Add(btnIngresarPersona);
            Controls.Add(cmbTipoPersona);
            Controls.Add(btnIngresarMatricula);
            Controls.Add(lvMatriculas);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtFechaNacimiento;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvMatriculas;
        private Button btnIngresarMatricula;
        private ComboBox cmbTipoPersona;
        private Button btnIngresarPersona;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtNota;
        private Label label20;
        private TextBox txtAsignatura;
        private ListView lvAprobados;
        private Button btnMostrarAprobadosReprobados;
        private ListView lvReprobados;
        private Label label7;
        private TextBox txtCodigo;
        private ComboBox cmbEstudiantes;
        private ComboBox cmbAsignaturas;
        private Label label8;
    }
}
