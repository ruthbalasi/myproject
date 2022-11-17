using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Claim = MyProject.Repositories.Entities.Claim;

namespace MyProject.Repositories.Interface
{
   public interface IClaimRepositories
{
        List<Claim> GetAll();

        Claim GetById(int id);

        Claim Add(int id,int roleid, int permiision,EPolicy policy);

        Claim Update(Claim claim);

        Claim Delete(int id);
    }
 
}
