using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace controlador_final
{
    public partial class Form1 : Form
    {
        private delegate void DelegadoAcceso(String accion);
        private bool Encendido=false;
        private Vigilante a = new Vigilante();

        private string strBufferIn;
        private string strBufferOut;
        public Form1()
        {
            InitializeComponent();
        }
        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            TxtDatosRecividos.Text = strBufferIn;
        }

        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_delegadoAcceso;
            Var_delegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_delegadoAcceso, arg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnEnviarDatos.Enabled = false;

        }

        private void BtnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles=SerialPort.GetPortNames();

            CboPuertos.Items.Clear();

            foreach (string Puerto in PuertosDisponibles)
            {
                CboPuertos.Items.Add(Puerto);
            }
            if (CboPuertos.Items.Count > 0)
            {
                MessageBox.Show("SELECCIONAR EL PUERTO DE TRABAJO");
                BtnConectar.Enabled=true;
            }
            else
            {
                MessageBox.Show("NINGUN PUERTO DETECTADO");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "      ";
                strBufferIn = "";
                strBufferOut = "";
                BtnConectar.Enabled = false;
                BtnEnviarDatos.Enabled = false;

            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnConectar.Text == "CONECTAR")
                {
                    SpPuertos.BaudRate=Int32.Parse(CboBoudRate.Text);
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = CboPuertos.Text;

                    try
                    {
                        SpPuertos.Open();
                        BtnConectar.Text = "DESCONECTAR";
                        BtnEnviarDatos.Enabled = true;
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }
                }
                else if(BtnConectar.Text == "DESCONECTAR")
                {
                    SpPuertos.Close();
                    BtnConectar.Text = "CONECTAR";
                    BtnEnviarDatos.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void BtnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                SpPuertos.DiscardInBuffer();
                strBufferIn=TxtDatosAEnviar.Text; 
                SpPuertos.Write(strBufferIn);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(SpPuertos.ReadExisting());
            /*string Data_in = SpPuertos.ReadExisting();
            MessageBox.Show(Data_in);
            TxtDatosRecividos.Text = Data_in;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*byte dato = 0;
           
            while (Encendido == false)
            {
                Thread.Sleep(100);
                try
            {
                SpPuertos.DiscardInBuffer();
                strBufferIn="0"; 
                SpPuertos.Write(strBufferIn);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

            }*/
            //Enviar();

            strBufferIn = TxtDatosAEnviar.Text;
            a.encender(ref SpPuertos, ref Encendido, ref strBufferIn);


        }
        private void Enviar()
        {
            //for(int i = 0; i < 1000; i++)
           /* Encendido = true;
            while(Encendido)
            {
                Thread.Sleep(10);
                try
                {
                    SpPuertos.DiscardInBuffer();
                    strBufferIn = TxtDatosAEnviar.Text;
                    SpPuertos.Write(strBufferIn);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message.ToString());
                }


            }*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encendido = false;
        }
    }
}
