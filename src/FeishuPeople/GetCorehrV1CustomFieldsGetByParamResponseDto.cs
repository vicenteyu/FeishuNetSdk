namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取字段详情 响应体
/// <para>获取「飞书人事」对象下某字段的详细信息,支持系统预置字段和自定义字段。通常可通过该接口获取某个对象中字段的枚举值列表。使用方式可参考[【操作手册】如何通过 OpenAPI 维护自定义字段](https://feishu.feishu.cn/docx/QlUudBfCtosWMbxx3vxcOFDknn7)</para>
/// <para>接口ID：7112009113388138524</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/get_by_param</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcustom_field%2fget_by_param</para>
/// </summary>
public record GetCorehrV1CustomFieldsGetByParamResponseDto
{
    /// <summary>
    /// <para>字段详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("data")]
    public CustomField? Data { get; set; }

    /// <summary>
    /// <para>字段详情</para>
    /// </summary>
    public record CustomField
    {
        /// <summary>
        /// <para>字段 apiname，即字段的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom_field_33</para>
        /// </summary>
        [JsonPropertyName("custom_api_name")]
        public string? CustomApiName { get; set; }

        /// <summary>
        /// <para>字段名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public CustomFieldName Name { get; set; } = new();

        /// <summary>
        /// <para>字段名称</para>
        /// </summary>
        public record CustomFieldName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("description")]
        public NameSuffix Description { get; set; } = new();

