// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1ReferralsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询人才内推信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询人才内推信息 响应体
/// <para>查询人才内推信息，按内推投递的「创建时间」正向排序</para>
/// <para>接口ID：7307160083569704963</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/referral/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral%2fsearch</para>
/// </summary>
public record PostHireV1ReferralsSearchResponseDto
{
    /// <summary>
    /// <para>内推信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ReferralInfo[]? Items { get; set; }

    /// <summary>
    /// <para>内推信息列表</para>
    /// </summary>
    public record ReferralInfo
    {
        /// <summary>
        /// <para>内推的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114322</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递 ID 列表，第一个投递就是原始投递ID，包含：</para>
        /// <para>- 原始内推的投递 ID</para>
        /// <para>- 转移到其他职位后的投递 ID</para>
        /// <para>- 不包含被HR复捞(加入职位）的投递 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("application_ids")]
        public string[]? ApplicationIds { get; set; }

        /// <summary>
        /// <para>创建时间（ms）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618899376474</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

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
            /// <para>内推人ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
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
