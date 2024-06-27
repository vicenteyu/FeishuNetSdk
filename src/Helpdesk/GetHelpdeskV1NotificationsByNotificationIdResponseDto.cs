// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHelpdeskV1NotificationsByNotificationIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询推送 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 查询推送 响应体
/// <para>查询推送详情。</para>
/// <para>接口ID：6999529163292606466</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fget</para>
/// </summary>
public record GetHelpdeskV1NotificationsByNotificationIdResponseDto
{
    /// <summary>
    /// <para>push任务详情</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"approval_app_link":"","notification":{"chat_list":null,"create_user":{"avatar_url":"","name":"","user_id":"ou_7277fd1262bfafc363d5b2a1f9c2ac90"},"created_at":"1626329642000","department_list":null,"ext":"","helpdesk_id":"6969495102523703316","id":"6985032626234982420","instance_code":"","job_name":"api push create test","new_staff_scope_department_list":null,"new_staff_scope_type":null,"push_content":"{\n \"config\": {\n \"wide_screen_mode\": true\n },\n \"elements\": [\n {\n \"tag\": \"div\",\n \"text\": {\n \"tag\": \"lark_md\",\n \"content\": \"[飞书](https://www.feishu.cn)整合即时沟通、日历、音视频会议、云文档、云盘、工作台等功能于一体，成就组织和个人，更高效、更愉悦。\"\n }\n }\n ]\n}",":0,"send_at":"","sent_user_count":0,"status":0,"target_user_count":7814,"tenant_id":"1","update_user":{"avatar_url":"","name":"","user_id":"ou_7277fd1262bfafc363d5b2a1f9c2ac90"},"updated_at":"","user_list":null}}</para>
    /// </summary>
    [JsonPropertyName("notification")]
    public GetHelpdeskV1NotificationsByNotificationIdResponseDtoNotification? Notification { get; set; }

    /// <summary>
    /// <para>push任务详情</para>
    /// </summary>
    public record GetHelpdeskV1NotificationsByNotificationIdResponseDtoNotification
    {
        /// <summary>
        /// <para>非必填，创建成功后返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：6981801914270744596</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>必填，任务名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试推送任务</para>
        /// </summary>
        [JsonPropertyName("job_name")]
        public string? JobName { get; set; }

        /// <summary>
        /// <para>非必填，创建成功后返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>非必填，创建人</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"avatar_url":"","name":"","user_id":"ou_7277fd1262bfafc363d5b2a1f9c2ac90"}</para>
        /// </summary>
        [JsonPropertyName("create_user")]
        public NotificationUser? CreateUser { get; set; }

        /// <summary>
        /// <para>非必填，创建人</para>
        /// </summary>
        public record NotificationUser
        {
            /// <summary>
            /// <para>非必填，用户id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_7277fd1262bfafc363d5b2a1f9c2ac90</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>非必填，头像地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://*.com/*.png</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>非必填，用户名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>非必填，创建时间（毫秒时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1626332244719</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>非必填，更新用户</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"avatar_url":"","name":"","user_id":"ou_7277fd1262bfafc363d5b2a1f9c2ac90"}</para>
        /// </summary>
        [JsonPropertyName("update_user")]
        public NotificationUser? UpdateUser { get; set; }

        /// <summary>
        /// <para>非必填，更新时间（毫秒时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1626332244719</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// <para>非必填，目标推送用户总数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("target_user_count")]
        public int? TargetUserCount { get; set; }

        /// <summary>
        /// <para>非必填，已推送用户总数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("sent_user_count")]
        public int? SentUserCount { get; set; }

        /// <summary>
        /// <para>非必填，已读用户总数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("read_user_count")]
        public int? ReadUserCount { get; set; }

        /// <summary>
        /// <para>非必填，推送任务触发时间（毫秒时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1626332244719</para>
        /// </summary>
        [JsonPropertyName("send_at")]
        public string? SendAt { get; set; }

