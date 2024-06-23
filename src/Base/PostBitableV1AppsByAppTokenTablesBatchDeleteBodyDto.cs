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
/// <para>删除多个数据表。</para>
/// <para>接口ID：6960166873968459779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fbatch_delete</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesBatchDeleteBodyDto
{
    /// <summary>
    /// <para>待删除的数据表的id [table_id 参数说明]，当前一次操作最多支持50个数据表(https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#735fe883)</para>
    /// <para>必填：否</para>
    /// <para>示例值：["tblsRc9GRRXKqhvW"]</para>
    /// </summary>
    [JsonPropertyName("table_ids")]
    public string[]? TableIds { get; set; }
}
