// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="GetEventV1ConnectionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取长连接在线数量 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Event;
/// <summary>
/// 获取长连接在线数量 响应体
/// <para>查询应用的长连接在线数量。应用由请求头中的 tenant_access_token 确定。</para>
/// <para>长连接配置与接入方式请参考[使用长连接接收事件](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-subscription-configure-/request-url-configuration-case)</para>
/// <para>接口ID：7652298771384404951</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-v1/connection/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYDNxYjL2QTM24iN0EjN%2fevent-v1%2fconnection%2fget</para>
/// </summary>
public record GetEventV1ConnectionResponseDto
{
    /// <summary>
    /// <para>应用长连接数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("online_instance_cnt")]
    public int? OnlineInstanceCnt { get; set; }
}
