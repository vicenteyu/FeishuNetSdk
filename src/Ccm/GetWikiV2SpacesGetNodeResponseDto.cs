// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetWikiV2SpacesGetNodeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取知识空间节点信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取知识空间节点信息 响应体
/// <para>获取知识空间节点信息</para>
/// <para>接口ID：7023947709203939332</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/get_node</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fget_node</para>
/// </summary>
public record GetWikiV2SpacesGetNodeResponseDto
{
    /// <summary>
    /// <para>节点信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node")]
    public GetWikiV2SpacesGetNodeResponseDtoNode? Node { get; set; }

    /// <summary>
    /// <para>节点信息</para>
    /// </summary>
    public record GetWikiV2SpacesGetNodeResponseDtoNode
    {
        /// <summary>
        /// <para>知识空间 ID。获取方式参考[知识库概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-overview)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6946843325487912356</para>
        /// </summary>
        [JsonPropertyName("space_id")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// <para>知识库节点 token，如果 URL 链接中 token 前为 wiki，该 token 为知识库的节点 token。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wikcnKQ1k3p******8Vabcef</para>
        /// </summary>
        [JsonPropertyName("node_token")]
        public string? NodeToken { get; set; }

        /// <summary>
        /// <para>节点的实际云文档的 token，如果 URL 链接中 token 前为 docx、base、sheets 等非 wiki 类型，则说明该 token 是当前云文档的实际 token。如果要获取或编辑节点内容，需要使用此 token 调用对应的接口。可根据 obj_type 判断属于哪种文档类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：doccnzAaOD******Wabcdef</para>
        /// </summary>
        [JsonPropertyName("obj_token")]
        public string? ObjToken { get; set; }

        /// <summary>
        /// <para>文档类型，对于快捷方式，该字段是对应的实体的obj_type。</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// <para>可选值：<list type="bullet">
        /// <item>doc：旧版文档</item>
        /// <item>sheet：表格</item>
        /// <item>mindnote：思维导图</item>
        /// <item>bitable：多维表格</item>
        /// <item>file：文件</item>
        /// <item>docx：新版文档</item>
        /// <item>slides：幻灯片</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("obj_type")]
        public string ObjType { get; set; } = string.Empty;

        /// <summary>
        /// <para>父节点 token。若当前节点为一级节点，父节点 token 为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wikcnKQ1k3p******8Vabcef</para>
        /// </summary>
        [JsonPropertyName("parent_node_token")]
        public string? ParentNodeToken { get; set; }

        /// <summary>
        /// <para>节点类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：origin</para>
        /// <para>可选值：<list type="bullet">
        /// <item>origin：实体</item>
        /// <item>shortcut：快捷方式</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("node_type")]
        public string NodeType { get; set; } = string.Empty;

        /// <summary>
        /// <para>快捷方式对应的实体node_token，当节点为快捷方式时，该值不为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wikcnKQ1k3p******8Vabcef</para>
        /// </summary>
        [JsonPropertyName("origin_node_token")]
        public string? OriginNodeToken { get; set; }

        /// <summary>
        /// <para>快捷方式对应的实体所在的space id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6946843325487912356</para>
        /// </summary>
        [JsonPropertyName("origin_space_id")]
        public string? OriginSpaceId { get; set; }

        /// <summary>
        /// <para>是否有子节点</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("has_child")]
        public bool? HasChild { get; set; }

        /// <summary>
        /// <para>文档标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：标题</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>文档创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1642402428</para>
        /// </summary>
        [JsonPropertyName("obj_create_time")]
        public string? ObjCreateTime { get; set; }

        /// <summary>
        /// <para>文档最近编辑时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1642402428</para>
        /// </summary>
        [JsonPropertyName("obj_edit_time")]
        public string? ObjEditTime { get; set; }

        /// <summary>
        /// <para>节点创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1642402428</para>
        /// </summary>
        [JsonPropertyName("node_create_time")]
        public string? NodeCreateTime { get; set; }

        /// <summary>
        /// <para>文档创建者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxx</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// <para>文档所有者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxx</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// <para>节点创建者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxx</para>
        /// </summary>
        [JsonPropertyName("node_creator")]
        public string? NodeCreator { get; set; }
    }
}
