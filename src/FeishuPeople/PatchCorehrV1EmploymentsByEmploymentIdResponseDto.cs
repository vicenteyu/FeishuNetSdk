namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新雇佣信息 响应体
/// <para>更新雇佣信息。</para>
/// <para>接口ID：7072588598729981980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fpatch</para>
/// </summary>
public record PatchCorehrV1EmploymentsByEmploymentIdResponseDto
{
    /// <summary>
    /// <para>雇佣信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment")]
    public PatchCorehrV1EmploymentsByEmploymentIdResponseDtoEmployment? Employment { get; set; }

    /// <summary>
    /// <para>雇佣信息</para>
    /// </summary>
    public record PatchCorehrV1EmploymentsByEmploymentIdResponseDtoEmployment
    {
        /// <summary>
        /// <para>待入职ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("prehire_id")]
        public string? PrehireId { get; set; }

        /// <summary>
        /// <para>人员类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string? EmployeeTypeId { get; set; }

        /// <summary>
        /// <para>司龄</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("tenure")]
        public string? Tenure { get; set; }

        /// <summary>
        /// <para>部门 ID，详细信息可通过【查询单个部门】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>职级 ID，详细信息可通过【查询单个职务级别】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>工作地点 ID，详细信息可通过【查询单个地点】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("work_location_id")]
        public string? WorkLocationId { get; set; }

        /// <summary>
        /// <para>序列 ID，详细信息可通过【查询单个职务序列】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>职务 ID，详细信息可通过【查询单个职务】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>法人主体 ID，详细信息可通过【查询单个公司】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// <para>工时制度 ID，详细信息可通过【查询单个工时制度】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>雇员ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>资历起算日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("seniority_date")]
        public string? SeniorityDate { get; set; }

        /// <summary>
        /// <para>员工编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000000</para>
        /// </summary>
        [JsonPropertyName("employee_number")]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// <para>入职日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-0100:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>离职日期，即员工的最后一个工作日，最后一个工作日时员工的雇佣状态仍为“在职”，次日凌晨将更改为“离职”</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-01-0100:00:00</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>雇佣类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)雇佣类型（employment_type）枚举定义获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("employment_type")]
        public Enum EmploymentType { get; set; } = new();

        /// <summary>
        /// <para>雇佣类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)雇佣类型（employment_type）枚举定义获得</para>
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
        /// <para>个人信息 ID，详细信息可通过【查询单个个人信息】接口获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：6919733936050406926</para>
        /// </summary>
        [JsonPropertyName("person_id")]
        public string PersonId { get; set; } = string.Empty;

        /// <summary>
        /// <para>试用期时长（月份）</para>
        /// <para>必填：否</para>
        /// <para>示例值：9999</para>
        /// </summary>
        [JsonPropertyName("probation_period")]
        public int? ProbationPeriod { get; set; }

        /// <summary>
        /// <para>是否在试用期中</para>
        /// <para>- 满足以下任一条件时，该字段值为`"true"`：</para>
        /// <para>- 预计试用结束日期非空，且实际结束日期为空</para>
        /// <para>- 预计试用结束日期非空，实际结束日期非空，且当日日期小于等于实际结束日期</para>
        /// <para>- 其余情况下，该字段值为`"false"`；</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("on_probation")]
        public string? OnProbation { get; set; }

        /// <summary>
        /// <para>试用期结束日期（实际结束日期）</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-01-01</para>
        /// </summary>
        [JsonPropertyName("probation_end_date")]
        public string? ProbationEndDate { get; set; }

        /// <summary>
        /// <para>是否是主雇佣信息</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("primary_employment")]
        public bool PrimaryEmployment { get; set; }

        /// <summary>
        /// <para>雇员状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)雇员状态（employment_status）枚举定义获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employment_status")]
        public Enum? EmploymentStatus { get; set; }

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
        /// <para>工作邮箱列表，只有当邮箱下面所有条件时，才在个人信息页面可见：</para>
        /// <para>- is_primary = "true"</para>
        /// <para>- is_public = "true"</para>
        /// <para>- email_usage = "work"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_email_list")]
        public Email[]? WorkEmailLists { get; set; }

        /// <summary>
        /// <para>工作邮箱列表，只有当邮箱下面所有条件时，才在个人信息页面可见：</para>
        /// <para>- is_primary = "true"</para>
        /// <para>- is_public = "true"</para>
        /// <para>- email_usage = "work"</para>
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
        /// <para>邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：test@163.com</para>
        /// </summary>
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// <para>离职原因，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)离职原因（reason_for_offboarding）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reason_for_offboarding")]
        public Enum? ReasonForOffboarding { get; set; }

        /// <summary>
        /// <para>成本中心id列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center_list")]
        public JobDataCostCenter[]? CostCenterLists { get; set; }

        /// <summary>
        /// <para>成本中心id列表</para>
        /// </summary>
        public record JobDataCostCenter
        {
            /// <summary>
            /// <para>成本中心id，可以通过【查询单个成本中心信息】接口获取对应的成本中心信息</para>
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
        /// <para>招聘投递 ID ，详细信息可以通过[【获取投递信息】](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6838119494196871234</para>
        /// </summary>
        [JsonPropertyName("ats_application_id")]
        public string? AtsApplicationId { get; set; }
    }
}
