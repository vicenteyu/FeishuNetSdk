// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchCorehrV1CompaniesByCompanyIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新公司 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新公司 请求体
/// <para>更新公司信息，包括基本信息、注册地址、办公地址等</para>
/// <para>接口ID：7309323790810824705</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcompany%2fpatch</para>
/// </summary>
public record PatchCorehrV1CompaniesByCompanyIdBodyDto
{
    /// <summary>
    /// <para>组织实体公共字段，包括名称、描述、上级、启停用状态、生效日期、编码等基础信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("hiberarchy_common")]
    public PatchCorehrV1CompaniesByCompanyIdBodyDtoHiberarchyCommon? HiberarchyCommon { get; set; }

    /// <summary>
    /// <para>组织实体公共字段，包括名称、描述、上级、启停用状态、生效日期、编码等基础信息</para>
    /// </summary>
    public record PatchCorehrV1CompaniesByCompanyIdBodyDtoHiberarchyCommon
    {
        /// <summary>
        /// <para>上级组织</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719168654814483759</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>公司名称</para>
        /// <para>- 名称不能包含「/」「；」「;」字符。</para>
        /// <para>- 公司中英文名称会有全局唯一校验</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>公司名称</para>
        /// <para>- 名称不能包含「/」「；」「;」字符。</para>
        /// <para>- 公司中英文名称会有全局唯一校验</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容，支持中文和英文</para>
            /// <para>必填：是</para>
            /// <para>示例值：xx有限科技公司</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否启用该公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>版本生效日期</para>
        /// <para>- 填写格式：YYYY-MM-DD 00:00:00（系统会自动将时分秒改为00:00:00）</para>
        /// <para>- 系统默认为填写日期当天的 00:00:00 生效</para>
        /// <para>- 该接口只支持到最小单位为日</para>
        /// <para>- 日期范围要求:1900-01-01 00:00:00～9999-12-31 23:59:59</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>公司编码 (不能与其他记录的编码重复)，如果不传值则不更新</para>
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
    }

    /// <summary>
    /// <para>公司性质，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=type。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public Enum? Type { get; set; }

    /// <summary>
    /// <para>公司性质，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=type。</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：private_owned</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>所在行业，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=industry。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("industry_list")]
    public Enum[]? IndustryLists { get; set; }

    /// <summary>
    /// <para>法定代表人。仅注册地址中的 国家 / 地区 为中国大陆时，法人字段填入才有效。</para>
    /// <para>若注册地址中的 国家 / 地区 不为中国大陆时，则填入法人字段无效。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("legal_representative")]
    public I18n[]? LegalRepresentatives { get; set; }

    /// <summary>
    /// <para>法定代表人。仅注册地址中的 国家 / 地区 为中国大陆时，法人字段填入才有效。</para>
    /// <para>若注册地址中的 国家 / 地区 不为中国大陆时，则填入法人字段无效。</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>内容，支持中文和英文。</para>
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
    /// <para>是否保密，该功能暂不支持，可以忽略</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("confidential")]
    public bool? Confidential { get; set; }

    /// <summary>
    /// <para>公司主体类型，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=subtype。</para>
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
    public PatchCorehrV1CompaniesByCompanyIdBodyDtoCurrency? Currency { get; set; }

    /// <summary>
    /// <para>默认币种</para>
    /// </summary>
    public record PatchCorehrV1CompaniesByCompanyIdBodyDtoCurrency
    {
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
            /// <para>语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容，支持中文和英文</para>
            /// <para>必填：是</para>
            /// <para>示例值：xx科技有限公司</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>对应币种的指代代码，通过系统内部查找，通过[查询货币信息v2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)查询获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("numeric_code")]
        public int? NumericCode { get; set; }

        /// <summary>
        /// <para>法定货币对应代码，如CNY、USD等.通过[查询货币信息v2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)查询获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：CNY</para>
        /// </summary>
        [JsonPropertyName("currency_alpha_3_code")]
        public string? CurrencyAlpha3Code { get; set; }
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
        /// <para>区号对应的数字，可通过</para>
        /// <para>[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code。</para>
        /// <para>必填：是</para>
        /// <para>示例值：123123</para>
        /// </summary>
        [JsonPropertyName("area_code")]
        public Enum AreaCode { get; set; } = new();

        /// <summary>
        /// <para>区号对应的数字，可通过</para>
        /// <para>[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code。</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>区号对应名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：86_china</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;
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
    /// <para>注册地址详细信息。公共字段，若请求对象为公司，则该字段必填。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("registered_office_address_info")]
    public Address? RegisteredOfficeAddressInfo { get; set; }

