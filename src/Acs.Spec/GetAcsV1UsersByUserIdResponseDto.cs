using Newtonsoft.Json;
namespace FeishuNetSdk.Acs.Spec;
/// <summary>
/// 获取单个用户信息 响应体
/// <para>该接口用于获取智能门禁中单个用户的信息。</para>
/// <para>接口ID：6987691292973875201</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2fget</para>
/// </summary>
public record GetAcsV1UsersByUserIdResponseDto
{
    /// <summary>
    /// <para>门禁用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user")]
    public UserSuffix? User { get; set; }

    /// <summary></summary>
    public record UserSuffix
    {
        /// <summary>
        /// <para>用户特征</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("feature")]
        public FeatureSuffix? Feature { get; set; }

        /// <summary></summary>
        public record FeatureSuffix
        {
            /// <summary>
            /// <para>卡号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("card")]
            public int? Card { get; set; }

            /// <summary>
            /// <para>是否已上传人脸图片</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("face_uploaded")]
            public bool? FaceUploaded { get; set; }
        }

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}
