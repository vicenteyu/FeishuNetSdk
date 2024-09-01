// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="DriveFileBitableFieldChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>多维表格字段变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 多维表格字段变更 事件体
/// <para>多维表格字段变更事件。被订阅的多维表格字段发生变更时，将会触发此事件。了解事件订阅的配置流程和使用场景，参考[事件概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=drive&amp;version=v1&amp;resource=file&amp;event=bitable_field_changed)</para>
/// <para>接口ID：7152791669179596804</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/event/list/bitable_field_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fevents%2fbitable_field_changed</para>
/// </summary>
public record DriveFileBitableFieldChangedV1EventBodyDto() : EventBodyDto("drive.file.bitable_field_changed_v1")
{
    /// <summary>
    /// <para>云文档类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }

    /// <summary>
    /// <para>多维表格 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>多维表格数据表 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("table_id")]
    public string? TableId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>字段变更操作类型列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("action_list")]
    public BitableTableFieldAction[]? ActionList { get; set; }

    /// <summary></summary>
    public record BitableTableFieldAction
    {
        /// <summary>
        /// <para>字段变更类型。枚举值有：</para>
        /// <para>- field_added：新增字段</para>
        /// <para>- field_edited：修改字段</para>
        /// <para>- field_deleted：删除字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// <para>字段 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("field_id")]
        public string? FieldId { get; set; }

        /// <summary>
        /// <para>操作前的字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("before_value")]
        public BitableTableFieldActionValue? BeforeValue { get; set; }

        /// <summary>
        /// <para>操作后的字段值</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("after_value")]
        public BitableTableFieldActionValue? AfterValue { get; set; }

        /// <summary></summary>
        public record BitableTableFieldActionValue
        {
            /// <summary>
            /// <para>字段 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>字段名字</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>字段类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>字段描述</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>字段属性</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("property")]
            public BitableTableFieldActionValueProperty? Property { get; set; }

            /// <summary></summary>
            public record BitableTableFieldActionValueProperty
            {
                /// <summary>
                /// <para>数字、公式字段的显示格式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("formatter")]
                public string? Formatter { get; set; }

                /// <summary>
                /// <para>日期、创建时间、最后更新时间字段的显示格式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("date_formatter")]
                public string? DateFormatter { get; set; }

                /// <summary>
                /// <para>日期字段中新纪录自动填写创建时间</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("auto_fill")]
                public bool? AutoFill { get; set; }

                /// <summary>
                /// <para>人员字段中允许添加多个成员，单向关联、双向关联中允许添加多个记录</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("multiple")]
                public bool? Multiple { get; set; }

                /// <summary>
                /// <para>单向关联、双向关联字段中关联的数据表的ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("table_id")]
                public string? TableId { get; set; }

                /// <summary>
                /// <para>单向关联、双向关联字段中关联的数据表的名字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("table_name")]
                public string? TableName { get; set; }

                /// <summary>
                /// <para>双向关联字段中关联的数据表中对应的双向关联字段的名字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("back_field_name")]
                public string? BackFieldName { get; set; }

                /// <summary>
                /// <para>地理位置输入限制</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("input_type")]
                public string? InputType { get; set; }

                /// <summary>
                /// <para>双向关联字段中关联的数据表中对应的双向关联字段的id</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("back_field_id")]
                public string? BackFieldId { get; set; }

                /// <summary>
                /// <para>自动编号类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("auto_serial")]
                public BitableTableFieldActionValuePropertyAutoSerial? AutoSerial { get; set; }

                /// <summary></summary>
                public record BitableTableFieldActionValuePropertyAutoSerial
                {
                    /// <summary>
                    /// <para>自动编号类型</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public string? Type { get; set; }

                    /// <summary>
                    /// <para>自动编号规则列表</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("options")]
                    public BitableTableFieldActionValuePropertyAutoSerialOption[]? Options { get; set; }

                    /// <summary></summary>
                    public record BitableTableFieldActionValuePropertyAutoSerialOption
                    {
                        /// <summary>
                        /// <para>自动编号的可选规则项类型</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// <para>与类型相对应的取值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("value")]
                        public string? Value { get; set; }
                    }
                }

                /// <summary>
                /// <para>单选、多选字段的选项信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("options")]
                public BitableTableFieldActionValuePropertyOption[]? Options { get; set; }

                /// <summary></summary>
                public record BitableTableFieldActionValuePropertyOption
                {
                    /// <summary>
                    /// <para>选项名</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }

                    /// <summary>
                    /// <para>选项 ID</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>选项颜色</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("color")]
                    public int? Color { get; set; }
                }

                /// <summary>
                /// <para>公式字段的公式表达式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("formula_expression")]
                public string? FormulaExpression { get; set; }
            }
        }

    }

    /// <summary>
    /// <para>多维表格数据表的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// <para>订阅用户 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscriber_id_list")]
    public UserIdSuffix[]? SubscriberIdList { get; set; }

    /// <summary>
    /// <para>字段变更时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("update_time")]
    public int? UpdateTime { get; set; }
}
