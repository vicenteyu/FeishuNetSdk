namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新用户所有信息 请求体
/// <para>该接口用于更新通讯录中用户的字段。</para>
/// <para>接口ID：6943913881476808731</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//user/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fupdate</para>
/// </summary>
public record PutContactV3UsersByUserIdBodyDto
{
    /// <summary>
    /// <para>用户名</para>
    /// <para>必填：是</para>
    /// <para>示例值：张三</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>英文名</para>
    /// <para>必填：否</para>
    /// <para>示例值：San Zhang</para>
    /// </summary>
    [JsonPropertyName("en_name")]
    public string? EnName { get; set; }

    /// <summary>
    /// <para>别名</para>
    /// <para>必填：否</para>
    /// <para>示例值：Alex Zhang</para>
    /// </summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>
    /// <para>邮箱</para>
    /// <para>注意：</para>
    /// <para>1. 非中国大陆手机号成员必须同时添加邮箱</para>
    /// <para>2. 邮箱不可重复</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan@gmail.com</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>手机号</para>
    /// <para>注意：</para>
    /// <para>1. 在本企业内不可重复</para>
    /// <para>2. 未认证企业仅支持添加中国大陆手机号，通过飞书认证的企业允许添加海外手机号</para>
    /// <para>3. 国际电话区号前缀中必须包含加号 +</para>
    /// <para>4. 该 mobile 字段在海外版飞书非必填</para>
    /// <para>必填：是</para>
    /// <para>示例值：13011111111 (其他例子，中国大陆手机号: 13011111111 或 +8613011111111, 非中国大陆手机号: +41446681800)</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public string Mobile { get; set; } = string.Empty;

    /// <summary>
    /// <para>手机号码可见性，true 为可见，false 为不可见，目前默认为 true。不可见时，组织员工将无法查看该员工的手机号码</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("mobile_visible")]
    public bool? MobileVisible { get; set; }

    /// <summary>
    /// <para>性别</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：保密</item>
    /// <item>1：男</item>
    /// <item>2：女</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("gender")]
    public int? Gender { get; set; }

    /// <summary>
    /// <para>头像的文件Key，可通过“消息与群组/消息/图片信息”中的“上传图片”接口上传并获取头像文件 Key</para>
    /// <para>“上传图片”功能参见[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)</para>
    /// <para>必填：否</para>
    /// <para>示例值：2500c7a9-5fff-4d9a-a2de-3d59614ae28g</para>
    /// </summary>
    [JsonPropertyName("avatar_key")]
    public string? AvatarKey { get; set; }

    /// <summary>
    /// <para>用户所属部门的ID列表，一个用户可属于多个部门。</para>
    /// <para>ID值的类型与查询参数中的department_id_type 对应。</para>
    /// <para>不同 ID 的说明与department_id的获取方式参见 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
    /// <para>必填：是</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[] DepartmentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>用户的直接主管的用户ID，ID值与查询参数中的user_id_type 对应。</para>
    /// <para>不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>获取方式参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("leader_user_id")]
    public string? LeaderUserId { get; set; }

    /// <summary>
    /// <para>工作城市</para>
    /// <para>必填：否</para>
    /// <para>示例值：杭州</para>
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// <para>国家或地区Code缩写，具体写入格式请参考 [国家/地区码表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/country-code-description)</para>
    /// <para>必填：否</para>
    /// <para>示例值：CN</para>
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// <para>工位</para>
    /// <para>必填：否</para>
    /// <para>示例值：北楼-H34</para>
    /// </summary>
    [JsonPropertyName("work_station")]
    public string? WorkStation { get; set; }

    /// <summary>
    /// <para>入职时间，时间戳格式，表示从1970年1月1日开始所经过的秒数</para>
    /// <para>必填：否</para>
    /// <para>示例值：2147483647</para>
    /// </summary>
    [JsonPropertyName("join_time")]
    public int? JoinTime { get; set; }

    /// <summary>
    /// <para>工号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("employee_no")]
    public string? EmployeeNo { get; set; }

    /// <summary>
    /// <para>员工类型，可选值有：</para>
    /// <para>- `1`：正式员工</para>
    /// <para>- `2`：实习生</para>
    /// <para>- `3`：外包</para>
    /// <para>- `4`：劳务</para>
    /// <para>- `5`：顾问</para>
    /// <para>同时可读取到自定义员工类型的 int 值，可通过下方接口获取到该租户的自定义员工类型的名称，参见[获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("employee_type")]
    public int EmployeeType { get; set; }

    /// <summary>
    /// <para>用户排序信息。</para>
    /// <para>用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("orders")]
    public UserOrder[]? Orders { get; set; }

