// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApplicationV6AppRecommendRulesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取当前设置的推荐规则列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 获取当前设置的推荐规则列表 响应体
/// <para>获取当前设置的推荐规则列表。</para>
/// <para>接口ID：7148673650311643139</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/workplace-v1/app_recommend_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapp_recommend_rule%2flist</para>
/// </summary>
public record GetApplicationV6AppRecommendRulesResponseDto
{
    /// <summary>
    /// <para>推荐规则列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rules")]
    public AppRecommendRule[]? Rules { get; set; }

    /// <summary></summary>
    public record AppRecommendRule
    {
        /// <summary>
        /// <para>推荐规则 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>推荐规则名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>推荐规则启用状态</para>
        /// <para>**可选值有**：</para>
        /// <para>open:启用,closed:停用</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>open：启用</item>
        /// <item>closed：停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>推荐规则可见性信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("visibility_info")]
        public VisibilityInfoSuffix? VisibilityInfo { get; set; }

        /// <summary></summary>
        public record VisibilityInfoSuffix
        {
            /// <summary>
            /// <para>是否全员可见</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("is_all")]
            public bool? IsAll { get; set; }

            /// <summary>
            /// <para>可见部门 ID 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_ids")]
            public string[]? DepartmentIds { get; set; }

            /// <summary>
            /// <para>可见用户 ID 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_ids")]
            public string[]? UserIds { get; set; }

            /// <summary>
            /// <para>可见用户组 ID 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("group_ids")]
            public string[]? GroupIds { get; set; }
        }

        /// <summary></summary>
        public record ItemInfo
        {
            /// <summary>
            /// <para>推荐应用项 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("item_id")]
            public string? ItemId { get; set; }

            /// <summary>
            /// <para>推荐应用项类型</para>
            /// <para>**可选值有**：</para>
            /// <para>application:应用类型,link:链接类型</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>application：应用类型</item>
            /// <item>link：链接类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("item_type")]
            public string? ItemType { get; set; }

            /// <summary>
            /// <para>推荐应用项名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>推荐应用项描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>链接类型应用项的跳转链接（应用类型该字段为空）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("link_url")]
            public string? LinkUrl { get; set; }

            /// <summary>
            /// <para>应用类型应用项的 app id（链接类型该字段为空）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("client_id")]
            public string? ClientId { get; set; }

            /// <summary>
            /// <para>应用项图标链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("icon_url")]
            public string? IconUrl { get; set; }

            /// <summary>
            /// <para>链接类型应用项的默认展示语种（应用类型该字段为空）</para>
            /// <para>**可选值有**：</para>
            /// <para>zh_cn:简体中文,zh_hk:繁体中文（中国香港）,zh_tw:繁体中文（中国台湾）,en_us:英文,ja_jp:日文</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>zh_cn：简体中文</item>
            /// <item>zh_hk：繁体中文（中国香港）</item>
            /// <item>zh_tw：繁体中文（中国台湾）</item>
            /// <item>en_us：英文</item>
            /// <item>ja_jp：日文</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("default_locale")]
            public string? DefaultLocale { get; set; }

            /// <summary>
            /// <para>应用项的多语种名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_name")]
            public I18nNameSuffix? I18nName { get; set; }

            /// <summary></summary>
            public record I18nNameSuffix
            {
                /// <summary>
                /// <para>应用项的简体中文名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>应用项的繁体中文（中国香港）名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("zh_hk")]
                public string? ZhHk { get; set; }

                /// <summary>
                /// <para>应用项的繁体中文（中国台湾）名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("zh_tw")]
                public string? ZhTw { get; set; }

                /// <summary>
                /// <para>应用项的英文名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }

                /// <summary>
                /// <para>应用项的日文名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("ja_jp")]
                public string? JaJp { get; set; }
            }
        }

        /// <summary>
        /// <para>不可移除推荐应用项列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("recommend_item_infos")]
        public ItemInfo[]? RecommendItemInfos { get; set; }

        /// <summary>
        /// <para>可移除推荐应用项列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("distributed_recommend_item_infos")]
        public ItemInfo[]? DistributedRecommendItemInfos { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
