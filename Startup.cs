﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(visproD3.Startup))]
namespace visproD3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
