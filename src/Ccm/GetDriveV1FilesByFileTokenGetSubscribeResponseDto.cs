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
/// <para>该接口仅支持**文档拥有者**和**文档管理者**查询文档的订阅状态（但目前文档管理者仅能接收到**文件编辑**事件）。可订阅的文档类型为**旧版文档**、**新版文档**、**电子表格**和**多维表格**。在调用该接口之前请确保正确[配置事件回调网址和订阅事件类型](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM#2eb3504a)，事件类型参考[事件列表](https://open.feishu.cn/document/ukTMukTMukTM/uYDNxYjL2QTM24iN0EjN/event-list)。</para>
/// <para>接口ID：7259592279886250012</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/get_subscribe</para>
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
