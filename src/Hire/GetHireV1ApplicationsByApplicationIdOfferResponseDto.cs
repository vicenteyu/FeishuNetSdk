// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1ApplicationsByApplicationIdOfferResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 Offer 信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取 Offer 信息 响应体
/// <para>根据投递 ID 获取 Offer 信息。</para>
/// <para>接口ID：6964286393804914716</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/offer</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2foffer</para>
/// </summary>
public record GetHireV1ApplicationsByApplicationIdOfferResponseDto
{
    /// <summary>
    /// <para>Offer数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offer")]
    public ApplicationOffer? Offer { get; set; }

    /// <summary>
    /// <para>Offer数据</para>
    /// </summary>
    public record ApplicationOffer
    {
        /// <summary>
        /// <para>Offer ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7057802493489285412</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7020661401874614564</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>基础信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("basic_info")]
        public ApplicationOfferBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// <para>基础信息</para>
        /// </summary>
        public record ApplicationOfferBasicInfo
        {
            /// <summary>
            /// <para>Offer 类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：社招offer</item>
            /// <item>2：校招offer</item>
            /// <item>3：实习offer</item>
            /// <item>4：实习生转正offer</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("offer_type")]
            public int? OfferType { get; set; }

            /// <summary>
            /// <para>备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>Offer 过期时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1653383498000</para>
            /// </summary>
            [JsonPropertyName("expire_time")]
            public int? ExpireTime { get; set; }

            /// <summary>
            /// <para>Offer 负责人 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99be8e24ad1ad390b6cd3b8916940df1</para>
            /// </summary>
            [JsonPropertyName("owner_user_id")]
            public string? OwnerUserId { get; set; }

            /// <summary>
            /// <para>Offer 创建人 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99be8e24ad1ad390b6cd3b8916940df1</para>
            /// </summary>
            [JsonPropertyName("creator_user_id")]
            public string? CreatorUserId { get; set; }

            /// <summary>
            /// <para>Offer 人员类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employee_type")]
            public BaseBilingualWithId? EmployeeType { get; set; }

            /// <summary>
            /// <para>Offer 人员类型</para>
            /// </summary>
            public record BaseBilingualWithId
            {
                /// <summary>
                /// <para>人员类型 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>人员类型中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：正式</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>人员类型英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Regular</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }
            }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1628512038000</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>直属上级 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99be8e24ad1ad390b6cd3b8916940df1</para>
            /// </summary>
            [JsonPropertyName("leader_user_id")]
            public string? LeaderUserId { get; set; }

            /// <summary>
            /// <para>入职日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-05-20</para>
            /// </summary>
            [JsonPropertyName("onboard_date")]
            public string? OnboardDate { get; set; }

            /// <summary>
            /// <para>入职部门，与入参中的`department_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-6b394871807047c7023ebfc1ff37cd3a</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>试用期, 比如试用期6个月</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("probation_month")]
            public int? ProbationMonth { get; set; }

            /// <summary>
            /// <para>合同期(年)，推荐使用「contract_period」，如果Offer申请表中「合同期(年)」字段已停用，则不可使用该字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonPropertyName("contract_year")]
            public int? ContractYear { get; set; }

            /// <summary>
            /// <para>合同期（年/月）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("contract_period")]
            public ContractPeriodInfo? ContractPeriod { get; set; }

            /// <summary>
            /// <para>合同期（年/月）</para>
            /// </summary>
            public record ContractPeriodInfo
            {
                /// <summary>
                /// <para>合同周期类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：月</item>
                /// <item>2：年</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("period_type")]
                public int PeriodType { get; set; }

                /// <summary>
                /// <para>合同时长</para>
                /// <para>必填：是</para>
                /// <para>示例值：3</para>
                /// <para>最大值：100</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("period")]
                public int Period { get; set; }
            }

            /// <summary>
            /// <para>雇员类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("recruitment_type")]
            public BaseBilingualWithId? RecruitmentType { get; set; }

            /// <summary>
            /// <para>序列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sequence")]
            public BaseBilingualWithId? Sequence { get; set; }

            /// <summary>
            /// <para>级别</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("level")]
            public BaseBilingualWithId? Level { get; set; }

            /// <summary>
            /// <para>入职地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("onboard_address")]
            public BaseAddress? OnboardAddress { get; set; }

