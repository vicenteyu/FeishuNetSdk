// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApplicationV6ApplicationsByAppIdAppVersionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用版本列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用版本列表 响应体
/// <para>根据 app_id 获取对应应用版本列表。</para>
/// <para>接口ID：7146031228486467585</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2flist</para>
/// </summary>
public record GetApplicationV6ApplicationsByAppIdAppVersionsResponseDto
{
    /// <summary>
    /// <para>应用版本列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ApplicationAppVersion[]? Items { get; set; }

    /// <summary>
    /// <para>应用版本列表</para>
    /// </summary>
    public record ApplicationAppVersion
    {
        /// <summary>
        /// <para>应用 id</para>
        /// <para>必填：是</para>
        /// <para>示例值：cli_9f3ca975326b501b</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// <para>在开发者后台填入的应用版本号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1.0.0</para>
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// <para>唯一标识应用版本的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：oav_d317f090b7258ad0372aa53963cda70d</para>
        /// </summary>
        [JsonPropertyName("version_id")]
        public string VersionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>应用默认名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：应用名称</para>
        /// </summary>
        [JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// <para>应用头像 url</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com</para>
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>应用默认描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：应用描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>应用权限列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("scopes")]
        public AppScope[]? Scopes { get; set; }

        /// <summary>
        /// <para>应用权限列表</para>
        /// </summary>
        public record AppScope
        {
            /// <summary>
            /// <para>应用权限</para>
            /// <para>必填：是</para>
            /// <para>示例值：contact:user.base</para>
            /// </summary>
            [JsonPropertyName("scope")]
            public string Scope { get; set; } = string.Empty;

            /// <summary>
            /// <para>应用权限的国际化描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：获取应用信息</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>权限等级描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：普通权限</item>
            /// <item>2：高级权限</item>
            /// <item>3：超敏感权限</item>
            /// <item>0：未知等级</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }
        }

        /// <summary>
        /// <para>后台主页地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com</para>
        /// </summary>
        [JsonPropertyName("back_home_url")]
        public string? BackHomeUrl { get; set; }

        /// <summary>
        /// <para>应用的国际化信息列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("i18n")]
        public AppI18nInfo[]? I18ns { get; set; }

        /// <summary>
        /// <para>应用的国际化信息列表</para>
        /// </summary>
        public record AppI18nInfo
        {
            /// <summary>
            /// <para>国际化语言的 key</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh_cn</para>
            /// <para>可选值：<list type="bullet">
            /// <item>zh_cn：中文</item>
            /// <item>en_us：英文</item>
            /// <item>ja_jp：日文</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("i18n_key")]
            public string I18nKey { get; set; } = string.Empty;

            /// <summary>
            /// <para>应用国际化名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：应用名称</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>应用国际化描述（副标题）</para>
            /// <para>必填：否</para>
            /// <para>示例值：应用描述</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>国际化帮助文档链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.example.com</para>
            /// </summary>
            [JsonPropertyName("help_use")]
            public string? HelpUse { get; set; }
        }

        /// <summary>
        /// <para>应用分类的国际化描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：3</para>
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
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
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
        /// <para>示例值：1610462759</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>版本发布时间（单位：s）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1610462759</para>
        /// </summary>
        [JsonPropertyName("publish_time")]
        public string? PublishTime { get; set; }

        /// <summary>
        /// <para>当前版本下应用开启的能力</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ability")]
        public AppAbility? Ability { get; set; }

        /// <summary>
        /// <para>当前版本下应用开启的能力</para>
        /// </summary>
        public record AppAbility
        {
            /// <summary>
            /// <para>小程序能力</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("gadget")]
            public AppAbilityGadget? Gadget { get; set; }

            /// <summary>
            /// <para>小程序能力</para>
            /// </summary>
            public record AppAbilityGadget
            {
                /// <summary>
                /// <para>pc 支持的小程序模式，bit 位表示</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：sidebar模式</item>
                /// <item>2：pc模式</item>
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
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("pc_use_mobile_pkg")]
                public bool? PcUseMobilePkg { get; set; }

                /// <summary>
                /// <para>pc 的小程序版本号</para>
                /// <para>必填：否</para>
                /// <para>示例值：1.0.0</para>
                /// </summary>
                [JsonPropertyName("pc_version")]
                public string? PcVersion { get; set; }

                /// <summary>
                /// <para>移动端小程序版本号</para>
                /// <para>必填：否</para>
                /// <para>示例值：1.0.0</para>
                /// </summary>
                [JsonPropertyName("mobile_version")]
                public string? MobileVersion { get; set; }

