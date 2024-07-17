// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改保护范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 修改保护范围 响应体
/// <para>修改电子表格工作表中指定的保护范围。</para>
/// <para>使用限制：单次调用该接口，最多支持修改 10 个保护范围。</para>
/// <para>接口ID：6923123667871612956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/modify-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTM5YjL1ETO24SNxkjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateResponseDto
{
    /// <summary>
    /// <para>修改后的保护范围的信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("replies")]
    public Reply[]? Replies { get; set; }

    /// <summary></summary>
    public record Reply
    {
        /// <summary>
        /// <para>保护范围 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("protectId")]
        public string? ProtectId { get; set; }

        /// <summary>
        /// <para>工作表 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>保护的行或列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>电子表格工作表的 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string? SheetId { get; set; }

            /// <summary>
            /// <para>开始的行或列的索引。从 1 开始计数。若 startIndex 为 3，则从第 3 行或列开始保护。包含第 3 行或列。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("startIndex")]
            public int? StartIndex { get; set; }

            /// <summary>
            /// <para>结束的行或列的索引。从 1 开始计数。若 endIndex 为 7，则保护到第 7 行或列。包含第 7 行或列。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("endIndex")]
            public int? EndIndex { get; set; }

            /// <summary>
            /// <para>保护范围的维度。枚举值：</para>
            /// <para>- ROWS：行</para>
            /// <para>- COLUMNS：列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string? MajorDimension { get; set; }
        }

        /// <summary>
        /// <para>增加或删除的可编辑保护范围的用户 ID 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("editors")]
        public EditorsSuffix? Editors { get; set; }

        /// <summary></summary>
        public record EditorsSuffix
        {
            /// <summary>
            /// <para>增加的用户 ID 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("addEditors")]
            public Editor[]? AddEditors { get; set; }

            /// <summary></summary>
            public record Editor
            {
                /// <summary>
                /// <para>用户 ID 类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberType")]
                public string? MemberType { get; set; }

                /// <summary>
                /// <para>用户 ID，类型由 memberType 决定。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberId")]
                public string? MemberId { get; set; }
            }

            /// <summary>
            /// <para>删除的用户的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("delEditors")]
            public Editor[]? DelEditors { get; set; }
        }

        /// <summary>
        /// <para>修改的备注信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lockInfo")]
        public string? LockInfo { get; set; }
    }
}