using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartamentoVehicular d = new DepartamentoVehicular();
        private void bAgregar_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            Persona p;
            if(agregar.ShowDialog() == DialogResult.OK)
            {
                string nombre = agregar.tBnombre.Text;
                try
                {
                    int dni = Convert.ToInt32(agregar.tBdni.Text);
                    p = new Persona(dni, nombre);
                    string serie = agregar.tBserie.Text;
                    string patente = agregar.tBpatente.Text;
                    d.RegistrarVehiculo(p, patente, serie);
                }
                catch(RangoDniIncorrectoException ex)
                {
                    MessageBox.Show("Error\n" + ex.Message);
                }
                catch(FormatoPatenteNoValidaException ex)
                {
                    MessageBox.Show("Error\n" + ex.Message);
                }
            }
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < d.CantidadRegistros; i++)
            {
                RegistroVehiculo a = d.VerRegistro(i);
                lBregistros.Items.Add(a.VerDetalle());
            }
        }
    }
}
