// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-24
// ************************************************************************
// <copyright file="PostApaasV1ApplicationsByNamespaceRecordPermissionsByRecordPermissionApiNameMemberBatchCreateAuthorizationBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建记录权限用户授权 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 批量创建记录权限用户授权 请求体
/// <para>批量创建记录权限授权</para>
/// <para>接口ID：7417675812785504259</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/permission/application-record_permission-member/batch_create_authorization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-record_permission-member%2fbatch_create_authorization</para>
/// </summary>
public record PostApaasV1ApplicationsByNamespaceRecordPermissionsByRecordPermissionApiNameMemberBatchCreateAuthorizationBodyDto
{
    /// <summary>
    /// <para>需要新增的用户 ID 列表，使用飞书低代码平台的用户 ID</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }
}
