// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostCorehrV2CustomOrgsDeleteOrgBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除自定义组织 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 删除自定义组织 请求体
/// <para>根据传入的自定义组织 ID 删除相应自定义组织</para>
/// <para>接口ID：7358017162446487556</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/delete_org</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fdelete_org</para>
/// </summary>
public record PostCorehrV2CustomOrgsDeleteOrgBodyDto
{
    /// <summary>
    /// <para>自定义组织 ID</para>
    /// <para>- 可从 [批量查询自定义组织](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/custom_org/query)的 org_id 字段中获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：6862995757234914824</para>
    /// </summary>
    [JsonPropertyName("org_id")]
    public string OrgId { get; set; } = string.Empty;

    /// <summary>
    /// <para>组织类型编码，可在「飞书人事-设置-组织设置」中相应的自定义组织目录下查看</para>
    /// <para>必填：是</para>
    /// <para>示例值：custom_org_01</para>
    /// </summary>
    [JsonPropertyName("object_api_name")]
    public string ObjectApiName { get; set; } = string.Empty;
}