            /// <summary>
            /// <para>入职地点</para>
            /// </summary>
            public record BaseAddress
            {
                /// <summary>
                /// <para>入职地点 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6932753007915206919</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>入职地点中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：名字</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>入职地点英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>区域信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("district")]
                public BaseDistrict? District { get; set; }

                /// <summary>
                /// <para>区域信息</para>
                /// </summary>
                public record BaseDistrict
                {
                    /// <summary>
                    /// <para>区域中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：伦敦</para>
                    /// </summary>
                    [JsonPropertyName("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>区域英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：London</para>
                    /// </summary>
                    [JsonPropertyName("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>区域编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：400700</para>
                    /// </summary>
                    [JsonPropertyName("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>地址类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("location_type")]
                    public int? LocationType { get; set; }
                }

                /// <summary>
                /// <para>城市信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("city")]
                public BaseCity? City { get; set; }

                /// <summary>
                /// <para>城市信息</para>
                /// </summary>
                public record BaseCity
                {
                    /// <summary>
                    /// <para>城市中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中文</para>
                    /// </summary>
                    [JsonPropertyName("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>城市英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：eng</para>
                    /// </summary>
                    [JsonPropertyName("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>城市编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：400700</para>
                    /// </summary>
                    [JsonPropertyName("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>地址类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：COUNTRY（国家）</item>
                    /// <item>2：STATE（省份/州）</item>
                    /// <item>3：CITY（市）</item>
                    /// <item>4：DISTRICT（区/县）</item>
                    /// <item>5：ADDRESS（地址）</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("location_type")]
                    public int? LocationType { get; set; }
                }

                /// <summary>
                /// <para>省信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("state")]
                public BaseCity? State { get; set; }

                /// <summary>
                /// <para>国家信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("country")]
                public BaseCountry? Country { get; set; }

                /// <summary>
                /// <para>国家信息</para>
                /// </summary>
                public record BaseCountry
                {
                    /// <summary>
                    /// <para>国家中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中文</para>
                    /// </summary>
                    [JsonPropertyName("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>国家英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：eng</para>
                    /// </summary>
                    [JsonPropertyName("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>国家编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：400700</para>
                    /// </summary>
                    [JsonPropertyName("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>地址类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：COUNTRY（国家）</item>
                    /// <item>2：STATE（省份/州）</item>
                    /// <item>3：CITY（市）</item>
                    /// <item>4：DISTRICT（区/县）</item>
                    /// <item>5：ADDRESS（地址）</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("location_type")]
                    public int? LocationType { get; set; }
                }
            }

            /// <summary>
            /// <para>工作地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_address")]
            public BaseAddress? WorkAddress { get; set; }

            /// <summary>
            /// <para>自定义字段信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customize_info_list")]
            public ApplicationOfferCustomValue[]? CustomizeInfoLists { get; set; }

            /// <summary>
            /// <para>自定义字段信息</para>
            /// </summary>
            public record ApplicationOfferCustomValue
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：key</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value</para>
                /// <para>必填：否</para>
                /// <para>示例值：value</para>
                /// </summary>
                [JsonPropertyName("customize_value")]
                public string? CustomizeValue { get; set; }
            }
        }

        /// <summary>
        /// <para>薪酬计划</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("salary_plan")]
        public ApplicationOfferSalaryPlan? SalaryPlan { get; set; }

        /// <summary>
        /// <para>薪酬计划</para>
        /// </summary>
        public record ApplicationOfferSalaryPlan
        {
            /// <summary>
            /// <para>币种</para>
            /// <para>必填：否</para>
            /// <para>示例值：CNY</para>
            /// </summary>
            [JsonPropertyName("currency")]
            public string? Currency { get; set; }

            /// <summary>
            /// <para>基本薪资，为JSON 格式，amount 代表基本薪资的金额，peroid 代表基本薪资的周期单位，如：`"{\"amount\":\"10000\","\period\":2}"`</para>
            /// <para>必填：否</para>
            /// <para>示例值：{\"amount\":\"10000\",\"period\":2}</para>
            /// </summary>
            [JsonPropertyName("basic_salary")]
            public string? BasicSalary { get; set; }

            /// <summary>
            /// <para>试用期百分比</para>
            /// <para>必填：否</para>
            /// <para>示例值：10%</para>
            /// </summary>
            [JsonPropertyName("probation_salary_percentage")]
            public string? ProbationSalaryPercentage { get; set; }

            /// <summary>
            /// <para>年终奖月数</para>
            /// <para>必填：否</para>
            /// <para>示例值：12</para>
            /// </summary>
            [JsonPropertyName("award_salary_multiple")]
            public string? AwardSalaryMultiple { get; set; }

            /// <summary>
            /// <para>期权股数</para>
            /// <para>必填：否</para>
            /// <para>示例值：11</para>
            /// </summary>
            [JsonPropertyName("option_shares")]
            public string? OptionShares { get; set; }

            /// <summary>
            /// <para>季度奖金额</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonPropertyName("quarterly_bonus")]
            public string? QuarterlyBonus { get; set; }

            /// <summary>
            /// <para>半年奖金额</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonPropertyName("half_year_bonus")]
            public string? HalfYearBonus { get; set; }

            /// <summary>
            /// <para>年度现金总额(数量，非公式)</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonPropertyName("total_annual_cash")]
            public string? TotalAnnualCash { get; set; }

            /// <summary>
            /// <para>自定义字段的 value 信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customize_info_list")]
            public ApplicationOfferCustomValue[]? CustomizeInfoLists { get; set; }

            /// <summary>
            /// <para>自定义字段的 value 信息</para>
            /// </summary>
            public record ApplicationOfferCustomValue
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：key</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value</para>
                /// <para>必填：否</para>
                /// <para>示例值：value</para>
                /// </summary>
                [JsonPropertyName("customize_value")]
                public string? CustomizeValue { get; set; }
            }
        }

        /// <summary>
        /// <para>当前 Offer 使用的 schema</para>
        /// <para>必填：否</para>
        /// <para>示例值：6963562624677398823</para>
        /// </summary>
        [JsonPropertyName("schema_id")]
        public string? SchemaId { get; set; }

        /// <summary>
        /// <para>Offer 状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：所有</item>
        /// <item>1：未申请</item>
        /// <item>2：审批中</item>
        /// <item>3：审批已撤回</item>
        /// <item>4：审批通过</item>
        /// <item>5：审批不通过</item>
        /// <item>6：Offer 已发出</item>
        /// <item>7：候选人已接受</item>
        /// <item>8：候选人已拒绝</item>
        /// <item>9：Offer 已失效</item>
        /// <item>10：未审批</item>
        /// <item>11：实习待入职（仅实习 Offer 具有）</item>
        /// <item>12：实习已入职（仅实习 Offer 具有）</item>
        /// <item>13：实习已离职（仅实习 Offer 具有）</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("offer_status")]
        public int? OfferStatus { get; set; }

        /// <summary>
        /// <para>职位信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_info")]
        public OfferJobInfo? JobInfo { get; set; }

        /// <summary>
        /// <para>职位信息</para>
        /// </summary>
        public record OfferJobInfo
        {
            /// <summary>
            /// <para>Offer 职位 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7080891505426925854</para>
            /// </summary>
            [JsonPropertyName("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>Offer 职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx</para>
            /// </summary>
            [JsonPropertyName("job_name")]
            public string? JobName { get; set; }
        }

        /// <summary>
        /// <para>offer自定义模块列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_module_list")]
        public ApplicationOfferCustomModule[]? CustomizedModuleLists { get; set; }

        /// <summary>
        /// <para>offer自定义模块列表</para>
        /// </summary>
        public record ApplicationOfferCustomModule
        {
            /// <summary>
            /// <para>自定义模块ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? ID { get; set; }

            /// <summary>
            /// <para>自定义模块下字段的值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_list")]
            public ApplicationOfferCustomValue[]? ObjectLists { get; set; }

            /// <summary>
            /// <para>自定义模块下字段的值</para>
            /// </summary>
            public record ApplicationOfferCustomValue
            {
                /// <summary>
                /// <para>自定义字段ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6930815272790114324</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段Value</para>
                /// <para>必填：否</para>
                /// <para>示例值：value</para>
                /// </summary>
                [JsonPropertyName("customize_value")]
                public string? CustomizeValue { get; set; }
            }
        }

        /// <summary>
        /// <para>招聘需求ID，详情请查看：[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1231231232312312</para>
        /// </summary>
        [JsonPropertyName("job_requirement_id")]
        public string? JobRequirementId { get; set; }
    }
}
