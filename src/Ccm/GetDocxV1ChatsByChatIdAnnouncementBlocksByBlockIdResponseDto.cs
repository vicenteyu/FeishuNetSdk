// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="GetDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群公告块的内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取群公告块的内容 响应体
/// <para>接口ID：7450053428095565852</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block%2fget</para>
/// </summary>
public record GetDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdResponseDto
{
    /// <summary>
    /// <para>查询的 Block 的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("block")]
    public Dtos.Block? Block { get; set; }
}
