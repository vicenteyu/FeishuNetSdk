namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 单行文本
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record InputFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string Value,
        [property: JsonPropertyName("type")] string Type = "input");

    /// <summary>
    /// 多行文本
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record TextareaFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string Value,
        [property: JsonPropertyName("type")] string Type = "textarea");

    /// <summary>
    /// 数字
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record NumberFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string Value,
        [property: JsonPropertyName("type")] string Type = "number");

    /// <summary>
    /// 金额
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Currency">货币</param>
    /// <param name="Type">控件类型</param>
    public record AmountFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] decimal Value,
        [property: JsonPropertyName("currency")] string Currency,
        [property: JsonPropertyName("type")] string Type = "amount");

    /// <summary>
    /// 日期
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record DateFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] DateTime Value,
        [property: JsonPropertyName("type")] string Type = "date");

    /// <summary>
    /// 日期区间
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record DateIntervalFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] DateIntervalFormControl.ValueDto Value,
        [property: JsonPropertyName("type")] string Type = "dateInterval")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="Start">起始时间</param>
        /// <param name="End">结束时间</param>
        /// <param name="Interval">间隔</param>
        public record ValueDto([property: JsonPropertyName("start")] DateTime Start,
            [property: JsonPropertyName("end")] DateTime End,
            [property: JsonPropertyName("interval")] decimal Interval);
    };

    /// <summary>
    /// 计算公式
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record FormulaFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] decimal Value,
        [property: JsonPropertyName("type")] string Type = "formula");

    /// <summary>
    /// 附件
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record AttachmentFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string[] Value,
        [property: JsonPropertyName("type")] string Type = "attachmentV2");

    /// <summary>
    /// 图片
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record ImageFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string[] Value,
        [property: JsonPropertyName("type")] string Type = "image");

    /// <summary>
    /// 联系人
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="OpenIds">OpenId</param>
    /// <param name="Type">控件类型</param>
    public record ContactFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string[] Value,
        [property: JsonPropertyName("open_ids")] string[] OpenIds,
        [property: JsonPropertyName("type")] string Type = "contact");

    /// <summary>
    /// 关联审批
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record ConnectFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string[] Value,
        [property: JsonPropertyName("type")] string Type = "connect");

    /// <summary>
    /// 单选
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record RadioFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string Value,
        [property: JsonPropertyName("type")] string Type = "radioV2");

    /// <summary>
    /// 多选
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record CheckboxFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] string[] Value,
        [property: JsonPropertyName("type")] string Type = "checkboxV2");

    /// <summary>
    /// 明细
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record FieldListFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] FieldListFormControl.ValueDto[][] Value,
        [property: JsonPropertyName("type")] string Type = "fieldList")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="Id">控件ID</param>
        /// <param name="Value">控件值</param>
        /// <param name="Type">控件类型</param>
        public record ValueDto([property: JsonPropertyName("id")] string Id,
            [property: JsonPropertyName("value")] string[] Value,
            [property: JsonPropertyName("type")] string Type);
    }

    /// <summary>
    /// 部门
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record DepartmentFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] DepartmentFormControl.ValueDto[] Value,
        [property: JsonPropertyName("type")] string Type = "department")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="OpenId">控件ID</param>
        public record ValueDto([property: JsonPropertyName("open_id")] string OpenId);
    }

    /// <summary>
    /// 电话
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record TelephoneFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] TelephoneFormControl.ValueDto Value,
        [property: JsonPropertyName("type")] string Type = "telephone")
    {

        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="CountryCode">国家代码</param>
        /// <param name="NationalNumber">电话号码</param>
        public record ValueDto(
            [property: JsonPropertyName("countryCode")] string CountryCode,
            [property: JsonPropertyName("nationalNumber")] string NationalNumber);
    }

    /// <summary>
    /// 换班控件组
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Value">控件值</param>
    /// <param name="Type">控件类型</param>
    public record ShiftGroupFormControl([property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("value")] ShiftGroupFormControl.ValueDto Value,
        [property: JsonPropertyName("type")] string Type = "shiftGroup")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="ShiftTime"></param>
        /// <param name="ReturnTime"></param>
        /// <param name="Reason"></param>
        public record ValueDto(
            [property: JsonPropertyName("shiftTime")] DateTime ShiftTime,
            [property: JsonPropertyName("returnTime")] DateTime ReturnTime,
            [property: JsonPropertyName("reason")] string Reason);
    }

    /// <summary>
    /// 序列化的控件信息
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Name">控件名称</param>
    /// <param name="Type">控件类型</param>
    /// <param name="Value"></param>
    /// <param name="DefaultValueType">控件的默认值类型</param>
    /// <param name="DisplayCondition">控件显隐条件</param>
    /// <param name="EnableDefaultValue">此控件是否启用了默认值</param>
    /// <param name="WidgetDefaultValue">控件的默认值</param>
    /// <param name="Printable">是否允许打印</param>
    /// <param name="Required">是否必填</param>
    /// <param name="Visible">是否可见</param>
    /// <param name="Option"></param>
    /// <param name="Options"></param>
    public record FromControl(
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("type")] string Type,
        [property: JsonPropertyName("value")] string? Value,
        [property: JsonPropertyName("default_value_type")] string DefaultValueType,
        [property: JsonPropertyName("display_condition")] object? DisplayCondition,
        [property: JsonPropertyName("enable_default_value")] bool EnableDefaultValue,
        [property: JsonPropertyName("widget_default_value")] string WidgetDefaultValue,
        [property: JsonPropertyName("printable")] bool Printable,
        [property: JsonPropertyName("required")] bool Required,
        [property: JsonPropertyName("visible")] bool Visible,
        [property: JsonPropertyName("option")] object? Option = null,
        [property: JsonPropertyName("options")] object? Options = null);

}
