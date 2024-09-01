// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrPersonUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】更新个人信息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】更新个人信息 事件体
/// <para>员工个人信息发生变更时发送该事件，场景举例：</para>
/// <para>- 调用[【更新个人信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/person/patch)接口</para>
/// <para>- 人事系统【编辑个人信息】、【导入编辑人员】功能</para>
/// <para>- 计算字段变更</para>
/// <para>注：籍贯、政治面貌、户口类型、户口所在地变化不会触发该事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=person&amp;event=updated)</para>
/// <para>接口ID：7125370197952036868</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fevents%2fupdated</para>
/// </summary>
public record CorehrPersonUpdatedV1EventBodyDto() : EventBodyDto("corehr.person.updated_v1")
{
    /// <summary>
    /// <para>被更新个人信息的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("person_id")]
    public string? PersonId { get; set; }

    /// <summary>
    /// <para>发生变更的字段，若部分字段变更无需接受事件消息，可根据该字段进行事件消息过滤</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }
}
