namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工信息 响应体
/// <para>该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中有申请「员工资源」权限范围</para>
/// <para>接口ID：7211423970042167300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fsearch</para>
/// </summary>
public record PostCorehrV2EmployeesSearchResponseDto
{
    /// <summary>
    /// <para>查询的雇佣信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Employee[]? Items { get; set; }

    /// <summary>
    /// <para>查询的雇佣信息</para>
    /// </summary>
    public record Employee
    {
        /// <summary>
        /// <para>雇佣 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>招聘投递 ID ，详细信息可以通过【获取投递信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6838119494196871234</para>
        /// </summary>
        [JsonPropertyName("ats_application_id")]
        public string? AtsApplicationId { get; set; }

        /// <summary>
        /// <para>待入职 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7023239238976141133</para>
        /// </summary>
        [JsonPropertyName("prehire_id")]
        public string? PrehireId { get; set; }

        /// <summary>
        /// <para>工号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000000</para>
        /// </summary>
        [JsonPropertyName("employee_number")]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        /// <para>人员类型 ID，详细信息可通过【查询单个人员类型】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6971090097697521314</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string? EmployeeTypeId { get; set; }

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
        /// <para>职等 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("job_grade_id")]
        public string? JobGradeId { get; set; }

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
        /// <para>所属公司 ID，详细信息可通过【查询单个公司】接口获得</para>
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
        /// <para>司龄</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.01</para>
        /// </summary>
        [JsonPropertyName("tenure")]
        public string? Tenure { get; set; }

        /// <summary>
        /// <para>资历起算日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-03-16</para>
        /// </summary>
        [JsonPropertyName("seniority_date")]
        public string? SeniorityDate { get; set; }

        /// <summary>
        /// <para>当前雇佣记录的入职日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2021-03-16</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否是主雇佣信息</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("primary_employment")]
        public bool PrimaryEmployment { get; set; }

        /// <summary>
        /// <para>试用期时长（月）</para>
        /// <para>必填：否</para>
        /// <para>示例值：16</para>
        /// </summary>
        [JsonPropertyName("probation_period")]
        public int? ProbationPeriod { get; set; }

        /// <summary>
        /// <para>是否在试用期中</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("on_probation")]
        public bool? OnProbation { get; set; }

        /// <summary>
        /// <para>试用期结束日期（实际结束日期）</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-08-01</para>
        /// </summary>
        [JsonPropertyName("probation_end_date")]
        public string? ProbationEndDate { get; set; }

        /// <summary>
        /// <para>直接上级的雇佣 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7027024823985411287</para>
        /// </summary>
        [JsonPropertyName("direct_manager_id")]
        public string? DirectManagerId { get; set; }

        /// <summary>
        /// <para>虚线上级的雇佣 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7027024823985411782</para>
        /// </summary>
        [JsonPropertyName("dotted_line_manager_id")]
        public string? DottedLineManagerId { get; set; }

        /// <summary>
        /// <para>雇佣类型，枚举值可通过文档【飞书人事枚举常量】雇佣类型（employment_type）枚举定义获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("employment_type")]
        public Enum EmploymentType { get; set; } = new();

        /// <summary>
        /// <para>雇佣类型，枚举值可通过文档【飞书人事枚举常量】雇佣类型（employment_type）枚举定义获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
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
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>雇佣状态，枚举值可通过文档【飞书人事枚举常量】雇员状态（employment_status）枚举定义获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employment_status")]
        public Enum? EmploymentStatus { get; set; }

        /// <summary>
        /// <para>离职日期，即员工的最后一个工作日，最后一个工作日时员工的雇佣状态仍为“在职”，次日凌晨将更改为“离职”</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-08-16</para>
        /// </summary>
        [JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// <para>离职原因，枚举值可通过文档【飞书人事枚举常量】离职原因（reason_for_offboarding）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reason_for_offboarding")]
        public Enum? ReasonForOffboarding { get; set; }

        /// <summary>
        /// <para>邮箱地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：test@163.com</para>
        /// </summary>
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// <para>工作邮箱列表，只有当邮箱满足下面所有条件时，才在个人信息页面可见</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_email_list")]
        public WorkEmail[]? WorkEmailLists { get; set; }

        /// <summary>
        /// <para>工作邮箱列表，只有当邮箱满足下面所有条件时，才在个人信息页面可见</para>
        /// </summary>
        public record WorkEmail
        {
            /// <summary>
            /// <para>邮箱地址</para>
            /// <para>必填：是</para>
            /// <para>示例值：1234567@example.feishu.cn</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string Email { get; set; } = string.Empty;

            /// <summary>
            /// <para>邮箱用途，枚举值可通过文档【飞书人事枚举常量】邮箱用途（email_usage）枚举定义获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email_usage")]
            public Enum? EmailUsage { get; set; }

            /// <summary>
            /// <para>邮箱用途，枚举值可通过文档【飞书人事枚举常量】邮箱用途（email_usage）枚举定义获得</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
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
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }
        }

        /// <summary>
        /// <para>成本中心列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center_list")]
        public JobDataCostCenter[]? CostCenterLists { get; set; }

        /// <summary>
        /// <para>成本中心列表</para>
        /// </summary>
        public record JobDataCostCenter
        {
            /// <summary>
            /// <para>成本中心 ID，可以通过【查询单个成本中心信息】接口获取对应的成本中心信息</para>
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
        /// <para>是否离职重聘</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("rehire")]
        public Enum? Rehire { get; set; }

        /// <summary>
        /// <para>历史雇佣信息 ID，可以通过【查询单个雇佣信息】查询详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("rehire_employment_id")]
        public string? RehireEmploymentId { get; set; }

        /// <summary>
        /// <para>基本个人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("person_info")]
        public EmployeePersonInfo? PersonInfo { get; set; }

        /// <summary>
        /// <para>基本个人信息</para>
        /// </summary>
        public record EmployeePersonInfo
        {
            /// <summary>
            /// <para>个人信息 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6919733936050406926</para>
            /// </summary>
            [JsonPropertyName("person_id")]
            public string? PersonId { get; set; }

            /// <summary>
            /// <para>个人电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：13649211111</para>
            /// </summary>
            [JsonPropertyName("phone_number")]
            public string? PhoneNumber { get; set; }

            /// <summary>
            /// <para>法定姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("legal_name")]
            public string? LegalName { get; set; }

            /// <summary>
            /// <para>常用名</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新(Henry)</para>
            /// </summary>
            [JsonPropertyName("preferred_name")]
            public string? PreferredName { get; set; }

            /// <summary>
            /// <para>常用本地全名</para>
            /// <para>必填：否</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonPropertyName("preferred_local_full_name")]
            public string? PreferredLocalFullName { get; set; }

