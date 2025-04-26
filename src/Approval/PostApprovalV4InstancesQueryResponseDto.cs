// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询实例列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询实例列表 响应体
/// <para>该接口通过不同条件查询审批系统中符合条件的审批实例列表。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口会过滤被撤销的审批实例，因此会有实例存在却不返回数据的情况。</para>
/// <para>该情况的具体表现：返回结果中每页的数据条目数可能小于 page_size 值。例如，page_size 取值为 10，实际查询结果中当前页只显示 6 条数据，则表示有 4 条数据是被撤销的审批实例。</para>
/// <para>- 该接口查询结果可能存在延迟，无法保证实时性。如需实时查询，建议使用[批量获取审批实例 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)（该接口只能查询某一审批定义下的审批实例 ID）。</para>
/// <para>- 查询时：</para>
/// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
/// <para>- approval_code 和 group_external_id 查询结果取并集；instance_code 和 instance_external_id 查询结果取并集；其他查询条件之间均取交集。</para>
/// <para>接口ID：7117964632137203715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fquery</para>
/// </summary>
public record PostApprovalV4InstancesQueryResponseDto
{
    /// <summary>
    /// <para>查询结果中包含的审批实例总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// <para>审批实例列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_list")]
    public InstanceSearchItem[]? InstanceLists { get; set; }

    /// <summary>
    /// <para>审批实例列表</para>
    /// </summary>
    public record InstanceSearchItem
    {
        /// <summary>
        /// <para>审批定义信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approval")]
        public InstanceSearchApproval? Approval { get; set; }

        /// <summary>
        /// <para>审批定义信息</para>
        /// </summary>
        public record InstanceSearchApproval
        {
            /// <summary>
            /// <para>审批定义 Code</para>
            /// <para>必填：否</para>
            /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>审批定义名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：approval</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>是否为第三方审批</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_external")]
            public bool? IsExternal { get; set; }

            /// <summary>
            /// <para>第三方审批信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("external")]
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
                [JsonPropertyName("batch_cc_read")]
                public bool? BatchCcRead { get; set; }
            }

            /// <summary>
            /// <para>审批定义 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7090754740375519252</para>
            /// </summary>
            [JsonPropertyName("approval_id")]
            public string? ApprovalId { get; set; }

            /// <summary>
            /// <para>审批定义图标信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://lf3-ea.bytetos.com/obj/goofy/ee/approval/approval-admin/image/iconLib/v3/person.png</para>
            /// </summary>
            [JsonPropertyName("icon")]
            public string? Icon { get; set; }
        }

        /// <summary>
        /// <para>审批定义分组</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("group")]
        public InstanceSearchGroup? Group { get; set; }

        /// <summary>
        /// <para>审批定义分组</para>
        /// </summary>
        public record InstanceSearchGroup
        {
            /// <summary>
            /// <para>审批定义分组的第三方 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：0004</para>
            /// </summary>
            [JsonPropertyName("external_id")]
            public string? ExternalId { get; set; }

            /// <summary>
            /// <para>审批定义分组名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：groupA</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>审批实例信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("instance")]
        public InstanceSearchNode? Instance { get; set; }

        /// <summary>
        /// <para>审批实例信息</para>
        /// </summary>
        public record InstanceSearchNode
        {
            /// <summary>
            /// <para>审批实例 Code</para>
            /// <para>必填：否</para>
            /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>审批实例的第三方 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：0004_3ED52DC1-AA6C</para>
            /// </summary>
            [JsonPropertyName("external_id")]
            public string? ExternalId { get; set; }

            /// <summary>
            /// <para>审批实例发起人的 user_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：lwiu098wj</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>审批实例开始时间，Unix 毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1547654251506</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>审批实例结束时间，Unix 毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1547654251506</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>审批实例状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：pending</para>
            /// <para>可选值：<list type="bullet">
            /// <item>rejected：已拒绝</item>
            /// <item>pending：审批中</item>
            /// <item>canceled：已撤回</item>
            /// <item>deleted：已删除</item>
            /// <item>approved：已通过</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("status")]
            public string? Status { get; set; }

            /// <summary>
            /// <para>审批实例名称（只有第三方审批有返回值）</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>审批实例扩展字段，字符串类型的 JSON 数据</para>
            /// <para>必填：否</para>
            /// <para>示例值：{}</para>
            /// </summary>
            [JsonPropertyName("extra")]
            public string? Extra { get; set; }

            /// <summary>
            /// <para>审批流水号</para>
            /// <para>必填：否</para>
            /// <para>示例值：201902020001</para>
            /// </summary>
            [JsonPropertyName("serial_id")]
            public string? SerialId { get; set; }

            /// <summary>
            /// <para>审批实例链接（只有第三方审批有返回值）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("link")]
            public InstanceSearchLink? Link { get; set; }

            /// <summary>
            /// <para>审批实例链接（只有第三方审批有返回值）</para>
            /// </summary>
            public record InstanceSearchLink
            {
                /// <summary>
                /// <para>审批实例 PC 端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com/</para>
                /// </summary>
                [JsonPropertyName("pc_link")]
                public string? PcLink { get; set; }

                /// <summary>
                /// <para>审批实例移动端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com/</para>
                /// </summary>
                [JsonPropertyName("mobile_link")]
                public string? MobileLink { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：nF1ZXJ5VGhlbkZldGNoCgAAAAAA6PZwFmUzSldvTC1yU</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
