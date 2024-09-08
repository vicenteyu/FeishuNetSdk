// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="DecryptMessageDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件加密结构体</summary>
// ************************************************************************
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 事件加密结构体
    /// </summary>
    /// <param name="EncryptString"></param>
    public record DecryptMessageDto([property: JsonPropertyName("encrypt")] string EncryptString);
}
