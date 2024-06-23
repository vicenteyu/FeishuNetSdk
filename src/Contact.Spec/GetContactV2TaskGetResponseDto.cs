// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV2TaskGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询批量任务执行状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 查询批量任务执行状态 响应体
/// <para>该接口用于查询通讯录异步任务当前的执行状态以及执行结果。</para>
/// <para>应用商店应用无权限调用此接口。</para>
/// <para>调用该接口需要申请 `更新通讯录` 以及 `以应用身份读取通讯录` 权限。</para>
/// <para>接口ID：6907569745299816450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/query-the-execution-status-of-a-batch-task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDOwUjL1gDM14SN4ATN</para>
/// </summary>
public record GetContactV2TaskGetResponseDto
{
    /// <summary>
    /// <para>异步任务 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>任务类型，目前有两种，添加用户时为 add_user，添加部门时为 add_department。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>任务当前执行状态，小于 9：正在执行过程中，9：执行完成，10：执行失败。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>任务执行进度百分比。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    /// <summary>
    /// <para>任务总条数。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("total_num")]
    public int? TotalNum { get; set; }

    /// <summary>
    /// <para>任务当前执行成功的条数。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("success_num")]
    public int? SuccessNum { get; set; }

    /// <summary>
    /// <para>任务当前执行失败的条数。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("fail_num")]
    public int? FailNum { get; set; }

    /// <summary>
    /// <para>任务创建时间，以秒为单位的 Unix 时间戳。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public int? CreateTime { get; set; }

    /// <summary>
    /// <para>任务完成时间，以秒为单位的 Unix 时间戳，当任务未完成时不返回此字段。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("finish_time")]
    public int? FinishTime { get; set; }

    /// <summary>
    /// <para>任务执行结果列表，当任务非正常执行完成时不返回此字段。</para>
    /// <para>列表中的执行结果顺序和创建任务时请求体中的子任务顺序一致。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_info")]
    public Task[]? TaskInfo { get; set; }

    /// <summary></summary>
    public record Task
    {
        /// <summary>
        /// <para>子任务返回码，非 0 表示失败。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>对子任务返回码的文本描述。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// <para>子任务进行的操作，1：添加，2：更新。子任务执行失败时不返回此字段。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }

        /// <summary>
        /// <para>子任务请求名称，用户操作时为用户名，部门操作时为部门名。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>**以下字段适用于在用户操作时：**</para>
        /// <para>必填：否</para>
        /// </summary>

        /// <summary>
        /// <para>请求时的用户邮箱。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>请求时的用户手机号。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>请求时的用户企业内唯一标识。</para>
        /// <para>当请求时没有填写 user_id 字段并且子任务执行成功时，字段值为系统生成的唯一标识。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>请求时的用户所属部门。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("departments")]
        public string[]? Departments { get; set; }

        /// <summary>
        /// <para>生成的用户 open_id，子任务执行失败时不返回此字段。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>**以下字段适用于在部门操作时：**</para>
        /// <para>必填：否</para>
        /// </summary>

        /// <summary>
        /// <para>请求时的自定义部门 ID。</para>
        /// <para>当请求时没有填写自定义 ID 字段并且子任务执行成功时，字段值为系统生成的部门 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>请求时的父部门 ID。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>部门群 ID，部门群不存在时不返回此字段。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }
    }
}
