// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-04-18
// ************************************************************************
// <copyright file="GetHireV1OffersByOfferIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 Offer 详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取 Offer 详情 响应体
/// <para>根据 Offer ID 获取 Offer 详细信息。</para>
/// <para>接口ID：7036562575123873793</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fget</para>
/// </summary>
public record GetHireV1OffersByOfferIdResponseDto
{
    /// <summary>
    /// <para>Offer 详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offer")]
    public GetHireV1OffersByOfferIdResponseDtoOffer? Offer { get; set; }

    /// <summary>
    /// <para>Offer 详情</para>
    /// </summary>
    public record GetHireV1OffersByOfferIdResponseDtoOffer
    {
        /// <summary>
        /// <para>Offer ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1231231231231231</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递 ID，详情请查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：1231231232312312</para>
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
            /// <item>1：社招 Offer</item>
            /// <item>2：校招 Offer</item>
            /// <item>3：实习 Offer</item>
            /// <item>4：实习生转正 Offer</item>
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
            /// <para>Offer 过期时间，毫秒级时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1653383498000</para>
            /// </summary>
            [JsonPropertyName("expire_time")]
            public long? ExpireTime { get; set; }

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
                /// <para>人员类型 ID，与入参`employee_type_id_type` 类型一致</para>
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
            /// <para>创建时间，毫秒级时间戳</para>
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
            /// <para>入职日期，格式为YYYY-MM-DD</para>
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
            /// <para>合同期（年），推荐使用「contract_period」</para>
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
                /// <para>入职地点 ID，详情请参考：[获取地址列表](https://open.larkoffice.com/document/server-docs/hire-v1/recruitment-related-configuration/location/list)</para>
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
                    /// <para>地址类型，值固定为`4`：DISTRICT（区/县）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：4</para>
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
                    /// <para>地址类型，值固定为`3`：CITY（市）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：3</para>
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
                    /// <para>地址类型，值固定为`1`：COUNTRY（国家）</para>
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
                /// <para>自定义字段 ID，详情请参考：[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)</para>
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

            /// <summary>
            /// <para>人事侧的办公地点与地址（目前仅字节可用)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("work_location_address_info")]
            public MasterLocationAddressInfo? WorkLocationAddressInfo { get; set; }

            /// <summary>
            /// <para>人事侧的办公地点与地址（目前仅字节可用)</para>
            /// </summary>
            public record MasterLocationAddressInfo
            {
                /// <summary>
                /// <para>办公地点</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("location_info")]
                public MasterLocationInfo? LocationInfo { get; set; }

                /// <summary>
                /// <para>办公地点</para>
                /// </summary>
                public record MasterLocationInfo
                {
                    /// <summary>
                    /// <para>地点 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6930815272790114324</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>地点中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：北京</para>
                    /// </summary>
                    [JsonPropertyName("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>地点英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Beijing</para>
                    /// </summary>
                    [JsonPropertyName("en_name")]
                    public string? EnName { get; set; }
                }

                /// <summary>
                /// <para>办公地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("address_info")]
                public MasterLocationInfo? AddressInfo { get; set; }
            }

            /// <summary>
            /// <para>岗位 ID，可通过[查询岗位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)获取（仅限飞书人事租户使用，若链接无法打开，则说明飞书人事未启用岗位，请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)开通）</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("position_id")]
            public string? PositionId { get; set; }

            /// <summary>
            /// <para>入职职位</para>
            /// <para>必填：否</para>
            /// <para>示例值：入职职位</para>
            /// </summary>
            [JsonPropertyName("job_offered")]
            public string? JobOffered { get; set; }

            /// <summary>
            /// <para>职等 ID，可通过[查询职等](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query) 获取（仅限飞书人事租户使用）</para>
            /// <para>必填：否</para>
            /// <para>示例值：6897079709306259720</para>
            /// </summary>
            [JsonPropertyName("job_grade_id")]
            public string? JobGradeId { get; set; }

