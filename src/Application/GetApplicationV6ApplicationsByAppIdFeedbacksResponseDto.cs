// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="GetApplicationV6ApplicationsByAppIdFeedbacksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用反馈列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用反馈列表 响应体
/// <para>查询应用的反馈数据</para>
/// <para>接口ID：7072687744306610178</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application-feedback/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-feedback%2flist</para>
/// </summary>
public record GetApplicationV6ApplicationsByAppIdFeedbacksResponseDto : IPageableResponse<GetApplicationV6ApplicationsByAppIdFeedbacksResponseDto.ApplicationFeedback>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public ApplicationFeedback[]? Items => FeedbackLists;

    /// <summary>
    /// <para>应用的反馈列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("feedback_list")]
    public ApplicationFeedback[]? FeedbackLists { get; set; }

    /// <summary>
    /// <para>应用的反馈列表</para>
    /// </summary>
    public record ApplicationFeedback
    {
        /// <summary>
        /// <para>应用反馈 ID，应用反馈记录唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：7057888018203574291</para>
        /// </summary>
        [JsonPropertyName("feedback_id")]
        public string FeedbackId { get; set; } = string.Empty;

        /// <summary>
        /// <para>被反馈应用ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：cli_9b445f5258795107</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// <para>反馈提交时间，格式为yyyy-mm-dd hh:mm:ss</para>
        /// <para>必填：是</para>
        /// <para>示例值：2022-01-30 11:30:12</para>
        /// </summary>
        [JsonPropertyName("feedback_time")]
        public string FeedbackTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>反馈用户的租户名， 查询 isv 应用时返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：字节跳动</para>
        /// </summary>
        [JsonPropertyName("tenant_name")]
        public string? TenantName { get; set; }

        /// <summary>
        /// <para>反馈类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：故障反馈</item>
        /// <item>2：产品建议</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonPropertyName("feedback_type")]
        public int FeedbackType { get; set; }

        /// <summary>
        /// <para>反馈处理状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：反馈未处理</item>
        /// <item>1：反馈已处理</item>
        /// <item>2：反馈处理中</item>
        /// <item>3：反馈已关闭</item>
        /// </list></para>
        /// <para>默认值：0</para>
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// <para>故障类型列表：1: 黑屏 2: 白屏 3: 无法打开小程序 4: 卡顿 5: 小程序闪退 6: 页面加载慢 7: 死机 8: 其他异常</para>
        /// <para>必填：否</para>
        /// <para>示例值：[1,2,3]</para>
        /// <para>最大长度：30</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("fault_type")]
        public int[]? FaultType { get; set; }

        /// <summary>
        /// <para>故障时间，格式为yyyy-mm-dd hh:mm:ss</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-01-30 11:30:12</para>
        /// </summary>
        [JsonPropertyName("fault_time")]
        public string? FaultTime { get; set; }

        /// <summary>
        /// <para>反馈来源：1： 小程序 2：网页应用 3：机器人 4：webSDK</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：小程序</item>
        /// <item>2：网页应用</item>
        /// <item>3：机器人</item>
        /// <item>4：WebSDK</item>
        /// </list></para>
        /// <para>默认值：1</para>
        /// </summary>
        [JsonPropertyName("source")]
        public int? Source { get; set; }

        /// <summary>
        /// <para>用户联系方式，只有用户填写联系方式后返回</para>
        /// <para>必填：否</para>
        /// <para>示例值：wang@bytedance.com</para>
        /// </summary>
        [JsonPropertyName("contact")]
        public string? Contact { get; set; }

        /// <summary>
        /// <para>反馈处理时间，格式为yyyy-mm-dd hh:mm:ss</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-01-30 11:30:12</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// <para>反馈问题描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：反馈描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>反馈用户id，租户内用户的唯一标识 ，ID值与查询参数中的user_id_type对应</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_9565b69967831233761cc2f11b4c089f</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>操作者id，租户内用户的唯一标识， ID值与查询参数中的user_id_type 对应</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_9565b69967831233761cc2f11b4c089f</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }

        /// <summary>
        /// <para>反馈图片url列表，url 过期时间三天</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// </summary>
        [JsonPropertyName("images")]
        public string[]? Images { get; set; }

        /// <summary>
        /// <para>反馈页面路径</para>
        /// <para>- 如触发反馈的应用类型为小程序，则上报小程序当前页面的path信息</para>
        /// <para>- 如触发反馈的应用类型为网页或网页应用，则上报当前网页的url信息</para>
        /// <para>- 如为其他应用类型，则字段返回值为空</para>
        /// <para>必填：否</para>
        /// <para>示例值：index/page</para>
        /// </summary>
        [JsonPropertyName("feedback_path")]
        public string? FeedbackPath { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：7064688334618378259</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
