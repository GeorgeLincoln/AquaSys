
using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraries.Services;

namespace ClassLibraries.Services.Impl
{
    public class SensorService : ServiceBase<Sensor>, ISensorService
    {
        public SensorService(ISensorRepository repository) : base(repository)
        {
        }
    }
}
            