using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单位信息 响应体
/// <para>该接口用于获取单位信息。</para>
/// <para>接口ID：7023995901275291651</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fget</para>
/// </summary>
public record GetContactV3UnitByUnitIdResponseDto
{
    /// <summary>
    /// <para>单位信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("unit")]
    public GetContactV3UnitByUnitIdResponseDtoUnit Unit { get; set; } = new();

    /// <summary>
    /// <para>单位信息</para>
    /// </summary>
    public record GetContactV3UnitByUnitIdResponseDtoUnit
    {
        /// <summary>
        /// <para>单位ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：BU121</para>
        /// </summary>
        [JsonProperty("unit_id")]
        public string UnitId { get; set; } = string.Empty;

        /// <summary>
        /// <para>单位的名字</para>
        /// <para>必填：是</para>
        /// <para>示例值：消费者事业部</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>单位的类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：事业部</para>
        /// </summary>
        [JsonProperty("unit_type")]
        public string UnitType { get; set; } = string.Empty;
    }
}
