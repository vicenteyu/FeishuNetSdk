// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1ApplicationsByApplicationIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取投递信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取投递信息 响应体
/// <para>根据投递 ID 获取单个投递信息。</para>
/// <para>接口ID：6964286393804849180</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fget</para>
/// </summary>
public record GetHireV1ApplicationsByApplicationIdResponseDto
{
    /// <summary>
    /// <para>投递数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application")]
    public GetHireV1ApplicationsByApplicationIdResponseDtoApplication? Application { get; set; }

    /// <summary>
    /// <para>投递数据</para>
    /// </summary>
    public record GetHireV1ApplicationsByApplicationIdResponseDtoApplication
    {
        /// <summary>
        /// <para>投递id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949805467799537964</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递的职位 ID，详情可参考：[获取职位详情](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get_detail)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6843547872837273223</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>候选人 ID，详情可参考：[获取人才详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6843547872837273223</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }

        /// <summary>
        /// <para>简历来源 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6583482347283472832</para>
        /// </summary>
        [JsonPropertyName("resume_source_id")]
        public string? ResumeSourceId { get; set; }

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
            /// <para>阶段 ID，详情可参考：[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)返回参数中的投递阶段信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：614218419274131</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>阶段中文名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：面试</para>
            /// </summary>
            [JsonPropertyName("zh_name")]
            public string? ZhName { get; set; }

            /// <summary>
            /// <para>英文名</para>
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
        /// <para>活跃状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：活跃</item>
        /// <item>2：非活跃，即为「已终止」</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int? ActiveStatus { get; set; }

        /// <summary>
        /// <para>投递方式，详细枚举请参考[「枚举常量介绍」](https://open.larkoffice.com/document/server-docs/hire-v1/enum) - 投递方式枚举定义</para>
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
            /// <para>投递来源 ID</para>
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
        /// <para>官网投递来源</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("website_resume_source")]
        public ApplicationWebsiteResumeSource? WebsiteResumeSource { get; set; }

        /// <summary>
        /// <para>官网投递来源</para>
        /// </summary>
        public record ApplicationWebsiteResumeSource
        {
            /// <summary>
            /// <para>官网站点 ID</para>
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
                /// <para>官网推广渠道 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：777218419274131</para>
                /// </summary>
                [JsonPropertyName("channel_id")]
                public string? ChannelId { get; set; }

                /// <summary>
                /// <para>官网推广渠道名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("channel_name")]
                public I18n? ChannelName { get; set; }

                /// <summary>
                /// <para>官网推广渠道名称</para>
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
        }

        /// <summary>
        /// <para>简历附件 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956415</para>
        /// </summary>
        [JsonPropertyName("talent_attachment_resume_id")]
        public string? TalentAttachmentResumeId { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1632990774278</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>修改时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1634801678103</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>阶段变更时间列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("stage_time_list")]
        public ApplicationStageTime[]? StageTimeLists { get; set; }

        /// <summary>
        /// <para>阶段变更时间列表</para>
        /// </summary>
        public record ApplicationStageTime
        {
            /// <summary>
            /// <para>阶段 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：614218419274131</para>
            /// </summary>
            [JsonPropertyName("stage_id")]
            public string? StageId { get; set; }

            /// <summary>
            /// <para>最近一次进入该阶段的时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1632991542615</para>
            /// </summary>
            [JsonPropertyName("enter_time")]
            public string? EnterTime { get; set; }

            /// <summary>
            /// <para>最后一次离开时间，如当前在该阶段，则为空</para>
            /// <para>必填：否</para>
            /// <para>示例值：1631509574398</para>
            /// </summary>
            [JsonPropertyName("exit_time")]
            public string? ExitTime { get; set; }
        }

        /// <summary>
        /// <para>终止原因的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：我们拒绝了候选人</item>
        /// <item>22：候选人拒绝了我们</item>
        /// <item>27：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("termination_type")]
        public int? TerminationType { get; set; }

        /// <summary>
        /// <para>终止的具体原因的id列表，详细信息请参考[获取终止投递原因](https://open.larkoffice.com/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/list-2)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("termination_reason_list")]
        public string[]? TerminationReasonList { get; set; }

        /// <summary>
        /// <para>终止备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：其他投递已入职</para>
        /// </summary>
        [JsonPropertyName("termination_reason_note")]
        public string? TerminationReasonNote { get; set; }

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
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：1111</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

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
        /// <para>投递创建人 ID，仅当投递创建人为企业内部员工时可获取（如员工手动上传简历 / 加入职位 / 内推），其余情况返回为空（如候选人主动投递）</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string? CreatorId { get; set; }
    }
}