            /// <summary>
            /// <para>通用附件 ID 列表，可通过[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)接口获取附件的详细信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("common_attachment_id_list")]
            public string[]? CommonAttachmentIdList { get; set; }
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
            /// <para>基本薪资，为JSON 格式，amount 代表基本薪资的金额，peroid 代表基本薪资的周期单位，如：`{"amount":"10000","period":2}`。</para>
            /// <para>**peroid 可选值有:**</para>
            /// <para>- 1 : 日薪</para>
            /// <para>- 2 : 月薪</para>
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
            /// <para>季度奖金额，单位元、支持小数点后两位</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonPropertyName("quarterly_bonus")]
            public string? QuarterlyBonus { get; set; }

            /// <summary>
            /// <para>半年奖金额，单位元、支持小数点后两位</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonPropertyName("half_year_bonus")]
            public string? HalfYearBonus { get; set; }

            /// <summary>
            /// <para>年度现金总额(数量，非公式)，单位元、支持小数点后两位</para>
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
                /// <para>自定义字段 ID，详情请参考：[获取 Offer 申请表模版信息](https://open.larkoffice.com/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_application_form/get)</para>
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
        /// <para>当前 Offer 使用的 Schema</para>
        /// <para>必填：否</para>
        /// <para>示例值：6963562624677398823</para>
        /// </summary>
        [JsonPropertyName("schema_id")]
        public string? SchemaId { get; set; }

        /// <summary>
        /// <para>Offer 状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
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
        /// <para>Offer 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：正式 Offer</item>
        /// <item>2：实习 Offer</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("offer_type")]
        public int? OfferType { get; set; }

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
        /// <para>Offer 自定义模块列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_module_list")]
        public ApplicationOfferCustomModule[]? CustomizedModuleLists { get; set; }

        /// <summary>
        /// <para>Offer 自定义模块列表</para>
        /// </summary>
        public record ApplicationOfferCustomModule
        {
            /// <summary>
            /// <para>自定义模块 ID</para>
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
                /// <para>自定义字段 ID，详情请参考：[获取 Offer 申请表模版信息](https://open.larkoffice.com/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_application_form/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6930815272790114324</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 Value</para>
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

        /// <summary>
        /// <para>offer 发送记录列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("offer_send_record_list")]
        public OfferSendRecord[]? OfferSendRecordLists { get; set; }

        /// <summary>
        /// <para>offer 发送记录列表</para>
        /// </summary>
        public record OfferSendRecord
        {
            /// <summary>
            /// <para>offer 发送记录 id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1718959426734</para>
            /// </summary>
            [JsonPropertyName("offer_send_record_id")]
            public string? OfferSendRecordId { get; set; }

            /// <summary>
            /// <para>操作人 ID，与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
            /// </summary>
            [JsonPropertyName("operator_user_id")]
            public string? OperatorUserId { get; set; }

            /// <summary>
            /// <para>offer 发送时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1718959426734</para>
            /// </summary>
            [JsonPropertyName("send_time")]
            public string? SendTime { get; set; }

            /// <summary>
            /// <para>offer 状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：已创建</item>
            /// <item>2：已接受</item>
            /// <item>3：已拒绝</item>
            /// <item>4：已过期</item>
            /// <item>5：已作废</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("offer_letter_status")]
            public int? OfferLetterStatus { get; set; }

            /// <summary>
            /// <para>offer 邮件信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email_info")]
            public OfferEmailInfo? EmailInfo { get; set; }

            /// <summary>
            /// <para>offer 邮件信息</para>
            /// </summary>
            public record OfferEmailInfo
            {
                /// <summary>
                /// <para>抄送人邮件列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("cc_email_list")]
                public string[]? CcEmailList { get; set; }

                /// <summary>
                /// <para>接收人邮件列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("receiver_email_list")]
                public string[]? ReceiverEmailList { get; set; }

                /// <summary>
                /// <para>邮件内容</para>
                /// <para>必填：否</para>
                /// <para>示例值：This is a test email.</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }
            }

            /// <summary>
            /// <para>Offer 跟进记录</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("acceptance_list")]
            public Acceptance[]? AcceptanceLists { get; set; }

            /// <summary>
            /// <para>Offer 跟进记录</para>
            /// </summary>
            public record Acceptance
            {
                /// <summary>
                /// <para>操作类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：HR 操作</item>
                /// <item>2：候选人操作</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("operator_type")]
                public int? OperatorType { get; set; }

