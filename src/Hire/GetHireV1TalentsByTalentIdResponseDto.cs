using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取人才信息 V1 响应体
/// <para>根据人才 ID 获取人才信息。</para>
/// <para>接口ID：6964264269274611714</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fget</para>
/// </summary>
public record GetHireV1TalentsByTalentIdResponseDto
{
    /// <summary>
    /// <para>人才信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("talent")]
    public GetHireV1TalentsByTalentIdResponseDtoTalent? Talent { get; set; }

    /// <summary>
    /// <para>人才信息</para>
    /// </summary>
    public record GetHireV1TalentsByTalentIdResponseDtoTalent
    {
        /// <summary>
        /// <para>人才ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6891560630172518670</para>
        /// </summary>
        [JsonProperty("id")]
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
        [JsonProperty("is_in_agency_period")]
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
        [JsonProperty("is_onboarded")]
        public bool? IsOnboarded { get; set; }

        /// <summary>
        /// <para>基础信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("basic_info")]
        public TalentBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// <para>基础信息</para>
        /// </summary>
        public record TalentBasicInfo
        {
            /// <summary>
            /// <para>名字</para>
            /// <para>必填：是</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>手机</para>
            /// <para>必填：否</para>
            /// <para>示例值：182900291190</para>
            /// </summary>
            [JsonProperty("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>手机国家区号</para>
            /// <para>必填：否</para>
            /// <para>示例值：86</para>
            /// </summary>
            [JsonProperty("mobile_code")]
            public string? MobileCode { get; set; }

            /// <summary>
            /// <para>手机国家代码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonProperty("mobile_country_code")]
            public string? MobileCountryCode { get; set; }

            /// <summary>
            /// <para>邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：16xx1@126.com</para>
            /// </summary>
            [JsonProperty("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>工作年限</para>
            /// <para>必填：否</para>
            /// <para>示例值：5</para>
            /// </summary>
            [JsonProperty("experience_years")]
            public int? ExperienceYears { get; set; }

            /// <summary>
            /// <para>年龄</para>
            /// <para>必填：否</para>
            /// <para>示例值：22</para>
            /// </summary>
            [JsonProperty("age")]
            public int? Age { get; set; }

            /// <summary>
            /// <para>国籍</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("nationality")]
            public TalentNationality? Nationality { get; set; }

            /// <summary>
            /// <para>国籍</para>
            /// </summary>
            public record TalentNationality
            {
                /// <summary>
                /// <para>国家编码</para>
                /// <para>必填：否</para>
                /// <para>示例值：CN_183</para>
                /// </summary>
                [JsonProperty("nationality_code")]
                public string? NationalityCode { get; set; }

                /// <summary>
                /// <para>中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonProperty("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonProperty("en_name")]
                public string? EnName { get; set; }
            }

            /// <summary>
            /// <para>性别</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：男</item>
            /// <item>2：女</item>
            /// <item>3：保密</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("gender")]
            public int? Gender { get; set; }

            /// <summary>
            /// <para>所在地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("current_city")]
            public TalentCityInfo? CurrentCity { get; set; }

            /// <summary>
            /// <para>所在地点</para>
            /// </summary>
            public record TalentCityInfo
            {
                /// <summary>
                /// <para>城市码</para>
                /// <para>必填：否</para>
                /// <para>示例值：CN_183</para>
                /// </summary>
                [JsonProperty("city_code")]
                public string? CityCode { get; set; }

                /// <summary>
                /// <para>中文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试</para>
                /// </summary>
                [JsonProperty("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>英文名</para>
                /// <para>必填：否</para>
                /// <para>示例值：test</para>
                /// </summary>
                [JsonProperty("en_name")]
                public string? EnName { get; set; }
            }

            /// <summary>
            /// <para>家乡</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("hometown_city")]
            public TalentCityInfo? HometownCity { get; set; }

            /// <summary>
            /// <para>意向地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("preferred_city_list")]
            public TalentCityInfo[]? PreferredCityLists { get; set; }

            /// <summary>
            /// <para>证件类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：中国-居民身份证</item>
            /// <item>2：护照</item>
            /// <item>3：中国-港澳居民居住证</item>
            /// <item>4：中国-台湾居民来往大陆通行证</item>
            /// <item>5：其他</item>
            /// <item>6：中国-港澳居民来往内地通行证</item>
            /// <item>9：中国-台湾居民居住证</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("identification_type")]
            public int? IdentificationType { get; set; }

            /// <summary>
            /// <para>证件号</para>
            /// <para>必填：否</para>
            /// <para>示例值：511699199x1x111234</para>
            /// </summary>
            [JsonProperty("identification_number")]
            public string? IdentificationNumber { get; set; }

            /// <summary>
            /// <para>生日</para>
            /// <para>必填：否</para>
            /// <para>示例值：1687872017</para>
            /// </summary>
            [JsonProperty("birthday")]
            public int? Birthday { get; set; }

            /// <summary>
            /// <para>创建人</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-xxx</para>
            /// </summary>
            [JsonProperty("creator_id")]
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
            [JsonProperty("marital_status")]
            public int? MaritalStatus { get; set; }

            /// <summary>
            /// <para>家庭住址</para>
            /// <para>必填：否</para>
            /// <para>示例值：南京路1号</para>
            /// </summary>
            [JsonProperty("current_home_address")]
            public string? CurrentHomeAddress { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>修改时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1634801678103</para>
            /// </summary>
            [JsonProperty("modify_time")]
            public string? ModifyTime { get; set; }

            /// <summary>
            /// <para>户口所在地</para>
            /// <para>必填：否</para>
            /// <para>示例值：CN_1</para>
            /// </summary>
            [JsonProperty("hukou_location_code")]
            public string? HukouLocationCode { get; set; }
        }

        /// <summary>
        /// <para>教育经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("education_list")]
        public TalentEducationInfo[]? EducationLists { get; set; }

        /// <summary>
        /// <para>教育经历</para>
        /// </summary>
        public record TalentEducationInfo
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonProperty("id")]
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
            [JsonProperty("degree")]
            public int? Degree { get; set; }

            /// <summary>
            /// <para>学校</para>
            /// <para>必填：否</para>
            /// <para>示例值：湘港大学</para>
            /// </summary>
            [JsonProperty("school")]
            public string? School { get; set; }

            /// <summary>
            /// <para>专业</para>
            /// <para>必填：否</para>
            /// <para>示例值：考古</para>
            /// </summary>
            [JsonProperty("field_of_study")]
            public string? FieldOfStudy { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1990-01</para>
            /// </summary>
            [JsonProperty("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1994-01</para>
            /// </summary>
            [JsonProperty("end_time")]
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
            [JsonProperty("education_type")]
            public int? EducationType { get; set; }

            /// <summary>
            /// <para>成绩排名</para>
            /// <para>必填：否</para>
            /// <para>示例值：5</para>
            /// <para>可选值：<list type="bullet">
            /// <item>5：前5%</item>
            /// <item>10：前10%</item>
            /// <item>20：前20%</item>
            /// <item>30：前30%</item>
            /// <item>50：前50%</item>
            /// <item>-1：其他</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("academic_ranking")]
            public int? AcademicRanking { get; set; }

            /// <summary>
            /// <para>教育经历标签</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("tag_list")]
            public int[]? TagList { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>工作经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("career_list")]
        public TalentCareerInfo[]? CareerLists { get; set; }

        /// <summary>
        /// <para>工作经历</para>
        /// </summary>
        public record TalentCareerInfo
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>公司名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试公司</para>
            /// </summary>
            [JsonProperty("company")]
            public string? Company { get; set; }

            /// <summary>
            /// <para>职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：高级工程师</para>
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonProperty("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1990-01</para>
            /// </summary>
            [JsonProperty("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1994-01</para>
            /// </summary>
            [JsonProperty("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>经历类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：实习经历</item>
            /// <item>2：工作经历</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("career_type")]
            public int? CareerType { get; set; }

            /// <summary>
            /// <para>工作经历标签</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("tag_list")]
            public int[]? TagList { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>项目经历</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("project_list")]
        public TalentProjectInfo[]? ProjectLists { get; set; }

        /// <summary>
        /// <para>项目经历</para>
        /// </summary>
        public record TalentProjectInfo
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>项目名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>项目角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }

            /// <summary>
            /// <para>项目链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：www.test.com</para>
            /// </summary>
            [JsonProperty("link")]
            public string? Link { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonProperty("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1990-01</para>
            /// </summary>
            [JsonProperty("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1991-01</para>
            /// </summary>
            [JsonProperty("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>作品</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("works_list")]
        public TalentWorksInfo[]? WorksLists { get; set; }

        /// <summary>
        /// <para>作品</para>
        /// </summary>
        public record TalentWorksInfo
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>作品链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：www.test.com</para>
            /// </summary>
            [JsonProperty("link")]
            public string? Link { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonProperty("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>作品附件名称，若需获取作品附件预览信息可调用「获取附件预览信息」接口</para>
            /// <para>必填：否</para>
            /// <para>示例值：XX项目</para>
            /// </summary>
            [JsonProperty("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>获奖</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("award_list")]
        public TalentAwardInfo[]? AwardLists { get; set; }

        /// <summary>
        /// <para>获奖</para>
        /// </summary>
        public record TalentAwardInfo
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>获奖名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：最佳新人奖</para>
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>获奖时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1991</para>
            /// </summary>
            [JsonProperty("award_time")]
            public string? AwardTime { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：最优秀的新人奖</para>
            /// </summary>
            [JsonProperty("desc")]
            public string? Desc { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>语言能力</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("language_list")]
        public TalentLanguageInfo[]? LanguageLists { get; set; }

        /// <summary>
        /// <para>语言能力</para>
        /// </summary>
        public record TalentLanguageInfo
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonProperty("id")]
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
            [JsonProperty("language")]
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
            [JsonProperty("proficiency")]
            public int? Proficiency { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>社交账号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sns_list")]
        public TalentSnsInfo[]? SnsLists { get; set; }

        /// <summary>
        /// <para>社交账号</para>
        /// </summary>
        public record TalentSnsInfo
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891560630172518670</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>SNS名称</para>
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
            [JsonProperty("sns_type")]
            public int? SnsType { get; set; }

            /// <summary>
            /// <para>URL/ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：www.test.com</para>
            /// </summary>
            [JsonProperty("link")]
            public string? Link { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customized_data_list")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>简历来源</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("resume_source_list")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>中文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：猎头</para>
            /// </summary>
            [JsonProperty("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>英文名</para>
            /// <para>必填：否</para>
            /// <para>示例值：Hunter</para>
            /// </summary>
            [JsonProperty("en_name")]
            public string? EnName { get; set; }
        }

        /// <summary>
        /// <para>面试登记表</para>
        /// <para>推荐使用 registration_list 字段获取完整登记表列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("interview_registration_list")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618494330932</para>
            /// </summary>
            [JsonProperty("registration_time")]
            public int? RegistrationTime { get; set; }

            /// <summary>
            /// <para>下载链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://hire.feishu.cn/hire/file/blob/...token.../</para>
            /// </summary>
            [JsonProperty("download_url")]
            public string? DownloadUrl { get; set; }
        }

        /// <summary>
        /// <para>登记表列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("registration_list")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1618494330932</para>
            /// </summary>
            [JsonProperty("registration_time")]
            public int? RegistrationTime { get; set; }

            /// <summary>
            /// <para>下载链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://hire.feishu.cn/hire/file/blob/...token.../</para>
            /// </summary>
            [JsonProperty("download_url")]
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
            [JsonProperty("scenario")]
            public int? Scenario { get; set; }
        }

        /// <summary>
        /// <para>简历附件id列表（按照简历创建时间降序）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("resume_attachment_id_list")]
        public string[]? ResumeAttachmentIdList { get; set; }

        /// <summary>
        /// <para>自定义模块</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("customized_data_list")]
        public TalentCustomizedData[]? CustomizedDataLists { get; set; }

        /// <summary>
        /// <para>自定义模块</para>
        /// </summary>
        public record TalentCustomizedData
        {
            /// <summary>
            /// <para>模块 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx</para>
            /// </summary>
            [JsonProperty("object_id")]
            public string? ObjectId { get; set; }

            /// <summary>
            /// <para>模块名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("name")]
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
            [JsonProperty("object_type")]
            public int? ObjectType { get; set; }

            /// <summary>
            /// <para>模块下的字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("children")]
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
                /// <item>13：附件</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("object_type")]
                public int? ObjectType { get; set; }

                /// <summary>
                /// <para>自定义字段值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("value")]
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
                    [JsonProperty("content")]
                    public string? Content { get; set; }

                    /// <summary>
                    /// <para>当字段类型为单选时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("option")]
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
                    public TalentCustomizedOption[]? OptionLists { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("time_range")]
                    public TalentCustomizedTimeRange? TimeRange { get; set; }

                    /// <summary>
                    /// <para>当字段类型为时间段时，从此字段取值</para>
                    /// </summary>
                    public record TalentCustomizedTimeRange
                    {
                        /// <summary>
                        /// <para>开始时间</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625456721</para>
                        /// </summary>
                        [JsonProperty("start_time")]
                        public string? StartTime { get; set; }

                        /// <summary>
                        /// <para>结束时间，当值为至今时，返回「-」</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1625656721</para>
                        /// </summary>
                        [JsonProperty("end_time")]
                        public string? EndTime { get; set; }
                    }

                    /// <summary>
                    /// <para>当字段类型为日期选择、月份选择、年份选择时，从此字段取值，该字段是秒级时间戳</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1625456721</para>
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

                    /// <summary>
                    /// <para>当字段类型为附件时，从此字段取值</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("customized_attachment")]
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
                        [JsonProperty("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>附件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1.13测试1的面试记录.pdf</para>
                        /// </summary>
                        [JsonProperty("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>附件类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：application/pdf</para>
                        /// </summary>
                        [JsonProperty("content_type")]
                        public string? ContentType { get; set; }

                        /// <summary>
                        /// <para>附件大小</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：16615</para>
                        /// </summary>
                        [JsonProperty("file_size")]
                        public int? FileSize { get; set; }
                    }
                }
            }
        }

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
        [JsonProperty("top_degree")]
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
        [JsonProperty("first_degree")]
        public int? FirstDegree { get; set; }
    }
}
