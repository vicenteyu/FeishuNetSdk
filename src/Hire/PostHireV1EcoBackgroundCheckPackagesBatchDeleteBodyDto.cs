// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoBackgroundCheckPackagesBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除背调套餐和附加调查项 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 删除背调套餐和附加调查项 请求体
/// <para>删除背调帐号下的背调套餐和附加调查项信息。删除操作不会影响已创建的背调。</para>
/// <para>接口ID：7195815976042528770</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_package/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_package%2fbatch_delete</para>
/// </summary>
public record PostHireV1EcoBackgroundCheckPackagesBatchDeleteBodyDto
{
    /// <summary>
    /// <para>背调账号 ID，可通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6995842370159937061</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// <para>要删除的套餐 ID 列表。删除套餐不影响已安排的背调</para>
    /// <para>必填：否</para>
    /// <para>示例值：6996920667635566881</para>
    /// </summary>
    [JsonPropertyName("package_id_list")]
    public string[]? PackageIdList { get; set; }

    /// <summary>
    /// <para>要删除的附加调查项 ID 列表。删除附加调查项不影响已安排的背调</para>
    /// <para>必填：否</para>
    /// <para>示例值：6996920667635566881</para>
    /// </summary>
    [JsonPropertyName("additional_item_id_list")]
    public string[]? AdditionalItemIdList { get; set; }
}
