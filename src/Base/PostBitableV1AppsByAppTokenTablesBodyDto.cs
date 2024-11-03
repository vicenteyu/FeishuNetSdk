// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增一个数据表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增一个数据表 请求体
/// <para>新增一个数据表，默认仅包含索引字段，也可以指定一部分初始字段。</para>
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
    [JsonPropertyName("table")]
    public ReqTable? Table { get; set; }

    /// <summary>
    /// <para>数据表</para>
    /// </summary>
    public record ReqTable
    {
        /// <summary>
        /// <para>数据表名称。名称中的首尾空格将会被默认去除。</para>
        /// <para>**注意**：</para>
        /// <para>该字段必填。</para>
        /// <para>必填：否</para>
        /// <para>示例值：一个新的数据表</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>默认表格视图的名称，不填则默认为“表格视图 1”。</para>
        /// <para>注意：</para>
        /// <para>- 名称中的首尾空格将会被去除。</para>
        /// <para>- 名称中不允许包含 [ ] 两个字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：表格视图</para>
        /// </summary>
        [JsonPropertyName("default_view_name")]
        public string? DefaultViewName { get; set; }

        /// <summary>
        /// <para>数据表的初始字段。了解如何填写字段，参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// <para>**注意**：</para>
        /// <para>- 如果 `default_view_name` 字段和 `fields` 字段都不填写，将会创建一个仅包含索引字段的空数据表。</para>
        /// <para>- 如果指定了本字段，将会创建一个包含初始字段的数据表、且默认第一个字段为索引字段。</para>
        /// <para>- 索引字段仅支持以下类型：</para>
        /// <para>- 1：多行文本</para>
        /// <para>- 2：数字</para>
        /// <para>- 5：日期</para>
        /// <para>- 13：电话号码</para>
        /// <para>- 15：超链接</para>
        /// <para>- 20：公式</para>
        /// <para>- 22：地理位置</para>
        /// <para>必填：否</para>
        /// <para>最大长度：300</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("fields")]
        public AppTableCreateHeader[]? Fields { get; set; }

        /// <summary>
        /// <para>数据表的初始字段。了解如何填写字段，参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// <para>**注意**：</para>
        /// <para>- 如果 `default_view_name` 字段和 `fields` 字段都不填写，将会创建一个仅包含索引字段的空数据表。</para>
        /// <para>- 如果指定了本字段，将会创建一个包含初始字段的数据表、且默认第一个字段为索引字段。</para>
        /// <para>- 索引字段仅支持以下类型：</para>
        /// <para>- 1：多行文本</para>
        /// <para>- 2：数字</para>
        /// <para>- 5：日期</para>
        /// <para>- 13：电话号码</para>
        /// <para>- 15：超链接</para>
        /// <para>- 20：公式</para>
        /// <para>- 22：地理位置</para>
        /// </summary>
        public record AppTableCreateHeader
        {
            /// <summary>
            /// <para>字段名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：问题描述</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
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
            [JsonPropertyName("type")]
            public int Type { get; set; }

            /// <summary>
            /// <para>字段在界面上的展示类型，例如 Progress 进度字段是数字的一种展示形态</para>
            /// <para>必填：否</para>
            /// <para>示例值：Progress</para>
            /// <para>可选值：<list type="bullet">
            /// <item>Text：文本</item>
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
            /// <para>字段属性</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("property")]
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
                    /// <para>示例值：红色</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>选项 ID，创建时不可指定 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：optKl35lnG</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>选项颜色，详情参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：0</para>
                    /// <para>最大值：54</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("color")]
                    public int? Color { get; set; }
                }

                /// <summary>
                /// <para>数字、公式字段的显示格式。详情参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// </summary>
                [JsonPropertyName("formatter")]
                public string? Formatter { get; set; }

                /// <summary>
                /// <para>日期、创建时间、最后更新时间字段的显示格式。详情参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
                /// <para>必填：否</para>
                /// <para>示例值：日期格式</para>
                /// </summary>
                [JsonPropertyName("date_formatter")]
                public string? DateFormatter { get; set; }

                /// <summary>
                /// <para>日期字段中新纪录自动填写创建时间</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("auto_fill")]
                public bool? AutoFill { get; set; }

                /// <summary>
                /// <para>人员字段中允许添加多个成员，单向关联、双向关联中允许添加多个记录</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("multiple")]
                public bool? Multiple { get; set; }

                /// <summary>
                /// <para>单向关联、双向关联字段中关联的数据表的id</para>
                /// <para>必填：否</para>
                /// <para>示例值：tblsRc9GRRXKqhvW</para>
                /// </summary>
                [JsonPropertyName("table_id")]
                public string? TableId { get; set; }

                /// <summary>
                /// <para>单向关联、双向关联字段中关联的数据表的名字</para>
                /// <para>必填：否</para>
                /// <para>示例值："table2"</para>
                /// </summary>
                [JsonPropertyName("table_name")]
                public string? TableName { get; set; }

                /// <summary>
                /// <para>双向关联字段中关联的数据表中对应的双向关联字段的名字</para>
                /// <para>必填：否</para>
                /// <para>示例值："table1-双向关联"</para>
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
                /// <para>示例值：bitable::$table[tblNj92WQBAasdEf].$field[fldMV60rYs]*2</para>
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
            }

            /// <summary>
            /// <para>字段的描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
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
                [JsonPropertyName("disable_sync")]
                public bool? DisableSync { get; set; }

                /// <summary>
                /// <para>字段描述内容，支持换行\n</para>
                /// <para>必填：否</para>
                /// <para>示例值：请按 name_id 格式填写\n例如：“Alice_20202020”</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }
            }
        }
    }
}
