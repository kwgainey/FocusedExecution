using System;
using System.Collections.Generic;
using System.Text;
using FocusedExecution.Localization;
using Volo.Abp.Application.Services;

namespace FocusedExecution
{
    /* Inherit your application services from this class.
     */
    public abstract class FocusedExecutionAppService : ApplicationService
    {
        protected FocusedExecutionAppService()
        {
            LocalizationResource = typeof(FocusedExecutionResource);
        }
    }
}
