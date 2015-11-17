// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Redis.Models;

namespace Microsoft.Azure.Management.Redis.Models
{
    /// <summary>
    /// Parameters supplied to CreateOrUpdate redis operation.
    /// </summary>
    public partial class RedisProperties
    {
        private bool? _enableNonSslPort;
        
        /// <summary>
        /// Optional. If the value is true, then the non-ssl redis server port
        /// (6379) will be enabled.
        /// </summary>
        public bool? EnableNonSslPort
        {
            get { return this._enableNonSslPort; }
            set { this._enableNonSslPort = value; }
        }
        
        private IDictionary<string, string> _redisConfiguration;
        
        /// <summary>
        /// Optional. All Redis Settings. Few possible keys:
        /// <para>rdb-backup-enabled</para><para>rdb-storage-connection-string</para><para>rdb-backup-frequency</para><para>maxmemory-reserved</para><para>maxmemory-policy</para><para>notify-keyspace-events</para>.
        /// </summary>
        public IDictionary<string, string> RedisConfiguration
        {
            get { return this._redisConfiguration; }
            set { this._redisConfiguration = value; }
        }
        
        private string _redisVersion;
        
        /// <summary>
        /// Optional. RedisVersion parameter has been deprecated. As such, it
        /// is no longer necessary to provide this parameter and any value
        /// specified is ignored.
        /// </summary>
        public string RedisVersion
        {
            get { return this._redisVersion; }
            set { this._redisVersion = value; }
        }
        
        private int? _shardCount;
        
        /// <summary>
        /// Optional. The number of shards to be created on a Premium Cluster
        /// Cache.
        /// </summary>
        public int? ShardCount
        {
            get { return this._shardCount; }
            set { this._shardCount = value; }
        }
        
        private Sku _sku;
        
        /// <summary>
        /// Required. What sku of redis cache to deploy.
        /// </summary>
        public Sku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private string _staticIP;
        
        /// <summary>
        /// Optional. Required when deploying a redis cache inside an existing
        /// Azure Virtual Network.
        /// </summary>
        public string StaticIP
        {
            get { return this._staticIP; }
            set { this._staticIP = value; }
        }
        
        private string _subnet;
        
        /// <summary>
        /// Optional. Required when deploying a redis cache inside an existing
        /// Azure Virtual Network.
        /// </summary>
        public string Subnet
        {
            get { return this._subnet; }
            set { this._subnet = value; }
        }
        
        private IDictionary<string, string> _tenantSettings;
        
        /// <summary>
        /// Optional. tenantSettings
        /// </summary>
        public IDictionary<string, string> TenantSettings
        {
            get { return this._tenantSettings; }
            set { this._tenantSettings = value; }
        }
        
        private string _virtualNetwork;
        
        /// <summary>
        /// Optional. The exact ARM resource ID of the virtual network to
        /// deploy the redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
        /// </summary>
        public string VirtualNetwork
        {
            get { return this._virtualNetwork; }
            set { this._virtualNetwork = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisProperties class.
        /// </summary>
        public RedisProperties()
        {
            this.RedisConfiguration = new LazyDictionary<string, string>();
            this.TenantSettings = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the RedisProperties class with
        /// required arguments.
        /// </summary>
        public RedisProperties(Sku sku)
            : this()
        {
            if (sku == null)
            {
                throw new ArgumentNullException("sku");
            }
            this.Sku = sku;
        }
    }
}
