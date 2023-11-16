namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 批量发送消息 响应体
/// <para>给多个用户或者多个部门中的成员发送消息。</para>
/// <para>**注意事项：**</para>
/// <para>- 应用需要启用[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)</para>
/// <para>- 接口权限说明：</para>
/// <para> - 必须拥有**获取与发送单聊、群组消息**权限，或者**以应用的身份发消息**权限</para>
/// <para> - 至少拥有一个批量发送消息权限：</para>
/// <para> - 给用户发送需要拥有 **给多个用户批量发消息** 权限</para>
/// <para> - 给部门成员发送需要拥有 **给一个或多个部门的成员批量发消息** 权限</para>
/// <para>- 应用需要拥有对所发送用户或部门的[可用性](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)</para>
/// <para>- 通过该接口发送的消息 **不支持更新以及回复等操作**</para>
/// <para>- 只能发送给用户，无法发送给群组</para>
/// <para>- 异步接口，会有一定延迟，每个应用待发送的消息按顺序处理，请合理安排批量发送范围和顺序。发送消息给单个用户的场景请使用[发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)接口</para>
/// <para>- 单个应用每天通过该接口发送的总消息条数不超过50万</para>
/// <para>接口ID：6907569743419555842</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/send-messages-in-batches</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDO1EjL3gTNx4yN4UTM</para>
/// </summary>
public record PostMessageV4BatchSendResponseDto
{
    /// <summary>
    /// <para>批量消息任务 ID，用于唯一标识一个批量发送消息的任务</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;

    /// <summary>
    /// <para>不合法的部门 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_department_ids")]
    public string[]? InvalidDepartmentIds { get; set; }

    /// <summary>
    /// <para>不合法的 open_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_open_ids")]
    public string[]? InvalidOpenIds { get; set; }

    /// <summary>
    /// <para>不合法的 user_id 列表（对应V3接口的invalid_employee_ids）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_user_ids")]
    public string[]? InvalidUserIds { get; set; }

    /// <summary>
    /// <para>不合法的 union_id 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("invalid_union_ids")]
    public string[]? InvalidUnionIds { get; set; }
}
