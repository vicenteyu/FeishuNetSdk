// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetWikiV2SpacesBySpaceIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取知识空间信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取知识空间信息 响应体
/// <para>此接口用于根据知识空间 ID 查询知识空间的信息，包括空间的类型、可见性、分享状态等。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保应用或用户为知识空间的成员或管理员。</para>
/// <para>接口ID：7023947709203857412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fget</para>
/// </summary>
public record GetWikiV2SpacesBySpaceIdResponseDto
{
    /// <summary>
    /// <para>知识空间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("space")]
    public GetWikiV2SpacesBySpaceIdResponseDtoSpace? Space { get; set; }

    /// <summary>
    /// <para>知识空间</para>
    /// </summary>
    public record GetWikiV2SpacesBySpaceIdResponseDtoSpace
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
        /// <item>person：个人空间（旧版，已下线），归个人管理。一人仅可拥有一个，无法添加其他管理员</item>
        /// <item>my_library：我的文档库，归个人管理。一人仅可拥有一个，无法添加其他管理员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("space_type")]
        public string? SpaceType { get; set; }

        /// <summary>
        /// <para>表示知识空间可见性</para>
        /// <para>必填：否</para>
        /// <para>示例值：private</para>
        /// <para>可选值：<list type="bullet">
        /// <item>public：公开空间。租户所有用户可见，默认为成员权限。无法额外添加成员，但可以添加管理员</item>
        /// <item>private：私有空间。仅对知识空间管理员、成员可见，需要手动添加管理员、成员</item>
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
}
