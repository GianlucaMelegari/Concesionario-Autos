using Microsoft.VisualBasic;
using System.Linq;

namespace Actividad_Integradora_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c = new Concesionario();
        }

        Concesionario c;


        private void MostrarGrilla(DataGridView pDGV, object pO)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pO;
        }

        //PERSONA
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            c.AgregarPersona(new Persona(Interaction.InputBox("DNI: "), Interaction.InputBox("Nombre: "), Interaction.InputBox("Apellido: ")));
            MostrarGrilla(dataGridView1, c.ListaDePersonas());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //c = new Concesionario();
            //p = new Persona();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var DNI = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var Nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var Apellido = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                c.BorrarPersona(new Persona(DNI, Nombre, Apellido));
                MostrarGrilla(dataGridView1, c.ListaDePersonas());
            }

        }
        //AUTO
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            string dniDueño = Interaction.InputBox("Ingrese el DNI del dueño: ");
            Persona dueño = c.ListaDePersonas().Find(dueño => dueño.DNI == dniDueño);

            if (dueño != null)
            {
                var nuevoAuto = new Auto(
                    Interaction.InputBox("Patente: "),
                    Interaction.InputBox("Marca: "),
                    Interaction.InputBox("Modelo: "),
                    Interaction.InputBox("Año: "),
                    Convert.ToDecimal(Interaction.InputBox("Precio: ")),
                    dueño
                );

                c.AgregarAuto(nuevoAuto);
                dueño.AgregarAuto(nuevoAuto);

                MostrarGrilla(dataGridView2, c.ListaDeAutos());
            }
            else
            {
                MessageBox.Show("No se encontró un dueño con el DNI ingresado.");
            }

            /*if (dataGridView1.SelectedRows.Count > 0)
            {
                var dueño = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;

                var nuevoAuto = new Auto(
                    Interaction.InputBox("Patente: "),
                    Interaction.InputBox("Marca: "),
                    Interaction.InputBox("Modelo: "),
                    Interaction.InputBox("Año: "),
                    Convert.ToDecimal(Interaction.InputBox("Precio: ")),
                    dueño
                );
                c.AgregarAuto(nuevoAuto);
                dueño.AgregarAuto(nuevoAuto);

                //c.AgregarAuto(new Auto(Interaction.InputBox("Patente: "), Interaction.InputBox("Marca: "), Interaction.InputBox("Modelo: "), Interaction.InputBox("Año: "), Convert.ToInt32(Interaction.InputBox("Precio: "), dueñoSeleccionado)));
                MostrarGrilla(dataGridView2, c.ListaDeAutos());
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un dueño antes de agregar un auto.");

            }*/
        }

        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            var Patente = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            var Marca = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            var Modelo = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            var Año = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            var Precio = Convert.ToDecimal(dataGridView2.SelectedRows[0].Cells[4].Value);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Persona dueñoSeleccionado = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                Auto autoAEliminar = new Auto(Patente, Marca, Modelo, Año, Precio, dueñoSeleccionado);

                c.BorrarAuto(autoAEliminar);
                MostrarGrilla(dataGridView2, c.ListaDeAutos());
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un auto.");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Persona personaSeleccionada = (Persona)dataGridView1.SelectedRows[0].DataBoundItem;
                List<Auto> autosDeLaPersona = c.ListaDeAutos().Where(a => a.Dueño.DNI == personaSeleccionada.DNI).ToList();

                MostrarGrilla(dataGridView3, autosDeLaPersona);
            }
        }
    }
}
