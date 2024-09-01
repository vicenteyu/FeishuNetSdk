// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrEmploymentUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】更新雇佣信息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】更新雇佣信息 事件体
/// <para>员工雇佣信息变更时发送该事件，场景举例：</para>
/// <para>- 调用[【更新雇佣信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/patch)接口</para>
/// <para>- 人事系统【编辑工作信息】、【导入编辑人员】功能</para>
/// <para>- 计算字段变更{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=employment&amp;event=updated)</para>
/// <para>接口ID：7166916493967835138</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/employment/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployment%2fevents%2fupdated</para>
/// </summary>
public record CorehrEmploymentUpdatedV1EventBodyDto() : EventBodyDto("corehr.employment.updated_v1")
{
    /// <summary>
    /// <para>被更新的雇佣信息 ID</para>
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

    /// <summary>
    /// <para>发生变更的字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }
}
