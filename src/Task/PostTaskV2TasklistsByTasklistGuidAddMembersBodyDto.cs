// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="PostTaskV2TasklistsByTasklistGuidAddMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>添加清单成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 添加清单成员 请求体
/// <para>向一个清单添加1个或多个协作成员。成员信息通过设置`members`字段实现。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
/// <para>一个清单协作成员可以是一个用户，应用或者群组。每个成员可以设置“可编辑”或者“可阅读”的角色。群组作为协作成员表示该群里所有群成员都自动拥有群组协作成员的角色。</para>
/// <para>如果要添加的成员已经是清单成员，且角色和请求中设置是一样的，则会被自动忽略，接口返回成功。</para>
/// <para>如果要添加的成员已经是清单成员，且角色和请求中设置是不一样的（比如原来的角色是可阅读，请求中设为可编辑），则相当于更新其角色。</para>
/// <para>如果要添加的成员已经是清单的所有者，则会被自动忽略。接口返回成功。其所有者的角色不会改变。</para>
/// <para>本接口不能用来设置清单所有者，如要设置，可以使用[更新清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/patch)接口。</para>
/// <para>接口ID：7255580838154485788</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist/add_members</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fadd_members</para>
/// </summary>
public record PostTaskV2TasklistsByTasklistGuidAddMembersBodyDto
{
    /// <summary>
    /// <para>要添加的成员列表。关于member的格式，详见[功能概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/overview)中的“ 如何表示任务和清单的成员？”章节。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("members")]
    public Member[] Members { get; set; } = [];
}
