using System.Web.Mvc;
using Raven.Client;

namespace ThenComesMarriage.Controllers
{
    public class HomeController : Controller
    {
		private readonly IDocumentSession _documentSession;
		public HomeController(IDocumentSession documentSession)
		{
			_documentSession = documentSession;
		}
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
