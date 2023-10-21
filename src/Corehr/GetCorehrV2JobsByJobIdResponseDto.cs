using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询单个职务（V2） 响应体
/// <para>根据 ID 查询单个职务。</para>
/// <para>接口ID：7277403063272701954</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob%2fget</para>
/// </summary>
public record GetCorehrV2JobsByJobIdResponseDto
{
    /// <summary>
    /// <para>职务信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("job")]
    public GetCorehrV2JobsByJobIdResponseDtoJob? Job { get; set; }

    /// <summary>
    /// <para>职务信息</para>
    /// </summary>
    public record GetCorehrV2JobsByJobIdResponseDtoJob
    {
        /// <summary>
        /// <para>实体在CoreHR内部的唯一键</para>
        /// <para>必填：否</para>
        /// <para>示例值：4698040628992333549</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：JP422119</para>
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>名称</para>
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

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("description")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>职务头衔</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_title")]
        public I18n[]? JobTitles { get; set; }

        /// <summary>
        /// <para>序列</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_family_id_list")]
        public string[]? JobFamilyIdList { get; set; }

        /// <summary>
        /// <para>职级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_level_id_list")]
        public string[]? JobLevelIdList { get; set; }

        /// <summary>
        /// <para>工时制度，引用WorkingHoursType的ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonProperty("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>生效时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-01-0100:00:00</para>
        /// </summary>
        [JsonProperty("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-01-0100:00:00</para>
        /// </summary>
        [JsonProperty("expiration_time")]
        public string? ExpirationTime { get; set; }

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
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
            /// <para>必填：是</para>
            /// <para>示例值：Sandy</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }
    }
}
