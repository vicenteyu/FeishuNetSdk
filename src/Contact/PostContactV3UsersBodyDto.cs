// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3UsersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建用户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建用户 请求体
/// <para>调用该接口向通讯录创建一个用户（该动作可以理解为员工入职）。成功创建用户后，系统会以短信或邮件的形式向用户发送邀请，用户在同意邀请后方可访问企业或团队。</para>
/// <para>## 注意事项</para>
/// <para>- 创建用户时，所操作的所有部门均需要在当前应用的通讯录权限范围内，才能成功创建。如果需要在根部门下创建用户，则应用必须有全员权限。关于通讯录权限范围的具体说明可参见[权限范围资源介绍](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)。</para>
/// <para>- 发送请求后获取到的响应数据受接口的字段权限要求影响，接口只返回有权限的数据，因此你在调用前需要为应用申请必要的接口权限和字段权限。如何申请 API 权限可参见[申请 API 权限](https://open.feishu.cn/document/ukTMukTMukTM/uQjN3QjL0YzN04CN2cDN)。</para>
/// <para>## 使用限制</para>
/// <para>- 未认证企业的人数上限为 100。</para>
/// <para>- 已认证企业的人数上限在不同飞书版本里不相同，具体参考[版本对比](https://www.feishu.cn/service)。</para>
/// <para>接口ID：6943913881476939803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fcreate</para>
/// </summary>
public record PostContactV3UsersBodyDto
{
    /// <summary>
    /// <para>自定义用户的 user_id。长度不能超过 64 字符。</para>
    /// <para>user_id 是用户在当前租户内的唯一标识，自定义时请确保唯一性。</para>
    /// <para>**默认值**：空，表示由系统随机生成一个 user_id。</para>
    /// <para>必填：否</para>
    /// <para>示例值：3e3cf96b</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>用户名。长度不能超过 255 字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：张三</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>英文名。长度不能超过 255 字符。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：San Zhang</para>
    /// </summary>
    [JsonPropertyName("en_name")]
    public string? EnName { get; set; }

    /// <summary>
    /// <para>别名。长度不能超过 255 字符。</para>
    /// <para>**默认值**：空</para>
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
    /// <para>**默认值**：空</para>
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
    /// <para>必填：是</para>
    /// <para>示例值：13011111111</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// <para>手机号码是否对其他员工可见。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：可见。</para>
    /// <para>- false：不可见。不可见时，企业内的员工将无法查看该用户的手机号码。</para>
    /// <para>**默认值**：true</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("mobile_visible")]
    public bool? MobileVisible { get; set; }

    /// <summary>
    /// <para>性别。</para>
    /// <para>**默认值**：0</para>
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
    /// <para>头像的文件 Key。你可以通过[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)接口，上传并获取头像文件 Key，上传时图片类型需要选择 用于设置头像</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：2500c7a9-5fff-4d9a-a2de-3d59614ae28g</para>
    /// </summary>
    [JsonPropertyName("avatar_key")]
    public string? AvatarKey { get; set; }

    /// <summary>
    /// <para>用户所属部门的 ID 列表。</para>
    /// <para>- 一个用户可属于多个部门，最多可设置 50 个部门。</para>
    /// <para>- 部门 ID 类型与查询参数 `department_id_type` 保持一致。</para>
    /// <para>- 你可以调用[搜索部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/search)接口，通过部门名称关键词获取对应的部门 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[] DepartmentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>用户的直接主管的用户 ID，ID 类型与查询参数 `user_id_type` 保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("leader_user_id")]
    public string? LeaderUserId { get; set; }

    /// <summary>
    /// <para>工作城市。字符长度上限为 100。</para>
    /// <para>**说明**：</para>
    /// <para>- 你可以调用[获取租户工作城市列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/work_city/list)接口获取当前租户内已有的工作城市名称。</para>
    /// <para>- 如果你传入的工作城市名称不存在，则系统会自动生成该工作城市。工作城市的枚举值数量上限为 10,000。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：杭州</para>
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// <para>国家或地区 Code 缩写。具体写入格式参考 [国家/地区 Code 参照表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/country-code-description)。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：CN</para>
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// <para>工位。字符长度上限为 255。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：北楼-H34</para>
    /// </summary>
    [JsonPropertyName("work_station")]
    public string? WorkStation { get; set; }

