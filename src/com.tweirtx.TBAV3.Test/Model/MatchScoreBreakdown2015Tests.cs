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
using com.tweirtx.TBAV3.Api;
using com.tweirtx.TBAV3.Model;
using com.tweirtx.TBAV3.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.tweirtx.TBAV3.Test
{
    /// <summary>
    ///  Class for testing MatchScoreBreakdown2015
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
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
            // TODO uncomment below to test "IsInstanceOfType" MatchScoreBreakdown2015
            //Assert.IsInstanceOfType<MatchScoreBreakdown2015> (instance, "variable 'instance' is a MatchScoreBreakdown2015");
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
