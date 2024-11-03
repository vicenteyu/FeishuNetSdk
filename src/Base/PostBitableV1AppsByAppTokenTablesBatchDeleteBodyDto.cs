// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除多个数据表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 删除多个数据表 请求体
/// <para>删除多个数据表。如果多维表格中只剩最后一张数据表，则不允许被删除。</para>
/// <para>接口ID：6960166873968459779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fbatch_delete</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesBatchDeleteBodyDto
{
    /// <summary>
    /// <para>待删除的数据表的 ID。当前一次操作最多支持 50 个数据表。</para>
    /// <para>获取方式：</para>
    /// <para>- 你可通过多维表格 URL 获取 `table_id`，下图高亮部分即为当前数据表的 `table_id`。</para>
    /// <para>- 也可通过[列出数据表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table/list)接口获取 `table_id`。</para>
    /// <para>![](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/18741fe2a0d3cafafaf9949b263bb57d_yD1wkOrSju.png?height=746&amp;lazyload=true&amp;maxWidth=700&amp;width=2976)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["tblsRc9GRRXKqhvW"]</para>
    /// </summary>
    [JsonPropertyName("table_ids")]
    public string[]? TableIds { get; set; }
}
