// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="GetHireV2TalentsByTalentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取人才详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才详情 响应体
/// <para>根据人才 ID 获取人才详情，包含人才加入文件夹列表、标签、人才库、备注以及屏蔽名单等信息。</para>
/// <para>接口ID：7177216475677474820</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhire-v2%2ftalent%2fget</para>
/// </summary>
public record GetHireV2TalentsByTalentIdResponseDto
{
    /// <summary>
    /// <para>人才 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6761694410053798151</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }

    /// <summary>
    /// <para>基本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("basic_info")]
    public CompositeTalentBasicInfo? BasicInfo { get; set; }

    /// <summary>
    /// <para>基本信息</para>
    /// </summary>
    public record CompositeTalentBasicInfo
    {
        /// <summary>
        /// <para>姓名</para>
        /// <para>必填：是</para>
        /// <para>示例值：张三</para>
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
        /// <para>手机国家区号，遵守国际统一标准，请参考[百度百科-国际长途电话区号](https://baike.baidu.com/item/%E5%9B%BD%E9%99%85%E9%95%BF%E9%80%94%E7%94%B5%E8%AF%9D%E5%8C%BA%E5%8F%B7%E8%A1%A8/12803495?fr=ge_ala)</para>
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
        /// <para>国籍（地区），详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
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
        /// <para>所在地点，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_2</para>
        /// </summary>
        [JsonPropertyName("current_location_code")]
        public string? CurrentLocationCode { get; set; }

        /// <summary>
        /// <para>家乡，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_3</para>
        /// </summary>
        [JsonPropertyName("hometown_location_code")]
        public string? HometownLocationCode { get; set; }

        /// <summary>
        /// <para>意向地点，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
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
        /// <para>生日，秒时间戳</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7392444731470547241</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：字段1</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：field 1</para>
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
            /// <item>12：日期</item>
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
                    /// <para>示例值：7350282123172432169</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项1</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option 1</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
        /// <para>户口所在地，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_1</para>
        /// </summary>
        [JsonPropertyName("hukou_location_code")]
        public string? HukouLocationCode { get; set; }

