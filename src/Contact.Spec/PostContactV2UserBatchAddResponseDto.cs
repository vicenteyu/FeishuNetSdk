namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 批量新增用户 响应体
/// <para>该接口用于向通讯录中批量新增多个用户。</para>
/// <para>调用该接口需要具有待添加用户所在部门的通讯录授权范围。</para>
/// <para>应用商店应用无权限调用此接口。</para>
/// <para>调用该接口需要申请 `更新通讯录` 以及 `以应用身份访问通讯录` 权限。</para>
/// <para>接口ID：6907569743420997634</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDOwUjLygDM14iM4ATN</para>
/// </summary>
public record PostContactV2UserBatchAddResponseDto
{
    /// <summary>
    /// <para>生成的异步任务 ID，参见 [查询批量任务执行状态](https://open.feishu.cn/document/ukTMukTMukTM/uUDOwUjL1gDM14SN4ATN) 接口。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
