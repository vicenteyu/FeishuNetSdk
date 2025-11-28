// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="GetCorehrV2SignatureTemplatesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取电子签模板内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取电子签模板内容 响应体
/// <para>根据多个模板ID获取电子签模板基本信息和内容列表。</para>
/// <para>接口ID：7395391068203089948</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_template_info_with_thumbnail/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_template%2fsearch</para>
/// </summary>
public record GetCorehrV2SignatureTemplatesSearchResponseDto
{
    /// <summary>
    /// <para>返回的电子签模板列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：4294967296</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("signature_templates")]
    public SignatureTemplate[]? SignatureTemplates { get; set; }

    /// <summary>
    /// <para>返回的电子签模板列表</para>
    /// </summary>
    public record SignatureTemplate
    {
        /// <summary>
        /// <para>电子签模板id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7246307700768902956</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>模板基本信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("brief_info")]
        public SignatureTemplateBriefInfo? BriefInfo { get; set; }

        /// <summary>
        /// <para>模板基本信息</para>
        /// </summary>
        public record SignatureTemplateBriefInfo
        {
            /// <summary>
            /// <para>电子签模板id</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>模板名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("label")]
            public I18n[]? Labels { get; set; }

            /// <summary>
            /// <para>模板名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>模板名</para>
                /// <para>必填：是</para>
                /// <para>示例值：合同续约模板</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>电子签模板分类，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板类型（signature_template_category）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("category")]
            public Enum? Category { get; set; }

