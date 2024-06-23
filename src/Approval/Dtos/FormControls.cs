// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="FormControls.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 审批实例控件抽象类
    /// </summary>
    public abstract record BaseFormControl(string Type)
    {
        /// <summary>
        /// 控件类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; } = Type;

        /// <summary>
        /// 控件ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }

    /// <summary>
    /// 单行文本
    /// </summary>
    /// <param name="Value">控件值</param>
    public record InputFormControl([property: JsonPropertyName("value")] string Value) : BaseFormControl("input");

    /// <summary>
    /// 多行文本
    /// </summary>
    /// <param name="Value">控件值</param>
    public record TextareaFormControl([property: JsonPropertyName("value")] string Value) : BaseFormControl("textarea");

    /// <summary>
    /// 数字
    /// </summary>
    /// <param name="Value">控件值</param>
    public record NumberFormControl([property: JsonPropertyName("value")] string Value) : BaseFormControl("number");

    /// <summary>
    /// 金额
    /// </summary>
    /// <param name="Value">控件值</param>
    /// <param name="Currency">货币</param>
    public record AmountFormControl([property: JsonPropertyName("value")] decimal Value,
        [property: JsonPropertyName("currency")] string Currency) : BaseFormControl("amount");

    /// <summary>
    /// 日期
    /// </summary>
    /// <param name="Value">控件值</param>
    public record DateFormControl([property: JsonPropertyName("value")] DateTime Value) : BaseFormControl("date");

    /// <summary>
    /// 日期区间
    /// </summary>
    /// <param name="Value">控件值</param>
    public record DateIntervalFormControl([property: JsonPropertyName("value")] DateIntervalFormControl.ValueDto Value) : BaseFormControl("dateInterval")
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
    /// <param name="Value">控件值</param>
    public record FormulaFormControl([property: JsonPropertyName("value")] decimal Value) : BaseFormControl("formula");

    /// <summary>
    /// 附件
    /// </summary>
    /// <param name="Value">控件值</param>
    public record AttachmentFormControl([property: JsonPropertyName("value")] string[] Value) : BaseFormControl("attachmentV2");

    /// <summary>
    /// 图片
    /// </summary>
    /// <param name="Value">控件值</param>
    public record ImageFormControl([property: JsonPropertyName("value")] string[] Value) : BaseFormControl("image");

    /// <summary>
    /// 联系人
    /// </summary>
    /// <param name="Value">控件值</param>
    /// <param name="OpenIds">OpenId</param>
    public record ContactFormControl([property: JsonPropertyName("value")] string[] Value,
        [property: JsonPropertyName("open_ids")] string[] OpenIds) : BaseFormControl("contact");

    /// <summary>
    /// 关联审批
    /// </summary>
    /// <param name="Value">控件值</param>
    public record ConnectFormControl([property: JsonPropertyName("value")] string[] Value) : BaseFormControl("connect");

    /// <summary>
    /// 单选
    /// </summary>
    /// <param name="Value">控件值</param>
    public record RadioFormControl([property: JsonPropertyName("value")] string Value) : BaseFormControl("radioV2");

    /// <summary>
    /// 多选
    /// </summary>
    /// <param name="Value">控件值</param>
    public record CheckboxFormControl([property: JsonPropertyName("value")] string[] Value) : BaseFormControl("checkboxV2");

    /// <summary>
    /// 明细
    /// </summary>
    /// <param name="Value">控件值</param>
    public record FieldListFormControl([property: JsonPropertyName("value")] FieldListFormControl.ValueDto[][] Value) : BaseFormControl("fieldList")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="Value">控件值</param>
        /// <param name="Type">控件类型</param>
        public record ValueDto([property: JsonPropertyName("value")] string[] Value, string Type) : BaseFormControl(Type);
    }

    /// <summary>
    /// 部门
    /// </summary>
    /// <param name="Value">控件值</param>
    public record DepartmentFormControl([property: JsonPropertyName("value")] DepartmentFormControl.ValueDto[] Value) : BaseFormControl("department")
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
    /// <param name="Value">控件值</param>
    public record TelephoneFormControl([property: JsonPropertyName("value")] TelephoneFormControl.ValueDto Value) : BaseFormControl("telephone")
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
    /// <param name="Value">控件值</param>
    public record ShiftGroupFormControl([property: JsonPropertyName("value")] ShiftGroupFormControl.ValueDto Value) : BaseFormControl("shiftGroup")
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