                /// <summary>
                /// <para>移动端兼容的最低飞书版本</para>
                /// <para>必填：否</para>
                /// <para>示例值：2.0</para>
                /// </summary>
                [JsonPropertyName("mobile_min_lark_version")]
                public string? MobileMinLarkVersion { get; set; }

                /// <summary>
                /// <para>pc 端兼容的最低飞书版本</para>
                /// <para>必填：否</para>
                /// <para>示例值：2.0</para>
                /// </summary>
                [JsonPropertyName("pc_min_lark_version")]
                public string? PcMinLarkVersion { get; set; }
            }

            /// <summary>
            /// <para>网页能力</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("web_app")]
            public AppAbilityWebApp? WebApp { get; set; }

            /// <summary>
            /// <para>网页能力</para>
            /// </summary>
            public record AppAbilityWebApp
            {
                /// <summary>
                /// <para>pc 端 url</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("pc_url")]
                public string? PcUrl { get; set; }

                /// <summary>
                /// <para>移动端 url</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("mobile_url")]
                public string? MobileUrl { get; set; }
            }

            /// <summary>
            /// <para>机器人能力</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bot")]
            public AppAbilityBot? Bot { get; set; }

            /// <summary>
            /// <para>机器人能力</para>
            /// </summary>
            public record AppAbilityBot
            {
                /// <summary>
                /// <para>消息卡片回调地址</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
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

            /// <summary>
            /// <para>小组件能力</para>
            /// </summary>
            public record WorkplaceWidget
            {
                /// <summary>
                /// <para>最低兼容飞书版本号</para>
                /// <para>必填：否</para>
                /// <para>示例值：1.0.0</para>
                /// </summary>
                [JsonPropertyName("min_lark_version")]
                public string? MinLarkVersion { get; set; }
            }

            /// <summary>
            /// <para>主导航小程序</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("navigate")]
            public AppAbilityNavigate? Navigate { get; set; }

            /// <summary>
            /// <para>主导航小程序</para>
            /// </summary>
            public record AppAbilityNavigate
            {
                /// <summary>
                /// <para>pc 端主导航信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("pc")]
                public NavigateMeta? Pc { get; set; }

                /// <summary>
                /// <para>pc 端主导航信息</para>
                /// </summary>
                public record NavigateMeta
                {
                    /// <summary>
                    /// <para>主导航小程序版本号</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1.0.0</para>
                    /// </summary>
                    [JsonPropertyName("version")]
                    public string? Version { get; set; }

                    /// <summary>
                    /// <para>默认图片 url</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://www.example.com</para>
                    /// </summary>
                    [JsonPropertyName("image_url")]
                    public string? ImageUrl { get; set; }

                    /// <summary>
                    /// <para>选中态图片 url</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://www.example.com</para>
                    /// </summary>
                    [JsonPropertyName("hover_image_url")]
                    public string? HoverImageUrl { get; set; }
                }

                /// <summary>
                /// <para>移动端主导航信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mobile")]
                public NavigateMeta? Mobile { get; set; }
            }

            /// <summary>
            /// <para>云文档应用</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cloud_doc")]
            public AppAbilityCloudDoc? CloudDoc { get; set; }

            /// <summary>
            /// <para>云文档应用</para>
            /// </summary>
            public record AppAbilityCloudDoc
            {
                /// <summary>
                /// <para>云空间重定向 url</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("space_url")]
                public string? SpaceUrl { get; set; }

                /// <summary>
                /// <para>国际化信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n")]
                public CloudDocI18nInfo[]? I18ns { get; set; }

                /// <summary>
                /// <para>国际化信息</para>
                /// </summary>
                public record CloudDocI18nInfo
                {
                    /// <summary>
                    /// <para>国际化语言的 key</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh_cn</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>zh_cn：中文</item>
                    /// <item>en_us：英文</item>
                    /// <item>ja_jp：日文</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("i18n_key")]
                    public string I18nKey { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档国际化名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：名称</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>云文档国际化读权限说明</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：读权限说明</para>
                    /// </summary>
                    [JsonPropertyName("read_description")]
                    public string? ReadDescription { get; set; }

                    /// <summary>
                    /// <para>云文档国际化写权限说明</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：写权限说明</para>
                    /// </summary>
                    [JsonPropertyName("write_description")]
                    public string? WriteDescription { get; set; }
                }

                /// <summary>
                /// <para>图标链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("icon_url")]
                public string? IconUrl { get; set; }

                /// <summary>
                /// <para>云文档支持模式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
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

