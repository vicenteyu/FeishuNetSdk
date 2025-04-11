// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresByPreHireIdTransitTaskBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流转入职任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 流转入职任务 请求体
/// <para>配置入职流程后，可通过本接口流转进行中的任务</para>
/// <para>接口ID：7357756972752732162</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/transit_task</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2ftransit_task</para>
/// </summary>
public record PostCorehrV2PreHiresByPreHireIdTransitTaskBodyDto
{
    /// <summary>
    /// <para>任务标识码。</para>
    /// <para>- 对于系统内置的任务，标识码与任务名称的对应关系如下所示：</para>
    /// <para>&gt; 其中 **创建账户SSO** 为隐藏的任务节点，在 **个人信息** 前自动执行。</para>
    /// <para>- 1：职位信息</para>
    /// <para>- 2：个人信息</para>
    /// <para>- 3：创建账户SSO</para>
    /// <para>- 4：签到</para>
    /// <para>- 9：签署入职文件</para>
    /// <para>- 对于自定义的任务节点（如：3095697a-065f-4627-a47c-46fe958a6754），名称的获取方式如下所示：</para>
    /// <para>1. 通过 `pre_hire_id` 调用[搜索待入职人员信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)接口或[查询待入职](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/query)</para>
    /// <para>2. 查询字段 `fields` 中添加 `onboarding_info.onboarding_task_list`</para>
    /// <para>查询后返回的 onboarding_task_list 结构体中包含标识码和任务名字的对应关系，示例如下所示：</para>
    /// <para>```json</para>
    /// <para>{</para>
    /// <para>"onboarding_task_list": [</para>
    /// <para>{</para>
    /// <para>"task_code": "3095697a-065f-4627-a47c-46fe958a6754",</para>
    /// <para>"task_name": "修改入职日期",</para>
    /// <para>"task_status": "uninitialized"</para>
    /// <para>},</para>
    /// <para>{</para>
    /// <para>"task_code": "d37b9d7c-232d-4a55-98fa-541318234ede",</para>
    /// <para>"task_name": "工签补充任务",</para>
    /// <para>"task_status": "uninitialized"</para>
    /// <para>}</para>
    /// <para>]</para>
    /// <para>}</para>
    /// <para>```</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;
}
