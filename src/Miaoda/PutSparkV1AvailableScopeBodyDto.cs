// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="PutSparkV1AvailableScopeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改妙搭产品使用权限 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 修改妙搭产品使用权限 请求体
/// <para>修改妙搭产品的使用权限，即配置哪些部门 / 成员被允许 (或禁止) 使用妙搭产品</para>
/// <para>接口ID：7679858182358043590</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-available_scope/open_api_update_miaoda_available_scope</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-available_scope%2fopen_api_update_miaoda_available_scope</para>
/// </summary>
public record PutSparkV1AvailableScopeBodyDto
{
    /// <summary>
    /// <para>使用权限范围类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：ALLOW_PART</para>
    /// <para>可选值：<list type="bullet">
    /// <item>ALLOW_ALL：全部允许</item>
    /// <item>DENY_ALL：全部拒绝</item>
    /// <item>ALLOW_PART：部分允许（仅 department_ids / user_ids 中指定的范围）</item>
    /// <item>DENY_PART：部分拒绝（仅 department_ids / user_ids 中指定的范围）</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("available_scope")]
    public string AvailableScope { get; set; } = string.Empty;

    /// <summary>
    /// <para>部门 ID 列表（仅 ALLOW_PART / DENY_PART 时生效）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>用户 ID 列表（仅 ALLOW_PART / DENY_PART 时生效）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }
}
