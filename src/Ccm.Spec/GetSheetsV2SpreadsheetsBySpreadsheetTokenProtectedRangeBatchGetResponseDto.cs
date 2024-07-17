// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取保护范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取保护范围 响应体
/// <para>获取电子表格工作表中指定保护范围的信息，包括保护的行列索引、支持编辑的用户 ID、保护范围的备注等。</para>
/// <para>使用限制：</para>
/// <para>- 单次调用该接口，最多支持获取 5 个保护范围的信息。</para>
/// <para>- 不支持获取包含多个区域的保护范围。即如果一个保护范围中添加了多个区域，例如 B22:B26 和 C26:C28，则不支持调用该接口获取。</para>
/// <para>接口ID：6923123667871596572</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/retrieve-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTM5YjL0ETO24CNxkjN</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchGetResponseDto
{
    /// <summary>
    /// <para>保护范围的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("protectedRanges")]
    public ProtectedRange[]? ProtectedRanges { get; set; }

    /// <summary></summary>
    public record ProtectedRange
    {
        /// <summary>
        /// <para>保护范围的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("protectId")]
        public string? ProtectId { get; set; }

        /// <summary>
        /// <para>保护范围的维度信息。为空表示保护整个工作表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>工作表的 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string? SheetId { get; set; }

            /// <summary>
            /// <para>开始的行或列的索引。从 1 开始计数。若 `startIndex` 为 3，则从第 3 行或列开始保护。包含第 3 行或列。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("startIndex")]
            public int? StartIndex { get; set; }

            /// <summary>
            /// <para>结束的行或列的索引。从 1 开始计数。若 `endIndex` 为 7，则保护到第 7 行或列。包含第 7 行或列。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("endIndex")]
            public int? EndIndex { get; set; }

            /// <summary>
            /// <para>保护范围的维度。可选值：</para>
            /// <para>- ROWS：行</para>
            /// <para>- COLUMNS：列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string? MajorDimension { get; set; }
        }
        /// <summary>
        /// <para>工作表的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>保护范围的备注信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lockInfo")]
        public string? LockInfo { get; set; }

        /// <summary>
        /// <para>允许编辑保护范围的用户信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("editors")]
        public Editor? Editors { get; set; }

        /// <summary></summary>
        public record Editor
        {
            /// <summary>
            /// <para>用户信息的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("users")]
            public User[]? Users { get; set; }

            /// <summary></summary>
            public record User
            {
                /// <summary>
                /// <para>用户 ID 的类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberType")]
                public string? MemberType { get; set; }

                /// <summary>
                /// <para>用户的 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberId")]
                public string? MemberId { get; set; }
            }
        }
    }
}
