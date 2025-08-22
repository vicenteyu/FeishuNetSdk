// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetTenantV2TenantAssignInfoListQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取企业席位信息接口 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tenant;
/// <summary>
/// 获取企业席位信息接口 响应体
/// <para>获取租户下待分配的席位列表（仅返回未满的席位），包含席位名称、席位ID、数量及对应有效期。</para>
/// <para>返回的待分配席位范围为：​</para>
/// <para>1. 客户当前已订阅且处于生效状态的席位（注：不包含增购的、尚未生效的未来席位）；​</para>
/// <para>2. 客户已订阅且未来生效的全新订阅席位。​</para>
/// <para>即增购的未来席位不在本接口返回的待分配席位列表范围内。</para>
/// <para>接口ID：7204729599813222401</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/tenant-v2/tenant-product_assign_info/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftenant-v2%2ftenant-product_assign_info%2fquery</para>
/// </summary>
public record GetTenantV2TenantAssignInfoListQueryResponseDto
{
    /// <summary>
    /// <para>租户待分配席位列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("assign_info_list")]
    public TenantAssignInfo[]? AssignInfoLists { get; set; }

    /// <summary>
    /// <para>租户待分配席位列表</para>
    /// </summary>
    public record TenantAssignInfo
    {
        /// <summary>
        /// <para>席位id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7079609167680782300</para>
        /// </summary>
        [JsonPropertyName("subscription_id")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// <para>license_plan_key</para>
        /// <para>必填：否</para>
        /// <para>示例值：suite_enterprise_e5</para>
        /// </summary>
        [JsonPropertyName("license_plan_key")]
        public string? LicensePlanKey { get; set; }

        /// <summary>
        /// <para>商业化产品名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：旗舰版 E5</para>
        /// </summary>
        [JsonPropertyName("product_name")]
        public string? ProductName { get; set; }

        /// <summary>
        /// <para>国际化名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n_name")]
        public ProductI18nName? I18nName { get; set; }

        /// <summary>
        /// <para>国际化名称</para>
        /// </summary>
        public record ProductI18nName
        {
            /// <summary>
            /// <para>商业化产品的中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：zh_cn_name</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>商业化产品的日文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：ja_jp_name</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }

            /// <summary>
            /// <para>商业化产品的英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：en_name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>席位总数</para>
        /// <para>必填：否</para>
        /// <para>示例值：500</para>
        /// </summary>
        [JsonPropertyName("total_seats")]
        public string? TotalSeats { get; set; }

        /// <summary>
        /// <para>已分配席位数</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// </summary>
        [JsonPropertyName("assigned_seats")]
        public string? AssignedSeats { get; set; }

        /// <summary>
        /// <para>席位起始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1674981000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>席位结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1674991000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }
}
