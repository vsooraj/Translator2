using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Translator2.Models
{
    public class MockPlatformRepository : IPlatformRepository
    {
        public MockPlatformRepository()
        {
        }

        public IEnumerable<Platform> Platforms => new List<Platform>
        {
            new Platform {Id = 1, Name="Windows", ImageUrl = "~/Images/win.jpg"},
            new Platform {Id = 2, Name="Android", ImageUrl = "~/Images/android.jpg"},
            new Platform {Id = 3, Name="IOS", ImageUrl = "~/Images/ios.jpg"},
            new Platform {Id = 4, Name="BlackBerry", ImageUrl = "~/Images/ios.jpg"}
        };

        public Platform GetPlatformById(int platformId)
        {
            throw new NotImplementedException();
        }
    
       
    }
}
