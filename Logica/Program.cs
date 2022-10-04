using System;
using Entidades;
using Vista;

namespace Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuarios = new Usuario();
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
