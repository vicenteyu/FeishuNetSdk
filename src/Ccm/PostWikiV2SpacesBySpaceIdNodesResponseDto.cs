using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建知识空间节点 响应体
/// <para>此接口用于在知识节点里创建[节点](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-overview)到指定位置。</para>
/// <para>接口ID：7023947709203873796</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fcreate</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdNodesResponseDto
{
    /// <summary>
    /// <para>节点</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("node")]
    public PostWikiV2SpacesBySpaceIdNodesResponseDtoNode? Node { get; set; }

    /// <summary>
    /// <para>节点</para>
    /// </summary>
    public record PostWikiV2SpacesBySpaceIdNodesResponseDtoNode
    {
        /// <summary>
        /// <para>知识空间id</para>
        /// <para>[获取方式](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-overview)</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonProperty("space_id")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// <para>节点token</para>
        /// <para>必填：否</para>
        /// <para>示例值：wikcnKQ1k3p******8Vabcef</para>
        /// </summary>
        [JsonProperty("node_token")]
        public string? NodeToken { get; set; }

        /// <summary>
        /// <para>对应文档类型的token，可根据 obj_type 判断属于哪种文档类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonProperty("obj_token")]
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
        /// </list></para>
        /// </summary>
        [JsonProperty("obj_type")]
        public string ObjType { get; set; } = string.Empty;

        /// <summary>
        /// <para>父节点 token。若当前节点为一级节点，父节点 token 为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wikcnKQ1k3p******8Vabcef</para>
        /// </summary>
        [JsonProperty("parent_node_token")]
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
        [JsonProperty("node_type")]
        public string NodeType { get; set; } = string.Empty;

        /// <summary>
        /// <para>快捷方式对应的实体node_token，当节点为快捷方式时，该值不为空。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wikcnKQ1k3p******8Vabcef</para>
        /// </summary>
        [JsonProperty("origin_node_token")]
        public string? OriginNodeToken { get; set; }

        /// <summary>
        /// <para>快捷方式对应的实体所在的space id</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonProperty("origin_space_id")]
        public string? OriginSpaceId { get; set; }

        /// <summary>
        /// <para>是否有子节点</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("has_child")]
        public bool? HasChild { get; set; }

        /// <summary>
        /// <para>文档标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：标题</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>文档创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1642402428</para>
        /// </summary>
        [JsonProperty("obj_create_time")]
        public string? ObjCreateTime { get; set; }

        /// <summary>
        /// <para>文档最近编辑时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1642402428</para>
        /// </summary>
        [JsonProperty("obj_edit_time")]
        public string? ObjEditTime { get; set; }

        /// <summary>
        /// <para>节点创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1642402428</para>
        /// </summary>
        [JsonProperty("node_create_time")]
        public string? NodeCreateTime { get; set; }

        /// <summary>
        /// <para>节点创建者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxx</para>
        /// </summary>
        [JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// <para>节点所有者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxx</para>
        /// </summary>
        [JsonProperty("owner")]
        public string? Owner { get; set; }
    }
}
