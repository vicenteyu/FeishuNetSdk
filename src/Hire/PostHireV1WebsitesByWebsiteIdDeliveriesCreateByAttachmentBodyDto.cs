// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-12
//
// Last Modified By : yxr
// Last Modified On : 2024-07-12
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据简历附件创建招聘官网投递任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 根据简历附件创建招聘官网投递任务 请求体
/// <para>根据简历附件创建招聘官网投递任务，创建投递的最终结果请通过[获取官网投递任务结果](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery_task/get)获取。</para>
/// <para>接口ID：7097131869725179905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_attachment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_attachment</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentBodyDto
{
    /// <summary>
    /// <para>职位广告 ID，可通过[获取招聘官网下的职位列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-job_post/list)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956636</para>
    /// </summary>
    [JsonPropertyName("job_post_id")]
    public string JobPostId { get; set; } = string.Empty;

    /// <summary>
    /// <para>官网用户ID，暂无直接查询接口，需在[新建招聘官网用户](https://open.larkoffice.com/document/server-docs/hire-v1/get-candidates/website/create)获取并保存</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956634</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>简历文件 ID，通过[创建附件](https://open.feishu.cn/document/ukTMukTMukTM/uIDN1YjLyQTN24iM0UjN/create_attachment)生成</para>
    /// <para>必填：是</para>
    /// <para>示例值：7095614894070434092</para>
    /// </summary>
    [JsonPropertyName("resume_file_id")]
    public string ResumeFileId { get; set; } = string.Empty;

    /// <summary>
    /// <para>官网推广渠道 ID，可通过[获取招聘官网推广渠道列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-channel/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6891560630172518670</para>
    /// </summary>
    [JsonPropertyName("channel_id")]
    public string? ChannelId { get; set; }

    /// <summary>
    /// <para>意向投递城市列表，最多可填入一个意向城市，可通过[查询地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：CT_1</para>
    /// <para>最大长度：1</para>
    /// </summary>
    [JsonPropertyName("application_preferred_city_code_list")]
    public string[]? ApplicationPreferredCityCodeList { get; set; }

    /// <summary>
    /// <para>电话国际区号，遵守国际统一标准，请参考[百度百科-国际长途电话区号](https://baike.baidu.com/item/%E5%9B%BD%E9%99%85%E9%95%BF%E9%80%94%E7%94%B5%E8%AF%9D%E5%8C%BA%E5%8F%B7%E8%A1%A8/12803495?fr=ge_ala)（当该参数值与简历附件中的相关值不一致时，将以该参数值为准）</para>
    /// <para>必填：否</para>
    /// <para>示例值：+86</para>
    /// </summary>
    [JsonPropertyName("mobile_country_code")]
    public string? MobileCountryCode { get; set; }

    /// <summary>
    /// <para>电话号码（当该参数值与简历附件中的相关值不一致时，将以该参数值为准）</para>
    /// <para>必填：否</para>
    /// <para>示例值：182900291190</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// <para>邮箱（当该参数值与简历附件中的相关值不一致时，将以该参数值为准）</para>
    /// <para>必填：否</para>
    /// <para>示例值：foo@bytedance.com</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>证件（当该参数值与简历附件中的相关值不一致时，将以该参数值为准）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("identification")]
    public WebsiteDeliveryAttachmentIndentification? Identification { get; set; }

    /// <summary>
    /// <para>证件（当该参数值与简历附件中的相关值不一致时，将以该参数值为准）</para>
    /// </summary>
    public record WebsiteDeliveryAttachmentIndentification
    {
        /// <summary>
        /// <para>证件类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：中国 - 居民身份证</item>
        /// <item>2：护照</item>
        /// <item>3：中国 - 港澳居民居住证</item>
        /// <item>4：中国 - 台湾居民来往大陆通行证</item>
        /// <item>5：其他</item>
        /// <item>6：中国 - 港澳居民来往内地通行证</item>
        /// <item>9：中国 - 台湾居民居住证</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("identification_type")]
        public int? IdentificationType { get; set; }

        /// <summary>
        /// <para>证件号码</para>
        /// <para>必填：否</para>
        /// <para>示例值：11002030131312312</para>
        /// </summary>
        [JsonPropertyName("identification_number")]
        public string? IdentificationNumber { get; set; }
    }
}
