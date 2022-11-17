using MyProject.Repositories.Entities;
using MyProject.Repositories.Interface;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class PremissionRepository : IPremission
    {
        private readonly IContext _context;
        public PremissionRepository(IContext context)
        {
            _context = context;
        }
        public Permission Add(int id, string name, string description)
        {

            _context.Permissions.Add(new Permission { Id = id, Name = name, Description = description });
            return _context.Permissions.First(r => r.Id == id); ;
        }

        public Permission Delete(int id)
        {
           Permission r = _context.Permissions.First(p1 => p1.Id == id);
            _context.Permissions = _context.Permissions.Where(p1 => p1.Id != id).ToList();
            return r;
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            return _context.Permissions.First(r => r.Id == id);
        }

        public Permission Update(Permission Permission)
        {
            Permission r = _context.Permissions.First(p => p.Id == Permission.Id);
            r.Name = Permission.Name;
            r.Description = Permission.Description;
            return r;
        }
    }
}
