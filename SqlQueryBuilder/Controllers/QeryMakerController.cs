using Microsoft.AspNetCore.Mvc;
using QueryBAL.QueryBALInterfaces;

namespace SqlQueryBuilder.Web.Controllers
{
    public class QeryMakerController : Controller
    {
        private readonly IQueryLogics _queryLogics;

        public QeryMakerController(IQueryLogics queryLogics)
        {
            _queryLogics = queryLogics;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
