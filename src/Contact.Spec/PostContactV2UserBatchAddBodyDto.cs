namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 批量新增用户 请求体
/// <para>该接口用于向通讯录中批量新增多个用户。</para>
/// <para>调用该接口需要具有待添加用户所在部门的通讯录授权范围。</para>
/// <para>应用商店应用无权限调用此接口。</para>
/// <para>调用该接口需要申请 `更新通讯录` 以及 `以应用身份访问通讯录` 权限。</para>
/// <para>接口ID：6907569743420997634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDOwUjLygDM14iM4ATN</para>
/// </summary>
public record PostContactV2UserBatchAddBodyDto
{
    /// <summary>
    /// <para>所有待新增用户的集合。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("users")]
    public User[] Users { get; set; } = Array.Empty<User>();

    /// <summary></summary>
    public record User
    {
        /// <summary>
        /// <para>用户名。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>待新增用户所属部门，目前仅支持单个用户所属单个部门。</para>
        /// <para>需要应用的通讯录权限范围包含该部门。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("departments")]
        public string[] Departments { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>用户企业内唯一标识。只能在创建用户时指定，不支持更新。</para>
        /// <para>不指定时由平台自动生成。</para>
        /// <para>自定义唯一标识不区分大小写，长度为 1 ~ 64 个字符。只能由数字、字母和“_”、“-”、“@”、“.”四种特殊字符组成，且第一个字符必须是数字或字母。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户邮箱。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>用户手机号。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; } = string.Empty;

        /// <summary>
        /// <para>手机号码可见性，true 为可见，false 为不可见，目前默认为 true。</para>
        /// <para>不可见时，企业内其他员工将无法在客户端内查看该员工的手机号码。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mobile_visible")]
        public bool? MobileVisible { get; set; }

        /// <summary>
        /// <para>用户所在城市。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// <para>用户所在国家。</para>
        /// <para>字段值请参考国际标准化组织 [ISO 3166-1 标准](https://www.iso.org/obp/ui/#iso:pub:PUB500001:en) 中的二位代码。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// <para>性别，1：男，2：女。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// <para>员工类型，1：正式员工，2：实习生，3：外包，4：劳务，5：顾问。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public int? EmployeeType { get; set; }

        /// <summary>
        /// <para>入职时间，以秒为单位的 Unix 时间戳。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("join_time")]
        public int? JoinTime { get; set; }

        /// <summary>
        /// <para>直属上级用户 ID，支持通过 user_id 或 open_id 进行设置。请求同时传递两个字段时只使用 leader_user_id，忽略 leader_open_id。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>直属上级用户 ID，支持通过 user_id 或 open_id 进行设置。请求同时传递两个字段时只使用 leader_user_id，忽略 leader_open_id。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("leader_open_id")]
        public string? LeaderOpenId { get; set; }

        /// <summary>
        /// <para>员工工号。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee_no")]
        public string? EmployeeNo { get; set; }

        /// <summary>
        /// <para>自定义用户属性。</para>
        /// <para>该字段仅当企业管理员在企业管理后台开启了“允许开放平台 API 调用”时有效。</para>
        /// <para>传入的每个自定义用户属性需要包含平台生成的属性 ID 和要设置的属性对应类型的值。</para>
        /// <para>当企业管理后台未开启“允许开放平台 API 调用”时，或者传入的属性 ID 不存在 / 非法时，会忽略该条属性的设置信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_attrs")]
        public CustomAttr[]? CustomAttrs { get; set; }

        /// <summary></summary>
        public record CustomAttr
        {
            /// <summary>
            /// <para>自定义属性 ID。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义属性值。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("value")]
            public ValueSuffix Value { get; set; } = new();

            /// <summary></summary>
            public record ValueSuffix
            {
                /// <summary>
                /// <para>当自定义属性类型为 text 时，传入此字段，表示属性的文字值。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// <para>当自定义属性类型为 href 时，传入此字段，表示属性的 URL 值。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>当自定义属性类型为 href 时，传入此字段，表示属性的 PC 端 URL 值。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_url")]
                public string? PcUrl { get; set; }
            }
        }

        /// <summary>
        /// <para>员工工位。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_station")]
        public string? WorkStation { get; set; }
    }

    /// <summary>
    /// <para>是否对本次新增的所有用户发送邀请通知，默认为 false，不发送通知。</para>
    /// <para>该字段为 true 时， 用户添加成功后会向对应的邮箱或手机发送邀请通知。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("need_send_notification")]
    public bool? NeedSendNotification { get; set; }
}
