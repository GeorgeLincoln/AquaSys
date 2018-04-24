using ClassLibraries.Models;
using ClassLibraries.Repositorios;
using ClassLibraries.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraries.Repositorios
{
    public class SensorRepository : RepositoryBase<Sensor>, ISensorRepository
    {
        public SensorRepository(DataContext context, bool saveChanges = true) : base(context, saveChanges)
        {
        }
    }
}