// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoBackgroundCheckPackagesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建背调套餐和附加调查项 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建背调套餐和附加调查项 请求体
/// <para>在指定背调帐号下创建可用的背调套餐列表和附加调查项信息列表。该接口为增量创建，每次调用会在原有的套餐列表和附加调查项列表基础上新增。</para>
/// <para>## 注意事项</para>
/// <para>已经创建过的套餐 ID和附加调查项 ID无法重复创建，如需修改，请使用[更新背调套餐和附加调查项](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_package/batch_update)或</para>
/// <para>[删除背调套餐和附加调查项](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_background_check_package/batch_delete)接口进行操作。</para>
/// <para>接口ID：7195815976042512386</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_background_check_package/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_background_check_package%2fcreate</para>
/// </summary>
public record PostHireV1EcoBackgroundCheckPackagesBodyDto
{
    /// <summary>
    /// <para>背调账号 ID，可通过[账号绑定](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_account/events/created)事件获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6995842370159937061</para>
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;

    /// <summary>
    /// <para>背调套餐列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("package_list")]
    public EcoBackgroundCheckPackageData[] PackageLists { get; set; } = Array.Empty<EcoBackgroundCheckPackageData>();

    /// <summary>
    /// <para>背调套餐列表</para>
    /// </summary>
    public record EcoBackgroundCheckPackageData
    {
        /// <summary>
        /// <para>套餐 ID。由调用方自定义</para>
        /// <para>**注意**：长度不超过`36`字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：pkg001</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>套餐名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：基础套餐</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>套餐描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：工作履历信息验证X1，工作表现鉴定评价X1，教育背景核实，公民身份信息验证，简历对比，民事诉讼调查</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// <para>附加调查项列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("additional_item_list")]
    public EcoBackgroundCheckPackageAdditionalItem[]? AdditionalItemLists { get; set; }

    /// <summary>
    /// <para>附加调查项列表</para>
    /// </summary>
    public record EcoBackgroundCheckPackageAdditionalItem
    {
        /// <summary>
        /// <para>附件调查项 ID。由调用方自定义</para>
        /// <para>**注意**：长度不超过`36`字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：ext001</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>附加调查项名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：工作履历信息验证X2</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>附加调查项描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：详细调查</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
