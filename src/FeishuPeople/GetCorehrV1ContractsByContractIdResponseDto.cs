// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1ContractsByContractIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询单个合同 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单个合同 响应体
/// <para>该接口用于根据合同 ID 查询单个合同详细信息，包括合同开始日期、结束日期、公司主体等信息</para>
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
    [JsonPropertyName("contract")]
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
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>合同开始日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2050-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>实际结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：9999-12-31 23:59:59</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>雇佣 ID，详细信息可通过[【查询员工信息接口】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893013238632416776</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>合同类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同类型（contract_type）枚举定义部分获得</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("contract_type")]
        public Enum ContractType { get; set; } = new();

        /// <summary>
        /// <para>合同类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同类型（contract_type）枚举定义部分获得</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：internship_agreement</para>
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
                /// <para>名称信息的语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>名称信息的内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：实习协议</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>合同主体ID, 详细信息可通过[【查询公司详情接口】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/get)接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：6892686614112241165</para>
        /// </summary>
        [JsonPropertyName("first_party_company_id")]
        public string FirstPartyCompanyId { get; set; } = string.Empty;

        /// <summary>
        /// <para>Person ID，详细信息可通过接口文档[【批量查询员工信息接口】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：151515151</para>
        /// </summary>
        [JsonPropertyName("person_id")]
        public string? PersonId { get; set; }

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
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：Sandy</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>期限类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同期限类型（duration_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：fixed_term</para>
        /// </summary>
        [JsonPropertyName("duration_type")]
        public Enum? DurationType { get; set; }

        /// <summary>
        /// <para>合同结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2006-01-02</para>
        /// </summary>
        [JsonPropertyName("contract_end_date")]
        public string? ContractEndDate { get; set; }

        /// <summary>
        /// <para>合同编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：6919737965274990093</para>
        /// </summary>
        [JsonPropertyName("contract_number")]
        public string? ContractNumber { get; set; }

        /// <summary>
        /// <para>签订类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)签订类型（signing_type）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("signing_type")]
        public Enum? SigningType { get; set; }

        /// <summary>
        /// <para>合同协议状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同协议状态（contract_status）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contract_status")]
        public Enum? ContractStatus { get; set; }

        /// <summary>
        /// <para>续签状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)续签状态（renewal_status）枚举定义部分获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("renewal_status")]
        public Enum? RenewalStatus { get; set; }

        /// <summary>
        /// <para>第几次签署</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("signing_times")]
        public int? SigningTimes { get; set; }
    }
}
