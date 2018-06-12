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
    ///  Class for testing EliminationAlliance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EliminationAllianceTests
    {
        // TODO uncomment below to declare an instance variable for EliminationAlliance
        //private EliminationAlliance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EliminationAlliance
            //instance = new EliminationAlliance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EliminationAlliance
        /// </summary>
        [Test]
        public void EliminationAllianceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EliminationAlliance
            //Assert.IsInstanceOfType<EliminationAlliance> (instance, "variable 'instance' is a EliminationAlliance");
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
        /// Test the property 'Backup'
        /// </summary>
        [Test]
        public void BackupTest()
        {
            // TODO unit test for the property 'Backup'
        }
        /// <summary>
        /// Test the property 'Declines'
        /// </summary>
        [Test]
        public void DeclinesTest()
        {
            // TODO unit test for the property 'Declines'
        }
        /// <summary>
        /// Test the property 'Picks'
        /// </summary>
        [Test]
        public void PicksTest()
        {
            // TODO unit test for the property 'Picks'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

    }

}
