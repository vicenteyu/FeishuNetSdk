// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1JobsByJobIdConfigResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取职位设置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取职位设置 响应体
/// <para>获取职位设置。</para>
/// <para>接口ID：7172190705011212292</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/config</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fconfig</para>
/// </summary>
public record GetHireV1JobsByJobIdConfigResponseDto
{
    /// <summary>
    /// <para>职位配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_config")]
    public JobConfigResult? JobConfig { get; set; }

    /// <summary>
    /// <para>职位配置</para>
    /// </summary>
    public record JobConfigResult
    {
        /// <summary>
        /// <para>Offer 申请表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("offer_apply_schema")]
        public IdNameObject? OfferApplySchema { get; set; }

        /// <summary>
        /// <para>Offer 申请表</para>
        /// </summary>
        public record IdNameObject
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1213213123123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>名称</para>
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
        /// <para>Offer 审批流</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("offer_process_conf")]
        public IdNameObject? OfferProcessConf { get; set; }

        /// <summary>
        /// <para>建议评估人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recommended_evaluator_list")]
        public IdNameObject[]? RecommendedEvaluatorLists { get; set; }

        /// <summary>
        /// <para>面试评价表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assessment_template")]
        public IdNameObject? AssessmentTemplate { get; set; }

        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956574</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>建议面试官列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_round_list")]
        public JobConfigInterviewRound[]? InterviewRoundLists { get; set; }

        /// <summary>
        /// <para>建议面试官列表</para>
        /// </summary>
        public record JobConfigInterviewRound
        {
            /// <summary>
            /// <para>面试官列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interviewer_list")]
            public IdNameObject[]? InterviewerLists { get; set; }

            /// <summary>
            /// <para>面试官列表</para>
            /// </summary>
            public record IdNameObject
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1213213123123</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>名称</para>
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
            /// <para>面试轮次</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("round")]
            public int? Round { get; set; }
        }

        /// <summary>
        /// <para>招聘需求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_requirement_list")]
        public IdNameObject[]? JobRequirementLists { get; set; }

        /// <summary>
        /// <para>面试登记表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_registration")]
        public RegistrationInfo? InterviewRegistration { get; set; }

        /// <summary>
        /// <para>面试登记表</para>
        /// </summary>
        public record RegistrationInfo
        {
            /// <summary>
            /// <para>面试登记表ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6930815272790114324</para>
            /// </summary>
            [JsonPropertyName("schema_id")]
            public string? SchemaId { get; set; }

            /// <summary>
            /// <para>面试登记表名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：默认登记表</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>入职登记表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("onboard_registration")]
        public RegistrationInfo? OnboardRegistration { get; set; }

        /// <summary>
        /// <para>面试轮次类型列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_round_type_list")]
        public JobConfigRoundTypeResult[]? InterviewRoundTypeLists { get; set; }

        /// <summary>
        /// <para>面试轮次类型列表</para>
        /// </summary>
        public record JobConfigRoundTypeResult
        {
            /// <summary>
            /// <para>面试轮次类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assessment_round")]
            public IdNameObject? AssessmentRound { get; set; }

            /// <summary>
            /// <para>面试轮次类型</para>
            /// </summary>
            public record IdNameObject
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1213213123123</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>名称</para>
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
            /// <para>面试评价表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assessment_template")]
            public IdNameObject? AssessmentTemplate { get; set; }
        }

        /// <summary>
        /// <para>关联职位列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("related_job_list")]
        public IdNameObject[]? RelatedJobLists { get; set; }

        /// <summary>
        /// <para>职位属性，1是实体职位，2是虚拟职位</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("job_attribute")]
        public int? JobAttribute { get; set; }

        /// <summary>
        /// <para>面试官安排面试配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_appointment_config")]
        public JobConfigResultInterviewAppointmentConfig? InterviewAppointmentConfig { get; set; }

        /// <summary>
        /// <para>面试官安排面试配置</para>
        /// </summary>
        public record JobConfigResultInterviewAppointmentConfig
        {
            /// <summary>
            /// <para>是否开启面试官安排面试</para>
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
                /// <para>时区</para>
                /// <para>必填：否</para>
                /// <para>示例值：Asia/Shanghai</para>
                /// </summary>
                [JsonPropertyName("talent_timezone_code")]
                public string? TalentTimezoneCode { get; set; }

                /// <summary>
                /// <para>联系人id</para>
                /// <para>必填：否</para>
                /// <para>示例值：ou_c99c5f35d542efc7ee492afe11af19ef</para>
                /// </summary>
                [JsonPropertyName("contact_user_id")]
                public string? ContactUserId { get; set; }

                /// <summary>
                /// <para>联系人电话</para>
                /// <para>必填：否</para>
                /// <para>示例值：177xxxx1773</para>
                /// </summary>
                [JsonPropertyName("contact_mobile")]
                public string? ContactMobile { get; set; }

                /// <summary>
                /// <para>联系人邮箱</para>
                /// <para>必填：否</para>
                /// <para>示例值：test@open.com</para>
                /// </summary>
                [JsonPropertyName("contact_email")]
                public string? ContactEmail { get; set; }

                /// <summary>
                /// <para>地址id</para>
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
                /// <para>抄送人id list</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("cc")]
                public string[]? Cc { get; set; }

                /// <summary>
                /// <para>备注</para>
                /// <para>必填：否</para>
                /// <para>示例值：备注</para>
                /// </summary>
                [JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// <para>面试通知模板</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956573</para>
                /// </summary>
                [JsonPropertyName("interview_notification_template_id")]
                public string? InterviewNotificationTemplateId { get; set; }

                /// <summary>
                /// <para>预约通知模板</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956573</para>
                /// </summary>
                [JsonPropertyName("appointment_notification_template_id")]
                public string? AppointmentNotificationTemplateId { get; set; }

                /// <summary>
                /// <para>取消面试通知</para>
                /// <para>必填：否</para>
                /// <para>示例值：6960663240925956573</para>
                /// </summary>
                [JsonPropertyName("cancel_interview_notification_template_id")]
                public string? CancelInterviewNotificationTemplateId { get; set; }
            }
        }
    }
}
