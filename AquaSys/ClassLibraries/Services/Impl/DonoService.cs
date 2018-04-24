
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Services;

namespace ClassLibraries.Services.Impl
{
    public class DonoService : ServiceBase<Dono>, IDonoService
    {
        public DonoService(IDonoRepository repository) : base(repository)
        {
        }
    }
}
            