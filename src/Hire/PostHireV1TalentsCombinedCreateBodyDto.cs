// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostHireV1TalentsCombinedCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建人才 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建人才 请求体
/// <para>用于在企业内创建一个人才。支持自定义字段数据，可配合[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
/// <para>接口获取自定义字段信息使用。</para>
/// <para>## 注意事项</para>
/// <para>请求参数中邮箱/电话字段请在「飞书招聘」-「设置」-「候选人信息管理」-「标准简历设置」中确认是否必填。</para>
/// <para>接口ID：7034053377010991105</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/combined_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fcombined_create</para>
/// </summary>
public record PostHireV1TalentsCombinedCreateBodyDto
{
    /// <summary>
    /// <para>简历来源 ID，已弃用，请使用 resume_source_id 字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("init_source_id")]
    public string? InitSourceId { get; set; }

    /// <summary>
    /// <para>简历来源 ID，可通过[获取简历来源列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/resume_source/list)</para>
    /// <para>接口查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("resume_source_id")]
    public string? ResumeSourceId { get; set; }

    /// <summary>
    /// <para>文件夹 ID 列表，可通过[获取人才文件夹列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_folder/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：["7025517823176132908"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("folder_id_list")]
    public string[]? FolderIdList { get; set; }

    /// <summary>
    /// <para>创建人 ID，和入参 `user_id_type` 类型保持一致，默认为系统用户 ID，当创建人类型为「系统」时无需填写该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_84aad35d084aa403a838cf73ee18467</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; set; }

    /// <summary>
    /// <para>创建人类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：员工</item>
    /// <item>3：系统</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("creator_account_type")]
    public int? CreatorAccountType { get; set; }

    /// <summary>
    /// <para>简历附件 ID，如何创建附件请参考[创建附件](https://open.feishu.cn/document/ukTMukTMukTM/uIDN1YjLyQTN24iM0UjN/create_attachment)</para>
    /// <para>必填：否</para>
    /// <para>示例值：7383906146040678700</para>
    /// </summary>
    [JsonPropertyName("resume_attachment_id")]
    public string? ResumeAttachmentId { get; set; }

    /// <summary>
    /// <para>基本信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("basic_info")]
    public TalentCombinedBasicInfo BasicInfo { get; set; } = new();

    /// <summary>
    /// <para>基本信息</para>
    /// </summary>
    public record TalentCombinedBasicInfo
    {
        /// <summary>
        /// <para>名字</para>
        /// <para>必填：是</para>
        /// <para>示例值：小明</para>
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
        /// <para>手机国家代码，可通过[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)接口获取</para>
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
        /// <para>证件信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("identification")]
        public TalentIdentificationInfo? Identification { get; set; }

        /// <summary>
        /// <para>证件信息</para>
        /// </summary>
        public record TalentIdentificationInfo
        {
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
        }

        /// <summary>
        /// <para>开始工作时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686832459000</para>
        /// </summary>
        [JsonPropertyName("start_work_time")]
        public string? StartWorkTime { get; set; }

        /// <summary>
        /// <para>出生日期时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1293016767159</para>
        /// </summary>
        [JsonPropertyName("birthday")]
        public string? Birthday { get; set; }

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
        /// <para>国籍编码，可通过[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_112</para>
        /// </summary>
        [JsonPropertyName("nationality_id")]
        public string? NationalityId { get; set; }

        /// <summary>
        /// <para>所在地点编码，可通过[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：CT_159</para>
        /// </summary>
        [JsonPropertyName("current_city_code")]
        public string? CurrentCityCode { get; set; }

        /// <summary>
        /// <para>家乡编码，可通过[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：CT_159</para>
        /// </summary>
        [JsonPropertyName("hometown_city_code")]
        public string? HometownCityCode { get; set; }

        /// <summary>
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>教育经历</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("education_list")]
    public TalentCombinedEducationInfo[]? EducationLists { get; set; }

    /// <summary>
    /// <para>教育经历</para>
    /// </summary>
    public record TalentCombinedEducationInfo
    {
        /// <summary>
        /// <para>教育经历 ID，无效字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>学历</para>
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
        /// <para>教育经历学校</para>
        /// <para>必填：否</para>
        /// <para>示例值：香港大学</para>
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
        /// <para>教育经历开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1655644087000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>教育经历结束时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1687180087000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>教育经历学历类型</para>
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
        /// <para>教育经历成绩排名</para>
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
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>工作经历</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("career_list")]
    public TalentCombinedCareerInfo[]? CareerLists { get; set; }

    /// <summary>
    /// <para>工作经历</para>
    /// </summary>
    public record TalentCombinedCareerInfo
    {
        /// <summary>
        /// <para>工作经历 ID，无效字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>工作经历公司名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：明日科技公司</para>
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// <para>工作经历职位名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：高级工程师</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>工作经历描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonPropertyName("desc")]
        public string? Desc { get; set; }

