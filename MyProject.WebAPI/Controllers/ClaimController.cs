using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Repositories;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly ClaimRepository _claimrepository;
        public ClaimController()
        {
            var mock = new MockContext();
            _claimrepository = new ClaimRepository(mock);
        }
        [HttpGet]
        public List<Claim> Get()
        {
            return _claimrepository.GetAll();
        }

        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            return _claimrepository.GetById(id);
        }
        [HttpPut]
        public Claim put(Claim claim)
        {
            return _claimrepository.Update(claim);
        }
        [HttpPost]
        public Claim Post(Claim claim)
        {
            return _claimrepository.Add(claim.Id,claim.RoleId, claim.PermissionId, claim.Policy);
        }
        [HttpDelete]
        public Claim Delete(int id)
        {
            return _claimrepository.Delete(id);
        }
    }
}
