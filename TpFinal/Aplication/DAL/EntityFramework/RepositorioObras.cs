using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication.DAL.EntityFramework
{
    public class RepositorioObras : Repository<Obra, BibliotecaDbContext>, IRepositorioObras
    {
        public RepositorioObras (BibliotecaDbContext pDbContext) : base(pDbContext)
        {

        }
    }
}