            /// <summary>
            /// <para>常用英文全名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Henry</para>
            /// </summary>
            [JsonPropertyName("preferred_english_full_name")]
            public string? PreferredEnglishFullName { get; set; }

            /// <summary>
            /// <para>姓名列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name_list")]
            public PersonName[]? NameLists { get; set; }

            /// <summary>
            /// <para>姓名列表</para>
            /// </summary>
            public record PersonName
            {
                /// <summary>
                /// <para>姓 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：黄</para>
                /// </summary>
                [JsonPropertyName("local_primary")]
                public string? LocalPrimary { get; set; }

                /// <summary>
                /// <para>名 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：四</para>
                /// </summary>
                [JsonPropertyName("local_first_name")]
                public string? LocalFirstName { get; set; }

                /// <summary>
                /// <para>国家 / 地区</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>姓名类型</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("name_type")]
                public Enum NameType { get; set; } = new();

                /// <summary>
                /// <para>姓名类型</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>名 - 第二本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：五</para>
                /// </summary>
                [JsonPropertyName("local_first_name_2")]
                public string? LocalFirstName2 { get; set; }

                /// <summary>
                /// <para>姓 - 第二本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("local_primary_2")]
                public string? LocalPrimary2 { get; set; }

                /// <summary>
                /// <para>补充姓名类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("additional_name_type")]
                public Enum? AdditionalNameType { get; set; }

                /// <summary>
                /// <para>名</para>
                /// <para>必填：否</para>
                /// <para>示例值：帅</para>
                /// </summary>
                [JsonPropertyName("first_name")]
                public string? FirstName { get; set; }

                /// <summary>
                /// <para>全名</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("full_name")]
                public string? FullName { get; set; }

                /// <summary>
                /// <para>姓氏称谓</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("hereditary")]
                public string? Hereditary { get; set; }

                /// <summary>
                /// <para>自定义姓名（未传入时，姓名将默认根据所属国家 / 地区规则对相关姓、名字段拼接）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("custom_name")]
                public string? CustomName { get; set; }

                /// <summary>
                /// <para>本地文字的自定义姓名（未传入时，本地文字的姓名将默认根据所属国家 / 地区规则对本地文字的相关姓、名字段拼接）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("custom_local_name")]
                public string? CustomLocalName { get; set; }

                /// <summary>
                /// <para>中间名</para>
                /// <para>必填：否</para>
                /// <para>示例值：大</para>
                /// </summary>
                [JsonPropertyName("middle_name")]
                public string? MiddleName { get; set; }

                /// <summary>
                /// <para>姓</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("name_primary")]
                public string? NamePrimary { get; set; }

                /// <summary>
                /// <para>第二姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("secondary")]
                public string? Secondary { get; set; }

                /// <summary>
                /// <para>尊称</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("social")]
                public Enum? Social { get; set; }

                /// <summary>
                /// <para>婚后姓氏</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("tertiary")]
                public string? Tertiary { get; set; }

                /// <summary>
                /// <para>头衔</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("title")]
                public Enum? Title { get; set; }

                /// <summary>
                /// <para>本地中间名</para>
                /// <para>必填：否</para>
                /// <para>示例值：大</para>
                /// </summary>
                [JsonPropertyName("local_middle_name")]
                public string? LocalMiddleName { get; set; }

                /// <summary>
                /// <para>第二姓氏 - 本地文字</para>
                /// <para>必填：否</para>
                /// <para>示例值：王</para>
                /// </summary>
                [JsonPropertyName("local_secondary")]
                public string? LocalSecondary { get; set; }

                /// <summary>
                /// <para>展示姓名（本地和西方文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("display_name_local_and_western_script")]
                public string? DisplayNameLocalAndWesternScript { get; set; }

                /// <summary>
                /// <para>展示姓名（本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("display_name_local_script")]
                public string? DisplayNameLocalScript { get; set; }

                /// <summary>
                /// <para>展示姓名（西方文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：王大帅</para>
                /// </summary>
                [JsonPropertyName("display_name_western_script")]
                public string? DisplayNameWesternScript { get; set; }
            }

            /// <summary>
            /// <para>-| 性别，枚举值可查询【获取字段详情】接口获取，按如下参数查询即可： - custom_api_name：gender - object_api_name：person</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("gender")]
            public Enum? Gender { get; set; }

            /// <summary>
            /// <para>-| 性别，枚举值可查询【获取字段详情】接口获取，按如下参数查询即可： - custom_api_name：gender - object_api_name：person</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
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
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>出生日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-01</para>
            /// </summary>
            [JsonPropertyName("date_of_birth")]
            public string? DateOfBirth { get; set; }

            /// <summary>
            /// <para>-| 民族 / 种族，枚举值可查询【获取字段详情】接口获取，按如下参数查询即可： - custom_api_name：ethnicity_race - object_api_name：person</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("race")]
            public Enum? Race { get; set; }

            /// <summary>
            /// <para>-| 婚姻状况，枚举值可查询【获取字段详情】接口获取，按如下参数查询即可： - custom_api_name：marital_status - object_api_name：person</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("marital_status")]
            public Enum? MaritalStatus { get; set; }

            /// <summary>
            /// <para>电话列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("phone_list")]
            public Phone[]? PhoneLists { get; set; }

            /// <summary>
            /// <para>电话列表</para>
            /// </summary>
            public record Phone
            {
                /// <summary>
                /// <para>国家区号</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("international_area_code")]
                public Enum? InternationalAreaCode { get; set; }

                /// <summary>
                /// <para>国家区号</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>电话号码</para>
                /// <para>必填：是</para>
                /// <para>示例值：010-12345678</para>
                /// </summary>
                [JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>完整电话号码</para>
                /// <para>必填：否</para>
                /// <para>示例值：+86 010-12345678</para>
                /// </summary>
                [JsonPropertyName("formatted_phone_number")]
                public string? FormattedPhoneNumber { get; set; }

                /// <summary>
                /// <para>设备类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("device_type")]
                public Enum? DeviceType { get; set; }

                /// <summary>
                /// <para>电话用途</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone_usage")]
                public Enum? PhoneUsage { get; set; }

                /// <summary>
                /// <para>主要电话</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool? IsPrimary { get; set; }

                /// <summary>
                /// <para>公开电话</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool? IsPublic { get; set; }
            }

            /// <summary>
            /// <para>地址列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("address_list")]
            public Address[]? AddressLists { get; set; }

