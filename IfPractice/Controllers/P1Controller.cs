using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfPractice.Controllers
{

    /// <summary>
    /// Tells us if Jenny can afford the toy
    /// </summary>
    /// <param
    /// <returns>
    /// True if Jenny can affort, False if she broke 
    /// </returns>
    /// <example>
    /// GET: /api/P1/CoinCalculator/0/0/0/15/0 -> "Go for it Jenny."
    /// </example>
    /// <example>
    /// GET: /api/P1/CoinCalculator/20/0/0/1/1	-> "You broke!"
    /// </example>
    /// 


    public class P1Controller : ApiController
    {
        [Route("api/P1/CoinCalculator/{nickles}/{dimes}/{quarters}/{loonies}/{twoonies}")]
        [HttpGet]

        public string CoinCalculator(int nickles, int dimes, int quarters, int loonies, int twoonies)
        {
            decimal nickleVal = nickles * 0.05M;
            decimal 

        }

    }
}
