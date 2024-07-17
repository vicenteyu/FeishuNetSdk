// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdSiteUsersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建招聘官网用户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 新建招聘官网用户 请求体
/// <para>注册指定招聘官网的用户，注册完成后，可通过[创建招聘官网投递任务](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery/create_by_attachment)创建官网投递任务，或通过[新建招聘官网投递](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery/create_by_resume)创建官网投递</para>
/// <para>接口ID：6990661791098634243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-site_user%2fcreate</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdSiteUsersBodyDto
{
    /// <summary>
    /// <para>用户姓名</para>
    /// <para>必填：否</para>
    /// <para>示例值：张敏</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>用户邮箱</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangmin@163.com</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>外部 ID，幂等字段，同一外部 ID只会创建1个官网用户；当系统中已存在`external_id`对应的官网用户时，接口会返回已存在的官网用户信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956621</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; } = string.Empty;

    /// <summary>
    /// <para>电话，若填写了该字段，国家码(mobile_country_code)字段必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：182900291190</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// <para>国家码，若填写了该字段，电话（mobile）字段必填，可通过[获取地点列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/query)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：CN_1</para>
    /// </summary>
    [JsonPropertyName("mobile_country_code")]
    public string? MobileCountryCode { get; set; }
}