    /// <summary>
    /// <para>用户排序信息。</para>
    /// <para>用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
    /// </summary>
    public record UserOrder
    {
        /// <summary>
        /// <para>排序信息对应的部门ID， ID值与查询参数中的department_id_type 对应。</para>
        /// <para>表示用户所在的、且需要排序的部门。</para>
        /// <para>不同 ID 的说明参见及获取方式参见 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>用户在其直属部门内的排序，数值越大，排序越靠前</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("user_order")]
        public int? UserOrderSuffix { get; set; }

        /// <summary>
        /// <para>用户所属的多个部门间的排序，数值越大，排序越靠前</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("department_order")]
        public int? DepartmentOrder { get; set; }

        /// <summary>
        /// <para>标识用户的唯一主部门，主部门为用户所属部门中排序第一的部门(department_order最大)</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_primary_dept")]
        public bool? IsPrimaryDept { get; set; }
    }

    /// <summary>
    /// <para>自定义字段，请确保你的组织管理员已在管理后台/组织架构/成员字段管理/自定义字段管理/全局设置中开启了“允许开放平台 API 调用“，否则该字段不会生效/返回。</para>
    /// <para>更多详情参见[用户接口相关问题](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN#77061525)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_attrs")]
    public UserCustomAttr[]? CustomAttrs { get; set; }

    /// <summary>
    /// <para>自定义字段，请确保你的组织管理员已在管理后台/组织架构/成员字段管理/自定义字段管理/全局设置中开启了“允许开放平台 API 调用“，否则该字段不会生效/返回。</para>
    /// <para>更多详情参见[用户接口相关问题](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN#77061525)</para>
    /// </summary>
    public record UserCustomAttr
    {
        /// <summary>
        /// <para>自定义字段类型</para>
        /// <para>- `TEXT`：文本</para>
        /// <para>- `HREF`：网页</para>
        /// <para>- `ENUMERATION`：枚举</para>
        /// <para>- `PICTURE_ENUM`：图片</para>
        /// <para>- `GENERIC_USER`：用户</para>
        /// <para>具体说明参见常见问题的[用户接口相关问题](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN#77061525)</para>
        /// <para>必填：否</para>
        /// <para>示例值：TEXT</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>自定义字段ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：DemoId</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>自定义字段取值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("value")]
        public UserCustomAttrValue? Value { get; set; }

        /// <summary>
        /// <para>自定义字段取值</para>
        /// </summary>
        public record UserCustomAttrValue
        {
            /// <summary>
            /// <para>字段类型为`TEXT`时该参数定义字段值，必填；字段类型为`HREF`时该参数定义网页标题，必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：DemoText</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string? Text { get; set; }

            /// <summary>
            /// <para>字段类型为 HREF 时，该参数定义默认 URL，例如手机端跳转小程序，PC端跳转网页</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://www.fs.cn</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>字段类型为 HREF 时，该参数定义PC端 URL</para>
            /// <para>必填：否</para>
            /// <para>示例值：http://www.fs.cn</para>
            /// </summary>
            [JsonPropertyName("pc_url")]
            public string? PcUrl { get; set; }

            /// <summary>
            /// <para>字段类型为 ENUMERATION 或 PICTURE_ENUM 时，该参数定义选项值</para>
            /// <para>必填：否</para>
            /// <para>示例值：edcvfrtg</para>
            /// </summary>
            [JsonPropertyName("option_id")]
            public string? OptionId { get; set; }

            /// <summary>
            /// <para>字段类型为 GENERIC_USER 时，该参数定义引用人员</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("generic_user")]
            public CustomAttrGenericUser? GenericUser { get; set; }

            /// <summary>
            /// <para>字段类型为 GENERIC_USER 时，该参数定义引用人员</para>
            /// </summary>
            public record CustomAttrGenericUser
            {
                /// <summary>
                /// <para>用户的user_id ，具体参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
                /// <para>必填：是</para>
                /// <para>示例值：9b2fabg5</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>用户类型:</para>
                /// <para>1：用户</para>
                /// <para>目前固定为1，表示用户类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("type")]
                public int Type { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>企业邮箱，请先确保已在管理后台启用飞书邮箱服务</para>
    /// <para>创建用户时，企业邮箱的使用方式参见[用户接口相关问题](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN#77061525)</para>
    /// <para>必填：否</para>
    /// <para>示例值：demo@mail.com</para>
    /// </summary>
    [JsonPropertyName("enterprise_email")]
    public string? EnterpriseEmail { get; set; }

    /// <summary>
    /// <para>职务</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxx</para>
    /// </summary>
    [JsonPropertyName("job_title")]
    public string? JobTitle { get; set; }

    /// <summary>
    /// <para>是否暂停用户</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_frozen")]
    public bool? IsFrozen { get; set; }
}
