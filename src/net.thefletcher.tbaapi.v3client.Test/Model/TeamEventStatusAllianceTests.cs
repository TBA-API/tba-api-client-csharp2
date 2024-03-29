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
    ///  Class for testing TeamEventStatusAlliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TeamEventStatusAllianceTests
    {
        // TODO uncomment below to declare an instance variable for TeamEventStatusAlliance
        //private TeamEventStatusAlliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TeamEventStatusAlliance
            //instance = new TeamEventStatusAlliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamEventStatusAlliance
        /// </summary>
        [Test]
        public void TeamEventStatusAllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" TeamEventStatusAlliance
            //Assert.IsInstanceOf(typeof(TeamEventStatusAlliance), instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'Backup'
        /// </summary>
        [Test]
        public void BackupTest()
        {
            // TODO unit test for the property 'Backup'
        }
        /// <summary>
        /// Test the property 'Pick'
        /// </summary>
        [Test]
        public void PickTest()
        {
            // TODO unit test for the property 'Pick'
        }

    }

}
