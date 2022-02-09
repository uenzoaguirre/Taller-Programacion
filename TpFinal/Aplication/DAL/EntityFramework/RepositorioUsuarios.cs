using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication.DAL.EntityFramework
{
    public class RepositorioUsuarios : Repository<Usuario, BibliotecaDbContext>, IRepositorioUsuarios
    {
        public RepositorioUsuarios (BibliotecaDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}