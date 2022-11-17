using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Repositories;


namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly PremissionRepository _permissioneRepository;

        public PermissionController()
        {
            var mock = new MockContext();
            _permissioneRepository = new PremissionRepository(mock);
        }
        [HttpGet]
        public List<Permission> Get()
        {
            return _permissioneRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Permission GetById(int id)
        {
            return _permissioneRepository.GetById(id);
        }
        [HttpPut]
        public Permission put(Permission permission)
        {
            return _permissioneRepository.Update(permission);
        }
        [HttpPost]
        public Permission Post(Role role)
        {
            return _permissioneRepository.Add(role.Id, role.Name, role.Description);
        }
        [HttpDelete]
        public Permission Delete(int id)
        {
            return _permissioneRepository.Delete(id);
        }
    }
}
