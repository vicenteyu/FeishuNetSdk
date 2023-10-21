using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文档元数据 响应体
/// <para>根据 Token 获取各类文档的元数据。</para>
/// <para>接口ID：7106040876741345308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmeta%2fbatch_query</para>
/// </summary>
public record PostDriveV1MetasBatchQueryResponseDto
{
    /// <summary>
    /// <para>文档元数据列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("metas")]
    public Meta[] Metas { get; set; } = Array.Empty<Meta>();

    /// <summary>
    /// <para>文档元数据列表</para>
    /// </summary>
    public record Meta
    {
        /// <summary>
        /// <para>文件token</para>
        /// <para>必填：是</para>
        /// <para>示例值：doccnfYZzTlvXqZIGTdAHKabcef</para>
        /// </summary>
        [JsonProperty("doc_token")]
        public string DocToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// </summary>
        [JsonProperty("doc_type")]
        public string DocType { get; set; } = string.Empty;

        /// <summary>
        /// <para>标题</para>
        /// <para>必填：是</para>
        /// <para>示例值：sampletitle</para>
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件所有者</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; } = string.Empty;

        /// <summary>
        /// <para>创建时间（Unix时间戳）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1652066345</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>最后编辑者</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonProperty("latest_modify_user")]
        public string LatestModifyUser { get; set; } = string.Empty;

        /// <summary>
        /// <para>最后编辑时间（Unix时间戳）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1652066345</para>
        /// </summary>
        [JsonProperty("latest_modify_time")]
        public string LatestModifyTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>文档链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://sample.feishu.cn/docs/doccnfYZzTlvXqZIGTdAHKabcef</para>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// <para>文档密级标签名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：L2-内部</para>
        /// </summary>
        [JsonProperty("sec_label_name")]
        public string? SecLabelName { get; set; }
    }

    /// <summary>
    /// <para>无法获取元数据的文档列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("failed_list")]
    public MetaFailed[]? FailedLists { get; set; }

    /// <summary>
    /// <para>无法获取元数据的文档列表</para>
    /// </summary>
    public record MetaFailed
    {
        /// <summary>
        /// <para>获取元数据失败的文档token</para>
        /// <para>必填：是</para>
        /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>获取元数据失败的错误码</para>
        /// <para>必填：是</para>
        /// <para>示例值：970005</para>
        /// <para>可选值：<list type="bullet">
        /// <item>970002：Unsupporteddoc-type</item>
        /// <item>970003：Nopermissiontoaccessmeta</item>
        /// <item>970005：Recordnotfound(不存在或者已被删除)</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