    /// <summary>
    /// <para>入职时间。秒级时间戳格式，表示从 1970 年 1 月 1 日开始所经过的秒数。如果不传入该参数，则默认填充当前请求时的时间。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2147483647</para>
    /// </summary>
    [JsonPropertyName("join_time")]
    public int? JoinTime { get; set; }

    /// <summary>
    /// <para>工号。字符长度上限为 255。</para>
    /// <para>**注意**：同一租户下，用户工号不能重复。</para>
    /// <para>**默认值**：空</para>
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
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("employee_type")]
    public int EmployeeType { get; set; }

    /// <summary>
    /// <para>用户排序信息列表。该参数用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("orders")]
    public UserOrder[]? Orders { get; set; }

    /// <summary>
    /// <para>用户排序信息列表。该参数用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
    /// </summary>
    public record UserOrder
    {
        /// <summary>
        /// <para>排序信息对应的部门 ID。表示用户所在的、且需要排序的部门。</para>
        /// <para>**注意**：</para>
        /// <para>- 部门 ID 类型与查询参数 `department_id_type` 保持一致。</para>
        /// <para>- 该参数所传入的部门 ID 必须在用户所属的部门 ID 列表（department_ids 参数）内。</para>
        /// <para>- 如果不传值，系统默认会将 department_ids 参数内的部门 ID，依次传入 order 的 department_id 参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>用户在其直属部门内的排序。数值越大，排序越靠前。</para>
        /// <para>**注意**：该参数为 int 类型，取值时不能超出 int 的最大值。</para>
        /// <para>**默认值**：0</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("user_order")]
        public int? UserOrderSuffix { get; set; }

        /// <summary>
        /// <para>用户所属的多个部门之间的排序。数值越大，排序越靠前。</para>
        /// <para>**注意**：该参数为 int 类型，取值时不能超出 int 的最大值。</para>
        /// <para>**默认值**：0</para>
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
        /// <para>**默认值**：如果当前的 department_id 是 department_ids 中传入的第一个数据，则默认值为 true，否则为 false。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_primary_dept")]
        public bool? IsPrimaryDept { get; set; }
    }

    /// <summary>
    /// <para>自定义字段。设置参数前建议你先了解[自定义字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
    /// <para>**默认值**：空。如果没有设置自定义字段，则无需传入值。</para>
    /// <para>**注意事项**：当企业管理员在管理后台配置了自定义字段，且开启了 **允许开放平台 API 调用** 功能后，该字段才会生效。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_attrs")]
    public UserCustomAttr[]? CustomAttrs { get; set; }

    /// <summary>
    /// <para>自定义字段。设置参数前建议你先了解[自定义字段资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/overview)。</para>
    /// <para>**默认值**：空。如果没有设置自定义字段，则无需传入值。</para>
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
        /// <para>自定义字段 ID。你可以调用[获取企业自定义用户字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/list)接口获取自定义字段对应的字段 ID。</para>
        /// <para>**说明**：如果设置了自定义字段类型参数（type），则该参数必填。</para>
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
            /// <para>- 自定义字段类型为 TEXT 时，该参数必填，用于定义字段值。</para>
            /// <para>- 自定义字段类型为 HREF 时，该参数必填，用于定义网页标题。</para>
            /// <para>长度不能超过 100 字符。</para>
            /// <para>必填：否</para>
            /// <para>示例值：DemoText</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string? Text { get; set; }

            /// <summary>
            /// <para>自定义字段类型为 HREF 时，该参数必填，用于定义默认 URL。例如，手机端跳转小程序，PC端跳转网页。</para>
            /// <para>**注意**：请以 http:// 或 https:// 开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://www.fs.cn</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>自定义字段类型为 HREF 时，该参数用于定义 PC 端 URL。</para>
            /// <para>**注意**：请以 http:// 或 https:// 开头。</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://www.fs.cn</para>
            /// </summary>
            [JsonPropertyName("pc_url")]
            public string? PcUrl { get; set; }

            /// <summary>
            /// <para>自定义字段类型为 ENUMERATION 或 PICTURE_ENUM 时，该参数用于定义选项 ID。</para>
            /// <para>你可以调用[获取企业自定义用户字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/custom_attr/list)接口获取自定义字段相应的选项 ID。</para>
            /// <para>必填：否</para>
            /// <para>示例值：edcvfrtg</para>
            /// </summary>
            [JsonPropertyName("option_id")]
            public string? OptionId { get; set; }

            /// <summary>
            /// <para>自定义字段类型为 GENERIC_USER 时，该参数用于定义引用人员。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("generic_user")]
            public CustomAttrGenericUser? GenericUser { get; set; }

            /// <summary>
            /// <para>自定义字段类型为 GENERIC_USER 时，该参数用于定义引用人员。</para>
            /// </summary>
            public record CustomAttrGenericUser
            {
                /// <summary>
                /// <para>引用人员的用户 ID。</para>
                /// <para>- ID 类型与查询参数 `user_id_type` 保持一致。</para>
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
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：demo@mail.com</para>
    /// </summary>
    [JsonPropertyName("enterprise_email")]
    public string? EnterpriseEmail { get; set; }

    /// <summary>
    /// <para>职务名称。字符数量上限为 255。</para>
    /// <para>- 你可以调用[获取租户职务列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_title/list)接口获取相应的职务名称。</para>
    /// <para>- 如果传入的职务名称不存在，则系统会自动创建并使用该名称。职务枚举值数量上限为 10,000。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxx</para>
    /// </summary>
    [JsonPropertyName("job_title")]
    public string? JobTitle { get; set; }

    /// <summary>
    /// <para>数据驻留地。</para>
    /// <para>**注意事项**：需联系服务台技术支持开通使用。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：cn</para>
    /// </summary>
    [JsonPropertyName("geo")]
    public string? Geo { get; set; }

    /// <summary>
    /// <para>职级 ID。你可以调用[获取租户职级列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_level/list)接口查询相应的职级 ID。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：mga5oa8ayjlp9rb</para>
    /// </summary>
    [JsonPropertyName("job_level_id")]
    public string? JobLevelId { get; set; }

    /// <summary>
    /// <para>序列 ID。你可以调用[获取租户序列列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_family/list)接口查询相应的序列 ID。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：mga5oa8ayjlp9rb</para>
    /// </summary>
    [JsonPropertyName("job_family_id")]
    public string? JobFamilyId { get; set; }

    /// <summary>
    /// <para>分配给用户的席位 ID 列表。</para>
    /// <para>**注意事项**：</para>
    /// <para>- 该字段需要应用已开通 **分配用户席位** 权限。</para>
    /// <para>- 如果你购买了席位，则创建用户时必须为用户分配席位 ID，否则用户将无法登录企业飞书。更多信息可参见[管理员分配席位](https://www.feishu.cn/hc/zh-CN/articles/548377434838-%E7%AE%A1%E7%90%86%E5%91%98%E5%88%86%E9%85%8D%E5%B8%AD%E4%BD%8D)。</para>
    /// <para>- 你可通过[获取企业席位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/tenant-v2/tenant-product_assign_info/query)接口，获取到当前租户的可用席位 ID。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscription_ids")]
    public string[]? SubscriptionIds { get; set; }

    /// <summary>
    /// <para>虚线上级的用户 ID 列表。</para>
    /// <para>- ID 类型与查询参数 `user_id_type` 保持一致。</para>
    /// <para>- 如何获取用户 ID 可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dotted_line_leader_user_ids")]
    public string[]? DottedLineLeaderUserIds { get; set; }
}
