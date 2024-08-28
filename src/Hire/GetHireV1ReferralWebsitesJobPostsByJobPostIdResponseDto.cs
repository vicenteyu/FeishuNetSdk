// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1ReferralWebsitesJobPostsByJobPostIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取内推官网下职位广告详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取内推官网下职位广告详情 响应体
/// <para>根据职位广告 ID 获取内推官网下的职位广告详情，包含职位广告 ID 以及职位信息等。</para>
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
    [JsonPropertyName("job_post")]
    public PortalJobPost? JobPost { get; set; }

    /// <summary>
    /// <para>职位广告信息</para>
    /// </summary>
    public record PortalJobPost
    {
        /// <summary>
        /// <para>职位广告 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7174316547413000195</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职位名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级工程师招聘</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7392894182636030258</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职位编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：A168688</para>
        /// </summary>
        [JsonPropertyName("job_code")]
        public string? JobCode { get; set; }

        /// <summary>
        /// <para>职位到期时间，毫秒时间戳，空代表「长期有效」</para>
        /// <para>必填：否</para>
        /// <para>示例值：1722837278000</para>
        /// </summary>
        [JsonPropertyName("job_expire_time")]
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
        [JsonPropertyName("job_active_status")]
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
        [JsonPropertyName("job_process_type")]
        public int? JobProcessType { get; set; }

        /// <summary>
        /// <para>雇佣类型，请参考[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_recruitment_type")]
        public IdNameObject? JobRecruitmentType { get; set; }

        /// <summary>
        /// <para>雇佣类型，请参考[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>雇佣类型ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：101</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>雇佣类型名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>雇佣类型名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：全职</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Full-time</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }

        /// <summary>
        /// <para>部门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_department")]
        public IdNameObject? JobDepartment { get; set; }

        /// <summary>
        /// <para>职位类别</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_type")]
        public IdNameObject? JobType { get; set; }

        /// <summary>
        /// <para>最低职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("min_job_level")]
        public IdNameObject? MinJobLevel { get; set; }

        /// <summary>
        /// <para>最高职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("max_job_level")]
        public IdNameObject? MaxJobLevel { get; set; }

        /// <summary>
        /// <para>职位地址，废弃字段，请使用`address_list`字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address")]
        public CommonAddress? Address { get; set; }

        /// <summary>
        /// <para>职位地址，废弃字段，请使用`address_list`字段</para>
        /// </summary>
        public record CommonAddress
        {
            /// <summary>
            /// <para>职位地址ID，详情请参考：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6583482347283472832</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位地址名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>职位地址名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：抖音大厦</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Douyin Building</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>区域信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("district")]
            public CodeNameObject? District { get; set; }

            /// <summary>
            /// <para>区域信息</para>
            /// </summary>
            public record CodeNameObject
            {
                /// <summary>
                /// <para>区域编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：DS_1000002</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>区域名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>区域名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：大观区</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Daguan</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>城市信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("city")]
            public CodeNameObject? City { get; set; }

            /// <summary>
            /// <para>省份信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("state")]
            public CodeNameObject? State { get; set; }

            /// <summary>
            /// <para>国家信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("country")]
            public CodeNameObject? Country { get; set; }
        }

        /// <summary>
        /// <para>月薪范围-最低薪资，单位：K，精度：整数</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonPropertyName("min_salary")]
        public string? MinSalary { get; set; }

        /// <summary>
        /// <para>月薪范围-最高薪资，单位：K，精度：整数</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// </summary>
        [JsonPropertyName("max_salary")]
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
        [JsonPropertyName("required_degree")]
        public int? RequiredDegree { get; set; }

        /// <summary>
        /// <para>工作经验</para>
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
        [JsonPropertyName("experience")]
        public int? Experience { get; set; }

        /// <summary>
        /// <para>招聘数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("headcount")]
        public int? Headcount { get; set; }

        /// <summary>
        /// <para>职位亮点列表，详情请参考：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("high_light_list")]
        public IdNameObject[]? HighLightLists { get; set; }

        /// <summary>
        /// <para>职位描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：负责软件开发</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>职位要求</para>
        /// <para>必填：否</para>
        /// <para>示例值：有相关经验者优先</para>
        /// </summary>
        [JsonPropertyName("requirement")]
        public string? Requirement { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("creator")]
        public IdNameObject? Creator { get; set; }

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1716791547691</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>修改时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1716791547691</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>自定义字段列表，详情可参考：[获取职位模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_schema/list)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public WebsiteJobPostCustomizedData[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段列表，详情可参考：[获取职位模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_schema/list)</para>
        /// </summary>
        public record WebsiteJobPostCustomizedData
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7368811146881091852</para>
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
                /// <para>示例值：集团数字化</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：group digitization</para>
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
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public WebsiteJobPostCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record WebsiteJobPostCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：集团数字化是大方向</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public WebsiteJobPostCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record WebsiteJobPostCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
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
                        /// <para>示例值：支持</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：support</para>
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
                public WebsiteJobPostCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public WebsiteJobPostCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record WebsiteJobPostCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，毫秒时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1716791547691</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，毫秒时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1716891547691</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是毫秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721000</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：88</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }
            }
        }

        /// <summary>
        /// <para>职能分类</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_function")]
        public IdNameObject? JobFunction { get; set; }

        /// <summary>
        /// <para>项目</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("subject")]
        public IdNameObject? Subject { get; set; }

        /// <summary>
        /// <para>职位地址列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("address_list")]
        public CommonAddress[]? AddressLists { get; set; }
    }
}
