// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1ReferralsGetByApplicationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取内推信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取内推信息 响应体
/// <para>根据投递 ID 获取内推信息。</para>
/// <para>接口ID：6964264269274595330</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/referral/get_by_application</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral%2fget_by_application</para>
/// </summary>
public record GetHireV1ReferralsGetByApplicationResponseDto
{
    /// <summary>
    /// <para>内推信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("referral")]
    public GetHireV1ReferralsGetByApplicationResponseDtoReferral? Referral { get; set; }

    /// <summary>
    /// <para>内推信息</para>
    /// </summary>
    public record GetHireV1ReferralsGetByApplicationResponseDtoReferral
    {
        /// <summary>
        /// <para>内推的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6643786345878</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>投递 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：643452344576878</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string ApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// <para>创建时间（ms）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1618899376474</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public int CreateTime { get; set; }

        /// <summary>
        /// <para>内推人的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_xxxx</para>
        /// </summary>
        [JsonPropertyName("referral_user_id")]
        public string ReferralUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>内推人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("referral_user")]
        public IdNameObject? ReferralUser { get; set; }

        /// <summary>
        /// <para>内推人信息</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }
}
