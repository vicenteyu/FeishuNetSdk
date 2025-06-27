// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSuiteDocsApiMetaResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取元数据 响应体
/// <para>该接口用于根据 token 获取各类文件的元数据。</para>
/// <para>请求用户需要拥有该文件的访问（读）权限</para>
/// <para>接口ID：6907569743420637186</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/obtain-metadata</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjN3UjLzYzN14yM2cTN</para>
/// </summary>
public record PostSuiteDocsApiMetaResponseDto
{
    /// <summary>
    /// <para>文件元数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("docs_metas")]
    public DocsMeta[]? DocsMetas { get; set; }

    /// <summary></summary>
    public record DocsMeta
    {
        /// <summary>
        /// <para>文件token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("docs_token")]
        public string? DocsToken { get; set; }

        /// <summary>
        /// <para>文件类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("docs_type")]
        public string? DocsType { get; set; }

        /// <summary>
        /// <para>标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>文件拥有者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>创建时间（Unix时间戳）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>最后编辑者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("latest_modify_user")]
        public string? LatestModifyUser { get; set; }

        /// <summary>
        /// <para>最后编辑时间（Unix时间戳）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("latest_modify_time")]
        public long? LatestModifyTime { get; set; }
    }
}
