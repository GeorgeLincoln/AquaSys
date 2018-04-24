
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Services.Impl
{
    public class TrabalhadorSetorService : ServiceBase<TrabalhadorSetor>, ITrabalhadorSetorService
    {
        public TrabalhadorSetorService(ITrabalhadorSetorRepository repository) : base(repository)
        {
        }
    }
}
            