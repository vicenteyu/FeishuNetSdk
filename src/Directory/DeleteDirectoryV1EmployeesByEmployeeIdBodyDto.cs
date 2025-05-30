// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="DeleteDirectoryV1EmployeesByEmployeeIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>离职员工 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 离职员工 请求体
/// <para>本接口用于离职员工。</para>
/// <para>接口ID：7359428154233602052</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fdelete</para>
/// </summary>
public record DeleteDirectoryV1EmployeesByEmployeeIdBodyDto
{
    /// <summary>
    /// <para>接口拓展选项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("options")]
    public DeleteEmployeeOptions? Options { get; set; }

    /// <summary>
    /// <para>接口拓展选项</para>
    /// </summary>
    public record DeleteEmployeeOptions
    {
        /// <summary>
        /// <para>离职员工的资源转移方式。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("resigned_employee_resource_receiver")]
        public ResignedUserResouceReceiver? ResignedEmployeeResourceReceiver { get; set; }

        /// <summary>
        /// <para>离职员工的资源转移方式。</para>
        /// </summary>
        public record ResignedUserResouceReceiver
        {
            /// <summary>
            /// <para>部门群接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>被删除用户为部门群群主时，转让群主给指定接收者，不指定接收者则默认转让给群内第一个入群的人。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
            /// </summary>
            [JsonPropertyName("department_chat_acceptor_employee_id")]
            public string? DepartmentChatAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>外部群接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>被删除用户为外部群群主时，转让群主给指定接收者，不指定接收者则默认转让给群内与被删除用户在同一组织的第一个入群的人，如果组织内只有该用户在群里，则解散外部群。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("external_chat_acceptor_employee_id")]
            public string? ExternalChatAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>文档接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其拥有的文档转让给接收者。不指定接收者则将文档资源保留在该用户名下。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("docs_acceptor_employee_id")]
            public string? DocsAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>日程接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其拥有的日程转让给接收者。不指定接收者则将日程资源保留在该用户名下。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("calendar_acceptor_employee_id")]
            public string? CalendarAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>应用接受者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其创建的应用转让给接收者，不指定接收者则保留应用在该用户名下，但该用户无法登录开发者后台进行应用管理，管理员可以在管理后台手动转移应用给其他人。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("application_acceptor_employee_id")]
            public string? ApplicationAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>服务台资源接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其拥有的服务台资源转让给接收者，不指定接收者时保留服务台资源在该用户名下。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("helpdesk_acceptor_employee_id")]
            public string? HelpdeskAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>审批资源接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其拥有的审批资源转让给接收者，不指定接收者时保留审批资源在该用户名下。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("approval_acceptor_employee_id")]
            public string? ApprovalAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>用户邮件资源接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其拥有的邮件资源转让给接收者，不指定接受者则保留邮件资源在该用户名下。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("email_acceptor_employee_id")]
            public string? EmailAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>妙记接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其拥有的妙记资源转让给接收者。如果不指定接收者则将妙记保留在该用户名下。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("minutes_acceptor_employee_id")]
            public string? MinutesAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>飞书问卷接收者。ID值与查询参数中的employee_id_type 对应。</para>
            /// <para>用户被删除时，其拥有的飞书问卷资源转让给接收者，不指定接收者则直接删除飞书问卷资源。</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("survey_acceptor_employee_id")]
            public string? SurveyAcceptorEmployeeId { get; set; }

            /// <summary>
            /// <para>集成平台资源Owner</para>
            /// <para>必填：否</para>
            /// <para>示例值：eehsdna</para>
            /// </summary>
            [JsonPropertyName("anycross_acceptor_employee_id")]
            public string? AnycrossAcceptorEmployeeId { get; set; }
        }
    }
}
