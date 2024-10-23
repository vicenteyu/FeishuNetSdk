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
/// <para>接口ID：6907569743419555842</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/send-messages-in-batches</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fucDO1EjL3gTNx4yN4UTM</para>
/// </summary>
public record PostMessageV4BatchSendBodyDto
{
    /// <summary>
    /// <para>消息类型。支持的消息类型有：</para>
    /// <para>- text：文本</para>
    /// <para>- image：图片</para>
    /// <para>- post：富文本</para>
    /// <para>- share_chat：分享群名片</para>
    /// <para>- interactive：卡片</para>
    /// <para>**注意**：</para>
    /// <para>- 如果 `msg_type` 取值为 text、image、post 或者 share_chat，则消息内容需要传入 `content` 参数内。</para>
    /// <para>- 如果 `msg_type` 取值为 interactive，则消息内容需要传入 `card` 参数内。</para>
    /// <para>- 富文本类型（post）的消息，不支持使用 `md` 标签。</para>
    /// <para>各类型的内容如何配置，参见[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)，但需要确保符合当前接口的要求。例如，仅支持以上 5 种消息类型、批量发送富文本消息时不支持 `md` 标签等。</para>
    /// <para>**示例值**：text</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容，JSON 结构。该参数的取值与 `msg_type` 对应，例如 `msg_type` 取值为 `text`，则该参数需要传入文本类型的内容。</para>
    /// <para>**注意：**</para>
    /// <para>- 该参数仅在 `msg_type` 取值为 text、image、post 或者 share_chat 时需要传入值。如果 `msg_type` 取值为 interactive，则消息内容需要传入到 `card` 参数。</para>
    /// <para>- 文本消息请求体最大不能超过 150 KB。</para>
    /// <para>- 富文本消息请求体最大不能超过 30 KB。</para>
    /// <para>- 文本消息（text）仅在该接口中不支持加粗、斜体、下划线、删除线样式。</para>
    /// <para>- 如果消息中包含样式标签，会使实际消息体长度大于您输入的请求体长度。</para>
    /// <para>- 图片需要先[上传图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/create)，然后使用图片的 Key 发消息。</para>
    /// <para>- 该接口直接传入 JSON 结构的消息内容即可，无需进行转义。</para>
    /// <para>了解各类型消息的内容格式、使用限制，可参见[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)。</para>
    /// <para>**示例值**：{ "text": "要发送的文本消息" }</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("content")]
    public object? Content { get; set; }

    /// <summary>
    /// <para>卡片内容，JSON 结构。</para>
    /// <para>**注意**：</para>
    /// <para>- 该参数的取值与 `msg_type` 对应，仅当 `msg_type` 取值为 interactive 时，需要将卡片内容传入当前参数。当 `msg_type` 取值不为 interactive 时，消息内容需要传入到 `content` 参数。</para>
    /// <para>- 卡片消息请求体最大不能超过 30 KB。</para>
    /// <para>- 如果使用卡片模板（template_id）发送消息，实际大小也包含模板对应的卡片数据大小。</para>
    /// <para>- 该接口直接传入 JSON 结构的消息内容即可，无需进行转义。了解更多参见[发送卡片](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/send-feishu-card)。</para>
    /// <para>**示例值**：{"elements":[{"tag":"div","text":{"content":"This is the plain text","tag":"plain_text"}}],"header":{"template":"blue","title":{"content":"This is the title","tag":"plain_text"}}}</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("card")]
    public object? Card { get; set; }

    /// <summary>
    /// <para>部门 ID 列表。列表内支持传入部门 department_id 和 open_department_id，部门 ID 介绍与获取方式，参见[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)的 **部门 ID** 章节。</para>
    /// <para>**注意**：</para>
    /// <para>- 列表长度不能超过 200。</para>
    /// <para>- 请求时，消息会发送给 ID 对应部门内的所有成员，包括部门下的所有子部门成员。</para>
    /// <para>- `department_ids`、`open_ids`、`user_ids`、`union_ids` 四个字段至少需要填写其中一个。</para>
    /// <para>**示例值**：["3dceba33a33226","d502aaa9514059", "od-5b91c9affb665451a16b90b4be367efa"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>用户 open_id 列表。open_id 获取方式参见[如何获取自己的 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>**注意**：</para>
    /// <para>- 列表长度不能超过 200。</para>
    /// <para>- `department_ids`、`open_ids`、`user_ids`、`union_ids` 四个字段至少需要填写其中一个。</para>
    /// <para>**示例值**：["ou_18eac85d35a26f989317ad4f02e8bbbb","ou_461cf042d9eedaa60d445f26dc747d5e"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_ids")]
    public string[]? OpenIds { get; set; }

    /// <summary>
    /// <para>用户 user_id 列表。user_id 获取方式参见[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>**注意**：</para>
    /// <para>- 列表长度不能超过 200。</para>
    /// <para>- `department_ids`、`open_ids`、`user_ids`、`union_ids` 四个字段至少需要填写其中一个。</para>
    /// <para>**示例值**：["7cdcc7c2","ca51d83b"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>用户 union_id 列表。union_id 获取方式参见[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
    /// <para>**注意**：</para>
    /// <para>- 列表长度不能超过 200。</para>
    /// <para>- `department_ids`、`open_ids`、`user_ids`、`union_ids` 四个字段至少需要填写其中一个。</para>
    /// <para>**示例值**：["on_cad4860e7af114fb4ff6c5d496d1dd76","on_gdcq860e7af114fb4ff6c5d496dabcet"]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("union_ids")]
    public string[]? UnionIds { get; set; }
}
