// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdFieldGroupsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建字段编组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 创建字段编组 响应体
/// <para>该接口用于为多维表格数据表的字段创建编组。创建字段编组后，字段将被组织到该编组中，便于多维表格的数据管理</para>
/// <para>#### 业务使用场景</para>
/// <para>适用于多维表格字段较多，需要分类管理字段的场景</para>
/// <para>接口ID：7600708368865856725</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field_group/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field_group%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdFieldGroupsResponseDto
{
    /// <summary>
    /// <para>字段编组的内容</para>
    /// <para>必填：否</para>
    /// <para>示例值：[ { "id": "fldjX7dUj5", "name": "编组1" }, { "id": "fldjX7dUj6", "name": "编组2" } ]</para>
    /// </summary>
    [JsonPropertyName("field_groups")]
    public string? FieldGroups { get; set; }
}
