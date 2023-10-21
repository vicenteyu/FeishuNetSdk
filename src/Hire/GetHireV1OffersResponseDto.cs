using Newtonsoft.Json;
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
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>Offer 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
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
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>Offer 职位</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_info")]
        public OfferJobInfo? JobInfo { get; set; }

        /// <summary>
        /// <para>Offer 职位</para>
        /// </summary>
        public record OfferJobInfo
        {
            /// <summary>
            /// <para>Offer 职位 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7080891505426925854</para>
            /// </summary>
            [JsonProperty("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>Offer 职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx</para>
            /// </summary>
            [JsonProperty("job_name")]
            public string? JobName { get; set; }
        }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1628512038000</para>
        /// </summary>
        [JsonProperty("create_time")]
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
        /// <item>6：Offer已发出</item>
        /// <item>7：候选人已接受</item>
        /// <item>8：候选人已拒绝</item>
        /// <item>9：Offer已失效</item>
        /// <item>10：未审批</item>
        /// <item>11：实习待入职（仅实习Offer具有）</item>
        /// <item>12：实习已入职（仅实习Offer具有）</item>
        /// <item>13：实习已离职（仅实习Offer具有）</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("offer_status")]
        public int? OfferStatus { get; set; }

        /// <summary>
        /// <para>Offer 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：正式Offer</item>
        /// <item>2：实习Offer</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("offer_type")]
        public int? OfferType { get; set; }

        /// <summary>
        /// <para>Offer 人员类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("employee_type")]
        public BaseBilingualWithId? EmployeeType { get; set; }

        /// <summary>
        /// <para>Offer 人员类型</para>
        /// </summary>
        public record BaseBilingualWithId
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：正式</para>
            /// </summary>
            [JsonProperty("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Regular</para>
            /// </summary>
            [JsonProperty("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>Offer 投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7096358713330272526</para>
        /// </summary>
        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }
    }
}
