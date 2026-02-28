// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-03-01
// ************************************************************************
// <copyright file="PostCorehrV2CompaniesQueryMultiTimelineResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定时间范围公司版本 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定时间范围公司版本 响应体
/// <para>- 接口支持查询出对象生效时间段在指定的start_date和end_date之间的版本（即：会查询出生效时间段和查询时间段有交集的版本）</para>
/// <para>- 接口支持对象版本相关字段的查询和返回（默认返回id和version_id）</para>
/// <para>接口ID：7473071080241545220</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2CompaniesQueryMultiTimelineResponseDto
{
    /// <summary>
    /// <para>公司信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CompanyTimeline[]? Items { get; set; }

    /// <summary>
    /// <para>公司信息</para>
    /// </summary>
    public record CompanyTimeline
    {
        /// <summary>
        /// <para>公司版本信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：500</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("company_version_data")]
        public CompanyVersionData[]? CompanyVersionDatas { get; set; }

        /// <summary>
        /// <para>公司版本信息</para>
        /// </summary>
        public record CompanyVersionData
        {
            /// <summary>
            /// <para>公司 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("company_id")]
            public string? CompanyId { get; set; }

            /// <summary>
            /// <para>公司版本 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7238516215202170412</para>
            /// </summary>
            [JsonPropertyName("company_version_id")]
            public string? CompanyVersionId { get; set; }

            /// <summary>
            /// <para>公司名称</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("company_names")]
            public I18n[]? CompanyNames { get; set; }

            /// <summary>
            /// <para>公司名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言信息，中文：zh-CN，英文en-US</para>
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
            /// <para>上级公司 ID</para>
            /// <para>- 若查询的是一级公司，则该字段不展示</para>
            /// <para>必填：否</para>
            /// <para>示例值：4719456877659520852</para>
            /// </summary>
            [JsonPropertyName("parent_company_id")]
            public string? ParentCompanyId { get; set; }

            /// <summary>
            /// <para>当前版本生效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD （最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 ～9999-12-31</para>
            /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-01</para>
            /// </summary>
            [JsonPropertyName("effective_date")]
            public string? EffectiveDate { get; set; }

            /// <summary>
            /// <para>当前版本失效日期</para>
            /// <para>- 返回格式：YYYY-MM-DD （最小单位到日）</para>
            /// <para>- 日期范围:1900-01-01 ～9999-12-31</para>
            /// <para>- 详情可以参考[时间轴介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/about-timeline-version)</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-05-02</para>
            /// </summary>
            [JsonPropertyName("expiration_date")]
            public string? ExpirationDate { get; set; }

            /// <summary>
            /// <para>是否启用</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("active")]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// <para>必填：否</para>
            /// <para>最大长度：2</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("descriptions")]
            public I18n[]? Descriptions { get; set; }

            /// <summary>
            /// <para>编码</para>
            /// <para>必填：否</para>
            /// <para>示例值：FJK387</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string? Code { get; set; }
        }

        /// <summary>
        /// <para>公司性质</para>
        /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=type。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public Enum? Type { get; set; }

        /// <summary>
        /// <para>公司性质</para>
        /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=company；custom_api_name=type。</para>
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
                /// <para>语言信息，中文：zh-CN，英文en-US</para>
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
        /// <para>所在行业</para>
        /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。查询参数：object_api_name=company；custom_api_name=industry</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("industry_list")]
        public Enum[]? IndustryLists { get; set; }

        /// <summary>
        /// <para>法定代表人</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("legal_representative")]
        public I18n[]? LegalRepresentatives { get; set; }

        /// <summary>
        /// <para>法定代表人</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言信息，中文：zh-CN，英文en-US</para>
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
        /// <para>邮编</para>
        /// <para>必填：否</para>
        /// <para>示例值：645623412342</para>
        /// </summary>
        [JsonPropertyName("post_code")]
        public string? PostCode { get; set; }

        /// <summary>
        /// <para>纳税人识别号</para>
        /// <para>必填：否</para>
        /// <para>示例值：341244646234</para>
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
        /// <para>公司主体类型</para>
        /// <para>- 可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。查询参数：object_api_name=company；custom_api_name=subtype</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
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
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("primary_manager")]
        public I18n[]? PrimaryManagers { get; set; }

        /// <summary>
        /// <para>默认币种</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("currency")]
        public CurrencySuffix? Currency { get; set; }

        /// <summary>
        /// <para>默认币种</para>
        /// </summary>
        public record CurrencySuffix
        {
            /// <summary>
            /// <para>货币 ID</para>
            /// <para>- 调用[【查询货币信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)接口返回货币详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863329932261459464</para>
            /// </summary>
            [JsonPropertyName("currency_id")]
            public string? CurrencyId { get; set; }

            /// <summary>
            /// <para>货币所属国家/地区 ID 列表</para>
            /// <para>- 详细信息可通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口查询获得</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("country_region_id_list")]
            public string[]? CountryRegionIdList { get; set; }

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
                /// <para>语言信息，中文：zh-CN，英文en-US</para>
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
            /// <para>数字代码（ISO 4217），对应币种的指代代码，通过系统内部查找，通过[查询货币信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)查询获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：156</para>
            /// </summary>
            [JsonPropertyName("numeric_code")]
            public int? NumericCode { get; set; }

            /// <summary>
            /// <para>法定货币对应代码，如CNY、USD等，通过[查询货币信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search)查询获取。</para>
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
            /// <para>电话区号</para>
            /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code。</para>
            /// <para>必填：是</para>
            /// <para>示例值：123123</para>
            /// </summary>
            [JsonPropertyName("area_code")]
            public Enum AreaCode { get; set; } = new();

            /// <summary>
            /// <para>电话区号</para>
            /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code。</para>
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
                    /// <para>语言信息，中文：zh-CN，英文en-US</para>
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
        /// <para>完整注册地址</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("registered_office_address")]
        public I18n[]? RegisteredOfficeAddress { get; set; }

        /// <summary>
        /// <para>完整办公地址</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("office_address")]
        public I18n[]? OfficeAddress { get; set; }

        /// <summary>
        /// <para>注册地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("registered_office_address_info")]
        public Address? RegisteredOfficeAddressInfo { get; set; }

        /// <summary>
        /// <para>注册地址</para>
        /// </summary>
        public record Address
        {
            /// <summary>
            /// <para>完整地址（本地文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：中国北京北京</para>
            /// </summary>
            [JsonPropertyName("full_address_local_script")]
            public string? FullAddressLocalScript { get; set; }

            /// <summary>
            /// <para>完整地址（西方文字）</para>
            /// <para>必填：否</para>
            /// <para>示例值：Beijing, Beijing, China,</para>
            /// </summary>
            [JsonPropertyName("full_address_western_script")]
            public string? FullAddressWesternScript { get; set; }

            /// <summary>
            /// <para>地址 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6989822217869624863</para>
            /// </summary>
            [JsonPropertyName("address_id")]
            public string? AddressId { get; set; }

            /// <summary>
            /// <para>国家 / 地区 ID</para>
            /// <para>- 各国家/地区填写字段可参考[地址填写规则](https://bytedance.larkoffice.com/wiki/GoL4wAKAXis3OWku72YcEjTxnKe?sheet=0sMjoP)查询。可通过</para>
            /// <para>[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)查询获取。</para>
            /// <para>必填：是</para>
            /// <para>示例值：6862995757234914824</para>
            /// </summary>
            [JsonPropertyName("country_region_id")]
            public string CountryRegionId { get; set; } = string.Empty;

            /// <summary>
            /// <para>主要行政区 ID</para>
            /// <para>- 可通过[查询省份/主要行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)查询获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863326815667095047</para>
            /// </summary>
            [JsonPropertyName("region_id")]
            public string? RegionId { get; set; }

            /// <summary>
            /// <para>城市 ID</para>
            /// <para>- 调用[【查询城市信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)接口返回城市详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：6863333254578046471</para>
            /// </summary>
            [JsonPropertyName("city_id")]
            public string? CityId { get; set; }

            /// <summary>
            /// <para>区/县 ID</para>
            /// <para>- 调用[【查询区县信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-district/search)接口返回区县详细信息</para>
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

            /// <summary>
            /// <para>地址类型</para>
            /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=address；custom_api_name= address_type。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("address_type_list")]
            public Enum[] AddressTypeLists { get; set; } = [];

            /// <summary>
            /// <para>地址类型</para>
            /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=address；custom_api_name= address_type。</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>地址类型</para>
                /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=address；custom_api_name= address_type。</para>
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
                    /// <para>语言信息，中文：zh-CN，英文en-US</para>
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
            /// <para>主要地址</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_primary")]
            public bool IsPrimary { get; set; }

            /// <summary>
            /// <para>公开地址</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_public")]
            public bool IsPublic { get; set; }
        }

        /// <summary>
        /// <para>办公地址</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("office_address_info")]
        public Address? OfficeAddressInfo { get; set; }
    }
}
