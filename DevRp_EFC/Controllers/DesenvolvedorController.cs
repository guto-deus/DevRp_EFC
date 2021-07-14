using DevRp_EFC.Domains;
using DevRp_EFC.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRp_EFC.Controllers
{
    [Route("api/[controller]")]
    public class DesenvolvedorController : ControllerBase
    {
        protected IDesenvolvedorService _desenvolvedorService;

        public DesenvolvedorController(IDesenvolvedorService desenvolvedorService)
        {
            _desenvolvedorService = desenvolvedorService;
        }
        [HttpPost]
        public IActionResult Inserir([FromBody] Desenvolvedor dev)
        {
            var response = _desenvolvedorService.Inserir(dev);
            return Ok(dev);
        }
        [HttpGet("listar")]
        public IActionResult Listar()
        {
            var response = _desenvolvedorService.Listar();
            return Ok(response);
        }
        [HttpDelete("remover")]
        public IActionResult Remover(Desenvolvedor id)
        {
            var request = _desenvolvedorService.Remover(id);
            return Ok(request);
        }
    }
}