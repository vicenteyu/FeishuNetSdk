namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建待入职人员 请求体
/// <para>创建待入职人员。</para>
/// <para>接口ID：7160511371865014276</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fcreate</para>
/// </summary>
public record PostCorehrV2PreHiresBodyDto
{
    /// <summary>
    /// <para>个人信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("basic_info")]
    public PostCorehrV2PreHiresBodyDtoBasicInfo BasicInfo { get; set; } = new();

    /// <summary>
    /// <para>个人信息</para>
    /// </summary>
    public record PostCorehrV2PreHiresBodyDtoBasicInfo
    {
        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public PostCorehrV2PreHiresBodyDtoBasicInfoName? Name { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// </summary>
        public record PostCorehrV2PreHiresBodyDtoBasicInfoName
        {
            /// <summary>
            /// <para>全名</para>
            /// <para>必填：否</para>
            /// <para>示例值：李一一</para>
            /// </summary>
            [JsonPropertyName("full_name")]
            public string? FullName { get; set; }

            /// <summary>
            /// <para>名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("first_name")]
            public string? FirstName { get; set; }

            /// <summary>
            /// <para>中间名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("middle_name")]
            public string? MiddleName { get; set; }

            /// <summary>
            /// <para>姓</para>
            /// <para>必填：否</para>
            /// <para>示例值：李</para>
            /// </summary>
            [JsonPropertyName("name_primary")]
            public string? NamePrimary { get; set; }

            /// <summary>
            /// <para>名 - 本地文字</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("local_first_name")]
            public string? LocalFirstName { get; set; }

            /// <summary>
            /// <para>本地中间名</para>
            /// <para>必填：否</para>
            /// <para>示例值：一</para>
            /// </summary>
            [JsonPropertyName("local_middle_name")]
            public string? LocalMiddleName { get; set; }

            /// <summary>
            /// <para>姓 - 本地文字</para>
            /// <para>必填：否</para>
            /// <para>示例值：李</para>
            /// </summary>
            [JsonPropertyName("local_primary")]
            public string? LocalPrimary { get; set; }
        }

        /// <summary>
        /// <para>手机号</para>
        /// <para>必填：否</para>
        /// <para>示例值：31123127</para>
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// <para>区号</para>
        /// <para>必填：否</para>
        /// <para>示例值：86_china</para>
        /// </summary>
        [JsonPropertyName("international_area_code")]
        public string? InternationalAreaCode { get; set; }

        /// <summary>
        /// <para>个人邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：xx@xx.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>生日</para>
        /// <para>必填：否</para>
        /// <para>示例值：2011-99-99</para>
        /// </summary>
        [JsonPropertyName("date_of_birth")]
        public string? DateOfBirth { get; set; }

        /// <summary>
        /// <para>证件号</para>
        /// <para>必填：否</para>
        /// <para>示例值：31123127</para>
        /// </summary>
        [JsonPropertyName("personal_id_number")]
        public string? PersonalIdNumber { get; set; }

        /// <summary>
        /// <para>参加工作日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2100-09-09</para>
        /// </summary>
        [JsonPropertyName("date_entered_workforce")]
        public string? DateEnteredWorkforce { get; set; }

        /// <summary>
        /// <para>性别</para>
        /// <para>必填：否</para>
        /// <para>示例值：male</para>
        /// </summary>
        [JsonPropertyName("gender_id")]
        public string? GenderId { get; set; }

        /// <summary>
        /// <para>国籍</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("nationality_id")]
        public string? NationalityId { get; set; }

        /// <summary>
        /// <para>家庭地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：homeaddr</para>
        /// </summary>
        [JsonPropertyName("home_address")]
        public string? HomeAddress { get; set; }

        /// <summary>
        /// <para>人员编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("worker_id")]
        public string? WorkerId { get; set; }
    }

    /// <summary>
    /// <para>职位信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("offer_info")]
    public PostCorehrV2PreHiresBodyDtoOfferInfo OfferInfo { get; set; } = new();

