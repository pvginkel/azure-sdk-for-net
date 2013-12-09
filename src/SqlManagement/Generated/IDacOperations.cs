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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// Includes operations for importing and exporting SQL Databases into and
    /// out of Windows Azure blob storage.
    /// </summary>
    public partial interface IDacOperations
    {
        /// <param name='serverName'>
        /// The name of the server being imported to or exported from
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for an DAC Import/Export request.
        /// </returns>
        Task<DacImportExportResponse> ExportAsync(string serverName, DacExportParameters parameters, CancellationToken cancellationToken);
        
        /// <param name='serverName'>
        /// The name of the server being imported to or exported from
        /// </param>
        /// <param name='fullyQualifiedServerName'>
        /// The fully qualified name of the server being imported to or
        /// exported from
        /// </param>
        /// <param name='username'>
        /// The server's username
        /// </param>
        /// <param name='password'>
        /// The server's password
        /// </param>
        /// <param name='requestId'>
        /// The request ID of the operation being queried
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the DAC GetStatus operation
        /// </returns>
        Task<DacGetStatusResponse> GetStatusAsync(string serverName, string fullyQualifiedServerName, string username, string password, string requestId, CancellationToken cancellationToken);
        
        /// <param name='serverName'>
        /// The name of the server being imported to or exported from
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for an DAC Import/Export request.
        /// </returns>
        Task<DacImportExportResponse> ImportAsync(string serverName, DacImportParameters parameters, CancellationToken cancellationToken);
    }
}
