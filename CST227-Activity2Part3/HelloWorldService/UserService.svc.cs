﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public string GetData(string value)
        {
            
            return "If your voice travels " + value + " feet, then the influence of your voice will cover " + Int32.Parse(value) * Int32.Parse(value) * 3.14 + " sq feet";
        }

        public HelloObject GetModelObject(string id)
        {
            HelloObject helloObject = new HelloObject();

            if (Int32.Parse(id) > 0)
            {
                helloObject.happyHello = true;
                helloObject.helloMessage = "Have a great day!";
            }
            else
            {
                helloObject.happyHello = false;
                helloObject.helloMessage = "Have a bad day!";
            }

            return helloObject;
        }

        public string SayHello()
        {
            return "Please help.";
        }
    }
}
