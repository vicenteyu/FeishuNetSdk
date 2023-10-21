using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查询抄送列表 响应体
/// <para>该接口通过不同条件查询审批系统中符合条件的审批抄送列表。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=approval&version=v4&resource=instance&method=search_cc)</para>
/// <para>接口ID：7117964632137187331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search_cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fsearch_cc</para>
/// </summary>
public record PostApprovalV4InstancesSearchCcResponseDto
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
    [JsonProperty("cc_list")]
    public CcSearchItem[]? CcList { get; set; }

    public record CcSearchItem
    {
        /// <summary>
        /// <para>审批定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("approval")]
        public InstanceSearchApproval? Approval { get; set; }

        public record InstanceSearchApproval
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
            public InstanceSearchApprovalExternal? External { get; set; }

            public record InstanceSearchApprovalExternal
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
        public InstanceSearchGroup? Group { get; set; }

        public record InstanceSearchGroup
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
        public InstanceSearchNode? Instance { get; set; }

        public record InstanceSearchNode
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
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>审批实例结束时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>审批实例状态</para>
            /// <para>**可选值有**：</para>
            /// <para>reject:拒绝,pending:审批中,recall:撤回,deleted:已删除,approved:通过</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>reject：拒绝</item>
            /// <item>pending：审批中</item>
            /// <item>recall：撤回</item>
            /// <item>deleted：已删除</item>
            /// <item>approved：通过</item>
            /// </list></para>
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
            /// <para>审批实例扩展字段，string型json</para>
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
            public InstanceSearchLink? Link { get; set; }
        }

        /// <summary>
        /// <para>审批抄送</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("cc")]
        public CcSearchNode? Cc { get; set; }

        public record CcSearchNode
        {
            /// <summary>
            /// <para>审批抄送发起人 id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批抄送开始时间</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>审批抄送状态</para>
            /// <para>**可选值有**：</para>
            /// <para>read:已读,unread:未读</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>read：已读</item>
            /// <item>unread：未读</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("read_status")]
            public string? ReadStatus { get; set; }

            /// <summary>
            /// <para>审批抄送名称（只有第三方审批有）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>审批抄送扩展字段，string型json</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("extra")]
            public string? Extra { get; set; }

            /// <summary>
            /// <para>审批抄送链接（只有第三方审批有）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("link")]
            public InstanceSearchLink? Link { get; set; }
        }

        public record InstanceSearchLink
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

    /// <summary>
    /// <para>翻页 Token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否有更多任务可供拉取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
