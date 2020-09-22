using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DesafioMutant.API.Data;
using DesafioMutant.API.Helpers;
using DesafioMutant.API.Models;
using DesafioMutant.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioMutant.API.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        public readonly IRepository _repo;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="mapper"></param>
        public HomeController(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        /// <summary>
        /// Método Responsável por Baixar os Dados de Uma API externa.
        /// </summary>
        /// <returns></returns>
        [HttpGet("baixar-dados")]
        public async Task<IActionResult> GetData()
        {
            List<UserDTO> users = await UserService.getUsers();

            return Ok(users);
        }

        /// <summary>
        /// Método Reponsável por Fazer as devidas transformações e Inserir os registros no Banco de Dados.
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost("salvar-dados")]
        public IActionResult SaveData(List<UserDTO> users)
        {
            if (users.Count == 0) return BadRequest("Nenhum Parâmetro foi Informado.");

            users = UserHelper.FilterUsersInSuite(users);

            foreach (UserDTO user in users)
            {
                _repo.Add(_mapper.Map<User>(user));
                _repo.Add(_mapper.Map<Address>(user));
                _repo.Add(_mapper.Map<Contact>(user));
            }

            if (_repo.Save())
            {
                return Ok("Salvo com Sucesso!");
            }

            return BadRequest("Algo deu Errado");
        }
    }
}
