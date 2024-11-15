// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出视图 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出视图 响应体
/// <para>获取多维表格数据表中的所有视图。</para>
/// <para>接口ID：6978670625209597954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto
{
    /// <summary>
    /// <para>视图信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppTableView[]? Items { get; set; }

    /// <summary>
    /// <para>视图信息</para>
    /// </summary>
    public record AppTableView
    {
        /// <summary>
        /// <para>视图 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：vewieWxfON</para>
        /// </summary>
        [JsonPropertyName("view_id")]
        public string? ViewId { get; set; }

        /// <summary>
        /// <para>视图名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：表格 1</para>
        /// </summary>
        [JsonPropertyName("view_name")]
        public string? ViewName { get; set; }

        /// <summary>
        /// <para>视图类型</para>
        /// <para>**可选值有**：</para>
        /// <para>- `grid`：表格视图</para>
        /// <para>- `kanban`：看板视图</para>
        /// <para>- `gallery`：画册视图</para>
        /// <para>- `gantt`：甘特视图</para>
        /// <para>- `form`：表单视图</para>
        /// <para>必填：否</para>
        /// <para>示例值：grid</para>
        /// </summary>
        [JsonPropertyName("view_type")]
        public string? ViewType { get; set; }

        /// <summary>
        /// <para>视图公共等级</para>
        /// <para>必填：否</para>
        /// <para>示例值：Public</para>
        /// <para>可选值：<list type="bullet">
        /// <item>Public：公共视图</item>
        /// <item>Locked：锁定视图</item>
        /// <item>Private：个人视图</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("view_public_level")]
        public string? ViewPublicLevel { get; set; }

        /// <summary>
        /// <para>个人视图的所有者的 ID，ID 类型和查询参数 user_id_type 保持一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_2910013f1e6456f16a0ce75ede950a0a</para>
        /// </summary>
        [JsonPropertyName("view_private_owner_id")]
        public string? ViewPrivateOwnerId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
