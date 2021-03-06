﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SVI.Recibo.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(
                typeof( decimal ), new DecimalModelBinder() );
            ModelBinders.Binders.Add(
                typeof( decimal? ), new DecimalModelBinder() );
        }
    }

    internal class DecimalModelBinder : IModelBinder
    {
        public object BindModel(
            ControllerContext controllerContext,
            ModelBindingContext bindingContext )
        {
            ValueProviderResult valueResult =
                bindingContext.ValueProvider
                    .GetValue( bindingContext.ModelName );
            ModelState modelState =
                new ModelState { Value = valueResult };
            object actualValue = null;
            try
            {
                actualValue = Convert.ToDecimal(
                    valueResult.AttemptedValue,
                    CultureInfo.CurrentCulture );
            }
            catch( FormatException e )
            {
                modelState.Errors.Add( e );
            }

            bindingContext.ModelState.Add(
                bindingContext.ModelName, modelState );
            return actualValue;
        }
    }
}
