namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 公式或查找引用类型的记录
/// </summary>
/// <param name="Type">用于指定 value 的数据类型</param>
/// <param name="Value">type 字段决定 value 的数据结构，可参考本文档中 value 的结构。</param>
public record FormulaRecord(
    [property: JsonPropertyName("type")] int Type,
    [property: JsonPropertyName("value")] object Value) : IBitableRecord;
