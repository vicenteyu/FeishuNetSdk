// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PutHireV1TripartiteAgreementsByTripartiteAgreementIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新三方协议 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新三方协议 请求体
/// <para>更新三方协议的状态及修改时间信息。</para>
/// <para>## 前提条件</para>
/// <para>在「飞书招聘」-「设置」-「候选人流程管理」-「三方协议设置」中勾选了「通过 API 维护三方协议」。</para>
/// <para>接口ID：7307160083569688579</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/tripartite_agreement/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftripartite_agreement%2fupdate</para>
/// </summary>
public record PutHireV1TripartiteAgreementsByTripartiteAgreementIdBodyDto
{
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
    /// <para>三方协议修改时间，毫秒时间戳，不可小于创建时间或者当前修改时间</para>
    /// <para>必填：是</para>
    /// <para>示例值：1698292282661</para>
    /// </summary>
    [JsonPropertyName("modify_time")]
    public string ModifyTime { get; set; } = string.Empty;
}
