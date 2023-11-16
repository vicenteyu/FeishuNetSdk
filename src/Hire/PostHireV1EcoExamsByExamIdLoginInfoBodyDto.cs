namespace FeishuNetSdk.Hire;
/// <summary>
/// 回传笔试安排结果 请求体
/// <para>回传笔试安排结果，如果安排成功需返回笔试链接和登录凭证</para>
/// <para>接口ID：7195815979079401473</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/login_info</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2flogin_info</para>
/// </summary>
public record PostHireV1EcoExamsByExamIdLoginInfoBodyDto
{
    /// <summary>
    /// <para>状态码，0-成功 非零-错误码</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("result")]
    public int? Result { get; set; }

    /// <summary>
    /// <para>成功或失败的描述信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：success</para>
    /// </summary>
    [JsonPropertyName("msg")]
    public string? Msg { get; set; }

    /// <summary>
    /// <para>笔试作答信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("exam_login_info")]
    public EcoExamLoginInfo ExamLoginInfo { get; set; } = new();

    /// <summary>
    /// <para>笔试作答信息</para>
    /// </summary>
    public record EcoExamLoginInfo
    {
        /// <summary>
        /// <para>笔试链接。如果返回的链接是附带候选人唯一标识且无需登录鉴权的，可只返回此地址</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://xxxx/xxxx/xxxx</para>
        /// </summary>
        [JsonPropertyName("exam_url")]
        public string ExamUrl { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户名</para>
        /// <para>必填：否</para>
        /// <para>示例值：waxsdfbhg</para>
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// <para>密码</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxxx</para>
        /// </summary>
        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }
}
