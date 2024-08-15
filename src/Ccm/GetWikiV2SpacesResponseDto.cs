// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetWikiV2SpacesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取知识空间列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取知识空间列表 响应体
/// <para>此接口用于获取有权限访问的知识空间列表。</para>
/// <para>## 注意事项</para>
/// <para>- 使用 tenant access token 调用时，请确认应用或机器人拥有部分知识空间的访问权限，否则返回列表为空。参阅[如何将应用添加为知识库管理员（成员）](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-v2/wiki-qa#b5da330b)。</para>
/// <para>- 此接口为分页接口。由于权限过滤，可能返回列表为空，但当分页标记（has_more）为 true 时，可以继续分页请求。</para>
/// <para>接口ID：7023947709203841028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2flist</para>
/// </summary>
public record GetWikiV2SpacesResponseDto
{
    /// <summary>
    /// <para>数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Space[]? Items { get; set; }

    /// <summary>
    /// <para>数据列表</para>
    /// </summary>
    public record Space
    {
        /// <summary>
        /// <para>知识空间名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：workspace name</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>知识空间描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：workspace description</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>知识空间 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("space_id")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// <para>表示知识空间类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：team</para>
        /// <para>可选值：<list type="bullet">
        /// <item>team：团队空间，归团队（多人）管理，可添加多个管理员</item>
        /// <item>person：个人空间，归个人管理。一人仅可拥有一个个人空间，无法添加其他管理员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("space_type")]
        public string? SpaceType { get; set; }

        /// <summary>
        /// <para>表示知识空间可见性</para>
        /// <para>必填：否</para>
        /// <para>示例值：private</para>
        /// <para>可选值：<list type="bullet">
        /// <item>public：公开空间，租户内所有用户可见，默认为成员权限。无法额外添加成员，但可以添加管理员</item>
        /// <item>private：私有空间，仅对知识空间管理员、成员可见，需要手动添加管理员、成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// <para>表示知识空间的分享状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：open</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>open：打开，即知识空间发布到互联网</item>
        /// <item>closed：关闭，即知识空间未发布到互联网</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("open_sharing")]
        public string? OpenSharing { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1565676577122621</para>
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
