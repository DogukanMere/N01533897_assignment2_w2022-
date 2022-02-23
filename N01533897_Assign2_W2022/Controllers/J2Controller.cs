using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01533897_Assign2_W2022.Controllers
{
    public class J2Controller : ApiController
    {
        //<summary>
        // user input 3 parameters and first one is total number of people which the code is trying to reach
        //second one is the number of person/people on day 0
        //third one - How many people can a person infect each day?
        //at the end each day infection is spread and when param1 value reached, it return the total day passed.
        // </summary>
        // <returns> at the end each day infection is spread and when param1 value reached, it return the total day passed.</returns>

        //PROBLEM J2 EPIDEMIOLOGY CCC 2020


        //GET /api/J2/{param}/{param2}/{param3}
        [HttpGet]
        [Route("api/J2/{param1}/{param2}/{param3}")]

        public int J2(int param1, int param2, int param3)
        {
            ///VARIABLES
            int inputTotal = param1; // P total
            int person = param2; // N person
            int infected = param2;
            int multiply = param3; // R infected
            int day = 0;

            //LOGIC
            //As long as Total amount has not reached - run the loop
            while (person < inputTotal)
            {
                //Assuming conditions given in problem 
                if(inputTotal <= Math.Pow(10, 7) && person <= inputTotal && multiply <= 10) { 
                    //Total number of infected people
                    person = person + (infected * multiply);
                    //Day after number of infected people
                    infected = infected * multiply;
                    day++;
                    //Check if param1 value reached and if it is equal to number of people
                    if (person >= inputTotal)
                    {
                        if (person == inputTotal)
                        {
                            day += 1;
                        }
                    }
                }
            }
            
            return day;
        }

        
    }
}
