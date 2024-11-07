namespace Modularidad
{
    public partial class Form1 : Form
    {
        string nombreEmpleado;
        double sueldoDiario;
        int diasTrabajados;


        public Form1()
        {
            InitializeComponent();
        }

        public void LeerDatos()
        {
            nombreEmpleado = txtNombre.Text;
            diasTrabajados = int.Parse(txtDiasTrabajados.Text);
            sueldoDiario = double.Parse(txtSueldoDiario.Text);
        }

        public double CalculaSueldo()
        {
            return sueldoDiario * diasTrabajados;
        }

        public void Limpiar()
        {
            txtDiasTrabajados.Clear();
            txtSueldoDiario.Clear();
            txtNombre.Clear();
        }

        public void MostrarDatos()
        { 
            ListViewItem fila= new ListViewItem(nombreEmpleado);
            fila.SubItems.Add(diasTrabajados.ToString());
            fila.SubItems.Add(sueldoDiario.ToString());
            fila.SubItems.Add(CalculaSueldo().ToString());
            lsvDatos.Items.Add(fila);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerDatos();
            MessageBox.Show("Dato capturado");
            Limpiar();
            MostrarDatos();
        }

        
    }
}
