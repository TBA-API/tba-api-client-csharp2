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
using net.thefletcher.tbaapi.v3client.Api;
using net.thefletcher.tbaapi.v3client.Model;
using net.thefletcher.tbaapi.v3client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace net.thefletcher.tbaapi.v3client.Test
{
    /// <summary>
    ///  Class for testing WLTRecord
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WLTRecordTests
    {
        // TODO uncomment below to declare an instance variable for WLTRecord
        //private WLTRecord instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of WLTRecord
            //instance = new WLTRecord();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WLTRecord
        /// </summary>
        [Test]
        public void WLTRecordInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" WLTRecord
            //Assert.IsInstanceOf(typeof(WLTRecord), instance);
        }


        /// <summary>
        /// Test the property 'Losses'
        /// </summary>
        [Test]
        public void LossesTest()
        {
            // TODO unit test for the property 'Losses'
        }
        /// <summary>
        /// Test the property 'Wins'
        /// </summary>
        [Test]
        public void WinsTest()
        {
            // TODO unit test for the property 'Wins'
        }
        /// <summary>
        /// Test the property 'Ties'
        /// </summary>
        [Test]
        public void TiesTest()
        {
            // TODO unit test for the property 'Ties'
        }

    }

}
