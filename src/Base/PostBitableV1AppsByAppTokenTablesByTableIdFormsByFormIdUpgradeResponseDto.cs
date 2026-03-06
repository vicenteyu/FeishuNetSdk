// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-06
//
// Last Modified By : yxr
// Last Modified On : 2026-03-06
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdUpgradeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>升级表单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 升级表单 响应体
/// <para>升级旧版表单至收集表</para>
/// <para>接口ID：7600708368865873109</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-form/upgrade</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form%2fupgrade</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdUpgradeResponseDto
{
    /// <summary>
    /// <para>升级后的表单</para>
    /// <para>必填：否</para>
    /// <para>示例值：vew8xQZ7f9</para>
    /// </summary>
    [JsonPropertyName("form")]
    public UpgradedForm? Form { get; set; }

    /// <summary>
    /// <para>升级后的表单</para>
    /// </summary>
    public record UpgradedForm
    {
        /// <summary>
        /// <para>升级后的表单ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：vew6oMbAa4</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}
