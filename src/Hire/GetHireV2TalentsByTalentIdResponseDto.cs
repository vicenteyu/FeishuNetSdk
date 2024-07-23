// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="GetHireV2TalentsByTalentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取人才信息 V2 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才信息 V2 响应体
/// <para>根据人才 ID 获取人才信息。</para>
/// <para>接口ID：7177216475677474820</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhire-v2%2ftalent%2fget</para>
/// </summary>
public record GetHireV2TalentsByTalentIdResponseDto
{
    /// <summary>
    /// <para>ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6761694410053798151</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }

    /// <summary>
    /// <para>基础信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("basic_info")]
    public CompositeTalentBasicInfo? BasicInfo { get; set; }

    /// <summary>
    /// <para>基础信息</para>
    /// </summary>
    public record CompositeTalentBasicInfo
    {
        /// <summary>
        /// <para>名字</para>
        /// <para>必填：是</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>手机</para>
        /// <para>必填：否</para>
        /// <para>示例值：18312341234</para>
        /// </summary>
        [JsonPropertyName("mobile_number")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// <para>手机国家区号</para>
        /// <para>必填：否</para>
        /// <para>示例值：86</para>
        /// </summary>
        [JsonPropertyName("mobile_code")]
        public string? MobileCode { get; set; }

        /// <summary>
        /// <para>邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：16xx1@126.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>工作年限</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonPropertyName("experience_years")]
        public int? ExperienceYears { get; set; }

        /// <summary>
        /// <para>年龄</para>
        /// <para>必填：否</para>
        /// <para>示例值：22</para>
        /// </summary>
        [JsonPropertyName("age")]
        public int? Age { get; set; }

        /// <summary>
        /// <para>国籍</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN</para>
        /// </summary>
        [JsonPropertyName("nationality_code")]
        public string? NationalityCode { get; set; }

        /// <summary>
        /// <para>性别</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：男</item>
        /// <item>2：女</item>
        /// <item>3：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// <para>所在地点</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_2</para>
        /// </summary>
        [JsonPropertyName("current_location_code")]
        public string? CurrentLocationCode { get; set; }

        /// <summary>
        /// <para>家乡</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_3</para>
        /// </summary>
        [JsonPropertyName("hometown_location_code")]
        public string? HometownLocationCode { get; set; }

        /// <summary>
        /// <para>意向地点</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("preferred_location_code_list")]
        public string[]? PreferredLocationCodeList { get; set; }

        /// <summary>
        /// <para>家庭住址</para>
        /// <para>必填：否</para>
        /// <para>示例值：北京朝阳区</para>
        /// </summary>
        [JsonPropertyName("home_address")]
        public string? HomeAddress { get; set; }

        /// <summary>
        /// <para>证件类型</para>
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

        /// <summary>
        /// <para>证件号</para>
        /// <para>必填：否</para>
        /// <para>示例值：511699199x1x111234</para>
        /// </summary>
        [JsonPropertyName("identification_number")]
        public string? IdentificationNumber { get; set; }

        /// <summary>
        /// <para>生日</para>
        /// <para>必填：否</para>
        /// <para>示例值：293016767159</para>
        /// </summary>
        [JsonPropertyName("birthday")]
        public long? Birthday { get; set; }

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
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>户口所在地</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_1</para>
        /// </summary>
        [JsonPropertyName("hukou_location_code")]
        public string? HukouLocationCode { get; set; }
    }

    /// <summary>
    /// <para>教育经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("education_list")]
    public CompositeTalentEducationInfo[]? EducationLists { get; set; }

    /// <summary>
    /// <para>教育经历</para>
    /// </summary>
    public record CompositeTalentEducationInfo
    {
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

        /// <summary>
        /// <para>学校</para>
        /// <para>必填：否</para>
        /// <para>示例值：湘港大学</para>
        /// </summary>
        [JsonPropertyName("school_name")]
        public string? SchoolName { get; set; }

