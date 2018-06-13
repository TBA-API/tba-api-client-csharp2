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
using com.tweirtx.tba-api-v3-client.Api;
using com.tweirtx.tba-api-v3-client.Model;
using com.tweirtx.tba-api-v3-client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.tba-api-v3-client.Test
{
    /// <summary>
    ///  Class for testing MatchScoreBreakdown2017
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MatchScoreBreakdown2017Tests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2017
        //private MatchScoreBreakdown2017 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2017
            //instance = new MatchScoreBreakdown2017();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2017
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2017InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MatchScoreBreakdown2017
            //Assert.IsInstanceOfType<MatchScoreBreakdown2017> (instance, "variable 'instance' is a MatchScoreBreakdown2017");
        }


        /// <summary>
        /// Test the property 'Blue'
        /// </summary>
        [Test]
        public void BlueTest()
        {
            // TODO unit test for the property 'Blue'
        }
        /// <summary>
        /// Test the property 'Red'
        /// </summary>
        [Test]
        public void RedTest()
        {
            // TODO unit test for the property 'Red'
        }

    }

}
