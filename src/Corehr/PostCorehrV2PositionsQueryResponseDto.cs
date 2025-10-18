// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCorehrV2PositionsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询岗位信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询岗位信息 响应体
/// <para>支持通过岗位 ID、部门 ID 查询岗位的详细信息，例如岗位关联的职务、职级、序列，以及岗位描述，是否关键岗位等</para>
/// <para>接口ID：7384280065851064321</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fquery</para>
/// </summary>
public record PostCorehrV2PositionsQueryResponseDto : IPageableResponse<PostCorehrV2PositionsQueryResponseDto.Position>
{
    /// <summary>
    /// <para>岗位信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Position[]? Items { get; set; }

    /// <summary>
    /// <para>岗位信息列表</para>
    /// </summary>
    public record Position
    {
        /// <summary>
        /// <para>岗位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4692446793125560154</para>
        /// </summary>
        [JsonPropertyName("position_id")]
        public string? PositionId { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：A01234</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("names")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>名称</para>
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
            /// <para>示例值：高级产品经理</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("descriptions")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>状态，true表示启用，false表示停用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>序列 ID 列表，详细信息可通过[查询单个序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)接口获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_family_id_list")]
        public string[]? JobFamilyIdList { get; set; }

        /// <summary>
        /// <para>成本中心 ID，可以通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取对应的成本中心信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

        /// <summary>
        /// <para>职务，可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096302</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职级 ID 列表，可通过[【查询单个职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_level_id_list")]
        public string[]? JobLevelIdList { get; set; }

        /// <summary>
        /// <para>人员类型 ID 列表，可通过文档[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)获得详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee_type_id_list")]
        public string[]? EmployeeTypeIdList { get; set; }

        /// <summary>
        /// <para>职等 ID 列表，可通过 [【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_grade_id_list")]
        public string[]? JobGradeIdList { get; set; }

        /// <summary>
        /// <para>工作地点 ID 列表，详细信息可通过[查询单个地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)接口获得</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_location_id_list")]
        public string[]? WorkLocationIdList { get; set; }

        /// <summary>
        /// <para>工时制度 ID 列表，可通过[【查询单个工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)查询详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>部门 ID，详细信息可通过[查询单个部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)接口获得</para>
        /// <para>- 类型与 department_id_type 一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>直属上级岗位 ID，可通过本接口查询详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("direct_leader_id")]
        public string? DirectLeaderId { get; set; }

        /// <summary>
        /// <para>虚线上级岗位 ID，可通过本接口查询详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("dotted_line_leader_id")]
        public string? DottedLineLeaderId { get; set; }

        /// <summary>
        /// <para>是否关键岗位</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_key_position")]
        public bool? IsKeyPosition { get; set; }

        /// <summary>
        /// <para>生效日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string ExpirationTime { get; set; } = string.Empty;

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
            /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
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

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
