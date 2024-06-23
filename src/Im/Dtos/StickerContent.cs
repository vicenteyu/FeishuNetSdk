// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="StickerContent.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表情包消息</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 表情包消息
    /// </summary>
    /// <param name="FileKey">表情包文件Key，目前仅支持发送机器人收到的表情包，可通过接收消息事件的推送获取表情包 file_key。</param>
    public record StickerContent([property: JsonPropertyName("file_key")] string FileKey = "") : MessageContent("sticker");

}
