﻿//-----------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  ---------------------------------------------------------------------------------

using System.Net;
using System.Threading.Tasks;
using PhotoSharingApp.Portable.DataContracts;

namespace PhotoSharingApp.AppService.Notifications
{
    /// <summary>
    /// Sends Push notification to registered tag.
    /// </summary>
    public interface INotificationHandler
    {
        /// <summary>
        /// Sends a rich push notification message with a thumbnail image and arguments to lauch the image
        /// if the optional parameters are passed.
        /// Otherwise, only a simple text push message is sent.
        /// </summary>
        /// <param name="platform">The platform specific notification service to use.</param>
        /// <param name="userNotificationTag">The user notification tag to send notification to.</param>
        /// <param name="message">The message to display on the notification toast.</param>
        /// <param name="thumbnailUrl">Optional - The thumbnail Url of the photo to display in notification.</param>
        /// <param name="photoId">Optional - The photoId of the photo to send as activation argument.</param>
        /// <param name="goldCount">Optional - The goldCount of the photo's user.</param>
        /// <returns>HttpStatusCode of the request.</returns>
        Task<HttpStatusCode> SendPushAsync(PushNotificationPlatform platform, string userNotificationTag,
            string message,
            string thumbnailUrl = "", string photoId = "", int goldCount = 0);
    }
}