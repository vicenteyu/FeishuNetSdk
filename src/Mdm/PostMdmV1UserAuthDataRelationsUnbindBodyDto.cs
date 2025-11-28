// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMdmV1UserAuthDataRelationsUnbindBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>用户数据维度解绑 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mdm;
/// <summary>
/// 用户数据维度解绑 请求体
/// <para>通过该接口，可为指定应用下的指定用户解除一类数据维度。</para>
/// <para>接口ID：7120547953915527171</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mdm-v1/user_auth_data_relation/unbind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v1%2fuser_auth_data_relation%2funbind</para>
/// </summary>
public record PostMdmV1UserAuthDataRelationsUnbindBodyDto
{
    /// <summary>
    /// <para>数据类型编码</para>
    /// <para>必填：是</para>
    /// <para>示例值：gongsi</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("root_dimension_type")]
    public string RootDimensionType { get; set; } = string.Empty;

    /// <summary>
    /// <para>数据编码列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：zijie</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("sub_dimension_types")]
    public string[] SubDimensionTypes { get; set; } = [];

    /// <summary>
    /// <para>授权人的lark id</para>
    /// <para>必填：是</para>
    /// <para>示例值：on_21f2db9bdbafadeb16cd77b76060d41d</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("authorized_user_ids")]
    public string[] AuthorizedUserIds { get; set; } = [];

    /// <summary>
    /// <para>uams系统中应用id</para>
    /// <para>必填：是</para>
    /// <para>示例值：uams-tenant-test</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("uams_app_id")]
    public string UamsAppId { get; set; } = string.Empty;
}
