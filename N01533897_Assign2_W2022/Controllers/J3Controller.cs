using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_Assign2_W2022.Controllers
{
    public class J3Controller : ApiController
    {
        //PROBLEM J3 ARE WE THERE YET? CCC 2018

        //<summary>
        // Taking 4 int parameters representing different 4 cities (Along the road are five cities including starting point). 
        // Parameters represents the distance between each pair of consecutive cities. 
        // (example: First city counts 0, city 1 distance from 0 is 5, city 2 distance from city 1 is 10, and so on)
        // </summary>
        // <returns> Each return items show the distance from each city to city0(starting point)</returns>

        //GET /api/J3/{city1}/{city2}/{city3}/{city4}
        [HttpGet]
        [Route("api/J3/{city1}/{city2}/{city3}/{city4}")]

        public int[] J3(int city1, int city2, int city3, int city4)
        {
            int[] cities = new int[4] { city1, city2, city3, city4};
            int[] intArray = new int[5];
            intArray[0] = 0;
            int sum = 0;


            for (int i = 0; i < 4; i++)
            {
                if(cities[i] < 1000) { 
                sum += cities[i];
                intArray[i+1] = sum;
                }
            }

            return intArray;
        }
    }
}