    /// <summary>
    /// <para>注册地址详细信息。公共字段，若请求对象为公司，则该字段必填。</para>
    /// </summary>
    public record Address
    {
        /// <summary>
        /// <para>国家 / 地区 ID。各国家/地区填写字段可参考[地址填写规则](https://bytedance.larkoffice.com/wiki/GoL4wAKAXis3OWku72YcEjTxnKe?sheet=0sMjoP)查询。可通过</para>
        /// <para>[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)查询获取。</para>
        /// <para>必填：是</para>
        /// <para>示例值：6862995757234914824</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string CountryRegionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>主要行政区ID.可通过</para>
        /// <para>[查询省份/主要行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)查询获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863326815667095047</para>
        /// </summary>
        [JsonPropertyName("region_id")]
        public string? RegionId { get; set; }

        /// <summary>
        /// <para>城市ID.可通过</para>
        /// <para>[查询城市信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)查询获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863333254578046471</para>
        /// </summary>
        [JsonPropertyName("city_id")]
        public string? CityId { get; set; }

        /// <summary>
        /// <para>区/县ID.可通过</para>
        /// <para>[查询区/县信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)查询获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863333516579440141</para>
        /// </summary>
        [JsonPropertyName("distinct_id")]
        public string? DistinctId { get; set; }

        /// <summary>
        /// <para>地址行 1</para>
        /// <para>必填：否</para>
        /// <para>示例值：丹佛测试地址-纽埃时区</para>
        /// </summary>
        [JsonPropertyName("address_line1")]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// <para>地址行 2</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("address_line2")]
        public string? AddressLine2 { get; set; }

        /// <summary>
        /// <para>地址行 3</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("address_line3")]
        public string? AddressLine3 { get; set; }

        /// <summary>
        /// <para>地址行 4</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line4")]
        public string? AddressLine4 { get; set; }

        /// <summary>
        /// <para>地址行 5</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line5")]
        public string? AddressLine5 { get; set; }

        /// <summary>
        /// <para>地址行 6</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line6")]
        public string? AddressLine6 { get; set; }

        /// <summary>
        /// <para>地址行 7</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("address_line7")]
        public string? AddressLine7 { get; set; }

        /// <summary>
        /// <para>地址行 8</para>
        /// <para>必填：否</para>
        /// <para>示例值：rafSu</para>
        /// </summary>
        [JsonPropertyName("address_line8")]
        public string? AddressLine8 { get; set; }

        /// <summary>
        /// <para>地址行 9</para>
        /// <para>必填：否</para>
        /// <para>示例值：McPRG</para>
        /// </summary>
        [JsonPropertyName("address_line9")]
        public string? AddressLine9 { get; set; }

        /// <summary>
        /// <para>地址行 1（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：丹佛测试地址-纽埃时区</para>
        /// </summary>
        [JsonPropertyName("local_address_line1")]
        public string? LocalAddressLine1 { get; set; }

        /// <summary>
        /// <para>地址行 2（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("local_address_line2")]
        public string? LocalAddressLine2 { get; set; }

        /// <summary>
        /// <para>地址行 3（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：PoewH</para>
        /// </summary>
        [JsonPropertyName("local_address_line3")]
        public string? LocalAddressLine3 { get; set; }

        /// <summary>
        /// <para>地址行 4（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line4")]
        public string? LocalAddressLine4 { get; set; }

        /// <summary>
        /// <para>地址行 5（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line5")]
        public string? LocalAddressLine5 { get; set; }

        /// <summary>
        /// <para>地址行 6（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line6")]
        public string? LocalAddressLine6 { get; set; }

        /// <summary>
        /// <para>地址行 7（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：jmwJc</para>
        /// </summary>
        [JsonPropertyName("local_address_line7")]
        public string? LocalAddressLine7 { get; set; }

        /// <summary>
        /// <para>地址行 8（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：rafSu</para>
        /// </summary>
        [JsonPropertyName("local_address_line8")]
        public string? LocalAddressLine8 { get; set; }

        /// <summary>
        /// <para>地址行 9（非拉丁语系的本地文字）</para>
        /// <para>必填：否</para>
        /// <para>示例值：McPRG</para>
        /// </summary>
        [JsonPropertyName("local_address_line9")]
        public string? LocalAddressLine9 { get; set; }

        /// <summary>
        /// <para>邮政编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：611530</para>
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }
    }

    /// <summary>
    /// <para>办公地址详细信息。公共字段，若请求对象为公司，则该字段必填。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("office_address_info")]
    public Address? OfficeAddressInfo { get; set; }
}
