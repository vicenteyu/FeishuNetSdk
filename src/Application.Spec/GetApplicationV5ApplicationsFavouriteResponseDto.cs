using Newtonsoft.Json;
namespace FeishuNetSdk.Application.Spec;
/// <summary>
/// 获取用户自定义常用的应用 响应体
/// <para>获取用户自定义常用的应用。</para>
/// <para>接口ID：7218970579747110913</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/workplace-v1/app_recommend_rule/favourite</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v5%2fapplication%2ffavourite</para>
/// </summary>
public record GetApplicationV5ApplicationsFavouriteResponseDto
{
    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>总的数量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>应用数据列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("app_list")]
    public Application[]? AppList { get; set; }

    public record Application
    {
        /// <summary>
        /// <para>应用id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// <para>应用名</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// <para>应用描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>应用类型</para>
        /// <para>**可选值有**：</para>
        /// <para>app:普通应用,shortcut:快捷入口</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>app：普通应用</item>
        /// <item>shortcut：快捷入口</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("app_type")]
        public string? AppType { get; set; }

        /// <summary>
        /// <para>应用图标</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>可以打开应用的方式, 包含移动端小程序applink、移动端网页applink、PC端小程序applink、移动端小程序applink、PC端网页applink、机器人applink</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("open_methods")]
        public OpenMethod[]? OpenMethods { get; set; }

        public record OpenMethod
        {
            /// <summary>
            /// <para>applink类型</para>
            /// <para>**可选值有**：</para>
            /// <para>mobile_gadget:移动端小程序,mobile_web:移动端Web,pc_gadget:pc端小程序,pc_web:pc端web,bot:机器人</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>mobile_gadget：移动端小程序</item>
            /// <item>mobile_web：移动端Web</item>
            /// <item>pc_gadget：pc端小程序</item>
            /// <item>pc_web：pc端web</item>
            /// <item>bot：机器人</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>applink链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("applink")]
            public string? Applink { get; set; }
        }
    }
}
