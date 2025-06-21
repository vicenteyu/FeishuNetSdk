// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>在群公告中创建块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 在群公告中创建块 响应体
/// <para>接口ID：7450053428095533084</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block-children%2fcreate</para>
/// </summary>
public record PostDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenResponseDto
{
    /// <summary>
    /// <para>所添加的孩子的 Block 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("children")]
    public Dtos.Block[]? Childrens { get; set; }

    /// <summary>
    /// <para>当前 Block Children 创建成功后群公告的版本号</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("revision_id")]
    public int? RevisionId { get; set; }

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string? ClientToken { get; set; }
}
