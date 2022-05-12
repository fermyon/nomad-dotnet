/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Fermyon.Nomad.Client;
using Fermyon.Nomad.Api;
// uncomment below to import models
//using Fermyon.Nomad.Model;

namespace Fermyon.Nomad.Test.Api
{
    /// <summary>
    ///  Class for testing OperatorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OperatorApiTests : IDisposable
    {
        private OperatorApi instance;

        public OperatorApiTests()
        {
            instance = new OperatorApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OperatorApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OperatorApi
            //Assert.IsType<OperatorApi>(instance);
        }

        /// <summary>
        /// Test DeleteOperatorRaftPeer
        /// </summary>
        [Fact]
        public void DeleteOperatorRaftPeerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string region = null;
            //string _namespace = null;
            //string xNomadToken = null;
            //string idempotencyToken = null;
            //instance.DeleteOperatorRaftPeer(region, _namespace, xNomadToken, idempotencyToken);
        }

        /// <summary>
        /// Test GetOperatorAutopilotConfiguration
        /// </summary>
        [Fact]
        public void GetOperatorAutopilotConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string region = null;
            //string _namespace = null;
            //int? index = null;
            //string wait = null;
            //string stale = null;
            //string prefix = null;
            //string xNomadToken = null;
            //int? perPage = null;
            //string nextToken = null;
            //var response = instance.GetOperatorAutopilotConfiguration(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<AutopilotConfiguration>(response);
        }

        /// <summary>
        /// Test GetOperatorAutopilotHealth
        /// </summary>
        [Fact]
        public void GetOperatorAutopilotHealthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string region = null;
            //string _namespace = null;
            //int? index = null;
            //string wait = null;
            //string stale = null;
            //string prefix = null;
            //string xNomadToken = null;
            //int? perPage = null;
            //string nextToken = null;
            //var response = instance.GetOperatorAutopilotHealth(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<OperatorHealthReply>(response);
        }

        /// <summary>
        /// Test GetOperatorRaftConfiguration
        /// </summary>
        [Fact]
        public void GetOperatorRaftConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string region = null;
            //string _namespace = null;
            //int? index = null;
            //string wait = null;
            //string stale = null;
            //string prefix = null;
            //string xNomadToken = null;
            //int? perPage = null;
            //string nextToken = null;
            //var response = instance.GetOperatorRaftConfiguration(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<RaftConfiguration>(response);
        }

        /// <summary>
        /// Test GetOperatorSchedulerConfiguration
        /// </summary>
        [Fact]
        public void GetOperatorSchedulerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string region = null;
            //string _namespace = null;
            //int? index = null;
            //string wait = null;
            //string stale = null;
            //string prefix = null;
            //string xNomadToken = null;
            //int? perPage = null;
            //string nextToken = null;
            //var response = instance.GetOperatorSchedulerConfiguration(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<SchedulerConfigurationResponse>(response);
        }

        /// <summary>
        /// Test PostOperatorSchedulerConfiguration
        /// </summary>
        [Fact]
        public void PostOperatorSchedulerConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SchedulerConfiguration schedulerConfiguration = null;
            //string region = null;
            //string _namespace = null;
            //string xNomadToken = null;
            //string idempotencyToken = null;
            //var response = instance.PostOperatorSchedulerConfiguration(schedulerConfiguration, region, _namespace, xNomadToken, idempotencyToken);
            //Assert.IsType<SchedulerSetConfigurationResponse>(response);
        }

        /// <summary>
        /// Test PutOperatorAutopilotConfiguration
        /// </summary>
        [Fact]
        public void PutOperatorAutopilotConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AutopilotConfiguration autopilotConfiguration = null;
            //string region = null;
            //string _namespace = null;
            //string xNomadToken = null;
            //string idempotencyToken = null;
            //var response = instance.PutOperatorAutopilotConfiguration(autopilotConfiguration, region, _namespace, xNomadToken, idempotencyToken);
            //Assert.IsType<bool>(response);
        }
    }
}
