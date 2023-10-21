using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取保护范围 响应体
/// <para>该接口用于根据保护范围ID查询详细的保护行列信息，最多支持同时查询5个ID。</para>
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
    [JsonProperty("protectedRange")]
    public ProtectedRange[]? ProtectedRanges { get; set; }

    public record ProtectedRange
    {
        /// <summary>
        /// <para>保护范围ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("protectId")]
        public string? ProtectId { get; set; }

        /// <summary>
        /// <para>保护范围，如果为空，则为保护子表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        public record DimensionSuffix
        {
            /// <summary>
            /// <para>sheet 的 id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("sheetId")]
            public string? SheetId { get; set; }

            /// <summary>
            /// <para>保护行列起始下标，下标从1开始</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("startIndex")]
            public int? StartIndex { get; set; }

            /// <summary>
            /// <para>保护行列终止下标，下标从1开始</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("endIndex")]
            public int? EndIndex { get; set; }

            /// <summary>
            /// <para>保护范围的维度，COLUMNS为保护列，ROWS为保护行</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("majorDimension")]
            public string? MajorDimension { get; set; }
        }

        /// <summary>
        /// <para>sheet的id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sheetId")]
        public string? SheetId { get; set; }

        /// <summary>
        /// <para>保护说明</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("lockInfo")]
        public string? LockInfo { get; set; }

        /// <summary>
        /// <para>用户信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("editors")]
        public Editor? Editors { get; set; }

        public record Editor
        {
            /// <summary>
            /// <para>用户信息列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("users")]
            public User[]? Users { get; set; }

            public record User
            {
                /// <summary>
                /// <para>用户类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("memberType")]
                public string? MemberType { get; set; }

                /// <summary>
                /// <para>用户ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("memberId")]
                public string? MemberId { get; set; }
            }
        }
    }

}
