using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_Assign2_W2022.Controllers
{
    public class J1Controller : ApiController
    {
        //PROBLEM J1 DOG TREATS CCC 2020

        //<summary>
        // Taking 3 int as parameters. First parameter is small treat for dog
        //Second is medium treat and Third is Large treat. (first values input*1, second input*2, third input*3)
        //If the total of these 3 treats are bigger than or equal to 10, return happy
        //If less, return sad
        // </summary>
        // <returns> If the dog feels happy or sad</returns>

        //GET /api/J2/{small}/{medium}/{large}

        [HttpGet]
        [Route("api/J1/{small}/{medium}/{large}")]
        public string J1(int small, int medium, int large)
        {

            //Variable for each treat
            int smallTreat = small * 1;
            int mediumTreat = medium * 2;
            int largeTreat = large * 3;
            int totalTreat = smallTreat + mediumTreat + largeTreat;
            string errorMessage = "You should input value between 0 to 10 (not including 10)!";

            //check the all 3 inputs are smaller than 10 and bigger or equal to 0
            if (small > 9 || small < 0)
            {
                return errorMessage;
            } else if (medium > 9 || medium < 0)
            {
                return errorMessage;
            } else if (large > 9 || large < 0) 
            {
                return errorMessage;
            } else //Check the total amount of treat is more than or equal to 10 to output happy or sad if it is less than 10
            { if (totalTreat >= 10) 
                {
                    return "happy";
                } else if (totalTreat > -1)
                {
                    return "sad";
                } else //error message if conditions are not met
                { 
                    return "invalid number"; 
                }
            }

        }
    }
}
