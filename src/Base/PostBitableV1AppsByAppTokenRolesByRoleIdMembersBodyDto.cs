// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenRolesByRoleIdMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增协作者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增协作者 请求体
/// <para>新增多维表格高级权限中自定义角色的协作者。</para>
/// <para>## 前提条件</para>
/// <para>要调用协作者相关接口，你需确保多维表格已开启高级权限并设置了自定义角色。你可通过[更新多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/update)接口开启高级权限，通过[新增自定义角色](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/create)接口设置自定义角色。</para>
/// <para>接口ID：7101134500528619523</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role-member%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenRolesByRoleIdMembersBodyDto
{
    /// <summary>
    /// <para>高级权限中自定义角色协作者的 ID，需与查询参数中 member_id_type 的类型需一致。获取 ID 方式参考 member_id_type 参数描述。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string MemberId { get; set; } = string.Empty;
}