        /// <summary>
        /// <para>人才更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1634801678103</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>人才创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1634801678103</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>人才隐藏状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：隐藏</item>
        /// <item>2：公开</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("confidential")]
        public int? Confidential { get; set; }
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
        /// <para>学校名称</para>
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
        /// <para>教育经历的起始日期，精确到月份，格式为YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：1992-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>教育经历的结束时间，精确到月份，格式为YYYY-MM</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7392444731470563625</para>
            /// </summary>
            [JsonPropertyName("object_id")]
            public string? ObjectId { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>自定义字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：人才过往</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>自定义字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：talent old history</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段字段类型</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个自定义字段内容</para>
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
                    /// <para>示例值：7392444731470563625</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
        /// <para>公司名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技公司</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// <para>工作经历描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>工作经历的结束日期，精确到月份，格式为YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-06</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>工作经历的开始日期，精确到月份，格式为YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-06</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>职位名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级工程师</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917641499</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：经历地址</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：data english name</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项 A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
        /// <para>示例值：权限重构项目</para>
        /// </summary>
        [JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// <para>项目角色</para>
        /// <para>必填：否</para>
        /// <para>示例值：项目负责人</para>
        /// </summary>
        [JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// <para>项目链接（访问型链接，无有效期限制）</para>
        /// <para>必填：否</para>
        /// <para>示例值：www.recruitment-demo.com</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>项目描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：招聘网站</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>项目的开始日期，精确到月份，格式为YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：1990-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>项目的结束日期，精确到月份，格式为YYYY-MM</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917641499</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：自定义字段</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：english name</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项 A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
    /// <para>作品</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("works_list")]
    public CompositeTalentWorksInfo[]? WorksLists { get; set; }

    /// <summary>
    /// <para>作品</para>
    /// </summary>
    public record CompositeTalentWorksInfo
    {
        /// <summary>
        /// <para>作品 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>作品链接（访问型链接，无有效期限制）</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get-2</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>作品描述</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917641499</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：字段1</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：english name</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
    /// <para>获奖</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("award_list")]
    public CompositeTalentAwardInfo[]? AwardLists { get; set; }

    /// <summary>
    /// <para>获奖</para>
    /// </summary>
    public record CompositeTalentAwardInfo
    {
        /// <summary>
        /// <para>获奖名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：最佳新人奖</para>
        /// </summary>
        [JsonPropertyName("award_name")]
        public string? AwardName { get; set; }

        /// <summary>
        /// <para>获奖日期，精确到月份，格式为YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：1992-01</para>
        /// </summary>
        [JsonPropertyName("award_time")]
        public string? AwardTime { get; set; }

        /// <summary>
        /// <para>获奖描述</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917641499</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：字段1</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：english name</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项 A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
    /// <para>语言能力</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("language_list")]
    public CompositeTalentLanguageInfo[]? LanguageLists { get; set; }

    /// <summary>
    /// <para>语言能力</para>
    /// </summary>
    public record CompositeTalentLanguageInfo
    {
        /// <summary>
        /// <para>语言类别</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6792436415209817608</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：字段 1</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：english name</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项 A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
    /// <para>社交账号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sns_list")]
    public CompositeTalentSnsInfo[]? SnsLists { get; set; }

    /// <summary>
    /// <para>社交账号</para>
    /// </summary>
    public record CompositeTalentSnsInfo
    {
        /// <summary>
        /// <para>社交平台</para>
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
        /// <para>URL/ID</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917641499</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：字段 1</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：option A</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项 A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
        /// <para>简历来源 ID，详情请查看：[获取简历来源列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/resume_source/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>简历来源中文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：猎头</para>
        /// </summary>
        [JsonPropertyName("zh_name")]
        public string? ZhName { get; set; }

        /// <summary>
        /// <para>简历来源英文名称</para>
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
        /// <para>实习公司名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技</para>
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// <para>实习公司描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技实习公司</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>实习的结束日期，精确到月份，格式为YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：1992-01</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>实习的开始日期，精确到月份，格式为YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：1992-01</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>职位名称</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917641499</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：字段 1</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项 A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
            /// <para>模块中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：模块 1</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>模块英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：module 1</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>模块类型</para>
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
            /// <para>自定义字段 ID，详情请查看：[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7395082456917641499</para>
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
                /// <para>字段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：字段 1</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>字段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：english name</para>
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
            /// <item>12：日期</item>
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
                /// <para>示例值：这是一个单行文本</para>
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
                    /// <para>示例值：7395082456917641499</para>
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
                        /// <para>选项中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：选项 A</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>选项英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：option A</para>
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
                    /// <para>附件 ID，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
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
    /// <para>简历附件id列表（按照简历创建时间降序），详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("resume_attachment_id_list")]
    public string[]? ResumeAttachmentIdList { get; set; }

    /// <summary>
    /// <para>简历附件列表（按照简历创建时间降序）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("resume_attachment_list")]
    public TalentResumeAttachment[]? ResumeAttachmentLists { get; set; }

    /// <summary>
    /// <para>简历附件列表（按照简历创建时间降序）</para>
    /// </summary>
    public record TalentResumeAttachment
    {
        /// <summary>
        /// <para>ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>附件名，包含文件类型后缀，例如【简历.pdf】</para>
        /// <para>必填：否</para>
        /// <para>示例值：1.pdf</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>附件MIME类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：application/pdf</para>
        /// </summary>
        [JsonPropertyName("mime")]
        public string? Mime { get; set; }

        /// <summary>
        /// <para>创建时间，为毫秒级的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1734348840749</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }

    /// <summary>
    /// <para>面试登记表，推荐使用`registration_list`字段获取完整登记表列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("interview_registration_list")]
    public TalentInterviewRegistrationSimple[]? InterviewRegistrationLists { get; set; }

    /// <summary>
    /// <para>面试登记表，推荐使用`registration_list`字段获取完整登记表列表</para>
    /// </summary>
    public record TalentInterviewRegistrationSimple
    {
        /// <summary>
        /// <para>登记表 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6833685612520950030</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618494330932</para>
        /// </summary>
        [JsonPropertyName("registration_time")]
        public long? RegistrationTime { get; set; }

        /// <summary>
        /// <para>下载链接（有效期7天）</para>
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
        /// <para>登记表 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6833685612520950030</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618494330932</para>
        /// </summary>
        [JsonPropertyName("registration_time")]
        public long? RegistrationTime { get; set; }

        /// <summary>
        /// <para>下载链接（有效期7天）</para>
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
    /// <item>false：未在猎头保护期</item>
    /// <item>true：在猎头保护期</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("is_in_agency_period")]
    public bool? IsInAgencyPeriod { get; set; }

    /// <summary>
    /// <para>最高学历， 详情请参考[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中 DegreeType 枚举</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("top_degree")]
    public int? TopDegree { get; set; }

    /// <summary>
    /// <para>人才已加入的人才库列表，详情请查看：[获取人才库列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_pool/search)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_pool_id_list")]
    public string[]? TalentPoolIdList { get; set; }

    /// <summary>
    /// <para>文件夹列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_folder_ref_list_v2")]
    public TalentFolder[]? TalentFolderRefListV2s { get; set; }

    /// <summary>
    /// <para>文件夹列表</para>
    /// </summary>
    public record TalentFolder
    {
        /// <summary>
        /// <para>文件夹名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：人才文件夹A1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>文件夹 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7041806543797995820</para>
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// <para>所有者 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_85bb308c57f597471cd2bb5b4f580245</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>文件夹加入时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1634801678103</para>
        /// </summary>
        [JsonPropertyName("add_time")]
        public string? AddTime { get; set; }
    }

    /// <summary>
    /// <para>标签列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tag_list")]
    public TalentTag[]? TagLists { get; set; }

    /// <summary>
    /// <para>标签列表</para>
    /// </summary>
    public record TalentTag
    {
        /// <summary>
        /// <para>标签 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7140517838785481004</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>标签名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>标签名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>标签中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：高学历人才</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>标签英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：985</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>标签描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }

        /// <summary>
        /// <para>标签类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：手动标签</item>
        /// <item>2：自动标签</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }
    }

    /// <summary>
    /// <para>相似人才信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("similar_info_v2")]
    public TalentSimilar? SimilarInfoV2 { get; set; }

    /// <summary>
    /// <para>相似人才信息</para>
    /// </summary>
    public record TalentSimilar
    {
        /// <summary>
        /// <para>是否相似人才</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_similar_talent")]
        public bool? IsSimilarTalent { get; set; }

        /// <summary>
        /// <para>相似人才 ID 列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("similar_talent_id_list")]
        public string[]? SimilarTalentIdList { get; set; }
    }

    /// <summary>
    /// <para>人才屏蔽名单信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("block_info")]
    public TalentBlock? BlockInfo { get; set; }

    /// <summary>
    /// <para>人才屏蔽名单信息</para>
    /// </summary>
    public record TalentBlock
    {
        /// <summary>
        /// <para>加入屏蔽名单时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625656721</para>
        /// </summary>
        [JsonPropertyName("blocked_time")]
        public string? BlockedTime { get; set; }

        /// <summary>
        /// <para>屏蔽名单创建者 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>加入屏蔽名单原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：人才作弊</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }

    /// <summary>
    /// <para>人才已经加入的人才库列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_pool_ref_list_v2")]
    public TalentPool[]? TalentPoolRefListV2s { get; set; }

    /// <summary>
    /// <para>人才已经加入的人才库列表</para>
    /// </summary>
    public record TalentPool
    {
        /// <summary>
        /// <para>人才库 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>人才库名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>人才库名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>人才库中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试人才库</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>人才库英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：Test talent pool</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>人才库描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n? Description { get; set; }

        /// <summary>
        /// <para>人才库加入时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1634801678103</para>
        /// </summary>
        [JsonPropertyName("add_time")]
        public string? AddTime { get; set; }
    }

    /// <summary>
    /// <para>备注列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("note_list_v2")]
    public TalentNote[]? NoteListV2s { get; set; }

    /// <summary>
    /// <para>备注列表</para>
    /// </summary>
    public record TalentNote
    {
        /// <summary>
        /// <para>备注 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>人才 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6916472453069883661</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// <para>投递 ID，详情可查看[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891565253964859661</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>人才备注创建时间,毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>人才备注更新时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>创建人ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_f476cb099ac9227c9bae09ce46112579</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }

        /// <summary>
        /// <para>备注内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试备注内容</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>备注私密属性</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：私密</item>
        /// <item>2：公开</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("privacy")]
        public int? Privacy { get; set; }
    }
}
