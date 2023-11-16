namespace FeishuNetSdk.Helpdesk.Spec;
/// <summary>
/// 获取全部工单自定义字段 响应体
/// <para>该接口用于获取全部工单自定义字段。</para>
/// <para>接口ID：6955768699895955458</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket_customized_field/list-ticket-customized-fields</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_customized_field%2flist-ticket-customized-fields</para>
/// </summary>
public record GetHelpdeskV1TicketCustomizedFieldsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>下一分页标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    /// <summary>
    /// <para>工单自定义字段列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TicketCustomizedField[]? Items { get; set; }

    /// <summary></summary>
    public record TicketCustomizedField
    {
        /// <summary>
        /// <para>工单自定义字段ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ticket_customized_field_id")]
        public string? TicketCustomizedFieldId { get; set; }

        /// <summary>
        /// <para>服务台ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("helpdesk_id")]
        public string? HelpdeskId { get; set; }

        /// <summary>
        /// <para>键名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// <para>字段在列表后台管理列表中的位置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("position")]
        public string? Position { get; set; }

        /// <summary>
        /// <para>类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("field_type")]
        public string? FieldType { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>是否可见</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// <para>是否可以修改</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("editable")]
        public bool? Editable { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// <para>创建用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public TicketUser? CreatedBy { get; set; }

        /// <summary>
        /// <para>更新用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public TicketUser? UpdatedBy { get; set; }

        /// <summary></summary>
        public record TicketUser
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户头像url</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>用户名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>用户邮箱</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }
        }

        /// <summary>
        /// <para>下拉列表选项</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dropdown_options")]
        public DropdownOptionSuffix? DropdownOptions { get; set; }

        /// <summary></summary>
        public record DropdownOptionSuffix
        {
            /// <summary>
            /// <para>选项列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("children")]
            public DropdownOption[]? Children { get; set; }

            /// <summary></summary>
            public record DropdownOption
            {
                /// <summary>
                /// <para>选项ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("tag")]
                public string? Tag { get; set; }

                /// <summary>
                /// <para>展示名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display_name")]
                public string? DisplayName { get; set; }

                /// <summary>
                /// <para>同上：选项列表，只适用于多层下拉列表（最多可以设置三级下拉列表）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("children")]
                public DropdownOption[]? Children { get; set; }
            }
        }

        /// <summary>
        /// <para>是否支持多选，仅在字段类型是dropdown的时候有效</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dropdown_allow_multiple")]
        public bool? DropdownAllowMultiple { get; set; }
    }
}
