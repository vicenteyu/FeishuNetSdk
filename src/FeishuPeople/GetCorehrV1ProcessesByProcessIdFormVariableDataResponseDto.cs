namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取流程表单数据 响应体
/// <para>根据流程实例 id（process_id）获取流程表单字段数据，包括表单里的业务字段和自定义字段。仅支持飞书人事、假勤相关业务流程。</para>
/// <para>接口ID：7160631114605608962</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/process-form_variable_data/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fprocess-form_variable_data%2fget</para>
/// </summary>
public record GetCorehrV1ProcessesByProcessIdFormVariableDataResponseDto
{
    /// <summary>
    /// <para>流程变量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_variable_values")]
    public FormFieldVariable[]? FieldVariableValues { get; set; }

    /// <summary>
    /// <para>流程变量</para>
    /// </summary>
    public record FormFieldVariable
    {
        /// <summary>
        /// <para>变量api名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：reason</para>
        /// </summary>
        [JsonPropertyName("variable_api_name")]
        public string? VariableApiName { get; set; }

        /// <summary>
        /// <para>变量名称的i18n描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("variable_name")]
        public BpmDataengineI18n? VariableName { get; set; }

        /// <summary>
        /// <para>变量名称的i18n描述</para>
        /// </summary>
        public record BpmDataengineI18n
        {
            /// <summary>
            /// <para>i18n类型字段，中文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：离职原因</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>i18n类型字段，英文值</para>
            /// <para>必填：否</para>
            /// <para>示例值：Reason</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>变量值的对象</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("variable_value")]
        public FormVariableValueInfo? VariableValue { get; set; }

        /// <summary>
        /// <para>变量值的对象</para>
        /// </summary>
        public record FormVariableValueInfo
        {
            /// <summary>
            /// <para>文本变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_value")]
            public FormFieldVariableTextValue? TextValue { get; set; }

            /// <summary>
            /// <para>文本变量对象</para>
            /// </summary>
            public record FormFieldVariableTextValue
            {
                /// <summary>
                /// <para>文本类型变量的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：文本</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>数值变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("number_value")]
            public FormFieldVariableNumberValue? NumberValue { get; set; }

            /// <summary>
            /// <para>数值变量对象</para>
            /// </summary>
            public record FormFieldVariableNumberValue
            {
                /// <summary>
                /// <para>数值类型变量的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>日期变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("date_value")]
            public FormFieldVariableDateValue? DateValue { get; set; }

            /// <summary>
            /// <para>日期变量对象</para>
            /// </summary>
            public record FormFieldVariableDateValue
            {
                /// <summary>
                /// <para>日期变量的值，从1970起的天数</para>
                /// <para>必填：否</para>
                /// <para>示例值：10000</para>
                /// </summary>
                [JsonPropertyName("value")]
                public int? Value { get; set; }
            }

            /// <summary>
            /// <para>员工变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("employment_value")]
            public FormFieldVariableEmploymentValue? EmploymentValue { get; set; }

            /// <summary>
            /// <para>员工变量对象</para>
            /// </summary>
            public record FormFieldVariableEmploymentValue
            {
                /// <summary>
                /// <para>employmentID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6893014062142064134</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }

                /// <summary>
                /// <para>员工ID 如3158117</para>
                /// <para>必填：否</para>
                /// <para>示例值：3158117</para>
                /// </summary>
                [JsonPropertyName("user_id")]
                public string? UserId { get; set; }
            }

            /// <summary>
            /// <para>日期时间变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("date_time_value")]
            public FormFieldVariableDatetimeValue? DateTimeValue { get; set; }

            /// <summary>
            /// <para>日期时间变量对象</para>
            /// </summary>
            public record FormFieldVariableDatetimeValue
            {
                /// <summary>
                /// <para>毫秒的时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1670227428803</para>
                /// </summary>
                [JsonPropertyName("value")]
                public int? Value { get; set; }

