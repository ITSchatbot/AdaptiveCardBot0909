// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.BotBuilderSamples
{
    /// <summary>
    /// Stores states of a user in a conversation.
    /// </summary>
    public class ConversationMember
    {
        /// <summary>
        /// Returns whether or not the given user in a conversation is greeted by the bot
        /// </summary>
        /// <value><c>true</c> if the user was greeted previously, <c>false</c> otherwise</value>
        public bool WasGreeted { get; set; } = false;

        public Categories categories { get; set; } = Categories.NotSupported;

        public string QuestionType { get; set; }
    }
}