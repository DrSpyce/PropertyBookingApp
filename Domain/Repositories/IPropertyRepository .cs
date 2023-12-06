using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetProperties { get; }
        IEnumerable<Property> GetAvailableProperties(DateTime start, DateTime end);

        Property GetProperty(int id);
    }
}
