// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdSiteUsersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建招聘官网用户 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 新建招聘官网用户 响应体
/// <para>注册指定招聘官网的用户，注册完成后，可通过[根据简历附件创建招聘官网投递任务](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery/create_by_attachment)创建官网投递任务，或通过[新建招聘官网投递](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/website-delivery/create_by_resume)创建官网投递</para>
/// <para>接口ID：6990661791098634243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-site_user%2fcreate</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdSiteUsersResponseDto
{
    /// <summary>
    /// <para>官网用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("site_user")]
    public WebsiteUser? SiteUser { get; set; }

    /// <summary>
    /// <para>官网用户信息</para>
    /// </summary>
    public record WebsiteUser
    {
        /// <summary>
        /// <para>官网用户 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956620</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户姓名</para>
        /// <para>必填：否</para>
        /// <para>示例值：dan27</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>用户邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：dan27@163.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>外部 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956621</para>
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; } = string.Empty;

        /// <summary>
        /// <para>电话</para>
        /// <para>必填：否</para>
        /// <para>示例值：182900291190</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>国家码</para>
        /// <para>必填：否</para>
        /// <para>示例值：CN_1</para>
        /// </summary>
        [JsonPropertyName("mobile_country_code")]
        public string? MobileCountryCode { get; set; }
    }
}
