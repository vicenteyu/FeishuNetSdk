// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="UserAccessToken.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>用户凭证</summary>
// ************************************************************************
using System.Net.Http.Headers;
using WebApiClientCore;

namespace FeishuNetSdk.Parameters
{
    /// <summary>
    /// 用户凭证
    /// </summary>
    public class UserAccessToken(string access_token) : IApiParameter
    {
        private readonly AuthenticationHeaderValue authentication = new("Bearer", access_token);

        /// <summary>
        /// 用户凭证
        /// </summary>
        public static implicit operator UserAccessToken(string access_token)
        {
            return new UserAccessToken(access_token);
        }

        /// <summary>
        /// 输出字符串
        /// </summary>
        public override string ToString()
        {
            return authentication.ToString();
        }

        System.Threading.Tasks.Task IApiParameter.OnRequestAsync(ApiParameterContext context)
        {
            context.HttpContext.RequestMessage.Headers.Authorization = authentication;
            return System.Threading.Tasks.Task.CompletedTask;
        }
    }
}