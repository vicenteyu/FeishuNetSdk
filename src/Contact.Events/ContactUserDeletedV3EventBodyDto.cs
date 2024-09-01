// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ContactUserDeletedV3EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>员工离职 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Events;
/// <summary>
/// 员工离职 事件体
/// <para>当应用订阅该事件后，如果有员工离职（例如，通过管理后台离职成员、调用删除用户 API），则会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=contact&amp;version=v3&amp;resource=user&amp;event=deleted)</para>
/// <para>接口ID：6954228303264071707</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fevents%2fdeleted</para>
/// </summary>
public record ContactUserDeletedV3EventBodyDto() : EventBodyDto("contact.user.deleted_v3")
{
    /// <summary>
    /// <para>员工信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object")]
    public UserEvent? Object { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record UserEvent
    {
        /// <summary>
        /// <para>用户的 open_id，应用内用户的唯一标识。不同用户 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>用户的 union_id，是应用开发商发布的不同应用中同一用户的标识。不同用户 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("union_id")]
        public string? UnionId { get; set; }

        /// <summary>
        /// <para>用户的 user_id，租户内用户的唯一标识。不同用户 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- contact:user.employee_id:readonly : 获取用户 user ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

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
        /// <para>用户英文名。</para>
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
        /// <para>用户别名。</para>
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
        /// <para>企业邮箱。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:user.base:readonly : 获取用户基本信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("enterprise_email")]
        public string? EnterpriseEmail { get; set; }

        /// <summary>
        /// <para>职务。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

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
        /// <para>0:未知,1:男,2:女,3:其他</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:user.gender:readonly : 获取用户性别</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：男</item>
        /// <item>2：女</item>
        /// <item>3：其他</item>
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
        /// <para>用户所属部门的 ID 列表。部门 ID 类型为open_department_id，了解部门 ID 可参见[部门 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:user.department:readonly : 获取用户组织架构信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户直属主管的用户 open_id 。了解用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>城市。</para>
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
        /// <para>国家。</para>
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
        /// <para>入职时间。秒级时间戳格式。</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`1` ～ `2147483647`</para>
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
        /// <para>**说明**：支持读取自定义员工类型的 int 值。如果该参数的取值不为 1 ~ 5，则你可调用[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)接口查询相应的自定义员工类型信息（employee_type 对应 **查询人员类型** 接口返回的 enum_value）。</para>
        /// <para>**可选值有**：</para>
        /// <para>1:正式员工,2:实习生,3:外包,4:劳务,5:顾问</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:user.employee:readonly : 获取用户受雇信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：正式员工</item>
        /// <item>2：实习生</item>
        /// <item>3：外包</item>
        /// <item>4：劳务</item>
        /// <item>5：顾问</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public int? EmployeeType { get; set; }

        /// <summary>
        /// <para>用户排序信息。用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:user.department:readonly : 获取用户组织架构信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("orders")]
        public UserOrderSuffix[]? Orders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record UserOrderSuffix
        {
            /// <summary>
            /// <para>排序信息对应的部门 ID，表示用户所在的、且需要排序的部门。该 ID 均包含在用户所属部门 ID 列表（department_ids）的参数值当中。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>用户在其直属部门内的排序，数值越大，排序越靠前。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_order")]
            public int? UserOrder { get; set; }

            /// <summary>
            /// <para>用户所属的多个部门间的排序，数值越大，排序越靠前。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_order")]
            public int? DepartmentOrder { get; set; }

            /// <summary>
            /// <para>标识部门是否为用户的唯一主部门，主部门为用户所属部门中排序第一的部门（department_order 最大）。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_primary_dept")]
            public bool? IsPrimaryDept { get; set; }
        }

        /// <summary>
        /// <para>自定义字段信息。了解自定义字段可参见[自定义字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
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
        /// <para>虚线上级的用户 ID。</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- contact:user.dotted_line_leader_info.read : 查看成员的虚线上级 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dotted_line_leader_user_ids")]
        public string[]? DottedLineLeaderUserIds { get; set; }
    }

    /// <summary>
    /// <para>删除前信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("old_object")]
    public OldUserObject? OldObject { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record OldUserObject
    {
        /// <summary>
        /// <para>用户所属部门的ID列表</para>
        /// <para>**字段权限要求（满足任一）**：</para>
        /// <para>- contact:contact:readonly_as_app : 以应用身份读取通讯录</para>
        /// <para>- contact:user.department:readonly : 获取用户组织架构信息</para>
        /// <para>- contact:contact:access_as_app : 以应用身份访问通讯录</para>
        /// <para>- contact:contact:readonly : 读取通讯录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户open_id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }
    }
}
