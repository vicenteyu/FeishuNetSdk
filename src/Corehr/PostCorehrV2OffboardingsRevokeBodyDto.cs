// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-29
//
// Last Modified By : yxr
// Last Modified On : 2024-11-29
// ************************************************************************
// <copyright file="PostCorehrV2OffboardingsRevokeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销离职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销离职 请求体
/// <para>通过离职ID撤销飞书人事的[离职信息](https://people.feishu.cn/people/members/dimission/management)。当接口成功提交后，会产生对应的[离职信息变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/updated)事件。</para>
/// <para>接口ID：7428522865559273475</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/revoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2frevoke</para>
/// </summary>
public record PostCorehrV2OffboardingsRevokeBodyDto
{
    /// <summary>
    /// <para>离职记录ID，不允许为空。可以通过[搜索离职信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/search)获取，取值于接口返回的data &gt; items &gt; offboarding_id</para>
    /// <para>必填：是</para>
    /// <para>示例值：7095671727698478604</para>
    /// </summary>
    [JsonPropertyName("offboarding_id")]
    public string OffboardingId { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作人雇佣 ID（employment_id），ID类型与查询参数 user_id_type取值一致：</para>
    /// <para>1、当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>2、当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>3、当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
    /// <para>4、当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
    /// <para>注意：为空时，默认系统操作人</para>
    /// <para>必填：否</para>
    /// <para>示例值：6982509313466189341</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }
}
