// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="PostCorehrV2SeverancePaysEditBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>编辑被动解除补偿金信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 编辑被动解除补偿金信息 请求体
/// <para>该接口用于编辑已创建的被动解除补偿金记录。调用方需要传入补偿金记录 ID 和待更新字段列表，字段名使用补偿金对象字段 APIName。</para>
/// <para>接口ID：7667872540325759962</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fedit</para>
/// </summary>
public record PostCorehrV2SeverancePaysEditBodyDto
{
    /// <summary>
    /// <para>补偿金/被动解除业务单 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7660423757252773420</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("severance_pay_id")]
    public string SeverancePayId { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作人雇佣 ID，为空默认为系统操作。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7659617611689510444</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>编辑字段数据信息</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("update_data")]
    public ObjectFieldData[] UpdateDatas { get; set; } = [];

    /// <summary>
    /// <para>编辑字段数据信息</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
        /// <para>必填：是</para>
        /// <para>示例值：Sandy</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
