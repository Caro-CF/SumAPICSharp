using Microsoft.AspNetCore.Mvc;

namespace SommeAPI.Controllers
{
    [ApiController]
    [Route("getSum")]
    public class CalculateSum
    {
        public int ReturnSum()
        {
            int a = 3;
            int b = 3;
            return a + b;
        }
    }
}