// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetLingoV1ReposResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取词库列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Baike;
/// <summary>
/// 获取词库列表 响应体
/// <para>获取有权限访问的飞书词典词库列表。</para>
/// <para>如以应用身份获取，需要在“词库设置”页面添加应用；若以用户身份获取，该用户需要拥有对应词库的可见权限。</para>
/// <para>接口ID：7249689905697177628</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/repo/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2frepo%2flist</para>
/// </summary>
public record GetLingoV1ReposResponseDto
{
    /// <summary>
    /// <para>词库列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Repo[]? Items { get; set; }

    /// <summary>
    /// <para>词库列表</para>
    /// </summary>
    public record Repo
    {
        /// <summary>
        /// <para>词库 id</para>
        /// <para>必填：是</para>
        /// <para>示例值：71527909***274113</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>词库名</para>
        /// <para>必填：是</para>
        /// <para>示例值：全员词库</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
