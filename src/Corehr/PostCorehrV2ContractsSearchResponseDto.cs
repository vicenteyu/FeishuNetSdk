using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索合同 响应体
/// <para>搜索合同信息</para>
/// <para>接口ID：7248868628551303172</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/contract/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcontract%2fsearch</para>
/// </summary>
public record PostCorehrV2ContractsSearchResponseDto
{
    /// <summary>
    /// <para>查询的合同信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Contract[]? Items { get; set; }

    /// <summary>
    /// <para>查询的合同信息</para>
    /// </summary>
    public record Contract
    {
        /// <summary>
        /// <para>合同ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7147527056140813828</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>合同开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-01-0100:00:00</para>
        /// </summary>
        [JsonProperty("effective_time")]
        public string? EffectiveTime { get; set; }

        /// <summary>
        /// <para>合同结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-01-01</para>
        /// </summary>
        [JsonProperty("contract_end_date")]
        public string? ContractEndDate { get; set; }

        /// <summary>
        /// <para>实际结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2023-11-0100:00:00</para>
        /// </summary>
        [JsonProperty("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>雇佣 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonProperty("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>合同类型，枚举值可通过文档【飞书人事枚举常量】合同类型（contract_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("contract_type")]
        public Enum? ContractType { get; set; }

        /// <summary>
        /// <para>合同类型，枚举值可通过文档【飞书人事枚举常量】合同类型（contract_type）枚举定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
            /// </summary>
            [JsonProperty("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("display")]
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
                [JsonProperty("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>合同主体, 引用 Company 的 ID，枚举值及详细信息可通过【批量查询公司】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：7091599096804394540</para>
        /// </summary>
        [JsonProperty("first_party_company_id")]
        public string? FirstPartyCompanyId { get; set; }

        /// <summary>
        /// <para>Person ID，枚举值及详细信息可通过【批量查询个人信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：7088589447189022252</para>
        /// </summary>
        [JsonProperty("person_id")]
        public string? PersonId { get; set; }

        /// <summary>
        /// <para>期限类型，枚举值可通过文档【飞书人事枚举常量】合同期限类型（duration_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("duration_type")]
        public Enum? DurationType { get; set; }

        /// <summary>
        /// <para>合同编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：0000011</para>
        /// </summary>
        [JsonProperty("contract_number")]
        public string? ContractNumber { get; set; }

        /// <summary>
        /// <para>签订类型，枚举值可通过文档【飞书人事枚举常量】签订类型（signing_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("signing_type")]
        public Enum? SigningType { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
