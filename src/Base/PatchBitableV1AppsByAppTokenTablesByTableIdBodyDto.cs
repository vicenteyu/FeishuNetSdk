// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchBitableV1AppsByAppTokenTablesByTableIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新数据表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新数据表 请求体
/// <para>更新数据表的名称。</para>
/// <para>接口ID：7182466310810402817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdBodyDto
{
    /// <summary>
    /// <para>数据表的新名称。</para>
    /// <para>**注意**：</para>
    /// <para>- 名称中的首尾空格将会被去除。</para>
    /// <para>- 数据表名称不可以包含 `/ \ ? * : [ ]` 等特殊字符。</para>
    /// <para>- 如果名称为空或和旧名称相同，接口仍然会返回成功，但是名称不会被更改。</para>
    /// <para>必填：否</para>
    /// <para>示例值：新的数据表名称</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
