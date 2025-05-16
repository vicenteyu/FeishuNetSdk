namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 单向或双向关联的记录
/// </summary>
/// <param name="LinkRecordIds">关联的记录 ID，array 类型，可包含多个记录 ID 字符串。</param>
public record LinkRecord(
    [property: JsonPropertyName("link_record_ids")] string[] LinkRecordIds) : IBitableRecord;
