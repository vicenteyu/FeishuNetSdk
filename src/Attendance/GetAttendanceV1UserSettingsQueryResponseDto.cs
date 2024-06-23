// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetAttendanceV1UserSettingsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询用户人脸识别信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 批量查询用户人脸识别信息 响应体
/// <para>批量查询授权内员工的用户设置信息，包括人脸照片文件 ID、人脸照片更新时间。</para>
/// <para>接口ID：7044467124773584897</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_setting%2fquery</para>
/// </summary>
public record GetAttendanceV1UserSettingsQueryResponseDto
{
    /// <summary>
    /// <para>用户设置信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_settings")]
    public UserSetting[]? UserSettings { get; set; }

    /// <summary>
    /// <para>用户设置信息列表</para>
    /// </summary>
    public record UserSetting
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>人脸照片文件 ID，获取方式：[文件上传](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/file/upload)</para>
        /// <para>必填：是</para>
        /// <para>示例值：xxxxxb306842b1c189bc5212eefxxxxx</para>
        /// </summary>
        [JsonPropertyName("face_key")]
        public string FaceKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>人脸照片更新时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625681917</para>
        /// </summary>
        [JsonPropertyName("face_key_update_time")]
        public string? FaceKeyUpdateTime { get; set; }
    }
}
