// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制仪表盘 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 复制仪表盘 响应体
/// <para>基于现有仪表盘复制出新的仪表盘。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有原多维表格的阅读权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7177650713441812483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-dashboard/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-dashboard%2fcopy</para>
/// </summary>
public record PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyResponseDto
{
    /// <summary>
    /// <para>新的仪表盘的 block_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：blkEsvEEaNllY2UV</para>
    /// </summary>
    [JsonPropertyName("block_id")]
    public string? BlockId { get; set; }

    /// <summary>
    /// <para>新的仪表盘名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：Dashboard</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
