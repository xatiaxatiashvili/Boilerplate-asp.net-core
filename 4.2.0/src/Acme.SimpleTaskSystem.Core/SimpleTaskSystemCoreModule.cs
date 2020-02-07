﻿using Abp.Modules;
using Abp.Reflection.Extensions;
using Acme.SimpleTaskSystem.Localization;

namespace Acme.SimpleTaskSystem
{
    public class SimpleTaskSystemCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            SimpleTaskSystemLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleTaskSystemCoreModule).GetAssembly());
        }
    }
}