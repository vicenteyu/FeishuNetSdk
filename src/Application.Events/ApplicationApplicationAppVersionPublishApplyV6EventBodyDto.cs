// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2025-02-21
// ************************************************************************
// <copyright file="ApplicationApplicationAppVersionPublishApplyV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>申请发布应用 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application.Events;
/// <summary>
/// 申请发布应用 事件体
/// <para>通过订阅该事件，可接收应用提交发布申请事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=application&amp;version=v6&amp;resource=application.app_version&amp;event=publish_apply)</para>
/// <para>接口ID：7005118068771405827</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/publish_apply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fevents%2fpublish_apply</para>
/// </summary>
public record ApplicationApplicationAppVersionPublishApplyV6EventBodyDto() : EventBodyDto("application.application.app_version.publish_apply_v6")
{
    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>当前线上版本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("online_version")]
    public ApplicationAppVersionEvent? OnlineVersion { get; set; }

    /// <summary>
    /// <para>当前在审核的版本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("under_audit_version")]
    public ApplicationAppVersionEvent? UnderAuditVersion { get; set; }

    /// <summary></summary>
    public record ApplicationAppVersionEvent
    {
        /// <summary>
        /// <para>应用 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// <para>开发者填入的应用版本 ID</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最小长度：`1` 字符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// <para>唯一标识应用版本的 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// <para>应用默认名称</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最小长度：`1` 字符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// <para>应用头像 url</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>应用默认描述</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最小长度：`1` 字符</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>应用权限列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("scopes")]
        public AppScope[]? Scopes { get; set; }

        /// <summary></summary>
        public record AppScope
        {
            /// <summary>
            /// <para>应用权限</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("scope")]
            public string? Scope { get; set; }

            /// <summary>
            /// <para>应用权限的国际化描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>权限等级描述</para>
            /// <para>**可选值有**：</para>
            /// <para>1:普通权限,2:高级权限,3:超敏感权限,0:未知等级</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：普通权限</item>
            /// <item>2：高级权限</item>
            /// <item>3：超敏感权限</item>
            /// <item>0：未知等级</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }

            /// <summary>
            /// <para>返回用户身份类型user、应用身份类型tenant。如果两种类型都支持，则同时返回两个。</para>
            /// <para>**可选值有**：</para>
            /// <para>tenant:应用身份类型,user:用户身份类型</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 长度范围：`0` ～ `200`</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>tenant：应用身份类型</item>
            /// <item>user：用户身份类型</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("token_types")]
            public string[]? TokenTypes { get; set; }
        }

        /// <summary>
        /// <para>后台主页地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("back_home_url")]
        public string? BackHomeUrl { get; set; }

        /// <summary>
        /// <para>应用的国际化信息列表</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最小长度：`1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n")]
        public AppI18nInfo[]? I18n { get; set; }

        /// <summary></summary>
        public record AppI18nInfo
        {
            /// <summary>
            /// <para>国际化语言的 key</para>
            /// <para>**可选值有**：</para>
            /// <para>zh_cn:简体中文,en_us:英文,ja_jp:日文,zh_hk:繁体中文(中国香港),zh_tw:繁体中文(中国台湾),id_id:印度尼西亚语,ms_my:马来语,de_de:德语,es_es:西班牙语,fr_fr:法语,it_it:意大利语,pt_br:葡萄牙语(巴西),vi_vn:越南语,ru_ru:俄语,th_th:泰语,ko_kr:韩语</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>zh_cn：简体中文</item>
            /// <item>en_us：英文</item>
            /// <item>ja_jp：日文</item>
            /// <item>zh_hk：繁体中文(中国香港)</item>
            /// <item>zh_tw：繁体中文(中国台湾)</item>
            /// <item>id_id：印度尼西亚语</item>
            /// <item>ms_my：马来语</item>
            /// <item>de_de：德语</item>
            /// <item>es_es：西班牙语</item>
            /// <item>fr_fr：法语</item>
            /// <item>it_it：意大利语</item>
            /// <item>pt_br：葡萄牙语(巴西)</item>
            /// <item>vi_vn：越南语</item>
            /// <item>ru_ru：俄语</item>
            /// <item>th_th：泰语</item>
            /// <item>ko_kr：韩语</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("i18n_key")]
            public string? I18nKey { get; set; }

            /// <summary>
            /// <para>应用国际化名称</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最小长度：`1` 字符</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>应用国际化描述（副标题）</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 最小长度：`1` 字符</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>国际化帮助文档链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("help_use")]
            public string? HelpUse { get; set; }
        }

        /// <summary>
        /// <para>应用分类的国际化描述</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 最大长度：`3`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("common_categories")]
        public string[]? CommonCategories { get; set; }

        /// <summary>
        /// <para>应用已订阅开放平台事件列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("events")]
        public string[]? Events { get; set; }

        /// <summary>
        /// <para>版本状态</para>
        /// <para>**可选值有**：</para>
        /// <para>0:未知状态,1:审核通过,2:审核拒绝,3:审核中,4:未提交审核</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知状态</item>
        /// <item>1：审核通过</item>
        /// <item>2：审核拒绝</item>
        /// <item>3：审核中</item>
        /// <item>4：未提交审核</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>版本创建时间（单位：s）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>版本发布时间（单位：s）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("publish_time")]
        public string? PublishTime { get; set; }

        /// <summary>
        /// <para>当前版本下应用开启的能力</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ability")]
        public AppAbility? Ability { get; set; }

        /// <summary></summary>
        public record AppAbility
        {
            /// <summary>
            /// <para>小程序能力</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("gadget")]
            public GadgetSuffix? Gadget { get; set; }

            /// <summary></summary>
            public record GadgetSuffix
            {
                /// <summary>
                /// <para>pc 支持的小程序模式，bit 位表示</para>
                /// <para>**可选值有**：</para>
                /// <para>1:sidebar 模式,2:pc 模式,4:主导航模式</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：sidebar 模式</item>
                /// <item>2：pc 模式</item>
                /// <item>4：主导航模式</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("enable_pc_mode")]
                public int? EnablePcMode { get; set; }

                /// <summary>
                /// <para>schema url 列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("schema_urls")]
                public string[]? SchemaUrls { get; set; }

                /// <summary>
                /// <para>pc 端是否使用小程序版本</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_use_mobile_pkg")]
                public bool? PcUseMobilePkg { get; set; }

                /// <summary>
                /// <para>pc 的小程序版本号</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最小长度：`1` 字符</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_version")]
                public string? PcVersion { get; set; }

                /// <summary>
                /// <para>移动端小程序版本号</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最小长度：`1` 字符</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile_version")]
                public string? MobileVersion { get; set; }

                /// <summary>
                /// <para>移动端兼容的最低飞书版本</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最小长度：`1` 字符</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile_min_lark_version")]
                public string? MobileMinLarkVersion { get; set; }

                /// <summary>
                /// <para>pc 端兼容的最低飞书版本</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最小长度：`1` 字符</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_min_lark_version")]
                public string? PcMinLarkVersion { get; set; }
            }

            /// <summary>
            /// <para>网页能力</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("web_app")]
            public WebAppSuffix? WebApp { get; set; }

            /// <summary></summary>
            public record WebAppSuffix
            {
                /// <summary>
                /// <para>pc 端 url</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_url")]
                public string? PcUrl { get; set; }

                /// <summary>
                /// <para>移动端 url</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile_url")]
                public string? MobileUrl { get; set; }
            }

            /// <summary>
            /// <para>机器人能力</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bot")]
            public BotSuffix? Bot { get; set; }

            /// <summary></summary>
            public record BotSuffix
            {
                /// <summary>
                /// <para>消息卡片回调地址</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("card_request_url")]
                public string? CardRequestUrl { get; set; }
            }

            /// <summary>
            /// <para>小组件能力</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("workplace_widgets")]
            public WorkplaceWidget[]? WorkplaceWidgets { get; set; }

            /// <summary></summary>
            public record WorkplaceWidget
            {
                /// <summary>
                /// <para>最低兼容飞书版本号</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("min_lark_version")]
                public string? MinLarkVersion { get; set; }
            }

            /// <summary>
            /// <para>主导航小程序</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("navigate")]
            public NavigateSuffix? Navigate { get; set; }

            /// <summary></summary>
            public record NavigateSuffix
            {
                /// <summary>
                /// <para>pc 端主导航信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc")]
                public NavigateMeta? Pc { get; set; }

                /// <summary>
                /// <para>移动端主导航信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile")]
                public NavigateMeta? Mobile { get; set; }

                /// <summary></summary>
                public record NavigateMeta
                {
                    /// <summary>
                    /// <para>主导航小程序版本号</para>
                    /// <para>**数据校验规则**：</para>
                    /// <para>- 最小长度：`1` 字符</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("version")]
                    public string? Version { get; set; }

                    /// <summary>
                    /// <para>默认图片 url</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("image_url")]
                    public string? ImageUrl { get; set; }

                    /// <summary>
                    /// <para>选中态图片 url</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("hover_image_url")]
                    public string? HoverImageUrl { get; set; }
                }
            }

            /// <summary>
            /// <para>云文档应用</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cloud_doc")]
            public CloudDocSuffix? CloudDoc { get; set; }

            /// <summary></summary>
            public record CloudDocSuffix
            {
                /// <summary>
                /// <para>云空间重定向 url</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("space_url")]
                public string? SpaceUrl { get; set; }

                /// <summary>
                /// <para>国际化信息</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最小长度：`1`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n")]
                public CloudDocI18nInfo[]? I18n { get; set; }

                /// <summary></summary>
                public record CloudDocI18nInfo
                {
                    /// <summary>
                    /// <para>国际化语言的 key</para>
                    /// <para>**可选值有**：</para>
                    /// <para>zh_cn:简体中文,en_us:英文,ja_jp:日文</para>
                    /// <para>必填：否</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>zh_cn：简体中文</item>
                    /// <item>en_us：英文</item>
                    /// <item>ja_jp：日文</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("i18n_key")]
                    public string? I18nKey { get; set; }

                    /// <summary>
                    /// <para>云文档国际化名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>云文档国际化读权限说明</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("read_description")]
                    public string? ReadDescription { get; set; }

                    /// <summary>
                    /// <para>云文档国际化写权限说明</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("write_description")]
                    public string? WriteDescription { get; set; }
                }

                /// <summary>
                /// <para>图标链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("icon_url")]
                public string? IconUrl { get; set; }

                /// <summary>
                /// <para>云文档支持模式</para>
                /// <para>**可选值有**：</para>
                /// <para>0:未知,1:移动端</para>
                /// <para>必填：否</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：未知</item>
                /// <item>1：移动端</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("mode")]
                public int? Mode { get; set; }
            }

            /// <summary>
            /// <para>云文档小组件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("docs_blocks")]
            public DocsBlock[]? DocsBlocks { get; set; }

            /// <summary></summary>
            public record DocsBlock
            {
                /// <summary>
                /// <para>BlockTypeID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("block_type_id")]
                public string? BlockTypeId { get; set; }

                /// <summary>
                /// <para>block 的国际化信息</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最小长度：`1`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n")]
                public BlockI18nInfo[]? I18n { get; set; }

                /// <summary></summary>
                public record BlockI18nInfo
                {
                    /// <summary>
                    /// <para>国际化语言的 key</para>
                    /// <para>**可选值有**：</para>
                    /// <para>zh_cn:简体中文,en_us:英文,ja_jp:日文</para>
                    /// <para>必填：否</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>zh_cn：简体中文</item>
                    /// <item>en_us：英文</item>
                    /// <item>ja_jp：日文</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("i18n_key")]
                    public string? I18nKey { get; set; }

                    /// <summary>
                    /// <para>名称</para>
                    /// <para>**数据校验规则**：</para>
                    /// <para>- 最小长度：`1` 字符</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                }

                /// <summary>
                /// <para>移动端 icon 链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile_icon_url")]
                public string? MobileIconUrl { get; set; }

                /// <summary>
                /// <para>pc 端口 icon 链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_icon_url")]
                public string? PcIconUrl { get; set; }
            }

            /// <summary>
            /// <para>消息快捷操作</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("message_action")]
            public MessageActionSuffix? MessageAction { get; set; }

            /// <summary></summary>
            public record MessageActionSuffix
            {
                /// <summary>
                /// <para>pc 端链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_app_link")]
                public string? PcAppLink { get; set; }

                /// <summary>
                /// <para>移动端链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile_app_link")]
                public string? MobileAppLink { get; set; }

                /// <summary>
                /// <para>国际化信息</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 最小长度：`1`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n")]
                public MessageActionI18nInfo[]? I18n { get; set; }

                /// <summary></summary>
                public record MessageActionI18nInfo
                {
                    /// <summary>
                    /// <para>国际化语言的 key</para>
                    /// <para>**可选值有**：</para>
                    /// <para>zh_cn:简体中文,en_us:英文,ja_jp:日文</para>
                    /// <para>必填：否</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>zh_cn：简体中文</item>
                    /// <item>en_us：英文</item>
                    /// <item>ja_jp：日文</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("i18n_key")]
                    public string? I18nKey { get; set; }

                    /// <summary>
                    /// <para>国际化名称</para>
                    /// <para>**数据校验规则**：</para>
                    /// <para>- 最小长度：`1` 字符</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                }
            }

            /// <summary>
            /// <para>加号菜单</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("plus_menu")]
            public PlusMenuSuffix? PlusMenu { get; set; }

            /// <summary></summary>
            public record PlusMenuSuffix
            {
                /// <summary>
                /// <para>pc 端链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc_app_link")]
                public string? PcAppLink { get; set; }

                /// <summary>
                /// <para>移动端链接</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile_app_link")]
                public string? MobileAppLink { get; set; }
            }
        }

        /// <summary>
        /// <para>跟随应用版本的信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public AppVersionRemarkEvent? Remark { get; set; }

        /// <summary></summary>
        public record AppVersionRemarkEvent
        {
            /// <summary>
            /// <para>备注说明</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>更新说明</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("update_remark")]
            public string? UpdateRemark { get; set; }

            /// <summary>
            /// <para>可见性名单</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("visibility")]
            public AppVisibilityEvent? Visibility { get; set; }

            /// <summary></summary>
            public record AppVisibilityEvent
            {
                /// <summary>
                /// <para>是否全员可见</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("is_all")]
                public bool? IsAll { get; set; }

                /// <summary>
                /// <para>可见名单</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("visible_list")]
                public AppVisibleListEvent? VisibleList { get; set; }

                /// <summary>
                /// <para>不可见名单</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("invisible_list")]
                public AppVisibleListEvent? InvisibleList { get; set; }

                /// <summary></summary>
                public record AppVisibleListEvent
                {
                    /// <summary>
                    /// <para>可见性成员 id 列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("open_ids")]
                    public UserIdSuffix[]? OpenIds { get; set; }

                    /// <summary>
                    /// <para>可见性部门的 id 列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("department_ids")]
                    public string[]? DepartmentIds { get; set; }
                }
            }
        }
    }

    /// <summary>
    /// <para>应用状态</para>
    /// <para>**可选值有**：</para>
    /// <para>0:停用状态,1:启用状态</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：停用状态</item>
    /// <item>1：启用状态</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("app_status")]
    public int? AppStatus { get; set; }
}
