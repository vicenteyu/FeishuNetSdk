// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ContactScopeUpdatedV3EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通讯录权限范围变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Events;
/// <summary>
/// 通讯录权限范围变更 事件体
/// <para>当应用订阅该事件后，如果应用的通讯录权限范围发生变更，则会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=contact&amp;version=v3&amp;resource=scope&amp;event=updated)</para>
/// <para>接口ID：6954228303264038939</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/scope/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fscope%2fevents%2fupdated</para>
/// </summary>
public record ContactScopeUpdatedV3EventBodyDto() : EventBodyDto("contact.scope.updated_v3")
{
    /// <summary>
    /// <para>当通讯录权限范围变更时，新增的对象信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("added")]
    public Scope? Added { get; set; }

    /// <summary>
    /// <para>当通讯录权限范围发生变更时，移除的对象信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("removed")]
    public Scope? Removed { get; set; }

    /// <summary>
    /// 对象信息
    /// </summary>
    public record Scope
    {
        /// <summary>
        /// <para>部门对象信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("departments")]
        public Department[]? Departments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record Department
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
            /// <para>国际化的部门名称。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.base:readonly : 获取部门基础信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_name")]
            public I18nLanguage<string>? I18nName { get; set; }

            /// <summary>
            /// <para>父部门的 ID。取值为 0 表示当前部门的父部门为根部门。</para>
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
            /// <para>当前部门的自定义部门 ID。</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最大长度：`64` 字符</para>
            /// <para>- 正则校验：`^[a-zA-Z0-9][a-zA-Z0-9_\-@.]{0,63}$`</para>
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
            /// <para>部门的 open_department_id。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("open_department_id")]
            public string? OpenDepartmentId { get; set; }

            /// <summary>
            /// <para>部门主管的 open_id。关于用户 ID 的说明可参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("leader_user_id")]
            public string? LeaderUserId { get; set; }

            /// <summary>
            /// <para>部门群 ID。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.base:readonly : 获取部门基础信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("chat_id")]
            public string? ChatId { get; set; }

            /// <summary>
            /// <para>部门的排序，即部门在其同级部门的展示顺序。取值越小排序越靠前。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("order")]
            public string? Order { get; set; }

            /// <summary>
            /// <para>部门单位的自定义 ID 列表。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("unit_ids")]
            public string[]? UnitIds { get; set; }

            /// <summary>
            /// <para>部门下用户的个数。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("member_count")]
            public int? MemberCount { get; set; }

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

            /// <summary>
            /// 
            /// </summary>
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
            /// <para>部门群雇员类型限制。当该字段列表为空时，表示为无任何雇员类型。类型字段可包含以下值：</para>
            /// <para>- 1：正式员工</para>
            /// <para>- 2：实习生</para>
            /// <para>- 3：外包</para>
            /// <para>- 4：劳务</para>
            /// <para>- 5：顾问</para>
            /// <para>- 6：其他自定义类型字段。你可以调用[获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)接口，获取到该租户的自定义员工类型的名称。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("group_chat_employee_types")]
            public int[]? GroupChatEmployeeTypes { get; set; }

            /// <summary>
            /// <para>部门下主属用户的个数。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:department.organize:readonly : 获取通讯录部门组织架构信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("primary_member_count")]
            public int? PrimaryMemberCount { get; set; }
        }

