using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 修改保护范围 响应体
/// <para>该接口用于根据保护范围ID修改保护范围，单次最多支持同时修改10个ID。</para>
/// <para>接口ID：6923123667871612956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/modify-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTM5YjL1ETO24SNxkjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateResponseDto
{
    /// <summary>
    /// <para>响应</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("replies")]
    public Reply[]? Replies { get; set; }

    public record Reply
    {
        /// <summary>
        /// <para>sheet的id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sheetId")]
        public string? Sheetid { get; set; }

        /// <summary>
        /// <para>成功修改的保护行列信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        public record DimensionSuffix
        {
            /// <summary>
            /// <para>sheetId</para>
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
            /// <para>保护范围的维度</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("majorDimension")]
            public string? MajorDimension { get; set; }
        }

        /// <summary>
        /// <para>可编辑保护范围的用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("editors")]
        public EditorsSuffix? Editors { get; set; }

        public record EditorsSuffix
        {
            /// <summary>
            /// <para>成功增加的用户的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("addEditors")]
            public Editor[]? AddEditors { get; set; }


            /// <summary>
            /// <para>成功删除的用户的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("delEditors")]
            public Editor[]? DelEditors { get; set; }

            public record Editor
            {
                /// <summary>
                /// <para>用户类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("memberType")]
                public string? MemberType { get; set; }

                /// <summary>
                /// <para>用户类型对应的用户ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("memberId")]
                public string? MemberId { get; set; }
            }
        }

        /// <summary>
        /// <para>成功修改的保护说明</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("lockInfo")]
        public string? LockInfo { get; set; }
    }
}
