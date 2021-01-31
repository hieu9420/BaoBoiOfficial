using BaoBoi.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaoBoi.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoiChucController : ControllerBase
    {
        private readonly LoiChucService _loichucService;
        public LoiChucController(LoiChucService loichucService)
        {
            _loichucService = loichucService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _loichucService.GetAll();
            return Ok(data);
        }
    }
}
