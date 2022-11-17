using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interface
{
    public interface IRoleRepositories
{
        List<Role> GetAll();

        Role GetById(int id);

        Role Add(int id, string name, string description);

        Role Update(Role role);

        Role Delete(int id);
    }
}
