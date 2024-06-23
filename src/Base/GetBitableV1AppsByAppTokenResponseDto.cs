// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取多维表格元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 获取多维表格元数据 响应体
/// <para>获取指定多维表格的元数据信息，包括多维表格名称，多维表格版本号，多维表格是否开启高级权限等。</para>
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
        /// <para>多维表格的 app_token</para>
        /// <para>[app_token 参数说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/bitable/notification#8121eebe)</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("app_token")]
        public string? AppToken { get; set; }

        /// <summary>
        /// <para>多维表格的名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多维表格的版本号（对多维表格进行修改时更新，如新增、删除数据表，修改数据表名等，初始为1，每次更新+1）</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// <para>多维表格是否开启了高级权限。取值包括：</para>
        /// <para>- true：表示开启了高级权限</para>
        /// <para>- false：表示关闭了高级权限</para>
        /// <para>[了解更多：使用多维表格高级权限](https://www.feishu.cn/hc/zh-CN/articles/588604550568)</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("is_advanced")]
        public bool? IsAdvanced { get; set; }

        /// <summary>
        /// <para>文档时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Beijing</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }
    }
}
