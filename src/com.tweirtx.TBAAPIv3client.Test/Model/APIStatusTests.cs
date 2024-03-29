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
using com.tweirtx.TBAAPIv3client.Api;
using com.tweirtx.TBAAPIv3client.Model;
using com.tweirtx.TBAAPIv3client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.TBAAPIv3client.Test
{
    /// <summary>
    ///  Class for testing APIStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class APIStatusTests
    {
        // TODO uncomment below to declare an instance variable for APIStatus
        //private APIStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of APIStatus
            //instance = new APIStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of APIStatus
        /// </summary>
        [Test]
        public void APIStatusInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" APIStatus
            //Assert.IsInstanceOfType<APIStatus> (instance, "variable 'instance' is a APIStatus");
        }


        /// <summary>
        /// Test the property 'CurrentSeason'
        /// </summary>
        [Test]
        public void CurrentSeasonTest()
        {
            // TODO unit test for the property 'CurrentSeason'
        }
        /// <summary>
        /// Test the property 'MaxSeason'
        /// </summary>
        [Test]
        public void MaxSeasonTest()
        {
            // TODO unit test for the property 'MaxSeason'
        }
        /// <summary>
        /// Test the property 'IsDatafeedDown'
        /// </summary>
        [Test]
        public void IsDatafeedDownTest()
        {
            // TODO unit test for the property 'IsDatafeedDown'
        }
        /// <summary>
        /// Test the property 'DownEvents'
        /// </summary>
        [Test]
        public void DownEventsTest()
        {
            // TODO unit test for the property 'DownEvents'
        }
        /// <summary>
        /// Test the property 'Ios'
        /// </summary>
        [Test]
        public void IosTest()
        {
            // TODO unit test for the property 'Ios'
        }
        /// <summary>
        /// Test the property 'Android'
        /// </summary>
        [Test]
        public void AndroidTest()
        {
            // TODO unit test for the property 'Android'
        }

    }

}
