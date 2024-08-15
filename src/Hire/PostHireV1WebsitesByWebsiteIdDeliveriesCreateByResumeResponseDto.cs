// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建招聘官网投递 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 新建招聘官网投递 响应体
/// <para>新建招聘官网投递。</para>
/// <para>## 注意事项</para>
/// <para>- 请求参数中邮箱/电话等字段请在「飞书招聘」-「设置」-「招聘官网设置」-「申请表」中确认是否必填。</para>
/// <para>- 请求参数中的时间字段 (start_time/end_time 等)，时间格式为毫秒时间戳，类型均为 bigint。</para>
/// <para>接口ID：6990661791098716163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_resume</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_resume</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeResponseDto
{
    /// <summary>
    /// <para>官网投递信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delivery")]
    public WebsiteDeliveryDto? Delivery { get; set; }

    /// <summary>
    /// <para>官网投递信息</para>
    /// </summary>
    public record WebsiteDeliveryDto
    {
        /// <summary>
        /// <para>招聘投递 ID，可通过[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956657</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>官网投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956655</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956659</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职位广告 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956658</para>
        /// </summary>
        [JsonPropertyName("job_post_id")]
        public string? JobPostId { get; set; }

        /// <summary>
        /// <para>简历 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956660</para>
        /// </summary>
        [JsonPropertyName("portal_resume_id")]
        public string? PortalResumeId { get; set; }

        /// <summary>
        /// <para>官网用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956656</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>人才 ID，详情可参考[获取人才信息 ](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7095600054216542508</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }
    }
}
