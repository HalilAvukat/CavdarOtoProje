using System.Web.Mvc;

namespace CavdarOtoProje.Areas.AdminPanel
{
    public class AdminPanelAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AdminPanel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AdminPanel_default",
                "AdminPanel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "CavdarOtoProje.Areas.AdminPanel.Controllers" }
            );
        }
    }
}