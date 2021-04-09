using FocusedExecution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FocusedExecution.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FocusedExecutionController : AbpController
    {
        protected FocusedExecutionController()
        {
            LocalizationResource = typeof(FocusedExecutionResource);
        }
    }
}