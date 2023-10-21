using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单个合同 响应体
/// <para>根据 ID 查询单个合同。</para>
/// <para>接口ID：7017694651621883908</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/contract/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fget</para>
/// </summary>
public record GetCorehrV1ContractsByContractIdResponseDto
{
    /// <summary>
    /// <para>合同信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("contract")]
    public GetCorehrV1ContractsByContractIdResponseDtoContract? Contract { get; set; }

    /// <summary>
    /// <para>合同信息</para>
    /// </summary>
    public record GetCorehrV1ContractsByContractIdResponseDtoContract
    {
        /// <summary>
        /// <para>合同ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6919737965274990093</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>合同开始日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2050-01-0100:00:00</para>
        /// </summary>
        [JsonProperty("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>实际结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：9999-12-3123:59:59</para>
        /// </summary>
        [JsonProperty("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>雇员 ID，枚举值及详细信息可通过【批量查询雇佣信息】接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893013238632416776</para>
        /// </summary>
        [JsonProperty("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>合同类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同类型（contract_type）枚举定义部分获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("contract_type")]
        public Enum ContractType { get; set; } = new();

        /// <summary>
        /// <para>合同类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同类型（contract_type）枚举定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：type_1</para>
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
                /// <para>名称信息的语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonProperty("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称信息的内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>甲方, 引用Company的ID，枚举值及详细信息可通过【批量查询公司】接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：6892686614112241165</para>
        /// </summary>
        [JsonProperty("first_party_company_id")]
        public string FirstPartyCompanyId { get; set; } = string.Empty;

        /// <summary>
        /// <para>Person ID，枚举值及详细信息可通过【批量查询个人信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：151515151</para>
        /// </summary>
        [JsonProperty("person_id")]
        public string? PersonId { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_fields")]
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
            [JsonProperty("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>期限类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同期限类型（duration_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：fixed_term</para>
        /// </summary>
        [JsonProperty("duration_type")]
        public Enum? DurationType { get; set; }

        /// <summary>
        /// <para>合同结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2006-01-02</para>
        /// </summary>
        [JsonProperty("contract_end_date")]
        public string? ContractEndDate { get; set; }

        /// <summary>
        /// <para>合同编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：6919737965274990093</para>
        /// </summary>
        [JsonProperty("contract_number")]
        public string? ContractNumber { get; set; }

        /// <summary>
        /// <para>签订类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)签订类型（signing_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("signing_type")]
        public Enum? SigningType { get; set; }
    }
}
