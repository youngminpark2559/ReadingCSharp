﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

//c Using MVC API in PocoController.cs.

namespace ControllersAndActions.Controllers
{
    public class PocoController
    {
        public ViewResult Index() => new ViewResult()
        {
            ViewName = "Result",
            ViewData = new ViewDataDictionary(
                    new EmptyModelMetadataProvider(),
                    new ModelStateDictionary())
            {
                Model = $"This is a POCO controller"
            }
        };
    }
}