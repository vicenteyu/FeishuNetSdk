// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCorehrV2JobsBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据条件批量获取职务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 根据条件批量获取职务 响应体
/// <para>根据传入的职务ID或职务Code批量获取当前生效版本职务信息。</para>
/// <para>接口ID：7525709902931836932</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fbatch_get</para>
/// </summary>
public record PostCorehrV2JobsBatchGetResponseDto
{
    /// <summary>
    /// <para>查询的职务信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Job[]? Items { get; set; }

    /// <summary>
    /// <para>查询的职务信息</para>
    /// </summary>
    public record Job
    {
        /// <summary>
        /// <para>职务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4698040628992333549</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：JP422119</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

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
            /// <para>语言信息，中文用zh-CN，英文用en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：高级 Java 开发工程师</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>启用状态，true为启用，false为停用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>职务头衔</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_title")]
        public I18n[]? JobTitles { get; set; }

        /// <summary>
        /// <para>通道ID，详情可以参考[【获取通道信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// <para>关联的序列ID列表</para>
        /// <para>- 可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_family/batch_get)获取详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_family_id_list")]
        public string[]? JobFamilyIdList { get; set; }

        /// <summary>
        /// <para>关联的职级ID列表</para>
        /// <para>- 可通过[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_level/batch_get)获取详情</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_level_id_list")]
        public string[]? JobLevelIdList { get; set; }

        /// <summary>
        /// <para>工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>当前版本生效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>当前版本失效日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>自定义字段，格式参考：[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)岗位、职务、自定义组织模块</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段，格式参考：[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)岗位、职务、自定义组织模块</para>
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
        /// <para>创建人，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719519211875096301</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// <para>当前版本创建日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新人，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search) 或 [【批量查询员工】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：2415132452875096301</para>
        /// </summary>
        [JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// <para>当前版本更新日期</para>
        /// <para>- 返回格式：YYYY-MM-DD 00:00:00（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 00:00:00～9999-12-31 00:00:00</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-01-01 00:00:00</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }
    }
}
