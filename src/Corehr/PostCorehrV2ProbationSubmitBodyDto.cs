// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCorehrV2ProbationSubmitBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起转正 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 发起转正 请求体
/// <para>通过本接口可以为员工发起转正</para>
/// <para>接口ID：7254814386694635522</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/probation/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsubmit</para>
/// </summary>
public record PostCorehrV2ProbationSubmitBodyDto
{
    /// <summary>
    /// <para>试用期人员的雇佣 ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7140964208476371111</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>转正方式</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：直接转正</item>
    /// <item>2：发起转正</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("conversion_mode")]
    public int ConversionMode { get; set; }

    /// <summary>
    /// <para>实际结束日期，如果为空则默认填入试用期预计结束日期，填入日期需满足：试用期开始时间 &lt;= 实际结束日期 &lt;= 试用期预计结束日期，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-20</para>
    /// </summary>
    [JsonPropertyName("actual_probation_end_date")]
    public string? ActualProbationEndDate { get; set; }

    /// <summary>
    /// <para>发起方</para>
    /// <para>必填：是</para>
    /// <para>示例值：system</para>
    /// <para>可选值：<list type="bullet">
    /// <item>self_submission：员工</item>
    /// <item>system：系统</item>
    /// <item>hr_submission：HR</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("submission_type")]
    public string SubmissionType { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起人 ID，当发起方为 HR 时填写，为其他发起方时该字段会自动计算，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140964208476371111</para>
    /// </summary>
    [JsonPropertyName("initiator_id")]
    public string? InitiatorId { get; set; }

    /// <summary>
    /// <para>备注，当为直接转正时必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：符合预期</para>
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// <para>员工自评</para>
    /// <para>必填：否</para>
    /// <para>示例值：符合预期</para>
    /// </summary>
    [JsonPropertyName("self_review")]
    public string? SelfReview { get; set; }

    /// <summary>
    /// <para>自定义字段（试用期中如果有附件自定义字段，当前不支持使用「上传文件」接口写入）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public CustomFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段（试用期中如果有附件自定义字段，当前不支持使用「上传文件」接口写入）</para>
    /// </summary>
    public record CustomFieldData
    {
        /// <summary>
        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("custom_api_name")]
        public string CustomApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义字段名称（无需填写）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public CustomName? Name { get; set; }

        /// <summary>
        /// <para>自定义字段名称（无需填写）</para>
        /// </summary>
        public record CustomName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：自定义姓名</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Custom Name</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>自定义字段类型（无需填写）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同，不同类型字段传值格式如下</para>
        /// <para>- 文本，示例："你好"</para>
        /// <para>- 超链接，示例："https://www.baidu.com/"</para>
        /// <para>- 数字，示例："123"</para>
        /// <para>- 布尔，示例："true"</para>
        /// <para>- 单选，示例："option1"</para>
        /// <para>- 多选，示例："[\"option1\", \"option2\"]"</para>
        /// <para>- 人员（单选），示例："7140964208476371111"</para>
        /// <para>- 人员（多选），示例："[\"7140964208476371111\", \"7140964208476371112\"]"</para>
        /// <para>- 日期，示例："2025-01-01"</para>
        /// <para>必填：是</para>
        /// <para>示例值：231</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
