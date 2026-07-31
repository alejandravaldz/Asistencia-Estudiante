namespace Asistencia_Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
       
    string Asistencia;
    if (chbo_Presente.Checked)
    {
        Asistencia = "Presente";
    }
    else
    {
        Asistencia = "Ausente";
    }
    lst_Asistencia.Items.Add(txt_Nombre.Text + "  " + Asistencia);
    txt_Nombre.Clear();

    chbo_Presente.Checked = false;
    chbox_Ausencia.Checked = false;
}


        private void btn_Resumen_Click(object sender, EventArgs e)
 {
     int presentes = 0;
     int ausentes = 0;

     foreach (var item in lst_Asistencia.Items)
     {
         string registro = item.ToString();
         if (registro.Contains("Presente"))
             presentes++;
         else
             ausentes++;
     }

     MessageBox.Show($"Resumen de asistencia:\nPresentes: {presentes}\nAusentes: {ausentes}");
 }

 

         private void btn_Salir_Click(object sender, EventArgs e)
 {
      Close();
 } 
    }
}
