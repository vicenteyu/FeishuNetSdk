// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1WorkingHoursTypesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建工时制度 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建工时制度 响应体
/// <para>创建工时制度。</para>
/// <para>接口ID：7072647640912117762</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/working_hours_type/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fworking_hours_type%2fcreate</para>
/// </summary>
public record PostCorehrV1WorkingHoursTypesResponseDto
{
    /// <summary>
    /// <para>工时制度</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("working_hours_type")]
    public PostCorehrV1WorkingHoursTypesResponseDtoWorkingHoursType? WorkingHoursType { get; set; }

    /// <summary>
    /// <para>工时制度</para>
    /// </summary>
    public record PostCorehrV1WorkingHoursTypesResponseDtoWorkingHoursType
    {
        /// <summary>
        /// <para>工时制度 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = [];

        /// <summary>
        /// <para>名称</para>
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
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>国家/地区 ID 列表</para>
        /// <para>- 可通过[查询国家/地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：创建成功的工时制度信息</para>
        /// </summary>
        [JsonPropertyName("country_region_id_list")]
        public string[]? CountryRegionIdList { get; set; }

        /// <summary>
        /// <para>职务默认值</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("default_for_job")]
        public bool DefaultForJob { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>- 具体支持的对象请参考[自定义字段说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>- 具体支持的对象请参考[自定义字段说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
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
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }
}
