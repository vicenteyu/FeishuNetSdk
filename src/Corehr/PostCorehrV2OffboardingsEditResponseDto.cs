// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-29
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="PostCorehrV2OffboardingsEditResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>编辑离职信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 编辑离职信息 响应体
/// <para>该接口用于编辑飞书人事的[离职信息](https://people.feishu.cn/people/members/dimission/management)，支持的字段包括离职日期、离职原因、离职申请发起时间和离职申请审批通过时间等等，同时也支持编辑离职的自定义字段（附件字段除外）。当接口成功提交后，会产生对应的[离职信息变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/updated)事件。</para>
/// <para>接口ID：7386577676713328643</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/edit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fedit</para>
/// </summary>
public record PostCorehrV2OffboardingsEditResponseDto
{
    /// <summary>
    /// <para>编辑字段数据信息</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("data")]
    public ObjectFieldData[] Datas { get; set; } = Array.Empty<ObjectFieldData>();

    /// <summary>
    /// <para>编辑字段数据信息</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
        /// <para>必填：是</para>
        /// <para>示例值：Sandy</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