    /// <summary>
    /// <para>职位信息</para>
    /// </summary>
    public record PostCorehrV2PreHiresBodyDtoOfferInfo
    {
        /// <summary>
        /// <para>Offer ID，仅支持飞书招聘 ID，可以通过飞书招聘【获取 Offer 申请表列表】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7032210902531327521</para>
        /// </summary>
        [JsonPropertyName("offer_id")]
        public string? OfferId { get; set; }

        /// <summary>
        /// <para>Offer HR ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7032210902531327521</para>
        /// </summary>
        [JsonPropertyName("offer_hr_id")]
        public string? OfferHrId { get; set; }

        /// <summary>
        /// <para>部门 ID，可以通过【批量获取部门】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7147562782945478177</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>直属领导的雇佣 ID，可以通过【查询员工信息】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7032210902531327521</para>
        /// </summary>
        [JsonPropertyName("direct_leader_id")]
        public string? DirectLeaderId { get; set; }

        /// <summary>
        /// <para>职务 ID，可以通过招聘【批量查询职务】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976735715378724</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职务序列 ID，可以通过招聘【批量查询职务序列】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977972856625939999</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>职务级别 ID，可以通过招聘【批量查询职务级别】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977971894960145950</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>职务头衔</para>
        /// <para>必填：否</para>
        /// <para>示例值：java</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>试用期开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-07-29</para>
        /// </summary>
        [JsonPropertyName("probation_start_date")]
        public string? ProbationStartDate { get; set; }

        /// <summary>
        /// <para>试用期结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-04-07</para>
        /// </summary>
        [JsonPropertyName("probation_end_date")]
        public string? ProbationEndDate { get; set; }

        /// <summary>
        /// <para>合同开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-08</para>
        /// </summary>
        [JsonPropertyName("contract_start_date")]
        public string? ContractStartDate { get; set; }

        /// <summary>
        /// <para>合同结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2025-10-07</para>
        /// </summary>
        [JsonPropertyName("contract_end_date")]
        public string? ContractEndDate { get; set; }

        /// <summary>
        /// <para>入职日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-10-08</para>
        /// </summary>
        [JsonPropertyName("onboarding_date")]
        public string? OnboardingDate { get; set; }

        /// <summary>
        /// <para>入职地点 ID，详细信息可通过【批量查询地点】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924832</para>
        /// </summary>
        [JsonPropertyName("onboarding_location_id")]
        public string? OnboardingLocationId { get; set; }

        /// <summary>
        /// <para>办公地点 ID，详细信息可通过【批量查询地点】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977976687350924832</para>
        /// </summary>
        [JsonPropertyName("office_location_id")]
        public string? OfficeLocationId { get; set; }

        /// <summary>
        /// <para>招聘来源，枚举值 api_name 可通过【获取自定义字段详情】接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "pre_hire"</para>
        /// <para>- custom_api_name = "recruitment_type"</para>
        /// <para>必填：否</para>
        /// <para>示例值：experienced_professionals</para>
        /// </summary>
        [JsonPropertyName("recruitment_type_id")]
        public string? RecruitmentTypeId { get; set; }

        /// <summary>
        /// <para>试用期时长</para>
        /// <para>必填：否</para>
        /// <para>示例值：6</para>
        /// </summary>
        [JsonPropertyName("probation_period")]
        public string? ProbationPeriod { get; set; }

        /// <summary>
        /// <para>人员类型 ID，可以通过招聘【批量查询人员类型】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977973225846343171</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string? EmployeeTypeId { get; set; }

        /// <summary>
        /// <para>雇佣类型， 枚举值 api_name 可通过【获取自定义字段详情】接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "pre_hire"</para>
        /// <para>- custom_api_name = "employment_type"</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977973225846343171</para>
        /// </summary>
        [JsonPropertyName("employment_type_id")]
        public string? EmploymentTypeId { get; set; }

