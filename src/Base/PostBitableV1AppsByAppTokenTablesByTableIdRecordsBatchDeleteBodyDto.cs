// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除多条记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 删除多条记录 请求体
/// <para>该接口用于删除数据表中现有的多条记录，单次调用中最多删除 500 条记录。</para>
/// <para>接口ID：6952707657162620930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_delete</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteBodyDto
{
    /// <summary>
    /// <para>删除的多条记录id列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：[ "recIcJBbvC", "recvmiCORa" ]</para>
    /// </summary>
    [JsonPropertyName("records")]
    public string[] Records { get; set; } = Array.Empty<string>();
}
