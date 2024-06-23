// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostWikiV2SpacesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建知识空间 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建知识空间 响应体
/// <para>此接口用于创建知识空间</para>
/// <para>接口ID：7023947709203922948</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fcreate</para>
/// </summary>
public record PostWikiV2SpacesResponseDto
{
    /// <summary>
    /// <para>知识空间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("space")]
    public PostWikiV2SpacesResponseDtoSpace? Space { get; set; }

    /// <summary>
    /// <para>知识空间</para>
    /// </summary>
    public record PostWikiV2SpacesResponseDtoSpace
    {
        /// <summary>
        /// <para>知识空间名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：知识空间</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>知识空间描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：知识空间描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>知识空间id</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("space_id")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// <para>表示知识空间类型（团队空间 或 个人空间）</para>
        /// <para>必填：否</para>
        /// <para>示例值：team</para>
        /// <para>可选值：<list type="bullet">
        /// <item>team：团队空间</item>
        /// <item>person：个人空间</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("space_type")]
        public string? SpaceType { get; set; }

        /// <summary>
        /// <para>表示知识空间可见性（公开空间 或 私有空间）</para>
        /// <para>必填：否</para>
        /// <para>示例值：private</para>
        /// <para>可选值：<list type="bullet">
        /// <item>public：公开空间</item>
        /// <item>private：私有空间</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }
    }
}
