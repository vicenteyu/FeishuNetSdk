namespace FeishuNetSdk.Base;
/// <summary>
/// 检索视图 响应体
/// <para>该接口根据 view_id 检索现有视图</para>
/// <para>接口ID：7177650713441845251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fget</para>
/// </summary>
public record GetBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdResponseDto
{
    /// <summary>
    /// <para>视图信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("view")]
    public AppTableView? View { get; set; }

    /// <summary>
    /// <para>视图信息</para>
    /// </summary>
    public record AppTableView
    {
        /// <summary>
        /// <para>视图Id</para>
        /// <para>必填：否</para>
        /// <para>示例值：vewieWxfON</para>
        /// </summary>
        [JsonPropertyName("view_id")]
        public string? ViewId { get; set; }

        /// <summary>
        /// <para>视图名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：表格 1</para>
        /// </summary>
        [JsonPropertyName("view_name")]
        public string? ViewName { get; set; }

        /// <summary>
        /// <para>视图类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：grid</para>
        /// </summary>
        [JsonPropertyName("view_type")]
        public string? ViewType { get; set; }

        /// <summary>
        /// <para>视图属性</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("property")]
        public AppTableViewProperty? Property { get; set; }

        /// <summary>
        /// <para>视图属性</para>
        /// </summary>
        public record AppTableViewProperty
        {
            /// <summary>
            /// <para>过滤条件</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("filter_info")]
            public AppTableViewPropertyFilterInfo? FilterInfo { get; set; }

            /// <summary>
            /// <para>过滤条件</para>
            /// </summary>
            public record AppTableViewPropertyFilterInfo
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
                public AppTableViewPropertyFilterInfoCondition[] Conditions { get; set; } = Array.Empty<AppTableViewPropertyFilterInfoCondition>();

                /// <summary>
                /// <para>筛选条件</para>
                /// </summary>
                public record AppTableViewPropertyFilterInfoCondition
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
                    /// <para>1：多行文本</para>
                    /// <para>2：数字</para>
                    /// <para>3：单选</para>
                    /// <para>4：多选</para>
                    /// <para>5：日期</para>
                    /// <para>7：复选框</para>
                    /// <para>11：人员</para>
                    /// <para>13：电话号码</para>
                    /// <para>15：超链接</para>
                    /// <para>17：附件</para>
                    /// <para>18：单向关联</para>
                    /// <para>19：查找引用</para>
                    /// <para>20：公式</para>
                    /// <para>21：双向关联</para>
                    /// <para>22：地理位置</para>
                    /// <para>23：群组</para>
                    /// <para>1001：创建时间</para>
                    /// <para>1002：最后更新时间</para>
                    /// <para>1003：创建人</para>
                    /// <para>1004：修改人</para>
                    /// <para>1005：自动编号</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：3</para>
                    /// </summary>
                    [JsonPropertyName("field_type")]
                    public int? FieldType { get; set; }
                }

                /// <summary>
                /// <para>筛选条件是否缺省</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("condition_omitted")]
                public bool? ConditionOmitted { get; set; }
            }

            /// <summary>
            /// <para>隐藏字段ID列表</para>
            /// <para>必填：否</para>
            /// <para>示例值：["fldCGzANXx", "fldCGzANXx"]</para>
            /// <para>最大长度：300</para>
            /// </summary>
            [JsonPropertyName("hidden_fields")]
            public string[]? HiddenFields { get; set; }

            /// <summary>
            /// <para>表格视图层级结构设置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("hierarchy_config")]
            public AppTableViewPropertyHierarchyConfig? HierarchyConfig { get; set; }

            /// <summary>
            /// <para>表格视图层级结构设置</para>
            /// </summary>
            public record AppTableViewPropertyHierarchyConfig
            {
                /// <summary>
                /// <para>层级结构的关联列id</para>
                /// <para>必填：否</para>
                /// <para>示例值：fldTca**hb</para>
                /// </summary>
                [JsonPropertyName("field_id")]
                public string? FieldId { get; set; }
            }
        }
    }
}
