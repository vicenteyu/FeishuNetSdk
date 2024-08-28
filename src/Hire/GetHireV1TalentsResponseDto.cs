// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-08-24
// ************************************************************************
// <copyright file="GetHireV1TalentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取人才列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才列表 响应体
/// <para>批量获取人才摘要信息，包括人才 ID、人才基信息、教育经历、工作经历等。若需要获取人才详细信息请使用[获取人才详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)接口。</para>
/// <para>接口ID：7001051759612936195</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2flist</para>
/// </summary>
public record GetHireV1TalentsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>人才摘要信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Talent[]? Items { get; set; }

    /// <summary>
    /// <para>人才摘要信息列表</para>
    /// </summary>
    public record Talent
    {
        /// <summary>
        /// <para>人才 ID，详情可查看：[获取人才详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// <para>基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("basic_info")]
        public TalentBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// <para>基本信息</para>
        /// </summary>
        public record TalentBasicInfo
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
            /// <para>示例值：182900291190</para>
            /// </summary>
            [JsonPropertyName("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>手机国家区号，遵守国际统一标准，请参考[百度百科-国际长途电话区号](https://baike.baidu.com/item/%E5%9B%BD%E9%99%85%E9%95%BF%E9%80%94%E7%94%B5%E8%AF%9D%E5%8C%BA%E5%8F%B7%E8%A1%A8/12803495?fr=ge_ala)</para>
            /// <para>必填：否</para>
            /// <para>示例值：86</para>
            /// </summary>
            [JsonPropertyName("mobile_code")]
            public string? MobileCode { get; set; }

            /// <summary>
            /// <para>手机国家代码，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonPropertyName("mobile_country_code")]
            public string? MobileCountryCode { get; set; }

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
            /// <para>国籍（地区）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("nationality")]
            public TalentNationality? Nationality { get; set; }

            /// <summary>
            /// <para>国籍（地区）</para>
            /// </summary>
            public record TalentNationality
            {
                /// <summary>
                /// <para>国家编码，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
                /// <para>必填：否</para>
                /// <para>示例值：CN_1</para>
                /// </summary>
                [JsonPropertyName("nationality_code")]
                public string? NationalityCode { get; set; }

                /// <summary>
                /// <para>国籍（地区）中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：中国</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>国籍（地区）英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：China</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }
            }

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
            /// </summary>
            [JsonPropertyName("current_city")]
            public TalentCityInfo? CurrentCity { get; set; }

            /// <summary>
            /// <para>所在地点</para>
            /// </summary>
            public record TalentCityInfo
            {
                /// <summary>
                /// <para>城市码，详情请查看：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
                /// <para>必填：否</para>
                /// <para>示例值：CT_11</para>
                /// </summary>
                [JsonPropertyName("city_code")]
                public string? CityCode { get; set; }

                /// <summary>
                /// <para>地点中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：北京</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>地点英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：Beijing</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }
            }

            /// <summary>
            /// <para>家乡</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hometown_city")]
            public TalentCityInfo? HometownCity { get; set; }

            /// <summary>
            /// <para>期望工作地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("preferred_city_list")]
            public TalentCityInfo[]? PreferredCityLists { get; set; }

            /// <summary>
            /// <para>个人证件类型</para>
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
            /// <para>个人证件号</para>
            /// <para>必填：否</para>
            /// <para>示例值：511699199x1x111234</para>
            /// </summary>
            [JsonPropertyName("identification_number")]
            public string? IdentificationNumber { get; set; }

            /// <summary>
            /// <para>出生日期，秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：293016767159</para>
            /// </summary>
            [JsonPropertyName("birthday")]
            public long? Birthday { get; set; }

            /// <summary>
            /// <para>创建人 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_4c5ec7005d5e476175d5edfd3f1e5206</para>
            /// </summary>
            [JsonPropertyName("creator_id")]
            public string? CreatorId { get; set; }

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
            /// <para>家庭住址</para>
            /// <para>必填：否</para>
            /// <para>示例值：南京路1号</para>
            /// </summary>
            [JsonPropertyName("current_home_address")]
            public string? CurrentHomeAddress { get; set; }

            /// <summary>
            /// <para>修改时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1634801678103</para>
            /// </summary>
            [JsonPropertyName("modify_time")]
            public string? ModifyTime { get; set; }
        }

        /// <summary>
        /// <para>教育经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("education_list")]
        public TalentEducationInfo[]? EducationLists { get; set; }

        /// <summary>
        /// <para>教育经历</para>
        /// </summary>
        public record TalentEducationInfo
        {
            /// <summary>
            /// <para>教育经历 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

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
            [JsonPropertyName("school")]
            public string? School { get; set; }

            /// <summary>
            /// <para>专业</para>
            /// <para>必填：否</para>
            /// <para>示例值：考古</para>
            /// </summary>
            [JsonPropertyName("field_of_study")]
            public string? FieldOfStudy { get; set; }

            /// <summary>
            /// <para>教育经历的起始日期，精确到月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：1990-01</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>教育经历的结束时间，精确到月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：1994-01</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>结束时间-新，无「至今」传值。建议使用此字段，避免模糊的毕业时间影响候选人筛选</para>
            /// <para>必填：否</para>
            /// <para>示例值：1687180087000</para>
            /// </summary>
            [JsonPropertyName("end_time_v2")]
            public string? EndTimeV2 { get; set; }

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
            /// <para>教育经历标签</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("tag_list")]
            public int[]? TagList { get; set; }
        }

        /// <summary>
        /// <para>工作经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("career_list")]
        public TalentCareerInfo[]? CareerLists { get; set; }

        /// <summary>
        /// <para>工作经历</para>
        /// </summary>
        public record TalentCareerInfo
        {
            /// <summary>
            /// <para>工作经历 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>公司名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：明日科技公司</para>
            /// </summary>
            [JsonPropertyName("company")]
            public string? Company { get; set; }

            /// <summary>
            /// <para>职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：高级工程师</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>工作经历描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：负责公司主页 UI 交互动画设计，行业领先水准</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>工作经历的开始日期，精确到月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：1990-01</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>工作经历的结束日期，精确到月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：1994-01</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>经历类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：实习经历</item>
            /// <item>2：工作经历</item>
            /// <item>3：兼职经历</item>
            /// <item>4：其他经历</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("career_type")]
            public int? CareerType { get; set; }

            /// <summary>
            /// <para>工作经历标签</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("tag_list")]
            public int[]? TagList { get; set; }
        }

        /// <summary>
        /// <para>项目经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("project_list")]
        public TalentProjectInfo[]? ProjectLists { get; set; }

        /// <summary>
        /// <para>项目经历</para>
        /// </summary>
        public record TalentProjectInfo
        {
            /// <summary>
            /// <para>项目经历 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>项目名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：权限重构项目</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>项目角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：项目负责人</para>
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
            /// <para>项目描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：将系统的权限模块进行重构，支持更加灵活的权限控制能力。</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>项目的开始日期，精确到月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：1990-01</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>项目的结束日期，精确到月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：1991-01</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }

        /// <summary>
        /// <para>作品</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("works_list")]
        public TalentWorksInfo[]? WorksLists { get; set; }

        /// <summary>
        /// <para>作品</para>
        /// </summary>
        public record TalentWorksInfo
        {
            /// <summary>
            /// <para>作品 ID，可通过[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)获取作品附件信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>作品链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：www.test.com</para>
            /// </summary>
            [JsonPropertyName("link")]
            public string? Link { get; set; }

            /// <summary>
            /// <para>作品描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：全国 UI 设计大赛一等奖</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>作品附件名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：全国 UI 设计大赛</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>获奖</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("award_list")]
        public TalentAwardInfo[]? AwardLists { get; set; }

        /// <summary>
        /// <para>获奖</para>
        /// </summary>
        public record TalentAwardInfo
        {
            /// <summary>
            /// <para>获奖 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>获奖名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：最佳新人奖</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>获奖日期，精确到年份</para>
            /// <para>必填：否</para>
            /// <para>示例值：1991</para>
            /// </summary>
            [JsonPropertyName("award_time")]
            public string? AwardTime { get; set; }

            /// <summary>
            /// <para>获奖描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：最优秀的新人奖</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }
        }

        /// <summary>
        /// <para>语言能力</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("language_list")]
        public TalentLanguageInfo[]? LanguageLists { get; set; }

        /// <summary>
        /// <para>语言能力</para>
        /// </summary>
        public record TalentLanguageInfo
        {
            /// <summary>
            /// <para>语言能力 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

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
            /// <para>精通程度</para>
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

        /// <summary>
        /// <para>社交账号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sns_list")]
        public TalentSnsInfo[]? SnsLists { get; set; }

        /// <summary>
        /// <para>社交账号</para>
        /// </summary>
        public record TalentSnsInfo
        {
            /// <summary>
            /// <para>社交账号 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>SNS 名称</para>
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
            /// <para>示例值：www.test.com</para>
            /// </summary>
            [JsonPropertyName("link")]
            public string? Link { get; set; }
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
            /// <para>简历来源中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：猎头</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>简历来源英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Hunter</para>
            /// </summary>
            [JsonPropertyName("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>面试登记表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_registration_list")]
        public TalentInterviewRegistrationSimple[]? InterviewRegistrationLists { get; set; }

        /// <summary>
        /// <para>面试登记表</para>
        /// </summary>
        public record TalentInterviewRegistrationSimple
        {
            /// <summary>
            /// <para>面试登记表 ID，详情可查看：[获取面试登记表模板列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_registration_schema/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6833685612520950030</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>面试登记表创建时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618494330932</para>
            /// </summary>
            [JsonPropertyName("registration_time")]
            public long? RegistrationTime { get; set; }
        }

        /// <summary>
        /// <para>简历附件 ID 列表（按照简历创建时间降序），详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("resume_attachment_id_list")]
        public string[]? ResumeAttachmentIdList { get; set; }

        /// <summary>
        /// <para>最高学历</para>
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
        [JsonPropertyName("top_degree")]
        public int? TopDegree { get; set; }

        /// <summary>
        /// <para>第一学历</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：低于大专</item>
        /// <item>2：大专</item>
        /// <item>3：本科</item>
        /// <item>4：硕士</item>
        /// <item>5：博士</item>
        /// <item>6：其他</item>
        /// <item>7：无</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("first_degree")]
        public int? FirstDegree { get; set; }
    }
}
