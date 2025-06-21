// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增多个数据表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增多个数据表 响应体
/// <para>新增多个数据表，仅可指定数据表名称。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>## 使用限制</para>
/// <para>每个多维表格中，数据表与仪表盘的总数量上限为 100。</para>
/// <para>接口ID：6960166873968558083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fbatch_create</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesBatchCreateResponseDto
{
    /// <summary>
    /// <para>table ids</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("table_ids")]
    public string[]? TableIds { get; set; }
}
