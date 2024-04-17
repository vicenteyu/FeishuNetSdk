namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新公司 请求体
/// <para>更新公司信息。</para>
/// <para>接口ID：7309323790810824705</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcompany%2fpatch</para>
/// </summary>
public record PatchCorehrV1CompaniesByCompanyIdBodyDto
{
    /// <summary>
    /// <para>层级关系，内层字段见实体</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("hiberarchy_common")]
    public PatchCorehrV1CompaniesByCompanyIdBodyDtoHiberarchyCommon HiberarchyCommon { get; set; } = new();

    /// <summary>
    /// <para>层级关系，内层字段见实体</para>
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
            /// <para>语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容，支持中文和英文</para>
            /// <para>必填：是</para>
            /// <para>示例值：刘梓新</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public Enum? Type { get; set; }

        /// <summary>
        /// <para>组织类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)组织类型（organization_type）枚举定义部分获得</para>
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
        }

        /// <summary>
        /// <para>是否启用该公司</para>
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
    /// <para>性质，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)公司类型（company_type）枚举定义部分获得。该字段为通用字段，若为公司维度则为必填。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public Enum? Type { get; set; }

    /// <summary>
    /// <para>性质，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)公司类型（company_type）枚举定义部分获得。该字段为通用字段，若为公司维度则为必填。</para>
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
    }

    /// <summary>
    /// <para>行业，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)行业（industry）枚举定义部分获得</para>
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
        /// <para>语言，支持中文和英文。中文用zh-CN；英文用en-US。</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>内容，支持中文和英文。</para>
        /// <para>必填：是</para>
        /// <para>示例值：刘梓新</para>
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
    /// <para>confidential</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("confidential")]
    public bool? Confidential { get; set; }

    /// <summary>
    /// <para>主体类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)主体类型（company_sub_type）枚举定义部分获得</para>
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
        /// <para>[请求接口](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code。</para>
        /// <para>必填：是</para>
        /// <para>示例值：123123</para>
        /// </summary>
        [JsonPropertyName("area_code")]
        public Enum AreaCode { get; set; } = new();

        /// <summary>
        /// <para>区号对应的数字，可通过</para>
        /// <para>[请求接口](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=phone；custom_api_name=international_area_code。</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>区号对应名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
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
}
