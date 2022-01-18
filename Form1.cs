using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AxieCalculator
{
    public partial class FormularioControl : Form
    {
        public FormularioControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //reloj 1/9/2021 00:00:0030/9/2021 22:47:46Cristian.txt
            DateTime date1 = new DateTime();
            date1 = DateTime.Now; 
            lblDateTime1.Text = date1.ToString("MM/dd/yyyy HH: mm");
            //valores en cero
            txtUsuario.Text = "";
            txtCuenta.Text = "";
            dateTimePicker1.Value = new DateTime(2021, 7, 3, 0, 0, 0);
            dateTimePicker2.Value = DateTime.Now;
            tbIngresoLogrado.Text = "0";
            tbSlpMinimoDiario.Text = "0";
            cbPorcentaje.SelectedIndex = 0;
            lblDias.Text = "";
            lblPromedio.Text = "";
            lblSItuacion.Text = "";
            lblSlpBecario.Text = "";
            lblSlpDiferencia.Text = "";
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            int IngresoLogrado, IngresoMinimo, dias=1, minimoSlp;
            double porcBec = 0;
            DateTime date1, date2;
            try
            {

                //calculo fechas

                date1 = dateTimePicker1.Value;
                date2 = dateTimePicker2.Value;
                dias = (date2 - date1).Days;
                if (dias <= 0)
                {
                    MessageBox.Show("El rango de valores ingresados en fecha es menor que 1. Por favor ingrese un rango de fechas valido", "Rango de fecha incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                lblDias.Text = Convert.ToString(dias);

                //calculo slp y situación correspondiente

                IngresoLogrado = Convert.ToInt32(tbIngresoLogrado.Text);
                IngresoMinimo = Convert.ToInt32(tbSlpMinimoDiario.Text);
                //                if ((tbIngresoLogrado.Text == "") || (tbSlpMinimoDiario.Text == "")) MessageBox.Show("Falta completar los datos numericos del SLP", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if ((IngresoMinimo == 0) || (IngresoLogrado == 0)) MessageBox.Show("Falta completar los datos numericos del SLP", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                {
                    minimoSlp = IngresoMinimo * dias;
                    int resultadoDiferencia = IngresoLogrado - minimoSlp;
                    lblSlpDiferencia.Text = resultadoDiferencia.ToString();

                    if (resultadoDiferencia >= 0) lblSItuacion.Text = "MINIMO CUMPLIDO";
                    else lblSItuacion.Text = "MINIMO INCUMPLIDO";


                    if (cbPorcentaje.SelectedIndex == 0) MessageBox.Show("No se ha seleccionado el porcentaje correspondiente al becario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    else
                    {
                        //porcentaje becario y su slp
                        string cbPorcVar = cbPorcentaje.Text;
                        switch (cbPorcVar)
                        {
                            case "%10":
                                porcBec = 0.1;
                                break;
                            case "%20":
                                porcBec = 0.2;
                                break;
                            case "%30":
                                porcBec = 0.3;
                                break;
                            case "%40":
                                porcBec = 0.4;
                                break;
                            case "%50":
                                porcBec = 0.5;
                                break;
                            case "%60":
                                porcBec = 0.6;
                                break;
                            case "%70":
                                porcBec = 0.7;
                                break;
                            case "%80":
                                porcBec = 0.8;
                                break;
                            case "%90":
                                porcBec = 0.9;
                                break;
                        }
                        lblSlpBecario.Text = Convert.ToString(porcBec * IngresoLogrado);
                    }
                }
                //slp promedio diario

                lblPromedio.Text = Convert.ToString(IngresoLogrado / dias);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Falta completar los datos numericos del SLP. Por favor completá esa casilla para poder realizar los cálculos necesarios." + ex.InnerException,"Error", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nombreUsr = Convert.ToString(txtUsuario.Text);
            String cuentaUsr = Convert.ToString(txtCuenta.Text);
            DateTime fileInitDate = dateTimePicker1.Value;
            DateTime fileEndDate = dateTimePicker2.Value;
            String fechaIn = fileInitDate.ToString("MM-dd-yy");
            String fechaFin = fileEndDate.ToString("MM-dd-yy");

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"c:\axiescholar";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = fechaIn + "_" + fechaFin + "_" + nombreUsr + "_" + cuentaUsr + ".txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write("Período: " + fechaIn + " al " + fechaFin + "\n");
                sw.Write("Usuario: " + txtUsuario.Text + "\n");
                sw.Write("Cuenta: " + txtCuenta.Text + "\n");
                sw.Write("Ingreso logrado: " + tbIngresoLogrado.Text + "\n");
                sw.Write("Ingreso mínimo diario: " + tbSlpMinimoDiario.Text + "\n");
                sw.Write("Porcentaje: " + cbPorcentaje.Text + "\n");
                sw.Write("Días jugados: " + lblDias.Text + "\n");
                sw.Write("Promedio diario: " + lblPromedio.Text + "\n");
                sw.Write("Situación: " + lblSItuacion.Text + "\n");
                sw.Write("SLP para el becario: " + lblSlpBecario.Text + "\n");
                sw.Write("Diferencia de SLP: " + lblSlpDiferencia.Text + "\n");
                sw.Close();
                fileStream.Close();
                MessageBox.Show($"¡Archivo salvado correctamente!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = saveFileDialog.FileName;
            }
            else MessageBox.Show("El archivo no fue guardado", "No guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtCuenta.Text = "";
            dateTimePicker1.Value = new DateTime(2021, 7, 3, 0, 0, 0);
            dateTimePicker2.Value = DateTime.Now;
            tbIngresoLogrado.Text = "0";
            tbSlpMinimoDiario.Text = "0";
            cbPorcentaje.SelectedIndex = 0;
            lblDias.Text = "";
            lblPromedio.Text = "";
            lblSItuacion.Text = "";
            lblSlpBecario.Text = "";
            lblSlpDiferencia.Text = "";

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1, date2;
            int dateChecker;
            date1 = dateTimePicker1.Value;
            date2 = dateTimePicker2.Value;
            try
            {
                dateChecker = 2 / ((date2 - date1).Days);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("El rango de valores ingresados en fecha es menor que 1.Por favor ingrese un rango de fechas valido","Rango de fecha incorrecto", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1, date2;
            int dateChecker;
            date1 = dateTimePicker1.Value;
            date2 = dateTimePicker2.Value;
            try
            {
                dateChecker = 2/((date2 - date1).Days);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("El rango de valores ingresados en fecha es menor que 1.Por favor ingrese un rango de fechas valido", "Rango de fecha incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtb_Only_Num1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtb_Only_Num2(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

        }
    }
}
