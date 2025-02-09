// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-09
//
// Last Modified By : yxr
// Last Modified On : 2025-02-09
// ************************************************************************
// <copyright file="PutApplicationV6ApplicationsByAppIdCollaboratorsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用协作者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用协作者 请求体
/// <para>某个应用（包括自建应用和商店应用）中添加/移除应用协作者，添加后协作者将会收到添加通知。</para>
/// <para>接口ID：7320160200451686403</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application-collaborators/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-collaborators%2fupdate</para>
/// </summary>
public record PutApplicationV6ApplicationsByAppIdCollaboratorsBodyDto
{
    /// <summary>
    /// <para>添加人员</para>
    /// <para>必填：否</para>
    /// <para>最大长度：5</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("adds")]
    public AppCollaborator[]? Adds { get; set; }

    /// <summary>
    /// <para>添加人员</para>
    /// </summary>
    public record AppCollaborator
    {
        /// <summary>
        /// <para>人员类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：administrator</para>
        /// <para>可选值：<list type="bullet">
        /// <item>administrator：管理员</item>
        /// <item>developer：开发者</item>
        /// <item>operator：运营</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_d317f090b7258ad0372aa53963cda70d</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>移除人员</para>
    /// <para>必填：否</para>
    /// <para>最大长度：5</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("removes")]
    public string[]? Removes { get; set; }
}
