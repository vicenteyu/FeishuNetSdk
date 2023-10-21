using Newtonsoft.Json;
namespace FeishuNetSdk.Admin;
/// <summary>
/// 修改勋章信息 请求体
/// <para>通过该接口可以修改勋章的信息。</para>
/// <para>接口ID：7104154222309031939</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge%2fupdate</para>
/// </summary>
public record PutAdminV1BadgesByBadgeIdBodyDto
{
    /// <summary>
    /// <para>租户内唯一的勋章名称，最多30个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：激励勋章</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>勋章的描述文案，最多100个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：这枚勋章为了激励员工颁发。</para>
    /// </summary>
    [JsonProperty("explanation")]
    public string? Explanation { get; set; }

    /// <summary>
    /// <para>企业勋章的详情图Key。1.权限校验：非本租户上传的图片key，不能直接使用；2.时效校验：创建勋章，或者修改勋章图片key时，需使用1h内上传的图片key。</para>
    /// <para>必填：是</para>
    /// <para>示例值：75a1949f-d9df-4b46-bc88-dacc51e88f3j</para>
    /// </summary>
    [JsonProperty("detail_image")]
    public string DetailImage { get; set; } = string.Empty;

    /// <summary>
    /// <para>企业勋章的头像挂饰图Key。1.权限校验：非本租户上传的图片key，不能直接使用；2.时效校验：创建勋章，或者修改勋章图片key时，需使用1h内上传的图片key。</para>
    /// <para>必填：是</para>
    /// <para>示例值：03daa74a-159f-49e9-963e-b6c4d76103fj</para>
    /// </summary>
    [JsonProperty("show_image")]
    public string ShowImage { get; set; } = string.Empty;

    /// <summary>
    /// <para>勋章的多语言名称，同name字段限制，最多30个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"zh_cn":"激励勋章","en_us":"IncentiveMedal","ja_jp":"奨励メダル"}</para>
    /// </summary>
    [JsonProperty("i18n_name")]
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
        [JsonProperty("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>英文文案</para>
        /// <para>必填：否</para>
        /// <para>示例值：IncentiveMedal</para>
        /// </summary>
        [JsonProperty("en_us")]
        public string? EnUs { get; set; }

        /// <summary>
        /// <para>日文文案</para>
        /// <para>必填：否</para>
        /// <para>示例值：奨励メダル</para>
        /// </summary>
        [JsonProperty("ja_jp")]
        public string? JaJp { get; set; }
    }

    /// <summary>
    /// <para>勋章的多语言描述文案，同explanation字段限制，最多100个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"zh_cn":"这枚勋章为了激励员工颁发。","en_us":"Thismedalisawardedtomotivateemployees.","ja_jp":"このメダルは、従業員のモチベーションを高めるために授与されます。"}</para>
    /// </summary>
    [JsonProperty("i18n_explanation")]
    public I18n? I18nExplanation { get; set; }
}
