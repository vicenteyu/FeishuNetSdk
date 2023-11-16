namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询待入职人员 响应体
/// <para>批量查询待入职人员。</para>
/// <para>接口ID：7017707615190958083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fpre_hire%2flist</para>
/// </summary>
public record GetCorehrV1PreHiresResponseDto
{
    /// <summary>
    /// <para>查询的待入职信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public PreHireQuery[]? Items { get; set; }

    /// <summary>
    /// <para>查询的待入职信息</para>
    /// </summary>
    public record PreHireQuery
    {
        /// <summary>
        /// <para>招聘投递 ID ，详细信息可以通过招聘的【获取投递信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719168654814483759</para>
        /// </summary>
        [JsonPropertyName("ats_application_id")]
        public string? AtsApplicationId { get; set; }

        /// <summary>
        /// <para>实体在CoreHR内部的唯一键</para>
        /// <para>必填：否</para>
        /// <para>示例值：154545454</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>入职日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("hire_date")]
        public string? HireDate { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public Enum EmployeeType { get; set; } = new();

        /// <summary>
        /// <para>雇佣类型</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：type_1</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>名称信息的语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称信息的内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>人员编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1245646</para>
        /// </summary>
        [JsonPropertyName("worker_id")]
        public string? WorkerId { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：正式</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string EmployeeTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>引用Person ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：656464648662</para>
        /// </summary>
        [JsonPropertyName("person_id")]
        public string PersonId { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>入职状态</para>
        /// <para>- `preboarding`：待入职</para>
        /// <para>- `day_one`：准备就绪</para>
        /// <para>- `completed`：已完成</para>
        /// <para>- `withdrawn`：已撤销</para>
        /// <para>- `deleted`：已删除，对应的系统操作是将待入职人员回退至 Offer 沟通阶段</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("onboarding_status")]
        public Enum OnboardingStatus { get; set; } = new();

        /// <summary>
        /// <para>成本中心分摊信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center_rate")]
        public SupportCostCenterItem[]? CostCenterRates { get; set; }

        /// <summary>
        /// <para>成本中心分摊信息</para>
        /// </summary>
        public record SupportCostCenterItem
        {
            /// <summary>
            /// <para>支持的成本中心id</para>
            /// <para>必填：否</para>
            /// <para>示例值：6950635856373745165</para>
            /// </summary>
            [JsonPropertyName("cost_center_id")]
            public string? CostCenterId { get; set; }

            /// <summary>
            /// <para>分摊比例</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("rate")]
            public int? Rate { get; set; }
        }

        /// <summary>
        /// <para>工作邮箱</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_email_list")]
        public Email[]? WorkEmailLists { get; set; }

        /// <summary>
        /// <para>工作邮箱</para>
        /// </summary>
        public record Email
        {
            /// <summary>
            /// <para>邮箱号</para>
            /// <para>必填：是</para>
            /// <para>示例值：12456@test.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string EmailSuffix { get; set; } = string.Empty;

            /// <summary>
            /// <para>是否为主要邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_primary")]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// <para>是否为公开邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_public")]
            public bool? IsPublic { get; set; }

            /// <summary>
            /// <para>邮箱用途，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)邮箱用途（email_usage）枚举定义获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email_usage")]
            public Enum? EmailUsage { get; set; }

            /// <summary>
            /// <para>邮箱用途，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)邮箱用途（email_usage）枚举定义获得</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：type_1</para>
                /// </summary>
                [JsonPropertyName("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>枚举多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>名称信息的语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>名称信息的内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"Sandy\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>部门ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：656464648662</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }
    }

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
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
