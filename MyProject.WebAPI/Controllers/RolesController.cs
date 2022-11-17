using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System.Data;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleRepository _roleRepository;

        public RolesController()
        {
            var mock = new MockContext();
            _roleRepository = new RoleRepository(mock);
        }
        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }
        [HttpPut]
        public Role put(Role role)
        {
            return _roleRepository.Update(role);
        }
        [HttpPost]
        public Role Post(Role role)
        {
            return _roleRepository.Add(role.Id,role.Name,role.Description);
        }
        [HttpDelete]
        public Role Delete(int id) 
        {
            return _roleRepository.Delete(id);
        }  
        
    }
}