                /// <summary>
                /// <para>时区</para>
                /// <para>必填：否</para>
                /// <para>示例值：+08:00</para>
                /// </summary>
                [JsonPropertyName("zone")]
                public string? Zone { get; set; }
            }

            /// <summary>
            /// <para>枚举变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_value")]
            public FormFieldVariableEnumValue? EnumValue { get; set; }

            /// <summary>
            /// <para>枚举变量对象</para>
            /// </summary>
            public record FormFieldVariableEnumValue
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：否</para>
                /// <para>示例值：enum_value</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }

                /// <summary>
                /// <para>枚举的名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public BpmDataengineI18n? Name { get; set; }

                /// <summary>
                /// <para>枚举的名称</para>
                /// </summary>
                public record BpmDataengineI18n
                {
                    /// <summary>
                    /// <para>i18n类型字段，中文值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中文</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>i18n类型字段，英文值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：English</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }

                /// <summary>
                /// <para>枚举的描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("desc")]
                public BpmDataengineI18n? Desc { get; set; }
            }

            /// <summary>
            /// <para>空变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("null_value")]
            public object? NullValue { get; set; }

            /// <summary>
            /// <para>布尔变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("bool_value")]
            public FormFieldVariableBoolValue? BoolValue { get; set; }

            /// <summary>
            /// <para>布尔变量对象</para>
            /// </summary>
            public record FormFieldVariableBoolValue
            {
                /// <summary>
                /// <para>布尔变量的值</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("value")]
                public bool? Value { get; set; }
            }

            /// <summary>
            /// <para>部门变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_value")]
            public FormFieldVariableDepartmentValue? DepartmentValue { get; set; }

            /// <summary>
            /// <para>部门变量对象</para>
            /// </summary>
            public record FormFieldVariableDepartmentValue
            {
                /// <summary>
                /// <para>部门ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：201933311</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }

            /// <summary>
            /// <para>文件变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("file_value")]
            public FormFieldVariableFileValue? FileValue { get; set; }

            /// <summary>
            /// <para>文件变量对象</para>
            /// </summary>
            public record FormFieldVariableFileValue
            {
                /// <summary>
                /// <para>文件源类型（1BPM; 2主数据）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("source_type")]
                public int? SourceType { get; set; }

                /// <summary>
                /// <para>文件id</para>
                /// <para>必填：否</para>
                /// <para>示例值：abc_file_xyz</para>
                /// </summary>
                [JsonPropertyName("file_id")]
                public string? FileId { get; set; }

                /// <summary>
                /// <para>文件名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：a</para>
                /// </summary>
                [JsonPropertyName("file_name")]
                public string? FileName { get; set; }

                /// <summary>
                /// <para>文件长度</para>
                /// <para>必填：否</para>
                /// <para>示例值：1024</para>
                /// </summary>
                [JsonPropertyName("length")]
                public int? Length { get; set; }

                /// <summary>
                /// <para>mime type</para>
                /// <para>必填：否</para>
                /// <para>示例值：text/plain</para>
                /// </summary>
                [JsonPropertyName("mime_type")]
                public string? MimeType { get; set; }
            }

            /// <summary>
            /// <para>i18n变量对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("i18n_value")]
            public FormFieldVariableI18nValue? I18nValue { get; set; }

            /// <summary>
            /// <para>i18n变量对象</para>
            /// </summary>
            public record FormFieldVariableI18nValue
            {
                /// <summary>
                /// <para>i18n值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("value")]
                public BpmDataengineI18n? Value { get; set; }

                /// <summary>
                /// <para>i18n值</para>
                /// </summary>
                public record BpmDataengineI18n
                {
                    /// <summary>
                    /// <para>i18n类型字段，中文值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("zh_cn")]
                    public string? ZhCn { get; set; }

                    /// <summary>
                    /// <para>i18n类型字段，英文值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("en_us")]
                    public string? EnUs { get; set; }
                }
            }

