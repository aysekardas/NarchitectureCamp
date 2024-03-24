using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Fuel:Entity<Guid>
{
    private string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }

    //Bir yakıt tipinin bir sürü modeli olur

    //public virtual 
}
