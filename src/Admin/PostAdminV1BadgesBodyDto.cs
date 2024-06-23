// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAdminV1BadgesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建勋章 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Admin;
/// <summary>
/// 创建勋章 请求体
/// <para>使用该接口可以创建一枚完整的勋章信息，一个租户下最多可创建1000枚勋章。</para>
/// <para>接口ID：7104154222309146627</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge%2fcreate</para>
/// </summary>
public record PostAdminV1BadgesBodyDto
{
    /// <summary>
    /// <para>租户内唯一的勋章名称，最多30个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：激励勋章</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>勋章的描述文案，最多100个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：这枚勋章为了激励员工颁发。</para>
    /// </summary>
    [JsonPropertyName("explanation")]
    public string? Explanation { get; set; }

    /// <summary>
    /// <para>企业勋章的详情图Key。1.权限校验：非本租户上传的图片key，不能直接使用；2.时效校验：创建勋章，或者修改勋章图片key时，需使用1h内上传的图片key。</para>
    /// <para>必填：是</para>
    /// <para>示例值：75a1949f-d9df-4b46-bc88-dacc51e88f3j</para>
    /// </summary>
    [JsonPropertyName("detail_image")]
    public string DetailImage { get; set; } = string.Empty;

    /// <summary>
    /// <para>企业勋章的头像挂饰图Key。1.权限校验：非本租户上传的图片key，不能直接使用；2.时效校验：创建勋章，或者修改勋章图片key时，需使用1h内上传的图片key。</para>
    /// <para>必填：是</para>
    /// <para>示例值：03daa74a-159f-49e9-963e-b6c4d76103fj</para>
    /// </summary>
    [JsonPropertyName("show_image")]
    public string ShowImage { get; set; } = string.Empty;

    /// <summary>
    /// <para>勋章的多语言名称，同name字段限制，最多30个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"zh_cn":"激励勋章","en_us":"IncentiveMedal","ja_jp":"奨励メダル"}</para>
    /// </summary>
    [JsonPropertyName("i18n_name")]
    public I18n? I18nName { get; set; }

    /// <summary>
    /// <para>勋章的多语言名称，同name字段限制，最多30个字符。</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>中文文案</para>
        /// <para>必填：否</para>
        /// <para>示例值：激励勋章</para>
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>英文文案</para>
        /// <para>必填：否</para>
        /// <para>示例值：IncentiveMedal</para>
        /// </summary>
        [JsonPropertyName("en_us")]
        public string? EnUs { get; set; }

        /// <summary>
        /// <para>日文文案</para>
        /// <para>必填：否</para>
        /// <para>示例值：奨励メダル</para>
        /// </summary>
        [JsonPropertyName("ja_jp")]
        public string? JaJp { get; set; }
    }

    /// <summary>
    /// <para>勋章的多语言描述文案，同explanation字段限制，最多100个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"zh_cn":"这枚勋章为了激励员工颁发。","en_us":"Thismedalisawardedtomotivateemployees.","ja_jp":"このメダルは、従業員のモチベーションを高めるために授与されます。"}</para>
    /// </summary>
    [JsonPropertyName("i18n_explanation")]
    public I18n? I18nExplanation { get; set; }
}
