// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="MessageTypeErrorException.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>消息类型不支持的异常</summary>
// ************************************************************************
namespace FeishuNetSdk.Exceptions
{
    /// <summary>
    /// 消息类型不支持的异常
    /// </summary>
    public class MessageTypeNotSupportedException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public MessageTypeNotSupportedException()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public MessageTypeNotSupportedException(string? message) : base(message)
        {
        }
    }
}
