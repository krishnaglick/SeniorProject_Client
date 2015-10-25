
using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Caliburn.Micro;
using Caliburn.Micro.Autofac;
using Caliburn.Micro.Logging;
using SeniorProject_Client.ViewModels;

namespace SeniorProject_Client.Bootstrappers
{
    public class AppBootstrapper : TypedAutofacBootStrapper<ShellViewModel>
    {
        #region Fields
        private readonly ILog _logger = LogManager.GetLog(typeof(AppBootstrapper));
        #endregion
    
        #region Constructor
        static AppBootstrapper()
        {
            LogManager.GetLog = type => new DebugLogger(typeof(AppBootstrapper));
        }
        #endregion
    
        #region Overrides
        protected override void ConfigureContainer(Autofac.ContainerBuilder builder)
        {
          _logger.Info("Configuring Container.");
          base.ConfigureContainer(builder);

        }
        #endregion
    }
}