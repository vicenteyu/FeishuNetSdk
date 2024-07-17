// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改保护范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 修改保护范围 请求体
/// <para>修改电子表格工作表中指定的保护范围。</para>
/// <para>使用限制：单次调用该接口，最多支持修改 10 个保护范围。</para>
/// <para>接口ID：6923123667871612956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/modify-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTM5YjL1ETO24SNxkjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateBodyDto
{
    /// <summary>
    /// <para>需要增加保护范围的维度信息。支持传入多个维度信息。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public Request[] Requests { get; set; } = Array.Empty<Request>();

    /// <summary></summary>
    public record Request
    {
        /// <summary>
        /// <para>保护范围 ID，可通过[获取表格元数据](https://open.feishu.cn/document/ukTMukTMukTM/uETMzUjLxEzM14SMxMTN) 获取。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("protectId")]
        public string ProtectId { get; set; } = string.Empty;

        /// <summary>
        /// <para>要保护的行或列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>电子表格工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string SheetId { get; set; } = string.Empty;

            /// <summary>
            /// <para>保护范围的维度。可选值：</para>
            /// <para>- ROWS：行</para>
            /// <para>- COLUMNS：列</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string MajorDimension { get; set; } = string.Empty;

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
        /// <para>增加或删除可编辑保护范围的用户 ID 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("editors")]
        public EditorsSuffix? Editors { get; set; }

        /// <summary></summary>
        public record EditorsSuffix
        {
            /// <summary>
            /// <para>增加的用户 ID 列表，用户需要有文档的编辑权限。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("addEditors")]
            public Editor[]? AddEditors { get; set; }

            /// <summary></summary>
            public record Editor
            {
                /// <summary>
                /// <para>用户 ID 类型，可选值：</para>
                /// <para>- userId：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。详情参考[如何获取 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)</para>
                /// <para>- openId：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。详情参考[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
                /// <para>- unionId：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。详情参考[如何获取 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("memberType")]
                public string MemberType { get; set; } = string.Empty;

                /// <summary>
                /// <para>用户 ID，类型由 `memberType` 决定。</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("memberId")]
                public string MemberId { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>需要删除的用户的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("delEditors")]
            public Editor[]? DelEditors { get; set; }
        }

        /// <summary>
        /// <para>保护范围的备注信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lockInfo")]
        public string? LockInfo { get; set; }
    }
}