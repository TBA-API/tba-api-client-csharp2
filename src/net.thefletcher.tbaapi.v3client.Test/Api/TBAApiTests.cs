/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using net.thefletcher.tbaapi.v3client.Client;
using net.thefletcher.tbaapi.v3client.Api;
using net.thefletcher.tbaapi.v3client.Model;

namespace net.thefletcher.tbaapi.v3client.Test
{
    /// <summary>
    ///  Class for testing TBAApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TBAApiTests
    {
        private TBAApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TBAApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TBAApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TBAApi
            //Assert.IsInstanceOf(typeof(TBAApi), instance);
        }

        
        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Test]
        public void GetStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ifModifiedSince = null;
            //var response = instance.GetStatus(ifModifiedSince);
            //Assert.IsInstanceOf(typeof(APIStatus), response, "response is APIStatus");
        }
        
    }

}
