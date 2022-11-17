using MyProject.Repositories.Entities;
using MyProject.Repositories.Interface;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepositories
    {
        private readonly IContext _context;
        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public Claim Add(int id, int roleid, int permiision, EPolicy policy)
        {
           _context.Claims.Add(new Claim { Id = id, RoleId = roleid, PermissionId = permiision, Policy = policy });
            return _context.Claims.First(r => r.Id == id); ;
        }

        public Claim Delete(int id)
        {
            Claim r = _context.Claims.First(p1 => p1.Id == id);
            _context.Claims = _context.Claims.Where(p1 => p1.Id != id).ToList();
            return r;
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            return _context.Claims.First(r => r.Id == id);
        }

        public Claim Update(Claim claim)
        {
            Claim r = _context.Claims.First(p => p.Id == claim.Id);
            r.RoleId = claim.RoleId;
            r.PermissionId = claim.PermissionId;
            r.Policy = claim.Policy;
            return r;
        }
    }
}
