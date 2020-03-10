/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.thebluealliance.TBAAPI.v3client.Api;
using com.thebluealliance.TBAAPI.v3client.Model;
using com.thebluealliance.TBAAPI.v3client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.thebluealliance.TBAAPI.v3client.Test
{
    /// <summary>
    ///  Class for testing MatchSimpleAlliances
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchSimpleAlliancesTests
    {
        // TODO uncomment below to declare an instance variable for MatchSimpleAlliances
        //private MatchSimpleAlliances instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchSimpleAlliances
            //instance = new MatchSimpleAlliances();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchSimpleAlliances
        /// </summary>
        [Test]
        public void MatchSimpleAlliancesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" MatchSimpleAlliances
            //Assert.IsInstanceOf(typeof(MatchSimpleAlliances), instance);
        }


        /// <summary>
        /// Test the property 'Red'
        /// </summary>
        [Test]
        public void RedTest()
        {
            // TODO unit test for the property 'Red'
        }
        /// <summary>
        /// Test the property 'Blue'
        /// </summary>
        [Test]
        public void BlueTest()
        {
            // TODO unit test for the property 'Blue'
        }

    }

}