            /// <summary>
            /// <para>云文档小组件</para>
            /// </summary>
            public record DocsBlock
            {
                /// <summary>
                /// <para>BlockTypeID</para>
                /// <para>必填：否</para>
                /// <para>示例值：blk_4fb61568435880110854c1d0</para>
                /// </summary>
                [JsonPropertyName("block_type_id")]
                public string? BlockTypeId { get; set; }

                /// <summary>
                /// <para>block 的国际化信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n")]
                public BlockI18nInfo[]? I18ns { get; set; }

                /// <summary>
                /// <para>block 的国际化信息</para>
                /// </summary>
                public record BlockI18nInfo
                {
                    /// <summary>
                    /// <para>国际化语言的 key</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：zh_cn</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>zh_cn：中文</item>
                    /// <item>en_us：英文</item>
                    /// <item>ja_jp：日文</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("i18n_key")]
                    public string? I18nKey { get; set; }

                    /// <summary>
                    /// <para>名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：名称</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                }

                /// <summary>
                /// <para>移动端 icon 链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("mobile_icon_url")]
                public string? MobileIconUrl { get; set; }

                /// <summary>
                /// <para>pc 端口 icon 链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("pc_icon_url")]
                public string? PcIconUrl { get; set; }
            }

            /// <summary>
            /// <para>消息快捷操作</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("message_action")]
            public AppAbilityMessageAction? MessageAction { get; set; }

            /// <summary>
            /// <para>消息快捷操作</para>
            /// </summary>
            public record AppAbilityMessageAction
            {
                /// <summary>
                /// <para>pc 端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("pc_app_link")]
                public string? PcAppLink { get; set; }

                /// <summary>
                /// <para>移动端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("mobile_app_link")]
                public string? MobileAppLink { get; set; }

                /// <summary>
                /// <para>国际化信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("i18n")]
                public MessageActionI18nInfo[]? I18ns { get; set; }

                /// <summary>
                /// <para>国际化信息</para>
                /// </summary>
                public record MessageActionI18nInfo
                {
                    /// <summary>
                    /// <para>国际化语言的 key</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：zh_cn</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>zh_cn：中文</item>
                    /// <item>en_us：英文</item>
                    /// <item>ja_jp：日文</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("i18n_key")]
                    public string? I18nKey { get; set; }

                    /// <summary>
                    /// <para>国际化名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：名称</para>
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
            public AppAbilityPlusMenu? PlusMenu { get; set; }

            /// <summary>
            /// <para>加号菜单</para>
            /// </summary>
            public record AppAbilityPlusMenu
            {
                /// <summary>
                /// <para>pc 端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
                /// </summary>
                [JsonPropertyName("pc_app_link")]
                public string? PcAppLink { get; set; }

                /// <summary>
                /// <para>移动端链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.example.com</para>
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
        public AppVersionRemark? Remark { get; set; }

        /// <summary>
        /// <para>跟随应用版本的信息</para>
        /// </summary>
        public record AppVersionRemark
        {
            /// <summary>
            /// <para>备注说明</para>
            /// <para>必填：否</para>
            /// <para>示例值：备注说明</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>更新说明</para>
            /// <para>必填：否</para>
            /// <para>示例值：更新说明</para>
            /// </summary>
            [JsonPropertyName("update_remark")]
            public string? UpdateRemark { get; set; }

            /// <summary>
            /// <para>应用当前版本开发者编辑的可见性建议，若开发者未编辑可见性建议，则该字段无内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("visibility")]
            public AppVisibility? Visibility { get; set; }

            /// <summary>
            /// <para>应用当前版本开发者编辑的可见性建议，若开发者未编辑可见性建议，则该字段无内容</para>
            /// </summary>
            public record AppVisibility
            {
                /// <summary>
                /// <para>是否全员可见</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_all")]
                public bool? IsAll { get; set; }

                /// <summary>
                /// <para>可见名单</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("visible_list")]
                public AppVisibleList? VisibleList { get; set; }

                /// <summary>
                /// <para>可见名单</para>
                /// </summary>
                public record AppVisibleList
                {
                    /// <summary>
                    /// <para>可见性成员 open_id 列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("open_ids")]
                    public string[]? OpenIds { get; set; }

                    /// <summary>
                    /// <para>可见性部门的 id 列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("department_ids")]
                    public string[]? DepartmentIds { get; set; }

                    /// <summary>
                    /// <para>可见性成员 group_id 列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("group_ids")]
                    public string[]? GroupIds { get; set; }
                }

                /// <summary>
                /// <para>不可见名单</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("invisible_list")]
                public AppVisibleList? InvisibleList { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：new-e3c5a0627cdf0c2e057da7257b90376a</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
