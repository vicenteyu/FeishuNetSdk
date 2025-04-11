// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1TwMainlandTravelPermitRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的台湾居民来往大陆通行证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的台湾居民来往大陆通行证 响应体
/// <para>台湾居民来往大陆通行证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>文件大小需要小于10M。</para>
/// <para>接口ID：7273083612789571587</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/tw_mainland_travel_permit/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2ftw_mainland_travel_permit%2frecognize</para>
/// </summary>
public record PostDocumentAiV1TwMainlandTravelPermitRecognizeResponseDto
{
    /// <summary>
    /// <para>台湾居民来往大陆通行证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tw_mainland_travel_permit")]
    public PostDocumentAiV1TwMainlandTravelPermitRecognizeResponseDtoTwMainlandTravelPermit? TwMainlandTravelPermit { get; set; }

    /// <summary>
    /// <para>台湾居民来往大陆通行证信息</para>
    /// </summary>
    public record PostDocumentAiV1TwMainlandTravelPermitRecognizeResponseDtoTwMainlandTravelPermit
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public TwMainlandTravelPermitEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record TwMainlandTravelPermitEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：full_name_cn</para>
            /// <para>可选值：<list type="bullet">
            /// <item>full_name_cn：中文姓名</item>
            /// <item>full_name_en：英文格式姓名</item>
            /// <item>date_of_birth：出生日期</item>
            /// <item>date_of_expiry：有效期至</item>
            /// <item>card_number：证件号码</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
