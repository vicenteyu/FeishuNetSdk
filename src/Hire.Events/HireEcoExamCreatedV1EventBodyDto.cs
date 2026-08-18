// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="HireEcoExamCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建笔试 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 创建笔试 事件体
/// <para>飞书招聘客户在招聘系统安排笔试后，系统会推送「创建笔试」事件给对应的笔试服务商应用。服务商可根据此事件获取该场笔试的候选人信息和试卷信息，并根据这些信息为候选人安排笔试，之后可通过[回传笔试安排结果](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_exam/login_info)将笔试安排结果回传给招聘系统。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=eco_exam&amp;event=created)</para>
/// <para>接口ID：7195815976042610690</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2fevents%2fcreated</para>
/// </summary>
public record HireEcoExamCreatedV1EventBodyDto() : EventBodyDto("hire.eco_exam.created_v1")
{
    /// <summary>
    /// <para>笔试 ID，招聘系统内唯一</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("exam_id")]
    public string? ExamId { get; set; }

    /// <summary>
    /// <para>账号 ID，招聘系统内唯一，可通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }

    /// <summary>
    /// <para>试卷 ID，通过[创建试卷列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_exam_paper/create)接口传入</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("paper_id")]
    public string? PaperId { get; set; }

    /// <summary>
    /// <para>候选人信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("candidate_info")]
    public EcoExamCreateEventCandidateInfo? CandidateInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EcoExamCreateEventCandidateInfo
    {
        /// <summary>
        /// <para>候选人姓名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>候选人手机号</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public EcoExamCreateEventMobile? Mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record EcoExamCreateEventMobile
        {
            /// <summary>
            /// <para>电话国家区号，遵循国际统一标准，可参考 [国际长途电话区号表](https://baike.baidu.com/item/%E5%9B%BD%E9%99%85%E9%95%BF%E9%80%94%E7%94%B5%E8%AF%9D%E5%8C%BA%E5%8F%B7%E8%A1%A8/12803495)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>手机号码</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("number")]
            public string? Number { get; set; }
        }

        /// <summary>
        /// <para>候选人邮箱</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }
    }

    /// <summary>
    /// <para>人才ID。灰度字段，灰度内才会返回。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }

    /// <summary>
    /// <para>投递ID。灰度字段，灰度内才会返回。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>职位信息。灰度字段，灰度内才会返回。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_info")]
    public EcoExamCreateEventJobInfo? JobInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record EcoExamCreateEventJobInfo
    {
        /// <summary>
        /// <para>职位部门。ID 为招聘系统 ATS/SaaS 部门 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public EcoExamCreateEventJobDepartment? Department { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record EcoExamCreateEventJobDepartment
        {
            /// <summary>
            /// <para>招聘系统 ATS/SaaS 部门 ID，不做 Open Department ID 转换。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>部门名称。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18nLanguage<string>? Name { get; set; }
        }

        /// <summary>
        /// <para>职位地址列表，顺序与职位配置一致。</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`0` ～ `1000`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("addresses")]
        public CommonAddress[]? Addresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record CommonAddress
        {
            /// <summary>
            /// <para>ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18nLanguage<string>? Name { get; set; }

            /// <summary>
            /// <para>区域信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("district")]
            public CodeNameObject? District { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record CodeNameObject
            {
                /// <summary>
                /// <para>编码</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string? Code { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public I18nLanguage<string>? Name { get; set; }
            }

            /// <summary>
            /// <para>城市信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("city")]
            public CodeNameObject? City { get; set; }

            /// <summary>
            /// <para>省信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("state")]
            public CodeNameObject? State { get; set; }

            /// <summary>
            /// <para>国家信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("country")]
            public CodeNameObject? Country { get; set; }
        }
    }
}
