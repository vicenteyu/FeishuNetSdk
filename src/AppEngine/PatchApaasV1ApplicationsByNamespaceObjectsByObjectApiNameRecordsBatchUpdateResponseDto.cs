// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量编辑记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量编辑记录 响应体
/// <para>一次编辑多条对象中的记录</para>
/// <para>接口ID：7384730094872969244</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fbatch_update</para>
/// </summary>
public record PatchApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsBatchUpdateResponseDto
{
    /// <summary>
    /// <para>处理结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public RecordResult[]? Items { get; set; }

    /// <summary>
    /// <para>处理结果</para>
    /// </summary>
    public record RecordResult
    {
        /// <summary>
        /// <para>是否成功</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// <para>记录 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1801464965461024</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>权限错误时的细分 code</para>
        /// <para>必填：否</para>
        /// <para>最大长度：512</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("errors")]
        public RecordResultError[]? Errors { get; set; }

        /// <summary>
        /// <para>权限错误时的细分 code</para>
        /// </summary>
        public record RecordResultError
        {
            /// <summary>
            /// <para>错误码</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>success</para>
            /// <para>必填：是</para>
            /// <para>示例值：success</para>
            /// <para>最大长度：1000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("message")]
            public string Message { get; set; } = string.Empty;

            /// <summary>
            /// <para>权限错误时的细分 code</para>
            /// <para>必填：否</para>
            /// <para>示例值：k_ec_00001</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("sub_code")]
            public string? SubCode { get; set; }

            /// <summary>
            /// <para>权限错误时的涉及的字段 APIID 集合</para>
            /// <para>必填：否</para>
            /// <para>最大长度：256</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("fields")]
            public string[]? Fields { get; set; }
        }
    }
}
