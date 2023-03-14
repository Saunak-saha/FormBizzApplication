﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FormBizz.Web.Public.Views
{
    public abstract class FormBizzRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FormBizzRazorPage()
        {
            LocalizationSourceName = FormBizzConsts.LocalizationSourceName;
        }
    }
}
