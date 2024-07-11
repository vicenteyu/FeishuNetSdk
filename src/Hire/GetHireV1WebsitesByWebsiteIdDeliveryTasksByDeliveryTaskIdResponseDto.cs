// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="GetHireV1WebsitesByWebsiteIdDeliveryTasksByDeliveryTaskIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取招聘官网投递任务结果 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取招聘官网投递任务结果 响应体
/// <para>通过[根据简历附件创建招聘官网投递](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery/create_by_attachment)接口创建的投递任务，可通过本接口获取投递任务结果。如果获取到的数据 data 为空，可继续轮询直到获取到的 data 不为空。</para>
/// <para>接口ID：7097130726429179906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery_task%2fget</para>
/// </summary>
public record GetHireV1WebsitesByWebsiteIdDeliveryTasksByDeliveryTaskIdResponseDto
{
    /// <summary>
    /// <para>任务状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：新建</item>
    /// <item>1：处理中</item>
    /// <item>2：成功</item>
    /// <item>3：失败</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

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
        /// <para>投递 ID，可通过[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956657</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>ID，废弃字段，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956655</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>职位 ID，可通过[获取职位信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956659</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职位广告 ID，可通过[获取招聘官网下职位广告详情](https://open.larkoffice.com/document/server-docs/hire-v1/get-candidates/website/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956658</para>
        /// </summary>
        [JsonPropertyName("job_post_id")]
        public string? JobPostId { get; set; }

        /// <summary>
        /// <para>官网简历 ID，可通过[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)获取详细信息</para>
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
        /// <para>人才 ID，可通过[获取人才信息](https://open.larkoffice.com/document/server-docs/hire-v1/candidate-management/talent/get-2)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：7095600054216542508</para>
        /// </summary>
        [JsonPropertyName("talent_id")]
        public string? TalentId { get; set; }
    }

    /// <summary>
    /// <para>状态信息，仅在任务状态（status）为失败（3）时返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：same application exist</para>
    /// </summary>
    [JsonPropertyName("status_msg")]
    public string? StatusMsg { get; set; }

    /// <summary>
    /// <para>附加信息，在任务状态（status）为失败（3）时、且状态信息（status_msg）标识为重复投递时，返回重复投递的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7100825663201052972</para>
    /// </summary>
    [JsonPropertyName("extra_info")]
    public string? ExtraInfo { get; set; }
}
