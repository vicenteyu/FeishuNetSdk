// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdViewsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增视图 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增视图 请求体
/// <para>在多维表格数据表中新增一个视图，可指定视图类型，包括表格视图、看板视图、画册视图、甘特视图和表单视图。</para>
/// <para>## 使用限制</para>
/// <para>视图最大支持数量为 200，包括公共视图、锁定视图和个人视图。因此个人在多维表格中看到的视图数量可能仅是部分视图。</para>
/// <para>接口ID：6978670625209614338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdViewsBodyDto
{
    /// <summary>
    /// <para>视图名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：表格视图 1</para>
    /// </summary>
    [JsonPropertyName("view_name")]
    public string ViewName { get; set; } = string.Empty;

    /// <summary>
    /// <para>视图类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：grid</para>
    /// <para>可选值：<list type="bullet">
    /// <item>grid：表格视图</item>
    /// <item>kanban：看板视图</item>
    /// <item>gallery：画册视图</item>
    /// <item>gantt：甘特视图</item>
    /// <item>form：表单视图</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("view_type")]
    public string? ViewType { get; set; }
}
