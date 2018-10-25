using AutoMapper;

namespace GroupMap.Service
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Reset();
            Mapper.Initialize(config =>
            {
                
            });
        }
    }
}
