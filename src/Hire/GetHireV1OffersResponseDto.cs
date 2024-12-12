// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1OffersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 Offer 列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取 Offer 列表 响应体
/// <para>根据人才 ID 获取 Offer 列表。</para>
/// <para>接口ID：7054010541106921473</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2flist</para>
/// </summary>
public record GetHireV1OffersResponseDto
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
    /// <para>Offer 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public OfferListInfo[]? Items { get; set; }

    /// <summary>
    /// <para>Offer 列表</para>
    /// </summary>
    public record OfferListInfo
    {
        /// <summary>
        /// <para>Offer ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7096320678581242123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>Offer 职位</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_info")]
        public OfferJobInfo? JobInfo { get; set; }

        /// <summary>
        /// <para>Offer 职位</para>
        /// </summary>
        public record OfferJobInfo
        {
            /// <summary>
            /// <para>Offer 职位 ID，详情请参考[获取职位详情](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get_detail)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7080891505426925854</para>
            /// </summary>
            [JsonPropertyName("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>Offer 职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx</para>
            /// </summary>
            [JsonPropertyName("job_name")]
            public string? JobName { get; set; }
        }

        /// <summary>
        /// <para>创建时间戳（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1628512038000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>Offer 状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未申请</item>
        /// <item>2：审批中</item>
        /// <item>3：审批已撤回</item>
        /// <item>4：审批通过</item>
        /// <item>5：审批不通过</item>
        /// <item>6：Offer 已发出</item>
        /// <item>7：候选人已接受</item>
        /// <item>8：候选人已拒绝</item>
        /// <item>9：Offer 已失效</item>
        /// <item>10：未审批</item>
        /// <item>11：实习待入职（仅实习 Offer 具有）</item>
        /// <item>12：实习已入职（仅实习 Offer 具有）</item>
        /// <item>13：实习已离职（仅实习 Offer 具有）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("offer_status")]
        public int? OfferStatus { get; set; }

        /// <summary>
        /// <para>Offer 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：正式 Offer</item>
        /// <item>2：实习 Offer</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("offer_type")]
        public int? OfferType { get; set; }

        /// <summary>
        /// <para>Offer 人员类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public BaseBilingualWithId? EmployeeType { get; set; }

        /// <summary>
        /// <para>Offer 人员类型</para>
        /// </summary>
        public record BaseBilingualWithId
        {
            /// <summary>
            /// <para>Offer 人员类型 ID，与入参 `employee_type_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>Offer 人员类型中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：正式</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>Offer 人员类型英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Regular</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>Offer 投递 ID，获取投递信息请参考[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7096358713330272526</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }
    }
}
