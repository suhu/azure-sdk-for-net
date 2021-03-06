// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Chat
{
    /// <summary> The ChatMessage. </summary>
    public partial class ChatMessage
    {
        /// <summary> Initializes a new instance of ChatMessage. </summary>
        internal ChatMessage()
        {
        }

        /// <summary> The id of the chat message. This id is server generated. </summary>
        public string Id { get; }
        /// <summary>
        /// Type of the chat message.
        /// 
        /// 
        /// 
        /// Possible values:
        /// 
        ///     - Text
        /// 
        ///     - ThreadActivity/TopicUpdate
        /// 
        ///     - ThreadActivity/AddMember
        /// 
        ///     - ThreadActivity/DeleteMember.
        /// </summary>
        public string Type { get; }
        /// <summary> The chat message priority. </summary>
        public ChatMessagePriority? Priority { get; }
        /// <summary> Version of the chat message. </summary>
        public string Version { get; }
        /// <summary> Content of the chat message. </summary>
        public string Content { get; }
        /// <summary> The display name of the chat message sender. This property is used to populate sender name for push notifications. </summary>
        public string SenderDisplayName { get; }
        /// <summary> The timestamp when the chat message arrived at the server. The timestamp is in ISO8601 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The timestamp when the chat message was deleted. The timestamp is in ISO8601 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The timestamp when the chat message was edited. The timestamp is in ISO8601 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? EditedOn { get; }
    }
}
