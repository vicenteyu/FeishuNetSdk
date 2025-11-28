// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="PostCorehrV2SignatureFilesTerminateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>终止电子签文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 终止电子签文件 响应体
/// <para>该接口用于终止在签署流程中的电子签文件，不再执行后续的签署流程</para>
/// <para>接口ID：7420421437193633795</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/terminate</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fterminate</para>
/// </summary>
public record PostCorehrV2SignatureFilesTerminateResponseDto
{
    /// <summary>
    /// <para>欲终止的文件总数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// <para>成功总数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("success_count")]
    public int? SuccessCount { get; set; }

    /// <summary>
    /// <para>失败总数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("fail_count")]
    public int? FailCount { get; set; }

    /// <summary>
    /// <para>终止成功的文件id列表，可以通过[【获取电子签文件列表】](ssl:/uAjLw4CM/ukTMukTMukTM/corehr-v2/signature_file/list)接口获取文件详情信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("success_file_id_list")]
    public string[]? SuccessFileIdList { get; set; }

    /// <summary>
    /// <para>终止失败的文件id和对应的原因列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fail_file_id_and_reasons")]
    public TerminateSignatureFailIdAndReason[]? FailFileIdAndReasons { get; set; }

    /// <summary>
    /// <para>终止失败的文件id和对应的原因列表</para>
    /// </summary>
    public record TerminateSignatureFailIdAndReason
    {
        /// <summary>
        /// <para>终止操作失败的文件ID，可以通过[【获取电子签文件列表】](ssl:/uAjLw4CM/ukTMukTMukTM/corehr-v2/signature_file/list)接口获取文件详情信息</para>
        /// <para>必填：是</para>
        /// <para>示例值：7345403447803379731</para>
        /// </summary>
        [JsonPropertyName("signature_file_id")]
        public string SignatureFileId { get; set; } = string.Empty;

        /// <summary>
        /// <para>终止失败的原因</para>
        /// <para>必填：是</para>
        /// <para>示例值：文件状态不允许终止</para>
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; } = string.Empty;
    }
}
