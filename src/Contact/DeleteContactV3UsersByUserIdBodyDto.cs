using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 删除用户 请求体
/// <para>该接口用于从通讯录删除一个用户信息，可以理解为员工离职。</para>
/// <para>接口ID：6943913881476907035</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fdelete</para>
/// </summary>
public record DeleteContactV3UsersByUserIdBodyDto
{
    /// <summary>
    /// <para>部门群接收者。被删除用户为部门群群主时，转让群主给指定接收者，不指定接收者则默认转让给群内第一个入群的人</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("department_chat_acceptor_user_id")]
    public string? DepartmentChatAcceptorUserId { get; set; }

    /// <summary>
    /// <para>外部群接收者。被删除用户为外部群群主时，转让群主给指定接收者，不指定接收者则默认转让给群内与被删除用户在同一组织的第一个入群的人，如果组织内只有该用户在群里，则解散外部群</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("external_chat_acceptor_user_id")]
    public string? ExternalChatAcceptorUserId { get; set; }

    /// <summary>
    /// <para>文档接收者。用户被删除时，其拥有的文档转让给接收者。不指定接收者则默认转让给直属上级，如果无直属上级则将文档资源保留在该用户名下。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("docs_acceptor_user_id")]
    public string? DocsAcceptorUserId { get; set; }

    /// <summary>
    /// <para>日程接收者。用户被删除时，其拥有的日程转让给接收者，不指定接收者则默认转让给直属上级，如果无直属上级则直接删除日程资源。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("calendar_acceptor_user_id")]
    public string? CalendarAcceptorUserId { get; set; }

    /// <summary>
    /// <para>应用接受者。用户被删除时，其创建的应用转让给接收者，不指定接收者则默认转让给直属上级。如果无直属上级则保留应用在该用户名下，但该用户无法登录开发者后台进行应用管理，管理员可以在管理后台手动转移应用给其他人。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("application_acceptor_user_id")]
    public string? ApplicationAcceptorUserId { get; set; }

    /// <summary>
    /// <para>妙记接收者。用户被删除时，其拥有的妙记资源转让给接收者。如果不指定接收者，则默认转让给直属上级。如果无直属上级则将妙记保留在该用户名下。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("minutes_acceptor_user_id")]
    public string? MinutesAcceptorUserId { get; set; }

    /// <summary>
    /// <para>飞书问卷接收者。用户被删除时，其拥有的飞书问卷资源转让给接收者，不指定接收者则默认转让给直属上级，如果无直属上级则直接删除飞书问卷资源。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("survey_acceptor_user_id")]
    public string? SurveyAcceptorUserId { get; set; }

    /// <summary>
    /// <para>用户邮件资源处理方式。用户被删除时，根据传递的操作指令对其拥有的邮件资源做对应处理。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("email_acceptor")]
    public ResourceAcceptor? EmailAcceptor { get; set; }

    /// <summary>
    /// <para>用户邮件资源处理方式。用户被删除时，根据传递的操作指令对其拥有的邮件资源做对应处理。</para>
    /// </summary>
    public record ResourceAcceptor
    {
        /// <summary>
        /// <para>邮件处理方式。如果未传值，则默认将邮件资源转让给直属上级，如果无直属上级则保留邮件资源在该用户名下。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：转移资源</item>
        /// <item>2：保留资源</item>
        /// <item>3：删除资源</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("processing_type")]
        public string ProcessingType { get; set; } = string.Empty;

        /// <summary>
        /// <para>在 processing_type 为 1 （转移资源时），邮件资源接收者</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonProperty("acceptor_user_id")]
        public string? AcceptorUserId { get; set; }
    }
}
