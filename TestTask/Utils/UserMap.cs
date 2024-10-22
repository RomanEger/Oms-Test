using Dapper.FluentMap.Mapping;
using TestTask.Models;

namespace TestTask.Utils
{
    public class UserMap : EntityMap<User>
    {
        public UserMap()
        {
            Map(x => x.LastName).ToColumn("fam");
            Map(x => x.FirstName).ToColumn("im");
            Map(x => x.Patronymic).ToColumn("ot");
            Map(x => x.Birthday).ToColumn("dr");
        }
    }
}