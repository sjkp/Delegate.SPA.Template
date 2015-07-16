namespace $safeprojectname$.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Http;
    

    public class ValuesController : ApiController
    {
        public async Task<IHttpActionResult> GetValues()
        {
            return Ok(new[] { "a", "b", "c" });
        }
    }
}
