using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Translator2.Models
{
    public interface IPlatformRepository
    {
         IEnumerable<Platform> Platforms { get; }

         Platform GetPlatformById(int platformId);

    }
}
