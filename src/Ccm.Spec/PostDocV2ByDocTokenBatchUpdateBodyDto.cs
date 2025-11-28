// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocV2ByDocTokenBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>编辑旧版文档内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 编辑旧版文档内容 请求体
/// <para>此接口只支持编辑旧版文档内容。要编辑新版文档（文档类型：`docx`）的内容，调用以下接口：</para>
/// <para>- [创建块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/create)</para>
/// <para>- [更新块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/patch)</para>
/// <para>- [批量更新块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block/batch_update)</para>
/// <para>- [删除块](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document-block-children/batch_delete)</para>
/// <para>接口ID：6908984614439813122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/content/batch-update-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYDM2YjL2AjN24iNwYjN</para>
/// </summary>
public record PostDocV2ByDocTokenBatchUpdateBodyDto
{
    /// <summary>
    /// <para>文件的 token，获取方式见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("docToken")]
    public string DocToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档的指定版本，文档新创建后版本号是0，[获取方式](https://open.feishu.cn/document/ukTMukTMukTM/uUDM2YjL1AjN24SNwYjN)，要求&gt;=0，post body json 字段</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("Revision")]
    public int Revision { get; set; }

    /// <summary>
    /// <para>post body json， OperationRequest 类型序列化 string 数组</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("Requests")]
    public string[] Requests { get; set; } = [];
}
