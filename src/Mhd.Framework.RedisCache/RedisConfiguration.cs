using Mhd.Framework.Ioc;

namespace Mhd.Framewrok.RedisCache
{
    public class RedisConfiguration : IConfigurationOptions
    {
        public string Connection { get; set; }
    }
}
