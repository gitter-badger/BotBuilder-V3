﻿// 
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
// 
// Microsoft Bot Framework: http://botframework.com
// 
// Bot Builder SDK Github:
// https://github.com/Microsoft/BotBuilder
// 
// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.Dialogs
{
    public interface IActivityManager
    {
        /// <summary>
        /// Delete a specific conversation.
        /// </summary>
        /// <param name="channelId">Channel where conversation took place.</param>
        /// <param name="conversationId">Id of conversation to delete.</param>
        /// <param name="cancel">Cancellation token.</param>
        /// <returns>Task.</returns>
        Task DeleteConversationAsync(string channelId, string conversationId, CancellationToken cancel = default(CancellationToken));

        /// <summary>
        /// Delete any conversation records older than <paramref name="oldest"/>.
        /// </summary>
        /// <param name="oldest">Earliest remaining date in log.</param>
        /// <param name="cancel">Cancellation token.</param>
        Task DeleteBeforeAsync(DateTime oldest, CancellationToken cancel = default(CancellationToken));

        /// <summary>
        /// Delete all activities involving <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">User to delete.</param>
        /// <param name="cancel">Cancellation token.</param>
        /// <returns>Task.</returns>
        Task DeleteUserActivitiesAsync(string userId, CancellationToken cancel = default(CancellationToken));
    }
}