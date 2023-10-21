using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新待入职信息 响应体
/// <para>更新待入职信息。</para>
/// <para>接口ID：7072977543561461762</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fpre_hire%2fpatch</para>
/// </summary>
public record PatchCorehrV1PreHiresByPreHireIdResponseDto
{
    /// <summary>
    /// <para>待入职数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("pre_hire")]
    public PatchCorehrV1PreHiresByPreHireIdResponseDtoPreHire? PreHire { get; set; }

    /// <summary>
    /// <para>待入职数据</para>
    /// </summary>
    public record PatchCorehrV1PreHiresByPreHireIdResponseDtoPreHire
    {
        /// <summary>
        /// <para>招聘投递 ID ，详细信息可以通过招聘的【获取投递信息】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719168654814483759</para>
        /// </summary>
        [JsonProperty("ats_application_id")]
        public string? AtsApplicationId { get; set; }

        /// <summary>
        /// <para>待入职ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：154545454</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>入职日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-01-01</para>
        /// </summary>
        [JsonProperty("hire_date")]
        public string? HireDate { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("employee_type")]
        public Enum EmployeeType { get; set; } = new();

        /// <summary>
        /// <para>雇佣类型</para>
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
                /// <para>示例值：刘梓新</para>
                /// </summary>
                [JsonProperty("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>人员编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：1245646</para>
        /// </summary>
        [JsonProperty("worker_id")]
        public string? WorkerId { get; set; }

        /// <summary>
        /// <para>雇佣类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：正式</para>
        /// </summary>
        [JsonProperty("employee_type_id")]
        public string EmployeeTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>引用Person ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：656464648662</para>
        /// </summary>
        [JsonProperty("person_id")]
        public string PersonId { get; set; } = string.Empty;

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
        /// <para>成本中心分摊信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("cost_center_rate")]
        public SupportCostCenterItem[]? CostCenterRates { get; set; }

        /// <summary>
        /// <para>成本中心分摊信息</para>
        /// </summary>
        public record SupportCostCenterItem
        {
            /// <summary>
            /// <para>支持的成本中心id</para>
            /// <para>必填：否</para>
            /// <para>示例值：6950635856373745165</para>
            /// </summary>
            [JsonProperty("cost_center_id")]
            public string? CostCenterId { get; set; }

            /// <summary>
            /// <para>分摊比例</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonProperty("rate")]
            public int? Rate { get; set; }
        }

        /// <summary>
        /// <para>入职状态</para>
        /// <para>- 待入职(preboarding)</para>
        /// <para>- 已删除(deleted)</para>
        /// <para>- 准备就绪(day_one)</para>
        /// <para>- 已撤销(withdrawn)</para>
        /// <para>- 已完成(completed)</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("onboarding_status")]
        public Enum OnboardingStatus { get; set; } = new();
    }
}
