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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Storage.Models;

namespace Microsoft.WindowsAzure.Management.Storage.Models
{
    /// <summary>
    /// The Get Storage Account Properties operation response.
    /// </summary>
    public partial class StorageServiceGetResponse : OperationResponse
    {
        private IList<string> _capabilities;
        
        /// <summary>
        /// Indicates if the storage account is able to perform virtual machine
        /// related operations. If so, this element returns a string
        /// containing PersistentVMRole. Otherwise, this element will not be
        /// present.
        /// </summary>
        public IList<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }
        
        private IDictionary<string, string> _extendedProperties;
        
        /// <summary>
        /// Optional. Represents the name of an extended storage account
        /// property. Each extended property must have both a defined name and
        /// value. You can have a maximum of 50 extended property name/value
        /// pairs.  The maximum length of the Name element is 64 characters,
        /// only alphanumeric characters and underscores are valid in the
        /// Name, and the name must start with a letter. Attempting to use
        /// other characters, starting the Name with a non-letter character,
        /// or entering a name that is identical to that of another extended
        /// property owned by the same storage account, will result in a
        /// status code 400 (Bad Request) error.  Each extended property value
        /// has a maximum length of 255 characters.
        /// </summary>
        public IDictionary<string, string> ExtendedProperties
        {
            get { return this._extendedProperties; }
            set { this._extendedProperties = value; }
        }
        
        private StorageServiceProperties _properties;
        
        /// <summary>
        /// Details about the storage account.
        /// </summary>
        public StorageServiceProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _serviceName;
        
        /// <summary>
        /// The name of the storage account. This name is the DNS prefix name
        /// and can be used to access blobs, queues, and tables in the storage
        /// account.  For example, if the service name is MyStorageAccount you
        /// could access the blob containers by calling:
        /// http://MyStorageAccount.blob.core.windows.net/mycontainer/
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }
        
        private Uri _uri;
        
        /// <summary>
        /// The Service Management API request URI used to perform Get Storage
        /// Account Properties requests against the storage account.
        /// </summary>
        public Uri Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageServiceGetResponse class.
        /// </summary>
        public StorageServiceGetResponse()
        {
            this._capabilities = new List<string>();
            this._extendedProperties = new Dictionary<string, string>();
        }
    }
}
