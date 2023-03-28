using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_7
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios  = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Datos> listData = new List<Datos>();
        List<Datos> listtemp = new List<Datos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarPropietarios();
            cargarPropiedades();
            llenarData();
        }

        private void cargarPropietarios()
        {
            string fileName = @"..\..\Propietarios.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Propietario protemp = new Propietario();
                protemp.Dpi = reader.ReadLine();
                protemp.Nombre = reader.ReadLine();
                protemp.Apellido = reader.ReadLine();

                propietarios.Add(protemp);
            }
            reader.Close();
        }

        private void cargarPropiedades()
        {
            string fileName = @"..\..\Propiedades.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Propiedad propte = new Propiedad();
                propte.NumCasa = int.Parse(reader.ReadLine());
                propte.Dpi = reader.ReadLine();
                propte.Cuota = int.Parse(reader.ReadLine());

                propiedades.Add(propte);
            }
            reader.Close();
        }

        private void llenarData()
        {
            foreach(var temp in propiedades) {
                Datos datte = new Datos();
                Propietario prote = propietarios.Find(u => u.Dpi == temp.Dpi);
                datte.Nombre = prote.Nombre;
                datte.Apellido = prote.Apellido;
                datte.NoCasa = temp.NumCasa;
                datte.Cuota = temp.Cuota;

                listData.Add(datte);
            }
            dataGridViewCasas.DataSource = null;
            dataGridViewCasas.DataSource = listData;
            dataGridViewCasas.Refresh();
        }

        private void buttonOrdMan_Click(object sender, EventArgs e)
        {
            listData = listData.OrderBy(u => u.Cuota).ToList();
            dataGridViewCasas.DataSource = null;
            dataGridViewCasas.Refresh();
            dataGridViewCasas.DataSource = listData;
            dataGridViewCasas.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baj = "";
            string alt = "";
            for (int i = 0; i < 3; i++)
                baj += listData[i].Cuota.ToString() + "\n";
            for (int i = listData.Count-3; i <= listData.Count - 1; i++)
                alt += listData[i].Cuota.ToString() + "\n";
            MessageBox.Show("3 Cuotas más bajas: \n" + baj + "3 Cuotas más altas: \n" + alt);
        }

        private void buttonCuotaMayor_Click(object sender, EventArgs e)
        {
            listtemp = listData.OrderBy(a => a.Cuota).ToList();
            int ind = listData.Count - 1;
            MessageBox.Show("El propietario con la mayor cuota de mantenimiento es: \n" + listData[ind].Nombre + " " + listData[ind].Apellido + "\n" + "Con un total de: Q." + listData[ind].Cuota.ToString() +".00");
        }
    }
}