        /// <summary>
        /// <para>专业</para>
        /// <para>必填：否</para>
        /// <para>示例值：考古</para>
        /// </summary>
        [JsonPropertyName("major")]
        public string? Major { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1992-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1994-01</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>学历类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：海外及港台</item>
        /// <item>2：统招全日制</item>
        /// <item>3：非全日制</item>
        /// <item>4：自考</item>
        /// <item>5：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("education_type")]
        public int? EducationType { get; set; }

        /// <summary>
        /// <para>成绩排名</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// <para>可选值：<list type="bullet">
        /// <item>5：前 5 %</item>
        /// <item>10：前 10 %</item>
        /// <item>20：前 20 %</item>
        /// <item>30：前 30 %</item>
        /// <item>50：前 50 %</item>
        /// <item>-1：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("academic_ranking")]
        public int? AcademicRanking { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>工作经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("career_list")]
    public CompositeTalentCareerInfo[]? CareerLists { get; set; }

    /// <summary>
    /// <para>工作经历</para>
    /// </summary>
    public record CompositeTalentCareerInfo
    {
        /// <summary>
        /// <para>公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1688180088</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1687180087</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>职称</para>
        /// <para>必填：否</para>
        /// <para>示例值：1655644087000</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：科学家</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>项目经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("project_list")]
    public CompositeTalentProjectInfo[]? ProjectLists { get; set; }

    /// <summary>
    /// <para>项目经历</para>
    /// </summary>
    public record CompositeTalentProjectInfo
    {
        /// <summary>
        /// <para>项目名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// <para>项目角色</para>
        /// <para>必填：否</para>
        /// <para>示例值：test</para>
        /// </summary>
        [JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// <para>项目链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：www.recruitment-demo.com</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：招聘网站</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1990-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1991-01</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>作品集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("works_list")]
    public CompositeTalentWorksInfo[]? WorksLists { get; set; }

    /// <summary>
    /// <para>作品集</para>
    /// </summary>
    public record CompositeTalentWorksInfo
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get-2</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：人才信息页面</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>获奖列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("award_list")]
    public CompositeTalentAwardInfo[]? AwardLists { get; set; }

    /// <summary>
    /// <para>获奖列表</para>
    /// </summary>
    public record CompositeTalentAwardInfo
    {
        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：最佳新人奖</para>
        /// </summary>
        [JsonPropertyName("award_name")]
        public string? AwardName { get; set; }

        /// <summary>
        /// <para>获奖时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1991</para>
        /// </summary>
        [JsonPropertyName("award_time")]
        public string? AwardTime { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：最优秀的新人奖</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>语言列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("language_list")]
    public CompositeTalentLanguageInfo[]? LanguageLists { get; set; }

    /// <summary>
    /// <para>语言列表</para>
    /// </summary>
    public record CompositeTalentLanguageInfo
    {
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
        /// <para>熟练程度</para>
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

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>SNS列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sns_list")]
    public CompositeTalentSnsInfo[]? SnsLists { get; set; }

    /// <summary>
    /// <para>SNS列表</para>
    /// </summary>
    public record CompositeTalentSnsInfo
    {
        /// <summary>
        /// <para>SNS类型</para>
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
        /// <para>SNS链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>简历来源</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("resume_source_list")]
    public TalentResumeSource[]? ResumeSourceLists { get; set; }

    /// <summary>
    /// <para>简历来源</para>
    /// </summary>
    public record TalentResumeSource
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>中文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：猎头</para>
        /// </summary>
        [JsonPropertyName("zh_name")]
        public string? ZhName { get; set; }

        /// <summary>
        /// <para>英文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：Hunter</para>
        /// </summary>
        [JsonPropertyName("en_name")]
        public string? EnName { get; set; }
    }

    /// <summary>
    /// <para>实习经历</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("internship_list")]
    public CompositeTalentInternshipInfo[]? InternshipLists { get; set; }

    /// <summary>
    /// <para>实习经历</para>
    /// </summary>
    public record CompositeTalentInternshipInfo
    {
        /// <summary>
        /// <para>公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技实习公司</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1687180087000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1655644087000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>职称</para>
        /// <para>必填：否</para>
        /// <para>示例值：实习科学家</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data_list")]
        public TalentCustomizedDataChild[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_data_list")]
    public CompositeTalentCustomizedData[]? CustomizedDataLists { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record CompositeTalentCustomizedData
    {
        /// <summary>
        /// <para>模块 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7106698109352479020</para>
        /// </summary>
        [JsonPropertyName("module_id")]
        public string? ModuleId { get; set; }

        /// <summary>
        /// <para>模块名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>模块名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>类型</para>
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
        /// <para>模块下的字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("children")]
        public TalentCustomizedDataChild[]? Childrens { get; set; }

        /// <summary>
        /// <para>模块下的字段</para>
        /// </summary>
        public record TalentCustomizedDataChild
        {
            /// <summary>
            /// <para>自定义字段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
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
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
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
            /// <item>13：附件</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public TalentCustomizedValue? Value { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// </summary>
            public record TalentCustomizedValue
            {
                /// <summary>
                /// <para>当字段类型为单行文本、多行文本、模块、默认字段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：text</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("option")]
                public TalentCustomizedOption? Option { get; set; }

                /// <summary>
                /// <para>当字段类型为单选时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedOption
                {
                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：AA</para>
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
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：测试</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：test</para>
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
                public TalentCustomizedOption[]? OptionLists { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("time_range")]
                public TalentCustomizedTimeRange? TimeRange { get; set; }

                /// <summary>
                /// <para>当字段类型为时间段时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedTimeRange
                {
                    /// <summary>
                    /// <para>开始时间，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
                    /// </summary>
                    [JsonPropertyName("start_time")]
                    public string? StartTime { get; set; }

                    /// <summary>
                    /// <para>结束时间，当值为至今时，返回「-」，秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625656721</para>
                    /// </summary>
                    [JsonPropertyName("end_time")]
                    public string? EndTime { get; set; }
                }

                /// <summary>
                /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1625456721</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }

                /// <summary>
                /// <para>当字段类型为数字时，从此字段取值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("number")]
                public string? Number { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customized_attachment")]
                public TalentCustomizedAttachment[]? CustomizedAttachments { get; set; }

                /// <summary>
                /// <para>当字段类型为附件时，从此字段取值</para>
                /// </summary>
                public record TalentCustomizedAttachment
                {
                    /// <summary>
                    /// <para>附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7140517838785481004</para>
                    /// </summary>
                    [JsonPropertyName("file_id")]
                    public string? FileId { get; set; }

                    /// <summary>
                    /// <para>附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.13测试1的面试记录.pdf</para>
                    /// </summary>
                    [JsonPropertyName("file_name")]
                    public string? FileName { get; set; }

                    /// <summary>
                    /// <para>附件类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：application/pdf</para>
                    /// </summary>
                    [JsonPropertyName("content_type")]
                    public string? ContentType { get; set; }

                    /// <summary>
                    /// <para>附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：16615</para>
                    /// </summary>
                    [JsonPropertyName("file_size")]
                    public int? FileSize { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>简历附件id列表（按照简历创建时间降序）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("resume_attachment_id_list")]
    public string[]? ResumeAttachmentIdList { get; set; }

    /// <summary>
    /// <para>面试登记表</para>
    /// <para>推荐使用 registration_list 字段获取完整登记表列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("interview_registration_list")]
    public TalentInterviewRegistrationSimple[]? InterviewRegistrationLists { get; set; }

    /// <summary>
    /// <para>面试登记表</para>
    /// <para>推荐使用 registration_list 字段获取完整登记表列表</para>
    /// </summary>
    public record TalentInterviewRegistrationSimple
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6833685612520950030</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618494330932</para>
        /// </summary>
        [JsonPropertyName("registration_time")]
        public int? RegistrationTime { get; set; }

        /// <summary>
        /// <para>下载链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://hire.feishu.cn/hire/file/blob/...token.../</para>
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }
    }

    /// <summary>
    /// <para>登记表列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("registration_list")]
    public RegistrationBasicInfo[]? RegistrationLists { get; set; }

    /// <summary>
    /// <para>登记表列表</para>
    /// </summary>
    public record RegistrationBasicInfo
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6833685612520950030</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618494330932</para>
        /// </summary>
        [JsonPropertyName("registration_time")]
        public int? RegistrationTime { get; set; }

        /// <summary>
        /// <para>下载链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://hire.feishu.cn/hire/file/blob/...token.../</para>
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// <para>登记表场景</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// <para>可选值：<list type="bullet">
        /// <item>5：面试登记表</item>
        /// <item>6：入职登记表</item>
        /// <item>14：信息更新登记表</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("scenario")]
        public int? Scenario { get; set; }
    }

    /// <summary>
    /// <para>是否已入职</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>可选值：<list type="bullet">
    /// <item>false：未入职</item>
    /// <item>true：已入职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("is_onboarded")]
    public bool? IsOnboarded { get; set; }

    /// <summary>
    /// <para>是否在猎头保护期</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>可选值：<list type="bullet">
    /// <item>false：未入职</item>
    /// <item>true：已入职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("is_in_agency_period")]
    public bool? IsInAgencyPeriod { get; set; }

    /// <summary>
    /// <para>最高学历 参考 DegreeType 枚举</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("top_degree")]
    public int? TopDegree { get; set; }

    /// <summary>
    /// <para>人才已加入的人才库列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_pool_id_list")]
    public string[]? TalentPoolIdList { get; set; }
}
