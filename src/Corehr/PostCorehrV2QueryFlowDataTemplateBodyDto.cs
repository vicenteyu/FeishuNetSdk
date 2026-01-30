// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-30
//
// Last Modified By : yxr
// Last Modified On : 2026-01-30
// ************************************************************************
// <copyright file="PostCorehrV2QueryFlowDataTemplateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询流程数据参数模板 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询流程数据参数模板 请求体
/// <para>通过传入流程定义 ID 和变量的 ApiName，获取 process_form_variable_v2[] 类型参数模板。</para>
/// <para>接口ID：7554060175772434434</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-query_flow_data_template/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-query_flow_data_template%2fcreate</para>
/// </summary>
public record PostCorehrV2QueryFlowDataTemplateBodyDto
{
    /// <summary>
    /// <para>流程定义ID。</para>
    /// <para>获取方式：管理员在设置侧配置的流程，浏览器 URL 为</para>
    /// <para>`https://{域名}/people/approvals/flow-builder/people_7023711013443944467_7554571297192562476`，其中 `people_7023711013443944467_7554571297192562476` 为当前流程的流程定义 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：people_7023711013443944467_7437160904904494892</para>
    /// </summary>
    [JsonPropertyName("flow_definition_id")]
    public string FlowDefinitionId { get; set; } = string.Empty;

    /// <summary>
    /// <para>需要传入的变量的ApiName。如果是多级下钻变量用"."分割。</para>
    /// <para>字段的ApiName查询方式：</para>
    /// <para>1. 进入飞书人事 -&gt; 设置 -&gt; 流程设置 -&gt; 流程管理。</para>
    /// <para>2. 点击flow_definition_id对应的流程的"编辑"按钮，点击右上角"下一步"，进入"2. 流程设计"页面</para>
    /// <para>3. 点击左侧的“变量”，找到你需要查询的变量，点击变量右侧的“API”按钮，复制变量的ApiName。</para>
    /// <para>多级下钻变量举例，例如“批量异动.新部门”，分别按上面的步骤找到"批量异动"的ApiName为"batch_job_change"，新部门的ApiName为"target_department"，并用"."分割，则传参为"batch_job_change.target_department"。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("variable_api_names")]
    public string[] VariableApiNames { get; set; } = [];
}
