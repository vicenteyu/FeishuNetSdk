// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1EcoExamsByExamIdLoginInfoBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>回传笔试安排结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 回传笔试安排结果 请求体
/// <para>飞书招聘的笔试服务商，在收到[创建笔试](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/eco_exam/events/created)事件并安排笔试后，应通过本接口</para>
/// <para>回传笔试安排结果。若安排成功，须返回笔试链接；若笔试链接需要登录鉴权，则须返回登录凭证（`username`，`password`)。</para>
/// <para>接口ID：7195815979079401473</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/login_info</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2flogin_info</para>
/// </summary>
public record PostHireV1EcoExamsByExamIdLoginInfoBodyDto
{
    /// <summary>
    /// <para>状态码。</para>
    /// <para>* 0：成功</para>
    /// <para>* 非0：服务商内部的失败错误码</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("result")]
    public int? Result { get; set; }

    /// <summary>
    /// <para>安排成功或失败的描述信息</para>
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
        /// <para>笔试链接。若返回的链接已经附带候选人唯一标识且无需登录鉴权，可只返回此链接</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://xxxx/xxxx/xxxx</para>
        /// </summary>
        [JsonPropertyName("exam_url")]
        public string ExamUrl { get; set; } = string.Empty;

        /// <summary>
        /// <para>登录用户名。</para>
        /// <para>**注意**：若笔试链接需要登录鉴权，须返回此登录凭证</para>
        /// <para>必填：否</para>
        /// <para>示例值：waxsdfbhg</para>
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// <para>登录密码。</para>
        /// <para>**注意**：若笔试链接需要登录鉴权，须返回此登录凭证</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxxxx</para>
        /// </summary>
        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }
}
