﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(edccAdvisingProject.Startup))]
namespace edccAdvisingProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