            /// <summary>
            /// <para>对象变量</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("object_value")]
            public FormFieldVariableObjectValue? ObjectValue { get; set; }

            /// <summary>
            /// <para>对象变量</para>
            /// </summary>
            public record FormFieldVariableObjectValue
            {
                /// <summary>
                /// <para>对象ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：203948191</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }

                /// <summary>
                /// <para>主数据apiName</para>
                /// <para>必填：否</para>
                /// <para>示例值：object1</para>
                /// </summary>
                [JsonPropertyName("wk_api_name")]
                public string? WkApiName { get; set; }
            }

            /// <summary>
            /// <para>列表对象</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("list_value")]
            public FormFieldVariableListValue? ListValue { get; set; }

            /// <summary>
            /// <para>列表对象</para>
            /// </summary>
            public record FormFieldVariableListValue
            {
                /// <summary>
                /// <para>列表值</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("values")]
                public FormFieldVariableListObject[]? Values { get; set; }

                /// <summary>
                /// <para>列表值</para>
                /// </summary>
                public record FormFieldVariableListObject
                {
                    /// <summary>
                    /// <para>文本变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_value")]
                    public FormFieldVariableTextValue? TextValue { get; set; }

                    /// <summary>
                    /// <para>文本变量对象</para>
                    /// </summary>
                    public record FormFieldVariableTextValue
                    {
                        /// <summary>
                        /// <para>文本类型变量的值</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：文本</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }
                    }

                    /// <summary>
                    /// <para>数值变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("number_value")]
                    public FormFieldVariableNumberValue? NumberValue { get; set; }

                    /// <summary>
                    /// <para>数值变量对象</para>
                    /// </summary>
                    public record FormFieldVariableNumberValue
                    {
                        /// <summary>
                        /// <para>数值类型变量的值</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }
                    }

                    /// <summary>
                    /// <para>日期变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("date_value")]
                    public FormFieldVariableDateValue? DateValue { get; set; }

                    /// <summary>
                    /// <para>日期变量对象</para>
                    /// </summary>
                    public record FormFieldVariableDateValue
                    {
                        /// <summary>
                        /// <para>日期变量的值，从1970起的天数</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：10000</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public int? Value { get; set; }
                    }

                    /// <summary>
                    /// <para>员工变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("employment_value")]
                    public FormFieldVariableEmploymentValue? EmploymentValue { get; set; }

                    /// <summary>
                    /// <para>员工变量对象</para>
                    /// </summary>
                    public record FormFieldVariableEmploymentValue
                    {
                        /// <summary>
                        /// <para>employmentID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：6893014062142064134</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }

                        /// <summary>
                        /// <para>员工ID 如3158117</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：3158117</para>
                        /// </summary>
                        [JsonPropertyName("user_id")]
                        public string? UserId { get; set; }
                    }

                    /// <summary>
                    /// <para>日期时间变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("date_time_value")]
                    public FormFieldVariableDatetimeValue? DateTimeValue { get; set; }

                    /// <summary>
                    /// <para>日期时间变量对象</para>
                    /// </summary>
                    public record FormFieldVariableDatetimeValue
                    {
                        /// <summary>
                        /// <para>毫秒的时间戳</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1670227428803</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public int? Value { get; set; }

                        /// <summary>
                        /// <para>时区</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：+08:00</para>
                        /// </summary>
                        [JsonPropertyName("zone")]
                        public string? Zone { get; set; }
                    }

                    /// <summary>
                    /// <para>枚举变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("enum_value")]
                    public FormFieldVariableEnumValue? EnumValue { get; set; }

                    /// <summary>
                    /// <para>枚举变量对象</para>
                    /// </summary>
                    public record FormFieldVariableEnumValue
                    {
                        /// <summary>
                        /// <para>枚举值</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：enum_value</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }

                        /// <summary>
                        /// <para>枚举的名称</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("name")]
                        public BpmDataengineI18n? Name { get; set; }

