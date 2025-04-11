// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1DrivingLicenseRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的驾驶证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的驾驶证 响应体
/// <para>驾驶证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>文件大小需要小于10M。</para>
/// <para>接口ID：7249730096956653571</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/driving_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fdriving_license%2frecognize</para>
/// </summary>
public record PostDocumentAiV1DrivingLicenseRecognizeResponseDto
{
    /// <summary>
    /// <para>驾驶证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("driving_license")]
    public DrvingLicense? DrivingLicense { get; set; }

    /// <summary>
    /// <para>驾驶证信息</para>
    /// </summary>
    public record DrvingLicense
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public DrivingEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record DrivingEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：name</para>
            /// <para>可选值：<list type="bullet">
            /// <item>id_number：证号</item>
            /// <item>name：姓名</item>
            /// <item>sex：性别</item>
            /// <item>nationality：国籍</item>
            /// <item>address：住址</item>
            /// <item>date_of_birth：出生日期</item>
            /// <item>date_of_first_issue：初次领证日期</item>
            /// <item>class：准驾车型</item>
            /// <item>valid_begin：有效期起</item>
            /// <item>valid_end：有效期止</item>
            /// <item>license_issuing_authority：发证机关</item>
            /// <item>document_id：档案编号</item>
            /// <item>record：记录</item>
            /// <item>id_photo_location：相片位置</item>
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
