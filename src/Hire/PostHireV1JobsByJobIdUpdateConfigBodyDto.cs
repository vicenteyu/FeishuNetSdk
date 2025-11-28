// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-27
// ************************************************************************
// <copyright file="PostHireV1JobsByJobIdUpdateConfigBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新职位设置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新职位设置 请求体
/// <para>更新职位设置，包括面试评价表、Offer 申请表等。</para>
/// <para>## 注意事项</para>
/// <para>调用此接口前，需先打开「飞书招聘」-「设置」-「职位管理」-「职位设置」-「通过 API 同步职位开关」开关。</para>
/// <para>接口ID：7012986483075563521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/update_config</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fupdate_config</para>
/// </summary>
public record PostHireV1JobsByJobIdUpdateConfigBodyDto
{
    /// <summary>
    /// <para>Offer 申请表 ID，可通过[获取 Offer 申请表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/list)接口获取，当`update_option_list`包含`更新 Offer 申请表`时，该参数必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956573</para>
    /// </summary>
    [JsonPropertyName("offer_apply_schema_id")]
    public string? OfferApplySchemaId { get; set; }

    /// <summary>
    /// <para>Offer 审批流程 ID，可通过[获取 Offer 审批流配置列表](https://open.larkoffice.com/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_approval_template/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956572</para>
    /// </summary>
    [JsonPropertyName("offer_process_conf")]
    public string? OfferProcessConf { get; set; }

    /// <summary>
    /// <para>建议评估人 ID 列表，需与入参`user_id_type`类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956573</para>
    /// </summary>
    [JsonPropertyName("recommended_evaluator_id_list")]
    public string[]? RecommendedEvaluatorIdList { get; set; }

    /// <summary>
    /// <para>更新选项，传入要更新的配置项</para>
    /// <para>- 接口将按照所选择的「选项」进行设置参数校验和更新。若设置的必填字段更新时未填写内容，接口将报错无法完成更新。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：更新面试评价表</item>
    /// <item>2：更新 Offer 申请表</item>
    /// <item>3：更新 Offer 审批流程</item>
    /// <item>4：更新招聘需求</item>
    /// <item>5：更新建议面试官</item>
    /// <item>6：更新建议评估人</item>
    /// <item>8：更新关联职位</item>
    /// <item>9：更新面试官安排面试配置</item>
    /// <item>10：更新面试登记表</item>
    /// <item>11：更新入职登记表</item>
    /// <item>12：更新官网申请表</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("update_option_list")]
    public int[] UpdateOptionList { get; set; } = [];

    /// <summary>
    /// <para>面试评价表 ID，可通过[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)接口获取，当同时满足以下两个条件时，该参数必填：</para>
    /// <para>- `update_option_list`包含`更新面试评价表`</para>
    /// <para>- 「飞书招聘」-「设置」-「面试轮次类型设置」-「启用面试轮次类型」开关关闭</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956571</para>
    /// </summary>
    [JsonPropertyName("assessment_template_biz_id")]
    public string? AssessmentTemplateBizId { get; set; }

    /// <summary>
    /// <para>建议面试官列表，当`update_option_list`包含`更新建议面试官`时，该参数必填</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("interview_round_conf_list")]
    public JobConfigInterviewRoundConf[]? InterviewRoundConfLists { get; set; }

    /// <summary>
    /// <para>建议面试官列表，当`update_option_list`包含`更新建议面试官`时，该参数必填</para>
    /// </summary>
    public record JobConfigInterviewRoundConf
    {
        /// <summary>
        /// <para>建议面试官 ID 列表，需与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956571</para>
        /// </summary>
        [JsonPropertyName("interviewer_id_list")]
        public string[]? InterviewerIdList { get; set; }

        /// <summary>
        /// <para>面试轮次</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("round")]
        public int? Round { get; set; }
    }

    /// <summary>
    /// <para>关联招聘需求，可通过[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956572</para>
    /// </summary>
    [JsonPropertyName("jr_id_list")]
    public string[]? JrIdList { get; set; }

    /// <summary>
    /// <para>面试登记表 ID，可通过[获取面试登记表模板列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_registration_schema/list)接口获取。</para>
    /// <para>&lt;strong&gt;注意：</para>
    /// <para>- 当在「飞书招聘」-「设置」 -「信息登记表使用设置」 - 「申请表和登记表使用设置」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效</para>
    /// <para>- 当`update_option_list`包含`更新面试登记表`时，该参数必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("interview_registration_schema_id")]
    public string? InterviewRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>入职登记表 ID，可通过[获取信息登记表模板列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/registration_schema/list)接口获取。</para>
    /// <para>&lt;strong&gt;注意：</para>
    /// <para>- 当在飞书招聘「设置」 - 「信息登记表使用设置」 - 「入职登记表使用方式」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效</para>
    /// <para>- 当`update_option_list`包含`更新入职登记表`时，该参数必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("onboard_registration_schema_id")]
    public string? OnboardRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>面试轮次类型 ID 列表，当同时满足以下两个条件时，该参数必填：</para>
    /// <para>- `update_option_list`包含`更新面试评价表`</para>
    /// <para>- 「飞书招聘」-「设置」-「面试轮次类型设置」-「启用面试轮次类型」开关打开</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("interview_round_type_conf_list")]
    public JobConfigRoundType[]? InterviewRoundTypeConfLists { get; set; }

