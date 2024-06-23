// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1MetasBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文件元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文件元数据 响应体
/// <para>该接口用于根据文件 token 获取其元数据，包括标题、所有者、创建时间、密级、访问链接等数据。</para>
/// <para>接口ID：7106040876741345308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmeta%2fbatch_query</para>
/// </summary>
public record PostDriveV1MetasBatchQueryResponseDto
{
    /// <summary>
    /// <para>文件的元数据列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("metas")]
    public Meta[] Metas { get; set; } = Array.Empty<Meta>();

    /// <summary>
    /// <para>文件的元数据列表</para>
    /// </summary>
    public record Meta
    {
        /// <summary>
        /// <para>文件的 token</para>
        /// <para>必填：是</para>
        /// <para>示例值：doccnfYZzTlvXqZIGTdAHKabcef</para>
        /// </summary>
        [JsonPropertyName("doc_token")]
        public string DocToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件的类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// </summary>
        [JsonPropertyName("doc_type")]
        public string DocType { get; set; } = string.Empty;

        /// <summary>
        /// <para>标题</para>
        /// <para>必填：是</para>
        /// <para>示例值：sampletitle</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件的所有者</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; } = string.Empty;

        /// <summary>
        /// <para>创建时间。UNIX 时间戳，单位为秒</para>
        /// <para>必填：是</para>
        /// <para>示例值：1652066345</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>最后编辑者</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_b13d41c02edc52ce66aaae67bf1abcef</para>
        /// </summary>
        [JsonPropertyName("latest_modify_user")]
        public string LatestModifyUser { get; set; } = string.Empty;

        /// <summary>
        /// <para>最后编辑时间。UNIX 时间戳，单位为秒</para>
        /// <para>必填：是</para>
        /// <para>示例值：1652066345</para>
        /// </summary>
        [JsonPropertyName("latest_modify_time")]
        public string LatestModifyTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>文档访问链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://sample.feishu.cn/docs/doccnfYZzTlvXqZIGTdAHKabcef</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// <para>文档密级标签名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：L2-内部</para>
        /// </summary>
        [JsonPropertyName("sec_label_name")]
        public string? SecLabelName { get; set; }
    }

    /// <summary>
    /// <para>获取元数据失败的文档 token 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_list")]
    public MetaFailed[]? FailedLists { get; set; }

    /// <summary>
    /// <para>获取元数据失败的文档 token 列表</para>
    /// </summary>
    public record MetaFailed
    {
        /// <summary>
        /// <para>获取元数据失败的文档token</para>
        /// <para>必填：是</para>
        /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>获取元数据失败的错误码</para>
        /// <para>必填：是</para>
        /// <para>示例值：970005</para>
        /// <para>可选值：<list type="bullet">
        /// <item>970002：文档类型不支持</item>
        /// <item>970003：当前应用或用户没有获取该文件元数据的权限</item>
        /// <item>970005：文件 token 和 doc_type 不匹配或该文件不存在</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
