// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-09-20
// ************************************************************************
// <copyright file="DeleteContactV3UsersByUserIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除用户 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 删除用户 请求体
/// <para>调用该接口从通讯录内删除一个指定用户（该动作可以理解为员工离职），删除时可通过请求参数将用户所有的群组、文档、日程和应用等数据转让至他人。</para>
/// <para>## 注意事项</para>
/// <para>- 调用该接口的应用的[通讯录权限范围](https://open.feishu.cn/document/ukTMukTMukTM/uETNz4SM1MjLxUzM/v3/guides/scope_authority)必须包含用户所属的部门。例如，待删除用户归属部门 A、部门 B，则应用的通讯录权限范围必须包括部门 A 和部门 B，这样才可以成功删除用户。</para>
/// <para>- 删除用户后，你可以调用[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)接口，通过用户 ID 查询用户的状态（响应参数 status），从而确保用户已成功删除（对应已离职状态）。</para>
/// <para>接口ID：6943913881476907035</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/user/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fdelete</para>
/// </summary>
public record DeleteContactV3UsersByUserIdBodyDto
{
    /// <summary>
    /// <para>部门群接收者的用户 ID。被删除用户为部门群群主时，转让群主给指定接收者。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 不指定该参数时，如果被删除用户是部门群群主，则群主会默认转让给群内第一个入群的人。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("department_chat_acceptor_user_id")]
    public string? DepartmentChatAcceptorUserId { get; set; }

    /// <summary>
    /// <para>外部群接收者的用户 ID。被删除用户为外部群群主时，转让群主给指定接收者。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 不指定该参数时，如果被删除用户是外部群群主，则群主会默认转让给群内与被删除用户在同一组织的第一个入群的人。如果组织内只有被删除用户在群里，则解散外部群。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("external_chat_acceptor_user_id")]
    public string? ExternalChatAcceptorUserId { get; set; }

    /// <summary>
    /// <para>文档接收者的用户 ID。用户被删除时，其拥有的文档转让给接收者。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 不指定接收者则默认转让给被删除用户的直属上级。如果被删除用户无直属上级，则将文档资源保留在该用户名下。</para>
    /// <para>- 文档转让后，只改变文档所有者，其他权限不受影响。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("docs_acceptor_user_id")]
    public string? DocsAcceptorUserId { get; set; }

    /// <summary>
    /// <para>日程接收者的用户 ID。用户被删除时，其拥有的日程转让给接收者。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 不指定接收者则默认转让给被删除用户的直属上级。如果被删除用户无直属上级，则直接删除日程资源。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("calendar_acceptor_user_id")]
    public string? CalendarAcceptorUserId { get; set; }

    /// <summary>
    /// <para>应用接受者的用户 ID。用户被删除时，其创建的应用转让给接收者。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 不指定接收者则默认转让给被删除用户的直属上级。如果被删除用户无直属上级，则保留应用在该用户名下，但该用户无法登录开发者后台进行应用管理。企业管理员可以在管理后台手动转移应用给其他人。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("application_acceptor_user_id")]
    public string? ApplicationAcceptorUserId { get; set; }

    /// <summary>
    /// <para>妙记接收者的用户 ID。用户被删除时，其拥有的妙记资源转让给接收者。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 如果不指定接收者，则默认转让给被删除用户的直属上级。如果被删除用户无直属上级，则将妙记保留在该用户名下。</para>
    /// <para>- 妙记转让后，只改变妙记所有者，不影响已分享的妙记链接。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("minutes_acceptor_user_id")]
    public string? MinutesAcceptorUserId { get; set; }

    /// <summary>
    /// <para>飞书问卷接收者的用户 ID。用户被删除时，其拥有的飞书问卷资源转让给接收者。</para>
    /// <para>**注意**：</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 不指定接收者则默认转让给被删除用户的直属上级。如果被删除用户无直属上级，则直接删除飞书问卷资源。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("survey_acceptor_user_id")]
    public string? SurveyAcceptorUserId { get; set; }

    /// <summary>
    /// <para>用户邮件资源的处理方式。</para>
    /// <para>该参数为可选参数，如果未传值，则默认将邮件资源转让给被删除用户的直属上级。如果被删除用户无直属上级，则保留邮件资源在该用户名下。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("email_acceptor")]
    public ResourceAcceptor? EmailAcceptor { get; set; }

    /// <summary>
    /// <para>用户邮件资源的处理方式。</para>
    /// <para>该参数为可选参数，如果未传值，则默认将邮件资源转让给被删除用户的直属上级。如果被删除用户无直属上级，则保留邮件资源在该用户名下。</para>
    /// </summary>
    public record ResourceAcceptor
    {
        /// <summary>
        /// <para>处理方式。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：转移资源</item>
        /// <item>2：保留资源</item>
        /// <item>3：删除资源</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("processing_type")]
        public string ProcessingType { get; set; } = string.Empty;

        /// <summary>
        /// <para>邮件资源接收者的用户 ID。ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
        /// <para>**说明**：仅当 `processing_type` 取值为 `1` 时，需要设置该参数值。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("acceptor_user_id")]
        public string? AcceptorUserId { get; set; }
    }

    /// <summary>
    /// <para>用户集成平台资源的接收者的用户 ID。</para>
    /// <para>**注意：**</para>
    /// <para>- ID 类型需要与查询参数中的 user_id_type 类型保持一致。用户 ID 获取方式可参见[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>- 不指定接收者则默认转让给被删除用户的直属上级。如果被删除用户无直属上级，则保留应用在该用户名下，但该用户无法登录飞书集成平台。企业管理员可以在管理后台手动转移应用给其他人。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("anycross_acceptor_user_id")]
    public string? AnycrossAcceptorUserId { get; set; }
}
