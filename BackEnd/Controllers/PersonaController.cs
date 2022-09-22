using AutoMapper;
using BackEnd.Data;
using BackEnd.DTOs;
using BackEnd.DTOs.Persona;
using BackEnd.Helpers;
using BackEnd.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clase03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PersonaController : ControllerBase
    {
        private readonly CineContext context;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public PersonaController(CineContext context, IMapper mapper, IConfiguration configuration)
        {
            this.context = context;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        [HttpGet("{id:int}", Name ="GetPersona")]
        [ProducesResponseType(typeof(PersonaDTO),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PersonaDTO>> Get(int id)
        {
            try
            {
                var persona = await context.Personas
                    .FirstOrDefaultAsync(x=> x.Id==id);

                if (persona == null)
                {
                    return new ResponseError(StatusCodes.Status404NotFound, "El recurso no Existe").GetObjectResult();

                    //var res = new ResponseError(StatusCodes.Status404NotFound, "El recurso no Existe");
                    //return StatusCode(res.statuCode, res);
                }
                var personaDTO = mapper.Map<PersonaDTO>(persona);
                return Ok(personaDTO);
            }
            catch (Exception ex)
            {
                return new ResponseError(StatusCodes.Status400BadRequest, ex.Message).GetObjectResult();
                //return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonaInsertarDTO personaDTO)
        {
            try
            {
                var persona = mapper.Map<Persona>(personaDTO);
                
                context.Personas.Add(persona);
                await context.SaveChangesAsync();

                var dtoLectura = mapper.Map<PersonaDTO>(persona);
                return new CreatedAtRouteResult("GetUsuario", new { id = persona.Id }, dtoLectura);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Login")]
        [AllowAnonymous]

        public async Task<ActionResult<UserToken>> Login([FromBody] UsuarioLoginDTO loginDTO)
        {
            try
            {
                var pass = Encrypt.GetSHA256(loginDTO.Password);

                var usuario = await context.Usuarios
                    .Include(x => x.Rol)
                    .FirstOrDefaultAsync(x => x.UserName == loginDTO.UserName && x.Password == pass && x.Estado);
                if (usuario == null)
                    return BadRequest("El usuario ò contraseña ingresada son incorrectas");

                var userdto = mapper.Map<UsuarioDTO>(usuario);

                var token = ConstruirToken(userdto);


                return Ok(token);


                

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        private UserToken ConstruirToken(UsuarioDTO usuario)
        {

            var claims = new List<Claim>()
            { 
                new Claim(ClaimTypes.Name,usuario.Nombre),
                new Claim(ClaimTypes.Role,usuario.RolCod),

            };

            claims.Add (new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiracion = DateTime.UtcNow.AddDays(2);

            JwtSecurityToken token = new JwtSecurityToken(
                   issuer: null,
                   audience: null,
                   claims: claims,
                   expires : expiracion,
                    signingCredentials: creds);


            return new UserToken()
            { 
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                 Expiracion = expiracion,
            };
  

                

        }
            

         
       

    }
}
