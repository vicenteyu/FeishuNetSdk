// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-09
//
// Last Modified By : yxr
// Last Modified On : 2025-02-09
// ************************************************************************
// <copyright file="GetApplicationV6ApplicationsByAppIdCollaboratorsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用协作者列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用协作者列表 响应体
/// <para>根据 app_id 获取应用（包括自建应用和商店应用）的协作者信息，包括应用的所有者、管理员、开发者、运营人员</para>
/// <para>接口ID：7320225176225087491</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/application/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-collaborators%2fget</para>
/// </summary>
public record GetApplicationV6ApplicationsByAppIdCollaboratorsResponseDto
{
    /// <summary>
    /// <para>协作者</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("collaborators")]
    public AppCollaborator[]? Collaborators { get; set; }

    /// <summary>
    /// <para>协作者</para>
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
}
