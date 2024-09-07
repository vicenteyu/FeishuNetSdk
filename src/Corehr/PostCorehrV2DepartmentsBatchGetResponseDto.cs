// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门 响应体
/// <para>批量查询部门信息，**该接口只返回部门当前内容**。</para>
/// <para>接口ID：7280432392631549953</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fbatch_get</para>
/// </summary>
public record PostCorehrV2DepartmentsBatchGetResponseDto
{
    /// <summary>
    /// <para>查询的部门信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
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
            /// <para>语言信息，中文用zh-CN，英文用en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>部门名称内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>部门类型</para>
        /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sub_type")]
        public Enum? SubType { get; set; }

        /// <summary>
        /// <para>部门类型</para>
        /// <para>- 通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>部门类型名称</para>
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
                /// <para>语言编码（IETF BCP 47）</para>
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
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520111</para>
        /// </summary>
        [JsonPropertyName("parent_department_id")]
        public string? ParentDepartmentId { get; set; }

        /// <summary>
        /// <para>部门负责人雇佣 ID，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
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
        /// <para>必填：否</para>
        /// <para>示例值：001000</para>
        /// </summary>
        [JsonPropertyName("tree_order")]
        public string? TreeOrder { get; set; }

        /// <summary>
        /// <para>列表排序，代表所有部门的混排序号，为该部门上级路径上所有tree_order用“-”拼接</para>
        /// <para>- 该字段在新建/更新场景非立即更新，10分钟后会延迟更新</para>
        /// <para>- 由于list_order变更会导致[部门变更接口](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/updated)产生大量事件，因此事件接口不会针对该字段同步变更事件，如果有需求订阅请联系Oncall单独开启</para>
        /// <para>必填：否</para>
        /// <para>示例值：001000-001000</para>
        /// </summary>
        [JsonPropertyName("list_order")]
        public string? ListOrder { get; set; }

        /// <summary>
        /// <para>部门编码</para>
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
        /// <para>是否保密，该功能暂不支持，可以忽略</para>
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
        /// <para>部门启用状态，true为启用，false为停用</para>
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
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同。如：```("\"123\"", "\"123.23\"", "\"true\"", [\"id1\",\"id2\"], \"2006-01-02 15:04:05\")```</para>
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
        /// <para>该部门下成员的默认成本中心ID</para>
        /// <para>- 可通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)获取详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：7142384817131652652</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }
    }
}