        /// <summary>
        /// <para>用户对象信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("users")]
        public User[]? Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record User
        {
            /// <summary>
            /// <para>用户的 union_id，应用开发商发布的不同应用中同一用户的标识。关于用户 ID 的说明可参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("union_id")]
            public string? UnionId { get; set; }

            /// <summary>
            /// <para>用户的 user_id，租户内用户的唯一标识。关于用户 ID 的说明可参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.employee_id:readonly : 获取用户 user ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>用户的 open_id，应用内用户的唯一标识。关于用户 ID 的说明可参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// <para>用户名。</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最小长度：`1` 字符</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.base:readonly : 获取用户基本信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>英文名。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.base:readonly : 获取用户基本信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }

            /// <summary>
            /// <para>别名。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.base:readonly : 获取用户基本信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("nickname")]
            public string? Nickname { get; set; }

            /// <summary>
            /// <para>邮箱。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.email:readonly : 获取用户邮箱信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>手机号。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.phone:readonly : 获取用户手机号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>性别。</para>
            /// <para>**可选值有**：</para>
            /// <para>0:保密。,1:男。,2:女。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.gender:readonly : 获取用户性别</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：保密。</item>
            /// <item>1：男。</item>
            /// <item>2：女。</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("gender")]
            public int? Gender { get; set; }

            /// <summary>
            /// <para>用户头像信息。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.base:readonly : 获取用户基本信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public AvatarInfo? Avatar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record AvatarInfo
            {
                /// <summary>
                /// <para>72*72 像素头像链接。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_72")]
                public string? Avatar72 { get; set; }

                /// <summary>
                /// <para>240*240 像素头像链接。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_240")]
                public string? Avatar240 { get; set; }

                /// <summary>
                /// <para>640*640 像素头像链接。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_640")]
                public string? Avatar640 { get; set; }

                /// <summary>
                /// <para>原始头像链接。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("avatar_origin")]
                public string? AvatarOrigin { get; set; }
            }

            /// <summary>
            /// <para>用户状态。通过 is_frozen、is_resigned、is_activated、is_exited 布尔值类型参数进行展示。</para>
            /// <para>用户状态的转关逻辑可参见[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview#4302b5a1)。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("status")]
            public UserStatus? Status { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record UserStatus
            {
                /// <summary>
                /// <para>是否为暂停状态。</para>
                /// <para>**可能值有**：</para>
                /// <para>- true：是</para>
                /// <para>- false：否</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("is_frozen")]
                public bool? IsFrozen { get; set; }

                /// <summary>
                /// <para>是否为离职状态。</para>
                /// <para>**可能值有**：</para>
                /// <para>- true：是</para>
                /// <para>- false：否</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("is_resigned")]
                public bool? IsResigned { get; set; }

                /// <summary>
                /// <para>是否为激活状态。</para>
                /// <para>**可能值有**：</para>
                /// <para>- true：是</para>
                /// <para>- false：否</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("is_activated")]
                public bool? IsActivated { get; set; }

                /// <summary>
                /// <para>是否为主动退出状态。主动退出一段时间后用户状态会自动转为已离职。</para>
                /// <para>**可能值有**：</para>
                /// <para>- true：是</para>
                /// <para>- false：否</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("is_exited")]
                public bool? IsExited { get; set; }

                /// <summary>
                /// <para>是否为未加入状态，需要用户自主确认才能加入企业或团队。</para>
                /// <para>**可能值有**：</para>
                /// <para>- true：是</para>
                /// <para>- false：否</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("is_unjoin")]
                public bool? IsUnjoin { get; set; }
            }

            /// <summary>
            /// <para>用户的直接主管的 open_id。</para>
            /// <para>关于用户 ID 的说明可参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.department:readonly : 获取用户组织架构信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("leader_user_id")]
            public string? LeaderUserId { get; set; }

            /// <summary>
            /// <para>工作城市。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("city")]
            public string? City { get; set; }

            /// <summary>
            /// <para>国家或地区 Code 缩写。具体格式可参见 [国家/地区码表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/country-code-description)。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("country")]
            public string? Country { get; set; }

            /// <summary>
            /// <para>工位。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_station")]
            public string? WorkStation { get; set; }

            /// <summary>
            /// <para>入职时间。秒级时间戳格式，表示从 1970 年 1 月 1 日开始所经过的秒数。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("join_time")]
            public int? JoinTime { get; set; }

            /// <summary>
            /// <para>工号。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:user.employee_number:read : 查看成员工号</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employee_no")]
            public string? EmployeeNo { get; set; }

            /// <summary>
            /// <para>员工类型。</para>
            /// <para>**可能值有：**</para>
            /// <para>- `1`：正式员工</para>
            /// <para>- `2`：实习生</para>
            /// <para>- `3`：外包</para>
            /// <para>- `4`：劳务</para>
            /// <para>- `5`：顾问</para>
            /// <para>同时可读取到自定义员工类型的 int 值，通过 int 值调用[获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)接口，进而获取到该租户的自定义员工类型的名称。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employee_type")]
            public int? EmployeeType { get; set; }

            /// <summary>
            /// <para>自定义字段。如果企业管理员已在管理后台 &gt; 组织架构 &gt; 成员字段管理 &gt; 自定义字段管理 &gt; 全局设置中开启了 **允许开放平台 API 调用**，则该字段生效。</para>
            /// <para>更多信息可参见[用户接口相关问题](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN#77061525)。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_attrs")]
            public UserCustomAttr[]? CustomAttrs { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record UserCustomAttr
            {
                /// <summary>
                /// <para>自定义字段类型。</para>
                /// <para>**可能值有：**</para>
                /// <para>- `TEXT`：文本</para>
                /// <para>- `HREF`：网页</para>
                /// <para>- `ENUMERATION`：枚举</para>
                /// <para>- `PICTURE_ENUM`：图片</para>
                /// <para>- `GENERIC_USER`：用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>自定义字段 ID。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>自定义字段取值。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("value")]
                public UserCustomAttrValue? Value { get; set; }

                /// <summary>
                /// 
                /// </summary>
                public record UserCustomAttrValue
                {
                    /// <summary>
                    /// <para>- 字段类型为 TEXT 时，该参数返回定义的字段值。</para>
                    /// <para>- 字段类型为 HREF 时，该参数返回定义的网页标题。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text")]
                    public string? Text { get; set; }

                    /// <summary>
                    /// <para>字段类型为 HREF 时，该参数返回定义的默认 URL。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string? Url { get; set; }

                    /// <summary>
                    /// <para>字段类型为 HREF 时，如果为 PC 端设置了 URL，则该参数返回定义的 PC 端 URL。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("pc_url")]
                    public string? PcUrl { get; set; }

                    /// <summary>
                    /// <para>字段类型为 `ENUMERATION` 或 `PICTURE_ENUM` 时，该参数返回定义的选项 ID。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("option_id")]
                    public string? OptionId { get; set; }

                    /// <summary>
                    /// <para>选项类型的值，即用户详情或自定义字段中选中的选项值。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("option_value")]
                    public string? OptionValue { get; set; }

                    /// <summary>
                    /// <para>选项类型为图片时，图片的名称。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>选项类型为图片时，图片的链接。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("picture_url")]
                    public string? PictureUrl { get; set; }

                    /// <summary>
                    /// <para>字段类型为 `GENERIC_USER` 时，该参数返回定义的引用人员信息。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("generic_user")]
                    public CustomAttrGenericUser? GenericUser { get; set; }

                    /// <summary>
                    /// 
                    /// </summary>
                    public record CustomAttrGenericUser
                    {
                        /// <summary>
                        /// <para>引用人员的 user_id。关于用户 ID 的具体说明可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("id")]
                        public string? Id { get; set; }

                        /// <summary>
                        /// <para>用户类型。目前固定取值为 1，表示用户。</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("type")]
                        public int? Type { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>企业邮箱。如果企业管理员已在管理后台启用飞书邮箱服务，则会返回该值。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enterprise_email")]
            public string? EnterpriseEmail { get; set; }

            /// <summary>
            /// <para>职务。</para>
            /// <para>**字段权限要求（满足任一）**：</para>
            /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
            /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
            /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
            /// <para>- contact:contact:readonly : 读取通讯录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_title")]
            public string? JobTitle { get; set; }

            /// <summary>
            /// <para>是否为暂停状态的用户。</para>
            /// <para>**可能值有：**</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_frozen")]
            public bool? IsFrozen { get; set; }

            /// <summary>
            /// <para>职级 ID。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.job_level:readonly : 查询用户职级</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_level_id")]
            public string? JobLevelId { get; set; }

            /// <summary>
            /// <para>序列 ID。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.job_family:readonly : 查询用户所属的工作序列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("job_family_id")]
            public string? JobFamilyId { get; set; }

            /// <summary>
            /// <para>分配给用户的席位 ID 列表。需开通 **分配用户席位** 权限。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.subscription_ids:write : 分配用户席位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("subscription_ids")]
            public string[]? SubscriptionIds { get; set; }

            /// <summary>
            /// <para>用户席位列表。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.assign_info:read : 查询用户席位信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assign_info")]
            public UserAssignInfo[]? AssignInfo { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record UserAssignInfo
            {
                /// <summary>
                /// <para>席位 ID。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("subscription_id")]
                public string? SubscriptionId { get; set; }

                /// <summary>
                /// <para>席位的许可证（license plan key）。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("license_plan_key")]
                public string? LicensePlanKey { get; set; }

                /// <summary>
                /// <para>席位名称。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("product_name")]
                public string? ProductName { get; set; }

                /// <summary>
                /// <para>国际化名称。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n_name")]
                public I18nLanguage<string>? I18nName { get; set; }

                /// <summary>
                /// <para>席位起始时间。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("start_time")]
                public string? StartTime { get; set; }

                /// <summary>
                /// <para>席位结束时间。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("end_time")]
                public string? EndTime { get; set; }
            }

            /// <summary>
            /// <para>部门路径。</para>
            /// <para>**字段权限要求**：</para>
            /// <para>- contact:user.department_path:readonly : 获取成员所在部门路径</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_path")]
            public DepartmentPathSuffix[]? DepartmentPaths { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record DepartmentPathSuffix
            {
                /// <summary>
                /// <para>部门路径 ID 列表。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_ids")]
                public string[]? DepartmentIds { get; set; }

                /// <summary>
                /// <para>部门路径名字。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_path_name")]
                public DepartmentPathNameSuffix? DepartmentPathName { get; set; }

                /// <summary>
                /// <para>部门路径。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_path")]
                public DepartmentPathSuffix? DepartmentPath { get; set; }

                /// <summary>
                /// 
                /// </summary>
                public record DepartmentPathNameSuffix
                {
                    /// <summary>
                    /// <para>部门名。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>部门国际化名。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("i18n_name")]
                    public I18nLanguage<string>? I18nName { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>用户组对象。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_groups")]
        public UserGroup[]? UserGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record UserGroup
        {
            /// <summary>
            /// <para>用户组的自定义 ID。</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`1` ～ `64` 字符</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_group_id")]
            public string? UserGroupId { get; set; }

            /// <summary>
            /// <para>用户组的名称。</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`1` ～ `100` 字符</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>用户组的类型。</para>
            /// <para>**可选值有**：</para>
            /// <para>1:普通用户组。,2:动态用户组。</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：普通用户组。</item>
            /// <item>2：动态用户组。</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>成员数量。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("member_count")]
            public int? MemberCount { get; set; }

            /// <summary>
            /// <para>用户组状态。</para>
            /// <para>**可选值有**：</para>
            /// <para>0:未知。,1:计算完毕。,2:计算中。,3:计算失败。</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：未知。</item>
            /// <item>1：计算完毕。</item>
            /// <item>2：计算中。</item>
            /// <item>3：计算失败。</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }
        }
    }
}
