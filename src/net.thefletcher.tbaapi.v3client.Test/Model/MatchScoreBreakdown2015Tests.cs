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
    ///  Class for testing MatchScoreBreakdown2015
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MatchScoreBreakdown2015Tests
    {
        // TODO uncomment below to declare an instance variable for MatchScoreBreakdown2015
        //private MatchScoreBreakdown2015 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MatchScoreBreakdown2015
            //instance = new MatchScoreBreakdown2015();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MatchScoreBreakdown2015
        /// </summary>
        [Test]
        public void MatchScoreBreakdown2015InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" MatchScoreBreakdown2015
            //Assert.IsInstanceOf(typeof(MatchScoreBreakdown2015), instance);
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
        /// <summary>
        /// Test the property 'Coopertition'
        /// </summary>
        [Test]
        public void CoopertitionTest()
        {
            // TODO unit test for the property 'Coopertition'
        }
        /// <summary>
        /// Test the property 'CoopertitionPoints'
        /// </summary>
        [Test]
        public void CoopertitionPointsTest()
        {
            // TODO unit test for the property 'CoopertitionPoints'
        }

    }

}