            /// <summary>
            /// <para>地址列表</para>
            /// </summary>
            public record Address
            {
                /// <summary>
                /// <para>完整地址（本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国北京北京</para>
                /// </summary>
                [JsonPropertyName("full_address_local_script")]
                public string? FullAddressLocalScript { get; set; }

                /// <summary>
                /// <para>完整地址（西方文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：Beijing, Beijing, China,</para>
                /// </summary>
                [JsonPropertyName("full_address_western_script")]
                public string? FullAddressWesternScript { get; set; }

                /// <summary>
                /// <para>地址 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6989822217869624863</para>
                /// </summary>
                [JsonPropertyName("address_id")]
                public string? AddressId { get; set; }

                /// <summary>
                /// <para>国家 / 地区</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>主要行政区</para>
                /// <para>必填：否</para>
                /// <para>示例值：6863326815667095047</para>
                /// </summary>
                [JsonPropertyName("region_id")]
                public string? RegionId { get; set; }

                /// <summary>
                /// <para>地址行 1（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：丹佛测试地址-纽埃时区</para>
                /// </summary>
                [JsonPropertyName("local_address_line1")]
                public string? LocalAddressLine1 { get; set; }

                /// <summary>
                /// <para>地址行 2（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line2")]
                public string? LocalAddressLine2 { get; set; }

                /// <summary>
                /// <para>地址行 3（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：PoewH</para>
                /// </summary>
                [JsonPropertyName("local_address_line3")]
                public string? LocalAddressLine3 { get; set; }

                /// <summary>
                /// <para>地址行 4（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line4")]
                public string? LocalAddressLine4 { get; set; }

                /// <summary>
                /// <para>地址行 5（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line5")]
                public string? LocalAddressLine5 { get; set; }

                /// <summary>
                /// <para>地址行 6（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line6")]
                public string? LocalAddressLine6 { get; set; }

                /// <summary>
                /// <para>地址行 7（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：jmwJc</para>
                /// </summary>
                [JsonPropertyName("local_address_line7")]
                public string? LocalAddressLine7 { get; set; }

                /// <summary>
                /// <para>地址行 8（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：rafSu</para>
                /// </summary>
                [JsonPropertyName("local_address_line8")]
                public string? LocalAddressLine8 { get; set; }

                /// <summary>
                /// <para>地址行 9（非拉丁语系的本地文字）</para>
                /// <para>必填：否</para>
                /// <para>示例值：McPRG</para>
                /// </summary>
                [JsonPropertyName("local_address_line9")]
                public string? LocalAddressLine9 { get; set; }

                /// <summary>
                /// <para>邮政编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：611530</para>
                /// </summary>
                [JsonPropertyName("postal_code")]
                public string? PostalCode { get; set; }

                /// <summary>
                /// <para>地址类型</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("address_type_list")]
                public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

                /// <summary>
                /// <para>地址类型</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>主要地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_primary")]
                public bool IsPrimary { get; set; }

