// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveV1FilesByFileTokenGetSubscribeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询云文档事件订阅状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询云文档事件订阅状态 响应体
/// <para>该接口用于查询云文档事件的订阅状态。了解事件订阅的配置流程和使用场景，参考[事件概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。了解云文档支持的事件类型，参考[事件列表](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-list)。</para>
/// <para>## 前提条件</para>
/// <para>- 调用接口前，请确保应用或用户为文档所有者或文档管理者。文档的通知事件仅支持文档拥有者和文档管理者订阅。</para>
/// <para>- 调用接口前，请确保正确配置订阅方式并添加了事件。详情参考[配置订阅方式](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-subscription-configure-/request-url-configuration-case)和[添加事件](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-subscription-configure-/subscription-event-case)。</para>
/// <para>接口ID：7259592279886250012</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/drive-v1/event/get_subscribe</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fget_subscribe</para>
/// </summary>
public record GetDriveV1FilesByFileTokenGetSubscribeResponseDto
{
    /// <summary>
    /// <para>true 表示已订阅，false 表示未订阅</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("is_subscribe")]
    public bool IsSubscribe { get; set; }
}
