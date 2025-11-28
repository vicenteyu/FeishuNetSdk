// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoExamPapersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建试卷列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建试卷列表 请求体
/// <para>飞书招聘的笔试服务商，在完成[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)后，可通过本接口在客户的笔试帐号下创建试卷列表。若客户的笔试账号为「未激活」、「停用」状态，则试卷创建成功后，客户的账号将变为「正常」状态，可正常安排笔试。</para>
/// <para>接口ID：7195815976042561538</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam_paper/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam_paper%2fcreate</para>
/// </summary>
public record PostHireV1EcoExamPapersBodyDto
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
        /// <para>试卷 ID。由调用方自定义</para>
        /// <para>**注意**：试卷 ID 长度应不超过`255`字符，超出部分将被截断</para>
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
        /// <para>考试时长（分钟）</para>
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
