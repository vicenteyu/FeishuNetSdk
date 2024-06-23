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
    [JsonPropertyName("replies")]
    public Reply[]? Replies { get; set; }

    /// <summary></summary>
    public record Reply
    {
        /// <summary>
        /// <para>sheet的id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sheetId")]
        public string? Sheetid { get; set; }

        /// <summary>
        /// <para>成功修改的保护行列信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dimension")]
        public DimensionSuffix? Dimension { get; set; }

        /// <summary></summary>
        public record DimensionSuffix
        {
            /// <summary>
            /// <para>sheetId</para>
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
            /// <para>保护范围的维度</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("majorDimension")]
            public string? MajorDimension { get; set; }
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
            /// <para>成功增加的用户的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("addEditors")]
            public Editor[]? AddEditors { get; set; }


            /// <summary>
            /// <para>成功删除的用户的列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("delEditors")]
            public Editor[]? DelEditors { get; set; }

            /// <summary></summary>
            public record Editor
            {
                /// <summary>
                /// <para>用户类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberType")]
                public string? MemberType { get; set; }

                /// <summary>
                /// <para>用户类型对应的用户ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("memberId")]
                public string? MemberId { get; set; }
            }
        }

        /// <summary>
        /// <para>成功修改的保护说明</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("lockInfo")]
        public string? LockInfo { get; set; }
    }
}
