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
    ///  Class for testing EnterpriseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EnterpriseApiTests : IDisposable
    {
        private EnterpriseApi instance;

        public EnterpriseApiTests()
        {
            instance = new EnterpriseApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EnterpriseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EnterpriseApi
            //Assert.IsType<EnterpriseApi>(instance);
        }

        /// <summary>
        /// Test CreateQuotaSpec
        /// </summary>
        [Fact]
        public void CreateQuotaSpecTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuotaSpec quotaSpec = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //instance.CreateQuotaSpec(quotaSpec, region, _namespace, xNomadToken, idempotencyToken);
        }

        /// <summary>
        /// Test DeleteQuotaSpec
        /// </summary>
        [Fact]
        public void DeleteQuotaSpecTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string specName = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //instance.DeleteQuotaSpec(specName, region, _namespace, xNomadToken, idempotencyToken);
        }

        /// <summary>
        /// Test GetQuotaSpec
        /// </summary>
        [Fact]
        public void GetQuotaSpecTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string specName = null;
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetQuotaSpec(specName, region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<QuotaSpec>(response);
        }

        /// <summary>
        /// Test GetQuotas
        /// </summary>
        [Fact]
        public void GetQuotasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? region = null;
            //string? _namespace = null;
            //int? index = null;
            //string? wait = null;
            //string? stale = null;
            //string? prefix = null;
            //string? xNomadToken = null;
            //int? perPage = null;
            //string? nextToken = null;
            //var response = instance.GetQuotas(region, _namespace, index, wait, stale, prefix, xNomadToken, perPage, nextToken);
            //Assert.IsType<List<Object>>(response);
        }

        /// <summary>
        /// Test PostQuotaSpec
        /// </summary>
        [Fact]
        public void PostQuotaSpecTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string specName = null;
            //QuotaSpec quotaSpec = null;
            //string? region = null;
            //string? _namespace = null;
            //string? xNomadToken = null;
            //string? idempotencyToken = null;
            //instance.PostQuotaSpec(specName, quotaSpec, region, _namespace, xNomadToken, idempotencyToken);
        }
    }
}
