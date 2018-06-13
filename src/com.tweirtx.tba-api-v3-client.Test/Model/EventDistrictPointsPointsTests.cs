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
    ///  Class for testing EventDistrictPointsPoints
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EventDistrictPointsPointsTests
    {
        // TODO uncomment below to declare an instance variable for EventDistrictPointsPoints
        //private EventDistrictPointsPoints instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EventDistrictPointsPoints
            //instance = new EventDistrictPointsPoints();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventDistrictPointsPoints
        /// </summary>
        [Test]
        public void EventDistrictPointsPointsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventDistrictPointsPoints
            //Assert.IsInstanceOfType<EventDistrictPointsPoints> (instance, "variable 'instance' is a EventDistrictPointsPoints");
        }


        /// <summary>
        /// Test the property 'AlliancePoints'
        /// </summary>
        [Test]
        public void AlliancePointsTest()
        {
            // TODO unit test for the property 'AlliancePoints'
        }
        /// <summary>
        /// Test the property 'AwardPoints'
        /// </summary>
        [Test]
        public void AwardPointsTest()
        {
            // TODO unit test for the property 'AwardPoints'
        }
        /// <summary>
        /// Test the property 'QualPoints'
        /// </summary>
        [Test]
        public void QualPointsTest()
        {
            // TODO unit test for the property 'QualPoints'
        }
        /// <summary>
        /// Test the property 'ElimPoints'
        /// </summary>
        [Test]
        public void ElimPointsTest()
        {
            // TODO unit test for the property 'ElimPoints'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }

    }

}