                        /// <summary>
                        /// <para>枚举的名称</para>
                        /// </summary>
                        public record BpmDataengineI18n
                        {
                            /// <summary>
                            /// <para>i18n类型字段，中文值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：张三</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>i18n类型字段，英文值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：zh-CN</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }

                        /// <summary>
                        /// <para>枚举的描述</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("desc")]
                        public BpmDataengineI18n? Desc { get; set; }
                    }

                    /// <summary>
                    /// <para>空变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("null_value")]
                    public object? NullValue { get; set; }

                    /// <summary>
                    /// <para>布尔变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("bool_value")]
                    public FormFieldVariableBoolValue? BoolValue { get; set; }

                    /// <summary>
                    /// <para>布尔变量对象</para>
                    /// </summary>
                    public record FormFieldVariableBoolValue
                    {
                        /// <summary>
                        /// <para>布尔变量的值</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public bool? Value { get; set; }
                    }

                    /// <summary>
                    /// <para>部门变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("department_value")]
                    public FormFieldVariableDepartmentValue? DepartmentValue { get; set; }

                    /// <summary>
                    /// <para>部门变量对象</para>
                    /// </summary>
                    public record FormFieldVariableDepartmentValue
                    {
                        /// <summary>
                        /// <para>部门ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：201933311</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }
                    }

                    /// <summary>
                    /// <para>文件变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("file_value")]
                    public FormFieldVariableFileValue? FileValue { get; set; }

                    /// <summary>
                    /// <para>文件变量对象</para>
                    /// </summary>
                    public record FormFieldVariableFileValue
                    {
                        /// <summary>
                        /// <para>文件源类型（1BPM; 2主数据）</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// </summary>
                        [JsonPropertyName("source_type")]
                        public int? SourceType { get; set; }

                        /// <summary>
                        /// <para>文件id</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：abc_file_xyz</para>
                        /// </summary>
                        [JsonPropertyName("file_id")]
                        public string? FileId { get; set; }

                        /// <summary>
                        /// <para>文件名称</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：a</para>
                        /// </summary>
                        [JsonPropertyName("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// <para>文件长度</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1024</para>
                        /// </summary>
                        [JsonPropertyName("length")]
                        public int? Length { get; set; }

                        /// <summary>
                        /// <para>mime type</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：text/plain</para>
                        /// </summary>
                        [JsonPropertyName("mime_type")]
                        public string? MimeType { get; set; }
                    }

                    /// <summary>
                    /// <para>i18n变量对象</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("i18n_value")]
                    public FormFieldVariableI18nValue? I18nValue { get; set; }

                    /// <summary>
                    /// <para>i18n变量对象</para>
                    /// </summary>
                    public record FormFieldVariableI18nValue
                    {
                        /// <summary>
                        /// <para>i18n值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public BpmDataengineI18n? Value { get; set; }

                        /// <summary>
                        /// <para>i18n值</para>
                        /// </summary>
                        public record BpmDataengineI18n
                        {
                            /// <summary>
                            /// <para>i18n类型字段，中文值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：中文</para>
                            /// </summary>
                            [JsonPropertyName("zh_cn")]
                            public string? ZhCn { get; set; }

                            /// <summary>
                            /// <para>i18n类型字段，英文值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：English</para>
                            /// </summary>
                            [JsonPropertyName("en_us")]
                            public string? EnUs { get; set; }
                        }
                    }

                    /// <summary>
                    /// <para>对象变量</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("object_value")]
                    public FormFieldVariableObjectValue? ObjectValue { get; set; }

                    /// <summary>
                    /// <para>对象变量</para>
                    /// </summary>
                    public record FormFieldVariableObjectValue
                    {
                        /// <summary>
                        /// <para>对象ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：203948191</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }

                        /// <summary>
                        /// <para>主数据apiName</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：object1</para>
                        /// </summary>
                        [JsonPropertyName("wk_api_name")]
                        public string? WkApiName { get; set; }
                    }
                }
            }
        }
    }
}