        /// <summary>
        /// <para>工作经历开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1655644087000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>工作经历结束时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1687180087000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>工作经历经历类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：实习经历</item>
        /// <item>2：工作经历</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("career_type")]
        public int? CareerType { get; set; }

        /// <summary>
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>项目经历</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("project_list")]
    public TalentCombinedProjectInfo[]? ProjectLists { get; set; }

    /// <summary>
    /// <para>项目经历</para>
    /// </summary>
    public record TalentCombinedProjectInfo
    {
        /// <summary>
        /// <para>项目经历 ID，无效字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>项目名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：系统稳定性提升项目</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>项目角色</para>
        /// <para>必填：否</para>
        /// <para>示例值：研发人员</para>
        /// </summary>
        [JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// <para>项目链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.a.com</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>项目描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：该项目目标是提升整个系统的稳定性，达到行业一流水准。</para>
        /// </summary>
        [JsonPropertyName("desc")]
        public string? Desc { get; set; }

        /// <summary>
        /// <para>项目开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1655644087000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>项目结束时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1687180087000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>作品</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("works_list")]
    public TalentCombinedWorkInfo[]? WorksLists { get; set; }

    /// <summary>
    /// <para>作品</para>
    /// </summary>
    public record TalentCombinedWorkInfo
    {
        /// <summary>
        /// <para>作品 ID，无效字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>作品链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.a.com</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>作品描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：个人设计作品</para>
        /// </summary>
        [JsonPropertyName("desc")]
        public string? Desc { get; set; }

        /// <summary>
        /// <para>作品附件 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：12345678</para>
        /// </summary>
        [JsonPropertyName("attachment_id")]
        public string? AttachmentId { get; set; }

        /// <summary>
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>获奖</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("award_list")]
    public TalentCombinedAwardInfo[]? AwardLists { get; set; }

    /// <summary>
    /// <para>获奖</para>
    /// </summary>
    public record TalentCombinedAwardInfo
    {
        /// <summary>
        /// <para>获奖 ID，无效字段，请勿使用</para>
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
        /// <para>获奖时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1687180087000</para>
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

        /// <summary>
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>语言能力</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("language_list")]
    public TalentCombinedLanguageInfo[]? LanguageLists { get; set; }

    /// <summary>
    /// <para>语言能力</para>
    /// </summary>
    public record TalentCombinedLanguageInfo
    {
        /// <summary>
        /// <para>语言能力 ID，无效字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>语言类型</para>
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
        /// <item>26：印尼语</item>
        /// <item>27：马来语</item>
        /// <item>28：泰语</item>
        /// <item>29：塞尔维亚语</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("language")]
        public int? Language { get; set; }

        /// <summary>
        /// <para>语言精通程度</para>
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
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>社交账号</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("sns_list")]
    public TalentCombinedSnsInfo[]? SnsLists { get; set; }

    /// <summary>
    /// <para>社交账号</para>
    /// </summary>
    public record TalentCombinedSnsInfo
    {
        /// <summary>
        /// <para>社交账号 ID，无效字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// <para>示例值：https://www.a.com</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>意向地点，可通过[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：["CT_2"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("preferred_city_code_list")]
    public string[]? PreferredCityCodeList { get; set; }

    /// <summary>
    /// <para>自我评价</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("self_evaluation")]
    public TalentSelfEvaluation? SelfEvaluation { get; set; }

    /// <summary>
    /// <para>自我评价</para>
    /// </summary>
    public record TalentSelfEvaluation
    {
        /// <summary>
        /// <para>自我评价 ID，无效字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>自我评价内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：自我评价：平常心</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>自定义字段列表</para>
        /// <para>**注意**：`children` 字段无效，请参考请求体示例在当前层级传入 `object_id` 和 `value`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_data")]
        public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }
    }

    /// <summary>
    /// <para>自定义模块列表</para>
    /// <para>**注意**：`children` 字段为二维数组，请参考请求体示例</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_data")]
    public TalentCustomizedDataObjectValue[]? CustomizedDatas { get; set; }

    /// <summary>
    /// <para>自定义模块列表</para>
    /// <para>**注意**：`children` 字段为二维数组，请参考请求体示例</para>
    /// </summary>
    public record TalentCustomizedDataObjectValue
    {
        /// <summary>
        /// <para>自定义模块 ID，可通过[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
        /// <para>接口获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6934193211960330504</para>
        /// </summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// <para>自定义字段值，请参考本文「自定义字段数据格式说明」。</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// <para>子字段列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("children")]
        public TalentCustomizedDataObjectValueChild[]? Childrens { get; set; }

        /// <summary>
        /// <para>子字段列表</para>
        /// </summary>
        public record TalentCustomizedDataObjectValueChild
        {
            /// <summary>
            /// <para>自定义字段 ID，可通过[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
            /// <para>接口获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6934193211960330504</para>
            /// </summary>
            [JsonPropertyName("object_id")]
            public string? ObjectId { get; set; }

            /// <summary>
            /// <para>自定义字段值，请参考本文「自定义字段数据格式说明」。</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
