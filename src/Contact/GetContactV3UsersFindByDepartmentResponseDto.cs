// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3UsersFindByDepartmentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取部门直属用户列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取部门直属用户列表 响应体
/// <para>调用该接口获取指定部门直属的用户信息列表。用户信息包括用户 ID、名称、邮箱、手机号以及状态等信息。</para>
/// <para>## 注意事项</para>
/// <para>- 使用用户身份（user_access_token）调用该接口时，接口将根据该用户的组织架构可见范围进行过滤，仅返回组织架构可见范围内的用户数据。</para>
/// <para>- 使用应用身份（tenant_access_token）调用该接口时，接口将根据应用的通讯录权限范围进行过滤。 如果请求的部门 ID 为 0（即根部门），则接口会校验应用是否具有全员的通讯录权限；如果请求的是非 0 的部门 ID，则会校验应用是否具有该部门的通讯录权限。无权限时，接口会返回无权限的报错信息；有权限则返回对应部门下的直属用户列表。</para>
/// <para>- 使用应用身份（tenant_access_token）调用本接口时，响应结果中不会返回部门路径字段（department_path）。如需获取部门路径字段值，请为应用申请 **获取成员所在部门路径（contact:user.department_path:readonly）** API 权限，并使用用户身份（user_access_token）调用接口。</para>
/// <para>关于用户组织架构可见范围和通讯录权限范围的更多信息，可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>接口ID：7033365649318789148</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/find_by_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2ffind_by_department</para>
/// </summary>
public record GetContactV3UsersFindByDepartmentResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ%2BG8JG6tK7%2BZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>用户信息列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public User[]? Items { get; set; }

    /// <summary>
    /// <para>用户信息列表。</para>
    /// </summary>
    public record User
    {
        /// <summary>
        /// <para>用户的 union_id，是应用开发商发布的不同应用中同一用户的标识。不同用户 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
        /// </summary>
        [JsonPropertyName("union_id")]
        public string? UnionId { get; set; }

        /// <summary>
        /// <para>用户的 user_id，租户内用户的唯一标识。不同用户 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：3e3cf96b</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户的 open_id，应用内用户的唯一标识。不同用户 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>用户名。</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>英文名。</para>
        /// <para>必填：否</para>
        /// <para>示例值：San Zhang</para>
        /// </summary>
        [JsonPropertyName("en_name")]
        public string? EnName { get; set; }

        /// <summary>
        /// <para>别名。</para>
        /// <para>必填：否</para>
        /// <para>示例值：Alex Zhang</para>
        /// </summary>
        [JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// <para>邮箱。</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@gmail.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>手机号。</para>
        /// <para>必填：是</para>
        /// <para>示例值：13011111111</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; } = string.Empty;

        /// <summary>
        /// <para>手机号码是否可见。</para>
        /// <para>**可能值有**：</para>
        /// <para>- true：可见。</para>
        /// <para>- false：不可见。不可见时，企业内的员工将无法查看该用户的手机号码。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("mobile_visible")]
        public bool? MobileVisible { get; set; }

        /// <summary>
        /// <para>性别。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：保密</item>
        /// <item>1：男</item>
        /// <item>2：女</item>
        /// <item>3：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// <para>头像的文件 Key。该参数实际无返回值，请忽略，获取头像信息可使用 `avatar` 参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2500c7a9-5fff-4d9a-a2de-3d59614ae28g</para>
        /// </summary>
        [JsonPropertyName("avatar_key")]
        public string? AvatarKey { get; set; }

        /// <summary>
        /// <para>用户头像信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public AvatarInfo? Avatar { get; set; }

        /// <summary>
        /// <para>用户头像信息。</para>
        /// </summary>
        public record AvatarInfo
        {
            /// <summary>
            /// <para>72*72 像素头像链接。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>240*240 像素头像链接。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>640*640 像素头像链接。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>原始头像链接。</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }

        /// <summary>
        /// <para>用户状态。通过 is_frozen、is_resigned、is_activated、is_exited 布尔值类型参数进行展示。</para>
        /// <para>用户状态的转关逻辑可参见[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview#4302b5a1)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public UserStatus? Status { get; set; }

        /// <summary>
        /// <para>用户状态。通过 is_frozen、is_resigned、is_activated、is_exited 布尔值类型参数进行展示。</para>
        /// <para>用户状态的转关逻辑可参见[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview#4302b5a1)。</para>
        /// </summary>
        public record UserStatus
        {
            /// <summary>
            /// <para>是否为暂停状态。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_frozen")]
            public bool? IsFrozen { get; set; }

            /// <summary>
            /// <para>是否为离职状态。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_resigned")]
            public bool? IsResigned { get; set; }

            /// <summary>
            /// <para>是否为激活状态。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_activated")]
            public bool? IsActivated { get; set; }

            /// <summary>
            /// <para>是否为主动退出状态。主动退出一段时间后用户状态会自动转为已离职。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_exited")]
            public bool? IsExited { get; set; }

            /// <summary>
            /// <para>是否为未加入状态，需要用户自主确认才能加入企业或团队。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_unjoin")]
            public bool? IsUnjoin { get; set; }
        }

        /// <summary>
        /// <para>用户所属部门的 ID 列表，一个用户可属于多个部门。ID 值的类型与查询参数中的 department_id_type 取值一致。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户的直接主管的用户ID。ID 值的类型与查询参数中的 user_id_type 取值一致。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>工作城市。</para>
        /// <para>必填：否</para>
        /// <para>示例值：杭州</para>
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// <para>国家或地区 Code 缩写，具体格式参考 [国家/地区 Code 参照表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/country-code-description)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN</para>
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// <para>工位。</para>
        /// <para>必填：否</para>
        /// <para>示例值：北楼-H34</para>
        /// </summary>
        [JsonPropertyName("work_station")]
        public string? WorkStation { get; set; }

        /// <summary>
        /// <para>入职时间。秒级时间戳格式，表示从 1970 年 1 月 1 日开始所经过的秒数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2147483647</para>
        /// </summary>
        [JsonPropertyName("join_time")]
        public int? JoinTime { get; set; }

        /// <summary>
        /// <para>用户是否为租户超级管理员。</para>
        /// <para>**可能值有**：</para>
        /// <para>- true：是</para>
        /// <para>- false：否</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_tenant_manager")]
        public bool? IsTenantManager { get; set; }

        /// <summary>
        /// <para>工号。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("employee_no")]
        public string? EmployeeNo { get; set; }

        /// <summary>
        /// <para>员工类型。</para>
        /// <para>**可能值有**：</para>
        /// <para>- 1：正式员工</para>
        /// <para>- 2：实习生</para>
        /// <para>- 3：外包</para>
        /// <para>- 4：劳务</para>
        /// <para>- 5：顾问</para>
        /// <para>同时支持自定义员工类型的 int 值。你可通过[获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)接口获取到当前租户内自定义员工类型的名称。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public int? EmployeeType { get; set; }

        /// <summary>
        /// <para>用户排序信息。用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("orders")]
        public UserOrder[]? Orders { get; set; }

        /// <summary>
        /// <para>用户排序信息。用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
        /// </summary>
        public record UserOrder
        {
            /// <summary>
            /// <para>排序信息对应的部门 ID，表示用户所在的、且需要排序的部门。ID 类型与查询参数中的 department_id_type 取值一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>用户在其直属部门内的排序。数值越大，排序越靠前。</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("user_order")]
            public int? UserOrderSuffix { get; set; }

            /// <summary>
            /// <para>用户所属的多个部门间的排序。数值越大，排序越靠前。</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("department_order")]
            public int? DepartmentOrder { get; set; }

            /// <summary>
            /// <para>标识是否为用户的唯一主部门。主部门为用户所属部门中排序第一的部门(department_order 最大)。</para>
            /// <para>**可能值有**：</para>
            /// <para>- true：是</para>
            /// <para>- false：否</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_primary_dept")]
            public bool? IsPrimaryDept { get; set; }
        }

        /// <summary>
        /// <para>自定义字段。了解自定义字段可参见[自定义字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
        /// <para>**注意事项**：当企业管理员在管理后台配置了自定义字段，且开启了 **允许开放平台 API 调用** 功能后，该字段才会生效。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_attrs")]
        public UserCustomAttr[]? CustomAttrs { get; set; }

        /// <summary>
        /// <para>自定义字段。了解自定义字段可参见[自定义字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
        /// <para>**注意事项**：当企业管理员在管理后台配置了自定义字段，且开启了 **允许开放平台 API 调用** 功能后，该字段才会生效。</para>
        /// </summary>
        public record UserCustomAttr
        {
            /// <summary>
            /// <para>自定义字段类型。</para>
            /// <para>**可能值有**：</para>
            /// <para>- TEXT：文本</para>
            /// <para>- HREF：网页</para>
            /// <para>- ENUMERATION：枚举</para>
            /// <para>- PICTURE_ENUM：图片</para>
            /// <para>- GENERIC_USER：用户</para>
            /// <para>必填：否</para>
            /// <para>示例值：TEXT</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>自定义字段 ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：DemoId</para>
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
            /// <para>自定义字段取值。</para>
            /// </summary>
            public record UserCustomAttrValue
            {
                /// <summary>
                /// <para>- 字段类型为 TEXT 时，该参数返回定义的字段值。</para>
                /// <para>- 字段类型为 HREF 时，该参数返回定义的网页标题。</para>
                /// <para>必填：否</para>
                /// <para>示例值：DemoText</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// <para>字段类型为 HREF 时，该参数返回定义的默认 URL。</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://www.fs.cn</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>字段类型为 HREF 时，该参数返回定义的 PC 端 URL。</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://www.fs.cn</para>
                /// </summary>
                [JsonPropertyName("pc_url")]
                public string? PcUrl { get; set; }

                /// <summary>
                /// <para>字段类型为 ENUMERATION 或 PICTURE_ENUM 时，该参数返回定义的选项 ID。</para>
                /// <para>必填：否</para>
                /// <para>示例值：edcvfrtg</para>
                /// </summary>
                [JsonPropertyName("option_id")]
                public string? OptionId { get; set; }

                /// <summary>
                /// <para>枚举类型中选项的选项值。</para>
                /// <para>必填：否</para>
                /// <para>示例值：option</para>
                /// </summary>
                [JsonPropertyName("option_value")]
                public string? OptionValue { get; set; }

                /// <summary>
                /// <para>图片类型中图片选项的名称。</para>
                /// <para>必填：否</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>图片类型中图片选项的链接。</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://xxxxxxxxxxxxxxxxxx</para>
                /// </summary>
                [JsonPropertyName("picture_url")]
                public string? PictureUrl { get; set; }

                /// <summary>
                /// <para>字段类型为 GENERIC_USER 时，该参数返回定义的引用人员信息。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("generic_user")]
                public CustomAttrGenericUser? GenericUser { get; set; }

                /// <summary>
                /// <para>字段类型为 GENERIC_USER 时，该参数返回定义的引用人员信息。</para>
                /// </summary>
                public record CustomAttrGenericUser
                {
                    /// <summary>
                    /// <para>引用人员的用户 ID。ID 类型与查询参数 user_id_type 一致。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：9b2fabg5</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string Id { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>用户类型。目前固定为 1，表示用户类型。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int Type { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>企业邮箱。</para>
        /// <para>**注意事项**：企业管理员在管理后台启用飞书邮箱服务后，才会生效该参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：demo@mail.com</para>
        /// </summary>
        [JsonPropertyName("enterprise_email")]
        public string? EnterpriseEmail { get; set; }

        /// <summary>
        /// <para>职务。</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>是否为暂停状态的用户。</para>
        /// <para>**可能值有**：</para>
        /// <para>- true：是</para>
        /// <para>- false：否</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_frozen")]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// <para>数据驻留地。</para>
        /// <para>必填：否</para>
        /// <para>示例值：cn</para>
        /// </summary>
        [JsonPropertyName("geo")]
        public string? Geo { get; set; }

        /// <summary>
        /// <para>职级 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlp9rb</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>序列 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlp9rb</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>部门路径。</para>
        /// <para>**注意**：使用应用身份（tenant_access_token）调用本接口时，响应结果中不会返回部门路径字段（department_path）。如需获取部门路径字段值，请为应用申请 **获取成员所在部门路径（contact:user.department_path:readonly）** API 权限，并使用用户身份（user_access_token）调用接口。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_path")]
        public DepartmentDetail[]? DepartmentPaths { get; set; }

        /// <summary>
        /// <para>部门路径。</para>
        /// <para>**注意**：使用应用身份（tenant_access_token）调用本接口时，响应结果中不会返回部门路径字段（department_path）。如需获取部门路径字段值，请为应用申请 **获取成员所在部门路径（contact:user.department_path:readonly）** API 权限，并使用用户身份（user_access_token）调用接口。</para>
        /// </summary>
        public record DepartmentDetail
        {
            /// <summary>
            /// <para>部门 ID。ID 类型与查询参数 department_id_type 的取值保持一致。</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>部门名称信息。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_name")]
            public DepartmentPathName? DepartmentName { get; set; }

            /// <summary>
            /// <para>部门名称信息。</para>
            /// </summary>
            public record DepartmentPathName
            {
                /// <summary>
                /// <para>部门名。</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试部门名1</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>部门国际化名。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n_name")]
                public DepartmentI18nName? I18nName { get; set; }

                /// <summary>
                /// <para>部门国际化名。</para>
                /// </summary>
                public record DepartmentI18nName
                {
                    /// <summary>
                    /// <para>部门的中文名。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：测试部门名1</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>部门的日文名。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：試験部署名 1</para>
                    /// </summary>
                    [JsonPropertyName("ja_jp")]
                    public string? JaJp { get; set; }

                    /// <summary>
                    /// <para>部门的英文名。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Test department name 1</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>部门路径。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_path")]
            public DepartmentDetailDepartmentPath? DepartmentPath { get; set; }

            /// <summary>
            /// <para>部门路径。</para>
            /// </summary>
            public record DepartmentDetailDepartmentPath
            {
                /// <summary>
                /// <para>部门路径 ID 列表。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_ids")]
                public string[]? DepartmentIds { get; set; }

                /// <summary>
                /// <para>部门路径名字信息。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department_path_name")]
                public DepartmentDetailDepartmentPathDepartmentPathName? DepartmentPathName { get; set; }

                /// <summary>
                /// <para>部门路径名字信息。</para>
                /// </summary>
                public record DepartmentDetailDepartmentPathDepartmentPathName
                {
                    /// <summary>
                    /// <para>部门名。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：测试部门名1</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>部门国际化名。</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("i18n_name")]
                    public DepartmentI18nName? I18nName { get; set; }

                    /// <summary>
                    /// <para>部门国际化名。</para>
                    /// </summary>
                    public record DepartmentI18nName
                    {
                        /// <summary>
                        /// <para>部门的中文名。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试部门名1</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>部门的日文名。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：試験部署名 1</para>
                        /// </summary>
                        [JsonPropertyName("ja_jp")]
                        public string? JaJp { get; set; }

                        /// <summary>
                        /// <para>部门的英文名。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Test department name 1</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>虚线上级的用户 ID。ID 类型与查询参数 user_id_type 的取值保持一致。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dotted_line_leader_user_ids")]
        public string[]? DottedLineLeaderUserIds { get; set; }
    }
}
