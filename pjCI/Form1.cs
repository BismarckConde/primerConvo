namespace pjCI
{
    public partial class Form1 : Form
    {
        private List<Persona> personas = new List<Persona>();
        private List<Matricula> matriculas = new List<Matricula>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarMatricula_Click(object sender, EventArgs e)
        {

            // Obtener datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            if (cmbTipoPersona.SelectedItem.ToString() == "Profesor")
            {
                int codigoProfesor = Convert.ToInt32(txtCodigo.Text);
                Profesor profesor = new Profesor
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaNacimiento = fechaNacimiento,
                    Direccion = direccion,
                    Telefono = telefono,
                    CodigoProfesor = codigoProfesor
                };

                personas.Add(profesor);
            }
            else if (cmbTipoPersona.SelectedItem.ToString() == "Estudiante")
            {
                int codigoEstudiante = Convert.ToInt32(txtCodigo.Text);
                Estudiante estudiante = new Estudiante
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaNacimiento = fechaNacimiento,
                    Direccion = direccion,
                    Telefono = telefono,
                    CodigoEstudiante = codigoEstudiante
                };

                personas.Add(estudiante);
            }

            // Limpiar los campos después de ingresar una persona
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            txtNombres.Clear();
            txtApellidos.Clear();
            txtFechaNacimiento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCodigo.Clear();
            txtAsignatura.Clear();
            txtNota.Clear();

            // Actualizar la lista de estudiantes en el ComboBox
            cmbEstudiantes.DataSource = null;
            cmbEstudiantes.DataSource = personas.OfType<Estudiante>().ToList();
        }

        private void btnMostrarAprobadosReprobados_Click(object sender, EventArgs e)
        {
            // Obtener la asignatura seleccionada
            string asignaturaSeleccionada = cmbAsignaturas.SelectedItem.ToString();

            // Filtrar estudiantes aprobados y reprobados por la asignatura
            var estudiantesAprobados = personas
                .OfType<Estudiante>()
                .Where(est => est.Matriculas.Any(mat => mat.Asignatura == asignaturaSeleccionada && mat.Nota >= 60))
                .ToList();

            var estudiantesReprobados = personas
                .OfType<Estudiante>()
                .Where(est => est.Matriculas.All(mat => mat.Asignatura != asignaturaSeleccionada || mat.Nota < 60))
                .ToList();

            // Mostrar resultados en controles ListView
            MostrarEstudiantesEnListView(lvAprobados, estudiantesAprobados);
            MostrarEstudiantesEnListView(lvReprobados, estudiantesReprobados);
        }

        private void MostrarEstudiantesEnListView(ListView listView, List<Estudiante> estudiantes)
        {
            // Limpiar el ListView antes de mostrar los resultados
            listView.Items.Clear();

            // Mostrar estudiantes en el ListView
            foreach (Estudiante estudiante in estudiantes)
            {
                ListViewItem item = new ListViewItem(new[] { estudiante.Nombres, estudiante.Apellidos });
                listView.Items.Add(item);
            }
        }

        private void btnIngresarPersona_Click(object sender, EventArgs e)
        {

        }
    }
}
