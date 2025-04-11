// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSecurityAndComplianceV1OpenapiLogsListDataResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取OpenAPI审计日志数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 获取OpenAPI审计日志数据 响应体
/// <para>该接口用于获取OpenAPI审计日志数据</para>
/// <para>接口ID：7283168587871223810</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/openapi_log/list_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fopenapi_log%2flist_data</para>
/// </summary>
public record PostSecurityAndComplianceV1OpenapiLogsListDataResponseDto
{
    /// <summary>
    /// <para>openapi日志列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public OpenapiLog[]? Items { get; set; }

    /// <summary>
    /// <para>openapi日志列表</para>
    /// </summary>
    public record OpenapiLog
    {
        /// <summary>
        /// <para>openapi日志唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：111</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>飞书开放平台定义的API</para>
        /// <para>必填：是</para>
        /// <para>示例值：POST/open-apis/authen/v1/access_token</para>
        /// </summary>
        [JsonPropertyName("api_key")]
        public string ApiKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>日志产生的时间，以秒为单位的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1610613336</para>
        /// </summary>
        [JsonPropertyName("event_time")]
        public int? EventTime { get; set; }

        /// <summary>
        /// <para>调用OpenAPI的应用唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：cli_xxx</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// <para>发起调用api的ip地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：192.123.12.1或fdbd:ff1:ce00:135:c7e:d128:5028:6546</para>
        /// </summary>
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// <para>openapi调用日志详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("log_detail")]
        public OpenapiLogDetail? LogDetail { get; set; }

        /// <summary>
        /// <para>openapi调用日志详情</para>
        /// </summary>
        public record OpenapiLogDetail
        {
            /// <summary>
            /// <para>http请求路径</para>
            /// <para>必填：否</para>
            /// <para>示例值：/open-apis/auth/v3/app_access_token</para>
            /// </summary>
            [JsonPropertyName("path")]
            public string? Path { get; set; }

            /// <summary>
            /// <para>http请求方法</para>
            /// <para>必填：否</para>
            /// <para>示例值：POST</para>
            /// </summary>
            [JsonPropertyName("method")]
            public string? Method { get; set; }

            /// <summary>
            /// <para>http查询参数</para>
            /// <para>必填：否</para>
            /// <para>示例值：{}</para>
            /// </summary>
            [JsonPropertyName("query_param")]
            public string? QueryParam { get; set; }

            /// <summary>
            /// <para>http请求体</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"app_id": "cli_xxx", "app_secret": "xxx", "app_ticket": "xxx"}</para>
            /// </summary>
            [JsonPropertyName("payload")]
            public string? Payload { get; set; }

            /// <summary>
            /// <para>http状态码</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("status_code")]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>http响应体，仅返回code，msg，error信息等</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"code": 0, "msg": "ok"}</para>
            /// </summary>
            [JsonPropertyName("response")]
            public string? Response { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
