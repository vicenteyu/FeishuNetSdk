// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-11-27
// ************************************************************************
// <copyright file="PostHireV1JobRequirementsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建招聘需求 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建招聘需求 响应体
/// <para>创建招聘需求，可指定招聘需求部门、招聘人数、需求描述等，具体可参考「飞书招聘」-「设置」-「招聘需求字段管理」，或者参考[获取招聘需求模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement_schema/list)。</para>
/// <para>接口ID：6989078472837283843</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2fcreate</para>
/// </summary>
public record PostHireV1JobRequirementsResponseDto
{
    /// <summary>
    /// <para>招聘需求信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_requirement")]
    public JobRequirementDto? JobRequirement { get; set; }

    /// <summary>
    /// <para>招聘需求信息</para>
    /// </summary>
    public record JobRequirementDto
    {
        /// <summary>
        /// <para>招聘需求 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘需求编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：R01905</para>
        /// </summary>
        [JsonPropertyName("short_code")]
        public string? ShortCode { get; set; }

        /// <summary>
        /// <para>需求名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：HR部门春季招聘需求</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>需求状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未开始</item>
        /// <item>2：进行中</item>
        /// <item>3：已取消</item>
        /// <item>4：已暂停</item>
        /// <item>5：已完成</item>
        /// <item>6：已超期</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("display_progress")]
        public int? DisplayProgress { get; set; }

        /// <summary>
        /// <para>需求人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("head_count")]
        public int? HeadCount { get; set; }

        /// <summary>
        /// <para>职位性质 ，可在[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)文档中查看枚举值，建议使用`employee_type`字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recruitment_type")]
        public IdNameObject? RecruitmentType { get; set; }

        /// <summary>
        /// <para>职位性质 ，可在[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)文档中查看枚举值，建议使用`employee_type`字段</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>职位性质 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：101</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位性质名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>职位性质名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：社招-全职</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Social recruitment - Full time</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>人员类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public IdNameObject? EmployeeType { get; set; }

        /// <summary>
        /// <para>最高职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("max_level")]
        public IdNameObject? MaxLevel { get; set; }

        /// <summary>
        /// <para>最低职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("min_level")]
        public IdNameObject? MinLevel { get; set; }

        /// <summary>
        /// <para>职位序列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sequence")]
        public IdNameObject? Sequence { get; set; }

        /// <summary>
        /// <para>需求类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：新增</item>
        /// <item>2：替换</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("category")]
        public int? Category { get; set; }

        /// <summary>
        /// <para>需求部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public IdNameObject? Department { get; set; }

        /// <summary>
        /// <para>需求负责人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recruiter_list")]
        public IdNameObject[]? RecruiterLists { get; set; }

        /// <summary>
        /// <para>需求用人经理</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("jr_hiring_managers")]
        public IdNameObject[]? JrHiringManagers { get; set; }

        /// <summary>
        /// <para>直属上级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("direct_leader_list")]
        public IdNameObject[]? DirectLeaderLists { get; set; }

        /// <summary>
        /// <para>开始日期，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625729379000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>预计完成日期，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625729379000</para>
        /// </summary>
        [JsonPropertyName("deadline")]
        public string? Deadline { get; set; }

        /// <summary>
        /// <para>招聘优先级</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：高</item>
        /// <item>2：中</item>
        /// <item>3：低</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>学历要求</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：小学及以上</item>
        /// <item>2：初中及以上</item>
        /// <item>3：专职及以上</item>
        /// <item>4：高中及以上</item>
        /// <item>5：大专及以上</item>
        /// <item>6：本科及以上</item>
        /// <item>7：硕士及以上</item>
        /// <item>8：博士及以上</item>
        /// <item>20：不限</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("required_degree")]
        public int? RequiredDegree { get; set; }

        /// <summary>
        /// <para>最高月薪，单位：K</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("max_salary")]
        public string? MaxSalary { get; set; }

        /// <summary>
        /// <para>最低月薪，单位：K</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonPropertyName("min_salary")]
        public string? MinSalary { get; set; }

        /// <summary>
        /// <para>工作地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address")]
        public IdNameObject? Address { get; set; }

        /// <summary>
        /// <para>需求描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：部门人力紧缺，需要招聘资深工程师10名</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public JobRequirementCustomizedDataDto[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record JobRequirementCustomizedDataDto
        {
            /// <summary>
            /// <para>自定义字段 ID，详情请参考：[获取招聘需求模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement_schema/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：123123123</para>
            /// </summary>
            [JsonPropertyName("object_id")]
            public string? ObjectId { get; set; }

            /// <summary>
            /// <para>字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>字段名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：招聘原因</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Recruitment reason</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：单行文本</item>
            /// <item>2：多行文本</item>
            /// <item>3：单选</item>
            /// <item>4：多选</item>
            /// <item>5：日期</item>
            /// <item>6：月份选择</item>
            /// <item>7：年份选择</item>
            /// <item>8：时间段</item>
            /// <item>9：数字</item>
            /// <item>10：默认字段</item>
            /// <item>11：模块</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public JobRequirementCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record JobRequirementCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：人员紧缺程度</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public JobRequirementCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record JobRequirementCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：serious</para>
                    /// </summary>
                    [JsonPropertyName("key")]
                    public string? Key { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：严重</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：serious</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>当字段类型为多选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option_list")]
                public JobRequirementCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public JobRequirementCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record JobRequirementCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，毫秒时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625729379000</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，毫秒时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625729380000</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是毫秒时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721000</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }
            }
        }

        /// <summary>
        /// <para>招聘类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招</item>
        /// <item>2：校招</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("process_type")]
        public int? ProcessType { get; set; }

        /// <summary>
        /// <para>职位类别</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_type")]
        public JobTypeInfo? JobType { get; set; }

        /// <summary>
        /// <para>职位类别</para>
        /// </summary>
        public record JobTypeInfo
        {
            /// <summary>
            /// <para>职位类别 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>职位类别名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n Name { get; set; } = new();

            /// <summary>
            /// <para>职位类别名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：金融</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：finance</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>父级职位类别 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114323</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string? ParentId { get; set; }
        }

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1718856006000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>创建人 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_e2fc714c4727ee9395f324cd2e7f331f</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1718856006000</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>职务ID，详情请查看：[查询单个职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381831949</para>
        /// </summary>
        [JsonPropertyName("employment_job_id")]
        public string? EmploymentJobId { get; set; }

        /// <summary>
        /// <para>岗位ID，详情请查看：[查询岗位信息](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7094136522860922111</para>
        /// </summary>
        [JsonPropertyName("position_id")]
        public string? PositionId { get; set; }
    }
}
