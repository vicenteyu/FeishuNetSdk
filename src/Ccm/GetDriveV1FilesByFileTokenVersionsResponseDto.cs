namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文档版本列表 响应体
/// <para>获取文档所有版本。</para>
/// <para>接口ID：7156062028484984836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-version/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-version%2flist</para>
/// </summary>
public record GetDriveV1FilesByFileTokenVersionsResponseDto
{
    /// <summary>
    /// <para>版本文档列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Version[]? Items { get; set; }

    /// <summary>
    /// <para>版本文档列表</para>
    /// </summary>
    public record Version
    {
        /// <summary>
        /// <para>版本文档标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：文档标题</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>版本文档版本号</para>
        /// <para>必填：否</para>
        /// <para>示例值：version1</para>
        /// </summary>
        [JsonPropertyName("version")]
        public string? VersionSuffix { get; set; }

        /// <summary>
        /// <para>创建版本的文档Token，如何获取文档Token可以参考[如何获取云文档相关token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxbcyvqZlSc9WlHvQMlSJwUrsb</para>
        /// </summary>
        [JsonPropertyName("parent_token")]
        public string? ParentToken { get; set; }

        /// <summary>
        /// <para>版本文档所有者id，user_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：694699009591869450</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>版本文档创建者id， user_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：694699009591869451</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>版本文档创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1660708537</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>版本文档更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1660708537</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>版本文档状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：正常状态</item>
        /// <item>1：删除状态</item>
        /// <item>2：回收站状态</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>版本文档类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：docx</para>
        /// <para>可选值：<list type="bullet">
        /// <item>docx：新版文档</item>
        /// <item>sheet：电子表格</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("obj_type")]
        public string? ObjType { get; set; }

        /// <summary>
        /// <para>源文档类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：docx</para>
        /// <para>可选值：<list type="bullet">
        /// <item>docx：新版文档</item>
        /// <item>sheet：电子表格</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("parent_type")]
        public string? ParentType { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1665739380</para>
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
