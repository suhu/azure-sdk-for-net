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

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a storage mapping input object.
    /// </summary>
    public partial class StorageMappingInput
    {
        private string _primaryServerId;
        
        /// <summary>
        /// Required. Primary server Id.
        /// </summary>
        public string PrimaryServerId
        {
            get { return this._primaryServerId; }
            set { this._primaryServerId = value; }
        }
        
        private string _primaryStorageId;
        
        /// <summary>
        /// Required. Primary storage Id.
        /// </summary>
        public string PrimaryStorageId
        {
            get { return this._primaryStorageId; }
            set { this._primaryStorageId = value; }
        }
        
        private string _recoveryServerId;
        
        /// <summary>
        /// Required. Recovery server Id.
        /// </summary>
        public string RecoveryServerId
        {
            get { return this._recoveryServerId; }
            set { this._recoveryServerId = value; }
        }
        
        private string _recoveryStorageId;
        
        /// <summary>
        /// Required. Recovery storage Id.
        /// </summary>
        public string RecoveryStorageId
        {
            get { return this._recoveryStorageId; }
            set { this._recoveryStorageId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageMappingInput class.
        /// </summary>
        public StorageMappingInput()
        {
        }
    }
}
