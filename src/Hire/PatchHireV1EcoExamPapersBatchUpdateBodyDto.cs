// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchHireV1EcoExamPapersBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新试卷列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新试卷列表 请求体
/// <para>飞书招聘的笔试服务商，可通过该接口更新客户笔试账号下的试卷列表。</para>
/// <para>接口ID：7195815979079532545</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam_paper/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam_paper%2fbatch_update</para>
/// </summary>
public record PatchHireV1EcoExamPapersBatchUpdateBodyDto
{
    /// <summary>
    /// <para>笔试账号 ID，可通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：7147998241542539527</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// <para>试卷列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("paper_list")]
    public EcoExamPaperData[] PaperLists { get; set; } = [];

    /// <summary>
    /// <para>试卷列表</para>
    /// </summary>
    public record EcoExamPaperData
    {
        /// <summary>
        /// <para>试卷 ID，为通过[创建试卷列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_exam_paper/create)传入的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7147998241542539527</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>试卷名称</para>
        /// <para>**注意**：试卷名称长度应不超过`255`字符，超出部分将被截断</para>
        /// <para>必填：是</para>
        /// <para>示例值：春季测评</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>笔试时长（分钟）</para>
        /// <para>必填：否</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>试卷题目数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("question_count")]
        public int? QuestionCount { get; set; }

        /// <summary>
        /// <para>笔试开始时间，毫秒时间戳。留空或不传表示不限制开始时间。</para>
        /// <para>**注意**：若传值且`end_time`不为空，则开始时间必须小于结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1658676234053</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>笔试结束时间，毫秒时间戳。留空或不传表示不限制结束时间</para>
        /// <para>**注意**：若传值且`start_time `不为空，则结束时间必须大于开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1672444800000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }
}
