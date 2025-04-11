// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-09
//
// Last Modified By : yxr
// Last Modified On : 2024-09-09
// ************************************************************************
// <copyright file="PatchCorehrV2DepartmentsByDepartmentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 更新部门 请求体
/// <para>更新部门，支持数据行权限判权</para>
/// <para>接口ID：7362022982037307395</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fpatch</para>
/// </summary>
public record PatchCorehrV2DepartmentsByDepartmentIdBodyDto
{
    /// <summary>
    /// <para>该字段暂时无效，可忽略</para>
    /// <para>必填：否</para>
    /// <para>示例值：4719456877659520852</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>部门类型，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sub_type")]
    public Enum? SubType { get; set; }

    /// <summary>
    /// <para>部门类型，通过[获取字段详情](https://open.larkoffice.com/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param)查询获取。请求参数：object_api_name=department；custom_api_name=subtype。</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：department</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>部门负责人 ID</para>
    /// <para>详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get) 接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6893013238632416776</para>
    /// </summary>
    [JsonPropertyName("manager")]
    public string? Manager { get; set; }

    /// <summary>
    /// <para>是否保密（该字段暂不支持，可忽略）</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_confidential")]
    public bool? IsConfidential { get; set; }

    /// <summary>
    /// <para>组织实体公共字段，包括名称、描述、上级、启停用状态、生效日期、编码等基础信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("hiberarchy_common")]
    public PatchCorehrV2DepartmentsByDepartmentIdBodyDtoHiberarchyCommon? HiberarchyCommon { get; set; }

    /// <summary>
    /// <para>组织实体公共字段，包括名称、描述、上级、启停用状态、生效日期、编码等基础信息</para>
    /// </summary>
    public record PatchCorehrV2DepartmentsByDepartmentIdBodyDtoHiberarchyCommon
    {
        /// <summary>
        /// <para>上级组织</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719168654814483759</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// <para>- 名称不能包含「/」「；」「;」字符。</para>
        /// <para>- 中英文名称会有重名校验规则（依赖租户配置规则）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>部门名称</para>
        /// <para>- 名称不能包含「/」「；」「;」字符。</para>
        /// <para>- 中英文名称会有重名校验规则（依赖租户配置规则）</para>
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
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>部门启用状态，true为启用，false为停用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>部门编码 (不能与其他记录的编码重复)，当开启自动编码时，该字段会失效</para>
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
    /// <para>自定义字段，枚举值可通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段，枚举值可通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)获取</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，为 JSON 转义后的字符串。</para>
        /// <para>**注意：具体传值方式参见**[获取自定义字段的元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// <para>必填：是</para>
        /// <para>示例值：Sandy</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>成本中心 ID，可以通过[搜索成本中心信息](https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/cost_center/search)接口获取对应的成本中心信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：7142384817131652652</para>
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public string? CostCenterId { get; set; }

    /// <summary>
    /// <para>岗职管理模式</para>
    /// <para>- 详细枚举类型请查看[枚举场景](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)中关于staffing_model定义</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("staffing_model")]
    public Enum? StaffingModel { get; set; }
}
