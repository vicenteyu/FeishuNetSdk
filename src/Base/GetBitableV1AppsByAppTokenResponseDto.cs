// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-01-11
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取多维表格元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 获取多维表格元数据 响应体
/// <para>获取指定多维表格的元数据信息，包括多维表格名称、多维表格版本号、多维表格是否开启高级权限等。</para>
/// <para>接口ID：6960166873968574467</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fget</para>
/// </summary>
public record GetBitableV1AppsByAppTokenResponseDto
{
    /// <summary>
    /// <para>多维表格元数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app")]
    public DisplayApp? App { get; set; }

    /// <summary>
    /// <para>多维表格元数据</para>
    /// </summary>
    public record DisplayApp
    {
        /// <summary>
        /// <para>多维表格的唯一标识 app_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("app_token")]
        public string? AppToken { get; set; }

        /// <summary>
        /// <para>多维表格的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多维表格的版本号。对多维表格进行修改时更新，如新增、删除数据表，修改数据表名等，初始为 1，每次更新+1</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// <para>多维表格是否开启了高级权限。取值包括：</para>
        /// <para>- true：开启了高级权限</para>
        /// <para>- false：关闭了高级权限</para>
        /// <para>了解更多参考飞书帮助中心文档[使用多维表格高级权限](https://www.feishu.cn/hc/zh-CN/articles/588604550568)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("is_advanced")]
        public bool? IsAdvanced { get; set; }

        /// <summary>
        /// <para>多维表格的时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Beijing</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }

        /// <summary>
        /// <para>多维表格的公式字段类型。可结合[字段相关 API](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/create)使用。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：不支持指定公式字段类型</item>
        /// <item>2：支持指定公式字段类型</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("formula_type")]
        public int? FormulaType { get; set; }

        /// <summary>
        /// <para>文档高级权限版本。可结合[自定义角色 API](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/create)使用。</para>
        /// <para>必填：否</para>
        /// <para>示例值：v1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>v1：v1版本</item>
        /// <item>v2：v2版本</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("advance_version")]
        public string? AdvanceVersion { get; set; }
    }
}
