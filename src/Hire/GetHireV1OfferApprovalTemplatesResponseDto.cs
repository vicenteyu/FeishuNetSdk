// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="GetHireV1OfferApprovalTemplatesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 Offer 审批流列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取 Offer 审批流列表 响应体
/// <para>获取飞书招聘系统中默认和自定义 Offer 审批流列表。Offer 审批流可以在「飞书招聘」-「设置」-「Offer 设置」-「Offer 审批设置」中维护。可在职位设置的「Offer 审批流程」中使用。</para>
/// <para>接口ID：7002055120885235715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_approval_template/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_approval_template%2flist</para>
/// </summary>
public record GetHireV1OfferApprovalTemplatesResponseDto : IPageableResponse<GetHireV1OfferApprovalTemplatesResponseDto.OfferApprovalTemplate>
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
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>Offer 审批流列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public OfferApprovalTemplate[]? Items { get; set; }

    /// <summary>
    /// <para>Offer 审批流列表</para>
    /// </summary>
    public record OfferApprovalTemplate
    {
        /// <summary>
        /// <para>Offer 审批流 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1213213123123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>Offer 审批流名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>Offer 审批流名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>Offer 审批流中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Offer 审批流1</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>Offer 审批流英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Offer approval flow config 1</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>创建时间戳（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1628512038000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：test</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// <para>适用部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_list")]
        public Department[]? DepartmentLists { get; set; }

        /// <summary>
        /// <para>适用部门</para>
        /// </summary>
        public record Department
        {
            /// <summary>
            /// <para>部门 ID，与入参`department_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>部门中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：部门名A</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>部门英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：DepartmentA</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }
    }
}
