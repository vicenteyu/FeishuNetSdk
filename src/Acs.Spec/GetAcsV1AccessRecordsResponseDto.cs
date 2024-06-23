// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetAcsV1AccessRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取门禁记录列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs.Spec;
/// <summary>
/// 获取门禁记录列表 响应体
/// <para>用户在门禁考勤机上成功开门或打卡后，智能门禁应用都会生成一条门禁记录。</para>
/// <para>该接口返回满足查询参数的识别记录。</para>
/// <para>接口ID：6979790924691996674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/access_record/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2faccess_record%2flist</para>
/// </summary>
public record GetAcsV1AccessRecordsResponseDto
{
    /// <summary>
    /// <para>-</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AccessRecord[]? Items { get; set; }

    /// <summary></summary>
    public record AccessRecord
    {
        /// <summary>
        /// <para>门禁记录 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("access_record_id")]
        public string? AccessRecordId { get; set; }

        /// <summary>
        /// <para>门禁记录所属用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>门禁设备 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("device_id")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// <para>是否是打卡</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_clock_in")]
        public bool? IsClockIn { get; set; }

        /// <summary>
        /// <para>访问时间，单位秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("access_time")]
        public string? AccessTime { get; set; }

        /// <summary>
        /// <para>识别方式</para>
        /// <para>**可选值有**：</para>
        /// <para>FA:人脸识别方式</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>FA：人脸识别方式</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("access_type")]
        public string? AccessType { get; set; }

        /// <summary>
        /// <para>识别相关数据，根据 access_type 不同，取值不同</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("access_data")]
        public string? AccessData { get; set; }

        /// <summary>
        /// <para>是否开门</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_door_open")]
        public bool? IsDoorOpen { get; set; }

        /// <summary>
        /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// <para>是否还有更多项</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }
    }
}
