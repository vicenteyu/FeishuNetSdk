using Newtonsoft.Json;
namespace FeishuNetSdk.Admin;
/// <summary>
/// 获取勋章列表 响应体
/// <para>可以通过该接口列出租户下所有的勋章，勋章的排列顺序是按照创建时间倒序排列。</para>
/// <para>接口ID：7104154222309048323</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge%2flist</para>
/// </summary>
public record GetAdminV1BadgesResponseDto
{
    /// <summary>
    /// <para>勋章列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：[{"badge_id":"m_DjMzaK","name":"字节范勋章","explanation":"奖励给值得鼓励的同学","badge_image":{"image_key":"a210ea02-e406-49ee-997c-9acc57c59eac","image_url":"https://s1-imfile.feishucdn.com/static-resource/v1/a210ea02-e406-49ee-997c-9acc57c59eac~?image_size=noop&amp;cut_type=&amp;quality=&amp;format=image&amp;sticker_format=.webp"},"show_image":{"image_key":"c23dcb4f-ee63-49c8-9b7d-85a7fe8f13cj","image_url":"https://s1-imfile.feishucdn.com/static-resource/v1/c23dcb4f-ee63-49c8-9b7d-85a7fe8f13cj~?image_size=noop&amp;cut_type=&amp;quality=&amp;format=image&amp;sticker_format=.webp"}}]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonProperty("badges")]
    public Badge[]? Badges { get; set; }

    /// <summary>
    /// <para>勋章列表</para>
    /// </summary>
    public record Badge
    {
        /// <summary>
        /// <para>租户内勋章的唯一标识，该值由系统随机生成。</para>
        /// <para>必填：否</para>
        /// <para>示例值：m_MzfKDM</para>
        /// <para>最大长度：64</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

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

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：h121921</para>
    /// <para>最大长度：64</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
