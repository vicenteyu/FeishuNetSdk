using Newtonsoft.Json;
namespace FeishuNetSdk.Contact.Spec;
/// <summary>
/// 批量新增部门 响应体
/// <para>该接口用于向通讯录中批量新增多个部门。<br></para>
/// <para>调用该接口需要具有所有新增部门父部门的授权范围。<br></para>
/// <para>应用商店应用无权限调用此接口。<br></para>
/// <para>调用该接口需要申请 `更新通讯录` 以及 `以应用身份访问通讯录` 权限。<br></para>
/// <para>接口ID：6907569524101021697</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version//import-api/batch-add-departments</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMDOwUjLzgDM14yM4ATN</para>
/// </summary>
public record PostContactV2DepartmentBatchAddResponseDto
{
    /// <summary>
    /// <para>生成的异步任务 ID，参见 [查询批量任务执行状态](https://open.feishu.cn/document/ukTMukTMukTM/uUDOwUjL1gDM14SN4ATN) 接口。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("task_id")]
    public string? TaskId { get; set; }
}
