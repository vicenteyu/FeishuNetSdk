// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ContactDepartmentCreatedV3EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>部门新建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Events;
/// <summary>
/// 部门新建 事件体
/// <para>当应用订阅该事件后，如果通讯录内有部门被创建，则会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=contact&amp;version=v3&amp;resource=department&amp;event=created)</para>
/// <para>接口ID：6954228303264022555</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fevents%2fcreated</para>
/// </summary>
public record ContactDepartmentCreatedV3EventBodyDto() : EventBodyDto("contact.department.created_v3")
{
    /// <summary>
    /// <para>部门信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object")]
    public DepartmentEvent? Object { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record DepartmentEvent
    {
        /// <summary>
        /// <para>部门名称。</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最小长度：`1` 字符</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:department.base:readonly : 获取部门基础信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>父部门的部门 open_department_id。了解部门 ID 可参见[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>当前部门的 department_id。了解部门 ID 可参见[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:department.base:readonly : 获取部门基础信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>当前部门的 open_department_id。了解部门 ID 可参见[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>部门主管的用户 open_id 。了解用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:department.base:readonly : 获取部门基础信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>部门群 ID。你可以调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，通过群 ID 获取群详细信息。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>当前部门在同级部门的排序。取值越小排序越靠前。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// <para>部门状态。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:department.base:readonly : 获取部门基础信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public DepartmentStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record DepartmentStatus
        {
            /// <summary>
            /// <para>是否被删除。</para>
            /// <para>**可能值：**</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_deleted")]
            public bool? IsDeleted { get; set; }
        }

        /// <summary>
        /// <para>部门负责人信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leaders")]
        public DepartmentLeader[]? Leaders { get; set; }

        /// <summary></summary>
        public record DepartmentLeader
        {
            /// <summary>
            /// <para>负责人类型。</para>
            /// <para>**可选值有**：</para>
            /// <para>1:主负责人。,2:副负责人。</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：主负责人。</item>
            /// <item>2：副负责人。</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("leaderType")]
            public int? LeaderType { get; set; }

            /// <summary>
            /// <para>负责人的用户 open_id。了解用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("leaderID")]
            public string? LeaderID { get; set; }
        }

        /// <summary>
        /// <para>部门 HRBP 的用户 ID 列表。了解用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- contact:department.hrbp:readonly : 查询部门 HRBP 信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_hrbps")]
        public UserIdSuffix[]? DepartmentHrbps { get; set; }
    }
}
