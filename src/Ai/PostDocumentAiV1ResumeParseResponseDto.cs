namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的简历信息 响应体
/// <para>简历信息解析接口，支持PDF/DOCX/PNG/JPG四种文件类型的一次性的识别。</para>
/// <para>接口ID：7340987945434742812</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/resume/parse</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fresume%2fparse</para>
/// </summary>
public record PostDocumentAiV1ResumeParseResponseDto
{
    /// <summary>
    /// <para>简历信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：99</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("resumes")]
    public Resume[]? Resumes { get; set; }

    /// <summary>
    /// <para>简历信息</para>
    /// </summary>
    public record Resume
    {
        /// <summary>
        /// <para>文件标识ID，依据文件内容自动生成</para>
        /// <para>必填：否</para>
        /// <para>示例值：825c59042dxxxxx3ff90b45xxxxx88</para>
        /// </summary>
        [JsonPropertyName("file_md5")]
        public string? FileMd5 { get; set; }

        /// <summary>
        /// <para>文本内容，当接口返回成功时，该字段才存在</para>
        /// <para>必填：否</para>
        /// <para>示例值：XX负责行政人事管理和日常事务...</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>经过排序后的文本内容，当接口返回成功时，该字段才存在</para>
        /// <para>必填：否</para>
        /// <para>示例值：XX负责行政人事管理和日常事务...</para>
        /// </summary>
        [JsonPropertyName("new_content")]
        public string? NewContent { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan.1111@company.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>手机号码</para>
        /// <para>必填：否</para>
        /// <para>示例值：13600000000</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>手机号码是否虚拟号码</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("mobile_is_virtual")]
        public bool? MobileIsVirtual { get; set; }

        /// <summary>
        /// <para>手机号码国家编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：86</para>
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// <para>教育经历</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("educations")]
        public ResumeEducation[]? Educations { get; set; }

        /// <summary>
        /// <para>教育经历</para>
        /// </summary>
        public record ResumeEducation
        {
            /// <summary>
            /// <para>学校名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：A大学</para>
            /// </summary>
            [JsonPropertyName("school")]
            public string? School { get; set; }

            /// <summary>
            /// <para>开始时间,格式：YYYY-MM-DD</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-03</para>
            /// </summary>
            [JsonPropertyName("start_date")]
            public string? StartDate { get; set; }

            /// <summary>
            /// <para>开始时间,格式：YYYY-MM-DD,跟start_date值一样</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-01-03</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间,格式：YYYY-MM-DD</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-01-03</para>
            /// </summary>
            [JsonPropertyName("end_date")]
            public string? EndDate { get; set; }

            /// <summary>
            /// <para>结束时间,格式：YYYY-MM-DD 或 “至今”，当值为“至今”时，end_date=="",值为其他时，end_date==end_time</para>
            /// <para>必填：否</para>
            /// <para>示例值：至今</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>专业</para>
            /// <para>必填：否</para>
            /// <para>示例值：XX工程</para>
            /// </summary>
            [JsonPropertyName("major")]
            public string? Major { get; set; }

            /// <summary>
            /// <para>学历——小学、初中、中职、高中、专科、本科、硕士、博士、其他</para>
            /// <para>必填：否</para>
            /// <para>示例值：本科</para>
            /// </summary>
            [JsonPropertyName("degree")]
            public string? Degree { get; set; }

            /// <summary>
            /// <para>学历对应ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：小学</item>
            /// <item>2：初中</item>
            /// <item>3：中职</item>
            /// <item>4：高中</item>
            /// <item>5：专科</item>
            /// <item>6：本科</item>
            /// <item>7：硕士</item>
            /// <item>8：博士</item>
            /// <item>9：其他</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("qualification")]
            public int? Qualification { get; set; }
        }

        /// <summary>
        /// <para>职业经历</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("careers")]
        public ResumeCareer[]? Careers { get; set; }

        /// <summary>
        /// <para>职业经历</para>
        /// </summary>
        public record ResumeCareer
        {
            /// <summary>
            /// <para>公司名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：XX公司</para>
            /// </summary>
            [JsonPropertyName("company")]
            public string? Company { get; set; }

            /// <summary>
            /// <para>开始时间,格式：YYYY-MM-DD</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-01-03</para>
            /// </summary>
            [JsonPropertyName("start_date")]
            public string? StartDate { get; set; }

            /// <summary>
            /// <para>始时间,格式：YYYY-MM-DD,跟start_date值一样</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-01-03</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间,格式：YYYY-MM-DD</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-03</para>
            /// </summary>
            [JsonPropertyName("end_date")]
            public string? EndDate { get; set; }

            /// <summary>
            /// <para>结束时间,格式：YYYY-MM-DD 或 “至今”，当值为“至今”时，end_date=="",值为其他时，end_date==end_time</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-03</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>职位</para>
            /// <para>必填：否</para>
            /// <para>示例值：XXX工程师</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>工作类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：实习</item>
            /// <item>2：全职</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>工作类型——'实习'、'全职'</para>
            /// <para>必填：否</para>
            /// <para>示例值：全职</para>
            /// </summary>
            [JsonPropertyName("type_str")]
            public string? TypeStr { get; set; }

            /// <summary>
            /// <para>工作描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：负责XXX开发...</para>
            /// </summary>
            [JsonPropertyName("job_description")]
            public string? JobDescription { get; set; }
        }

        /// <summary>
        /// <para>项目经历</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("projects")]
        public ResumeProject[]? Projects { get; set; }

        /// <summary>
        /// <para>项目经历</para>
        /// </summary>
        public record ResumeProject
        {
            /// <summary>
            /// <para>项目名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：XX项目</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>项目岗位</para>
            /// <para>必填：否</para>
            /// <para>示例值：客户端研发</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>开始时间,格式：YYYY-MM-DD</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-03</para>
            /// </summary>
            [JsonPropertyName("start_date")]
            public string? StartDate { get; set; }

            /// <summary>
            /// <para>开始时间,格式：YYYY-MM-DD,跟start_date值一样</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-03</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间,格式：YYYY-MM-DD</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-04</para>
            /// </summary>
            [JsonPropertyName("end_date")]
            public string? EndDate { get; set; }

            /// <summary>
            /// <para>结束时间,格式：YYYY-MM-DD 或 “至今”，当值为“至今”时，end_date=="",值</para>
            /// <para>必填：否</para>
            /// <para>示例值：2023-01-04</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>项目描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：XXX项目是一个...</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }
        }

        /// <summary>
        /// <para>工作年限，为空表示工作年限未知，数字单位为年，整数</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// <para>最大值：100</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("work_year")]
        public int? WorkYear { get; set; }

        /// <summary>
        /// <para>生日，格式YYYY-MM-DD</para>
        /// <para>必填：否</para>
        /// <para>示例值：1995-01-01</para>
        /// </summary>
        [JsonPropertyName("date_of_birth")]
        public string? DateOfBirth { get; set; }

        /// <summary>
        /// <para>性别</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：男性</item>
        /// <item>2：女性</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// <para>希望获得的职位列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx岗位</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("willing_positions")]
        public string[]? WillingPositions { get; set; }

        /// <summary>
        /// <para>当前工作地点(城市)</para>
        /// <para>必填：否</para>
        /// <para>示例值：上海</para>
        /// </summary>
        [JsonPropertyName("current_location")]
        public string? CurrentLocation { get; set; }

        /// <summary>
        /// <para>希望工作地点列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("willing_locations")]
        public string[]? WillingLocations { get; set; }

        /// <summary>
        /// <para>家乡(城市)</para>
        /// <para>必填：否</para>
        /// <para>示例值：上海</para>
        /// </summary>
        [JsonPropertyName("home_location")]
        public string? HomeLocation { get; set; }

        /// <summary>
        /// <para>语言</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("languages")]
        public ResumeLanguage[]? Languages { get; set; }

        /// <summary>
        /// <para>语言</para>
        /// </summary>
        public record ResumeLanguage
        {
            /// <summary>
            /// <para>语言等级</para>
            /// <para>必填：否</para>
            /// <para>示例值：6</para>
            /// <para>最大值：99999</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }

            /// <summary>
            /// <para>语言描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：英语</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }
        }

        /// <summary>
        /// <para>获奖</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("awards")]
        public ResumeAward[]? Awards { get; set; }

        /// <summary>
        /// <para>获奖</para>
        /// </summary>
        public record ResumeAward
        {
            /// <summary>
            /// <para>奖项</para>
            /// <para>必填：否</para>
            /// <para>示例值：XXX大赛奖项</para>
            /// </summary>
            [JsonPropertyName("award")]
            public string? Award { get; set; }

            /// <summary>
            /// <para>获奖时间，格式：YYYY</para>
            /// <para>必填：否</para>
            /// <para>示例值：2015</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：曾获XXX大赛奖项...</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }
        }

        /// <summary>
        /// <para>证书</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("certificates")]
        public ResumeCertificate[]? Certificates { get; set; }

        /// <summary>
        /// <para>证书</para>
        /// </summary>
        public record ResumeCertificate
        {
            /// <summary>
            /// <para>证书名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：XXX证书</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：曾获得XXX证书...</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }
        }

        /// <summary>
        /// <para>竞赛</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("competitions")]
        public ResumeCompetition[]? Competitions { get; set; }

        /// <summary>
        /// <para>竞赛</para>
        /// </summary>
        public record ResumeCompetition
        {
            /// <summary>
            /// <para>竞赛名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：XXX竞赛</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：曾参加XXX竞赛...</para>
            /// </summary>
            [JsonPropertyName("desc")]
            public string? Desc { get; set; }
        }

        /// <summary>
        /// <para>自我评价</para>
        /// <para>必填：否</para>
        /// <para>示例值：我是一个...</para>
        /// </summary>
        [JsonPropertyName("self_evaluation")]
        public string? SelfEvaluation { get; set; }

        /// <summary>
        /// <para>链接列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("urls")]
        public string[]? Urls { get; set; }

        /// <summary>
        /// <para>社交链接</para>
        /// <para>必填：否</para>
        /// <para>最大长度：99</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("social_links")]
        public string[]? SocialLinks { get; set; }
    }
}
