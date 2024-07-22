// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建招聘官网投递 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 新建招聘官网投递 请求体
/// <para>新建招聘官网投递。</para>
/// <para>接口ID：6990661791098716163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_resume</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_resume</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeBodyDto
{
    /// <summary>
    /// <para>职位广告 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956636</para>
    /// </summary>
    [JsonPropertyName("job_post_id")]
    public string JobPostId { get; set; } = string.Empty;

    /// <summary>
    /// <para>人才信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("resume")]
    public WebsiteDeliveryResume Resume { get; set; } = new();

    /// <summary>
    /// <para>人才信息</para>
    /// </summary>
    public record WebsiteDeliveryResume
    {
        /// <summary>
        /// <para>实习经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("internship_list")]
        public WebsiteDeliveryInternship[]? InternshipLists { get; set; }

        /// <summary>
        /// <para>实习经历</para>
        /// </summary>
        public record WebsiteDeliveryInternship
        {
            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是一家创业公司，非常不错</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>结束时间, 如果是至今传值 -1</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278667</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609430400000</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：后端研发实习生</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>公司</para>
            /// <para>必填：否</para>
            /// <para>示例值：字节跳动</para>
            /// </summary>
            [JsonPropertyName("company")]
            public string? Company { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>基本信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("basic_info")]
        public WebsiteDeliveryBasicInfo BasicInfo { get; set; } = new();

        /// <summary>
        /// <para>基本信息</para>
        /// </summary>
        public record WebsiteDeliveryBasicInfo
        {
            /// <summary>
            /// <para>国籍，可从「获取地址码」查询</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_112</para>
            /// </summary>
            [JsonPropertyName("nationality_id")]
            public string? NationalityId { get; set; }

            /// <summary>
            /// <para>起始工作时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1625648596</para>
            /// </summary>
            [JsonPropertyName("start_work_time")]
            public int? StartWorkTime { get; set; }

            /// <summary>
            /// <para>家庭住址</para>
            /// <para>必填：否</para>
            /// <para>示例值：成都</para>
            /// </summary>
            [JsonPropertyName("current_home_address")]
            public string? CurrentHomeAddress { get; set; }

            /// <summary>
            /// <para>家乡，可从「获取地址码」查询</para>
            /// <para>必填：否</para>
            /// <para>示例值：CT_159</para>
            /// </summary>
            [JsonPropertyName("hometown_city_code")]
            public string? HometownCityCode { get; set; }

            /// <summary>
            /// <para>电话国际区号，可从「获取地址码」查询</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonPropertyName("mobile_country_code")]
            public string? MobileCountryCode { get; set; }

            /// <summary>
            /// <para>身份证件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("identification")]
            public WebsiteDeliveryIdentification? Identification { get; set; }

            /// <summary>
            /// <para>身份证件</para>
            /// </summary>
            public record WebsiteDeliveryIdentification
            {
                /// <summary>
                /// <para>身份证件号码</para>
                /// <para>必填：否</para>
                /// <para>示例值：11002030131312312</para>
                /// </summary>
                [JsonPropertyName("identification_number")]
                public string? IdentificationNumber { get; set; }

                /// <summary>
                /// <para>身份证件类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：中国 - 居民身份证</item>
                /// <item>2：护照</item>
                /// <item>3：中国 - 港澳居民居住证</item>
                /// <item>4：中国 - 台湾居民来往大陆通行证</item>
                /// <item>5：其他</item>
                /// <item>6：中国 - 港澳居民来往内地通行证</item>
                /// <item>9：中国 - 台湾居民居住证</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("identification_type")]
                public int? IdentificationType { get; set; }
            }

            /// <summary>
            /// <para>婚姻状况</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：已婚</item>
            /// <item>2：未婚</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("marital_status")]
            public int? MaritalStatus { get; set; }

            /// <summary>
            /// <para>电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：182900291190</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>所在城市，可从「获取地址码」查询</para>
            /// <para>必填：否</para>
            /// <para>示例值：CT_11</para>
            /// </summary>
            [JsonPropertyName("current_city_code")]
            public string? CurrentCityCode { get; set; }

            /// <summary>
            /// <para>工作年限</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonPropertyName("experience_years")]
            public int? ExperienceYears { get; set; }

            /// <summary>
            /// <para>性别</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：Male</item>
            /// <item>2：Female</item>
            /// <item>3：Other</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("gender")]
            public int? Gender { get; set; }

            /// <summary>
            /// <para>出生日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609430400000</para>
            /// </summary>
            [JsonPropertyName("birthday")]
            public int? Birthday { get; set; }

            /// <summary>
            /// <para>姓名</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>意向城市，可从「获取地址码」查询</para>
            /// <para>必填：否</para>
            /// <para>示例值：意向城市</para>
            /// </summary>
            [JsonPropertyName("preferred_city_code_list")]
            public string[]? PreferredCityCodeList { get; set; }

            /// <summary>
            /// <para>简历来源，可从「获取简历来源列表」查询</para>
            /// <para>必填：否</para>
            /// <para>示例值：6982104077248219436</para>
            /// </summary>
            [JsonPropertyName("resume_source_id")]
            public string? ResumeSourceId { get; set; }

            /// <summary>
            /// <para>年龄</para>
            /// <para>必填：否</para>
            /// <para>示例值：25</para>
            /// </summary>
            [JsonPropertyName("age")]
            public int? Age { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：foo@bytedance.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }
        }

        /// <summary>
        /// <para>教育经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("education_list")]
        public WebsiteDeliveryEducation[]? EducationLists { get; set; }

        /// <summary>
        /// <para>教育经历</para>
        /// </summary>
        public record WebsiteDeliveryEducation
        {
            /// <summary>
            /// <para>学历类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：非中国大陆</item>
            /// <item>2：统招全日制</item>
            /// <item>3：非全日制</item>
            /// <item>4：自考</item>
            /// <item>5：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("education_type")]
            public int? EducationType { get; set; }

            /// <summary>
            /// <para>结束时间 ,如果是至今传值 -1</para>
            /// <para>传输「至今」，投递进入系统后可正常查看字段，但进入编辑态后需要修改为一个具体时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>结束时间-新，无「至今」传值。</para>
            /// <para>建议使用此字段，避免模糊的毕业时间影响候选人筛选</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278663</para>
            /// </summary>
            [JsonPropertyName("end_time_v2")]
            public int? EndTimeV2 { get; set; }

            /// <summary>
            /// <para>专业</para>
            /// <para>必填：否</para>
            /// <para>示例值：汉语言文学</para>
            /// </summary>
            [JsonPropertyName("field_of_study")]
            public string? FieldOfStudy { get; set; }

            /// <summary>
            /// <para>学校</para>
            /// <para>必填：否</para>
            /// <para>示例值：香港中文大学</para>
            /// </summary>
            [JsonPropertyName("school")]
            public string? School { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609430400000</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>专业排名</para>
            /// <para>必填：否</para>
            /// <para>示例值：5</para>
            /// <para>可选值：<list type="bullet">
            /// <item>5：前 5 %</item>
            /// <item>10：前 10 %</item>
            /// <item>20：前 20 %</item>
            /// <item>30：前 30 %</item>
            /// <item>50：前 50 %</item>
            /// <item>51：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("academic_ranking")]
            public int? AcademicRanking { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>学位</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：小学</item>
            /// <item>2：初中</item>
            /// <item>3：专职</item>
            /// <item>4：高中</item>
            /// <item>5：大专</item>
            /// <item>6：本科</item>
            /// <item>7：硕士</item>
            /// <item>8：博士</item>
            /// <item>9：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("degree")]
            public int? Degree { get; set; }
        }

        /// <summary>
        /// <para>自我评价</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("self_evaluation")]
        public WebsiteDeliverySelfEvaluation? SelfEvaluation { get; set; }

        /// <summary>
        /// <para>自我评价</para>
        /// </summary>
        public record WebsiteDeliverySelfEvaluation
        {
            /// <summary>
            /// <para>内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：自我评价：平常心</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>工作经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("career_list")]
        public WebsiteDeliveryCareer[]? CareerLists { get; set; }

        /// <summary>
        /// <para>工作经历</para>
        /// </summary>
        public record WebsiteDeliveryCareer
        {
            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是一家创业公司，非常不错</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>结束时间, 如果是至今传值 -1</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278667</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609430400000</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：后端研发实习生</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>公司</para>
            /// <para>必填：否</para>
            /// <para>示例值：字节跳动</para>
            /// </summary>
            [JsonPropertyName("company")]
            public string? Company { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>自定义模块</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public WebsiteDeliveryCustomizedDataParent[]? CustomizedDatas { get; set; }

        /// <summary>
        /// <para>自定义模块</para>
        /// </summary>
        public record WebsiteDeliveryCustomizedDataParent
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956651</para>
            /// </summary>
            [JsonPropertyName("object_id")]
            public string? ObjectId { get; set; }

            /// <summary>
            /// <para>模块下的字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("children")]
            public WebsiteDeliveryCustomizedData[]? Childrens { get; set; }

            /// <summary>
            /// <para>模块下的字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>简历附件ID，使用「创建附件」生成</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956654</para>
        /// </summary>
        [JsonPropertyName("resume_attachment_id")]
        public string? ResumeAttachmentId { get; set; }

        /// <summary>
        /// <para>社交账号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sns_list")]
        public WebsiteDeliverySns[]? SnsLists { get; set; }

        /// <summary>
        /// <para>社交账号</para>
        /// </summary>
        public record WebsiteDeliverySns
        {
            /// <summary>
            /// <para>社交账号类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：领英</item>
            /// <item>2：脉脉</item>
            /// <item>3：微信</item>
            /// <item>4：微博</item>
            /// <item>5：Github</item>
            /// <item>6：知乎</item>
            /// <item>7：脸书</item>
            /// <item>8：推特</item>
            /// <item>9：Whatsapp</item>
            /// <item>10：个人网站</item>
            /// <item>11：QQ</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("sns_type")]
            public int? SnsType { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：toutiao.com</para>
            /// </summary>
            [JsonPropertyName("link")]
            public string? Link { get; set; }
        }

        /// <summary>
        /// <para>作品</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("works_list")]
        public WebsiteDeliveryWorks[]? WorksLists { get; set; }

        /// <summary>
        /// <para>作品</para>
        /// </summary>
        public record WebsiteDeliveryWorks
        {
            /// <summary>
            /// <para>作品描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：作品描述：xxxx</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>作品链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：www.toutiao.com</para>
            /// </summary>
            [JsonPropertyName("link")]
            public string? Link { get; set; }

            /// <summary>
            /// <para>附件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("attachment")]
            public WebsiteDeliveryWorksAttachment? Attachment { get; set; }

            /// <summary>
            /// <para>附件</para>
            /// </summary>
            public record WebsiteDeliveryWorksAttachment
            {
                /// <summary>
                /// <para>文件ID，使用「创建附件」生成</para>
                /// <para>必填：否</para>
                /// <para>示例值：6982104077248219436</para>
                /// </summary>
                [JsonPropertyName("file_id")]
                public string? FileId { get; set; }
            }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// <para>获奖记录</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("award_list")]
        public WebsiteDeliveryAward[]? AwardLists { get; set; }

        /// <summary>
        /// <para>获奖记录</para>
        /// </summary>
        public record WebsiteDeliveryAward
        {
            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：ACM国际大学生程序设计竞赛</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>奖项名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：ACM 亚洲区金牌</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>获奖时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609430400000</para>
            /// </summary>
            [JsonPropertyName("award_time")]
            public int? AwardTime { get; set; }
        }

        /// <summary>
        /// <para>项目经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("project_list")]
        public WebsiteDeliveryProject[]? ProjectLists { get; set; }

        /// <summary>
        /// <para>项目经历</para>
        /// </summary>
        public record WebsiteDeliveryProject
        {
            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：项目描述：xxxx</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>结束时间, 如果是至今传值-1</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618500278669</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>项目链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：www.toutiao.com</para>
            /// </summary>
            [JsonPropertyName("link")]
            public string? Link { get; set; }

            /// <summary>
            /// <para>项目名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：XXX项目重构</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：项目经理</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1609430400000</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public long? StartTime { get; set; }
        }

        /// <summary>
        /// <para>语言能力</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("language_list")]
        public WebsiteDeliveryLanguage[]? LanguageLists { get; set; }

        /// <summary>
        /// <para>语言能力</para>
        /// </summary>
        public record WebsiteDeliveryLanguage
        {
            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("customized_data")]
            public WebsiteDeliveryCustomizedData[]? CustomizedDatas { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record WebsiteDeliveryCustomizedData
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956649</para>
                /// </summary>
                [JsonPropertyName("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value，格式见接口说明</para>
                /// <para>必填：否</para>
                /// <para>示例值：AA</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>语言</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：英语</item>
            /// <item>2：法语</item>
            /// <item>3：日语</item>
            /// <item>4：韩语</item>
            /// <item>5：德语</item>
            /// <item>6：俄语</item>
            /// <item>7：西班牙语</item>
            /// <item>8：葡萄牙语</item>
            /// <item>9：阿拉伯语</item>
            /// <item>10：印地语</item>
            /// <item>11：印度斯坦语</item>
            /// <item>12：孟加拉语</item>
            /// <item>13：豪萨语</item>
            /// <item>14：旁遮普语</item>
            /// <item>15：波斯语</item>
            /// <item>16：斯瓦西里语</item>
            /// <item>17：泰卢固语</item>
            /// <item>18：土耳其语</item>
            /// <item>19：意大利语</item>
            /// <item>20：爪哇语</item>
            /// <item>21：泰米尔语</item>
            /// <item>22：马拉地语</item>
            /// <item>23：越南语</item>
            /// <item>24：普通话</item>
            /// <item>25：粤语</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("language")]
            public int? Language { get; set; }

            /// <summary>
            /// <para>熟悉程度</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：入门</item>
            /// <item>2：日常会话</item>
            /// <item>3：商务会话</item>
            /// <item>4：无障碍沟通</item>
            /// <item>5：母语</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("proficiency")]
            public int? Proficiency { get; set; }
        }
    }

    /// <summary>
    /// <para>官网用户 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956634</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>意向投递城市列表，可从「获取职位信息」返回的工作地点列表获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：CT_11</para>
    /// </summary>
    [JsonPropertyName("application_preferred_city_code_list")]
    public string[]? ApplicationPreferredCityCodeList { get; set; }

    /// <summary>
    /// <para>官网推广渠道 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6891560630172518670</para>
    /// </summary>
    [JsonPropertyName("channel_id")]
    public string? ChannelId { get; set; }
}
