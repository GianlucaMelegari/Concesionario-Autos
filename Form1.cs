using Microsoft.VisualBasic;

namespace Actividad_Integradora_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Concesionario c;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            c.AgregarPersona(new Persona(Interaction.InputBox("DNI: "), Interaction.InputBox("Nombre: "), Interaction.InputBox("Apellido: ")));
            MostrarGrilla(dataGridView1, c.ListaDePersonas());
        }

        private void MostrarGrilla(DataGridView pDGV, object pO)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pO;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Concesionario();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var DNI = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var Nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var Apellido = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                c.BorrarPersona(new Persona (DNI, Nombre, Apellido));
                MostrarGrilla(dataGridView1, c.ListaDePersonas());
            }

        }
    }
}
