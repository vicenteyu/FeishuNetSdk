// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索部门信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索部门信息 响应体
/// <para>该接口支持通过部门id、上级部门ID、部门负责人、名称、编码字段批量搜索当天的部门详情信息，包括部门包含的名称、描述、启用状态等。</para>
/// <para>接口ID：7211423970042200068</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fsearch</para>
/// </summary>
public record PostCorehrV2DepartmentsSearchResponseDto : IPageableResponse<PostCorehrV2DepartmentsSearchResponseDto.Department>
{
    /// <summary>
    /// <para>查询的部门信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Department[]? Items { get; set; }

    /// <summary>
    /// <para>查询的部门信息</para>
    /// </summary>
    public record Department
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>部门记录版本 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372611</para>
        /// </summary>
        [JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_name")]
        public I18n[]? DepartmentNames { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言，中文用zh-CN，英文用en-US</para>
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
        /// <para>部门类型，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "department"</para>
        /// <para>- custom_api_name = "subtype"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sub_type")]
        public Enum? SubType { get; set; }

        /// <summary>
        /// <para>部门类型，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "department"</para>
        /// <para>- custom_api_name = "subtype"</para>
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
                /// <para>语言，中文用zh-CN，英文用en-US</para>
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
        /// <para>上级部门 ID</para>
        /// <para>- 可通过[批量查询部门V2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 或者[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search) 获取详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520111</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>部门负责人雇佣 ID</para>
        /// <para>- 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416777</para>
        /// </summary>
        [JsonPropertyName("manager")]
        public string? Manager { get; set; }

        /// <summary>
        /// <para>树形排序，代表同层级的部门排序序号</para>
        /// <para>- 创建部门场景tree_order不会实时生成，10分钟内更新完毕</para>
        /// <para>- 在页面拖动部门排序时tree_order可以实时生成</para>
        /// <para>- 变更部门上级时，会清空tree_order，并触发重算list_order和tree_order，10分钟内更新完毕</para>
        /// <para>- 同层部门（相同上级）数量超过1000时，该字段不再更新</para>
        /// <para>必填：否</para>
        /// <para>示例值：001000</para>
        /// </summary>
        [JsonPropertyName("tree_order")]
        public string? TreeOrder { get; set; }

        /// <summary>
        /// <para>列表排序，代表所有部门的混排序号，为该部门上级路径上所有tree_order用“-”拼接。</para>
        /// <para>- 该字段在新建/更新场景非立即更新，10分钟后会延迟更新</para>
        /// <para>- 由于list_order变更会导致[部门变更接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/updated)产生大量事件，因此事件接口不会针对该字段同步变更事件，如果有需求订阅请联系[Oncall](https://applink.feishu.cn/TLJpeNdW)单独开启。</para>
        /// <para>- 同层部门（相同上级）数量超过1000时，该字段不再更新</para>
        /// <para>必填：否</para>
        /// <para>示例值：001000-001000</para>
        /// </summary>
        [JsonPropertyName("list_order")]
        public string? ListOrder { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：D00000456</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>是否根部门</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_root")]
        public bool IsRoot { get; set; }

        /// <summary>
        /// <para>是否保密（该功能暂不支持，可忽略）</para>
        /// <para>必填：是</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_confidential")]
        public bool IsConfidential { get; set; }

        /// <summary>
        /// <para>当前版本生效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01～9999-12-31</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>当前版本失效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01～9999-12-31</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-02</para>
        /// </summary>
        [JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段类型，详细见[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)</para>
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
        /// <para>岗职管理模式</para>
        /// <para>- 详细枚举类型请查看[枚举场景](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)中关于staffing_model定义</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("staffing_model")]
        public Enum? StaffingModel { get; set; }

        /// <summary>
        /// <para>成本中心id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7142384817131652652</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-02 00:00:00</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416777</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// <para>更新人</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416777</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// <para>记录创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("record_created_time")]
        public string? RecordCreatedTime { get; set; }

        /// <summary>
        /// <para>记录更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-02 00:00:00</para>
        /// </summary>
        [JsonPropertyName("record_updated_time")]
        public string? RecordUpdatedTime { get; set; }

        /// <summary>
        /// <para>记录创建人</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416777</para>
        /// </summary>
        [JsonPropertyName("record_created_by")]
        public string? RecordCreatedBy { get; set; }

        /// <summary>
        /// <para>记录更新人</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893013238632416777</para>
        /// </summary>
        [JsonPropertyName("record_updated_by")]
        public string? RecordUpdatedBy { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJldV9uYyI6IlswLFwiNjk2MTI4Njg0NjA5Mzc4ODY4MC03MjExMDM0ODcxMjA3OTUzOTc1XCJdIn0</para>
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
