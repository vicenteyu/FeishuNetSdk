// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="GetApprovalV4InstancesDetailResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取单个审批实例详情（用户级） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 获取单个审批实例详情（用户级） 响应体
/// <para>通过审批实例 Code 获取指定审批实例的详细信息，包括审批实例的名称、创建时间、发起审批的用户、状态以及任务列表等信息。</para>
/// <para>接口ID：7642253323628432350</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fdetail</para>
/// </summary>
public record GetApprovalV4InstancesDetailResponseDto
{
    /// <summary>
    /// <para>审批名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：Payment</para>
    /// </summary>
    [JsonPropertyName("definition_name")]
    public string DefinitionName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1564590532967</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>审批完成时间，未完成为 0</para>
    /// <para>必填：是</para>
    /// <para>示例值：1564590532967</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户</para>
    /// <para>必填：是</para>
    /// <para>示例值：f3ta757q</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批单编号</para>
    /// <para>必填：是</para>
    /// <para>示例值：202102060002</para>
    /// </summary>
    [JsonPropertyName("serial_number")]
    public string SerialNumber { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起审批用户所在部门</para>
    /// <para>必填：是</para>
    /// <para>示例值：123456</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：PENDING</para>
    /// <para>可选值：<list type="bullet">
    /// <item>PENDING：审批中</item>
    /// <item>APPROVED：通过</item>
    /// <item>REJECTED：拒绝</item>
    /// <item>CANCELED：撤回</item>
    /// <item>DELETED：删除</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>json字符串，控件值</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"id\": \"widget1\",\"custom_id\": \"user_info\",\"name\": \"Item application\",\"type\": \"textarea\"},\"value\":\"aaaa\"]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string Form { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批任务列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("tasks")]
    public UatInstanceTask[] Tasks { get; set; } = [];

    /// <summary>
    /// <para>审批任务列表</para>
    /// </summary>
    public record UatInstanceTask
    {
        /// <summary>
        /// <para>审批任务id</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批人的用户id，自动通过、自动拒绝 时为空</para>
        /// <para>必填：是</para>
        /// <para>示例值：12345</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>instance 状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：PENDING</para>
        /// <para>可选值：<list type="bullet">
        /// <item>PENDING：审批中</item>
        /// <item>APPROVED：同意</item>
        /// <item>REJECTED：拒绝</item>
        /// <item>TRANSFERRED：已转交</item>
        /// <item>DONE：完成</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>task 所属节点 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b64</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>task 所属节点名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：开始</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public string? NodeName { get; set; }

        /// <summary>
        /// <para>审批方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：AND</para>
        /// <para>可选值：<list type="bullet">
        /// <item>AND：会签</item>
        /// <item>OR：或签</item>
        /// <item>AUTO_PASS：自动通过</item>
        /// <item>AUTO_REJECT：自动拒绝</item>
        /// <item>SEQUENTIAL：按顺序</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>task 开始时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1564590532967</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>task 完成时间, 未完成为 0</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }

    /// <summary>
    /// <para>评论列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("comments")]
    public UatInstanceComment[] Comments { get; set; } = [];

    /// <summary>
    /// <para>评论列表</para>
    /// </summary>
    public record UatInstanceComment
    {
        /// <summary>
        /// <para>评论 id</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>发表评论用户</para>
        /// <para>必填：是</para>
        /// <para>示例值：f7cb567e</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：ok</para>
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论时间 （该接口中相关时间都为毫秒时间戳）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1564590532967</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论附件</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("files")]
        public File[]? Files { get; set; }

        /// <summary>
        /// <para>评论附件</para>
        /// </summary>
        public record File
        {
            /// <summary>
            /// <para>资源路径</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://xxxxx.xxx</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>资源大小（字节数）</para>
            /// <para>必填：否</para>
            /// <para>示例值：55555</para>
            /// </summary>
            [JsonPropertyName("file_size")]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>资源标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：文件名称</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>资源类别</para>
            /// <para>必填：否</para>
            /// <para>示例值：attachment</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }
    }

    /// <summary>
    /// <para>审批动态</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("operation_records")]
    public UatInstanceTimeline[] OperationRecords { get; set; } = [];

    /// <summary>
    /// <para>审批动态</para>
    /// </summary>
    public record UatInstanceTimeline
    {
        /// <summary>
        /// <para>事件类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：PASS</para>
        /// <para>可选值：<list type="bullet">
        /// <item>START：审批开始</item>
        /// <item>PASS：通过</item>
        /// <item>REJECT：拒绝</item>
        /// <item>AUTO_PASS：自动通过</item>
        /// <item>AUTO_REJECT：自动拒绝</item>
        /// <item>REMOVE_REPEAT：去重</item>
        /// <item>TRANSFER：转交</item>
        /// <item>ADD_APPROVER_BEFORE：前加签</item>
        /// <item>ADD_APPROVER：并加签</item>
        /// <item>ADD_APPROVER_AFTER：后加签</item>
        /// <item>DELETE_APPROVER：减签</item>
        /// <item>ROLLBACK_SELECTED：指定回退</item>
        /// <item>ROLLBACK：全部回退</item>
        /// <item>CANCEL：撤回</item>
        /// <item>DELETE：删除</item>
        /// <item>CC：抄送</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>发生时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：1564590532967</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>动态产生用户</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>被抄送人列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("cc_user_ids")]
        public string[]? CcUserIds { get; set; }

        /// <summary>
        /// <para>产生动态关联的task_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>理由</para>
        /// <para>必填：否</para>
        /// <para>示例值：ok</para>
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// <para>产生task的节点key</para>
        /// <para>必填：否</para>
        /// <para>示例值：APPROVAL_240330_4058663</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>审批附件</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("files")]
        public File[]? Files { get; set; }

        /// <summary>
        /// <para>审批附件</para>
        /// </summary>
        public record File
        {
            /// <summary>
            /// <para>资源路径</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://yyyyy.yyy</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>12331</para>
            /// <para>必填：否</para>
            /// <para>示例值：777777</para>
            /// </summary>
            [JsonPropertyName("file_size")]
            public int? FileSize { get; set; }

            /// <summary>
            /// <para>资源标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：附件名称</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>资源类别</para>
            /// <para>必填：否</para>
            /// <para>示例值：attachment</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }
    }

    /// <summary>
    /// <para>审批定义 Code</para>
    /// <para>必填：是</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("definition_code")]
    public string DefinitionCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>单据是否被撤销</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("reverted")]
    public bool? Reverted { get; set; }

    /// <summary>
    /// <para>审批实例 Code</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>当前审批节点</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("current_nodes")]
    public UatCurrentNode[]? CurrentNodes { get; set; }

    /// <summary>
    /// <para>当前审批节点</para>
    /// </summary>
    public record UatCurrentNode
    {
        /// <summary>
        /// <para>当前审批节点 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b64</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// <para>当前审批节点名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：开始</para>
        /// </summary>
        [JsonPropertyName("node_name")]
        public string? NodeName { get; set; }

        /// <summary>
        /// <para>审批方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：AND</para>
        /// <para>可选值：<list type="bullet">
        /// <item>AND：会签</item>
        /// <item>OR：或签</item>
        /// <item>AUTO_PASS：自动通过</item>
        /// <item>AUTO_REJECT：自动拒绝</item>
        /// <item>SEQUENTIAL：按顺序</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>当前节点审批人</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("approvers")]
        public UatTaskUser[]? Approvers { get; set; }

        /// <summary>
        /// <para>当前节点审批人</para>
        /// </summary>
        public record UatTaskUser
        {
            /// <summary>
            /// <para>任务ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：123456789</para>
            /// </summary>
            [JsonPropertyName("task_id")]
            public string? TaskId { get; set; }

            /// <summary>
            /// <para>任务对应的userID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c186b6833e2d5fxxxxxx</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }
    }
}
