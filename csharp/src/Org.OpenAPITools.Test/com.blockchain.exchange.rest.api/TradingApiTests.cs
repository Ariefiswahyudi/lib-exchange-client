/* 
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.com.blockchain.exchange.rest.api;
using Org.OpenAPITools.com.blockchain.exchange.rest.model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing TradingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TradingApiTests
    {
        private TradingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TradingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TradingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TradingApi
            //Assert.IsInstanceOf(typeof(TradingApi), instance);
        }

        
        /// <summary>
        /// Test CreateOrder
        /// </summary>
        [Test]
        public void CreateOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BaseOrder baseOrder = null;
            //var response = instance.CreateOrder(baseOrder);
            //Assert.IsInstanceOf(typeof(OrderSummary), response, "response is OrderSummary");
        }
        
        /// <summary>
        /// Test DeleteAllOrders
        /// </summary>
        [Test]
        public void DeleteAllOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //instance.DeleteAllOrders(symbol);
            
        }
        
        /// <summary>
        /// Test DeleteOrder
        /// </summary>
        [Test]
        public void DeleteOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long orderId = null;
            //instance.DeleteOrder(orderId);
            
        }
        
        /// <summary>
        /// Test GetFees
        /// </summary>
        [Test]
        public void GetFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetFees();
            //Assert.IsInstanceOf(typeof(Fees), response, "response is Fees");
        }
        
        /// <summary>
        /// Test GetOrderById
        /// </summary>
        [Test]
        public void GetOrderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long orderId = null;
            //var response = instance.GetOrderById(orderId);
            //Assert.IsInstanceOf(typeof(OrderSummary), response, "response is OrderSummary");
        }
        
        /// <summary>
        /// Test GetOrders
        /// </summary>
        [Test]
        public void GetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //long? from = null;
            //long? to = null;
            //OrderStatus? status = null;
            //int? limit = null;
            //var response = instance.GetOrders(symbol, from, to, status, limit);
            //Assert.IsInstanceOf(typeof(List<OrderSummary>), response, "response is List<OrderSummary>");
        }
        
    }

}
