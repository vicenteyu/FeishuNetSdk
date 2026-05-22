// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="PostSparkV1AppsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建妙搭应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 创建妙搭应用 响应体
/// <para>创建妙搭应用</para>
/// <para>接口ID：7642228089434950837</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fcreate</para>
/// </summary>
public record PostSparkV1AppsResponseDto
{
    /// <summary>
    /// <para>妙搭应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app")]
    public AppSuffix? App { get; set; }

    /// <summary>
    /// <para>妙搭应用</para>
    /// </summary>
    public record AppSuffix
    {
        /// <summary>
        /// <para>应用唯一标识，系统自动生成，用于在接口中定位具体应用。可通过应用创建接口或开发者后台获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：app_7d2f8a4b1c9e6035</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// <para>应用类型</para>
        /// <para>可选值：HTML</para>
        /// <para>必填：否</para>
        /// <para>示例值：HTML</para>
        /// </summary>
        [JsonPropertyName("app_type")]
        public string? AppType { get; set; }

        /// <summary>
        /// <para>应用名称，用于在管理后台和前端展示，支持中英文，长度不超过64字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：智能客服助手</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>应用功能说明，用于向用户介绍应用核心能力，长度不超过200字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：提供7×24小时智能对话服务，支持常见问题自动解答与工单流转</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>应用图标访问地址，支持PNG/JPG格式，建议尺寸为128×128像素</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.com/app-icons/customer-service.png</para>
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// <para>应用创建时间，遵循ISO 8601 UTC格式，由系统自动生成</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-05-18T10:00:00Z</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// <para>应用最后更新时间，遵循ISO 8601 UTC格式，应用信息变更时自动更新</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-06-20T14:30:00Z</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}
