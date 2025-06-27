// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalOpenapiV2ApprovalGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查看审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查看审批定义 响应体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/get)根据 Approval Code 获取某个审批定义的详情，用于构造创建审批实例的请求。</para>
/// <para>接口ID：6907569744330358785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/obtain-single-approval-form</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADNyUjLwQjM14CM0ITN</para>
/// </summary>
public record PostApprovalOpenapiV2ApprovalGetResponseDto
{
    /// <summary>
    /// <para>审批名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("approval_name")]
    public string ApprovalName { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义状态</para>
    /// <para>ACTIVE -已启用</para>
    /// <para>INACTIVE -已停用</para>
    /// <para>DELETED -已删除</para>
    /// <para>UNKNOWN -未知</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>json 数组，**控件信息**</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string Form { get; set; } = string.Empty;

    /// <summary></summary>
    public record FormSuffix
    {
        /// <summary>
        /// <para>控件 ID</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件自定义 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// <para>控件名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件类型</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>此控件是否启用了默认值</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("enable_default_value")]
        public bool EnableDefaultValue { get; set; }

        /// <summary>
        /// <para>控件的默认值</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("widget_default_value")]
        public string WidgetDefaultValue { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件的默认值类型</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("default_value_type")]
        public string DefaultValueType { get; set; } = string.Empty;

        /// <summary>
        /// <para>控件显隐条件</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("display_condition")]
        public DisplayConditionSuffix? DisplayCondition { get; set; }

        /// <summary></summary>
        public record DisplayConditionSuffix
        {
            /// <summary>
            /// <para>否</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("conditional")]
            public string? Conditional { get; set; }

            /// <summary>
            /// <para>否</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("conditions")]
            public Condition[]? Conditions { get; set; }

            /// <summary></summary>
            public record Condition
            {
                /// <summary>
                /// <para>多个条件同时满足</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("conditional")]
                public string? Conditional { get; set; }

                /// <summary>
                /// <para>否</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("expressions")]
                public Expression[]? Expressions { get; set; }

                /// <summary></summary>
                public record Expression
                {
                    /// <summary>
                    /// <para>否</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("source_widget")]
                    public string? SourceWidget { get; set; }

                    /// <summary>
                    /// <para>判断规则</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("compare_type")]
                    public string? CompareType { get; set; }

                    /// <summary>
                    /// <para>条件值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("standard_value")]
                    public string? StandardValue { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>节点信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("node_list")]
    public Node[] NodeList { get; set; } = Array.Empty<Node>();

    /// <summary></summary>
    public record Node
    {
        /// <summary>
        /// <para>节点名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否发起人自选节点</para>
        /// <para>true - 发起审批时需要提交审批人</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("need_approver")]
        public bool NeedApprover { get; set; }

        /// <summary>
        /// <para>节点 ID</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>节点自定义 ID，如果没有设置则不返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_node_id")]
        public string? CustomNodeId { get; set; }

        /// <summary>
        /// <para>审批方式</para>
        /// <para>AND -会签</para>
        /// <para>OR - 或签</para>
        /// <para>SEQUENTIAL -依次审批</para>
        /// <para>CC_NODE -抄送节点</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("node_type")]
        public string NodeType { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>可见人列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("viewers")]
    public Viewer[] Viewers { get; set; } = Array.Empty<Viewer>();

    /// <summary></summary>
    public record Viewer
    {
        /// <summary>
        /// <para>可见人类型，分别有：</para>
        /// <para>TENANT：租户内可见</para>
        /// <para>DEPARTMENT：指定部门</para>
        /// <para>USER：指定用户</para>
        /// <para>ROLE：指定角色</para>
        /// <para>USER_GROUP：指定用户组</para>
        /// <para>NONE：任何人都不可见</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>在可见人类型为DEPARTMENT时，open_id为部门的open_id</para>
        /// <para>在可见人类型为USER时，open_id为用户的open_id</para>
        /// <para>在可见人类型为ROLE时，open_id为角色的open_id</para>
        /// <para>在可见人类型为USER_GROUP时，open_id为用户组的open_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>在可见人类型为USER时，表示可见人用户id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}
