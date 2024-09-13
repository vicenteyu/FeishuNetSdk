// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新多条记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新多条记录 请求体
/// <para>该接口用于更新数据表中的多条记录，单次调用最多更新 500 条记录。</para>
/// <para>接口ID：6952707657162539010</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_update</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchUpdateBodyDto
{
    /// <summary>
    /// <para>记录</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("records")]
    public AppTableRecord[] Records { get; set; } = Array.Empty<AppTableRecord>();

    /// <summary>
    /// <para>记录</para>
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

        /// <summary>
        /// <para>一条记录的唯一标识 ID。参考[record_id 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#15d8db94) 获取 record_id。该参数必填，请忽略左侧必填列的否</para>
        /// <para>必填：否</para>
        /// <para>示例值：recqwIwhc6</para>
        /// </summary>
        [JsonPropertyName("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>记录链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com/record/WVoXrzIaqeorcJcHgzAcg8AQnNd</para>
        /// </summary>
        [JsonPropertyName("record_url")]
        public string? RecordUrl { get; set; }
    }
}
