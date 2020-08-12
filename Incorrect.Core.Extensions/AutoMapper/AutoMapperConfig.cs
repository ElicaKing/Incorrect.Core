using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Incorrect.Core.Extensions
{
    /// <summary>
    /// 静态全局AutoMapper配置
    /// </summary>
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CustomProfile());
            });
        }
    }
}
