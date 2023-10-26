using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 实例列表查询 响应体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/query)该接口通过不同条件查询审批系统中符合条件的审批实例列表。</para>
/// <para>接口ID：6907568073251946498</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/approval-search/instance-list-query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjMxYjL0ITM24CNyEjN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceSearchResponseDto
{
    /// <summary>
    /// <para>查询返回条数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("count")]
    public int? Count { get; set; }

    /// <summary>
    /// <para>审批实例列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_list")]
    public InstanceItem[]? InstanceList { get; set; }

    /// <summary></summary>
    public record InstanceItem
    {
        /// <summary>
        /// <para>审批定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("approval")]
        public ApprovalSuffix? Approval { get; set; }

        /// <summary></summary>
        public record ApprovalSuffix
        {
            /// <summary>
            /// <para>审批定义 code</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>审批定义名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>是否为第三方审批</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("is_external")]
            public bool? IsExternal { get; set; }

            /// <summary>
            /// <para>第三方审批信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("external")]
            public ExternalSuffix? External { get; set; }

            /// <summary></summary>
            public record ExternalSuffix
            {
                /// <summary>
                /// <para>是否支持批量读</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("batch_cc_read")]
                public bool? BatchCcRead { get; set; }
            }
        }

        /// <summary>
        /// <para>审批定义分组</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("group")]
        public GroupSuffix? Group { get; set; }

        /// <summary></summary>
        public record GroupSuffix
        {
            /// <summary>
            /// <para>审批定义分组外部 id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("external_id")]
            public string? ExternalId { get; set; }

            /// <summary>
            /// <para>审批定义分组名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>审批实例信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("instance")]
        public InstanceSuffix? Instance { get; set; }

        /// <summary></summary>
        public record InstanceSuffix
        {
            /// <summary>
            /// <para>审批实例 code</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>审批实例外部 id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("external_id")]
            public string? ExternalId { get; set; }

            /// <summary>
            /// <para>审批实例发起人 id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批实例开始时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("start_time")]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>审批实例结束时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("end_time")]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>审批实例状态</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("status")]
            public string? Status { get; set; }

            /// <summary>
            /// <para>审批实例名称（只有第三方审批有）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>审批实例扩展字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("extra")]
            public string? Extra { get; set; }

            /// <summary>
            /// <para>审批流水号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("serial_id")]
            public string? SerialId { get; set; }

            /// <summary>
            /// <para>审批实例链接（只有第三方审批有）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("link")]
            public object? Link { get; set; }

            /// <summary></summary>
            public record LinkSuffix
            {
                /// <summary>
                /// <para>审批实例 pc 端链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("pc_link")]
                public string? PcLink { get; set; }

                /// <summary>
                /// <para>审批实例移动端链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("mobile_link")]
                public string? MobileLink { get; set; }
            }
        }
    }
}
