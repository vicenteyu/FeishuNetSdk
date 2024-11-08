// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增多个数据表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增多个数据表 请求体
/// <para>新增多个数据表，仅可指定数据表名称。最多支持新增 100 个数据表。</para>
/// <para>接口ID：6960166873968558083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fbatch_create</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesBatchCreateBodyDto
{
    /// <summary>
    /// <para>tables</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tables")]
    public ReqTable[]? Tables { get; set; }

    /// <summary>
    /// <para>tables</para>
    /// </summary>
    public record ReqTable
    {
        /// <summary>
        /// <para>数据表名称。</para>
        /// <para>**注意**：</para>
        /// <para>- 名称中的首尾空格将会被默认去除。</para>
        /// <para>- 数据表名称不可以包含 `/ \ ? * : [ ]` 等特殊字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：一个新的数据表</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
