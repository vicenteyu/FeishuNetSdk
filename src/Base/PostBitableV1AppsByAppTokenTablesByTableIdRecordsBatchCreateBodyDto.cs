// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增多条记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增多条记录 请求体
/// <para>该接口用于在数据表中新增多条记录，单次调用最多新增 500 条记录。</para>
/// <para>接口ID：6952707657162604546</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_create</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateBodyDto
{
    /// <summary>
    /// <para>本次请求将要新增的记录列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("records")]
    public AppTableRecord[] Records { get; set; } = Array.Empty<AppTableRecord>();

    /// <summary>
    /// <para>本次请求将要新增的记录列表</para>
    /// </summary>
    public record AppTableRecord
    {
        /// <summary>
        /// <para>数据表的字段，即数据表的列</para>
        /// <para>当前接口支持的字段类型请参考[接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#31f78a3c)</para>
        /// <para>不同类型字段的数据结构请参考[数据结构概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/development-guide/bitable-structure)</para>
        /// <para>必填：是</para>
        /// <para>示例值：{"多行文本":"HelloWorld"}</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public object Fields { get; set; } = new();
    }
}
