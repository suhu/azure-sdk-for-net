// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The email actions.
    /// </summary>
    public partial class EmailActions
    {
        /// <summary>
        /// Initializes a new instance of the EmailActions class.
        /// </summary>
        public EmailActions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailActions class.
        /// </summary>
        /// <param name="emailAddresses">The list of email actions.</param>
        public EmailActions(IList<EmailAction> emailAddresses = default(IList<EmailAction>))
        {
            EmailAddresses = emailAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of email actions.
        /// </summary>
        [JsonProperty(PropertyName = "emailAddresses")]
        public IList<EmailAction> EmailAddresses { get; set; }

    }
}