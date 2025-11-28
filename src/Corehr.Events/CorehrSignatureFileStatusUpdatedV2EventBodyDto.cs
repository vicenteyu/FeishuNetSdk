// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="CorehrSignatureFileStatusUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>电子签文件状态发生变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 电子签文件状态发生变更事件 事件体
/// <para>当电子签文件状态发生变更的时候，会推送变更事件，包含文件变更前后的状态等信息{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=signature_file&amp;event=status_updated)</para>
/// <para>接口ID：7395391068203073564</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_file/events/status_updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_file%2fevents%2fstatus_updated</para>
/// </summary>
public record CorehrSignatureFileStatusUpdatedV2EventBodyDto() : EventBodyDto("corehr.signature_file.status_updated_v2")
{
    /// <summary>
    /// <para>发生状态变更的电子签文件id，[【查询电子签文件详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/signature_file/query)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("signature_file_id")]
    public string? SignatureFileId { get; set; }

    /// <summary>
    /// <para>变更前的电子签文件状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签文件状态（signature_file_state）枚举定义部分获得</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("before_status")]
    public string? BeforeStatus { get; set; }

    /// <summary>
    /// <para>变更后的电子签文件状态，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)电子签文件状态（signature_file_state）枚举定义部分获得</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("after_status")]
    public string? AfterStatus { get; set; }

    /// <summary>
    /// <para>业务id, 由接入业务自行维护,可以通过该流程id获取该流程下的签署文件信息list</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("biz_process_id")]
    public string? BizProcessId { get; set; }
}
