using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘需求列表 响应体
/// <para>获取招聘需求列表。</para>
/// <para>接口ID：6989078472837218307</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2flist</para>
/// </summary>
public record GetHireV1JobRequirementsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>查询的招聘需求信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public JobRequirementDto[]? Items { get; set; }

    /// <summary>
    /// <para>查询的招聘需求信息</para>
    /// </summary>
    public record JobRequirementDto
    {
        /// <summary>
        /// <para>招聘需求 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘需求编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：xx1</para>
        /// </summary>
        [JsonProperty("short_code")]
        public string? ShortCode { get; set; }

        /// <summary>
        /// <para>需求名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：test</para>
        /// </summary>
        [JsonProperty("name")]
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
        [JsonProperty("display_progress")]
        public int? DisplayProgress { get; set; }

        /// <summary>
        /// <para>需求人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：11</para>
        /// </summary>
        [JsonProperty("head_count")]
        public int? HeadCount { get; set; }

        /// <summary>
        /// <para>职位性质 ，可在「招聘枚举常量」文档中查看枚举值，推荐使用「employee_type」字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("recruitment_type")]
        public IdNameObject? RecruitmentType { get; set; }

        /// <summary>
        /// <para>职位性质 ，可在「招聘枚举常量」文档中查看枚举值，推荐使用「employee_type」字段</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonProperty("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonProperty("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>人员类型，通过[「获取员工类型列表」](https://open.feishu.cn/document/server-docs/people_admin-v1/employee_type/list)接口获取详情。使用前请咨询招聘团队，确保已经在相关的灰度内</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("employee_type")]
        public IdNameObject? EmployeeType { get; set; }

        /// <summary>
        /// <para>最高职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("max_level")]
        public IdNameObject? MaxLevel { get; set; }

        /// <summary>
        /// <para>最低职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("min_level")]
        public IdNameObject? MinLevel { get; set; }

        /// <summary>
        /// <para>职位序列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sequence")]
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
        [JsonProperty("category")]
        public int? Category { get; set; }

        /// <summary>
        /// <para>需求部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("department")]
        public IdNameObject? Department { get; set; }

        /// <summary>
        /// <para>需求负责人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("recruiter_list")]
        public IdNameObject[]? RecruiterLists { get; set; }

        /// <summary>
        /// <para>需求用人经理</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("jr_hiring_managers")]
        public IdNameObject[]? JrHiringManagers { get; set; }

        /// <summary>
        /// <para>直属上级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("direct_leader_list")]
        public IdNameObject[]? DirectLeaderLists { get; set; }

        /// <summary>
        /// <para>开始日期，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625729379000</para>
        /// </summary>
        [JsonProperty("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>预计完成日期，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625729379000</para>
        /// </summary>
        [JsonProperty("deadline")]
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
        [JsonProperty("priority")]
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
        [JsonProperty("required_degree")]
        public int? RequiredDegree { get; set; }

        /// <summary>
        /// <para>最高薪资</para>
        /// <para>必填：否</para>
        /// <para>示例值：123</para>
        /// </summary>
        [JsonProperty("max_salary")]
        public string? MaxSalary { get; set; }

        /// <summary>
        /// <para>最低薪资</para>
        /// <para>必填：否</para>
        /// <para>示例值：11</para>
        /// </summary>
        [JsonProperty("min_salary")]
        public string? MinSalary { get; set; }

        /// <summary>
        /// <para>工作地点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("address")]
        public IdNameObject? Address { get; set; }

        /// <summary>
        /// <para>需求描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：11</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("customized_data_list")]
        public JobRequirementCustomizedDataDto[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record JobRequirementCustomizedDataDto
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
            /// </summary>
            [JsonProperty("object_id")]
            public string? ObjectId { get; set; }

            /// <summary>
            /// <para>字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>字段名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonProperty("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonProperty("en_us")]
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
            [JsonProperty("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("value")]
            public JobRequirementCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record JobRequirementCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonProperty("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("option")]
                public JobRequirementCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record JobRequirementCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
                    /// </summary>
                    [JsonProperty("key")]
                    public string? Key { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonProperty("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
                        /// </summary>
                        [JsonProperty("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>当字段类型为多选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("option_list")]
                public JobRequirementCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("time_range")]
                public JobRequirementCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record JobRequirementCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，毫秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
                    /// </summary>
                    [JsonProperty("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，毫秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
                    /// </summary>
                    [JsonProperty("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是毫秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721000</para>
                /// </summary>
                [JsonProperty("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonProperty("number")]
                public string? Number { get; set; }
            }
        }

        /// <summary>
        /// <para>关联职位 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_id_list")]
        public string[]? JobIdList { get; set; }

        /// <summary>
        /// <para>招聘需求支持的招聘类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招</item>
        /// <item>2：校招</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("process_type")]
        public int? ProcessType { get; set; }

        /// <summary>
        /// <para>职位类别</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_type")]
        public JobTypeInfo? JobType { get; set; }

        /// <summary>
        /// <para>职位类别</para>
        /// </summary>
        public record JobTypeInfo
        {
            /// <summary>
            /// <para>职位类别ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonProperty("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>职位类别名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("name")]
            public I18n Name { get; set; } = new();

            /// <summary>
            /// <para>职位类别名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>职位类别中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：金融</para>
                /// </summary>
                [JsonProperty("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>职位类别英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：finance</para>
                /// </summary>
                [JsonProperty("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>父级职位类别ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114323</para>
            /// </summary>
            [JsonProperty("parent_id")]
            public string? ParentId { get; set; }
        }
    }
}
