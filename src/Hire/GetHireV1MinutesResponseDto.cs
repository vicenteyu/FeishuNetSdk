// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-28
//
// Last Modified By : yxr
// Last Modified On : 2024-08-28
// ************************************************************************
// <copyright file="GetHireV1MinutesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取面试速记明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试速记明细 响应体
/// <para>获取指定面试的面试速记明细记录</para>
/// <para>接口ID：7397616200375304220</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/interview/get-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fminutes%2fget</para>
/// </summary>
public record GetHireV1MinutesResponseDto
{
    /// <summary>
    /// <para>面试速记</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("minutes")]
    public GetHireV1MinutesResponseDtoMinutes? Minutes { get; set; }

    /// <summary>
    /// <para>面试速记</para>
    /// </summary>
    public record GetHireV1MinutesResponseDtoMinutes
    {
        /// <summary>
        /// <para>速记句子列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sentences")]
        public Sentence[]? Sentences { get; set; }

        /// <summary>
        /// <para>速记句子列表</para>
        /// </summary>
        public record Sentence
        {
            /// <summary>
            /// <para>速记句子文本</para>
            /// <para>必填：否</para>
            /// <para>示例值：你好，可以做一下自我介绍么？</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>句子开始讲话的时间，毫秒时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1720967514994</para>
            /// </summary>
            [JsonPropertyName("speak_time")]
            public string? SpeakTime { get; set; }

            /// <summary>
            /// <para>句子说话人的用户类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：面试官</item>
            /// <item>2：候选人</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("user_type")]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>句子说话人名字</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("speaker_name")]
            public I18n? SpeakerName { get; set; }

            /// <summary>
            /// <para>句子说话人名字</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>说话人的中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>说话人的英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Zhang San</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：NzM5MTgyNjQyNDY2MDc4OTU0OA==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
