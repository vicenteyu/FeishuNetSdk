using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 修改用户人脸识别信息 响应体
/// <para>修改授权内员工的用户设置信息，包括人脸照片文件 ID。</para>
/// <para>接口ID：7044467124773404673</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_setting/modify</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_setting%2fmodify</para>
/// </summary>
public record PostAttendanceV1UserSettingsModifyResponseDto
{
    /// <summary>
    /// <para>用户设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_setting")]
    public PostAttendanceV1UserSettingsModifyResponseDtoUserSetting? UserSetting { get; set; }

    /// <summary>
    /// <para>用户设置</para>
    /// </summary>
    public record PostAttendanceV1UserSettingsModifyResponseDtoUserSetting
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>人脸照片文件 ID，获取方式：[文件上传](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/file/upload)</para>
        /// <para>必填：是</para>
        /// <para>示例值：xxxxxb306842b1c189bc5212eefxxxxx</para>
        /// </summary>
        [JsonProperty("face_key")]
        public string FaceKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>人脸照片更新时间，精确到秒的时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625681917</para>
        /// </summary>
        [JsonProperty("face_key_update_time")]
        public string? FaceKeyUpdateTime { get; set; }
    }
}