        /// <summary>
        /// <para>描述</para>
        /// </summary>
        public record NameSuffix
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_open")]
        public bool IsOpen { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// <para>是否唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_unique")]
        public bool IsUnique { get; set; }

        /// <summary>
        /// <para>所属对象 apiname</para>
        /// <para>必填：是</para>
        /// <para>示例值：offboarding_info</para>
        /// </summary>
        [JsonPropertyName("object_api_name")]
        public string ObjectApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段类型</para>
        /// <para>**可选值有：**</para>
        /// <para>- `1`：文本 Text，“文本”和“超链接”属于该类型</para>
        /// <para>- `2`：布尔 Boolean</para>
        /// <para>- `3`：数字 Number</para>
        /// <para>- `4`：枚举 Option，“单选”和“多选”属于该类型</para>
        /// <para>- `5`：查找 Lookup，“人员（单选）”、“人员（多选）”和个人信息中的自定义分组属于该类型</para>
        /// <para>- `6`：自动编号 AutoNumber</para>
        /// <para>- `7`：日期时间 Date time</para>
        /// <para>- `8`：附件 Attachment，“附件单选”和“附件多选”属于该类型</para>
        /// <para>- `9`：图片 Image</para>
        /// <para>- `10`：计算字段 Calculated</para>
        /// <para>- `11`：反向查找 BackLookup</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// <para>配置信息，当前仅字段类型为「文本」、「布尔」、「数字」、「枚举」、「日期时间」、「附件」、「图片」时返回具体的配置信息，其余类型的自定义字段暂不返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("common_schema_config")]
        public CustomFieldCommonSchemaConfig? CommonSchemaConfig { get; set; }

        /// <summary>
        /// <para>配置信息，当前仅字段类型为「文本」、「布尔」、「数字」、「枚举」、「日期时间」、「附件」、「图片」时返回具体的配置信息，其余类型的自定义字段暂不返回</para>
        /// </summary>
        public record CustomFieldCommonSchemaConfig
        {
            /// <summary>
            /// <para>文本配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_field_setting")]
            public CustomFieldCommonSchemaConfigTextFieldSetting? TextFieldSetting { get; set; }

            /// <summary>
            /// <para>文本配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigTextFieldSetting
            {
                /// <summary>
                /// <para>是否多语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_multilingual")]
                public bool? IsMultilingual { get; set; }

                /// <summary>
                /// <para>是否多行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_multiline")]
                public bool? IsMultiline { get; set; }

                /// <summary>
                /// <para>最大长度</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("max_length")]
                public int MaxLength { get; set; }

                /// <summary>
                /// <para>是否是URL类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_url_type")]
                public bool? IsUrlType { get; set; }
            }

            /// <summary>
            /// <para>数字配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("number_field_setting")]
            public CustomFieldCommonSchemaConfigNumberFieldSetting? NumberFieldSetting { get; set; }

            /// <summary>
            /// <para>数字配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigNumberFieldSetting
            {
                /// <summary>
                /// <para>数字类型</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：Percent 百分比</para>
                /// <para>- `2`：Integer 整数</para>
                /// <para>- `3`：Value 数值（浮点数）</para>
                /// <para>- `4`：Money 金额（浮点数）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("number_field_type")]
                public int? NumberFieldType { get; set; }

                /// <summary>
                /// <para>小数部分位数（浮点数整数部分和小数部分分别最大30位）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("decimal_places")]
                public int? DecimalPlaces { get; set; }

                /// <summary>
                /// <para>四舍五入规则</para>
                /// <para>**可选值有：**</para>
                /// <para>- `0`：Round 四舍五入</para>
                /// <para>- `1`：Ceil 向上舍入</para>
                /// <para>- `2`：Floor 向下舍入</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("round_type")]
                public int? RoundType { get; set; }

                /// <summary>
                /// <para>整数+小数总位数</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("decimal_total_places")]
                public int? DecimalTotalPlaces { get; set; }
            }

            /// <summary>
            /// <para>选项配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_field_setting")]
            public CustomFieldCommonSchemaConfigEnumFieldSetting? EnumFieldSetting { get; set; }

            /// <summary>
            /// <para>选项配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigEnumFieldSetting
            {
                /// <summary>
                /// <para>选项信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enum_field_option_list")]
                public CommonSchemaOption[]? EnumFieldOptionLists { get; set; }

                /// <summary>
                /// <para>选项信息</para>
                /// </summary>
                public record CommonSchemaOption
                {
                    /// <summary>
                    /// <para>选项 api_name，即选项的唯一标识</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：custom_field_33</para>
                    /// </summary>
                    [JsonPropertyName("api_name")]
                    public string? ApiName { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CommonSchemaOptionName? Name { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// </summary>
                    public record CommonSchemaOptionName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：cn</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：en</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>选项描述</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("description")]
                    public NameSuffix? Description { get; set; }

                    /// <summary>
                    /// <para>选项描述</para>
                    /// </summary>
                    public record NameSuffix
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：cn</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：en</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>是否启用</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_open")]
                    public bool? IsOpen { get; set; }
                }

                /// <summary>
                /// <para>是否为多选</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_multiple")]
                public bool? IsMultiple { get; set; }
            }

            /// <summary>
            /// <para>查找字段配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("lookup_field_setting")]
            public CustomFieldCommonSchemaConfigLookupFieldSetting? LookupFieldSetting { get; set; }

            /// <summary>
            /// <para>查找字段配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigLookupFieldSetting
            {
                /// <summary>
                /// <para>查找字段对应的对象 apiname，可通过[【获取自定义字段列表】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)接口获取这个对象中定义的自定义字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：employment</para>
                /// </summary>
                [JsonPropertyName("lookup_obj_api_name")]
                public string? LookupObjApiName { get; set; }

                /// <summary>
                /// <para>是否为多值</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_multiple")]
                public bool? IsMultiple { get; set; }
            }

            /// <summary>
            /// <para>日期时间配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("date_time_field_setting")]
            public CustomFieldCommonSchemaConfigDateTimeFieldSetting? DateTimeFieldSetting { get; set; }

            /// <summary>
            /// <para>日期时间配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigDateTimeFieldSetting
            {
                /// <summary>
                /// <para>时间类型枚举</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：Date 日期，如 2020-01-01</para>
                /// <para>- `2`：Time 时间，如 11:52:00</para>
                /// <para>- `3`：Datetime 日期时间，如 2020-01-01 11:52:00</para>
                /// <para>- `4`：CusDatetime // timestamp 时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("date_time_type")]
                public int? DateTimeType { get; set; }
            }

            /// <summary>
            /// <para>附件配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("attachment_field_setting")]
            public CustomFieldCommonSchemaConfigAttachmentFieldSetting? AttachmentFieldSetting { get; set; }

            /// <summary>
            /// <para>附件配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigAttachmentFieldSetting
            {
                /// <summary>
                /// <para>是否支持多个文件</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_multiple")]
                public bool? IsMultiple { get; set; }

                /// <summary>
                /// <para>文件类型枚举</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：jpeg</para>
                /// <para>- `2`：png</para>
                /// <para>- `3`：gif</para>
                /// <para>- `4`：pdf</para>
                /// <para>- `5`：docx</para>
                /// <para>- `6`：doc</para>
                /// <para>- `7`：csv</para>
                /// <para>- `8`：xls</para>
                /// <para>- `9`：txt</para>
                /// <para>- `10`：xlsx</para>
                /// <para>- `11`：mp4</para>
                /// <para>- `12`：pptx</para>
                /// <para>- `13`：ppt</para>
                /// <para>- `14`：json</para>
                /// <para>- `15`：zip</para>
                /// <para>- `16`：rar</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("file_type")]
                public int? FileType { get; set; }
            }

            /// <summary>
            /// <para>图片配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("image_field_setting")]
            public CustomFieldCommonSchemaConfigImageFieldSetting? ImageFieldSetting { get; set; }

            /// <summary>
            /// <para>图片配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigImageFieldSetting
            {
                /// <summary>
                /// <para>图片类型枚举</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：Avatar 头像</para>
                /// <para>- `2`：BadgePhoto 工卡照片</para>
                /// <para>- `3`：Logo 标志</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("image_type")]
                public int? ImageType { get; set; }

                /// <summary>
                /// <para>显示样式枚举</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：SquareImage 方形</para>
                /// <para>- `2`：RoundImage 圆形</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("display_style")]
                public int? DisplayStyle { get; set; }
            }
        }

        /// <summary>
        /// <para>创建时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625542287</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625542639</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }
    }
}
