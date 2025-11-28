// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="PostCorehrV2SignatureFilesTerminateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>终止电子签文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 终止电子签文件 请求体
/// <para>该接口用于终止在签署流程中的电子签文件，不再执行后续的签署流程</para>
/// <para>接口ID：7420421437193633795</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/terminate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fterminate</para>
/// </summary>
public record PostCorehrV2SignatureFilesTerminateBodyDto
{
    /// <summary>
    /// <para>欲终止的电子签文件id列表，文件ID可以通过调用「获取电子签文件列表」接口获取</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[] Ids { get; set; } = [];

    /// <summary>
    /// <para>操作人ID，ID的格式取决于query传参中传入的user_id_type字段；ID获取方式见「查询参数」</para>
    /// <para>必填：是</para>
    /// <para>示例值：7386593105085988xxx</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; } = string.Empty;

    /// <summary>
    /// <para>终止原因，不得超过300字符</para>
    /// <para>必填：是</para>
    /// <para>示例值：请求流程发生变化，需要重新签署，因此终止签署流程中的文件</para>
    /// </summary>
    [JsonPropertyName("terminate_reason")]
    public string TerminateReason { get; set; } = string.Empty;
}
