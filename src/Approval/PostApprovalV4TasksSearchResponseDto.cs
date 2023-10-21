using Newtonsoft.Json;
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询任务列表 响应体
/// <para>该接口通过不同条件查询审批系统中符合条件的审批任务列表。</para>
/// <para>接口ID：7117964632137138179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fsearch</para>
/// </summary>
public record PostApprovalV4TasksSearchResponseDto
{
    /// <summary>
    /// <para>查询返回条数</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonProperty("count")]
    public int? Count { get; set; }

    /// <summary>
    /// <para>审批任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("task_list")]
    public TaskSearchItem[]? TaskLists { get; set; }

    /// <summary>
    /// <para>审批任务列表</para>
    /// </summary>
    public record TaskSearchItem
    {
        /// <summary>
        /// <para>审批定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("approval")]
        public InstanceSearchApproval? Approval { get; set; }

        /// <summary>
        /// <para>审批定义</para>
        /// </summary>
        public record InstanceSearchApproval
        {
            /// <summary>
            /// <para>审批定义 code</para>
            /// <para>必填：否</para>
            /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
            /// </summary>
            [JsonProperty("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>审批定义名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：approval</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>是否为第三方审批</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_external")]
            public bool? IsExternal { get; set; }

            /// <summary>
            /// <para>第三方审批信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("external")]
            public InstanceSearchApprovalExternal? External { get; set; }

            /// <summary>
            /// <para>第三方审批信息</para>
            /// </summary>
            public record InstanceSearchApprovalExternal
            {
                /// <summary>
                /// <para>是否支持批量读</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonProperty("batch_cc_read")]
                public bool? BatchCcRead { get; set; }
            }

            /// <summary>
            /// <para>审批定义Id</para>
            /// <para>必填：否</para>
            /// <para>示例值：7090754740375519252</para>
            /// </summary>
            [JsonProperty("approval_id")]
            public string? ApprovalId { get; set; }

            /// <summary>
            /// <para>审批定义图标信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://lf3-ea.bytetos.com/obj/goofy/ee/approval/approval-admin/image/iconLib/v3/person.png</para>
            /// </summary>
            [JsonProperty("icon")]
            public string? Icon { get; set; }
        }

        /// <summary>
        /// <para>审批定义分组</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("group")]
        public InstanceSearchGroup? Group { get; set; }

        /// <summary>
        /// <para>审批定义分组</para>
        /// </summary>
        public record InstanceSearchGroup
        {
            /// <summary>
            /// <para>审批定义分组外部 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：0004</para>
            /// </summary>
            [JsonProperty("external_id")]
            public string? ExternalId { get; set; }

            /// <summary>
            /// <para>审批定义分组名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：groupA</para>
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

        /// <summary>
        /// <para>审批实例信息</para>
        /// </summary>
        public record InstanceSearchNode
        {
            /// <summary>
            /// <para>审批实例 code</para>
            /// <para>必填：否</para>
            /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
            /// </summary>
            [JsonProperty("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>审批实例外部 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：0004_3ED52DC1-AA6C</para>
            /// </summary>
            [JsonProperty("external_id")]
            public string? ExternalId { get; set; }

            /// <summary>
            /// <para>审批实例发起人 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：lwiu098wj</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批实例开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1547654251506</para>
            /// </summary>
            [JsonProperty("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>审批实例结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1547654251506</para>
            /// </summary>
            [JsonProperty("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>审批实例状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：PENDING</para>
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
            /// <para>示例值：test</para>
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>审批实例扩展字段，string型json</para>
            /// <para>必填：否</para>
            /// <para>示例值：{}</para>
            /// </summary>
            [JsonProperty("extra")]
            public string? Extra { get; set; }

            /// <summary>
            /// <para>审批流水号</para>
            /// <para>必填：否</para>
            /// <para>示例值：201902020001</para>
            /// </summary>
            [JsonProperty("serial_id")]
            public string? SerialId { get; set; }

            /// <summary>
            /// <para>审批实例链接（只有第三方审批有）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("link")]
            public InstanceSearchLink? Link { get; set; }

            /// <summary>
            /// <para>审批实例链接（只有第三方审批有）</para>
            /// </summary>
            public record InstanceSearchLink
            {
                /// <summary>
                /// <para>审批实例 pc 端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.baidu.com/</para>
                /// </summary>
                [JsonProperty("pc_link")]
                public string? PcLink { get; set; }

                /// <summary>
                /// <para>审批实例移动端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.baidu.com/</para>
                /// </summary>
                [JsonProperty("mobile_link")]
                public string? MobileLink { get; set; }
            }
        }

        /// <summary>
        /// <para>审批任务</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("task")]
        public TaskSearchNode? Task { get; set; }

        /// <summary>
        /// <para>审批任务</para>
        /// </summary>
        public record TaskSearchNode
        {
            /// <summary>
            /// <para>审批任务审批人 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：lwiu098wj</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批任务开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1547654251506</para>
            /// </summary>
            [JsonProperty("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>审批任务结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1547654251506</para>
            /// </summary>
            [JsonProperty("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>审批任务状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：PENDING</para>
            /// <para>可选值：<list type="bullet">
            /// <item>rejected：拒绝</item>
            /// <item>pending：审批中</item>
            /// <item>approved：通过</item>
            /// <item>transferred：转交</item>
            /// <item>done：已完成</item>
            /// <item>rm_repeat：去重</item>
            /// <item>processed：已处理</item>
            /// <item>hidden：隐藏</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("status")]
            public string? Status { get; set; }

            /// <summary>
            /// <para>审批任务名称（只有第三方审批有）</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>审批任务扩展字段，string型json</para>
            /// <para>必填：否</para>
            /// <para>示例值：{}</para>
            /// </summary>
            [JsonProperty("extra")]
            public string? Extra { get; set; }

            /// <summary>
            /// <para>审批任务链接（只有第三方审批有）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("link")]
            public InstanceSearchLink? Link { get; set; }

            /// <summary>
            /// <para>审批任务链接（只有第三方审批有）</para>
            /// </summary>
            public record InstanceSearchLink
            {
                /// <summary>
                /// <para>审批实例 pc 端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.baidu.com/</para>
                /// </summary>
                [JsonProperty("pc_link")]
                public string? PcLink { get; set; }

                /// <summary>
                /// <para>审批实例移动端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.baidu.com/</para>
                /// </summary>
                [JsonProperty("mobile_link")]
                public string? MobileLink { get; set; }
            }

            /// <summary>
            /// <para>任务id</para>
            /// <para>必填：否</para>
            /// <para>示例值：7110153401253494803</para>
            /// </summary>
            [JsonProperty("task_id")]
            public string? TaskId { get; set; }

            /// <summary>
            /// <para>审批任务更新时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1547654251506</para>
            /// </summary>
            [JsonProperty("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>三方审批扩展 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：123123daddf21313</para>
            /// </summary>
            [JsonProperty("task_external_id")]
            public string? TaskExternalId { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：nF1ZXJ5VGhlbkZldGNoCgAAAAAA6PZwFmUzSldvTC1yU</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
