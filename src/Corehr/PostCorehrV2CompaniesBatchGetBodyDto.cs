// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2CompaniesBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过公司 ID 批量获取公司信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过公司 ID 批量获取公司信息 请求体
/// <para>通过 ID 批量查询公司信息</para>
/// <para>接口ID：7252157701853184028</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fbatch_get</para>
/// </summary>
public record PostCorehrV2CompaniesBatchGetBodyDto
{
    /// <summary>
    /// <para>需要查询的公司ID列表。ID获取方式：</para>
    /// <para>- 调用[【创建公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/create)[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)等接口可以返回部门ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("company_ids")]
    public string[] CompanyIds { get; set; } = Array.Empty<string>();
}
