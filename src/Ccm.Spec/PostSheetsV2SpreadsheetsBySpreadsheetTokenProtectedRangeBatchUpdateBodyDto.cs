namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 修改保护范围 请求体
/// <para>该接口用于根据保护范围ID修改保护范围，单次最多支持同时修改10个ID。</para>
/// <para>接口ID：6923123667871612956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/modify-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTM5YjL1ETO24SNxkjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateBodyDto
{
    /// <summary>
    /// <para>请求</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public Request[] Requests { get; set; } = Array.Empty<Request>();

    /// <summary></summary>
    public record Request
    {
        /// <summary>
        /// <para>保护范围ID，可以通过[获取表格元数据](https://open.feishu.cn/document/ukTMukTMukTM/uETMzUjLxEzM14SMxMTN) 接口获取</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("protectId")]
        public string ProtectId { get; set; } = string.Empty;

        /// <summary>
        /// <para>行列保护信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>sheetId</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string SheetId { get; set; } = string.Empty;

            /// <summary>
            /// <para>保护行列起始下标，下标从1开始</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("startIndex")]
            public int StartIndex { get; set; }

            /// <summary>
            /// <para>保护行列终止下标，下标从1开始</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("endIndex")]
            public int EndIndex { get; set; }

            /// <summary>
            /// <para>保护范围ID对应的保护范围的维度，COLUMNS为保护列，ROWS为保护行</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string MajorDimension { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>可编辑保护范围的用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("editors")]
        public EditorsSuffix? Editors { get; set; }

        /// <summary></summary>
        public record EditorsSuffix
        {
            /// <summary>
            /// <para>需要增加的用户的列表，用户需要有文档的编辑权限</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("addEditors")]
            public Editor[]? AddEditors { get; set; }

            /// <summary>
            /// <para>需要删除的用户的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("delEditors")]
            public Editor[]? DelEditors { get; set; }

            /// <summary></summary>
            public record Editor
            {
                /// <summary>
                /// <para>用户类型，支持userId,openId,unionId</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("memberType")]
                public string MemberType { get; set; } = string.Empty;

                /// <summary>
                /// <para>用户类型对应的用户ID</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("memberId")]
                public string MemberId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>保护说明</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lockInfo")]
        public string? LockInfo { get; set; }
    }
}
