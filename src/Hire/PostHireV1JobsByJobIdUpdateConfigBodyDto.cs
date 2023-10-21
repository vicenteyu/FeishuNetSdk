using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新职位设置 请求体
/// <para>更新职位设置，包括面试评价表、Offer 申请表等。接口将按照所选择的「更新选项」进行设置参数校验和更新。若设置的必填字段更新时未填写内容，接口将报错无法完成更新</para>
/// <para>接口ID：7012986483075563521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/update_config</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fupdate_config</para>
/// </summary>
public record PostHireV1JobsByJobIdUpdateConfigBodyDto
{
    /// <summary>
    /// <para>Offer 申请表，枚举通过接口「获取 Offer 申请表列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956573</para>
    /// </summary>
    [JsonProperty("offer_apply_schema_id")]
    public string? OfferApplySchemaId { get; set; }

    /// <summary>
    /// <para>Offer 审批流，枚举通过接口「获取 Offer 审批流列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956572</para>
    /// </summary>
    [JsonProperty("offer_process_conf")]
    public string? OfferProcessConf { get; set; }

    /// <summary>
    /// <para>建议评估人 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956573</para>
    /// </summary>
    [JsonProperty("recommended_evaluator_id_list")]
    public string[]? RecommendedEvaluatorIdList { get; set; }

    /// <summary>
    /// <para>更新选项，传入要更新的配置项</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("update_option_list")]
    public int[] UpdateOptionList { get; set; } = Array.Empty<int>();

    /// <summary>
    /// <para>面试评价表，枚举通过接口「获取面试评价表列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956571</para>
    /// </summary>
    [JsonProperty("assessment_template_biz_id")]
    public string? AssessmentTemplateBizId { get; set; }

    /// <summary>
    /// <para>建议面试官列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("interview_round_conf_list")]
    public JobConfigInterviewRoundConf[]? InterviewRoundConfLists { get; set; }

    /// <summary>
    /// <para>建议面试官列表</para>
    /// </summary>
    public record JobConfigInterviewRoundConf
    {
        /// <summary>
        /// <para>建议面试官 ID 列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956571</para>
        /// </summary>
        [JsonProperty("interviewer_id_list")]
        public string[]? InterviewerIdList { get; set; }

        /// <summary>
        /// <para>面试轮次</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("round")]
        public int? Round { get; set; }
    }

    /// <summary>
    /// <para>关联招聘需求，支持关联多个，枚举通过接口「获取招聘需求」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956572</para>
    /// </summary>
    [JsonProperty("jr_id_list")]
    public string[]? JrIdList { get; set; }

    /// <summary>
    /// <para>面试登记表ID，当在飞书招聘「设置 - 信息登记表使用设置 - 面试登记表使用方式」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonProperty("interview_registration_schema_id")]
    public string? InterviewRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>入职登记表ID，当在飞书招聘「设置 - 信息登记表使用设置 - 入职登记表使用方式」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonProperty("onboard_registration_schema_id")]
    public string? OnboardRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>面试轮次类型 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("interview_round_type_conf_list")]
    public JobConfigRoundType[]? InterviewRoundTypeConfLists { get; set; }

    /// <summary>
    /// <para>面试轮次类型 ID 列表</para>
    /// </summary>
    public record JobConfigRoundType
    {
        /// <summary>
        /// <para>面试轮次类型业务 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7012129842917837100</para>
        /// </summary>
        [JsonProperty("round_biz_id")]
        public string? RoundBizId { get; set; }

        /// <summary>
        /// <para>面试评价表业务 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956632</para>
        /// </summary>
        [JsonProperty("assessment_template_biz_id")]
        public string? AssessmentTemplateBizId { get; set; }
    }

    /// <summary>
    /// <para>关联职位列表，如职位为实体职位则关联虚拟职位id，如职位为虚拟职位则关联实体职位id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956574</para>
    /// </summary>
    [JsonProperty("related_job_id_list")]
    public string[]? RelatedJobIdList { get; set; }

    /// <summary>
    /// <para>自助约面配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("interview_appointment_config")]
    public PostHireV1JobsByJobIdUpdateConfigBodyDtoInterviewAppointmentConfig? InterviewAppointmentConfig { get; set; }

    /// <summary>
    /// <para>自助约面配置</para>
    /// </summary>
    public record PostHireV1JobsByJobIdUpdateConfigBodyDtoInterviewAppointmentConfig
    {
        /// <summary>
        /// <para>是否开启面试官自助约面</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("enable_interview_appointment_by_interviewer")]
        public bool? EnableInterviewAppointmentByInterviewer { get; set; }

        /// <summary>
        /// <para>配置详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("config")]
        public InterviewAppointmentConfigContent? Config { get; set; }

        /// <summary>
        /// <para>配置详情</para>
        /// </summary>
        public record InterviewAppointmentConfigContent
        {
            /// <summary>
            /// <para>面试类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：现场面试</item>
            /// <item>2：电话面试</item>
            /// <item>3：视频面试</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("interview_type")]
            public int? InterviewType { get; set; }

            /// <summary>
            /// <para>时区</para>
            /// <para>必填：否</para>
            /// <para>示例值：Asia/Shanghai</para>
            /// </summary>
            [JsonProperty("talent_timezone_code")]
            public string? TalentTimezoneCode { get; set; }

            /// <summary>
            /// <para>联系人id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c99c5f35d542efc7ee492afe11af19ef</para>
            /// </summary>
            [JsonProperty("contact_user_id")]
            public string? ContactUserId { get; set; }

            /// <summary>
            /// <para>联系人电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：151********</para>
            /// </summary>
            [JsonProperty("contact_mobile")]
            public string? ContactMobile { get; set; }

            /// <summary>
            /// <para>联系人邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@email</para>
            /// </summary>
            [JsonProperty("contact_email")]
            public string? ContactEmail { get; set; }

            /// <summary>
            /// <para>地址id</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956576</para>
            /// </summary>
            [JsonProperty("address_id")]
            public string? AddressId { get; set; }

            /// <summary>
            /// <para>地址id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：zoom</item>
            /// <item>2：牛客技术类型</item>
            /// <item>3：牛客非技术类型</item>
            /// <item>4：赛码</item>
            /// <item>5：飞书</item>
            /// <item>8：Hackerrank</item>
            /// <item>9：飞书(含代码考核)</item>
            /// <item>100：不使用系统工具</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("video_type")]
            public int? VideoType { get; set; }

            /// <summary>
            /// <para>抄送人id list</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c99c5f35d542efc7ee492afe11af19ef</para>
            /// </summary>
            [JsonProperty("cc")]
            public string[]? Cc { get; set; }

            /// <summary>
            /// <para>备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：备注</para>
            /// </summary>
            [JsonProperty("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>面试通知模板</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956573</para>
            /// </summary>
            [JsonProperty("interview_notification_template_id")]
            public string? InterviewNotificationTemplateId { get; set; }

            /// <summary>
            /// <para>预约通知模板</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956573</para>
            /// </summary>
            [JsonProperty("appointment_notification_template_id")]
            public string? AppointmentNotificationTemplateId { get; set; }

            /// <summary>
            /// <para>取消面试通知</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956573</para>
            /// </summary>
            [JsonProperty("cancel_interview_notification_template_id")]
            public string? CancelInterviewNotificationTemplateId { get; set; }
        }
    }
}
