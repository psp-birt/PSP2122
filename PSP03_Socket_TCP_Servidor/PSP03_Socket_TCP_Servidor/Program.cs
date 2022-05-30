﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace PSP03_SocketClass_TCP_Servidor
{
    public class Servidor_Sincrono
    {
        public static int Main(String[] args)
        {
            Server servidor = null;

            try
            {
                servidor = new Server();
                servidor.esperandoConexion();
                string texto = servidor.recibiendoInfo();
                Console.WriteLine(texto);
                servidor.transfiendoinfo();
                

            }
            catch (SocketException se)
            {
                Console.WriteLine("Cliente ha tenido problemas  de SocketException : {0}", se.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cliente ha tenido problemas al establecer la conexión con el servidor");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("\nPresiona intro para continuar...");
                Console.Read();
                servidor.cerrarServidor();
            }
         
            

            return 0;
        }




    }
}