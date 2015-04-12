using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books_01.Models.Authorization;

namespace Books_01.Models.Wall
{
    public interface IWallPost
    {
        IEnumerable<ApplicationUser> getLikes();
        int id { get; }
        PostType type { get; }
        void Like(ApplicationUser user);
        void DisLike(ApplicationUser user);
    }
}
