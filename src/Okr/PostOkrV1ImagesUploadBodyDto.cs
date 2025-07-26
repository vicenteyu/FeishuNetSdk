// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostOkrV1ImagesUploadBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传进展记录图片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 上传进展记录图片 请求体
/// <para>上传图片，以获取在进展记录富文本中使用的 token。成功调用该接口后，你可继续调用[创建 OKR 进展记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/progress_record/create)或[更新 OKR 进展记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/progress_record/update)，将返回的 `url`参数和`file_token` 参数传入 `imageList` 参数中。</para>
/// <para>接口ID：7047048928294174722</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fimage%2fupload</para>
/// </summary>
public record PostOkrV1ImagesUploadBodyDto
{
    /// <summary>
    /// <para>插入图片所在的待创建/修改的进展记录对应的目标 ID，可以通过调用“批量获取 OKR”或“获取用户的 OKR 列表”接口获取对应的 Objective 或 KR 的 ID。</para>
    /// <para>必填：是</para>
    /// <para>示例值：6974586812998174252</para>
    /// </summary>
    [JsonPropertyName("target_id")]
    public string TargetId { get; set; } = string.Empty;

    /// <summary>
    /// <para>插入图片所在的待创建/修改的进展记录对应的目标类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>2：okr的O</item>
    /// <item>3：okr的KR</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("target_type")]
    public int TargetType { get; set; }
}
