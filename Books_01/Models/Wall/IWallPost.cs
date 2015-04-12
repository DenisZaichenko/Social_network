using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books_01.Models.Authorization;

namespace Books_01.Models.Wall
{
    interface IWallPost
    {
        List<ApplicationUser> likes { get; }
        Guid id { get; }
        PostType type { get; }
        void Like(ApplicationUser user);
        void DisLike(ApplicationUser user);
    }
}
