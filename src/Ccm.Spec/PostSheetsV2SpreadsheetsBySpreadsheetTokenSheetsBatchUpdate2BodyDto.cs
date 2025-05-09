// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-10
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2BodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新工作表属性 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新工作表属性 请求体
/// <para>更新电子表格中的工作表。支持更新工作表的标题、位置，和隐藏、冻结、保护等属性。</para>
/// <para>该接口和 [操作工作表](https://open.feishu.cn/document/ukTMukTMukTM/uYTMzUjL2EzM14iNxMTN) 的请求地址相同，但参数不同，调用前请仔细阅读文档。</para>
/// <para>接口ID：6907569743419473922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/update-sheet-properties</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugjMzUjL4IzM14COyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2BodyDto
{
    /// <summary>
    /// <para>更新工作表属性的请求。一次请求可以进行多次更新操作。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public Request[] Requests { get; set; } = Array.Empty<Request>();

    /// <summary></summary>
    public record Request
    {
        /// <summary>
        /// <para>更新工作表。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updateSheet")]
        public UpdateSheetSuffix? UpdateSheet { get; set; }

        /// <summary></summary>
        public record UpdateSheetSuffix
        {
            /// <summary>
            /// <para>工作表属性</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("properties")]
            public PropertiesSuffix Properties { get; set; } = new();

            /// <summary></summary>
            public record PropertiesSuffix
            {
                /// <summary>
                /// <para>要更新的工作表的 ID。调用[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query)获取 ID。</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("sheetId")]
                public string SheetId { get; set; } = string.Empty;

                /// <summary>
                /// <para>工作表的标题。更新的标题需符合以下规则：</para>
                /// <para>- 长度不超过 100 个字符</para>
                /// <para>- 不包含这些特殊字符：`/ \ ? * [ ] :`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// <para>工作表的位置。从 0 开始计数。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("index")]
                public int? Index { get; set; }

                /// <summary>
                /// <para>是否要隐藏表格。默认值为 false。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("hidden")]
                public bool? Hidden { get; set; }

                /// <summary>
                /// <para>要冻结至指定行的行索引。若填 3，表示从第一行冻结至第三行。小于或等于工作表的最大行数，0 表示取消冻结行。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("frozenRowCount")]
                public int? FrozenRowCount { get; set; }

                /// <summary>
                /// <para>要冻结至指定列的列索引。若填 3，表示从第一列冻结至第三列。小于等于工作表的最大列数，0 表示取消冻结列。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("frozenColCount")]
                public int? FrozenColCount { get; set; }

                /// <summary>
                /// <para>是否要保护该工作表。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("protect")]
                public ProtectSuffix? Protect { get; set; }

                /// <summary></summary>
                public record ProtectSuffix
                {
                    /// <summary>
                    /// <para>是否要保护该工作表。可选值：</para>
                    /// <para>- LOCK：保护</para>
                    /// <para>- UNLOCK：取消保护</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("lock")]
                    public string Lock { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>保护工作表的备注信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("lockInfo")]
                    public string? LockInfo { get; set; }

                    /// <summary>
                    /// <para>添加除操作用户与所有者外其他用户的 ID，为其开通保护范围的编辑权限。ID 类型由查询参数 `user_id_type` 决定。`user_id_type` 不为空时，该字段生效。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("userIDs")]
                    public string[]? UserIDs { get; set; }
                }
            }
        }
    }
}