                /// <summary>
                /// <para>offer 接受或拒绝的结果</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：接受</item>
                /// <item>2：拒绝</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("conclusion")]
                public int? Conclusion { get; set; }

                /// <summary>
                /// <para>备注，如果是拒绝，则展示拒绝原因</para>
                /// <para>必填：否</para>
                /// <para>示例值：Abort</para>
                /// </summary>
                [JsonPropertyName("memo")]
                public string? Memo { get; set; }

                /// <summary>
                /// <para>操作时间，毫秒时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1718959426734</para>
                /// </summary>
                [JsonPropertyName("operate_time")]
                public string? OperateTime { get; set; }
            }

            /// <summary>
            /// <para>offer 文件列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("offer_file_list")]
            public OfferFile[]? OfferFileLists { get; set; }

            /// <summary>
            /// <para>offer 文件列表</para>
            /// </summary>
            public record OfferFile
            {
                /// <summary>
                /// <para>文件 id，可通过[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)接口获取，查询参数 type 传枚举值 3，通用附件</para>
                /// <para>必填：否</para>
                /// <para>示例值：12345678901</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>文件模板 id，暂无接口可通过该 ID 获取对应信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：1718959426734</para>
                /// </summary>
                [JsonPropertyName("file_template_id")]
                public string? FileTemplateId { get; set; }

                /// <summary>
                /// <para>文件模板名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：offer 文件</para>
                /// </summary>
                [JsonPropertyName("file_template_name")]
                public string? FileTemplateName { get; set; }

                /// <summary>
                /// <para>文件模板类型 id，暂无接口可通过该 ID 获取对应信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：1718959426734</para>
                /// </summary>
                [JsonPropertyName("file_template_type_id")]
                public string? FileTemplateTypeId { get; set; }

                /// <summary>
                /// <para>文件模板类型名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：offer 文件</para>
                /// </summary>
                [JsonPropertyName("file_template_type_name")]
                public string? FileTemplateTypeName { get; set; }
            }

            /// <summary>
            /// <para>offer 签署信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("offer_signature_info")]
            public OfferSendRecordOfferSignatureInfo? OfferSignatureInfo { get; set; }

            /// <summary>
            /// <para>offer 签署信息</para>
            /// </summary>
            public record OfferSendRecordOfferSignatureInfo
            {
                /// <summary>
                /// <para>电子签信息 id，暂无接口可通过该 ID 获取对应信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：1718959426734</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>电子签签署状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：未签署</item>
                /// <item>2：所有签署人已签署</item>
                /// <item>3：部分签署人已签署</item>
                /// <item>4：已拒绝</item>
                /// <item>5：已失效</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("signature_status")]
                public int? SignatureStatus { get; set; }

                /// <summary>
                /// <para>电子签附件列表</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("attachment_list")]
                public SignatureAttachment[]? AttachmentLists { get; set; }

                /// <summary>
                /// <para>电子签附件列表</para>
                /// </summary>
                public record SignatureAttachment
                {
                    /// <summary>
                    /// <para>文件 id，可通过[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)接口获取，查询参数 type 传枚举值 3，通用附件</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：12345678901</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>文件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：offer 文件</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>文件模板 id，暂无接口可通过该 ID 获取对应信息</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1718959426734</para>
                    /// </summary>
                    [JsonPropertyName("file_template_id")]
                    public string? FileTemplateId { get; set; }

                    /// <summary>
                    /// <para>文件模板名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：offer 文件</para>
                    /// </summary>
                    [JsonPropertyName("file_template_name")]
                    public string? FileTemplateName { get; set; }

                    /// <summary>
                    /// <para>文件模板类型 id，暂无接口可通过该 ID 获取对应信息</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1718959426734</para>
                    /// </summary>
                    [JsonPropertyName("file_template_type_id")]
                    public string? FileTemplateTypeId { get; set; }

                    /// <summary>
                    /// <para>文件模板类型名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：offer 文件</para>
                    /// </summary>
                    [JsonPropertyName("file_template_type_name")]
                    public string? FileTemplateTypeName { get; set; }
                }
            }
        }
    }
}
