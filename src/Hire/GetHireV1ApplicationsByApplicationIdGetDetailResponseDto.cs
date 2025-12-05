// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2025-04-18
// ************************************************************************
// <copyright file="GetHireV1ApplicationsByApplicationIdGetDetailResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取投递详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取投递详情 响应体
/// <para>根据投递 ID 获取投递信息并通过参数按需获取该投递相关的实体信息，如「职位」、「人才」、「评估」、「面试」、「Offer」、「猎头」、「内推」、「官网」等实体的信息。</para>
/// <para>接口ID：7397703144758165532</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/application/get_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fget_detail</para>
/// </summary>
public record GetHireV1ApplicationsByApplicationIdGetDetailResponseDto
{
    /// <summary>
    /// <para>投递详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_detail")]
    public ApplicationDetailInfo? ApplicationDetail { get; set; }

    /// <summary>
    /// <para>投递详情</para>
    /// </summary>
    public record ApplicationDetailInfo
    {
        /// <summary>
        /// <para>投递基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("basic_info")]
        public ApplicationDetailBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// <para>投递基本信息</para>
        /// </summary>
        public record ApplicationDetailBasicInfo
        {
            /// <summary>
            /// <para>投递 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6949805467799537964</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位 ID，详情请查看：[获取职位信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6843547872837273223</para>
            /// </summary>
            [JsonPropertyName("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>人才 ID，详情请查看：[获取人才信息 V1](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6843547872837273223</para>
            /// </summary>
            [JsonPropertyName("talent_id")]
            public string? TalentId { get; set; }

            /// <summary>
            /// <para>投递处于的阶段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("stage")]
            public ApplicationStageInfo? Stage { get; set; }

            /// <summary>
            /// <para>投递处于的阶段</para>
            /// </summary>
            public record ApplicationStageInfo
            {
                /// <summary>
                /// <para>投递阶段 ID，详情可查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：614218419274131</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>投递阶段中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：面试</para>
                /// </summary>
                [JsonPropertyName("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>投递阶段英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interview</para>
                /// </summary>
                [JsonPropertyName("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>阶段类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：筛选型</item>
                /// <item>2：评估型</item>
                /// <item>3：笔试型</item>
                /// <item>4：面试型</item>
                /// <item>5：Offer型</item>
                /// <item>6：待入职</item>
                /// <item>7：已入职</item>
                /// <item>8：其它类型</item>
                /// <item>255：系统默认</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("type")]
                public int? Type { get; set; }
            }

            /// <summary>
            /// <para>投递活跃状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：活跃</item>
            /// <item>2：非活跃</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("active_status")]
            public int? ActiveStatus { get; set; }

            /// <summary>
            /// <para>投递方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：HR寻访</item>
            /// <item>2：候选人主动投递</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("delivery_type")]
            public int? DeliveryType { get; set; }

            /// <summary>
            /// <para>投递来源信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resume_source_info")]
            public ApplicationResumeSource? ResumeSourceInfo { get; set; }

            /// <summary>
            /// <para>投递来源信息</para>
            /// </summary>
            public record ApplicationResumeSource
            {
                /// <summary>
                /// <para>投递来源 ID，详情请查看[获取简历来源列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/resume_source/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：614218419274131</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>投递来源名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>投递来源名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>投递来源中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：内推</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>投递来源英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Referral</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>投递来源类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：10002</para>
                /// <para>可选值：<list type="bullet">
                /// <item>10000：内推</item>
                /// <item>10001：猎头</item>
                /// <item>10002：内部来源</item>
                /// <item>10003：第三方招聘网站</item>
                /// <item>10004：社交媒体</item>
                /// <item>10005：线下来源</item>
                /// <item>10006：其他</item>
                /// <item>10007：外部推荐</item>
                /// <item>10008：员工转岗</item>
                /// <item>10009：实习生转正</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("resume_source_type")]
                public int? ResumeSourceType { get; set; }
            }

            /// <summary>
            /// <para>官网投递来源（当从官网进行投递时返回）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("website_resume_source")]
            public ApplicationWebsiteResumeSource? WebsiteResumeSource { get; set; }

            /// <summary>
            /// <para>官网投递来源（当从官网进行投递时返回）</para>
            /// </summary>
            public record ApplicationWebsiteResumeSource
            {
                /// <summary>
                /// <para>官网站点 ID，详情请查看：[获取招聘官网列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：614218419274131</para>
                /// </summary>
                [JsonPropertyName("website_id")]
                public string? WebsiteId { get; set; }

                /// <summary>
                /// <para>官网站点名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("website_name")]
                public I18n? WebsiteName { get; set; }

                /// <summary>
                /// <para>官网站点名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>官网站点中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：新希望官网</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>官网站点英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：New hope offical</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>推广渠道来源</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("channel")]
                public ApplicationWebsiteChannel? Channel { get; set; }

                /// <summary>
                /// <para>推广渠道来源</para>
                /// </summary>
                public record ApplicationWebsiteChannel
                {
                    /// <summary>
                    /// <para>推广渠道 ID，详情请查看[获取招聘官网推广渠道列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-channel/list)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：777218419274131</para>
                    /// </summary>
                    [JsonPropertyName("channel_id")]
                    public string? ChannelId { get; set; }

                    /// <summary>
                    /// <para>推广渠道名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("channel_name")]
                    public I18n? ChannelName { get; set; }

                    /// <summary>
                    /// <para>推广渠道名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>推广渠道中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：领英</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>推广渠道英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：LinkedIn</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>简历附件 ID，详情请查看 ：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
            /// <para>「备注信息：只有站内创投时上传的简历附件才能关联取值，渠道/官网/内推创投的简历附件不会关联」</para>
            /// <para>必填：否</para>
            /// <para>示例值：6960663240925956415</para>
            /// </summary>
            [JsonPropertyName("talent_attachment_resume_id")]
            public string? TalentAttachmentResumeId { get; set; }

            /// <summary>
            /// <para>投递阶段变更时间列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("stage_time_list")]
            public ApplicationStageTime[]? StageTimeLists { get; set; }

            /// <summary>
            /// <para>投递阶段变更时间列表</para>
            /// </summary>
            public record ApplicationStageTime
            {
                /// <summary>
                /// <para>阶段 ID，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：614218419274131</para>
                /// </summary>
                [JsonPropertyName("stage_id")]
                public string? StageId { get; set; }

                /// <summary>
                /// <para>最近一次进入该阶段的时间（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1632991542615</para>
                /// </summary>
                [JsonPropertyName("enter_time")]
                public string? EnterTime { get; set; }

                /// <summary>
                /// <para>最后一次离开时间（单位：毫秒），如当前在该阶段，则为空</para>
                /// <para>必填：否</para>
                /// <para>示例值：1631509574398</para>
                /// </summary>
                [JsonPropertyName("exit_time")]
                public string? ExitTime { get; set; }
            }

            /// <summary>
            /// <para>投递入职状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未入职</item>
            /// <item>2：已入职</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("onboard_status")]
            public int? OnboardStatus { get; set; }

            /// <summary>
            /// <para>意向投递城市列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("application_preferred_city_list")]
            public CodeNameObject[]? ApplicationPreferredCityLists { get; set; }

            /// <summary>
            /// <para>意向投递城市列表</para>
            /// </summary>
            public record CodeNameObject
            {
                /// <summary>
                /// <para>城市编码，详情请参考：[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)</para>
                /// <para>必填：否</para>
                /// <para>示例值：CT _1</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>城市名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>城市名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>城市中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：北京</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>城市英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Beijing</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>投递终止原因</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("termination_reason")]
            public TerminationReasonInfo? TerminationReason { get; set; }

            /// <summary>
            /// <para>投递终止原因</para>
            /// </summary>
            public record TerminationReasonInfo
            {
                /// <summary>
                /// <para>终止原因 ID，详情请查看：[获取终止投递原因](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/termination_reason/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6891258038901016846</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>终止原因名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>终止原因名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>终止原因中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：候选人拒绝</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>终止原因英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Candidate rejected</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>子级终止原因</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("children")]
                public TerminationReasonChildInfo[]? Childrens { get; set; }

                /// <summary>
                /// <para>子级终止原因</para>
                /// </summary>
                public record TerminationReasonChildInfo
                {
                    /// <summary>
                    /// <para>终止原因 ID，详情请查看：[获取终止投递原因](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/termination_reason/list)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6891258038901016846</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>终止原因名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>终止原因名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>终止原因中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：对公司业务不感兴趣</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>终止原因英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Not interested in company business</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>投递创建者 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>**注意**：</para>
            /// <para>仅当投递创建人为企业内部员工时可获取（如员工手动上传简历 / 加入职位 / 内推），其余情况返回为空（如候选人主动投递。当投递创建者是外部租户，user_id_type默认为lark_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
            /// </summary>
            [JsonPropertyName("creator_id")]
            public string? CreatorId { get; set; }

            /// <summary>
            /// <para>投递所有者 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_ce913028fe74123221f5dc320bb9c709</para>
            /// </summary>
            [JsonPropertyName("owner_id")]
            public string? OwnerId { get; set; }

            /// <summary>
            /// <para>投递终止者 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_ce913028fe74123221f5dc320bb9c709</para>
            /// </summary>
            [JsonPropertyName("terminator_id")]
            public string? TerminatorId { get; set; }

            /// <summary>
            /// <para>创建时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1632990774278</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>修改时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1634801678103</para>
            /// </summary>
            [JsonPropertyName("modify_time")]
            public string? ModifyTime { get; set; }
        }

        /// <summary>
        /// <para>投递职位信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job")]
        public JobBasicInfo? Job { get; set; }

        /// <summary>
        /// <para>投递职位信息</para>
        /// </summary>
        public record JobBasicInfo
        {
            /// <summary>
            /// <para>职位 ID，详情请查看：[获取职位信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6956499586395523359</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：后端研发工程师</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>职位编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：A75256</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }
        }

        /// <summary>
        /// <para>投递人才信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("talent")]
        public TalentBasicInfoV2? Talent { get; set; }

        /// <summary>
        /// <para>投递人才信息</para>
        /// </summary>
        public record TalentBasicInfoV2
        {
            /// <summary>
            /// <para>人才 ID，详情请查看：[获取人才信息 V1](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6956499586395523359</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>人才名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：小明</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>人才手机国家区号</para>
            /// <para>必填：否</para>
            /// <para>示例值：+86</para>
            /// </summary>
            [JsonPropertyName("mobile_code")]
            public string? MobileCode { get; set; }

            /// <summary>
            /// <para>人才手机号</para>
            /// <para>必填：否</para>
            /// <para>示例值：13563350751</para>
            /// </summary>
            [JsonPropertyName("mobile_number")]
            public string? MobileNumber { get; set; }

            /// <summary>
            /// <para>人才邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx@bytedance.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }
        }

        /// <summary>
        /// <para>投递评估信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("evaluations")]
        public Evaluation[]? Evaluations { get; set; }

        /// <summary>
        /// <para>投递评估信息</para>
        /// </summary>
        public record Evaluation
        {
            /// <summary>
            /// <para>评估 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6875295756292425998</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>投递 ID，详情请查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6875569957036738823</para>
            /// </summary>
            [JsonPropertyName("application_id")]
            public string? ApplicationId { get; set; }

            /// <summary>
            /// <para>投递阶段 ID，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6784315427607595268</para>
            /// </summary>
            [JsonPropertyName("stage_id")]
            public string? StageId { get; set; }

            /// <summary>
            /// <para>创建人用户 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_aaf83d1b2c856ead36aa9a38784b9a5c</para>
            /// </summary>
            [JsonPropertyName("creator_id")]
            public string? CreatorId { get; set; }

            /// <summary>
            /// <para>评估人用户 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_aaf83d1b2c856ead36aa9a38784b9a5c</para>
            /// </summary>
            [JsonPropertyName("evaluator_id")]
            public string? EvaluatorId { get; set; }

            /// <summary>
            /// <para>提交状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：已提交</item>
            /// <item>2：未提交</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("commit_status")]
            public int? CommitStatus { get; set; }

            /// <summary>
            /// <para>评估结论</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：通过</item>
            /// <item>2：未通过</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("conclusion")]
            public int? Conclusion { get; set; }

            /// <summary>
            /// <para>评估详情</para>
            /// <para>必填：否</para>
            /// <para>示例值：这位同学很优秀</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>评估创建时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1600843767338</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>评估最近更新时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1600843937733</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }
        }

        /// <summary>
        /// <para>投递面试信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_aggregation")]
        public ApplicationDetailInfoInterviewAggregation? InterviewAggregation { get; set; }

        /// <summary>
        /// <para>投递面试信息</para>
        /// </summary>
        public record ApplicationDetailInfoInterviewAggregation
        {
            /// <summary>
            /// <para>面试信息列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("interviews")]
            public InterviewExtendV2[]? Interviews { get; set; }

            /// <summary>
            /// <para>面试信息列表</para>
            /// </summary>
            public record InterviewExtendV2
            {
                /// <summary>
                /// <para>面试 ID，详情请查看：[获取面试信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview/list)</para>
                /// <para>必填：否</para>
                /// <para>示例值：6949805467799537964</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>面试开始时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618899376474</para>
                /// </summary>
                [JsonPropertyName("begin_time")]
                public string? BeginTime { get; set; }

                /// <summary>
                /// <para>面试结束时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618999376474</para>
                /// </summary>
                [JsonPropertyName("end_time")]
                public string? EndTime { get; set; }

                /// <summary>
                /// <para>面试轮次（从0开始计数）</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("round")]
                public int? Round { get; set; }

                /// <summary>
                /// <para>面试评价信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("interview_record_list")]
                public InterviewRecordV2[]? InterviewRecordLists { get; set; }

                /// <summary>
                /// <para>面试评价信息</para>
                /// </summary>
                public record InterviewRecordV2
                {
                    /// <summary>
                    /// <para>面试评价 ID，详情请查看：[获取面试评价详细信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/interview_record/get)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7171693733661327361</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>面试评价表 ID，详情请查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：71716937336613273612</para>
                    /// </summary>
                    [JsonPropertyName("feedback_form_id")]
                    public string? FeedbackFormId { get; set; }

                    /// <summary>
                    /// <para>提交状态</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：已提交</item>
                    /// <item>2：未提交</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("commit_status")]
                    public int? CommitStatus { get; set; }

                    /// <summary>
                    /// <para>面试评价提交时间戳（单位：毫秒）</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1710405457390</para>
                    /// </summary>
                    [JsonPropertyName("submit_time")]
                    public string? SubmitTime { get; set; }

                    /// <summary>
                    /// <para>面试评价分数</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("record_score")]
                    public InterviewRecordV2RecordScore? RecordScore { get; set; }

                    /// <summary>
                    /// <para>面试评价分数</para>
                    /// </summary>
                    public record InterviewRecordV2RecordScore
                    {
                        /// <summary>
                        /// <para>面试评价得分（精确到小数点后两位）</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：85.33</para>
                        /// <para>最大值：2147483647</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("score")]
                        public float? Score { get; set; }

                        /// <summary>
                        /// <para>面试评价总分（精确到小数点后两位）</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：100</para>
                        /// <para>最大值：2147483647</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("total_score")]
                        public float? TotalScore { get; set; }
                    }

                    /// <summary>
                    /// <para>面试官信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("interviewer")]
                    public BasicUserInfo? Interviewer { get; set; }

                    /// <summary>
                    /// <para>面试官信息</para>
                    /// </summary>
                    public record BasicUserInfo
                    {
                        /// <summary>
                        /// <para>面试官用户 ID，与入参 `user_id_type` 类型一致</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：6956499586395523359</para>
                        /// </summary>
                        [JsonPropertyName("id")]
                        public string? Id { get; set; }

                        /// <summary>
                        /// <para>面试官名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public I18n? Name { get; set; }

                        /// <summary>
                        /// <para>面试官名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>面试官中文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：张三</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>面试官英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Tom cruise</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>面试评价附件列表</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：1000</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("attachments")]
                    public InterviewAttachment[]? Attachments { get; set; }

                    /// <summary>
                    /// <para>面试评价附件列表</para>
                    /// </summary>
                    public record InterviewAttachment
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
                        /// <para>附件创建时间戳（单位：毫秒）</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1710399930151</para>
                        /// </summary>
                        [JsonPropertyName("create_time")]
                        public string? CreateTime { get; set; }
                    }

                    /// <summary>
                    /// <para>模块评价列表</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：1000</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("module_assessments")]
                    public ModuleAssessment[]? ModuleAssessments { get; set; }

                    /// <summary>
                    /// <para>模块评价列表</para>
                    /// </summary>
                    public record ModuleAssessment
                    {
                        /// <summary>
                        /// <para>面试评价表模块 ID，详情请查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)</para>
                        /// <para>接口中的 module 的 ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：7171693733661327361</para>
                        /// </summary>
                        [JsonPropertyName("interview_feedback_form_module_id")]
                        public string? InterviewFeedbackFormModuleId { get; set; }

                        /// <summary>
                        /// <para>模块名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("module_name")]
                        public I18n? ModuleName { get; set; }

                        /// <summary>
                        /// <para>模块名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>模块中文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：模块一</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>模块英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Module 1</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>模块类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：系统预置「面试结论」模块</item>
                        /// <item>2：自定义模块（无模块名称）</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("module_type")]
                        public int? ModuleType { get; set; }

                        /// <summary>
                        /// <para>模块权重</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：10</para>
                        /// <para>最大值：2147483647</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("module_weight")]
                        public float? ModuleWeight { get; set; }

                        /// <summary>
                        /// <para>模块打分（精确到小数点后两位）</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：10</para>
                        /// <para>最大值：2147483647</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("module_score")]
                        public float? ModuleScore { get; set; }

                        /// <summary>
                        /// <para>模块评价</para>
                        /// <para>必填：否</para>
                        /// <para>最大长度：1000</para>
                        /// <para>最小长度：0</para>
                        /// </summary>
                        [JsonPropertyName("dimension_assessments")]
                        public DimensionAssessment[]? DimensionAssessments { get; set; }

                        /// <summary>
                        /// <para>模块评价</para>
                        /// </summary>
                        public record DimensionAssessment
                        {
                            /// <summary>
                            /// <para>对应模版中维度 ID，详情请查看：[获取面试评价表列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_feedback_form/list)</para>
                            /// <para>接口中的 dimension 的 ID</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：7171693733661327361</para>
                            /// </summary>
                            [JsonPropertyName("interview_feedback_form_dimension_id")]
                            public string? InterviewFeedbackFormDimensionId { get; set; }

                            /// <summary>
                            /// <para>维度名称</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("dimension_name")]
                            public I18n? DimensionName { get; set; }

                            /// <summary>
                            /// <para>维度名称</para>
                            /// </summary>
                            public record I18n
                            {
                                /// <summary>
                                /// <para>维度中文名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：维度一</para>
                                /// </summary>
                                [JsonPropertyName("zh_cn")]
                                public string? ZhCn { get; set; }

                                /// <summary>
                                /// <para>维度英文名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：Dimension 1</para>
                                /// </summary>
                                [JsonPropertyName("en_us")]
                                public string? EnUs { get; set; }
                            }

                            /// <summary>
                            /// <para>维度类型</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>可选值：<list type="bullet">
                            /// <item>1：单选题</item>
                            /// <item>2：多选题</item>
                            /// <item>3：描述题</item>
                            /// <item>5：职级建议</item>
                            /// <item>6：打分题(单选)</item>
                            /// <item>7：打分题(填空)</item>
                            /// <item>10：系统预置-结论</item>
                            /// <item>11：系统预置-得分</item>
                            /// <item>12：系统预置-记录</item>
                            /// </list></para>
                            /// </summary>
                            [JsonPropertyName("dimension_type")]
                            public int? DimensionType { get; set; }

                            /// <summary>
                            /// <para>维度权重</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// <para>最大值：2147483647</para>
                            /// <para>最小值：0</para>
                            /// </summary>
                            [JsonPropertyName("weight")]
                            public float? Weight { get; set; }

                            /// <summary>
                            /// <para>当维度类型为描述题时，从此取值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：描述题作答</para>
                            /// </summary>
                            [JsonPropertyName("dimension_content")]
                            public string? DimensionContent { get; set; }

                            /// <summary>
                            /// <para>当维度类型为单选题时，从此取值</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("dimension_option")]
                            public DimensionAssessmentDimensionOption? DimensionOption { get; set; }

                            /// <summary>
                            /// <para>当维度类型为单选题时，从此取值</para>
                            /// </summary>
                            public record DimensionAssessmentDimensionOption
                            {
                                /// <summary>
                                /// <para>选项 ID</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：7171693733661327361</para>
                                /// </summary>
                                [JsonPropertyName("id")]
                                public string? Id { get; set; }

                                /// <summary>
                                /// <para>选项名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：7171693733661327361</para>
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
                                    /// <para>示例值：选项一</para>
                                    /// </summary>
                                    [JsonPropertyName("zh_cn")]
                                    public string? ZhCn { get; set; }

                                    /// <summary>
                                    /// <para>选项英文名称</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：Option 1</para>
                                    /// </summary>
                                    [JsonPropertyName("en_us")]
                                    public string? EnUs { get; set; }
                                }

                                /// <summary>
                                /// <para>选项对应的分数</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：10</para>
                                /// <para>最大值：2147483647</para>
                                /// <para>最小值：0</para>
                                /// </summary>
                                [JsonPropertyName("score_val")]
                                public int? ScoreVal { get; set; }
                            }

                            /// <summary>
                            /// <para>当维度类型为多选题时，从此取值</para>
                            /// <para>必填：否</para>
                            /// <para>最大长度：1000</para>
                            /// <para>最小长度：0</para>
                            /// </summary>
                            [JsonPropertyName("dimension_options")]
                            public DimensionOptionSuffix[]? DimensionOptions { get; set; }

                            /// <summary>
                            /// <para>当维度类型为多选题时，从此取值</para>
                            /// </summary>
                            public record DimensionOptionSuffix
                            {
                                /// <summary>
                                /// <para>选项 ID</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：7171693733661327361</para>
                                /// </summary>
                                [JsonPropertyName("id")]
                                public string? Id { get; set; }

                                /// <summary>
                                /// <para>选项名称</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：7171693733661327361</para>
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
                                    /// <para>示例值：选项一</para>
                                    /// </summary>
                                    [JsonPropertyName("zh_cn")]
                                    public string? ZhCn { get; set; }

                                    /// <summary>
                                    /// <para>选项英文名称</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：Option 1</para>
                                    /// </summary>
                                    [JsonPropertyName("en_us")]
                                    public string? EnUs { get; set; }
                                }

                                /// <summary>
                                /// <para>选项对应的分数</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：10</para>
                                /// <para>最大值：2147483647</para>
                                /// <para>最小值：0</para>
                                /// </summary>
                                [JsonPropertyName("score_val")]
                                public int? ScoreVal { get; set; }
                            }

                            /// <summary>
                            /// <para>当维度评价方式为「打分题(填空)时」，从此取值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：10</para>
                            /// <para>最大值：2147483647</para>
                            /// <para>最小值：0</para>
                            /// </summary>
                            [JsonPropertyName("dimension_score")]
                            public int? DimensionScore { get; set; }

                            /// <summary>
                            /// <para>当维度为「职级建议」时，从此取值</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("recommended_job_level")]
                            public DimensionAssessmentRecommendedJobLevel? RecommendedJobLevel { get; set; }

                            /// <summary>
                            /// <para>当维度为「职级建议」时，从此取值</para>
                            /// </summary>
                            public record DimensionAssessmentRecommendedJobLevel
                            {
                                /// <summary>
                                /// <para>最低职级建议</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("lower_limit_job_level_name")]
                                public I18n? LowerLimitJobLevelName { get; set; }

                                /// <summary>
                                /// <para>最低职级建议</para>
                                /// </summary>
                                public record I18n
                                {
                                    /// <summary>
                                    /// <para>最低职级中文建议</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：多元化、跨国企业，最低职级建议为 6 - 10 级</para>
                                    /// </summary>
                                    [JsonPropertyName("zh_cn")]
                                    public string? ZhCn { get; set; }

                                    /// <summary>
                                    /// <para>最低职级英文建议</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：Diversified, multinational companies, the minimum recommended job level is 6 - 10</para>
                                    /// </summary>
                                    [JsonPropertyName("en_us")]
                                    public string? EnUs { get; set; }
                                }

                                /// <summary>
                                /// <para>最高职级建议</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("higher_limit_job_level_name")]
                                public I18n? HigherLimitJobLevelName { get; set; }
                            }

                            /// <summary>
                            /// <para>维度关联面试题</para>
                            /// <para>必填：否</para>
                            /// <para>最大长度：1000</para>
                            /// <para>最小长度：0</para>
                            /// </summary>
                            [JsonPropertyName("question_assessments")]
                            public QuestionAssessment[]? QuestionAssessments { get; set; }

                            /// <summary>
                            /// <para>维度关联面试题</para>
                            /// </summary>
                            public record QuestionAssessment
                            {
                                /// <summary>
                                /// <para>所关联面试题的类型</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：1</para>
                                /// <para>可选值：<list type="bullet">
                                /// <item>1：普通面试题目</item>
                                /// <item>2：在线编程题目</item>
                                /// </list></para>
                                /// </summary>
                                [JsonPropertyName("question_type")]
                                public int? QuestionType { get; set; }

                                /// <summary>
                                /// <para>关联面试题的名称</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("title")]
                                public I18n? Title { get; set; }

                                /// <summary>
                                /// <para>关联面试题的名称</para>
                                /// </summary>
                                public record I18n
                                {
                                    /// <summary>
                                    /// <para>关联面试题的中文名称</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：题目一</para>
                                    /// </summary>
                                    [JsonPropertyName("zh_cn")]
                                    public string? ZhCn { get; set; }

                                    /// <summary>
                                    /// <para>关联面试题的英文名称</para>
                                    /// <para>必填：否</para>
                                    /// <para>示例值：Question 1</para>
                                    /// </summary>
                                    [JsonPropertyName("en_us")]
                                    public string? EnUs { get; set; }
                                }

                                /// <summary>
                                /// <para>关联面试题的描述</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("description")]
                                public I18n? Description { get; set; }

                                /// <summary>
                                /// <para>面试者作答内容</para>
                                /// <para>必填：否</para>
                                /// <para>示例值：我对这道题目的作答是...</para>
                                /// </summary>
                                [JsonPropertyName("content")]
                                public string? Content { get; set; }

                                /// <summary>
                                /// <para>能力项列表</para>
                                /// <para>必填：否</para>
                                /// <para>最大长度：1000</para>
                                /// <para>最小长度：0</para>
                                /// </summary>
                                [JsonPropertyName("abilities")]
                                public Ability[]? Abilities { get; set; }

                                /// <summary>
                                /// <para>能力项列表</para>
                                /// </summary>
                                public record Ability
                                {
                                    /// <summary>
                                    /// <para>能力项 ID</para>
                                    /// <para>必填：是</para>
                                    /// <para>示例值：7270798542321666366</para>
                                    /// </summary>
                                    [JsonPropertyName("id")]
                                    public string Id { get; set; } = string.Empty;

                                    /// <summary>
                                    /// <para>能力项名称</para>
                                    /// <para>必填：否</para>
                                    /// </summary>
                                    [JsonPropertyName("name")]
                                    public I18n? Name { get; set; }

                                    /// <summary>
                                    /// <para>能力项名称</para>
                                    /// </summary>
                                    public record I18n
                                    {
                                        /// <summary>
                                        /// <para>能力项中文名称</para>
                                        /// <para>必填：否</para>
                                        /// <para>示例值：创新思维</para>
                                        /// </summary>
                                        [JsonPropertyName("zh_cn")]
                                        public string? ZhCn { get; set; }

                                        /// <summary>
                                        /// <para>能力项英文名称</para>
                                        /// <para>必填：否</para>
                                        /// <para>示例值：Creative Thinking</para>
                                        /// </summary>
                                        [JsonPropertyName("en_us")]
                                        public string? EnUs { get; set; }
                                    }

                                    /// <summary>
                                    /// <para>能力项描述</para>
                                    /// <para>必填：否</para>
                                    /// </summary>
                                    [JsonPropertyName("description")]
                                    public I18n? Description { get; set; }
                                }
                            }
                        }
                    }
                }

                /// <summary>
                /// <para>面试评价提交时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1659318415000</para>
                /// </summary>
                [JsonPropertyName("feedback_submit_time")]
                public string? FeedbackSubmitTime { get; set; }

                /// <summary>
                /// <para>面试关联的投递阶段</para>
                /// <para>必填：否</para>
                /// <para>示例值：634324253532232</para>
                /// </summary>
                [JsonPropertyName("stage_id")]
                public string? StageId { get; set; }

                /// <summary>
                /// <para>投递 ID，详情请查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：634324253532232</para>
                /// </summary>
                [JsonPropertyName("application_id")]
                public string? ApplicationId { get; set; }

                /// <summary>
                /// <para>阶段信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("stage")]
                public IdNameObject? Stage { get; set; }

                /// <summary>
                /// <para>阶段信息</para>
                /// </summary>
                public record IdNameObject
                {
                    /// <summary>
                    /// <para>阶段 ID，详情请查看：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1213213123123</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>阶段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>阶段名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>阶段中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：阶段一</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>阶段英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Stage 1</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>创建人</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("creator")]
                public IdNameObject? Creator { get; set; }

                /// <summary>
                /// <para>创建时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618999376474</para>
                /// </summary>
                [JsonPropertyName("create_time")]
                public string? CreateTime { get; set; }

                /// <summary>
                /// <para>更新时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618999376474</para>
                /// </summary>
                [JsonPropertyName("update_time")]
                public string? UpdateTime { get; set; }

                /// <summary>
                /// <para>面试状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：2</para>
                /// <para>可选值：<list type="bullet">
                /// <item>2：未开始</item>
                /// <item>3：全部未评价</item>
                /// <item>4：全部通过</item>
                /// <item>5：全部淘汰</item>
                /// <item>6：爽约</item>
                /// <item>7：部分评价且均评价通过</item>
                /// <item>8：部分评价且评价中有通过有淘汰的</item>
                /// <item>9：部分评价且均评价淘汰</item>
                /// <item>10：所有面试官都提交评价且评价中有通过有淘汰的</item>
                /// <item>11：部分评价且评价中有通过和待定的</item>
                /// <item>12：部分评价且评价中有淘汰和待定的</item>
                /// <item>13：部分评级且评价均为待定</item>
                /// <item>14：部分评价且评价中有通过、待定和淘汰的</item>
                /// <item>15：所有面试官都提交评价且评价中有通过和待定的</item>
                /// <item>16：所有面试官都提交评价且评价中有待定和淘汰的</item>
                /// <item>17：所有面试官都提交评价且评价均为待定</item>
                /// <item>18：所有面试官都提交评价且评价中有通过、待定、淘汰的</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("interview_round_summary")]
                public int? InterviewRoundSummary { get; set; }

                /// <summary>
                /// <para>面试安排 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6888110869563033870</para>
                /// </summary>
                [JsonPropertyName("interview_arrangement_id")]
                public string? InterviewArrangementId { get; set; }

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
                /// </summary>
                [JsonPropertyName("talent_time_zone")]
                public CodeNameObject? TalentTimeZone { get; set; }

                /// <summary>
                /// <para>候选人时区</para>
                /// </summary>
                public record CodeNameObject
                {
                    /// <summary>
                    /// <para>时区编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Asia/Shanghai</para>
                    /// </summary>
                    [JsonPropertyName("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>时区名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>时区名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>时区中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：上海</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>时区英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Shanghai</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>面试联系人</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("contact_user")]
                public IdNameObject? ContactUser { get; set; }

                /// <summary>
                /// <para>面试联系人电话</para>
                /// <para>必填：否</para>
                /// <para>示例值：13333333333</para>
                /// </summary>
                [JsonPropertyName("contact_mobile")]
                public string? ContactMobile { get; set; }

                /// <summary>
                /// <para>备注</para>
                /// <para>必填：否</para>
                /// <para>示例值：这是一条备注</para>
                /// </summary>
                [JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// <para>面试地点</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("address")]
                public BaseAddressV2? Address { get; set; }

                /// <summary>
                /// <para>面试地点</para>
                /// </summary>
                public record BaseAddressV2
                {
                    /// <summary>
                    /// <para>地点 ID，详情请查看：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6583482347283472832</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>地点名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>地点名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>地点中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：北京</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>地点英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Beijing</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>区域信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("district")]
                    public BaseLocation? District { get; set; }

                    /// <summary>
                    /// <para>区域信息</para>
                    /// </summary>
                    public record BaseLocation
                    {
                        /// <summary>
                        /// <para>区域名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public I18n? Name { get; set; }

                        /// <summary>
                        /// <para>区域名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>区域中文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：朝阳区</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>区域英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Chaoyang District</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>区域编码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：400700</para>
                        /// </summary>
                        [JsonPropertyName("code")]
                        public string? Code { get; set; }

                        /// <summary>
                        /// <para>地址类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：COUNTRY 国家</item>
                        /// <item>2：STATE 省</item>
                        /// <item>3：CITY 市</item>
                        /// <item>4：DISTRICT 区</item>
                        /// <item>5：ADDRESS 地址</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("location_type")]
                        public int? LocationType { get; set; }
                    }

                    /// <summary>
                    /// <para>城市信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("city")]
                    public BaseLocation? City { get; set; }

                    /// <summary>
                    /// <para>省信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("state")]
                    public BaseLocation? State { get; set; }

                    /// <summary>
                    /// <para>国家信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("country")]
                    public BaseLocation? Country { get; set; }
                }

                /// <summary>
                /// <para>视频面试工具</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：Zoom</item>
                /// <item>2：牛客技术类型</item>
                /// <item>3：牛客非技术类型</item>
                /// <item>4：赛码</item>
                /// <item>5：Lark</item>
                /// <item>8：Hackerrank</item>
                /// <item>9：飞书（含代码考核）</item>
                /// <item>100：不使用系统工具</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("video_type")]
                public int? VideoType { get; set; }

                /// <summary>
                /// <para>当安排类型为集中面试时，此值表示集中面试的安排状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：未开始</item>
                /// <item>2：进行中</item>
                /// <item>3：已结束</item>
                /// <item>4：已取消</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("arrangement_status")]
                public int? ArrangementStatus { get; set; }

                /// <summary>
                /// <para>安排类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：社招单面</item>
                /// <item>2：集中面试</item>
                /// <item>3：集体面试</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("arrangement_type")]
                public int? ArrangementType { get; set; }

                /// <summary>
                /// <para>安排方式（是否使用自助约面）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：直接安排</item>
                /// <item>2：自助约面</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("arrangement_appointment_kind")]
                public int? ArrangementAppointmentKind { get; set; }

                /// <summary>
                /// <para>面试会议室</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("meeting_room_list")]
                public InterviewMeetingRoom[]? MeetingRoomLists { get; set; }

                /// <summary>
                /// <para>面试会议室</para>
                /// </summary>
                public record InterviewMeetingRoom
                {
                    /// <summary>
                    /// <para>会议室 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6949805467799537964</para>
                    /// </summary>
                    [JsonPropertyName("room_id")]
                    public string? RoomId { get; set; }

                    /// <summary>
                    /// <para>会议室名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：OCG111</para>
                    /// </summary>
                    [JsonPropertyName("room_name")]
                    public string? RoomName { get; set; }

                    /// <summary>
                    /// <para>建筑名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：OCG</para>
                    /// </summary>
                    [JsonPropertyName("building_name")]
                    public string? BuildingName { get; set; }

                    /// <summary>
                    /// <para>会议室预定状态</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：预约中</item>
                    /// <item>2：预约成功</item>
                    /// <item>3：预约失败</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("reserved_status")]
                    public int? ReservedStatus { get; set; }

                    /// <summary>
                    /// <para>楼层</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：17</para>
                    /// </summary>
                    [JsonPropertyName("floor_name")]
                    public string? FloorName { get; set; }
                }

                /// <summary>
                /// <para>面试轮次类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("interview_round_type")]
                public IdNameObject? InterviewRoundType { get; set; }
            }
        }

        /// <summary>
        /// <para>投递 Offer 信息（正式offer）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("offer")]
        public OfferInfoV2? Offer { get; set; }

        /// <summary>
        /// <para>投递 Offer 信息（正式offer）</para>
        /// </summary>
        public record OfferInfoV2
        {
            /// <summary>
            /// <para>Offer 基本信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("offer_basic")]
            public OfferBasicInfoV2? OfferBasic { get; set; }

            /// <summary>
            /// <para>Offer 基本信息</para>
            /// </summary>
            public record OfferBasicInfoV2
            {
                /// <summary>
                /// <para>Offer ID，详情请查看：[获取 Offer 详情](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7056641315456469292</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>Offer 状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：10</para>
                /// <para>可选值：<list type="bullet">
                /// <item>10：Offer 已创建</item>
                /// <item>2：Offer 审批中</item>
                /// <item>3：Offer 审批已撤回</item>
                /// <item>4：Offer 审批通过</item>
                /// <item>5：Offer 审批不通过</item>
                /// <item>6：Offer 已发送</item>
                /// <item>7：Offer 被候选人接受</item>
                /// <item>8：Offer 被候选人拒绝</item>
                /// <item>9：Offer 已失效</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("offer_status")]
                public int? OfferStatus { get; set; }

                /// <summary>
                /// <para>直属上级</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("leader")]
                public BasicUserInfo? Leader { get; set; }

                /// <summary>
                /// <para>直属上级</para>
                /// </summary>
                public record BasicUserInfo
                {
                    /// <summary>
                    /// <para>用户 ID，与入参 `user_id_type` 类型一致</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6956499586395523359</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>直属上级名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>直属上级名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>直属上级中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：张三</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>直属上级英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Bob</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>人员类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("employee_type")]
                public IdNameObject? EmployeeType { get; set; }

                /// <summary>
                /// <para>人员类型</para>
                /// </summary>
                public record IdNameObject
                {
                    /// <summary>
                    /// <para>人员类型 ID，与入参 `employee_type_id_type` 类型一致</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1213213123123</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>人员类型名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>人员类型名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>人员类型中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：正式</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>人员类型英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Regular</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>部门</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("department")]
                public BasicDepartmentInfo? Department { get; set; }

                /// <summary>
                /// <para>部门</para>
                /// </summary>
                public record BasicDepartmentInfo
                {
                    /// <summary>
                    /// <para>部门 ID，与入参 `department_id_type` 类型一致</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6956499586395523359</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>部门名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>部门名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>部门中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：HR 部门</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>部门英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：HR Department</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>序列</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("sequence")]
                public IdNameObject? Sequence { get; set; }

                /// <summary>
                /// <para>级别</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("level")]
                public IdNameObject? Level { get; set; }

                /// <summary>
                /// <para>公司主体</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("company_main_body")]
                public IdNameObject? CompanyMainBody { get; set; }

                /// <summary>
                /// <para>招聘需求 ID，详情请查看：[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7018398769038182700</para>
                /// </summary>
                [JsonPropertyName("job_requirement_id")]
                public string? JobRequirementId { get; set; }

                /// <summary>
                /// <para>试用期（单位：月）</para>
                /// <para>必填：否</para>
                /// <para>示例值：3</para>
                /// </summary>
                [JsonPropertyName("probation_month")]
                public int? ProbationMonth { get; set; }

                /// <summary>
                /// <para>合同期（年/月）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("contract_period")]
                public ContractPeriodInfo? ContractPeriod { get; set; }

                /// <summary>
                /// <para>合同期（年/月）</para>
                /// </summary>
                public record ContractPeriodInfo
                {
                    /// <summary>
                    /// <para>合同周期类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：月</item>
                    /// <item>2：年</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("period_type")]
                    public int PeriodType { get; set; }

                    /// <summary>
                    /// <para>合同时长</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：3</para>
                    /// <para>最大值：100</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("period")]
                    public int Period { get; set; }
                }

                /// <summary>
                /// <para>入职日期，格式为 YYYY-MM-DD</para>
                /// <para>必填：否</para>
                /// <para>示例值：2023-01-01</para>
                /// </summary>
                [JsonPropertyName("onboard_date")]
                public string? OnboardDate { get; set; }

                /// <summary>
                /// <para>Offer 负责人</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("owner")]
                public BasicUserInfo? Owner { get; set; }

                /// <summary>
                /// <para>入职地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("onboard_address")]
                public BaseAddressV2? OnboardAddress { get; set; }

                /// <summary>
                /// <para>入职地址</para>
                /// </summary>
                public record BaseAddressV2
                {
                    /// <summary>
                    /// <para>入职地址 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6583482347283472832</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>入职地址名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>入职地址名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>入职地址中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：成都市高新区天府四街</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>入职地址英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Tianfu 4th street, Gaoxin district, Chengdu</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>区域信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("district")]
                    public BaseLocation? District { get; set; }

                    /// <summary>
                    /// <para>区域信息</para>
                    /// </summary>
                    public record BaseLocation
                    {
                        /// <summary>
                        /// <para>区域名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public I18n? Name { get; set; }

                        /// <summary>
                        /// <para>区域名称</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>区域中文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：高新区</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>区域英文名称</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：Gaoxin</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>区域编码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：400700</para>
                        /// </summary>
                        [JsonPropertyName("code")]
                        public string? Code { get; set; }

                        /// <summary>
                        /// <para>地址类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：COUNTRY 国家</item>
                        /// <item>2：STATE 省</item>
                        /// <item>3：CITY 市</item>
                        /// <item>4：DISTRICT 区</item>
                        /// <item>5：ADDRESS 地址</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("location_type")]
                        public int? LocationType { get; set; }
                    }

                    /// <summary>
                    /// <para>城市信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("city")]
                    public BaseLocation? City { get; set; }

                    /// <summary>
                    /// <para>省信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("state")]
                    public BaseLocation? State { get; set; }

                    /// <summary>
                    /// <para>国家信息</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("country")]
                    public BaseLocation? Country { get; set; }
                }

                /// <summary>
                /// <para>工作地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("work_address")]
                public BaseAddressV2? WorkAddress { get; set; }

                /// <summary>
                /// <para>Offer 备注</para>
                /// <para>必填：否</para>
                /// <para>示例值：这个 Offer 需要加急审批</para>
                /// </summary>
                [JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// <para>附件列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("attachment_list")]
                public OfferAttachmentInfo[]? AttachmentLists { get; set; }

                /// <summary>
                /// <para>附件列表</para>
                /// </summary>
                public record OfferAttachmentInfo
                {
                    /// <summary>
                    /// <para>Offer 附件 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7018398769038182700</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>Offer 附件名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：获奖证书「全套」</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>Offer 附件大小</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：4096</para>
                    /// </summary>
                    [JsonPropertyName("size")]
                    public int? Size { get; set; }

                    /// <summary>
                    /// <para>Offer 通用附件 ID 列表，可通过[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)接口获取附件的详细信息</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7118398769038182701</para>
                    /// </summary>
                    [JsonPropertyName("common_attachment_id")]
                    public string? CommonAttachmentId { get; set; }
                }

                /// <summary>
                /// <para>Offer 自定义字段数据</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customize_info_list")]
                public ApplicationOfferCustomValue[]? CustomizeInfoLists { get; set; }

                /// <summary>
                /// <para>Offer 自定义字段数据</para>
                /// </summary>
                public record ApplicationOfferCustomValue
                {
                    /// <summary>
                    /// <para>自定义字段 ID，详情可查看：[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6930815272790114324</para>
                    /// </summary>
                    [JsonPropertyName("object_id")]
                    public string? ObjectId { get; set; }

                    /// <summary>
                    /// <para>自定义字段 Value</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：This is a text type customized data value</para>
                    /// </summary>
                    [JsonPropertyName("customize_value")]
                    public string? CustomizeValue { get; set; }
                }

                /// <summary>
                /// <para>Offer 创建时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1619719298000</para>
                /// </summary>
                [JsonPropertyName("create_time")]
                public string? CreateTime { get; set; }
            }

            /// <summary>
            /// <para>Offer 薪酬信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("offer_salary")]
            public OfferSalaryInfoV2? OfferSalary { get; set; }

            /// <summary>
            /// <para>Offer 薪酬信息</para>
            /// </summary>
            public record OfferSalaryInfoV2
            {
                /// <summary>
                /// <para>薪酬 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6956641395189795116</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>薪酬状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：薪酬未创建</item>
                /// <item>1：薪酬已创建</item>
                /// <item>2：薪酬审批中</item>
                /// <item>3：薪酬无需审批</item>
                /// <item>4：薪酬审批已通过</item>
                /// <item>5：薪酬审批已拒绝</item>
                /// <item>6：薪酬已撤回</item>
                /// <item>7：薪酬已删除</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("salary_status")]
                public int? SalaryStatus { get; set; }

                /// <summary>
                /// <para>试用期百分比</para>
                /// <para>必填：否</para>
                /// <para>示例值：30%</para>
                /// </summary>
                [JsonPropertyName("probation_salary_percentage")]
                public string? ProbationSalaryPercentage { get; set; }

                /// <summary>
                /// <para>年终奖月数</para>
                /// <para>必填：否</para>
                /// <para>示例值：3</para>
                /// </summary>
                [JsonPropertyName("award_salary_multiple")]
                public string? AwardSalaryMultiple { get; set; }

                /// <summary>
                /// <para>期权股数</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("option_shares")]
                public string? OptionShares { get; set; }

                /// <summary>
                /// <para>季度奖金额，单位元、支持小数点后两位</para>
                /// <para>必填：否</para>
                /// <para>示例值：1000</para>
                /// </summary>
                [JsonPropertyName("quarterly_bonus")]
                public string? QuarterlyBonus { get; set; }

                /// <summary>
                /// <para>半年奖金额，单位元、支持小数点后两位</para>
                /// <para>必填：否</para>
                /// <para>示例值：3000</para>
                /// </summary>
                [JsonPropertyName("half_year_bonus")]
                public string? HalfYearBonus { get; set; }

                /// <summary>
                /// <para>年度现金总额（数量，非公式），单位元、支持小数点后两位</para>
                /// <para>必填：否</para>
                /// <para>示例值：200000</para>
                /// </summary>
                [JsonPropertyName("total_annual_cash")]
                public string? TotalAnnualCash { get; set; }

                /// <summary>
                /// <para>薪酬自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("customize_info_list")]
                public ApplicationOfferCustomValue[]? CustomizeInfoLists { get; set; }

                /// <summary>
                /// <para>薪酬自定义字段</para>
                /// </summary>
                public record ApplicationOfferCustomValue
                {
                    /// <summary>
                    /// <para>自定义字段 ID，详情可查看：[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6930815272790114324</para>
                    /// </summary>
                    [JsonPropertyName("object_id")]
                    public string? ObjectId { get; set; }

                    /// <summary>
                    /// <para>自定义字段 Value</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("customize_value")]
                    public string? CustomizeValue { get; set; }
                }

                /// <summary>
                /// <para>薪酬创建时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1619720918463</para>
                /// </summary>
                [JsonPropertyName("create_time")]
                public string? CreateTime { get; set; }
            }
        }

        /// <summary>
        /// <para>投递员工入转离信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee")]
        public EmployeeV2? Employee { get; set; }

        /// <summary>
        /// <para>投递员工入转离信息</para>
        /// </summary>
        public record EmployeeV2
        {
            /// <summary>
            /// <para>员工 ID，详情请查看：[通过员工 ID 获取入职信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/employee/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>投递 ID，详情请查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6990656563279480364</para>
            /// </summary>
            [JsonPropertyName("application_id")]
            public string? ApplicationId { get; set; }

            /// <summary>
            /// <para>入职状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：已入职</item>
            /// <item>2：已离职</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("onboard_status")]
            public int? OnboardStatus { get; set; }

            /// <summary>
            /// <para>转正状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：未转正</item>
            /// <item>2：已转正</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("conversion_status")]
            public int? ConversionStatus { get; set; }

            /// <summary>
            /// <para>实际入职时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1637596800000</para>
            /// </summary>
            [JsonPropertyName("onboard_time")]
            public string? OnboardTime { get; set; }

            /// <summary>
            /// <para>预期转正时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1637596800000</para>
            /// </summary>
            [JsonPropertyName("expected_conversion_time")]
            public string? ExpectedConversionTime { get; set; }

            /// <summary>
            /// <para>实际转正时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1637596800000</para>
            /// </summary>
            [JsonPropertyName("actual_conversion_time")]
            public string? ActualConversionTime { get; set; }

            /// <summary>
            /// <para>离职时间戳（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1637596800000</para>
            /// </summary>
            [JsonPropertyName("overboard_time")]
            public string? OverboardTime { get; set; }

            /// <summary>
            /// <para>离职原因</para>
            /// <para>必填：否</para>
            /// <para>示例值：职业发展考虑</para>
            /// </summary>
            [JsonPropertyName("overboard_note")]
            public string? OverboardNote { get; set; }

            /// <summary>
            /// <para>办公地点</para>
            /// <para>必填：否</para>
            /// <para>示例值：C20</para>
            /// </summary>
            [JsonPropertyName("onboard_city_code")]
            public string? OnboardCityCode { get; set; }

            /// <summary>
            /// <para>入职部门 ID，与入参 `department_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966123381141866028</para>
            /// </summary>
            [JsonPropertyName("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>直属上级 ID，与入参 `user_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-xxx</para>
            /// </summary>
            [JsonPropertyName("leader_id")]
            public string? LeaderId { get; set; }

            /// <summary>
            /// <para>序列 ID，与入参 `job_family_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：6501</para>
            /// </summary>
            [JsonPropertyName("sequence_id")]
            public string? SequenceId { get; set; }

            /// <summary>
            /// <para>职级 ID，与入参 `job_level_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：6301</para>
            /// </summary>
            [JsonPropertyName("level_id")]
            public string? LevelId { get; set; }

            /// <summary>
            /// <para>人员类型，与入参 `employee_type_id_type` 类型一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("employee_type")]
            public string? EmployeeType { get; set; }

            /// <summary>
            /// <para>招聘需求 ID，详情请查看：[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)</para>
            /// <para>必填：否</para>
            /// <para>示例值：123123123213</para>
            /// </summary>
            [JsonPropertyName("job_requirement_id")]
            public string? JobRequirementId { get; set; }
        }

        /// <summary>
        /// <para>投递猎头推荐信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agency")]
        public AgencyInfo? Agency { get; set; }

        /// <summary>
        /// <para>投递猎头推荐信息</para>
        /// </summary>
        public record AgencyInfo
        {
            /// <summary>
            /// <para>猎头基本信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("basic_info")]
            public AgencyBasicInfo? BasicInfo { get; set; }

            /// <summary>
            /// <para>猎头基本信息</para>
            /// </summary>
            public record AgencyBasicInfo
            {
                /// <summary>
                /// <para>猎头用户名</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("hunter_user_name")]
                public I18n? HunterUserName { get; set; }

                /// <summary>
                /// <para>猎头用户名</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>猎头中文用户名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：猎头一号</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>猎头英文用户名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Hunter One</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>猎头公司名</para>
                /// <para>必填：否</para>
                /// <para>示例值：明天会更好猎头公司</para>
                /// </summary>
                [JsonPropertyName("hunter_company_name")]
                public string? HunterCompanyName { get; set; }
            }

            /// <summary>
            /// <para>猎头评价信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("comment_info")]
            public ReportCustomData[]? CommentInfos { get; set; }

            /// <summary>
            /// <para>猎头评价信息</para>
            /// </summary>
            public record ReportCustomData
            {
                /// <summary>
                /// <para>猎头评价信息名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18n? Name { get; set; }

                /// <summary>
                /// <para>猎头评价信息名称</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>猎头评价信息中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：能力</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>猎头评价信息英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：Ability</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>猎头评价内容</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("value")]
                public I18n? Value { get; set; }

                /// <summary>
                /// <para>猎头评价信息描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public I18n? Description { get; set; }
            }

            /// <summary>
            /// <para>薪酬信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("salary_info")]
            public ReportCustomData[]? SalaryInfos { get; set; }
        }

        /// <summary>
        /// <para>投递官网信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("portal")]
        public ApplicationDetailPortalInfo? Portal { get; set; }

        /// <summary>
        /// <para>投递官网信息</para>
        /// </summary>
        public record ApplicationDetailPortalInfo
        {
            /// <summary>
            /// <para>校招志愿信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("campus_volunteer_info")]
            public CampusVolumnteerInfo? CampusVolunteerInfo { get; set; }

            /// <summary>
            /// <para>校招志愿信息</para>
            /// </summary>
            public record CampusVolumnteerInfo
            {
                /// <summary>
                /// <para>志愿顺序</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("volunteer_seq")]
                public int? VolunteerSeq { get; set; }
            }
        }

        /// <summary>
        /// <para>投递内推信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("referral")]
        public ReferralInfoV2? Referral { get; set; }

        /// <summary>
        /// <para>投递内推信息</para>
        /// </summary>
        public record ReferralInfoV2
        {
            /// <summary>
            /// <para>内推基本信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("basic_info")]
            public ReferralBasicInfo? BasicInfo { get; set; }

            /// <summary>
            /// <para>内推基本信息</para>
            /// </summary>
            public record ReferralBasicInfo
            {
                /// <summary>
                /// <para>内推 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6956498101012220204</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>投递 ID，详情请查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
                /// <para>必填：否</para>
                /// <para>示例值：7051498101012220201</para>
                /// </summary>
                [JsonPropertyName("application_id")]
                public string? ApplicationId { get; set; }

                /// <summary>
                /// <para>内推类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：意向推荐</item>
                /// <item>2：职位推荐</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("referral_type")]
                public int? ReferralType { get; set; }

                /// <summary>
                /// <para>内推人信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("user_info")]
                public BasicUserInfo? UserInfo { get; set; }

                /// <summary>
                /// <para>内推人信息</para>
                /// </summary>
                public record BasicUserInfo
                {
                    /// <summary>
                    /// <para>用户 ID，与入参 `user_id_type` 类型一致</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：6956499586395523359</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public I18n? Name { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>用户中文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：赵六</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>用户英文名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Tom</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }
                }

                /// <summary>
                /// <para>内推创建时间戳（单位：毫秒）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1619720918791</para>
                /// </summary>
                [JsonPropertyName("create_time")]
                public string? CreateTime { get; set; }

                /// <summary>
                /// <para>内推方法</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：正常内推</item>
                /// <item>2：内推码</item>
                /// <item>3：特别内推码</item>
                /// <item>4：H5 内推</item>
                /// <item>5：HR 代为内推</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("referral_method")]
                public int? ReferralMethod { get; set; }
            }

            /// <summary>
            /// <para>内推关联推荐信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("recommend_info")]
            public ReferralRecommendInfo? RecommendInfo { get; set; }

            /// <summary>
            /// <para>内推关联推荐信息</para>
            /// </summary>
            public record ReferralRecommendInfo
            {
                /// <summary>
                /// <para>与内推人关系</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：无关系</item>
                /// <item>1：直系亲属</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("relationship")]
                public int? Relationship { get; set; }

                /// <summary>
                /// <para>熟悉程度</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：不熟悉</item>
                /// <item>1：熟悉</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("familiarity")]
                public int? Familiarity { get; set; }

                /// <summary>
                /// <para>推荐语</para>
                /// <para>必填：否</para>
                /// <para>示例值：该同学十分优秀，经验丰富。</para>
                /// </summary>
                [JsonPropertyName("comment")]
                public string? Comment { get; set; }

                /// <summary>
                /// <para>特殊关系</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("specific_relationship")]
                public ReferralRecommendInfoSpecificRelationship? SpecificRelationship { get; set; }

                /// <summary>
                /// <para>特殊关系</para>
                /// </summary>
                public record ReferralRecommendInfoSpecificRelationship
                {
                    /// <summary>
                    /// <para>与候选人的关系</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：前同事</item>
                    /// <item>2：朋友</item>
                    /// <item>3：其他</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("relation_with_candidate")]
                    public int? RelationWithCandidate { get; set; }

                    /// <summary>
                    /// <para>附加信息</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：在前公司合作非常愉快～</para>
                    /// </summary>
                    [JsonPropertyName("extra")]
                    public string? Extra { get; set; }
                }

                /// <summary>
                /// <para>工作能力熟悉程度</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：非常熟悉</item>
                /// <item>2：比较熟悉</item>
                /// <item>3：一般熟悉</item>
                /// <item>4：不熟悉</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("work_ability_familiarity")]
                public int? WorkAbilityFamiliarity { get; set; }

                /// <summary>
                /// <para>匹配度</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：非常匹配</item>
                /// <item>2：比较匹配</item>
                /// <item>3：一般匹配</item>
                /// <item>4：不匹配</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("match_degree")]
                public int? MatchDegree { get; set; }
            }
        }
    }
}
