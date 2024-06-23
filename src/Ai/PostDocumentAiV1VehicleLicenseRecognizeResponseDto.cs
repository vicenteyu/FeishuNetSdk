// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1VehicleLicenseRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的行驶证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的行驶证 响应体
/// <para>行驶证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>接口ID：7249730096956669955</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/vehicle_license/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fvehicle_license%2frecognize</para>
/// </summary>
public record PostDocumentAiV1VehicleLicenseRecognizeResponseDto
{
    /// <summary>
    /// <para>行驶证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("vehicle_license")]
    public PostDocumentAiV1VehicleLicenseRecognizeResponseDtoVehicleLicense? VehicleLicense { get; set; }

    /// <summary>
    /// <para>行驶证信息</para>
    /// </summary>
    public record PostDocumentAiV1VehicleLicenseRecognizeResponseDtoVehicleLicense
    {
        /// <summary>
        /// <para>识别出的实体类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public VehicleEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体类型</para>
        /// </summary>
        public record VehicleEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：vehicle_type</para>
            /// <para>可选值：<list type="bullet">
            /// <item>plate_number：号牌号码</item>
            /// <item>vehicle_type：车辆类型</item>
            /// <item>owner：所有人</item>
            /// <item>address：住址</item>
            /// <item>use_character：使用性质</item>
            /// <item>model：品牌型号</item>
            /// <item>vin：车辆识别代号</item>
            /// <item>engine_number：发动机号码</item>
            /// <item>register_date：注册日期</item>
            /// <item>issue_date：发证日期</item>
            /// <item>license_issuing_authority：发证机关</item>
            /// <item>document_id：档案编号</item>
            /// <item>approved_passengers_capacity：核定载人数</item>
            /// <item>total_mass：总质量</item>
            /// <item>curb_weight：整备质量</item>
            /// <item>ratified_load_capacity：核定载质量</item>
            /// <item>gabarite：外廓尺寸</item>
            /// <item>traction_mass：准牵引总质量</item>
            /// <item>remarks：备注</item>
            /// <item>inspection_record：检验记录</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：小型普通客车</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }
    }
}