            /// <summary>
            /// <para>电子签模板分类，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板类型（signature_template_category）枚举定义部分获得</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>模板类别名称</para>
                /// <para>必填：是</para>
                /// <para>示例值：contract_agreement</para>
                /// </summary>
                [JsonPropertyName("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>模板类别对应的多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>模板类别对应的多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>中文</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：人事合同 / 协议</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>电子签模板用途，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板用途（signature_template_usage）枚举定义部分获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("usage")]
            public Enum? Usage { get; set; }

            /// <summary>
            /// <para>模版签署对象</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2147483647</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("signatory_labels")]
            public SignatureSignatoryLabel[]? SignatoryLabels { get; set; }

            /// <summary>
            /// <para>模版签署对象</para>
            /// </summary>
            public record SignatureSignatoryLabel
            {
                /// <summary>
                /// <para>电子签模板签署对象类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板签署对象类型（signature_template_signatory_type）枚举定义部分获得</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("template_signatory_type")]
                public Enum TemplateSignatoryType { get; set; } = new();

                /// <summary>
                /// <para>电子签模板签署对象类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板签署对象类型（signature_template_signatory_type）枚举定义部分获得</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>模板签署对象类型对应的枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：Person</para>
                    /// </summary>
                    [JsonPropertyName("enum_name")]
                    public string EnumName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("display")]
                    public I18n[]? Displies { get; set; }

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>字段多语展示</para>
                /// <para>必填：是</para>
                /// <para>最大长度：10</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("label")]
                public I18n[] Labels { get; set; } = [];

                /// <summary>
                /// <para>字段多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：中文示例</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>模板签署类型名</para>
                /// <para>必填：否</para>
                /// <para>示例值：status</para>
                /// </summary>
                [JsonPropertyName("apiname")]
                public string? Apiname { get; set; }
            }

            /// <summary>
            /// <para>是否激活</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>创建人的雇佣ID，详细信息可通过[【查询员工信息接口】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：123123123123123123</para>
            /// </summary>
            [JsonPropertyName("create_by")]
            public string? CreateBy { get; set; }

            /// <summary>
            /// <para>修改人的雇佣ID，详细信息可通过[【查询员工信息接口】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7287500478366090796</para>
            /// </summary>
            [JsonPropertyName("modify_by")]
            public string? ModifyBy { get; set; }

            /// <summary>
            /// <para>电子签模板适用范围，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板适用范围（signature_template_applicability）枚举定义部分</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("applicability")]
            public Enum? Applicability { get; set; }

            /// <summary>
            /// <para>模板创建方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：online_edit</para>
            /// </summary>
            [JsonPropertyName("creation_method")]
            public string? CreationMethod { get; set; }

            /// <summary>
            /// <para>版本</para>
            /// <para>必填：否</para>
            /// <para>示例值：v1</para>
            /// </summary>
            [JsonPropertyName("version")]
            public string? Version { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：31231232123</para>
            /// <para>最大值：4294967296</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：3123123211</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>模板设置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("template_setting")]
            public SignatureTemplateSetting? TemplateSetting { get; set; }

            /// <summary>
            /// <para>模板设置</para>
            /// </summary>
            public record SignatureTemplateSetting
            {
                /// <summary>
                /// <para>骑缝章类型</para>
                /// <para>必填：否</para>
                /// <para>最大长度：4294967296</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("page_seal_types")]
                public string[]? PageSealTypes { get; set; }
            }

            /// <summary>
            /// <para>模板适用区域</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("template_region_info")]
            public SignatureTemplateRegionInfo? TemplateRegionInfo { get; set; }

            /// <summary>
            /// <para>模板适用区域</para>
            /// </summary>
            public record SignatureTemplateRegionInfo
            {
                /// <summary>
                /// <para>是否全球适用</para>
                /// <para>必填：否</para>
                /// <para>示例值：global</para>
                /// </summary>
                [JsonPropertyName("is_global_scope")]
                public string? IsGlobalScope { get; set; }

                /// <summary>
                /// <para>适用区域名称</para>
                /// <para>必填：否</para>
                /// <para>最大长度：4294967296</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("meta_infos")]
                public SignatureMetaInfo[]? MetaInfos { get; set; }

                /// <summary>
                /// <para>适用区域名称</para>
                /// </summary>
                public record SignatureMetaInfo
                {
                    /// <summary>
                    /// <para>区域名称apiName</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7246307700768902956</para>
                    /// </summary>
                    [JsonPropertyName("api_name")]
                    public string? ApiName { get; set; }

                    /// <summary>
                    /// <para>区域对应的唯一ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：7246307700768902956</para>
                    /// </summary>
                    [JsonPropertyName("wk_id")]
                    public string? WkId { get; set; }

                    /// <summary>
                    /// <para>多语描述</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：10</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("label")]
                    public I18n[]? Labels { get; set; }

                    /// <summary>
                    /// <para>多语描述</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }
            }

            /// <summary>
            /// <para>模板编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：7246307700768902956</para>
            /// </summary>
            [JsonPropertyName("template_code")]
            public string? TemplateCode { get; set; }

            /// <summary>
            /// <para>模板描述 支持多语</para>
            /// <para>必填：否</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("template_desc")]
            public I18n[]? TemplateDescs { get; set; }
        }

        /// <summary>
        /// <para>模板内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("content_info")]
        public SignatureTemplateContentInfo? ContentInfo { get; set; }

        /// <summary>
        /// <para>模板内容</para>
        /// </summary>
        public record SignatureTemplateContentInfo
        {
            /// <summary>
            /// <para>【已废弃，无需关注】</para>
            /// <para>必填：否</para>
            /// <para>最大长度：4294967296</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("contents")]
            public SignatureTemplateContentItem[]? Contents { get; set; }

            /// <summary>
            /// <para>【已废弃，无需关注】</para>
            /// </summary>
            public record SignatureTemplateContentItem
            {
                /// <summary>
                /// <para>电子签模版内容的类型</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("content_type")]
                public Enum ContentType { get; set; } = new();

                /// <summary>
                /// <para>电子签模版内容的类型</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
                    /// </summary>
                    [JsonPropertyName("enum_name")]
                    public string EnumName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("display")]
                    public I18n[]? Displies { get; set; }

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>显示规则左值</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("filter_apiname")]
                public string? FilterApiname { get; set; }

                /// <summary>
                /// <para>模版内容</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>中英文描述</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("label")]
                public I18n[]? Labels { get; set; }

                /// <summary>
                /// <para>中英文描述</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言编码（IETF BCP 47）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：中文示例</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>内容描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：111</para>
                /// </summary>
                [JsonPropertyName("content_desc")]
                public string? ContentDesc { get; set; }
            }

            /// <summary>
            /// <para>自定义字段列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：4294967296</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public SignatureTemplateCustomField[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段列表</para>
            /// </summary>
            public record SignatureTemplateCustomField
            {
                /// <summary>
                /// <para>中英文描述</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("label")]
                public I18n[]? Labels { get; set; }

                /// <summary>
                /// <para>中英文描述</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：中文示例</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：status</para>
                /// </summary>
                [JsonPropertyName("apiname")]
                public string Apiname { get; set; } = string.Empty;

                /// <summary>
                /// <para>用户自定义字段类型</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("custom_field_type")]
                public Enum CustomFieldType { get; set; } = new();

                /// <summary>
                /// <para>用户自定义字段类型</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
                    /// </summary>
                    [JsonPropertyName("enum_name")]
                    public string EnumName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("display")]
                    public I18n[]? Displies { get; set; }

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言编码（IETF BCP 47）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>是否使用到</para>
                /// <para>必填：是</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("used")]
                public bool Used { get; set; }

                /// <summary>
                /// <para>是否需要</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_required")]
                public bool? IsRequired { get; set; }

                /// <summary>
                /// <para>自定义描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：desc</para>
                /// </summary>
                [JsonPropertyName("custom_desc")]
                public string? CustomDesc { get; set; }

                /// <summary>
                /// <para>电子签模版公共字段信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("common_info")]
                public SignatureTemplateCommonFieldInfo? CommonInfo { get; set; }

                /// <summary>
                /// <para>电子签模版公共字段信息</para>
                /// </summary>
                public record SignatureTemplateCommonFieldInfo
                {
                    /// <summary>
                    /// <para>模板字段源类型；枚举值填到enum_name中，如："System" "MainData"</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("source")]
                    public Enum Source { get; set; } = new();

                    /// <summary>
                    /// <para>模板字段源类型；枚举值填到enum_name中，如："System" "MainData"</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
                        /// </summary>
                        [JsonPropertyName("enum_name")]
                        public string EnumName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("display")]
                        public I18n[]? Displies { get; set; }

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>语言编码（IETF BCP 47）</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>文本内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：中文示例</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>主数据apiname</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：status</para>
                    /// </summary>
                    [JsonPropertyName("apiname")]
                    public string Apiname { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>【已废弃，无需关注】</para>
            /// <para>必填：否</para>
            /// <para>最大长度：4294967296</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("filter_fields")]
            public SignatureTemplateFilter[]? FilterFields { get; set; }

            /// <summary>
            /// <para>【已废弃，无需关注】</para>
            /// </summary>
            public record SignatureTemplateFilter
            {
                /// <summary>
                /// <para>双语描述</para>
                /// <para>必填：是</para>
                /// <para>最大长度：10</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("label")]
                public I18n[] Labels { get; set; } = [];

                /// <summary>
                /// <para>双语描述</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言编码（IETF BCP 47）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：中文示例</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>主数据apiname</para>
                /// <para>必填：是</para>
                /// <para>示例值：status</para>
                /// </summary>
                [JsonPropertyName("apiname")]
                public string Apiname { get; set; } = string.Empty;

                /// <summary>
                /// <para>过滤条件列表</para>
                /// <para>必填：否</para>
                /// <para>最大长度：4294967296</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("filters")]
                public SignatureTemplateFilterItem[]? Filters { get; set; }

                /// <summary>
                /// <para>过滤条件列表</para>
                /// </summary>
                public record SignatureTemplateFilterItem
                {
                    /// <summary>
                    /// <para>左值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：aa</para>
                    /// </summary>
                    [JsonPropertyName("left")]
                    public string Left { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>右值列表</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：4294967296</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("rights")]
                    public string[]? Rights { get; set; }

                    /// <summary>
                    /// <para>操作符</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("op")]
                    public Enum Op { get; set; } = new();

                    /// <summary>
                    /// <para>操作符</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
                        /// </summary>
                        [JsonPropertyName("enum_name")]
                        public string EnumName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("display")]
                        public I18n[]? Displies { get; set; }

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>语言编码（IETF BCP 47）</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>文本内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：中文示例</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }
                }

                /// <summary>
                /// <para>多个生效条件的logic</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("logic")]
                public Enum? Logic { get; set; }

                /// <summary>
                /// <para>多个生效条件的logic</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
                    /// </summary>
                    [JsonPropertyName("enum_name")]
                    public string EnumName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("display")]
                    public I18n[]? Displies { get; set; }

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言编码（IETF BCP 47）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>是否被校验</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_checked")]
                public bool? IsChecked { get; set; }

