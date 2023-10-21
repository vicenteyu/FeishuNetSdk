using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单个用户信息 响应体
/// <para>该接口用于获取通讯录中单个用户的信息。</para>
/// <para>接口ID：6943913881476956187</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fget</para>
/// </summary>
public record GetContactV3UsersByUserIdResponseDto
{
    /// <summary>
    /// <para>用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user")]
    public GetContactV3UsersByUserIdResponseDtoUser? User { get; set; }

    /// <summary>
    /// <para>用户信息</para>
    /// </summary>
    public record GetContactV3UsersByUserIdResponseDtoUser
    {
        /// <summary>
        /// <para>用户的union_id，应用开发商发布的不同应用中同一用户的标识，不同ID的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：on_94a1ee5551019f18cd73d9f111898cf2</para>
        /// </summary>
        [JsonProperty("union_id")]
        public string? UnionId { get; set; }

        /// <summary>
        /// <para>用户的user_id，租户内用户的唯一标识，不同ID的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：3e3cf96b</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户的open_id，应用内用户的唯一标识，不同ID的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonProperty("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>用户名</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>英文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：SanZhang</para>
        /// </summary>
        [JsonProperty("en_name")]
        public string? EnName { get; set; }

        /// <summary>
        /// <para>别名</para>
        /// <para>必填：否</para>
        /// <para>示例值：AlexZhang</para>
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// <para>邮箱</para>
        /// <para>注意：</para>
        /// <para>1. 非中国大陆手机号成员必须同时添加邮箱</para>
        /// <para>2. 邮箱不可重复</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan@gmail.com</para>
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>手机号</para>
        /// <para>注意：</para>
        /// <para>1. 在本企业内不可重复</para>
        /// <para>2. 未认证企业仅支持添加中国大陆手机号，通过飞书认证的企业允许添加海外手机号</para>
        /// <para>3. 国际电话区号前缀中必须包含加号 +</para>
        /// <para>4. 该 mobile 字段在海外版飞书非必填</para>
        /// <para>必填：否</para>
        /// <para>示例值：13011111111(其他例子，中国大陆手机号:13011111111或+8613011111111,非中国大陆手机号:+41446681800)</para>
        /// </summary>
        [JsonProperty("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>手机号码可见性，true 为可见，false 为不可见，目前默认为 true。不可见时，组织员工将无法查看该员工的手机号码</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("mobile_visible")]
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
        [JsonProperty("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// <para>用户头像信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("avatar")]
        public AvatarInfo? Avatar { get; set; }

        /// <summary>
        /// <para>用户头像信息</para>
        /// </summary>
        public record AvatarInfo
        {
            /// <summary>
            /// <para>72*72像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonProperty("avatar_72")]
            public string? Avatar72 { get; set; }

            /// <summary>
            /// <para>240*240像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonProperty("avatar_240")]
            public string? Avatar240 { get; set; }

            /// <summary>
            /// <para>640*640像素头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonProperty("avatar_640")]
            public string? Avatar640 { get; set; }

            /// <summary>
            /// <para>原始头像链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://foo.icon.com/xxxx</para>
            /// </summary>
            [JsonProperty("avatar_origin")]
            public string? AvatarOrigin { get; set; }
        }

        /// <summary>
        /// <para>用户状态，枚举类型，包括is_frozen、is_resigned、is_activated、is_exited 。</para>
        /// <para>用户状态转移参见：[用户状态图](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview#4302b5a1)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("status")]
        public UserStatus? Status { get; set; }

        /// <summary>
        /// <para>用户状态，枚举类型，包括is_frozen、is_resigned、is_activated、is_exited 。</para>
        /// <para>用户状态转移参见：[用户状态图](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview#4302b5a1)</para>
        /// </summary>
        public record UserStatus
        {
            /// <summary>
            /// <para>是否暂停</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_frozen")]
            public bool? IsFrozen { get; set; }

            /// <summary>
            /// <para>是否离职</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_resigned")]
            public bool? IsResigned { get; set; }

            /// <summary>
            /// <para>是否激活</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_activated")]
            public bool? IsActivated { get; set; }

            /// <summary>
            /// <para>是否主动退出，主动退出一段时间后用户会自动转为已离职</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_exited")]
            public bool? IsExited { get; set; }

            /// <summary>
            /// <para>是否未加入，需要用户自主确认才能加入团队</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("is_unjoin")]
            public bool? IsUnjoin { get; set; }
        }

        /// <summary>
        /// <para>用户所属部门的ID列表，一个用户可属于多个部门。</para>
        /// <para>ID值的类型与查询参数中的department_id_type 对应。</para>
        /// <para>不同 ID 的说明与department_id的获取方式参见 [部门ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#23857fe0)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户的直接主管的用户ID，ID值与查询参数中的user_id_type 对应。</para>
        /// <para>不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
        /// <para>获取方式参见[如何获取user_id](https://open.feishu.cn/document/home/user-identity-introduction/how-to-get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonProperty("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>工作城市</para>
        /// <para>必填：否</para>
        /// <para>示例值：杭州</para>
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// <para>国家或地区Code缩写，具体写入格式请参考 [国家/地区码表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/country-code-description)</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN</para>
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// <para>工位</para>
        /// <para>必填：否</para>
        /// <para>示例值：北楼-H34</para>
        /// </summary>
        [JsonProperty("work_station")]
        public string? WorkStation { get; set; }

        /// <summary>
        /// <para>入职时间，时间戳格式，表示从1970年1月1日开始所经过的秒数</para>
        /// <para>必填：否</para>
        /// <para>示例值：2147483647</para>
        /// </summary>
        [JsonProperty("join_time")]
        public int? JoinTime { get; set; }

        /// <summary>
        /// <para>是否是租户超级管理员</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("is_tenant_manager")]
        public bool? IsTenantManager { get; set; }

        /// <summary>
        /// <para>工号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("employee_no")]
        public string? EmployeeNo { get; set; }

        /// <summary>
        /// <para>员工类型，可选值有：</para>
        /// <para>- `1`：正式员工</para>
        /// <para>- `2`：实习生</para>
        /// <para>- `3`：外包</para>
        /// <para>- `4`：劳务</para>
        /// <para>- `5`：顾问</para>
        /// <para>同时可读取到自定义员工类型的 int 值，可通过下方接口获取到该租户的自定义员工类型的名称，参见[获取人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("employee_type")]
        public int? EmployeeType { get; set; }

        /// <summary>
        /// <para>用户排序信息。</para>
        /// <para>用于标记通讯录下组织架构的人员顺序，人员可能存在多个部门中，且有不同的排序。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("orders")]
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
            [JsonProperty("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>用户在其直属部门内的排序，数值越大，排序越靠前</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonProperty("user_order")]
            public int? UserOrderSuffix { get; set; }

            /// <summary>
            /// <para>用户所属的多个部门间的排序，数值越大，排序越靠前</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonProperty("department_order")]
            public int? DepartmentOrder { get; set; }

            /// <summary>
            /// <para>标识用户的唯一主部门，主部门为用户所属部门中排序第一的部门(department_order最大)</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("is_primary_dept")]
            public bool? IsPrimaryDept { get; set; }
        }

        /// <summary>
        /// <para>自定义字段，请确保你的组织管理员已在管理后台/组织架构/成员字段管理/自定义字段管理/全局设置中开启了“允许开放平台 API 调用“，否则该字段不会生效/返回。</para>
        /// <para>更多详情参见[用户接口相关问题](https://open.feishu.cn/document/ugTN1YjL4UTN24CO1UjN/uQzN1YjL0cTN24CN3UjN#77061525)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_attrs")]
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
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>自定义字段ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：DemoId</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>自定义字段取值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("value")]
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
                [JsonProperty("text")]
                public string? Text { get; set; }

                /// <summary>
                /// <para>字段类型为 HREF 时，该参数定义默认 URL，例如手机端跳转小程序，PC端跳转网页</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://www.fs.cn</para>
                /// </summary>
                [JsonProperty("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>字段类型为 HREF 时，该参数定义PC端 URL</para>
                /// <para>必填：否</para>
                /// <para>示例值：http://www.fs.cn</para>
                /// </summary>
                [JsonProperty("pc_url")]
                public string? PcUrl { get; set; }

                /// <summary>
                /// <para>选项类型的值。</para>
                /// <para>表示 成员详情/自定义字段 中选项选中的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：option</para>
                /// </summary>
                [JsonProperty("option_value")]
                public string? OptionValue { get; set; }

                /// <summary>
                /// <para>选项类型为图片时，表示图片的名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonProperty("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>图片链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://xxxxxxxxxxxxxxxxxx</para>
                /// </summary>
                [JsonProperty("picture_url")]
                public string? PictureUrl { get; set; }

                /// <summary>
                /// <para>字段类型为 GENERIC_USER 时，该参数定义引用人员</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("generic_user")]
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
                    [JsonProperty("id")]
                    public string Id { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>用户类型:</para>
                    /// <para>1：用户</para>
                    /// <para>目前固定为1，表示用户类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonProperty("type")]
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
        [JsonProperty("enterprise_email")]
        public string? EnterpriseEmail { get; set; }

        /// <summary>
        /// <para>职务</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxx</para>
        /// </summary>
        [JsonProperty("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>数据驻留地</para>
        /// <para>必填：否</para>
        /// <para>示例值：cn</para>
        /// </summary>
        [JsonProperty("geo")]
        public string? Geo { get; set; }

        /// <summary>
        /// <para>职级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlp9rb</para>
        /// </summary>
        [JsonProperty("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>序列ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：mga5oa8ayjlp9rb</para>
        /// </summary>
        [JsonProperty("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>用户席位列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("assign_info")]
        public UserAssignInfo[]? AssignInfos { get; set; }

        /// <summary>
        /// <para>用户席位列表</para>
        /// </summary>
        public record UserAssignInfo
        {
            /// <summary>
            /// <para>席位id</para>
            /// <para>必填：否</para>
            /// <para>示例值：7079609167680782300</para>
            /// </summary>
            [JsonProperty("subscription_id")]
            public string? SubscriptionId { get; set; }

            /// <summary>
            /// <para>license_plan_key</para>
            /// <para>必填：否</para>
            /// <para>示例值：suite_enterprise_e5</para>
            /// </summary>
            [JsonProperty("license_plan_key")]
            public string? LicensePlanKey { get; set; }

            /// <summary>
            /// <para>席位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：旗舰版E5</para>
            /// </summary>
            [JsonProperty("product_name")]
            public string? ProductName { get; set; }

            /// <summary>
            /// <para>国际化名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("i18n_name")]
            public ProductI18nName? I18nName { get; set; }

            /// <summary>
            /// <para>国际化名称</para>
            /// </summary>
            public record ProductI18nName
            {
                /// <summary>
                /// <para>席位中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：zh_cn_name</para>
                /// </summary>
                [JsonProperty("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>席位日文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：ja_jp_name</para>
                /// </summary>
                [JsonProperty("ja_jp")]
                public string? JaJp { get; set; }

                /// <summary>
                /// <para>席位英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：en_name</para>
                /// </summary>
                [JsonProperty("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>席位起始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1674981000</para>
            /// </summary>
            [JsonProperty("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>席位结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1674991000</para>
            /// </summary>
            [JsonProperty("end_time")]
            public string? EndTime { get; set; }
        }

        /// <summary>
        /// <para>部门路径。此字段需要使用`user_access_token`获取。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("department_path")]
        public DepartmentDetail[]? DepartmentPaths { get; set; }

        /// <summary>
        /// <para>部门路径。此字段需要使用`user_access_token`获取。</para>
        /// </summary>
        public record DepartmentDetail
        {
            /// <summary>
            /// <para>部门ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
            /// </summary>
            [JsonProperty("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>部门名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("department_name")]
            public DepartmentPathName? DepartmentName { get; set; }

            /// <summary>
            /// <para>部门名</para>
            /// </summary>
            public record DepartmentPathName
            {
                /// <summary>
                /// <para>部门名</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试部门名1</para>
                /// </summary>
                [JsonProperty("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>部门国际化名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("i18n_name")]
                public DepartmentI18nName? I18nName { get; set; }

                /// <summary>
                /// <para>部门国际化名</para>
                /// </summary>
                public record DepartmentI18nName
                {
                    /// <summary>
                    /// <para>部门的中文名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：测试部门名1</para>
                    /// </summary>
                    [JsonProperty("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>部门的日文名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：試験部署名1</para>
                    /// </summary>
                    [JsonProperty("ja_jp")]
                    public string? JaJp { get; set; }

                    /// <summary>
                    /// <para>部门的英文名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Testingdepartmentname1</para>
                    /// </summary>
                    [JsonProperty("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>部门路径</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("department_path")]
            public DepartmentDetailDepartmentPath? DepartmentPath { get; set; }

            /// <summary>
            /// <para>部门路径</para>
            /// </summary>
            public record DepartmentDetailDepartmentPath
            {
                /// <summary>
                /// <para>部门路径IDs</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("department_ids")]
                public string[]? DepartmentIds { get; set; }

                /// <summary>
                /// <para>部门路径名字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("department_path_name")]
                public DepartmentDetailDepartmentPathDepartmentPathName? DepartmentPathName { get; set; }

                /// <summary>
                /// <para>部门路径名字</para>
                /// </summary>
                public record DepartmentDetailDepartmentPathDepartmentPathName
                {
                    /// <summary>
                    /// <para>部门名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：测试部门名1</para>
                    /// </summary>
                    [JsonProperty("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>部门国际化名</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("i18n_name")]
                    public DepartmentI18nName? I18nName { get; set; }

                    /// <summary>
                    /// <para>部门国际化名</para>
                    /// </summary>
                    public record DepartmentI18nName
                    {
                        /// <summary>
                        /// <para>部门的中文名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试部门名1</para>
                        /// </summary>
                        [JsonProperty("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>部门的日文名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：試験部署名1</para>
                        /// </summary>
                        [JsonProperty("ja_jp")]
                        public string? JaJp { get; set; }

                        /// <summary>
                        /// <para>部门的英文名</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Testingdepartmentname1</para>
                        /// </summary>
                        [JsonProperty("en_us")]
                        public string? EnUs { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>虚线上级ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("dotted_line_leader_user_ids")]
        public string[]? DottedLineLeaderUserIds { get; set; }
    }
}
