namespace TP2Programacion
{
    public partial class Form1 : Form
    {

        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Con estos codigos adicionamos un nuevo renglon

            int n = dtgvLista.Rows.Add();

            // Colocamos la informacion

            dtgvLista.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvLista.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvLista.Rows[n].Cells[2].Value = txtPrecio.Text;

            //Limpiamos las datos cargados

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";




        }

        private void dtgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aqui seleccionamos filas; e = Envento; RowIndex = Indica la fila

            n = e.RowIndex;
            if (n != -1)
            {
                labelInformacion.Text = (string)dtgvLista.Rows[n].Cells[1].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvLista.Rows.RemoveAt(n);


            }
        }




    }
}