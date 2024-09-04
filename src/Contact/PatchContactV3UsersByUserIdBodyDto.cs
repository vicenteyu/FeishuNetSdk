// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchContactV3UsersByUserIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改用户部分信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 修改用户部分信息 请求体
/// <para>调用该接口更新通讯录中指定用户的信息，包括名称、邮箱、手机号、所属部门以及自定义字段等信息。</para>
/// <para>## 注意事项</para>
/// <para>- 发送请求时，未传递的参数不会更新。</para>
/// <para>- 并发操作冻结用户时，因事务冲突会遇到概率性的接口调用失败。因此，请尝试降低请求速率或改为串行执行。</para>
/// <para>- 更新 `department_ids`、`is_frozen` 时，限制调用频率为 1 QPS。</para>
/// <para>接口ID：6943913881476792347</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fpatch</para>
/// </summary>
public record PatchContactV3UsersByUserIdBodyDto
{
    /// <summary>
    /// <para>用户名。长度不能超过 255 字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：张三</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>英文名。长度不能超过 255 字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：San Zhang</para>
    /// </summary>
    [JsonPropertyName("en_name")]
    public string? EnName { get; set; }

    /// <summary>
    /// <para>别名。长度不能超过 255 字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：Alex Zhang</para>
    /// </summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>
    /// <para>邮箱。</para>
    /// <para>**注意**：</para>
    /// <para>- 当设置非中国大陆的手机号时，必须同时设置邮箱。</para>
    /// <para>- 在当前租户下，邮箱不可重复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan@gmail.com</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>手机号。</para>
    /// <para>**注意**：</para>
    /// <para>- 在当前租户下，手机号不可重复。</para>
    /// <para>- 未认证企业仅支持添加中国大陆手机号；通过飞书认证的企业允许添加海外手机号。</para>
    /// <para>- 国际电话区号的前缀中，必须包含加号 **+**。</para>
    /// <para>取值示例：</para>
    /// <para>- 中国大陆手机号：13011111111 或 +8613011111111</para>
    /// <para>- 非中国大陆手机号：+41446681800</para>
    /// <para>必填：否</para>
    /// <para>示例值：13011111111</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// <para>手机号码是否可见。</para>
    /// <para>**可选值有**：</para>
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
    /// <para>头像的文件 Key。你可以通过[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)接口，上传并获取头像文件 Key。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2500c7a9-5fff-4d9a-a2de-3d59614ae28g</para>
    /// </summary>
    [JsonPropertyName("avatar_key")]
    public string? AvatarKey { get; set; }

    /// <summary>
    /// <para>用户所属部门的 ID 列表。</para>
    /// <para>- 一个用户可属于多个部门。最多可归属 50 个部门。</para>
    /// <para>- 部门 ID 类型与查询参数 `department_id_type` 的取值保持一致。</para>
    /// <para>- 你可以调用[搜索部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search)接口，通过部门名称关键词获取对应的部门 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>用户的直接主管的用户 ID，ID 类型与查询参数 `user_id_type` 的取值保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("leader_user_id")]
    public string? LeaderUserId { get; set; }

    /// <summary>
    /// <para>工作城市。字符长度上限为 100。</para>
    /// <para>- 调用[获取租户工作城市列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/work_city/list)获取当前租户内已有的工作城市列表。</para>
    /// <para>- 如果你传入的工作城市名称不存在，则系统会自动生成该工作城市。工作城市的枚举值数量上限为 10,000。</para>
    /// <para>必填：否</para>
    /// <para>示例值：杭州</para>
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// <para>国家或地区 Code 缩写。具体写入格式参考 [国家/地区 Code 参照表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/country-code-description)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：CN</para>
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// <para>工位。字符长度上限为 255。</para>
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
    /// <para>工号。字符长度上限为 255。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("employee_no")]
    public string? EmployeeNo { get; set; }

    /// <summary>
    /// <para>员工类型。</para>
    /// <para>**可选值有**：</para>
    /// <para>- 1：正式员工</para>
    /// <para>- 2：实习生</para>
    /// <para>- 3：外包</para>
    /// <para>- 4：劳务</para>
    /// <para>- 5：顾问</para>
    /// <para>该参数支持读取自定义的员工类型的 int 值。你可通过[获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)接口获取到该租户的自定义员工类型的编号值（enum_value）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("employee_type")]
    public int? EmployeeType { get; set; }

    /// <summary>
    /// <para>用户排序信息。该参数用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("orders")]
    public UserOrder[]? Orders { get; set; }

    /// <summary>
    /// <para>用户排序信息。该参数用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
    /// </summary>
    public record UserOrder
    {
        /// <summary>
        /// <para>排序信息对应的部门 ID。表示用户所在的、且需要排序的部门。</para>
        /// <para>**注意**：</para>
        /// <para>- 部门 ID 类型与查询参数 department_id_type 的取值保持一致。</para>
        /// <para>- 该参数所传入的部门 ID 必须在用户所属的部门 ID 列表（department_ids 参数）内。</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>用户在其直属部门内的排序，数值越大，排序越靠前。</para>
        /// <para>**注意**：该参数为 int 类型，取值时不能超出 int 的最大值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("user_order")]
        public int? UserOrderSuffix { get; set; }

        /// <summary>
        /// <para>用户所属的多个部门间的排序，数值越大，排序越靠前。</para>
        /// <para>**注意**：该参数为 int 类型，取值时不能超出 int 的最大值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("department_order")]
        public int? DepartmentOrder { get; set; }

