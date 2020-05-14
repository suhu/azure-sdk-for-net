// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The DigitalTwinInterfacesPatch. </summary>
    public partial class DigitalTwinInterfacesPatch
    {
        /// <summary> Initializes a new instance of DigitalTwinInterfacesPatch. </summary>
        public DigitalTwinInterfacesPatch()
        {
        }

        /// <summary> Initializes a new instance of DigitalTwinInterfacesPatch. </summary>
        /// <param name="interfaces"> Interface(s) data to patch in the digital twin. </param>
        internal DigitalTwinInterfacesPatch(IDictionary<string, Components10Jnwi5SchemasDigitaltwininterfacespatchPropertiesInterfacesAdditionalproperties> interfaces)
        {
            Interfaces = interfaces;
        }

        /// <summary> Interface(s) data to patch in the digital twin. </summary>
        public IDictionary<string, Components10Jnwi5SchemasDigitaltwininterfacespatchPropertiesInterfacesAdditionalproperties> Interfaces { get; set; }
    }
}