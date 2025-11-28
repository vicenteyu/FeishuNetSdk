// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1MetasBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文件元数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文件元数据 请求体
/// <para>该接口用于根据文件 token 获取其元数据，包括标题、所有者、创建时间、密级、访问链接等数据。</para>
/// <para>接口ID：7106040876741345308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmeta%2fbatch_query</para>
/// </summary>
public record PostDriveV1MetasBatchQueryBodyDto
{
    /// <summary>
    /// <para>请求的文件的 token 和类型。一次请求中不可超过 200 个</para>
    /// <para>必填：是</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("request_docs")]
    public RequestDoc[] RequestDocs { get; set; } = [];

    /// <summary>
    /// <para>请求的文件的 token 和类型。一次请求中不可超过 200 个</para>
    /// </summary>
    public record RequestDoc
    {
        /// <summary>
        /// <para>文件的 token，获取方式见[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)</para>
        /// <para>必填：是</para>
        /// <para>示例值：doccnfYZzTlvXqZIGTdAHKabcef</para>
        /// </summary>
        [JsonPropertyName("doc_token")]
        public string DocToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件的类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// <para>可选值：<list type="bullet">
        /// <item>doc：飞书文档</item>
        /// <item>sheet：飞书电子表格</item>
        /// <item>bitable：飞书多维表格</item>
        /// <item>mindnote：飞书思维笔记</item>
        /// <item>file：飞书文件</item>
        /// <item>wiki：飞书知识库</item>
        /// <item>docx：飞书新版文档</item>
        /// <item>folder：飞书文件夹</item>
        /// <item>synced_block：文档同步块（灰度中）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("doc_type")]
        public string DocType { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否获取文件的访问链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("with_url")]
    public bool? WithUrl { get; set; }
}
