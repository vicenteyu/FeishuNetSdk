// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除多条记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 删除多条记录 响应体
/// <para>删除多维表格数据表中现有的多条记录，单次调用中最多删除 500 条记录。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>## 注意事项</para>
/// <para>从其它数据源同步的数据表，不支持开发者对记录进行增加、删除、和修改操作。</para>
/// <para>接口ID：6952707657162620930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_delete</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchDeleteResponseDto
{
    /// <summary>
    /// <para>删除的记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("records")]
    public DeleteRecord[]? Records { get; set; }

    /// <summary>
    /// <para>删除的记录列表</para>
    /// </summary>
    public record DeleteRecord
    {
        /// <summary>
        /// <para>是否成功删除：</para>
        /// <para>- true：成功删除</para>
        /// <para>- false：未删除</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// <para>记录的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：recpCsf4ME</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }
    }
}
