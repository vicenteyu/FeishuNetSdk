// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1AgenciesGetAgencyAccountResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询猎头供应商下猎头列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询猎头供应商下猎头列表 响应体
/// <para>根据猎头供应商 ID 查询该猎头供应商下的猎头列表。</para>
/// <para>接口ID：7413697955198058500</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/agency/get_agency_account</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fagency%2fget_agency_account</para>
/// </summary>
public record PostHireV1AgenciesGetAgencyAccountResponseDto : IPageableResponse<PostHireV1AgenciesGetAgencyAccountResponseDto.AgencyAccount>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>猎头列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AgencyAccount[]? Items { get; set; }

    /// <summary>
    /// <para>猎头列表</para>
    /// </summary>
    public record AgencyAccount
    {
        /// <summary>
        /// <para>猎头 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6995312261554538796</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>禁用原因，仅当`status`为`1`时填充</para>
        /// <para>必填：否</para>
        /// <para>示例值：这个猎头很不负责</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// <para>添加时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1639992265035</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>猎头状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：正常</item>
        /// <item>1：已禁用</item>
        /// <item>2：已被猎头供应商停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>猎头用户信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_info")]
        public AgencyAccountUser? UserInfo { get; set; }

        /// <summary>
        /// <para>猎头用户信息</para>
        /// </summary>
        public record AgencyAccountUser
        {
            /// <summary>
            /// <para>用户 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：7398623155442682156</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>用户名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>用户名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>用户中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>用户英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Zhangsan</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>用户邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：27188272xxxx1.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>用户手机</para>
            /// <para>必填：否</para>
            /// <para>示例值：1879087xxx8</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }
        }

        /// <summary>
        /// <para>角色</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：管理员</item>
        /// <item>1：顾问</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("role")]
        public int? Role { get; set; }
    }
}
