using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica240921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Alumno object1 = new Alumno(1, "Daniel", "Castillo", 18);

            ////alumno.IdStudent = 001;
            ////alumno.NameStudent = " Daniel Enrique ";
            ////alumno.LastNameStudent = "Zaldaña Castillo ";
            ////alumno.AgeStudent = 18;

            ////Mostramos los datos 

            //MessageBox.Show(object1.IdStudent + object1.NameStudent + object1.LastNameStudent + object1.AgeStudent);
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno(tbId.Text, tbName.Text, tbLastName.Text, tbAge.Text);

            listBox1.Items.Add(alumno.getinfoStudent());

            tbId.Text = "";
            tbName.Text = "";
            tbLastName.Text = "";
            tbAge.Text = "";

            tbId.Focus();


        }
    }
}
