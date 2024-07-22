// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TripartiteAgreementsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建三方协议 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建三方协议 请求体
/// <para>租户打开「通过 api 同步三方协议」开关并在校招流程特定阶段配置「三方协议」时，可以为 Offer 办公地点在中国大陆的校招投递创建三方协议，通过投递 ID 创建三方协议与对应状态。</para>
/// <para>接口ID：7307160083569623043</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/tripartite_agreement/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftripartite_agreement%2fcreate</para>
/// </summary>
public record PostHireV1TripartiteAgreementsBodyDto
{
    /// <summary>
    /// <para>投递ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6930815272790114325</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string ApplicationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>三方协议状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：未开始</item>
    /// <item>2：已申请</item>
    /// <item>3：学生处理中</item>
    /// <item>4：公司处理中</item>
    /// <item>5：学校处理中</item>
    /// <item>6：已终止</item>
    /// <item>7：已完成</item>
    /// <item>8：解约处理中</item>
    /// <item>9：已解约</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("state")]
    public int State { get; set; }

    /// <summary>
    /// <para>三方协议创建时间，毫秒时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1698292282660</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; } = string.Empty;
}
