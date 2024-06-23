// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="AudioContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>语音消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 语音消息
    /// </summary>
    /// <param name="FileKey">语音文件Key，可通过上传文件接口获取文件的 file_key。</param>
    public record AudioContent([property: JsonPropertyName("file_key")] string FileKey = "") : MessageContent("audio");
}