        /// <summary>
        /// <para>标识是否为用户的唯一主部门，主部门为用户所属部门中排序第一的部门（department_order 最大）。</para>
        /// <para>**可选值有**：</para>
        /// <para>- true：是</para>
        /// <para>- false：否</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_primary_dept")]
        public bool? IsPrimaryDept { get; set; }
    }

    /// <summary>
    /// <para>自定义字段。设置参数前建议你先了解[自定义字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
    /// <para>**注意事项**：当企业管理员在管理后台配置了自定义字段，且开启了 **允许开放平台 API 调用** 功能后，该字段才会生效。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_attrs")]
    public UserCustomAttr[]? CustomAttrs { get; set; }

    /// <summary>
    /// <para>自定义字段。设置参数前建议你先了解[自定义字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
    /// <para>**注意事项**：当企业管理员在管理后台配置了自定义字段，且开启了 **允许开放平台 API 调用** 功能后，该字段才会生效。</para>
    /// </summary>
    public record UserCustomAttr
    {
        /// <summary>
        /// <para>自定义字段类型。</para>
        /// <para>**可选值有**：</para>
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
            /// <para>- 字段类型为 TEXT 时，该参数定义字段值，必填。</para>
            /// <para>- 字段类型为 HREF 时，该参数定义网页标题，必填。</para>
            /// <para>长度不能超过 100 字符。</para>
            /// <para>必填：否</para>
            /// <para>示例值：DemoText</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string? Text { get; set; }

            /// <summary>
            /// <para>字段类型为 HREF 时，该参数定义默认 URL。例如，手机端跳转小程序，PC端跳转网页。</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://www.fs.cn</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>字段类型为 HREF 时，该参数定义 PC 端 URL。</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://www.fs.cn</para>
            /// </summary>
            [JsonPropertyName("pc_url")]
            public string? PcUrl { get; set; }

            /// <summary>
            /// <para>字段类型为 ENUMERATION 或 PICTURE_ENUM 时，该参数定义选项 ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：edcvfrtg</para>
            /// </summary>
            [JsonPropertyName("option_id")]
            public string? OptionId { get; set; }

            /// <summary>
            /// <para>字段类型为 GENERIC_USER 时，该参数定义引用人员。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("generic_user")]
            public CustomAttrGenericUser? GenericUser { get; set; }

            /// <summary>
            /// <para>字段类型为 GENERIC_USER 时，该参数定义引用人员。</para>
            /// </summary>
            public record CustomAttrGenericUser
            {
                /// <summary>
                /// <para>引用人员的用户 ID。</para>
                /// <para>- ID 类型与查询参数 `user_id_type` 的取值保持一致。</para>
                /// <para>- 如何获取用户 ID 可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
                /// <para>必填：是</para>
                /// <para>示例值：9b2fabg5</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>用户类型。</para>
                /// <para>**可选值有**：</para>
                /// <para>1：用户</para>
                /// <para>**说明**：目前仅支持取值 1，表示用户。</para>
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
    /// <para>**注意事项**：企业管理员在管理后台启用飞书邮箱服务后，才会生效该参数。如果设置企业邮箱失败，请联系企业管理员确认是否在管理后台启用了相应的企业邮箱域名。</para>
    /// <para>必填：否</para>
    /// <para>示例值：demo@mail.com</para>
    /// </summary>
    [JsonPropertyName("enterprise_email")]
    public string? EnterpriseEmail { get; set; }

    /// <summary>
    /// <para>职务名称。字符数量上限为 255。</para>
    /// <para>- 你可以调用[获取租户职务列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_title/list)接口获取相应的租户名称。</para>
    /// <para>- 如果传入的职务名称不存在，则系统会自动创建并使用该名称。职务枚举值数量上限为 10,000。</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxx</para>
    /// </summary>
    [JsonPropertyName("job_title")]
    public string? JobTitle { get; set; }

    /// <summary>
    /// <para>是否是暂停状态的用户。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：是</para>
    /// <para>- false：否</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_frozen")]
    public bool? IsFrozen { get; set; }

    /// <summary>
    /// <para>职级 ID。你可以调用[获取租户职级列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_level/list)接口查询相应的职级 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：mga5oa8ayjlp9rb</para>
    /// </summary>
    [JsonPropertyName("job_level_id")]
    public string? JobLevelId { get; set; }

    /// <summary>
    /// <para>序列 ID。你可以调用[获取租户序列列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_family/list)接口查询相应的序列 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：mga5oa8ayjlp9rb</para>
    /// </summary>
    [JsonPropertyName("job_family_id")]
    public string? JobFamilyId { get; set; }

    /// <summary>
    /// <para>分配给用户的席位 ID 列表。</para>
    /// <para>**注意事项**：</para>
    /// <para>- 该字段需开通 **分配用户席位** 权限。</para>
    /// <para>- 你可通过[获取企业席位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/tenant-v2/tenant-product_assign_info/query)接口，获取到当前租户的可用席位 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["7179609168571645971"]</para>
    /// </summary>
    [JsonPropertyName("subscription_ids")]
    public string[]? SubscriptionIds { get; set; }

    /// <summary>
    /// <para>虚线上级的用户 ID 列表。</para>
    /// <para>- ID 类型与查询参数 `user_id_type` 的取值保持一致。</para>
    /// <para>- 如何获取用户 ID 可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dotted_line_leader_user_ids")]
    public string[]? DottedLineLeaderUserIds { get; set; }
}
