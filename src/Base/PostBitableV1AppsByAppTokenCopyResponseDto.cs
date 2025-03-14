// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-18
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenCopyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制多维表格 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 复制多维表格 响应体
/// <para>复制一个多维表格，可以指定复制到某个有权限的文件夹下。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格和目标文件夹的阅读、编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通云文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7205776220394160156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcopy</para>
/// </summary>
public record PostBitableV1AppsByAppTokenCopyResponseDto
{
    /// <summary>
    /// <para>返回响应体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app")]
    public PostBitableV1AppsByAppTokenCopyResponseDtoApp? App { get; set; }

    /// <summary>
    /// <para>返回响应体</para>
    /// </summary>
    public record PostBitableV1AppsByAppTokenCopyResponseDtoApp
    {
        /// <summary>
        /// <para>多维表格的唯一标识 app_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：S404b*****e9PQsYDWYcNryFn0g</para>
        /// </summary>
        [JsonPropertyName("app_token")]
        public string? AppToken { get; set; }

        /// <summary>
        /// <para>多维表格的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：一篇新的多维表格</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多维表格 App 归属文件夹</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldbco*****CIMltVc</para>
        /// </summary>
        [JsonPropertyName("folder_token")]
        public string? FolderToken { get; set; }

        /// <summary>
        /// <para>多维表格 App 的 URL 链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/base/S404b*****e9PQsYDWYcNryFn0g</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>文档时区</para>
        /// <para>必填：否</para>
        /// <para>示例值："" //只有创建才返回默认表Id</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }
    }
}
