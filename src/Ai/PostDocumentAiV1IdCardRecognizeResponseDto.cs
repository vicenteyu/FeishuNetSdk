// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocumentAiV1IdCardRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的身份证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的身份证 响应体
/// <para>身份证识别接口，支持JPG/JPEG/PNG/BMP四种文件类型的一次性的识别。</para>
/// <para>文件大小需要小于10M。</para>
/// <para>接口ID：7249730096956637187</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/ai/document_ai-v1/id_card/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fid_card%2frecognize</para>
/// </summary>
public record PostDocumentAiV1IdCardRecognizeResponseDto
{
    /// <summary>
    /// <para>身份证信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id_card")]
    public PostDocumentAiV1IdCardRecognizeResponseDtoIdCard? IdCard { get; set; }

    /// <summary>
    /// <para>身份证信息</para>
    /// </summary>
    public record PostDocumentAiV1IdCardRecognizeResponseDtoIdCard
    {
        /// <summary>
        /// <para>识别的实体列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public IdEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别的实体列表</para>
        /// </summary>
        public record IdEntity
        {
            /// <summary>
            /// <para>识别的字段种类</para>
            /// <para>必填：否</para>
            /// <para>示例值：identity_name</para>
            /// <para>可选值：<list type="bullet">
            /// <item>identity_code：公民身份号码</item>
            /// <item>identity_name：姓名</item>
            /// <item>address：住址</item>
            /// <item>valid_date_start：有效期起始时间</item>
            /// <item>valid_date_end：有效期终止时间（“长期”识别为“长期”）</item>
            /// <item>gender：性别</item>
            /// <item>race：民族</item>
            /// <item>issued_by：签发机关</item>
            /// <item>birth：出生日期</item>
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

        /// <summary>
        /// <para>正反面，1为身份证-姓名页，0为身份证-国徽页</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("side")]
        public int? Side { get; set; }

        /// <summary>
        /// <para>四角坐标[x0,y0,x1,y1,x2,y2,x3,y3]</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("conners")]
        public int[]? Conners { get; set; }
    }
}
