// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrEmploymentCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】创建雇佣信息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】创建雇佣信息 事件体
/// <para>员工雇佣信息被创建时发送该事件，场景举例：</para>
/// <para>- 调用[【创建雇佣信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/create)、[【添加人员】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/create)接口</para>
/// <para>- 人事系统【添加人员】、【导入人员】功能{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=employment&amp;event=created)</para>
/// <para>接口ID：7166916493967818754</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fevents%2fcreated</para>
/// </summary>
public record CorehrEmploymentCreatedV1EventBodyDto() : EventBodyDto("corehr.employment.created_v1")
{
    /// <summary>
    /// <para>被创建的雇佣信息的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_user_id")]
    public UserIdSuffix? TargetUserId { get; set; }
}
