using Microsoft.VisualBasic;
using System.Linq;
using System.Windows.Forms;

namespace Actividad_Integradora_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Concesionario c;


        private void Mostrar(DataGridView pDGV, object pO)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pO;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                var dni = Interaction.InputBox("DNI: ");
                var p = new Persona(dni);
                // Verificanos que el DNI no exista.
                if (c.ValidarDNI(p)) throw new Exception("El DNI ya existe !!!!");

                var nombre = Interaction.InputBox("Nombre: ");
                var apellido = Interaction.InputBox("Apellido: ");
                p.Nombre = nombre;
                p.Apellido = apellido;
                c.AgregarPersona(p);


                Mostrar(dataGridView1, c.ListaDePersonas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Concesionario();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Mostrar(dataGridView2, c.ListaDeAutos());
            Mostrar(dataGridView4, c.ListaDeAutosyDuenos());
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay registros para borrar !!!");

                var dni = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                c.BorrarPersona(new Persona(dni));
                Mostrar(dataGridView1, c.ListaDePersonas());
                Mostrar(dataGridView4, c.ListaDeAutosyDuenos());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        


        private void button1_Click(object sender, EventArgs e) //btnAsignarDueño
        {
            try
            {
                if (dataGridView2.Rows.Count == 0) throw new Exception("No hay autos para asignar !!!");
                var auto = new Auto(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay personas para asignar !!!");
                var persona = new Persona(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                c.Asignar(persona, auto);
                dataGridView1_RowEnter(null, null); //SE USA CUANDO SE CAMBIA DE FILA EN OTRA GRILLA
                Mostrar(dataGridView4, c.ListaDeAutosyDuenos());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) //
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay registros de personas !!!");
                var dni = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Mostrar(dataGridView3, c.ListaDeAutosUnaPersona(new Persona(dni)));
            }
            catch (Exception)
            {


            }
        }
    }
}