        /// <summary>
        /// <para>工作邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：joshua@bytedance.com</para>
        /// </summary>
        [JsonPropertyName("work_email")]
        public string? WorkEmail { get; set; }

        /// <summary>
        /// <para>期限类型，枚举值 api_name 可通过【获取自定义字段详情】接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "pre_hire"</para>
        /// <para>- custom_api_name = "duration_type"</para>
        /// <para>必填：否</para>
        /// <para>示例值：6977973225846343171</para>
        /// </summary>
        [JsonPropertyName("duration_type_id")]
        public string? DurationTypeId { get; set; }

        /// <summary>
        /// <para>签订类型，枚举值 api_name 可通过【获取自定义字段详情】接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "pre_hire"</para>
        /// <para>- custom_api_name = "signing_type"</para>
        /// <para>必填：否</para>
        /// <para>示例值：6738317738688661772</para>
        /// </summary>
        [JsonPropertyName("signing_type_id")]
        public string? SigningTypeId { get; set; }

        /// <summary>
        /// <para>入职方式，枚举值 api_name 可通过【获取自定义字段详情】接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "pre_hire"</para>
        /// <para>- custom_api_name = "onboarding_method"</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("entry_mode")]
        public string? EntryMode { get; set; }

        /// <summary>
        /// <para>社保城市 ID，详细信息可通过【批量查询地点】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx</para>
        /// </summary>
        [JsonPropertyName("social_security_city_id")]
        public string? SocialSecurityCityId { get; set; }

        /// <summary>
        /// <para>合同类型，枚举值 api_name 可通过【获取自定义字段详情】接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "pre_hire"</para>
        /// <para>- custom_api_name = "contract_type"</para>
        /// <para>必填：否</para>
        /// <para>示例值：6738317738688661772</para>
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string? ContractType { get; set; }

        /// <summary>
        /// <para>公司 ID，详细信息可通过【批量查询公司】接口获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6738317738688661772</para>
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// <para>成本中心分摊信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center_rate")]
        public JobDataCostCenter[]? CostCenterRates { get; set; }

        /// <summary>
        /// <para>成本中心分摊信息</para>
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
            /// <para>字段值，请转换为字符串数组的方式写入</para>
            /// <para>必填：是</para>
            /// <para>示例值：[\"Sandy\"]</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>教育经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("education_info")]
    public EducationInfo[]? EducationInfos { get; set; }

    /// <summary>
    /// <para>教育经历</para>
    /// </summary>
    public record EducationInfo
    {
        /// <summary>
        /// <para>学校名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：长安大学</para>
        /// </summary>
        [JsonPropertyName("school_name")]
        public string? SchoolName { get; set; }

        /// <summary>
        /// <para>学历</para>
        /// <para>必填：否</para>
        /// <para>示例值：phd</para>
        /// </summary>
        [JsonPropertyName("education")]
        public string? Education { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2017-04-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2018-04-01</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>专业</para>
        /// <para>必填：否</para>
        /// <para>示例值：医学影像技术</para>
        /// </summary>
        [JsonPropertyName("field_of_study")]
        public string? FieldOfStudy { get; set; }
    }

    /// <summary>
    /// <para>工作经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_experience")]
    public WorkExperience[]? WorkExperiences { get; set; }

    /// <summary>
    /// <para>工作经历</para>
    /// </summary>
    public record WorkExperience
    {
        /// <summary>
        /// <para>公司名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：猎豹</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2015-02-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2017-02-01</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>岗位</para>
        /// <para>必填：否</para>
        /// <para>示例值：产品经理</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// <para>工作描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：app</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// <para>招聘应用 ID，仅支持飞书招聘 ID，详细信息可以通过招聘【获取投递信息】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140946969586010376</para>
    /// </summary>
    [JsonPropertyName("ats_application_id")]
    public string? AtsApplicationId { get; set; }
}
