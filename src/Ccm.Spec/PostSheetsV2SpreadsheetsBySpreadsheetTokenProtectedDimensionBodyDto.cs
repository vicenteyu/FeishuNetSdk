// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加保护范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 增加保护范围 请求体
/// <para>在电子表格工作表中设置多个保护范围，支持对行或列设置保护范围。</para>
/// <para>接口ID：6907569742383988738</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/add-locked-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDNzUjL4QzM14CO0MTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionBodyDto
{
    /// <summary>
    /// <para>需要增加保护范围的维度信息。支持传入多个维度信息。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("addProtectedDimension")]
    public ProtectedDimension[] AddProtectedDimension { get; set; } = Array.Empty<ProtectedDimension>();

    /// <summary></summary>
    public record ProtectedDimension
    {
        /// <summary>
        /// <para>要保护的行或列的信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix Dimension { get; set; } = new();

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>电子表格工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string SheetId { get; set; } = string.Empty;

            /// <summary>
            /// <para>更新的维度，默认 ROWS。可选值：</para>
            /// <para>- ROWS：行</para>
            /// <para>- COLUMNS：列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string? MajorDimension { get; set; }

            /// <summary>
            /// <para>开始的行或列的索引。从 1 开始计数。若 `startIndex` 为 3，则从第 3 行或列开始保护。包含第 3 行或列。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("startIndex")]
            public int StartIndex { get; set; }

            /// <summary>
            /// <para>结束的行或列的索引。从 1 开始计数。若 `endIndex` 为 7，则保护到第 7 行或列。包含第 7 行或列。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("endIndex")]
            public int EndIndex { get; set; }
        }

        /// <summary>
        /// <para>允许编辑保护范围的用户的 `lark_id`。该字段已不推荐使用，你可使用 `users` 参数代替。</para>
        /// <para>必填：否</para>
        /// </summary>
        [Obsolete("使用 `users` 参数代替")]
        [JsonPropertyName("editors")]
        public long[]? Editors { get; set; }

        /// <summary>
        /// <para>允许编辑保护范围的用户的 ID。ID 类型取决于查询参数 `user_id_type` 的取值。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("users")]
        public string[]? Users { get; set; }

        /// <summary>
        /// <para>保护范围的备注信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lockInfo")]
        public string? LockInfo { get; set; }

    }
}
