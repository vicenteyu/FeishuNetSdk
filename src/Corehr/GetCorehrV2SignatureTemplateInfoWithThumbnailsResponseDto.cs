// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="GetCorehrV2SignatureTemplateInfoWithThumbnailsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取电子签模板列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取电子签模板列表 响应体
/// <para>该接口用于批量获取电子签模板信息，包括模板类别、用途、适用区域等。</para>
/// <para>接口ID：7376163028442824732</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_template_info_with_thumbnail/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_template_info_with_thumbnail%2flist</para>
/// </summary>
public record GetCorehrV2SignatureTemplateInfoWithThumbnailsResponseDto
{
    /// <summary>
    /// <para>电子签模板列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public SignatureTemplateInfoWithThumbnail[]? Items { get; set; }

    /// <summary>
    /// <para>电子签模板列表</para>
    /// </summary>
    public record SignatureTemplateInfoWithThumbnail
    {
        /// <summary>
        /// <para>id</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>名称 支持多语</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("label")]
        public I18n[]? Labels { get; set; }

        /// <summary>
        /// <para>名称 支持多语</para>
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
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>模版类别</para>
        /// <para>枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板类别（signature_template_category）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("category")]
        public Enum? Category { get; set; }

        /// <summary>
        /// <para>模版类别</para>
        /// <para>枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板类别（signature_template_category）枚举定义部分获得</para>
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
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>模版用途；</para>
        /// <para>枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签模板类别（signature_template_category）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("usage")]
        public Enum? Usage { get; set; }

        /// <summary>
        /// <para>创建日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-12-21</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>修改日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-12-21</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public SignatureUserInfo? CreatedBy { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// </summary>
        public record SignatureUserInfo
        {
            /// <summary>
            /// <para>雇佣ID，[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)</para>
            /// <para>必填：是</para>
            /// <para>示例值：7300476612163913260</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>修改人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public SignatureUserInfo? UpdatedBy { get; set; }

        /// <summary>
        /// <para>缩略图url</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// <para>模版签署人标签</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2147483647</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("signatory_labels")]
        public SignatureSignatoryLabel[]? SignatoryLabels { get; set; }

        /// <summary>
        /// <para>模版签署人标签</para>
        /// </summary>
        public record SignatureSignatoryLabel
        {
            /// <summary>
            /// <para>电子签模板签订人类型</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("template_signatory_type")]
            public Enum TemplateSignatoryType { get; set; } = new();

            /// <summary>
            /// <para>电子签模板签订人类型</para>
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
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>中英文描述</para>
            /// <para>必填：是</para>
            /// <para>最大长度：10</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("label")]
            public I18n[] Labels { get; set; } = [];

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
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>主数据apiname</para>
            /// <para>必填：否</para>
            /// <para>示例值：status</para>
            /// </summary>
            [JsonPropertyName("apiname")]
            public string? Apiname { get; set; }
        }

        /// <summary>
        /// <para>模板编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("template_code")]
        public string? TemplateCode { get; set; }

        /// <summary>
        /// <para>模板描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：desc</para>
        /// </summary>
        [JsonPropertyName("template_desc")]
        public string? TemplateDesc { get; set; }

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
                /// <para>元数据api_name</para>
                /// <para>必填：否</para>
                /// <para>示例值：status</para>
                /// </summary>
                [JsonPropertyName("api_name")]
                public string? ApiName { get; set; }

                /// <summary>
                /// <para>wukong id</para>
                /// <para>必填：否</para>
                /// <para>示例值：123124124124123</para>
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
                    /// <para>内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1000</para>
    /// <para>最大值：4294967296</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public int? PageToken { get; set; }

    /// <summary>
    /// <para>数据总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：1000</para>
    /// <para>最大值：4294967296</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
