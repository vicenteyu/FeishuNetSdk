// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制仪表盘 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 复制仪表盘 请求体
/// <para>该接口用于根据现有仪表盘复制出新的仪表盘</para>
/// <para>接口ID：7177650713441812483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-dashboard/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-dashboard%2fcopy</para>
/// </summary>
public record PostBitableV1AppsByAppTokenDashboardsByBlockIdCopyBodyDto
{
    /// <summary>
    /// <para>仪表盘名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：Dashboard</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}
