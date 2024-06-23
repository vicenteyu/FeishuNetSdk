// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApprovalV4ApprovalsByApprovalCodeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查看指定审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查看指定审批定义 响应体
/// <para>根据 Approval Code 获取某个审批定义的详情，用于构造创建审批实例的请求。</para>
/// <para>接口ID：7114621541589860355</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fget</para>
/// </summary>
public record GetApprovalV4ApprovalsByApprovalCodeResponseDto
{
    /// <summary>
    /// <para>审批名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：Payment</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：ACTIVE</para>
    /// <para>可选值：<list type="bullet">
    /// <item>ACTIVE：已启用</item>
    /// <item>INACTIVE：已停用</item>
    /// <item>DELETED：已删除</item>
    /// <item>UNKNOWN：未知</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>控件信息，见下方form字段说明</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"id\": \"widget1\", \"custom_id\": \"user_name\",\"name\": \"Item application\",\"type\": \"textarea\",\"printable\": true,\"required\": true}]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string Form { get; set; } = string.Empty;

    /// <summary>
    /// <para>节点信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("node_list")]
    public ApprovalNodeInfo[] NodeLists { get; set; } = Array.Empty<ApprovalNodeInfo>();

    /// <summary>
    /// <para>节点信息</para>
    /// </summary>
    public record ApprovalNodeInfo
    {
        /// <summary>
        /// <para>节点名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：Approval</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否发起人自选节点 true - 发起审批时需要提交审批人</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("need_approver")]
        public bool NeedApprover { get; set; }

        /// <summary>
        /// <para>节点 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b64</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点自定义 ID，如果没有设置则不返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：46e6d96cfa756980907209209ec03b64</para>
        /// </summary>
        [JsonPropertyName("custom_node_id")]
        public string? CustomNodeId { get; set; }

        /// <summary>
        /// <para>审批方式</para>
        /// <para>必填：是</para>
        /// <para>示例值：AND</para>
        /// <para>可选值：<list type="bullet">
        /// <item>AND：会签</item>
        /// <item>OR：或签</item>
        /// <item>SEQUENTIAL：依次审批</item>
        /// <item>CC_NODE：抄送节点</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("node_type")]
        public string NodeType { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否支持多选：true-支持，发起、结束节点该值无意义</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("approver_chosen_multi")]
        public bool ApproverChosenMulti { get; set; }

        /// <summary>
        /// <para>自选范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("approver_chosen_range")]
        public ApproverChosenRange[]? ApproverChosenRanges { get; set; }

        /// <summary>
        /// <para>自选范围</para>
        /// </summary>
        public record ApproverChosenRange
        {
            /// <summary>
            /// <para>指定范围：0-all，1-指定角色，2-指定人员</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：全公司范围</item>
            /// <item>1：指定角色范围</item>
            /// <item>2：指定用户范围</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("approver_range_type")]
            public int? ApproverRangeType { get; set; }

            /// <summary>
            /// <para>根据上面的type，分别存放角色id与人员open_id，type为0时本字段为空列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("approver_range_ids")]
            public string[]? ApproverRangeIds { get; set; }
        }

        /// <summary>
        /// <para>是否签名</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("require_signature")]
        public bool? RequireSignature { get; set; }
    }

    /// <summary>
    /// <para>可见人列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("viewers")]
    public ApprovalViewerInfo[] Viewers { get; set; } = Array.Empty<ApprovalViewerInfo>();

    /// <summary>
    /// <para>可见人列表</para>
    /// </summary>
    public record ApprovalViewerInfo
    {
        /// <summary>
        /// <para>可见人类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：TENANT</para>
        /// <para>可选值：<list type="bullet">
        /// <item>TENANT：租户内可见</item>
        /// <item>DEPARTMENT：指定部门</item>
        /// <item>USER：指定用户</item>
        /// <item>ROLE：指定角色</item>
        /// <item>USER_GROUP：指定用户组</item>
        /// <item>NONE：任何人都不可见</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>在可见人类型为DEPARTMENT时，id为部门的id ；在可见人类型为USER时，id为用户的id ；在可见人类型为ROLE时，id为角色的id ；在可见人类型为USER_GROUP时，id为用户组的id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_e03053f0541cecc3269d7a9dc34a0b21</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>在可见人类型为USER时，表示可见人用户id</para>
        /// <para>必填：否</para>
        /// <para>示例值：f7cb567e</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }

    /// <summary>
    /// <para>有数据管理权限的审批流程管理员ID，由参数“with_admin_id”控制是否返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_admin_ids")]
    public string[]? ApprovalAdminIds { get; set; }
}
