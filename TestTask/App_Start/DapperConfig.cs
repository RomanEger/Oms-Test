using Dapper.FluentMap;
using TestTask.Utils;

namespace TestTask
{
    public class DapperConfig
    {
        public static void ConfigureDapperMap()
        {
            FluentMapper.Initialize(configuration =>
            {
                configuration.AddMap(new UserMap());
            });
        }
    }
}