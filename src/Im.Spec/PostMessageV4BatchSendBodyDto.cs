// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMessageV4BatchSendBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量发送消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 批量发送消息 请求体
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
public record PostMessageV4BatchSendBodyDto
{
    /// <summary>
    /// <para>消息类型，支持多种消息类型，详见本文“**消息类型及内容示例**”部分</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容，支持除卡片消息外的多种消息内容，详见本文“**消息类型及内容示例**”部分</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("content")]
    public object? Content { get; set; }

    /// <summary>
    /// <para>卡片消息内容</para>
    /// <para>**注意**：card和content字段必须二选一</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("card")]
    public object? Card { get; set; }

    /// <summary>
    /// <para>支持[自定义部门ID](https://open.feishu.cn/document/ukTMukTMukTM/uYTM5UjL2ETO14iNxkTN/terminology#3c3e6267)和open_department_id，列表长度小于等于 200</para>
    /// <para>**注意**：部门下的所有子部门包含的成员也会收到消息</para>
    /// <para>**示例值：**["3dceba33a33226","d502aaa9514059", "od-5b91c9affb665451a16b90b4be367efa"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>用户 open_id 列表，长度小于等于 200；ID获取方式可参考文档：[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>**示例值：**["ou_18eac85d35a26f989317ad4f02e8bbbb","ou_461cf042d9eedaa60d445f26dc747d5e"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_ids")]
    public string[]? OpenIds { get; set; }

    /// <summary>
    /// <para>用户 user_id 列表，长度小于等于 200；ID获取方式可参考文档：[如何获取 User ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id) （对应 V3 接口的 employee_ids ）</para>
    /// <para>**示例值：**["7cdcc7c2","ca51d83b"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>用户 union_ids 列表，长度小于等于 200；ID获取方式可参考文档：[如何获取 Union ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)</para>
    /// <para>**示例值：**["on_cad4860e7af114fb4ff6c5d496d1dd76","on_gdcq860e7af114fb4ff6c5d496dabcet"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("union_ids")]
    public string[]? UnionIds { get; set; }
}
