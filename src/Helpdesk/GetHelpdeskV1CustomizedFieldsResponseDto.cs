using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 获取服务台自定义字段 响应体
/// <para>该接口用于获取服务台自定义字段详情。</para>
/// <para>接口ID：6955768425688383491</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/customized_fields</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fcustomized_fields</para>
/// </summary>
public record GetHelpdeskV1CustomizedFieldsResponseDto
{
    /// <summary>
    /// <para>用户自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_customized_fields")]
    public UserCustomizedField[]? UserCustomizedFields { get; set; }

    /// <summary>
    /// <para>用户自定义字段</para>
    /// </summary>
    public record UserCustomizedField
    {
        /// <summary>
        /// <para>字段ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6746384425543548981</para>
        /// </summary>
        [JsonProperty("user_customized_field_id")]
        public string? UserCustomizedFieldId { get; set; }

        /// <summary>
        /// <para>旧字段ID，向后兼容用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6746384425543548981</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>服务台ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1542164574896126</para>
        /// </summary>
        [JsonProperty("helpdesk_id")]
        public string? HelpdeskId { get; set; }

        /// <summary>
        /// <para>字段键</para>
        /// <para>必填：否</para>
        /// <para>示例值：company_id3</para>
        /// </summary>
        [JsonProperty("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        /// <para>字段展示名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：CompanyID</para>
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// <para>字段在列表中的展示位置</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("position")]
        public string? Position { get; set; }

        /// <summary>
        /// <para>字段类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：string</para>
        /// </summary>
        [JsonProperty("field_type")]
        public string? FieldType { get; set; }

        /// <summary>
        /// <para>字段描述信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：租户ID</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>字段是否可见</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// <para>字段是否可编辑</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        /// <summary>
        /// <para>字段是否必填</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>字段创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1574040677000</para>
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>字段修改时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1574040677000</para>
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }
    }

    /// <summary>
    /// <para>自定义工单字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("ticket_customized_fields")]
    public TicketCustomizedField[]? TicketCustomizedFields { get; set; }

    /// <summary>
    /// <para>自定义工单字段</para>
    /// </summary>
    public record TicketCustomizedField
    {
        /// <summary>
        /// <para>工单自定义字段ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6834320707288072194</para>
        /// </summary>
        [JsonProperty("ticket_customized_field_id")]
        public string TicketCustomizedFieldId { get; set; } = string.Empty;

        /// <summary>
        /// <para>服务台ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：1542164574896126</para>
        /// </summary>
        [JsonProperty("helpdesk_id")]
        public string HelpdeskId { get; set; } = string.Empty;

        /// <summary>
        /// <para>键名</para>
        /// <para>必填：是</para>
        /// <para>示例值：testdropdown</para>
        /// </summary>
        [JsonProperty("key_name")]
        public string KeyName { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：testdropdown</para>
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段在列表后台管理列表中的位置</para>
        /// <para>必填：是</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; } = string.Empty;

        /// <summary>
        /// <para>类型</para>
        /// <para>string - 单行文本</para>
        /// <para>multiline - 多行文本</para>
        /// <para>dropdown - 下拉列表</para>
        /// <para>dropdown_nested - 级联下拉</para>
        /// <para>必填：是</para>
        /// <para>示例值：dropdown</para>
        /// </summary>
        [JsonProperty("field_type")]
        public string FieldType { get; set; } = string.Empty;

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：下拉示例</para>
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否可见</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// <para>是否可以修改</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("required")]
        public bool Required { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1591239289000</para>
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1591239289000</para>
        /// </summary>
        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// <para>创建用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("created_by")]
        public TicketUser? CreatedBy { get; set; }

        /// <summary>
        /// <para>创建用户</para>
        /// </summary>
        public record TicketUser
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_37019b7c830210acd88fdce886e25c71</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户头像url</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://xxxx</para>
            /// </summary>
            [JsonProperty("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>用户名</para>
            /// <para>必填：否</para>
            /// <para>示例值：abc</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>用户邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx@abc.com</para>
            /// </summary>
            [JsonProperty("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>所在部门名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：用户部门名称(有权限才展示)</para>
            /// </summary>
            [JsonProperty("department")]
            public string? Department { get; set; }

            /// <summary>
            /// <para>城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：城市</para>
            /// </summary>
            [JsonProperty("city")]
            public string? City { get; set; }

            /// <summary>
            /// <para>国家代号(CountryCode)，参考：http://www.mamicode.com/info-detail-2186501.html</para>
            /// <para>必填：否</para>
            /// <para>示例值：国家</para>
            /// </summary>
            [JsonProperty("country")]
            public string? Country { get; set; }
        }

        /// <summary>
        /// <para>更新用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("updated_by")]
        public TicketUser? UpdatedBy { get; set; }

        /// <summary>
        /// <para>是否支持多选，仅在字段类型是dropdown的时候有效</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("dropdown_allow_multiple")]
        public bool? DropdownAllowMultiple { get; set; }
    }
}
