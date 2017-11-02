using System.Collections.Generic;

namespace Translator2.Models
{
    public class PlatformRepository: IPlatformRepository
    {
        private object _appDbContext;

        public IEnumerable<Platform> Platforms
        {
            get { return new List<Platform>();
                //    _appDbContext.Platforms.ToList();
                
            }
        }



        public Platform GetPlatformById(int platformId)
        {
            return new Platform();
                //_appDbContext.Platforms.FirstOrDefault(p => p.Id == platformId);
        }
    }
}

