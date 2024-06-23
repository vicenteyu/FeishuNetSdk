// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2CompaniesBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过公司 ID 批量获取公司信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过公司 ID 批量获取公司信息 响应体
/// <para>通过公司 ID 批量获取公司信息</para>
/// <para>接口ID：7252157701853184028</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fbatch_get</para>
/// </summary>
public record PostCorehrV2CompaniesBatchGetResponseDto
{
    /// <summary>
    /// <para>查询的公司信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Company[]? Items { get; set; }

    /// <summary>
    /// <para>查询的公司信息</para>
    /// </summary>
    public record Company
    {
        /// <summary>
        /// <para>公司 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4692472714243080020</para>
        /// </summary>
        [JsonPropertyName("company_id")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// <para>公司基本信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("hiberarchy_common")]
        public CompanyHiberarchyCommon HiberarchyCommon { get; set; } = new();

        /// <summary>
        /// <para>公司基本信息</para>
        /// </summary>
        public record CompanyHiberarchyCommon
        {
            /// <summary>
            /// <para>上级</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719168654814483759</para>
            /// </summary>
            [JsonPropertyName("parent_id")]
            public string? ParentId { get; set; }

            /// <summary>
            /// <para>名称</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[] Names { get; set; } = Array.Empty<I18n>();

            /// <summary>
            /// <para>名称</para>
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
            /// <para>类型</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("type")]
            public Enum Type { get; set; } = new();

            /// <summary>
            /// <para>类型</para>
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
            /// <para>启用</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool Active { get; set; }

            /// <summary>
            /// <para>生效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-01 00:00:00</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>失效时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-02 00:00:00</para>
            /// </summary>
            [JsonPropertyName("expiration_time")]
            public string? ExpirationTime { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：12456</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>树形排序</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("tree_order")]
            public string? TreeOrder { get; set; }

            /// <summary>
            /// <para>列表排序</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("list_order")]
            public string? ListOrder { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("custom_fields")]
            public ObjectFieldData[]? CustomFields { get; set; }

            /// <summary>
            /// <para>自定义字段</para>
            /// </summary>
            public record ObjectFieldData
            {
                /// <summary>
                /// <para>字段名</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("field_name")]
                public string FieldName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
                /// <para>必填：是</para>
                /// <para>示例值：Sandy</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>性质</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public Enum? Type { get; set; }

        /// <summary>
        /// <para>性质</para>
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
        /// <para>行业</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("industry_list")]
        public Enum[]? IndustryLists { get; set; }

        /// <summary>
        /// <para>法定代表人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("legal_representative")]
        public I18n[]? LegalRepresentatives { get; set; }

        /// <summary>
        /// <para>法定代表人</para>
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
        /// <para>邮编</para>
        /// <para>必填：否</para>
        /// <para>示例值：邮编</para>
        /// </summary>
        [JsonPropertyName("post_code")]
        public string? PostCode { get; set; }

        /// <summary>
        /// <para>纳税人识别号</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456840</para>
        /// </summary>
        [JsonPropertyName("tax_payer_id")]
        public string? TaxPayerId { get; set; }

        /// <summary>
        /// <para>是否保密</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("confidential")]
        public bool? Confidential { get; set; }

        /// <summary>
        /// <para>主体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sub_type_list")]
        public Enum[]? SubTypeLists { get; set; }

        /// <summary>
        /// <para>是否为分公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("branch_company")]
        public bool? BranchCompany { get; set; }

        /// <summary>
        /// <para>主要负责人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("primary_manager")]
        public I18n[]? PrimaryManagers { get; set; }

        /// <summary>
        /// <para>默认币种</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("currency")]
        public CompanyCurrency? Currency { get; set; }

        /// <summary>
        /// <para>默认币种</para>
        /// </summary>
        public record CompanyCurrency
        {
            /// <summary>
            /// <para>货币 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893114062142064111</para>
            /// </summary>
            [JsonPropertyName("currency_id")]
            public string? CurrencyId { get; set; }

            /// <summary>
            /// <para>货币所属国家/地区 ID，详细信息可通过[【查询国家/地区信息】](https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893114162142064111</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string? CountryRegionId { get; set; }

            /// <summary>
            /// <para>货币名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("currency_name")]
            public I18n[]? CurrencyNames { get; set; }

            /// <summary>
            /// <para>货币名称</para>
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
            /// <para>数字代码</para>
            /// <para>必填：否</para>
            /// <para>示例值：156</para>
            /// </summary>
            [JsonPropertyName("numeric_code")]
            public int? NumericCode { get; set; }

            /// <summary>
            /// <para>三位字母代码</para>
            /// <para>必填：否</para>
            /// <para>示例值：CNY</para>
            /// </summary>
            [JsonPropertyName("currency_alpha_3_code")]
            public string? CurrencyAlpha3Code { get; set; }

            /// <summary>
            /// <para>状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：生效</item>
            /// <item>0：失效</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }
        }

        /// <summary>
        /// <para>电话</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("phone")]
        public PhoneNumberAndAreaCode? Phone { get; set; }

        /// <summary>
        /// <para>电话</para>
        /// </summary>
        public record PhoneNumberAndAreaCode
        {
            /// <summary>
            /// <para>区号</para>
            /// <para>必填：是</para>
            /// <para>示例值：123123</para>
            /// </summary>
            [JsonPropertyName("area_code")]
            public Enum AreaCode { get; set; } = new();

            /// <summary>
            /// <para>区号</para>
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
            /// <para>号码</para>
            /// <para>必填：是</para>
            /// <para>示例值：213213</para>
            /// </summary>
            [JsonPropertyName("phone_number")]
            public string PhoneNumber { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>传真</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("fax")]
        public PhoneNumberAndAreaCode? Fax { get; set; }

        /// <summary>
        /// <para>注册地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("registered_office_address")]
        public I18n[]? RegisteredOfficeAddress { get; set; }

        /// <summary>
        /// <para>办公地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("office_address")]
        public I18n[]? OfficeAddress { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record CustomFieldData
        {
            /// <summary>
            /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("custom_api_name")]
            public string CustomApiName { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public CustomName? Name { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// </summary>
            public record CustomName
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：自定义姓名</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Custom Name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }
}
