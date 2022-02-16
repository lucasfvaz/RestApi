using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Controllers
{
    [Route("cliente")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente ApplicationServiceCliente)
        {
            _applicationServiceCliente = ApplicationServiceCliente;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
