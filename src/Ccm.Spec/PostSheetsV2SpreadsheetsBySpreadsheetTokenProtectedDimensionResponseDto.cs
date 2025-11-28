// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加保护范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 增加保护范围 响应体
/// <para>在电子表格工作表中设置多个保护范围，支持对行或列设置保护范围。</para>
/// <para>接口ID：6907569742383988738</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/add-locked-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDNzUjL4QzM14CO0MTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionResponseDto
{
    /// <summary>
    /// <para>保护范围的维度信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("addProtectedDimension")]
    public ProtectedDimension[] AddProtectedDimension { get; set; } = [];

    /// <summary></summary>
    public record ProtectedDimension
    {
        /// <summary>
        /// <para>保护范围的信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>保护范围所在的工作表的 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string? SheetId { get; set; }

            /// <summary>
            /// <para>保护范围的维度。枚举值：</para>
            /// <para>- ROWS：行</para>
            /// <para>- COLUMNS：列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string? MajorDimension { get; set; }

            /// <summary>
            /// <para>保护范围开始的行或列的索引。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("startIndex")]
            public int? StartIndex { get; set; }

            /// <summary>
            /// <para>保护范围结束的行或列的索引。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("endIndex")]
            public int? EndIndex { get; set; }
        }
        /// <summary>
        /// <para>允许编辑保护范围的用户的 `lark_id`。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("editors")]
        public long[]? Editors { get; set; }

        /// <summary>
        /// <para>允许编辑保护范围的用户的 ID。ID 类型取决于查询参数 `user_id_type`。</para>
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

        /// <summary>
        /// <para>保护范围的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("protectId")]
        public string? ProtectId { get; set; }
    }
}
