// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-01-11
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdFieldsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增字段 请求体
/// <para>在多维表格数据表中新增一个字段。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：6960166873968427011</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdFieldsBodyDto
{
    /// <summary>
    /// <para>多维表格字段名称。名称中的首尾空格将会被去除。</para>
    /// <para>必填：是</para>
    /// <para>示例值：任务名称</para>
    /// </summary>
    [JsonPropertyName("field_name")]
    public string FieldName { get; set; } = string.Empty;

    /// <summary>
    /// <para>要新增的字段类型。不支持新增 19 查找引用字段类型。</para>
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
    /// <item>18：单项关联</item>
    /// <item>20：公式（不支持设置公式表达式）</item>
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
    /// <para>字段属性，了解如何填写字段，参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("property")]
    public AppTableFieldProperty? Property { get; set; }

    /// <summary>
    /// <para>字段属性，了解如何填写字段，参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
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
            /// <para>选项名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：红色</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>选项 ID，创建字段时不允许指定 ID。</para>
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
        /// <para>数字和公式字段的显示格式。详情参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("formatter")]
        public string? Formatter { get; set; }

        /// <summary>
        /// <para>日期、创建时间、最后更新时间字段的显示格式。默认为 "yyyy/MM/dd"。枚举值如下所示：</para>
        /// <para>- "yyyy/MM/dd"：2021/1/30</para>
        /// <para>- "yyyy-MM-dd HH:mm"：2021/1/30 14:00</para>
        /// <para>- "MM-dd"：1月30日</para>
        /// <para>- "MM/dd/yyyy"：2021/1/30</para>
        /// <para>- "dd/MM/yyyy"：2021/1/30"</para>
        /// <para>必填：否</para>
        /// <para>示例值：yyyy/MM/dd</para>
        /// </summary>
        [JsonPropertyName("date_formatter")]
        public string? DateFormatter { get; set; }

        /// <summary>
        /// <para>对于新记录，是否自动填写创建时间。默认为 false。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("auto_fill")]
        public bool? AutoFill { get; set; }

        /// <summary>
        /// <para>人员字段中是否允许添加多个成员，或单向关联、双向关联字段中是否允许添加多个记录。默认为 true。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("multiple")]
        public bool? Multiple { get; set; }

        /// <summary>
        /// <para>单向关联、双向关联字段中关联的数据表的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：tblsRc9GRRXKqhvW</para>
        /// </summary>
        [JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// <para>双向关联字段中，关联的数据表中对应的双向关联字段名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：table1-双向关联</para>
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
            /// <para>自定义编号规则列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("options")]
            public AppFieldPropertyAutoSerialOptions[]? Options { get; set; }

            /// <summary>
            /// <para>自定义编号规则列表</para>
            /// </summary>
            public record AppFieldPropertyAutoSerialOptions
            {
                /// <summary>
                /// <para>自动编号的可选规则项类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：created_time</para>
                /// <para>可选值：<list type="bullet">
                /// <item>system_number：自增数字的位数</item>
                /// <item>fixed_text：固定字符</item>
                /// <item>created_time：创建时间</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// <para>规则类型对应的值。</para>
                /// <para>- 若规则类型为 `"type": "system_number"`，value 为范围在 1-9 的整数，表示自增数字的位数</para>
                /// <para>- 若规则类型为 `"type": "fixed_text"`，value 为范围在 20 个字符以内的固定字符</para>
                /// <para>- 若规则类型为 `"type": "created_time"`，value 用于指定日期的格式。可选值如下所示：</para>
                /// <para>- "yyyyMMdd"：日期为 20220130 的格式</para>
                /// <para>- "yyyyMM"：日期为 202201 的格式</para>
                /// <para>- "yyyy"：日期为 2022 的格式</para>
                /// <para>- "MMdd"：日期为 130 的格式，表示 1 月 30 日</para>
                /// <para>- "MM"：日期为 1 的格式，表示月份</para>
                /// <para>- "dd"：日期为 30 的格式</para>
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
            /// <item>only_mobile：仅允许移动端实时定位</item>
            /// <item>not_limit：无限制，可输入任意地理位置</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("input_type")]
            public string InputType { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>公式字段的表达式。参考[飞书帮助中心文档](https://www.feishu.cn/hc/zh-CN/articles/360049067853-%E5%A4%9A%E7%BB%B4%E8%A1%A8%E6%A0%BC%E5%85%AC%E5%BC%8F%E5%AD%97%E6%AE%B5%E6%A6%82%E8%BF%B0)了解如何设置公式。</para>
        /// <para>必填：否</para>
        /// <para>示例值：bitable::$table[tblNj92WQBAasdEf].$field[fldMV60rYs]*2</para>
        /// </summary>
        [JsonPropertyName("formula_expression")]
        public string? FormulaExpression { get; set; }

        /// <summary>
        /// <para>条码展示类型字段支持的配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("allowed_edit_modes")]
        public AppTableFieldPropertyAllowedEditModes? AllowedEditModes { get; set; }

        /// <summary>
        /// <para>条码展示类型字段支持的配置</para>
        /// </summary>
        public record AppTableFieldPropertyAllowedEditModes
        {
            /// <summary>
            /// <para>是否允许手动录入。默认为 true</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("manual")]
            public bool? Manual { get; set; }

            /// <summary>
            /// <para>是否允许移动端录入。默认为 true</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("scan")]
            public bool? Scan { get; set; }
        }

        /// <summary>
        /// <para>进度和评分字段的数据范围最小值。不同字段类型中，该参数的必填属性和取值范围不同，详情参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("min")]
        public float? Min { get; set; }

        /// <summary>
        /// <para>进度和评分字段的数据范围最大值。不同字段类型中，该参数的必填属性和取值范围不同，详情参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("max")]
        public float? Max { get; set; }

        /// <summary>
        /// <para>进度字段是否允许自定义进度条值，默认为 false。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("range_customize")]
        public bool? RangeCustomize { get; set; }

        /// <summary>
        /// <para>货币的具体类型，枚举值如下所示：</para>
        /// <para>- CNY：人民币，货币符号为 ¥</para>
        /// <para>- USD：美元，货币符号为 $</para>
        /// <para>- EUR：欧元，货币符号为 €</para>
        /// <para>- GBP：英镑，货币符号为 £</para>
        /// <para>- AED：阿联酋迪拉姆，货币符号为 dh</para>
        /// <para>- AUD：澳大利亚元，货币符号为 $</para>
        /// <para>- BRL：巴西雷亚尔，货币符号为 R$</para>
        /// <para>- CAD：加拿大元，货币符号为 $</para>
        /// <para>- CHF：瑞士法郎，货币符号为 CHF</para>
        /// <para>- HKD：港元，货币符号为 $</para>
        /// <para>- INR：印度卢比，货币符号为 ₹</para>
        /// <para>- IDR：印尼盾，货币符号为 Rp</para>
        /// <para>- JPY：日元，货币符号为 ¥</para>
        /// <para>- KRW：韩元，货币符号为 ₩</para>
        /// <para>- MOP：澳门元，货币符号为 MOP$</para>
        /// <para>- MXN：墨西哥比索，货币符号为 $</para>
        /// <para>- MYR：马来西亚令吉，货币符号为 RM</para>
        /// <para>- PHP：菲律宾比索，货币符号为 ₱</para>
        /// <para>- PLN：波兰兹罗提，货币符号为 zł</para>
        /// <para>- RUB：俄罗斯卢布，货币符号为 ₽</para>
        /// <para>- SGD：新加坡元，货币符号为 $</para>
        /// <para>- THB：泰国铢，货币符号为 ฿</para>
        /// <para>- TRY：土耳其里拉，货币符号为 ₺</para>
        /// <para>- TWD：新台币，货币符号为 NT$</para>
        /// <para>- VND：越南盾，货币符号为 ₫</para>
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
            /// <para>评分的图标，默认为 "star"。枚举值如下所示：</para>
            /// <para>- star：星星</para>
            /// <para>- heart：爱心</para>
            /// <para>- thumbsup：赞</para>
            /// <para>- fire：火</para>
            /// <para>- smile：笑脸</para>
            /// <para>- lightning：闪电</para>
            /// <para>- flower：花</para>
            /// <para>- number：数字</para>
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
            /// <para>公式数据属性信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("ui_property")]
            public AppTableFieldPropertyTypeUiProperty? UiProperty { get; set; }

            /// <summary>
            /// <para>公式数据属性信息</para>
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
        /// <para>是否禁止同步该描述，只在新增、修改字段时生效。枚举值：</para>
        /// <para>- true：表示禁止同步该描述内容到表单的问题描述</para>
        /// <para>- false：允许同步该描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：true</para>
        /// </summary>
        [JsonPropertyName("disable_sync")]
        public bool? DisableSync { get; set; }

        /// <summary>
        /// <para>字段描述内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：这是一个字段描述</para>
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }

    /// <summary>
    /// <para>字段在界面上的展示类型，例如进度字段是数字的一种展示形态。了解更多，参考[字段编辑指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-field/guide)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：Progress</para>
    /// <para>可选值：<list type="bullet">
    /// <item>Text：文本</item>
    /// <item>Email：邮箱地址</item>
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
}
