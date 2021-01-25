using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaAPI.API.Pruebas_Borrar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumerosController : ControllerBase
    {
        private readonly FucionAnonima iFA;
        public NumerosController(FucionAnonima pFA)
        {
            iFA = pFA;
        }
        [HttpPost]
        public int Multiplicar(int pUno, int pDos)
        {
            return iFA.Nro1Xnro2(pUno, pDos);
        }
    }
}
