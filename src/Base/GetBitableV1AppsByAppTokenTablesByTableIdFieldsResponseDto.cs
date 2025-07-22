// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-22
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出字段 响应体
/// <para>获取多维表格数据表中的的所有字段。</para>
/// <para>接口ID：6960166873968492547</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto : IPageableResponse<GetBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto.AppTableFieldForList>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：\-</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>字段信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppTableFieldForList[]? Items { get; set; }

    /// <summary>
    /// <para>字段信息</para>
    /// </summary>
    public record AppTableFieldForList
    {
        /// <summary>
        /// <para>多维表格字段名称。名称中的首尾空格将会被去除。</para>
        /// <para>必填：是</para>
        /// <para>示例值：字段名称</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>多维表格字段类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>最大值：999999999</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：文本</item>
        /// <item>2：数字</item>
        /// <item>3：单选</item>
        /// <item>4：多选</item>
        /// <item>5：日期</item>
        /// <item>7：复选框</item>
        /// <item>11：人员</item>
        /// <item>13：电话号码</item>
        /// <item>15：超链接</item>
        /// <item>17：附件</item>
        /// <item>18：关联</item>
        /// <item>20：公式</item>
        /// <item>21：双向关联</item>
        /// <item>22：地理位置</item>
        /// <item>23：群组</item>
        /// <item>1001：创建时间</item>
        /// <item>1002：最后更新时间</item>
        /// <item>1003：创建人</item>
        /// <item>1004：修改人</item>
        /// <item>1005：自动编号</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// <para>字段属性，具体可参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("property")]
        public AppTableFieldProperty? Property { get; set; }

        /// <summary>
        /// <para>字段属性，具体可参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// </summary>
        public record AppTableFieldProperty
        {
            /// <summary>
            /// <para>单选、多选字段的选项信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("options")]
            public AppTableFieldPropertyOption[]? Options { get; set; }

            /// <summary>
            /// <para>单选、多选字段的选项信息</para>
            /// </summary>
            public record AppTableFieldPropertyOption
            {
                /// <summary>
                /// <para>选项名</para>
                /// <para>必填：否</para>
                /// <para>示例值：\-</para>
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>选项 ID，创建时不允许指定 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：\-</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>选项颜色</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// <para>最大值：54</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("color")]
                public int? Color { get; set; }
            }

            /// <summary>
            /// <para>数字、公式字段的显示格式</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("formatter")]
            public string? Formatter { get; set; }

            /// <summary>
            /// <para>日期、创建时间、最后更新时间字段的显示格式</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("date_formatter")]
            public string? DateFormatter { get; set; }

            /// <summary>
            /// <para>日期字段中新纪录自动填写创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("auto_fill")]
            public bool? AutoFill { get; set; }

            /// <summary>
            /// <para>人员字段中允许添加多个成员，单向关联、双向关联中允许添加多个记录</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("multiple")]
            public bool? Multiple { get; set; }

            /// <summary>
            /// <para>单向关联、双向关联字段中关联的数据表的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("table_id")]
            public string? TableId { get; set; }

            /// <summary>
            /// <para>单向关联、双向关联字段中关联的数据表的名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("table_name")]
            public string? TableName { get; set; }

            /// <summary>
            /// <para>双向关联字段中关联的数据表中对应的双向关联字段的 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("back_field_id")]
            public string? BackFieldId { get; set; }

            /// <summary>
            /// <para>双向关联字段中关联的数据表中对应的双向关联字段的名字</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("back_field_name")]
            public string? BackFieldName { get; set; }

            /// <summary>
            /// <para>自动编号类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("auto_serial")]
            public AppFieldPropertyAutoSerial? AutoSerial { get; set; }

            /// <summary>
            /// <para>自动编号类型</para>
            /// </summary>
            public record AppFieldPropertyAutoSerial
            {
                /// <summary>
                /// <para>自动编号类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：auto_increment_number</para>
                /// <para>可选值：<list type="bullet">
                /// <item>custom：自定义编号</item>
                /// <item>auto_increment_number：自增数字</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// <para>自动编号规则列表</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("options")]
                public AppFieldPropertyAutoSerialOptions[]? Options { get; set; }

                /// <summary>
                /// <para>自动编号规则列表</para>
                /// </summary>
                public record AppFieldPropertyAutoSerialOptions
                {
                    /// <summary>
                    /// <para>自动编号的可选规则项类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：created_time</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>system_number：自增数字位,value范围1-9</item>
                    /// <item>fixed_text：固定字符，最大长度：20</item>
                    /// <item>created_time：创建时间，支持格式 "yyyyMMdd"、"yyyyMM"、"yyyy"、"MMdd"、"MM"、"dd"</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public string Type { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>与自动编号的可选规则项类型相对应的取值</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：yyyyMMdd</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>地理位置输入方式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("location")]
            public AppFieldPropertyLocation? Location { get; set; }

            /// <summary>
            /// <para>地理位置输入方式</para>
            /// </summary>
            public record AppFieldPropertyLocation
            {
                /// <summary>
                /// <para>地理位置输入限制</para>
                /// <para>必填：是</para>
                /// <para>示例值：not_limit</para>
                /// <para>可选值：<list type="bullet">
                /// <item>only_mobile：只允许移动端上传</item>
                /// <item>not_limit：无限制</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("input_type")]
                public string InputType { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>公式字段的表达式</para>
            /// <para>必填：否</para>
            /// <para>示例值：\-</para>
            /// </summary>
            [JsonPropertyName("formula_expression")]
            public string? FormulaExpression { get; set; }

            /// <summary>
            /// <para>字段支持的编辑模式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("allowed_edit_modes")]
            public AppTableFieldPropertyAllowedEditModes? AllowedEditModes { get; set; }

            /// <summary>
            /// <para>字段支持的编辑模式</para>
            /// </summary>
            public record AppTableFieldPropertyAllowedEditModes
            {
                /// <summary>
                /// <para>是否允许手动录入</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("manual")]
                public bool? Manual { get; set; }

                /// <summary>
                /// <para>是否允许移动端录入</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("scan")]
                public bool? Scan { get; set; }
            }

            /// <summary>
            /// <para>进度、评分等字段的数据范围最小值</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("min")]
            public float? Min { get; set; }

            /// <summary>
            /// <para>进度、评分等字段的数据范围最大值</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// </summary>
            [JsonPropertyName("max")]
            public float? Max { get; set; }

            /// <summary>
            /// <para>进度等字段是否支持自定义范围</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("range_customize")]
            public bool? RangeCustomize { get; set; }

            /// <summary>
            /// <para>货币币种</para>
            /// <para>必填：否</para>
            /// <para>示例值：CNY</para>
            /// </summary>
            [JsonPropertyName("currency_code")]
            public string? CurrencyCode { get; set; }

            /// <summary>
            /// <para>评分字段的相关设置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("rating")]
            public AppTableFieldPropertyRating? Rating { get; set; }

            /// <summary>
            /// <para>评分字段的相关设置</para>
            /// </summary>
            public record AppTableFieldPropertyRating
            {
                /// <summary>
                /// <para>评分字段的符号展示</para>
                /// <para>必填：否</para>
                /// <para>示例值：star</para>
                /// </summary>
                [JsonPropertyName("symbol")]
                public string? Symbol { get; set; }
            }

            /// <summary>
            /// <para>设置公式字段的数据类型</para>
            /// <para>**注意**：非所有多维表格都支持该能力。请参考[获取多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get)接口返回的formula_type 判断，当 `formula_type` 等于 2 时，表示需要设置该字段。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("type")]
            public AppTableFieldPropertyType? Type { get; set; }

            /// <summary>
            /// <para>设置公式字段的数据类型</para>
            /// <para>**注意**：非所有多维表格都支持该能力。请参考[获取多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/get)接口返回的formula_type 判断，当 `formula_type` 等于 2 时，表示需要设置该字段。</para>
            /// </summary>
            public record AppTableFieldPropertyType
            {
                /// <summary>
                /// <para>公式字段对应的数据类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：文本（默认值）、条码</item>
                /// <item>2：数字（默认值）、进度、货币、评分</item>
                /// <item>3：单选</item>
                /// <item>4：多选</item>
                /// <item>5：日期</item>
                /// <item>7：复选框</item>
                /// <item>11：人员</item>
                /// <item>13：电话号码</item>
                /// <item>15：超链接</item>
                /// <item>17：附件</item>
                /// <item>18：单向关联</item>
                /// <item>20：公式</item>
                /// <item>21：双向关联</item>
                /// <item>22：地理位置</item>
                /// <item>23：群组</item>
                /// <item>1001：创建时间</item>
                /// <item>1002：最后更新时间</item>
                /// <item>1003：创建人</item>
                /// <item>1004：修改人</item>
                /// <item>1005：自动编号</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("data_type")]
                public int DataType { get; set; }

                /// <summary>
                /// <para>公式数据属性</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("ui_property")]
                public AppTableFieldPropertyTypeUiProperty? UiProperty { get; set; }

                /// <summary>
                /// <para>公式数据属性</para>
                /// </summary>
                public record AppTableFieldPropertyTypeUiProperty
                {
                    /// <summary>
                    /// <para>货币币种</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：CNY</para>
                    /// <para>最大长度：20</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("currency_code")]
                    public string? CurrencyCode { get; set; }

                    /// <summary>
                    /// <para>数字、公式字段的显示格式</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：0</para>
                    /// <para>最大长度：50</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("formatter")]
                    public string? Formatter { get; set; }

                    /// <summary>
                    /// <para>进度等字段是否支持自定义范围</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("range_customize")]
                    public bool? RangeCustomize { get; set; }

                    /// <summary>
                    /// <para>进度、评分等字段的数据范围最小值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：1</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("min")]
                    public float? Min { get; set; }

                    /// <summary>
                    /// <para>进度、评分等字段的数据范围最大值</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：100</para>
                    /// <para>最大值：100</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("max")]
                    public float? Max { get; set; }

                    /// <summary>
                    /// <para>日期、创建时间、最后更新时间字段的显示格式</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：yyyy/MM/dd</para>
                    /// <para>最大长度：50</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("date_formatter")]
                    public string? DateFormatter { get; set; }

                    /// <summary>
                    /// <para>评分字段的相关设置</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("rating")]
                    public AppTableFieldPropertyTypeUiPropertyRating? Rating { get; set; }

                    /// <summary>
                    /// <para>评分字段的相关设置</para>
                    /// </summary>
                    public record AppTableFieldPropertyTypeUiPropertyRating
                    {
                        /// <summary>
                        /// <para>评分字段的符号展示</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：star</para>
                        /// </summary>
                        [JsonPropertyName("symbol")]
                        public string? Symbol { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式字段在界面上的展示类型，例如进度字段是数字的一种展示形态。了解更多，参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
                /// <para>必填：否</para>
                /// <para>示例值：Progress</para>
                /// <para>可选值：<list type="bullet">
                /// <item>Number：数字</item>
                /// <item>Progress：进度</item>
                /// <item>Currency：货币</item>
                /// <item>Rating：评分</item>
                /// <item>DateTime：日期</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("ui_type")]
                public string? UiType { get; set; }
            }

            /// <summary>
            /// <para>查找引用关系</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("filter_info")]
            public AppTableFieldPropertyLookupFilter? FilterInfo { get; set; }

            /// <summary>
            /// <para>查找引用关系</para>
            /// </summary>
            public record AppTableFieldPropertyLookupFilter
            {
                /// <summary>
                /// <para>引用表格</para>
                /// <para>必填：否</para>
                /// <para>示例值：tblXJDra28ZYsSKo</para>
                /// </summary>
                [JsonPropertyName("target_table")]
                public string? TargetTable { get; set; }

                /// <summary>
                /// <para>查找条件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("filter_info")]
                public AppTableFieldPropertyFilterInfo? FilterInfo { get; set; }

                /// <summary>
                /// <para>查找条件</para>
                /// </summary>
                public record AppTableFieldPropertyFilterInfo
                {
                    /// <summary>
                    /// <para>多个筛选条件的关系</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：and</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>and：与</item>
                    /// <item>or：或</item>
                    /// </list></para>
                    /// <para>默认值：and</para>
                    /// </summary>
                    [JsonPropertyName("conjunction")]
                    public string Conjunction { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>筛选条件</para>
                    /// <para>必填：是</para>
                    /// <para>最大长度：50</para>
                    /// </summary>
                    [JsonPropertyName("conditions")]
                    public AppTableFieldPropertyFilterInfoCondition[] Conditions { get; set; } = Array.Empty<AppTableFieldPropertyFilterInfoCondition>();

                    /// <summary>
                    /// <para>筛选条件</para>
                    /// </summary>
                    public record AppTableFieldPropertyFilterInfoCondition
                    {
                        /// <summary>
                        /// <para>用于过滤的字段唯一ID</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：单选</para>
                        /// </summary>
                        [JsonPropertyName("field_id")]
                        public string FieldId { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>过滤操作的类型</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：is</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>is：等于</item>
                        /// <item>isNot：不等于</item>
                        /// <item>contains：包含</item>
                        /// <item>doesNotContain：不包含</item>
                        /// <item>isEmpty：为空</item>
                        /// <item>isNotEmpty：不为空</item>
                        /// <item>isGreater：大于</item>
                        /// <item>isGreaterEqual：大于等于</item>
                        /// <item>isLess：小于</item>
                        /// <item>isLessEqual：小于等于</item>
                        /// </list></para>
                        /// <para>默认值：is</para>
                        /// </summary>
                        [JsonPropertyName("operator")]
                        public string Operator { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>筛选值</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["optbdVHf4q", "optrpd3eIJ"]</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }

                        /// <summary>
                        /// <para>过滤条件的唯一ID</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：conNaOEK6O</para>
                        /// </summary>
                        [JsonPropertyName("condition_id")]
                        public string? ConditionId { get; set; }

                        /// <summary>
                        /// <para>用于过滤的字段类型</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：3</para>
                        /// </summary>
                        [JsonPropertyName("field_type")]
                        public int? FieldType { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>字段的描述。可能是数组或字符串类型。由请求参数 `text_field_as_array` 决定。</para>
        /// <para>必填：否</para>
        /// <para>示例值：字段描述示例：该字段为日期类型字段</para>
        /// </summary>
        [JsonPropertyName("description")]
        public object? Description { get; set; }

        /// <summary>
        /// <para>是否是索引列</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_primary")]
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// <para>多维表格字段 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：fldWJyCkFQ</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：5</para>
        /// </summary>
        [JsonPropertyName("field_id")]
        public string? FieldId { get; set; }

        /// <summary>
        /// <para>字段在界面上的展示类型，例如进度字段是数字的一种展示形态。了解更多，参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：Progress</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>Text：多行文本</item>
        /// <item>Barcode：条码</item>
        /// <item>Number：数字</item>
        /// <item>Progress：进度</item>
        /// <item>Currency：货币</item>
        /// <item>Rating：评分</item>
        /// <item>SingleSelect：单选</item>
        /// <item>MultiSelect：多选</item>
        /// <item>DateTime：日期</item>
        /// <item>Checkbox：复选框</item>
        /// <item>User：人员</item>
        /// <item>GroupChat：群组</item>
        /// <item>Phone：电话号码</item>
        /// <item>Url：超链接</item>
        /// <item>Attachment：附件</item>
        /// <item>SingleLink：单向关联</item>
        /// <item>Formula：公式</item>
        /// <item>DuplexLink：双向关联</item>
        /// <item>Location：地理位置</item>
        /// <item>CreatedTime：创建时间</item>
        /// <item>ModifiedTime：最后更新时间</item>
        /// <item>CreatedUser：创建人</item>
        /// <item>ModifiedUser：修改人</item>
        /// <item>AutoNumber：自动编号</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("ui_type")]
        public string? UiType { get; set; }

        /// <summary>
        /// <para>是否是隐藏字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_hidden")]
        public bool? IsHidden { get; set; }
    }
}
