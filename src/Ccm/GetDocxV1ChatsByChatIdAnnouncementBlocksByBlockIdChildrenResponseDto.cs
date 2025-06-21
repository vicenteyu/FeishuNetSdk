// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="GetDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取所有子块 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取所有子块 响应体
/// <para>接口ID：7450053428095582236</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block-children%2fget</para>
/// </summary>
public record GetDocxV1ChatsByChatIdAnnouncementBlocksByBlockIdChildrenResponseDto : IPageableResponse<Dtos.Block>
{
    /// <summary>
    /// <para>Block 的 Children 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Dtos.Block[]? Items { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：aw7DoMKBFMOGwqHCrcO8w6jCmMOvw6ILeADCvsKNw57Di8O5XGV3LG4_w5HCqhFxSnDCrCzCn0BgZcOYUg85EMOYcEAcwqYOw4ojw5QFwofCu8KoIMO3K8Ktw4IuNMOBBHNYw4bCgCV3U1zDu8K-J8KSR8Kgw7Y0fsKZdsKvW3d9w53DnkHDrcO5bDkYwrvDisOEPcOtVFJ-I03CnsOILMOoAmLDknd6dsKqG1bClAjDuS3CvcOTwo7Dg8OrwovDsRdqIcKxw5HDohTDtXN9w5rCkWo</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
