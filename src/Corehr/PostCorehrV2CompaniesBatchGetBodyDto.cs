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
/// <para>通过公司 ID 批量获取公司信息</para>
/// <para>接口ID：7252157701853184028</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fbatch_get</para>
/// </summary>
public record PostCorehrV2CompaniesBatchGetBodyDto
{
    /// <summary>
    /// <para>公司 ID 列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("company_ids")]
    public string[] CompanyIds { get; set; } = Array.Empty<string>();
}
