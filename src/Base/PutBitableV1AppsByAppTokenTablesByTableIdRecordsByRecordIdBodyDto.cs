// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新记录 请求体
/// <para>该接口用于更新数据表中的一条记录</para>
/// <para>note</para>
/// <para>首次调用请参考 [云文档接口快速入门](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN)[多维表格接口接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification)</para>
/// <para>接口ID：6952707657162637314</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fupdate</para>
/// </summary>
public record PutBitableV1AppsByAppTokenTablesByTableIdRecordsByRecordIdBodyDto
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
