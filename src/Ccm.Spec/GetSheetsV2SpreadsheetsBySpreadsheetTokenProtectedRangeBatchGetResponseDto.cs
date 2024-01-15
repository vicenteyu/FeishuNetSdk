namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取保护范围 响应体
/// <para>该接口用于根据保护范围ID查询详细的保护行列信息，最多支持同时查询5个ID。</para>
/// <para>1. 仅支持获取保护行或保护列，暂不支持获取保护单元格</para>
/// <para>2. 不支持获取包含多个区域的保护范围</para>
/// <para>接口ID：6923123667871596572</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/retrieve-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTM5YjL0ETO24CNxkjN</para>
/// </summary>
public record GetSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchGetResponseDto
{
    /// <summary>
    /// <para>保护范围</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("protectedRanges")]
    public ProtectedRange[]? ProtectedRanges { get; set; }

    /// <summary></summary>
    public record ProtectedRange
    {
        /// <summary>
        /// <para>保护范围ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("protectId")]
        public string? ProtectId { get; set; }

        /// <summary>
        /// <para>保护范围，如果为空，则为保护子表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>sheet 的 id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sheetId")]
            public string? SheetId { get; set; }

            /// <summary>
            /// <para>保护行列起始下标，下标从1开始</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("startIndex")]
            public int? StartIndex { get; set; }

            /// <summary>
            /// <para>保护行列终止下标，下标从1开始</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("endIndex")]
            public int? EndIndex { get; set; }

            /// <summary>
            /// <para>保护范围的维度，COLUMNS为保护列，ROWS为保护行</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string? MajorDimension { get; set; }
        }

        /// <summary>
        /// <para>sheet的id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>保护说明</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lockInfo")]
        public string? LockInfo { get; set; }

        /// <summary>
        /// <para>用户信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("editors")]
        public Editor? Editors { get; set; }

        /// <summary></summary>
        public record Editor
        {
            /// <summary>
            /// <para>用户信息列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("users")]
            public User[]? Users { get; set; }

            /// <summary></summary>
            public record User
            {
                /// <summary>
                /// <para>用户类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberType")]
                public string? MemberType { get; set; }

                /// <summary>
                /// <para>用户ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberId")]
                public string? MemberId { get; set; }
            }
        }
    }

}