                /// <summary>
                /// <para>公开地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_public")]
                public bool IsPublic { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>邮箱列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email_list")]
            public Email[]? EmailLists { get; set; }

            /// <summary>
            /// <para>邮箱列表</para>
            /// </summary>
            public record Email
            {
                /// <summary>
                /// <para>邮箱地址</para>
                /// <para>必填：是</para>
                /// <para>示例值：1234567@example.feishu.cn</para>
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
                /// <para>邮箱用途，枚举值可通过文档【飞书人事枚举常量】邮箱用途（email_usage）枚举定义获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("email_usage")]
                public Enum? EmailUsage { get; set; }

                /// <summary>
                /// <para>邮箱用途，枚举值可通过文档【飞书人事枚举常量】邮箱用途（email_usage）枚举定义获得</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }
            }

            /// <summary>
            /// <para>工作经历列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_experience_list")]
            public WorkExperienceInfo[]? WorkExperienceLists { get; set; }

            /// <summary>
            /// <para>工作经历列表</para>
            /// </summary>
            public record WorkExperienceInfo
            {
                /// <summary>
                /// <para>公司 / 组织</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("company_organization")]
                public I18n[]? CompanyOrganizations { get; set; }

                /// <summary>
                /// <para>公司 / 组织</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>部门</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department")]
                public I18n[]? Departments { get; set; }

                /// <summary>
                /// <para>岗位</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("job")]
                public I18n[]? Jobs { get; set; }

                /// <summary>
                /// <para>工作描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18n[]? Descriptions { get; set; }

                /// <summary>
                /// <para>开始日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("start_date")]
                public string? StartDate { get; set; }

                /// <summary>
                /// <para>结束日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("end_date")]
                public string? EndDate { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>教育经历列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("education_list")]
            public Education[]? EducationLists { get; set; }

            /// <summary>
            /// <para>教育经历列表</para>
            /// </summary>
            public record Education
            {
                /// <summary>
                /// <para>学校</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("school")]
                public I18n[] Schools { get; set; } = Array.Empty<I18n>();

                /// <summary>
                /// <para>学校</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>学历</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("level_of_education")]
                public Enum? LevelOfEducation { get; set; }

                /// <summary>
                /// <para>学历</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>开始日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2011-09-01</para>
                /// </summary>
                [JsonPropertyName("start_date")]
                public string? StartDate { get; set; }

                /// <summary>
                /// <para>结束日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2015-06-30</para>
                /// </summary>
                [JsonPropertyName("end_date")]
                public string? EndDate { get; set; }

                /// <summary>
                /// <para>专业</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("field_of_study")]
                public I18n[]? FieldOfStuies { get; set; }

                /// <summary>
                /// <para>学位</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("degree")]
                public Enum? Degree { get; set; }

                /// <summary>
                /// <para>学校名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("school_name")]
                public Enum? SchoolName { get; set; }

                /// <summary>
                /// <para>专业名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("field_of_study_name")]
                public Enum? FieldOfStudyName { get; set; }

                /// <summary>
                /// <para>国家地区ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string? CountryRegionId { get; set; }

                /// <summary>
                /// <para>预期结束日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2011-09-01</para>
                /// </summary>
                [JsonPropertyName("expected_end_date")]
                public string? ExpectedEndDate { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>银行账户</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bank_account_list")]
            public BankAccount[]? BankAccountLists { get; set; }

            /// <summary>
            /// <para>银行账户</para>
            /// </summary>
            public record BankAccount
            {
                /// <summary>
                /// <para>银行名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国农业银行</para>
                /// </summary>
                [JsonPropertyName("bank_name")]
                public string? BankName { get; set; }

                /// <summary>
                /// <para>银行账号</para>
                /// <para>必填：是</para>
                /// <para>示例值：6231200000001223</para>
                /// </summary>
                [JsonPropertyName("bank_account_number")]
                public string BankAccountNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>开户人姓名</para>
                /// <para>必填：是</para>
                /// <para>示例值：孟十五</para>
                /// </summary>
                [JsonPropertyName("account_holder")]
                public string AccountHolder { get; set; } = string.Empty;

                /// <summary>
                /// <para>支行名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国农业银行支行</para>
                /// </summary>
                [JsonPropertyName("branch_name")]
                public string? BranchName { get; set; }

                /// <summary>
                /// <para>国家/地区 ID，详细信息可通过【查询国家/地区信息】接口查询获得</para>
                /// <para>必填：否</para>
                /// <para>示例值：12</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string? CountryRegionId { get; set; }

                /// <summary>
                /// <para>银行卡用途，枚举值可通过文档【飞书人事枚举常量】银行卡用途（Bank Account Usage）枚举定义部分获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("bank_account_usage")]
                public Enum[]? BankAccountUsages { get; set; }

                /// <summary>
                /// <para>银行卡用途，枚举值可通过文档【飞书人事枚举常量】银行卡用途（Bank Account Usage）枚举定义部分获得</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>银行卡类型，枚举值可通过文档【飞书人事枚举常量】银行卡类型（Bank Account Type）枚举定义部分获得</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("bank_account_type")]
                public Enum? BankAccountType { get; set; }

                /// <summary>
                /// <para>货币id</para>
                /// <para>必填：否</para>
                /// <para>示例值：12QueryCountryRegionSubdivisionDataReq</para>
                /// </summary>
                [JsonPropertyName("currency_id")]
                public string? CurrencyId { get; set; }

                /// <summary>
                /// <para>国际银行账号</para>
                /// <para>必填：否</para>
                /// <para>示例值：CH56 0483 5012 3456 7800 9</para>
                /// </summary>
                [JsonPropertyName(nameof(IBAN))]
                public string? IBAN { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>证件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("national_id_list")]
            public NationalId[]? NationalIdLists { get; set; }

            /// <summary>
            /// <para>证件</para>
            /// </summary>
            public record NationalId
            {
                /// <summary>
                /// <para>国家证件类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：6863330041896371725</para>
                /// </summary>
                [JsonPropertyName("national_id_type_id")]
                public string NationalIdTypeId { get; set; } = string.Empty;

                /// <summary>
                /// <para>证件号码</para>
                /// <para>必填：是</para>
                /// <para>示例值：1231131333</para>
                /// </summary>
                [JsonPropertyName("national_id_number")]
                public string NationalIdNumber { get; set; } = string.Empty;

                /// <summary>
                /// <para>证件签发日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-04-01</para>
                /// </summary>
                [JsonPropertyName("issue_date")]
                public string? IssueDate { get; set; }

                /// <summary>
                /// <para>证件到期日期</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-05-21</para>
                /// </summary>
                [JsonPropertyName("expiration_date")]
                public string? ExpirationDate { get; set; }

                /// <summary>
                /// <para>国家 / 地区</para>
                /// <para>必填：是</para>
                /// <para>示例值：6862995757234914824</para>
                /// </summary>
                [JsonPropertyName("country_region_id")]
                public string CountryRegionId { get; set; } = string.Empty;

                /// <summary>
                /// <para>证件签发机构</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京市公安局</para>
                /// </summary>
                [JsonPropertyName("issued_by")]
                public string? IssuedBy { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>家庭成员列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dependent_list")]
            public Dependent[]? DependentLists { get; set; }

            /// <summary>
            /// <para>家庭成员列表</para>
            /// </summary>
            public record Dependent
            {
                /// <summary>
                /// <para>姓名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public PersonName? Name { get; set; }

                /// <summary>
                /// <para>姓名</para>
                /// </summary>
                public record PersonName
                {
                    /// <summary>
                    /// <para>姓 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：黄</para>
                    /// </summary>
                    [JsonPropertyName("local_primary")]
                    public string? LocalPrimary { get; set; }

                    /// <summary>
                    /// <para>名 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：四</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name")]
                    public string? LocalFirstName { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>姓名类型</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("name_type")]
                    public Enum NameType { get; set; } = new();

                    /// <summary>
                    /// <para>姓名类型</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
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
                            /// <para>语言</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：张三</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>名 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：五</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name_2")]
                    public string? LocalFirstName2 { get; set; }

                    /// <summary>
                    /// <para>姓 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_primary_2")]
                    public string? LocalPrimary2 { get; set; }

                    /// <summary>
                    /// <para>补充姓名类型</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("additional_name_type")]
                    public Enum? AdditionalNameType { get; set; }

                    /// <summary>
                    /// <para>名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：帅</para>
                    /// </summary>
                    [JsonPropertyName("first_name")]
                    public string? FirstName { get; set; }

                    /// <summary>
                    /// <para>全名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("full_name")]
                    public string? FullName { get; set; }

                    /// <summary>
                    /// <para>姓氏称谓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("hereditary")]
                    public string? Hereditary { get; set; }

                    /// <summary>
                    /// <para>自定义姓名（未传入时，姓名将默认根据所属国家 / 地区规则对相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_name")]
                    public string? CustomName { get; set; }

                    /// <summary>
                    /// <para>本地文字的自定义姓名（未传入时，本地文字的姓名将默认根据所属国家 / 地区规则对本地文字的相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_local_name")]
                    public string? CustomLocalName { get; set; }

                    /// <summary>
                    /// <para>中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("middle_name")]
                    public string? MiddleName { get; set; }

                    /// <summary>
                    /// <para>姓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("name_primary")]
                    public string? NamePrimary { get; set; }

                    /// <summary>
                    /// <para>第二姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("secondary")]
                    public string? Secondary { get; set; }

                    /// <summary>
                    /// <para>尊称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("social")]
                    public Enum? Social { get; set; }

                    /// <summary>
                    /// <para>婚后姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("tertiary")]
                    public string? Tertiary { get; set; }

                    /// <summary>
                    /// <para>头衔</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public Enum? Title { get; set; }

                    /// <summary>
                    /// <para>本地中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("local_middle_name")]
                    public string? LocalMiddleName { get; set; }

                    /// <summary>
                    /// <para>第二姓氏 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_secondary")]
                    public string? LocalSecondary { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地和西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_and_western_script")]
                    public string? DisplayNameLocalAndWesternScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_script")]
                    public string? DisplayNameLocalScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_western_script")]
                    public string? DisplayNameWesternScript { get; set; }
                }

                /// <summary>
                /// <para>关系</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public Enum Relationship { get; set; } = new();

                /// <summary>
                /// <para>关系</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>性别</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("gender")]
                public Enum? Gender { get; set; }

                /// <summary>
                /// <para>生日</para>
                /// <para>必填：否</para>
                /// <para>示例值：2020-01-01</para>
                /// </summary>
                [JsonPropertyName("date_of_birth")]
                public string? DateOfBirth { get; set; }

                /// <summary>
                /// <para>证件号码</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("national_id_list")]
                public NationalId[]? NationalIdLists { get; set; }

                /// <summary>
                /// <para>证件号码</para>
                /// </summary>
                public record NationalId
                {
                    /// <summary>
                    /// <para>国家证件类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6863330041896371725</para>
                    /// </summary>
                    [JsonPropertyName("national_id_type_id")]
                    public string NationalIdTypeId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>证件号码</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1231131333</para>
                    /// </summary>
                    [JsonPropertyName("national_id_number")]
                    public string NationalIdNumber { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>证件签发日期</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2020-04-01</para>
                    /// </summary>
                    [JsonPropertyName("issue_date")]
                    public string? IssueDate { get; set; }

                    /// <summary>
                    /// <para>证件到期日期</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2020-05-21</para>
                    /// </summary>
                    [JsonPropertyName("expiration_date")]
                    public string? ExpirationDate { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>证件签发机构</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：北京市公安局</para>
                    /// </summary>
                    [JsonPropertyName("issued_by")]
                    public string? IssuedBy { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("custom_fields")]
                    public CustomFieldData[]? CustomFields { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// </summary>
                    public record CustomFieldData
                    {
                        /// <summary>
                        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：name</para>
                        /// </summary>
                        [JsonPropertyName("custom_api_name")]
                        public string CustomApiName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public CustomName? Name { get; set; }

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// </summary>
                        public record CustomName
                        {
                            /// <summary>
                            /// <para>中文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：自定义姓名</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Custom Name</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>自定义字段类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：\"231\"</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>配偶工作状态</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("spouses_working_status")]
                public Enum? SpousesWorkingStatus { get; set; }

                /// <summary>
                /// <para>包含家属医疗保险</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_this_person_covered_by_health_insurance")]
                public bool? IsThisPersonCoveredByHealthInsurance { get; set; }

                /// <summary>
                /// <para>允许家属抵扣税款</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_this_person_allowed_for_tax_deduction")]
                public bool? IsThisPersonAllowedForTaxDeduction { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>家庭成员姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("dependent_name")]
                public string? DependentName { get; set; }

                /// <summary>
                /// <para>工作单位</para>
                /// <para>必填：否</para>
                /// <para>示例值：海淀区交警大队</para>
                /// </summary>
                [JsonPropertyName("employer")]
                public string? Employer { get; set; }

                /// <summary>
                /// <para>岗位</para>
                /// <para>必填：否</para>
                /// <para>示例值：保安</para>
                /// </summary>
                [JsonPropertyName("job")]
                public string? Job { get; set; }

                /// <summary>
                /// <para>电话</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone")]
                public DependentPhone? Phone { get; set; }

                /// <summary>
                /// <para>电话</para>
                /// </summary>
                public record DependentPhone
                {
                    /// <summary>
                    /// <para>国家区号</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("international_area_code")]
                    public Enum? InternationalAreaCode { get; set; }

                    /// <summary>
                    /// <para>国家区号</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
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
                            /// <para>语言</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：张三</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>电话号码</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("phone_number")]
                    public string PhoneNumber { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>完整电话号码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：+86 010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("formatted_phone_number")]
                    public string? FormattedPhoneNumber { get; set; }

                    /// <summary>
                    /// <para>设备类型</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("device_type")]
                    public Enum? DeviceType { get; set; }

                    /// <summary>
                    /// <para>电话用途</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("phone_usage")]
                    public Enum? PhoneUsage { get; set; }

                    /// <summary>
                    /// <para>主要电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_primary")]
                    public bool? IsPrimary { get; set; }

                    /// <summary>
                    /// <para>公开电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_public")]
                    public bool? IsPublic { get; set; }
                }

                /// <summary>
                /// <para>联系地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("address")]
                public DependentAddress? Address { get; set; }

                /// <summary>
                /// <para>联系地址</para>
                /// </summary>
                public record DependentAddress
                {
                    /// <summary>
                    /// <para>完整地址（本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中国北京北京</para>
                    /// </summary>
                    [JsonPropertyName("full_address_local_script")]
                    public string? FullAddressLocalScript { get; set; }

                    /// <summary>
                    /// <para>完整地址（西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Beijing, Beijing, China,</para>
                    /// </summary>
                    [JsonPropertyName("full_address_western_script")]
                    public string? FullAddressWesternScript { get; set; }

                    /// <summary>
                    /// <para>地址 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6989822217869624863</para>
                    /// </summary>
                    [JsonPropertyName("address_id")]
                    public string? AddressId { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>主要行政区</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6863326815667095047</para>
                    /// </summary>
                    [JsonPropertyName("region_id")]
                    public string? RegionId { get; set; }

                    /// <summary>
                    /// <para>地址行 1（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：丹佛测试地址-纽埃时区</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line1")]
                    public string? LocalAddressLine1 { get; set; }

                    /// <summary>
                    /// <para>地址行 2（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：PoewH</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line2")]
                    public string? LocalAddressLine2 { get; set; }

                    /// <summary>
                    /// <para>地址行 3（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：PoewH</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line3")]
                    public string? LocalAddressLine3 { get; set; }

                    /// <summary>
                    /// <para>地址行 4（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：jmwJc</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line4")]
                    public string? LocalAddressLine4 { get; set; }

                    /// <summary>
                    /// <para>地址行 5（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：jmwJc</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line5")]
                    public string? LocalAddressLine5 { get; set; }

                    /// <summary>
                    /// <para>地址行 6（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：jmwJc</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line6")]
                    public string? LocalAddressLine6 { get; set; }

                    /// <summary>
                    /// <para>地址行 7（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：jmwJc</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line7")]
                    public string? LocalAddressLine7 { get; set; }

                    /// <summary>
                    /// <para>地址行 8（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：rafSu</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line8")]
                    public string? LocalAddressLine8 { get; set; }

                    /// <summary>
                    /// <para>地址行 9（非拉丁语系的本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：McPRG</para>
                    /// </summary>
                    [JsonPropertyName("local_address_line9")]
                    public string? LocalAddressLine9 { get; set; }

                    /// <summary>
                    /// <para>邮政编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：611530</para>
                    /// </summary>
                    [JsonPropertyName("postal_code")]
                    public string? PostalCode { get; set; }

                    /// <summary>
                    /// <para>地址类型</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("address_type_list")]
                    public Enum[] AddressTypeLists { get; set; } = Array.Empty<Enum>();

                    /// <summary>
                    /// <para>地址类型</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
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
                            /// <para>语言</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：张三</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>主要地址</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_primary")]
                    public bool IsPrimary { get; set; }

                    /// <summary>
                    /// <para>公开地址</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_public")]
                    public bool IsPublic { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("custom_fields")]
                    public CustomFieldData[]? CustomFields { get; set; }

                    /// <summary>
                    /// <para>自定义字段</para>
                    /// </summary>
                    public record CustomFieldData
                    {
                        /// <summary>
                        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：name</para>
                        /// </summary>
                        [JsonPropertyName("custom_api_name")]
                        public string CustomApiName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public CustomName? Name { get; set; }

                        /// <summary>
                        /// <para>自定义字段名称</para>
                        /// </summary>
                        public record CustomName
                        {
                            /// <summary>
                            /// <para>中文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：自定义姓名</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>英文</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Custom Name</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>自定义字段类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("type")]
                        public int? Type { get; set; }

                        /// <summary>
                        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：\"231\"</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>出生证明</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("birth_certificate_of_child")]
                public File[]? BirthCertificateOfChilds { get; set; }

                /// <summary>
                /// <para>出生证明</para>
                /// </summary>
                public record File
                {
                    /// <summary>
                    /// <para>上传文件ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }
                }
            }

            /// <summary>
            /// <para>紧急联系人列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("emergency_contact_list")]
            public EmergencyContact[]? EmergencyContactLists { get; set; }

            /// <summary>
            /// <para>紧急联系人列表</para>
            /// </summary>
            public record EmergencyContact
            {
                /// <summary>
                /// <para>姓名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public PersonName? Name { get; set; }

                /// <summary>
                /// <para>姓名</para>
                /// </summary>
                public record PersonName
                {
                    /// <summary>
                    /// <para>姓 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：黄</para>
                    /// </summary>
                    [JsonPropertyName("local_primary")]
                    public string? LocalPrimary { get; set; }

                    /// <summary>
                    /// <para>名 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：四</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name")]
                    public string? LocalFirstName { get; set; }

                    /// <summary>
                    /// <para>国家 / 地区</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：6862995757234914824</para>
                    /// </summary>
                    [JsonPropertyName("country_region_id")]
                    public string CountryRegionId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>姓名类型</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("name_type")]
                    public Enum NameType { get; set; } = new();

                    /// <summary>
                    /// <para>姓名类型</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
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
                            /// <para>语言</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：张三</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>名 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：五</para>
                    /// </summary>
                    [JsonPropertyName("local_first_name_2")]
                    public string? LocalFirstName2 { get; set; }

                    /// <summary>
                    /// <para>姓 - 第二本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_primary_2")]
                    public string? LocalPrimary2 { get; set; }

                    /// <summary>
                    /// <para>补充姓名类型</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("additional_name_type")]
                    public Enum? AdditionalNameType { get; set; }

                    /// <summary>
                    /// <para>名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：帅</para>
                    /// </summary>
                    [JsonPropertyName("first_name")]
                    public string? FirstName { get; set; }

                    /// <summary>
                    /// <para>全名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("full_name")]
                    public string? FullName { get; set; }

                    /// <summary>
                    /// <para>姓氏称谓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("hereditary")]
                    public string? Hereditary { get; set; }

                    /// <summary>
                    /// <para>自定义姓名（未传入时，姓名将默认根据所属国家 / 地区规则对相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_name")]
                    public string? CustomName { get; set; }

                    /// <summary>
                    /// <para>本地文字的自定义姓名（未传入时，本地文字的姓名将默认根据所属国家 / 地区规则对本地文字的相关姓、名字段拼接）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("custom_local_name")]
                    public string? CustomLocalName { get; set; }

                    /// <summary>
                    /// <para>中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("middle_name")]
                    public string? MiddleName { get; set; }

                    /// <summary>
                    /// <para>姓</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("name_primary")]
                    public string? NamePrimary { get; set; }

                    /// <summary>
                    /// <para>第二姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("secondary")]
                    public string? Secondary { get; set; }

                    /// <summary>
                    /// <para>尊称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("social")]
                    public Enum? Social { get; set; }

                    /// <summary>
                    /// <para>婚后姓氏</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("tertiary")]
                    public string? Tertiary { get; set; }

                    /// <summary>
                    /// <para>头衔</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public Enum? Title { get; set; }

                    /// <summary>
                    /// <para>本地中间名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大</para>
                    /// </summary>
                    [JsonPropertyName("local_middle_name")]
                    public string? LocalMiddleName { get; set; }

                    /// <summary>
                    /// <para>第二姓氏 - 本地文字</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王</para>
                    /// </summary>
                    [JsonPropertyName("local_secondary")]
                    public string? LocalSecondary { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地和西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_and_western_script")]
                    public string? DisplayNameLocalAndWesternScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（本地文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_local_script")]
                    public string? DisplayNameLocalScript { get; set; }

                    /// <summary>
                    /// <para>展示姓名（西方文字）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：王大帅</para>
                    /// </summary>
                    [JsonPropertyName("display_name_western_script")]
                    public string? DisplayNameWesternScript { get; set; }
                }

                /// <summary>
                /// <para>关系</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public Enum? Relationship { get; set; }

                /// <summary>
                /// <para>关系</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>电话</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("phone_ist")]
                public Phone[]? PhoneIsts { get; set; }

                /// <summary>
                /// <para>电话</para>
                /// </summary>
                public record Phone
                {
                    /// <summary>
                    /// <para>国家区号</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("international_area_code")]
                    public Enum? InternationalAreaCode { get; set; }

                    /// <summary>
                    /// <para>国家区号</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
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
                            /// <para>语言</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：张三</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>电话号码</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("phone_number")]
                    public string PhoneNumber { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>完整电话号码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：+86 010-12345678</para>
                    /// </summary>
                    [JsonPropertyName("formatted_phone_number")]
                    public string? FormattedPhoneNumber { get; set; }

                    /// <summary>
                    /// <para>设备类型</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("device_type")]
                    public Enum? DeviceType { get; set; }

                    /// <summary>
                    /// <para>电话用途</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("phone_usage")]
                    public Enum? PhoneUsage { get; set; }

                    /// <summary>
                    /// <para>主要电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_primary")]
                    public bool? IsPrimary { get; set; }

                    /// <summary>
                    /// <para>公开电话</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_public")]
                    public bool? IsPublic { get; set; }
                }

                /// <summary>
                /// <para>法定姓名</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("legal_name")]
                public string? LegalName { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：\"231\"</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>参加工作日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-10-01</para>
            /// </summary>
            [JsonPropertyName("date_entered_workforce")]
            public string? DateEnteredWorkforce { get; set; }

            /// <summary>
            /// <para>工龄</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// </summary>
            [JsonPropertyName("working_years")]
            public int? WorkingYears { get; set; }

            /// <summary>
            /// <para>头像资源的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：dfysuc8x76dsfsw</para>
            /// </summary>
            [JsonPropertyName("profile_image_id")]
            public string? ProfileImageId { get; set; }

            /// <summary>
            /// <para>邮箱地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@163.com</para>
            /// </summary>
            [JsonPropertyName("email_address")]
            public string? EmailAddress { get; set; }

            /// <summary>
            /// <para>年龄</para>
            /// <para>必填：否</para>
            /// <para>示例值：22</para>
            /// </summary>
            [JsonPropertyName("age")]
            public int? Age { get; set; }

            /// <summary>
            /// <para>最高学历教育经历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highest_level_of_education")]
            public Education? HighestLevelOfEducation { get; set; }

            /// <summary>
            /// <para>最高学位教育经历</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("highest_degree_of_education")]
            public Education? HighestDegreeOfEducation { get; set; }

            /// <summary>
            /// <para>个人资料附件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("personal_profile")]
            public PersonalProfile[]? PersonalProfiles { get; set; }

            /// <summary>
            /// <para>个人资料附件</para>
            /// </summary>
            public record PersonalProfile
            {
                /// <summary>
                /// <para>个人资料 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
                /// </summary>
                [JsonPropertyName("personal_profile_id")]
                public string? PersonalProfileId { get; set; }

                /// <summary>
                /// <para>资料类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("personal_profile_type")]
                public Enum? PersonalProfileType { get; set; }

                /// <summary>
                /// <para>资料类型</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>上传文件列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("files")]
                public File[]? Files { get; set; }

                /// <summary>
                /// <para>上传文件列表</para>
                /// </summary>
                public record File
                {
                    /// <summary>
                    /// <para>上传文件ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：150018109586e8ea745e47ae8feb3722dbe1d03a181336393633393133303431393831343930373235150200</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }
                }
            }

            /// <summary>
            /// <para>籍贯 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752111</para>
            /// </summary>
            [JsonPropertyName("native_region")]
            public string? NativeRegion { get; set; }

            /// <summary>
            /// <para>户口类型，枚举值可通过文档【飞书人事枚举常量】户口类型（hukou_type）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hukou_type")]
            public Enum? HukouType { get; set; }

            /// <summary>
            /// <para>户口所在地</para>
            /// <para>必填：否</para>
            /// <para>示例值：山东省平阴县</para>
            /// </summary>
            [JsonPropertyName("hukou_location")]
            public string? HukouLocation { get; set; }

            /// <summary>
            /// <para>人才 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("talent_id")]
            public string? TalentId { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public CustomFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record CustomFieldData
            {
                /// <summary>
                /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("custom_api_name")]
                public string CustomApiName { get; set; } = string.Empty;

                /// <summary>
                /// <para>自定义字段名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public CustomName? Name { get; set; }

                /// <summary>
                /// <para>自定义字段名称</para>
                /// </summary>
                public record CustomName
                {
                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：自定义姓名</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Custom Name</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>自定义字段类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"231\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>居民身份证件号码</para>
            /// <para>必填：否</para>
            /// <para>示例值：11010000000000</para>
            /// </summary>
            [JsonPropertyName("national_id_number")]
            public string? NationalIdNumber { get; set; }

            /// <summary>
            /// <para>家庭地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("family_address")]
            public string? FamilyAddress { get; set; }

            /// <summary>
            /// <para>出生国家/地区</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国</para>
            /// </summary>
            [JsonPropertyName("born_country_region")]
            public string? BornCountryRegion { get; set; }

            /// <summary>
            /// <para>是否残疾</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_disabled")]
            public bool? IsDisabled { get; set; }

            /// <summary>
            /// <para>残疾证号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1110000</para>
            /// </summary>
            [JsonPropertyName("disable_card_number")]
            public string? DisableCardNumber { get; set; }

            /// <summary>
            /// <para>是否烈属</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_martyr_family")]
            public bool? IsMartyrFamily { get; set; }

            /// <summary>
            /// <para>烈属证号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1110000</para>
            /// </summary>
            [JsonPropertyName("martyr_card_number")]
            public string? MartyrCardNumber { get; set; }

            /// <summary>
            /// <para>是否孤老</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_old_alone")]
            public bool? IsOldAlone { get; set; }

            /// <summary>
            /// <para>居民身份信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326262618752123</para>
            /// </summary>
            [JsonPropertyName("resident_taxes")]
            public ResidentTax[]? ResidentTaxes { get; set; }

            /// <summary>
            /// <para>居民身份信息</para>
            /// </summary>
            public record ResidentTax
            {
                /// <summary>
                /// <para>年度</para>
                /// <para>必填：是</para>
                /// <para>示例值：2023</para>
                /// </summary>
                [JsonPropertyName("year_resident_tax")]
                public string YearResidentTax { get; set; } = string.Empty;

                /// <summary>
                /// <para>-| 居民身份，枚举值 api_name 可通过【获取字段详情】接口查询，查询参数如下： - object_api_name = "resident_tax" - custom_api_name = "resident_status"</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("resident_status")]
                public Enum? ResidentStatus { get; set; }

                /// <summary>
                /// <para>-| 居民身份，枚举值 api_name 可通过【获取字段详情】接口查询，查询参数如下： - object_api_name = "resident_tax" - custom_api_name = "resident_status"</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
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
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>国家/地区，可通过【查询国家/地区信息】 接口查询</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国</para>
                /// </summary>
                [JsonPropertyName("tax_country_region_id")]
                public string? TaxCountryRegionId { get; set; }

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
                    /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：Sandy</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>首次入境日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-02</para>
            /// </summary>
            [JsonPropertyName("first_entry_time")]
            public string? FirstEntryTime { get; set; }

            /// <summary>
            /// <para>预计离境日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-01-02</para>
            /// </summary>
            [JsonPropertyName("leave_time")]
            public string? LeaveTime { get; set; }
        }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record CustomFieldData
        {
            /// <summary>
            /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("custom_api_name")]
            public string CustomApiName { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public CustomName? Name { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// </summary>
            public record CustomName
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：自定义姓名</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Custom Name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>竞业状态，枚举值包括:1.竞业中；2.未竞业</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("noncompete_status")]
        public Enum? NoncompeteStatus { get; set; }

        /// <summary>
        /// <para>是否历史离职人员</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("past_offboarding")]
        public bool? PastOffboarding { get; set; }

        /// <summary>
        /// <para>转正式日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("regular_employee_start_date")]
        public string? RegularEmployeeStartDate { get; set; }

        /// <summary>
        /// <para>外部系统 ID , 可存储租户系统中的员工 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000000</para>
        /// </summary>
        [JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// <para>入职次数</para>
        /// <para>必填：否</para>
        /// <para>示例值：16</para>
        /// </summary>
        [JsonPropertyName("times_employed")]
        public int? TimesEmployed { get; set; }

        /// <summary>
        /// <para>招聘来源，枚举值 api_name 可通过【获取自定义字段详情】接口查询</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recruitment_type")]
        public Enum? RecruitmentType { get; set; }

        /// <summary>
        /// <para>员工头像</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v2_a550d36b-28ef-48ad-9e50-58004beb386j~?image_size=noop&amp;cut_type=&amp;quality=&amp;format=png&amp;sticker_format=.webp</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>主合同 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("primary_contract_id")]
        public string? PrimaryContractId { get; set; }

        /// <summary>
        /// <para>主合同开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("contract_start_date")]
        public string? ContractStartDate { get; set; }

        /// <summary>
        /// <para>主合同到期日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("contract_end_date")]
        public string? ContractEndDate { get; set; }

        /// <summary>
        /// <para>主合同预计到期日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonPropertyName("contract_expected_end_date")]
        public string? ContractExpectedEndDate { get; set; }

        /// <summary>
        /// <para>所属薪资组 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("pay_group_id")]
        public string? PayGroupId { get; set; }

        /// <summary>
        /// <para>是否外派</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("international_assignment")]
        public bool? InternationalAssignment { get; set; }

        /// <summary>
        /// <para>工作日历 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7164286667866966659</para>
        /// </summary>
        [JsonPropertyName("work_calendar_id")]
        public string? WorkCalendarId { get; set; }

        /// <summary>
        /// <para>部门基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public BasicDepartment? Department { get; set; }

        /// <summary>
        /// <para>部门基本信息</para>
        /// </summary>
        public record BasicDepartment
        {
            /// <summary>
            /// <para>部门 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_name")]
            public I18n[]? DepartmentNames { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>直接上级基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("direct_manager")]
        public BasicEmployee? DirectManager { get; set; }

        /// <summary>
        /// <para>直接上级基本信息</para>
        /// </summary>
        public record BasicEmployee
        {
            /// <summary>
            /// <para>雇佣 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014062142064135</para>
            /// </summary>
            [JsonPropertyName("employment_id")]
            public string? EmploymentId { get; set; }

            /// <summary>
            /// <para>工号</para>
            /// <para>必填：否</para>
            /// <para>示例值：1000000</para>
            /// </summary>
            [JsonPropertyName("employee_number")]
            public string? EmployeeNumber { get; set; }

            /// <summary>
            /// <para>邮箱地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@163.com</para>
            /// </summary>
            [JsonPropertyName("email_address")]
            public string? EmailAddress { get; set; }

            /// <summary>
            /// <para>基本个人信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("person_info")]
            public BasicPersonInfo? PersonInfo { get; set; }

            /// <summary>
            /// <para>基本个人信息</para>
            /// </summary>
            public record BasicPersonInfo
            {
                /// <summary>
                /// <para>个人信息 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6919733936050406926</para>
                /// </summary>
                [JsonPropertyName("person_id")]
                public string? PersonId { get; set; }

                /// <summary>
                /// <para>常用名</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("preferred_name")]
                public string? PreferredName { get; set; }

                /// <summary>
                /// <para>常用本地全名</para>
                /// <para>必填：否</para>
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonPropertyName("preferred_local_full_name")]
                public string? PreferredLocalFullName { get; set; }

                /// <summary>
                /// <para>常用英文全名</para>
                /// <para>必填：否</para>
                /// <para>示例值：Henry</para>
                /// </summary>
                [JsonPropertyName("preferred_english_full_name")]
                public string? PreferredEnglishFullName { get; set; }
            }
        }

        /// <summary>
        /// <para>虚线上级基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dotted_line_manager")]
        public BasicEmployee? DottedLineManager { get; set; }

        /// <summary>
        /// <para>时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Shanghai</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// <para>当前生效的外派记录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("primary_international_assignment")]
        public InternationalAssignmentSuffix? PrimaryInternationalAssignment { get; set; }

        /// <summary>
        /// <para>当前生效的外派记录</para>
        /// </summary>
        public record InternationalAssignmentSuffix
        {
            /// <summary>
            /// <para>当前生效的外派记录ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7046599238679447000</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的外派城市（派驻地）ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7046599238679447084</para>
            /// </summary>
            [JsonPropertyName("assignment_city_id")]
            public string? AssignmentCityId { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的外派公司ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7046599238679447084</para>
            /// </summary>
            [JsonPropertyName("assignment_company_id")]
            public string? AssignmentCompanyId { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的外派国家ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7046599238679447084</para>
            /// </summary>
            [JsonPropertyName("assignment_country_id")]
            public string? AssignmentCountryId { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的外派原因</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assignment_reason")]
            public I18n? AssignmentReason { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的外派原因</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>当前生效外派记录的生效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-08-29</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的开始外派流程 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：111111</para>
            /// </summary>
            [JsonPropertyName("start_assignment_process_id")]
            public string? StartAssignmentProcessId { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的结束外派流程 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1111111</para>
            /// </summary>
            [JsonPropertyName("end_assignment_process_id")]
            public string? EndAssignmentProcessId { get; set; }

            /// <summary>
            /// <para>当前生效外派记录的失效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-12-29</para>
            /// </summary>
            [JsonPropertyName("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>-| 当前生效外派记录的外派状态 - 枚举值可查询【获取字段详情】接口获取，按如下参数查询即可： - custom_api_name：international_assignment_status - object_api_name：international_assignment</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("international_assignment_status")]
            public Enum? InternationalAssignmentStatus { get; set; }

            /// <summary>
            /// <para>-| 当前生效外派记录的外派状态 - 枚举值可查询【获取字段详情】接口获取，按如下参数查询即可： - custom_api_name：international_assignment_status - object_api_name：international_assignment</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
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
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>-| 当前生效外派记录的外派类型 - 枚举值可查询【获取字段详情】接口获取，按如下参数查询即可： - custom_api_name：international_assignment_type - object_api_name：international_assignment</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("international_assignment_type")]
            public Enum? InternationalAssignmentType { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJldV9uYyI6IlswLFwiNjk2MTI4Njg0NjA5Mzc4ODY4MC03MjExMDM0ODcxMjA3OTUzOTc1XCJdIn0</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
