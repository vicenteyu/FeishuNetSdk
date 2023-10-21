using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取内推官网下职位广告详情 响应体
/// <para>根据广告 ID 获取内推官网下的职位广告详情。</para>
/// <para>接口ID：7204730827112185860</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/referral/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2freferral_website-job_post%2fget</para>
/// </summary>
public record GetHireV1ReferralWebsitesJobPostsByJobPostIdResponseDto
{
    /// <summary>
    /// <para>职位广告信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("job_post")]
    public PortalJobPost? JobPost { get; set; }

    /// <summary>
    /// <para>职位广告信息</para>
    /// </summary>
    public record PortalJobPost
    {
        /// <summary>
        /// <para>职位广告 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1213213123123</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx</para>
        /// </summary>
        [JsonProperty("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职位编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：007</para>
        /// </summary>
        [JsonProperty("job_code")]
        public string? JobCode { get; set; }

        /// <summary>
        /// <para>职位过期时间，「null」代表「长期有效」</para>
        /// <para>必填：否</para>
        /// <para>示例值：1111</para>
        /// </summary>
        [JsonProperty("job_expire_time")]
        public string? JobExpireTime { get; set; }

        /// <summary>
        /// <para>职位状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：启用态</item>
        /// <item>2：禁用态</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("job_active_status")]
        public int? JobActiveStatus { get; set; }

        /// <summary>
        /// <para>职位流程类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：社招</item>
        /// <item>2：校招</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("job_process_type")]
        public int? JobProcessType { get; set; }

        /// <summary>
        /// <para>职位雇佣类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_recruitment_type")]
        public IdNameObject? JobRecruitmentType { get; set; }

        /// <summary>
        /// <para>职位雇佣类型</para>
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
        /// <para>职位部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_department")]
        public IdNameObject? JobDepartment { get; set; }

        /// <summary>
        /// <para>职位类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_type")]
        public IdNameObject? JobType { get; set; }

        /// <summary>
        /// <para>最低职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("min_job_level")]
        public IdNameObject? MinJobLevel { get; set; }

        /// <summary>
        /// <para>最高职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("max_job_level")]
        public IdNameObject? MaxJobLevel { get; set; }

        /// <summary>
        /// <para>职位地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("address")]
        public CommonAddress? Address { get; set; }

        /// <summary>
        /// <para>职位地址</para>
        /// </summary>
        public record CommonAddress
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6583482347283472832</para>
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

            /// <summary>
            /// <para>区域信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("district")]
            public CodeNameObject? District { get; set; }

            /// <summary>
            /// <para>区域信息</para>
            /// </summary>
            public record CodeNameObject
            {
                /// <summary>
                /// <para>编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：1111</para>
                /// </summary>
                [JsonProperty("code")]
                public string? Code { get; set; }

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
            /// <para>城市信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("city")]
            public CodeNameObject? City { get; set; }

            /// <summary>
            /// <para>省信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("state")]
            public CodeNameObject? State { get; set; }

            /// <summary>
            /// <para>国家信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("country")]
            public CodeNameObject? Country { get; set; }
        }

        /// <summary>
        /// <para>月薪范围-最低薪资</para>
        /// <para>必填：否</para>
        /// <para>示例值：5000</para>
        /// </summary>
        [JsonProperty("min_salary")]
        public string? MinSalary { get; set; }

        /// <summary>
        /// <para>月薪范围-最高薪资</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000</para>
        /// </summary>
        [JsonProperty("max_salary")]
        public string? MaxSalary { get; set; }

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
        /// <para>经验</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：不限</item>
        /// <item>2：应届毕业生</item>
        /// <item>3：1年以下</item>
        /// <item>4：1-3年</item>
        /// <item>5：3-5年</item>
        /// <item>6：5-7年</item>
        /// <item>7：7-10年</item>
        /// <item>8：10年以上</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("experience")]
        public int? Experience { get; set; }

        /// <summary>
        /// <para>数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonProperty("headcount")]
        public int? Headcount { get; set; }

        /// <summary>
        /// <para>职位亮点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("high_light_list")]
        public IdNameObject[]? HighLightLists { get; set; }

        /// <summary>
        /// <para>职位描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：负责软件开发</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>职位要求</para>
        /// <para>必填：否</para>
        /// <para>示例值：大专</para>
        /// </summary>
        [JsonProperty("requirement")]
        public string? Requirement { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("creator")]
        public IdNameObject? Creator { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1111</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>修改时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：222</para>
        /// </summary>
        [JsonProperty("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("customized_data_list")]
        public WebsiteJobPostCustomizedData[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record WebsiteJobPostCustomizedData
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
            /// </list></para>
            /// </summary>
            [JsonProperty("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("value")]
            public WebsiteJobPostCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record WebsiteJobPostCustomizedValue
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
                public WebsiteJobPostCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record WebsiteJobPostCustomizedOption
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
                public WebsiteJobPostCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("time_range")]
                public WebsiteJobPostCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record WebsiteJobPostCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
                    /// </summary>
                    [JsonProperty("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间</para>
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
        /// <para>职能分类</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_function")]
        public IdNameObject? JobFunction { get; set; }

        /// <summary>
        /// <para>职位项目</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("subject")]
        public IdNameObject? Subject { get; set; }

        /// <summary>
        /// <para>职位广告地址列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("address_list")]
        public CommonAddress[]? AddressLists { get; set; }
    }
}
