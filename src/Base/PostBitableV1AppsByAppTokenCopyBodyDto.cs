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
/// <para>接口ID：7205776220394160156</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcopy</para>
/// </summary>
public record PostBitableV1AppsByAppTokenCopyBodyDto
{
    /// <summary>
    /// <para>多维表格 App 名字</para>
    /// <para>必填：否</para>
    /// <para>示例值：一篇新的多维表格</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>[多维表格 App 归属文件夹 ](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df)</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldbco*****CIMltVc</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string? FolderToken { get; set; }

    /// <summary>
    /// <para>是否复制多维表格内容，取值：</para>
    /// <para>* true：不复制</para>
    /// <para>* false：复制</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("without_content")]
    public bool? WithoutContent { get; set; }

    /// <summary>
    /// <para>文档时区，[详见](https://feishu.feishu.cn/docx/YKRndTM7VoyDqpxqqeEcd67MnEf)</para>
    /// <para>必填：否</para>
    /// <para>示例值：Asia/Shanghai</para>
    /// </summary>
    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }
}
