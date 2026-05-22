// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="GetSparkV1AppsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取妙搭应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 批量获取妙搭应用 响应体
/// <para>批量获取妙搭应用</para>
/// <para>接口ID：7642228089434901685</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2flist</para>
/// </summary>
public record GetSparkV1AppsResponseDto : IPageableResponse<GetSparkV1AppsResponseDto.App>
{
    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJwYWdlX251bWJlciI6MiwiY29udGVudF9pZHMiOlsiMTIzNCIsIjU2NzgiXX0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>应用列表数据，包含当前页返回的所有妙搭应用的详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public App[]? Items { get; set; }

    /// <summary>
    /// <para>应用列表数据，包含当前页返回的所有妙搭应用的详细信息</para>
    /// </summary>
    public record App
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

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
