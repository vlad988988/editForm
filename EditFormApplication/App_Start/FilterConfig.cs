// <copyright file="FilterConfig.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace EditFormApplication
{
    using System.Web.Mvc;

    /// <summary>
    /// Filter Configuration
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Sets route config
        /// </summary>
        /// <param name = "filters">GlobalFilterCollection type filters parameter</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
