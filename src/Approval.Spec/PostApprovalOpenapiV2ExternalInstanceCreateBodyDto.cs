using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 三方审批实例同步 请求体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_instance/create)<br></para>
/// <para>审批中心不负责审批的流转，审批的流转在三方系统，三方系统在审批流转后生成的审批实例、审批任务、审批抄送数据同步到审批中心。<br></para>
/// <para><br></para>
/// <para>用户可以在审批中心中浏览三方系统同步过来的实例、任务、抄送信息，并且可以跳转回三方系统进行更详细的查看和操作，其中实例信息在【已发起】列表，任务信息在【待审批】和【已审批】列表，抄送信息在【抄送我】列表</para>
/// <para><img src="//sf3-cn.feishucdn.com/obj/open-platform-opendoc/9dff4434afbeb0ef69de7f36b9a6e995_z5iwmTzEgg.png" alt="" style="zoom:17%;" /></para>
/// <para><img src="//sf3-cn.feishucdn.com/obj/open-platform-opendoc/ca6e0e984a7a6d64e1b16a0bac4bf868_tfqjCiaJQM.png" alt="" style="zoom:17%;" /></para>
/// <para><img src="//sf3-cn.feishucdn.com/obj/open-platform-opendoc/529377e238df78d391bbd22e962ad195_T7eefLI1GA.png" alt="" style="zoom:17%;" /></para>
/// <para>接口ID：6907569523177013249</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-instance-create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuczM3UjL3MzN14yNzcTN</para>
/// </summary>
public record PostApprovalOpenapiV2ExternalInstanceCreateBodyDto
{
    /// <summary>
    /// <para>JSON字符串</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("content")]
    public string Content { get; set; } = string.Empty;
}
