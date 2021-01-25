using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPI.API.Pruebas_Borrar
{
    public class FucionAnonima
    {
        private readonly Func<int, int, int> multiplicar2nros = (x, y) => x * y;
        public int Nro1Xnro2(int pUno, int pDos)
        {
            return multiplicar2nros(pUno, pDos);
        }
    }

}
