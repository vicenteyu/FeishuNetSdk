using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增一个数据表 请求体
/// <para>通过该接口，可以新增一个仅包含索引列的空数据表，也可以指定一部分初始字段。</para>
/// <para>接口ID：6960166873968541699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesBodyDto
{
    /// <summary>
    /// <para>数据表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("table")]
    public ReqTable? Table { get; set; }

    /// <summary>
    /// <para>数据表</para>
    /// </summary>
    public record ReqTable
    {
        /// <summary>
        /// <para>数据表名称</para>
        /// <para>请注意：</para>
        /// <para>1. 名称中的首尾空格将会被去除。</para>
        /// <para>必填：否</para>
        /// <para>示例值：table1</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>默认表格视图的名称，不填则默认为 表格。</para>
        /// <para>请注意：</para>
        /// <para>1. 名称中的首尾空格将会被去除。</para>
        /// <para>2. 名称中不允许包含 [ ] 两个字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：表格</para>
        /// </summary>
        [JsonProperty("default_view_name")]
        public string? DefaultViewName { get; set; }

        /// <summary>
        /// <para>数据表的初始字段。</para>
        /// <para>请注意：</para>
        /// <para>1. 如果 default_view_name 字段和 fields 字段都不填写，将会创建一个仅包含索引列的空数据表。</para>
        /// <para>2. 如果指定了 fields 字段，将会创建一个包含初始字段的数据表且默认第一个字段为索引列。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// </summary>
        [JsonProperty("fields")]
        public AppTableCreateHeader[]? Fields { get; set; }

        /// <summary>
        /// <para>数据表的初始字段。</para>
        /// <para>请注意：</para>
        /// <para>1. 如果 default_view_name 字段和 fields 字段都不填写，将会创建一个仅包含索引列的空数据表。</para>
        /// <para>2. 如果指定了 fields 字段，将会创建一个包含初始字段的数据表且默认第一个字段为索引列。</para>
        /// </summary>
        public record AppTableCreateHeader
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：文本</para>
            /// </summary>
            [JsonProperty("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：多行文本</item>
            /// <item>2：数字</item>
            /// <item>3：单选</item>
            /// <item>4：多选</item>
            /// <item>5：日期</item>
            /// <item>7：复选框</item>
            /// <item>11：人员</item>
            /// <item>13：电话号码</item>
            /// <item>15：超链接</item>
            /// <item>22：地理位置</item>
            /// <item>1001：创建时间</item>
            /// <item>1002：最后更新时间</item>
            /// <item>1003：创建人</item>
            /// <item>1004：修改人</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("type")]
            public int Type { get; set; }

            /// <summary>
            /// <para>字段属性</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("property")]
            public AppTableFieldProperty? Property { get; set; }

            /// <summary>
            /// <para>字段属性</para>
            /// </summary>
            public record AppTableFieldProperty
            {
                /// <summary>
                /// <para>单选、多选字段的选项信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("options")]
                public AppTableFieldPropertyOption[]? Options { get; set; }

                /// <summary>
                /// <para>单选、多选字段的选项信息</para>
                /// </summary>
                public record AppTableFieldPropertyOption
                {
                    /// <summary>
                    /// <para>选项名</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：红色</para>
                    /// </summary>
                    [JsonProperty("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>选项 ID，创建时不允许指定 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：optKl35lnG</para>
                    /// </summary>
                    [JsonProperty("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>选项颜色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：0</para>
                    /// </summary>
                    [JsonProperty("color")]
                    public int? Color { get; set; }
                }

                /// <summary>
                /// <para>数字、公式字段的显示格式</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonProperty("formatter")]
                public string? Formatter { get; set; }

                /// <summary>
                /// <para>日期、创建时间、最后更新时间字段的显示格式</para>
                /// <para>必填：否</para>
                /// <para>示例值：日期格式</para>
                /// </summary>
                [JsonProperty("date_formatter")]
                public string? DateFormatter { get; set; }

                /// <summary>
                /// <para>日期字段中新纪录自动填写创建时间</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonProperty("auto_fill")]
                public bool? AutoFill { get; set; }

                /// <summary>
                /// <para>人员字段中允许添加多个成员，单向关联、双向关联中允许添加多个记录</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonProperty("multiple")]
                public bool? Multiple { get; set; }

                /// <summary>
                /// <para>单向关联、双向关联字段中关联的数据表的id</para>
                /// <para>必填：否</para>
                /// <para>示例值：tblsRc9GRRXKqhvW</para>
                /// </summary>
                [JsonProperty("table_id")]
                public string? TableId { get; set; }

                /// <summary>
                /// <para>单向关联、双向关联字段中关联的数据表的名字</para>
                /// <para>必填：否</para>
                /// <para>示例值："table2"</para>
                /// </summary>
                [JsonProperty("table_name")]
                public string? TableName { get; set; }

                /// <summary>
                /// <para>双向关联字段中关联的数据表中对应的双向关联字段的名字</para>
                /// <para>必填：否</para>
                /// <para>示例值："table1-双向关联"</para>
                /// </summary>
                [JsonProperty("back_field_name")]
                public string? BackFieldName { get; set; }

                /// <summary>
                /// <para>自动编号类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("auto_serial")]
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
                    [JsonProperty("type")]
                    public string Type { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自动编号规则列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("options")]
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
                        /// <item>created_time：创建时间，支持格式"yyyyMMdd"、"yyyyMM"、"yyyy"、"MMdd"、"MM"、"dd"</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("type")]
                        public string Type { get; set; } = string.Empty;

                        /// <summary>
                        /// <para>与自动编号的可选规则项类型相对应的取值</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：yyyyMMdd</para>
                        /// </summary>
                        [JsonProperty("value")]
                        public string Value { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// <para>地理位置输入方式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("location")]
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
                    [JsonProperty("input_type")]
                    public string InputType { get; set; } = string.Empty;
                }

                /// <summary>
                /// <para>公式字段的表达式</para>
                /// <para>必填：否</para>
                /// <para>示例值：bitable::$table[tblNj92WQBAasdEf].$field[fldMV60rYs]*2</para>
                /// </summary>
                [JsonProperty("formula_expression")]
                public string? FormulaExpression { get; set; }

                /// <summary>
                /// <para>字段支持的编辑模式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("allowed_edit_modes")]
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
                    [JsonProperty("manual")]
                    public bool? Manual { get; set; }

                    /// <summary>
                    /// <para>是否允许移动端录入</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonProperty("scan")]
                    public bool? Scan { get; set; }
                }

                /// <summary>
                /// <para>进度、评分等字段的数据范围最小值</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonProperty("min")]
                public float? Min { get; set; }

                /// <summary>
                /// <para>进度、评分等字段的数据范围最大值</para>
                /// <para>必填：否</para>
                /// <para>示例值：10</para>
                /// </summary>
                [JsonProperty("max")]
                public float? Max { get; set; }

                /// <summary>
                /// <para>进度等字段是否支持自定义范围</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonProperty("range_customize")]
                public bool? RangeCustomize { get; set; }

                /// <summary>
                /// <para>货币币种</para>
                /// <para>必填：否</para>
                /// <para>示例值：CNY</para>
                /// </summary>
                [JsonProperty("currency_code")]
                public string? CurrencyCode { get; set; }

                /// <summary>
                /// <para>评分字段的相关设置</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("rating")]
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
                    [JsonProperty("symbol")]
                    public string? Symbol { get; set; }
                }
            }

            /// <summary>
            /// <para>字段的描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("description")]
            public AppTableFieldDescription? Description { get; set; }

            /// <summary>
            /// <para>字段的描述</para>
            /// </summary>
            public record AppTableFieldDescription
            {
                /// <summary>
                /// <para>是否禁止同步，如果为true，表示禁止同步该描述内容到表单的问题描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：true</para>
                /// </summary>
                [JsonProperty("disable_sync")]
                public bool? DisableSync { get; set; }

                /// <summary>
                /// <para>字段描述内容，支持换行\n</para>
                /// <para>必填：否</para>
                /// <para>示例值：请按name_id格式填写\n例如：“Alice_20202020”</para>
                /// </summary>
                [JsonProperty("text")]
                public string? Text { get; set; }
            }
        }
    }
}
