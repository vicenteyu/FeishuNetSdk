// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrEmploymentDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】删除雇佣信息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】删除雇佣信息 事件体
/// <para>员工在飞书人事的「雇佣信息被删除」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=employment&amp;event=deleted)</para>
/// <para>接口ID：7166916493967802370</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fevents%2fdeleted</para>
/// </summary>
public record CorehrEmploymentDeletedV1EventBodyDto() : EventBodyDto("corehr.employment.deleted_v1")
{
    /// <summary>
    /// <para>被删除的雇佣信息的 ID</para>
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