                /// <summary>
                /// <para>过滤条件描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：desc</para>
                /// </summary>
                [JsonPropertyName("filter_desc")]
                public string? FilterDesc { get; set; }

                /// <summary>
                /// <para>过滤条件列表，使用string类型描述list的原因是为了避免循环引用问题，因为该list的item类型就是这个数据类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：[]</para>
                /// </summary>
                [JsonPropertyName("criterion_list")]
                public string? CriterionList { get; set; }
            }

            /// <summary>
            /// <para>【已废弃，无需关注】</para>
            /// <para>必填：否</para>
            /// <para>最大长度：4294967296</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("using_fields")]
            public SignatureTemplateCommonFieldInfo[]? UsingFields { get; set; }

            /// <summary>
            /// <para>【已废弃，无需关注】</para>
            /// </summary>
            public record SignatureTemplateCommonFieldInfo
            {
                /// <summary>
                /// <para>模板字段源类型；枚举值填到enum_name中，如："System" "MainData"</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("source")]
                public Enum Source { get; set; } = new();

                /// <summary>
                /// <para>模板字段源类型；枚举值填到enum_name中，如："System" "MainData"</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
                    /// </summary>
                    [JsonPropertyName("enum_name")]
                    public string EnumName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("display")]
                    public I18n[]? Displies { get; set; }

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言编码（IETF BCP 47）</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：status</para>
                /// </summary>
                [JsonPropertyName("apiname")]
                public string Apiname { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>系统字段列表</para>
            /// <para>必填：否</para>
            /// <para>最大长度：4294967296</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("system_setting_fields")]
            public SignatureTemplateField[]? SystemSettingFields { get; set; }

            /// <summary>
            /// <para>系统字段列表</para>
            /// </summary>
            public record SignatureTemplateField
            {
                /// <summary>
                /// <para>模板字段值类型枚举</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("field_type")]
                public Enum FieldType { get; set; } = new();

                /// <summary>
                /// <para>模板字段值类型枚举</para>
                /// </summary>
                public record Enum
                {
                    /// <summary>
                    /// <para>枚举值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：phone_type</para>
                    /// </summary>
                    [JsonPropertyName("enum_name")]
                    public string EnumName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("display")]
                    public I18n[]? Displies { get; set; }

                    /// <summary>
                    /// <para>枚举多语展示</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>双语描述</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("label")]
                public I18n[]? Labels { get; set; }

                /// <summary>
                /// <para>双语描述</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：中文示例</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>【无需关注】通用字段信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("common_info")]
                public SignatureTemplateCommonFieldInfo? CommonInfo { get; set; }

                /// <summary>
                /// <para>【无需关注】通用字段信息</para>
                /// </summary>
                public record SignatureTemplateCommonFieldInfo
                {
                    /// <summary>
                    /// <para>模板字段源类型</para>
                    /// <para>- System</para>
                    /// <para>- MainData</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("source")]
                    public Enum Source { get; set; } = new();

                    /// <summary>
                    /// <para>模板字段源类型</para>
                    /// <para>- System</para>
                    /// <para>- MainData</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：System</para>
                        /// </summary>
                        [JsonPropertyName("enum_name")]
                        public string EnumName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("display")]
                        public I18n[]? Displies { get; set; }

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>语言</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>文本内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：中文示例</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>字段名称</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：status</para>
                    /// </summary>
                    [JsonPropertyName("apiname")]
                    public string Apiname { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>【无需关注】组合字段信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("combination_info")]
                public SignatureTemplateCombinationFieldInfo? CombinationInfo { get; set; }

                /// <summary>
                /// <para>【无需关注】组合字段信息</para>
                /// </summary>
                public record SignatureTemplateCombinationFieldInfo
                {
                    /// <summary>
                    /// <para>【无需关注】组合字段名</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：status</para>
                    /// </summary>
                    [JsonPropertyName("total_apiname")]
                    public string TotalApiname { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>字段名</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：status</para>
                    /// </summary>
                    [JsonPropertyName("apiname")]
                    public string Apiname { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>中英文描述</para>
                    /// <para>必填：是</para>
                    /// <para>最大长度：10</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public I18n[] Titles { get; set; } = [];

                    /// <summary>
                    /// <para>中英文描述</para>
                    /// </summary>
                    public record I18n
                    {
                        /// <summary>
                        /// <para>语言</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：zh-CN</para>
                        /// </summary>
                        [JsonPropertyName("lang")]
                        public string Lang { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>文本内容</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：中文示例</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string Value { get; set; } = string.Empty;
                    }

                    /// <summary>
                    /// <para>适用区域名称</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：4294967296</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("contents")]
                    public SignatureTemplateCombinationSubFieldInfo[][]? Contents { get; set; }

                    /// <summary>
                    /// <para>适用区域名称</para>
                    /// </summary>
                    public record SignatureTemplateCombinationSubFieldInfo
                    {
                        /// <summary>
                        /// <para>字段类型枚举</para>
                        /// <para>必填：是</para>
                        /// </summary>
                        [JsonPropertyName("field_type")]
                        public Enum FieldType { get; set; } = new();

                        /// <summary>
                        /// <para>字段类型枚举</para>
                        /// </summary>
                        public record Enum
                        {
                            /// <summary>
                            /// <para>枚举值</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：phone_type</para>
                            /// </summary>
                            [JsonPropertyName("enum_name")]
                            public string EnumName { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>枚举多语展示</para>
                            /// <para>必填：否</para>
                            /// </summary>
                            [JsonPropertyName("display")]
                            public I18n[]? Displies { get; set; }

                            /// <summary>
                            /// <para>枚举多语展示</para>
                            /// </summary>
                            public record I18n
                            {
                                /// <summary>
                                /// <para>语言</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：zh-CN</para>
                                /// </summary>
                                [JsonPropertyName("lang")]
                                public string Lang { get; set; } = string.Empty;

                                /// <summary>
                                /// <para>文本内容</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：中文示例</para>
                                /// </summary>
                                [JsonPropertyName("value")]
                                public string Value { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// <para>公共字段信息</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("info")]
                        public SignatureTemplateCommonFieldInfo? Info { get; set; }

                        /// <summary>
                        /// <para>公共字段信息</para>
                        /// </summary>
                        public record SignatureTemplateCommonFieldInfo
                        {
                            /// <summary>
                            /// <para>模板字段源类型；</para>
                            /// <para>- System</para>
                            /// <para>- MainData</para>
                            /// <para>必填：是</para>
                            /// </summary>
                            [JsonPropertyName("source")]
                            public Enum Source { get; set; } = new();

                            /// <summary>
                            /// <para>模板字段源类型；</para>
                            /// <para>- System</para>
                            /// <para>- MainData</para>
                            /// </summary>
                            public record Enum
                            {
                                /// <summary>
                                /// <para>枚举值</para>
                                /// <para>必填：是</para>
                                /// <para>示例值：System</para>
                                /// </summary>
                                [JsonPropertyName("enum_name")]
                                public string EnumName { get; set; } = string.Empty;

                                /// <summary>
                                /// <para>枚举多语展示</para>
                                /// <para>必填：否</para>
                                /// </summary>
                                [JsonPropertyName("display")]
                                public I18n[]? Displies { get; set; }

                                /// <summary>
                                /// <para>枚举多语展示</para>
                                /// </summary>
                                public record I18n
                                {
                                    /// <summary>
                                    /// <para>语言</para>
                                    /// <para>必填：是</para>
                                    /// <para>示例值：zh-CN</para>
                                    /// </summary>
                                    [JsonPropertyName("lang")]
                                    public string Lang { get; set; } = string.Empty;

                                    /// <summary>
                                    /// <para>文本内容</para>
                                    /// <para>必填：是</para>
                                    /// <para>示例值：中文示例</para>
                                    /// </summary>
                                    [JsonPropertyName("value")]
                                    public string Value { get; set; } = string.Empty;
                                }
                            }

                            /// <summary>
                            /// <para>字段名称</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：status</para>
                            /// </summary>
                            [JsonPropertyName("apiname")]
                            public string Apiname { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>双语描述</para>
                        /// <para>必填：否</para>
                        /// <para>最大长度：10</para>
                        /// <para>最小长度：0</para>
                        /// </summary>
                        [JsonPropertyName("label")]
                        public I18n[]? Labels { get; set; }

                        /// <summary>
                        /// <para>双语描述</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>语言</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>文本内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：中文示例</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }

                    /// <summary>
                    /// <para>【无需关注】电子签模板字段源类型</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("source")]
                    public Enum Source { get; set; } = new();

                    /// <summary>
                    /// <para>【无需关注】电子签模板字段源类型</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
                        /// </summary>
                        [JsonPropertyName("enum_name")]
                        public string EnumName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("display")]
                        public I18n[]? Displies { get; set; }

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>语言编码（IETF BCP 47）</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>文本内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：中文示例</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }
                }

                /// <summary>
                /// <para>【无需关注】子模板配置信息列表对应的string，避免循环引用问题</para>
                /// <para>必填：否</para>
                /// <para>示例值：无需关注</para>
                /// </summary>
                [JsonPropertyName("children")]
                public string? Children { get; set; }

                /// <summary>
                /// <para>弃用，无需关注</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("combination_info_v2")]
                public SignatureTemplateCombinationFieldInfoV2? CombinationInfoV2 { get; set; }

                /// <summary>
                /// <para>弃用，无需关注</para>
                /// </summary>
                public record SignatureTemplateCombinationFieldInfoV2
                {
                    /// <summary>
                    /// <para>弃用，无需关注</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：弃用，无需关注</para>
                    /// </summary>
                    [JsonPropertyName("total_apiname")]
                    public string TotalApiname { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>弃用，无需关注</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：弃用，无需关注</para>
                    /// </summary>
                    [JsonPropertyName("apiname")]
                    public string Apiname { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>弃用，无需关注</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("source")]
                    public Enum? Source { get; set; }

                    /// <summary>
                    /// <para>弃用，无需关注</para>
                    /// </summary>
                    public record Enum
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：phone_type</para>
                        /// </summary>
                        [JsonPropertyName("enum_name")]
                        public string EnumName { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("display")]
                        public I18n[]? Displies { get; set; }

                        /// <summary>
                        /// <para>枚举多语展示</para>
                        /// </summary>
                        public record I18n
                        {
                            /// <summary>
                            /// <para>语言编码（IETF BCP 47）</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("lang")]
                            public string Lang { get; set; } = string.Empty;

                            /// <summary>
                            /// <para>文本内容</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：中文示例</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string Value { get; set; } = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
