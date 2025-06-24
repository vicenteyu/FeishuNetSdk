// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetSheetsV2SpreadsheetsBySpreadsheetTokenMetainfoResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取表格元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取表格元数据 响应体
/// <para>该接口用于根据 spreadsheetToken 获取表格元数据。</para>
/// <para>接口ID：6907569744330227713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/obtain-spreadsheet-metadata</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETMzUjLxEzM14SMxMTN</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenMetainfoResponseDto
{
    /// <summary>
    /// <para>spreadsheet 的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheetToken")]
    public string? SpreadsheetToken { get; set; }

    /// <summary>
    /// <para>spreadsheet 的属性</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("properties")]
    public Property? Properties { get; set; }

    /// <summary></summary>
    public record Property
    {
        /// <summary>
        /// <para>spreadsheet 的标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>所有者的 id，仅user_id_type为空时返回该值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ownerUser")]
        public long? OwnerUser { get; set; }

        /// <summary>
        /// <para>所有者的 id，取决于user_id_type的值，仅user_id_type不为空时返回该值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ownerUserID")]
        public string? OwnerUserID { get; set; }

        /// <summary>
        /// <para>spreadsheet 下的 sheet 数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheetCount")]
        public int? SheetCount { get; set; }

        /// <summary>
        /// <para>该 sheet 的版本</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }
    }

    /// <summary>
    /// <para>spreadsheet 下的sheet列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sheets")]
    public Sheet[]? Sheets { get; set; }

    /// <summary></summary>
    public record Sheet
    {
        /// <summary>
        /// <para>sheet 的 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>sheet 的标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>sheet 的位置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// <para>sheet 的最大行数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rowCount")]
        public int? RowCount { get; set; }

        /// <summary>
        /// <para>sheet 的最大列数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("columnCount")]
        public int? ColumnCount { get; set; }

        /// <summary>
        /// <para>该 sheet 的冻结行数，小于等于 sheet 的最大行数，0表示未设置冻结</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("frozenRowCount")]
        public int? FrozenRowCount { get; set; }

        /// <summary>
        /// <para>该 sheet 的冻结列数，小于等于 sheet 的最大列数，0表示未设置冻结</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("frozenColCount")]
        public int? FrozenColCount { get; set; }

        /// <summary>
        /// <para>该 sheet 中合并单元格的范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("merges")]
        public Merge[]? Merges { get; set; }

        /// <summary></summary>
        public record Merge
        {
            /// <summary>
            /// <para>合并单元格范围的开始行下标，index 从 0 开始</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("startRowIndex")]
            public int? StartRowIndex { get; set; }

            /// <summary>
            /// <para>合并单元格范围的开始列下标，index 从 0 开始</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("startColumnIndex")]
            public int? StartColumnIndex { get; set; }

            /// <summary>
            /// <para>合并单元格范围的行数量</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("rowCount")]
            public int? RowCount { get; set; }

            /// <summary>
            /// <para>合并单元格范围的列数量</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("columnCount")]
            public int? ColumnCount { get; set; }
        }

        /// <summary>
        /// <para>该 sheet 中保护范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("protectedRange")]
        public ProtectedRangeSuffix[]? ProtectedRange { get; set; }

        /// <summary></summary>
        public record ProtectedRangeSuffix
        {
            /// <summary>
            /// <para>保护行列的信息，如果为保护工作表，则该字段为空</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dimension")]
            public DimensionSuffix? Dimension { get; set; }

            /// <summary></summary>
            public record DimensionSuffix
            {
                /// <summary>
                /// <para>保护行列的起始位置，位置从1开始</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("startIndex")]
                public int? StartIndex { get; set; }

                /// <summary>
                /// <para>保护行列的结束位置，位置从1开始</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("endIndex")]
                public int? EndIndex { get; set; }

                /// <summary>
                /// <para>若为ROWS，则为保护行；为COLUMNS，则为保护列</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("majorDimension")]
                public string? MajorDimension { get; set; }

                /// <summary>
                /// <para>保护范围所在工作表 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("sheetId")]
                public string? SheetId { get; set; }
            }

            /// <summary>
            /// <para>保护范围ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("protectId")]
            public string? ProtectId { get; set; }

            /// <summary>
            /// <para>保护说明</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("lockInfo")]
            public string? LockInfo { get; set; }

            /// <summary>
            /// <para>保护工作表 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string? SheetId { get; set; }
        }

        /// <summary>
        /// <para>若含有该字段，则此工作表不为表格</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("blockInfo")]
        public BlockInfoSuffix? BlockInfo { get; set; }

        /// <summary></summary>
        public record BlockInfoSuffix
        {
            /// <summary>
            /// <para>block的token</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("blockToken")]
            public string? BlockToken { get; set; }

            /// <summary>
            /// <para>block的类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("blockType")]
            public string? BlockType { get; set; }
        }
    }
}
