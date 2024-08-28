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
/// <para>根据人才查询内推信息列表，包含内推人信息、内推时间、投递 ID等，按内推投递的`创建时间`从小到大排序返回。</para>
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
        /// <para>内推 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114322</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递 ID 列表，详情请查看[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)。通常情况下1次内推仅有1个投递 ID，即内推原始投递 ID（列表中的第一个 ID）。</para>
        /// <para>若投递发生过转移，还会包含「转移到其他职位后的投递 ID」。</para>
        /// <para>但不包含投递结束后被HR复捞（加入职位）的投递 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("application_ids")]
        public string[]? ApplicationIds { get; set; }

        /// <summary>
        /// <para>内推创建时间，毫秒时间戳</para>
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
            /// <para>内推人 ID，跟`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>内推人名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>内推人名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：zhangsan</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }
}
