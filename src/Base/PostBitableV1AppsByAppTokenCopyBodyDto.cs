// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenCopyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制多维表格 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 复制多维表格 请求体
/// <para>复制一个多维表格，可以指定复制到某个有权限的文件夹下。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格和目标文件夹的阅读、编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通云文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>接口ID：7205776220394160156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcopy</para>
/// </summary>
public record PostBitableV1AppsByAppTokenCopyBodyDto
{
    /// <summary>
    /// <para>多维表格 App 的名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：一篇新的多维表格</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>了解如何获取文件夹 Token，参考[如何获取云文档资源相关 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>**注意**：</para>
    /// <para>请确保调用身份拥有在该文件夹中的编辑权限。若应用使用的是 `tenant_access_token` 权限，此处仅可指定应用创建的文件夹。详情参考[如何为应用开通云文档相关资源的权限](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-add-permissions-to-app)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldcnqquW1svRIYVT2Np6Iabcef</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string? FolderToken { get; set; }

    /// <summary>
    /// <para>是否复制多维表格中的内容，默认 false，即复制多维表格中的内容。可取值：</para>
    /// <para>* true：不复制</para>
    /// <para>* false：复制</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("without_content")]
    public bool? WithoutContent { get; set; }

    /// <summary>
    /// <para>文档时区，详情参考[文档时区介绍](https://feishu.feishu.cn/docx/YKRndTM7VoyDqpxqqeEcd67MnEf)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：Asia/Shanghai</para>
    /// </summary>
    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }
}