        /// <summary>
        /// <para>必填，推送内容，详见：https://open.feishu.cn/tool/cardbuilder?from=howtoguide</para>
        /// <para>必填：否</para>
        /// <para>示例值：{ \"config\": { \"wide_screen_mode\": true }, \"elements\": [ { \"tag\": \"div\", \"text\": { \"tag\": \"lark_md\", \"content\": \"[飞书](https://www.feishu.cn)整合即时沟通、日历、音视频会议、云文档、云盘、工作台等功能于一体，成就组织和个人，更高效、更愉悦。\" } } ] }</para>
        /// </summary>
        [JsonPropertyName("push_content")]
        public string? PushContent { get; set; }

        /// <summary>
        /// <para>必填</para>
        /// <para>0（定时推送：push_scope不能等于3） 1（新人入职推送：push_scope必须等于1或者3；new_staff_scope_type不能为空）</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("push_type")]
        public int? PushType { get; set; }

        /// <summary>
        /// <para>必填</para>
        /// <para>推送范围（服务台私信） 0：组织内全部成员（user_list和department_list必须为空） 1：不推送任何成员（user_list和department_list必须为空，chat_list不可为空） 2：推送到部分成员（user_list或department_list不能为空） 3：入职新人 以上四种状态，chat_list都相对独立，只有在推送范围为1时，必须需要设置chat_list</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("push_scope_type")]
        public int? PushScopeType { get; set; }

        /// <summary>
        /// <para>非必填</para>
        /// <para>新人入职范围类型（push_type为1时生效） 0：组织内所有新人 1：组织内特定的部门（new_staff_scope_department_list 字段不能为空）</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("new_staff_scope_type")]
        public int? NewStaffScopeType { get; set; }

        /// <summary>
        /// <para>非必填，新人入职生效部门列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{"department_id":"od_7c1a2815c9846b5e518b950de0e62de8"}]</para>
        /// </summary>
        [JsonPropertyName("new_staff_scope_department_list")]
        public NotificationDepartment[]? NewStaffScopeDepartmentLists { get; set; }

        /// <summary>
        /// <para>非必填，新人入职生效部门列表</para>
        /// </summary>
        public record NotificationDepartment
        {
            /// <summary>
            /// <para>部门ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：od_7277fd1262bfafc363d5b2a1f9c2ac90</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>非必填，部门名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试部门</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>非必填，push推送到成员列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{"user_id":"ou_7277fd1262bfafc363d5b2a1f9c2ac90"}]</para>
        /// </summary>
        [JsonPropertyName("user_list")]
        public NotificationUser[]? UserLists { get; set; }

        /// <summary>
        /// <para>非必填，push推送到的部门信息列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{"department_id":"od_7c1a2815c9846b5e518b950de0e62de8"}]</para>
        /// </summary>
        [JsonPropertyName("department_list")]
        public NotificationDepartment[]? DepartmentLists { get; set; }

        /// <summary>
        /// <para>非必填，push推送到的会话列表(群)</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{"chat_id":"oc_7c1a2815c9846b5e518b950de0e62de8"}]</para>
        /// </summary>
        [JsonPropertyName("chat_list")]
        public NotificationChat[]? ChatLists { get; set; }

        /// <summary>
        /// <para>非必填，push推送到的会话列表(群)</para>
        /// </summary>
        public record NotificationChat
        {
            /// <summary>
            /// <para>非必填，会话ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：oc_7277fd1262bfafc363d5b2a1f9c2ac90</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string? ChatId { get; set; }

            /// <summary>
            /// <para>非必填，会话名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试群聊</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>非必填，预留扩展字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：{}</para>
        /// </summary>
        [JsonPropertyName("ext")]
        public string? Ext { get; set; }
    }

    /// <summary>
    /// <para>审批链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：http://applink.feishu.cn/*xx</para>
    /// </summary>
    [JsonPropertyName("approval_app_link")]
    public string? ApprovalAppLink { get; set; }
}
