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
    ///  Class for testing TeamRobot
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TeamRobotTests
    {
        // TODO uncomment below to declare an instance variable for TeamRobot
        //private TeamRobot instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TeamRobot
            //instance = new TeamRobot();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamRobot
        /// </summary>
        [Test]
        public void TeamRobotInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TeamRobot
            //Assert.IsInstanceOfType<TeamRobot> (instance, "variable 'instance' is a TeamRobot");
        }


        /// <summary>
        /// Test the property 'Year'
        /// </summary>
        [Test]
        public void YearTest()
        {
            // TODO unit test for the property 'Year'
        }
        /// <summary>
        /// Test the property 'RobotName'
        /// </summary>
        [Test]
        public void RobotNameTest()
        {
            // TODO unit test for the property 'RobotName'
        }
        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'TeamKey'
        /// </summary>
        [Test]
        public void TeamKeyTest()
        {
            // TODO unit test for the property 'TeamKey'
        }

    }

}