    /// <summary>
    /// <para>面试轮次类型 ID 列表，当同时满足以下两个条件时，该参数必填：</para>
    /// <para>- `update_option_list`包含`更新面试评价表`</para>
    /// <para>- 「飞书招聘」-「设置」-「面试轮次类型设置」-「启用面试轮次类型」开关打开</para>
    /// </summary>
    public record JobConfigRoundType
    {
        /// <summary>
        /// <para>面试轮次类型 ID，可通过接口[获取面试轮次类型列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_round_type/list)获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7012129842917837100</para>
        /// </summary>
        [JsonPropertyName("round_biz_id")]
        public string? RoundBizId { get; set; }

        /// <summary>
        /// <para>面试评价表 ID，可通过[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956632</para>
        /// </summary>
        [JsonPropertyName("assessment_template_biz_id")]
        public string? AssessmentTemplateBizId { get; set; }
    }

    /// <summary>
    /// <para>关联职位列表，如职位为实体职位则关联虚拟职位 ID，如职位为虚拟职位则关联实体职位 ID，可通过[获取职位列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956574</para>
    /// </summary>
    [JsonPropertyName("related_job_id_list")]
    public string[]? RelatedJobIdList { get; set; }

    /// <summary>
    /// <para>自助约面配置，当`update_option_list`包含`更新面试官安排面试配置`时，该参数必填</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("interview_appointment_config")]
    public PostHireV1JobsByJobIdUpdateConfigBodyDtoInterviewAppointmentConfig? InterviewAppointmentConfig { get; set; }

    /// <summary>
    /// <para>自助约面配置，当`update_option_list`包含`更新面试官安排面试配置`时，该参数必填</para>
    /// </summary>
    public record PostHireV1JobsByJobIdUpdateConfigBodyDtoInterviewAppointmentConfig
    {
        /// <summary>
        /// <para>是否开启面试官自助约面</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable_interview_appointment_by_interviewer")]
        public bool? EnableInterviewAppointmentByInterviewer { get; set; }

        /// <summary>
        /// <para>配置详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("config")]
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
            [JsonPropertyName("interview_type")]
            public int? InterviewType { get; set; }

            /// <summary>
            /// <para>候选人时区</para>
            /// <para>必填：否</para>
            /// <para>示例值：Asia/Shanghai</para>
            /// </summary>
            [JsonPropertyName("talent_timezone_code")]
            public string? TalentTimezoneCode { get; set; }

            /// <summary>
            /// <para>面试联系人 ID，需与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c99c5f35d542efc7ee492afe11af19ef</para>
            /// </summary>
            [JsonPropertyName("contact_user_id")]
            public string? ContactUserId { get; set; }

            /// <summary>
            /// <para>面试联系人电话</para>
            /// <para>必填：否</para>
            /// <para>示例值：151********</para>
            /// </summary>
            [JsonPropertyName("contact_mobile")]
            public string? ContactMobile { get; set; }

            /// <summary>
            /// <para>面试联系人邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：test@email</para>
            /// </summary>
            [JsonPropertyName("contact_email")]
            public string? ContactEmail { get; set; }

            /// <summary>
            /// <para>面试地点 ID，可通过[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956576</para>
            /// </summary>
            [JsonPropertyName("address_id")]
            public string? AddressId { get; set; }

            /// <summary>
            /// <para>视频面试类型</para>
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
            [JsonPropertyName("video_type")]
            public int? VideoType { get; set; }

            /// <summary>
            /// <para>抄送人 ID 列表，需与入参`user_id_type`类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_c99c5f35d542efc7ee492afe11af19ef</para>
            /// </summary>
            [JsonPropertyName("cc")]
            public string[]? Cc { get; set; }

            /// <summary>
            /// <para>面试配置备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：仅仅用于视频面试</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>面试通知模板 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956573</para>
            /// </summary>
            [JsonPropertyName("interview_notification_template_id")]
            public string? InterviewNotificationTemplateId { get; set; }

            /// <summary>
            /// <para>预约通知模板 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956573</para>
            /// </summary>
            [JsonPropertyName("appointment_notification_template_id")]
            public string? AppointmentNotificationTemplateId { get; set; }

            /// <summary>
            /// <para>取消面试通知模版 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956573</para>
            /// </summary>
            [JsonPropertyName("cancel_interview_notification_template_id")]
            public string? CancelInterviewNotificationTemplateId { get; set; }
        }
    }

    /// <summary>
    /// <para>官网申请表ID，可通过[获取招聘官网申请表模板列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/portal_apply_schema/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("portal_website_apply_form_schema_id")]
    public string? PortalWebsiteApplyFormSchemaId { get; set; }
}
