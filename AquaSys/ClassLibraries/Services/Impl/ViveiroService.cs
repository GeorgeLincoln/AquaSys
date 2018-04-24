
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Services.Impl
{
    public class ViveiroService : ServiceBase<Viveiro>, IViveiroService
    {
        public ViveiroService(IViveiroRepository repository) : base(repository)
        {
        }
    }
}
            