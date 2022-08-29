using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.IO.Ports;

namespace controlador_final
{
    class Vigilante
    {
        

        public void encender(ref SerialPort SpPuertos,ref bool Encendido,ref string strBufferIn)
        {
            Encendido = true;
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
                try
                {
                    SpPuertos.DiscardInBuffer();
                    //strBufferIn = TxtDatosAEnviar.Text;
                    SpPuertos.Write(strBufferIn);
                }
                catch (Exception exc)
                {
                   // MessageBox.Show(exc.Message.ToString());
                }


            }
        }

       
    }
}
