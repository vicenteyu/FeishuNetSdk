// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenDashboardsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出仪表盘 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出仪表盘 响应体
/// <para>获取多维表格中的所有仪表盘。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的阅读等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7127206859065638914</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-dashboard/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-dashboard%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenDashboardsResponseDto : IPageableResponse<GetBitableV1AppsByAppTokenDashboardsResponseDto.AppDashboard>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public AppDashboard[]? Items => Dashboards;

    /// <summary>
    /// <para>仪表盘信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("dashboards")]
    public AppDashboard[] Dashboards { get; set; } = [];

    /// <summary>
    /// <para>仪表盘信息</para>
    /// </summary>
    public record AppDashboard
    {
        /// <summary>
        /// <para>仪表盘 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：blknkqrP3RqUkcAW</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string BlockId { get; set; } = string.Empty;

        /// <summary>
        /// <para>仪表盘名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：仪表盘1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：blknkqrP3RqUkcAW</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
