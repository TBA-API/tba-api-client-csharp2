/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * OpenAPI spec version: 3.03.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing EventOPRs
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EventOPRsTests
    {
        // TODO uncomment below to declare an instance variable for EventOPRs
        //private EventOPRs instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EventOPRs
            //instance = new EventOPRs();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventOPRs
        /// </summary>
        [Test]
        public void EventOPRsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventOPRs
            //Assert.IsInstanceOfType<EventOPRs> (instance, "variable 'instance' is a EventOPRs");
        }


        /// <summary>
        /// Test the property 'Oprs'
        /// </summary>
        [Test]
        public void OprsTest()
        {
            // TODO unit test for the property 'Oprs'
        }
        /// <summary>
        /// Test the property 'Dprs'
        /// </summary>
        [Test]
        public void DprsTest()
        {
            // TODO unit test for the property 'Dprs'
        }
        /// <summary>
        /// Test the property 'Ccwms'
        /// </summary>
        [Test]
        public void CcwmsTest()
        {
            // TODO unit test for the property 'Ccwms'
        }

    }

}