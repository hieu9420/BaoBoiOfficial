using BaoBoi.Application.Dtos;
using BaoBoi.Application.Interfaces;
using BaoBoi.Data.EF;
using Microsoft.AspNetCore.Authorization;
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

    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        public readonly BaoBoiDbContext _context;

        public UserController(IUserService userService, BaoBoiDbContext context)
        {
            _userService = userService;
            _context = context;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromForm] LoginRequest model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var resultToken = await _userService.Authencate(model);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("User Name Or Password Incorrect!");
            }
            return Ok(new { token = resultToken });
        }
    }
}
