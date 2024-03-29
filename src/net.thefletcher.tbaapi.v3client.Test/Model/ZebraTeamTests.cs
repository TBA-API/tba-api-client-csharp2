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
    ///  Class for testing ZebraTeam
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ZebraTeamTests
    {
        // TODO uncomment below to declare an instance variable for ZebraTeam
        //private ZebraTeam instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ZebraTeam
            //instance = new ZebraTeam();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ZebraTeam
        /// </summary>
        [Test]
        public void ZebraTeamInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" ZebraTeam
            //Assert.IsInstanceOf(typeof(ZebraTeam), instance);
        }


        /// <summary>
        /// Test the property 'TeamKey'
        /// </summary>
        [Test]
        public void TeamKeyTest()
        {
            // TODO unit test for the property 'TeamKey'
        }
        /// <summary>
        /// Test the property 'Xs'
        /// </summary>
        [Test]
        public void XsTest()
        {
            // TODO unit test for the property 'Xs'
        }
        /// <summary>
        /// Test the property 'Ys'
        /// </summary>
        [Test]
        public void YsTest()
        {
            // TODO unit test for the property 'Ys'
        }

    }

}
