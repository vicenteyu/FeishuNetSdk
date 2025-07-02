// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenCopyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 复制文件 请求体
/// <para>将用户云空间中的文件复制至其它文件夹下。该接口为异步接口。</para>
/// <para>## 使用限制</para>
/// <para>- 不支持复制文件夹。</para>
/// <para>- 云空间中文件夹（包括根文件夹，即根目录）的单层节点上限为 1500 个。超过此限制时，接口将返回 1062507 错误码。可通过将文件复制到不同文件夹中解决。</para>
/// <para>- 云空间中所有层级的节点总和的上限为 40 万个。</para>
/// <para>- 该接口不支持并发调用，且调用频率上限为 5QPS 且 10000次/天。否则会返回 1061045 错误码，可通过稍后重试解决。</para>
/// <para>接口ID：7087776630140157955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcopy</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCopyBodyDto
{
    /// <summary>
    /// <para>复制的新文件的名称</para>
    /// <para>**数据校验规则**：最大长度为 `256` 字节</para>
    /// <para>必填：是</para>
    /// <para>示例值：Demo copy</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>被复制的源文件的类型。必须与 `file_token` 对应的源文件实际类型一致。</para>
    /// <para>**注意**：该参数为必填，请忽略左侧必填列的“否”。若该参数值为空或与实际文件类型不匹配，接口将返回失败。</para>
    /// <para>必填：否</para>
    /// <para>示例值：docx</para>
    /// <para>可选值：<list type="bullet">
    /// <item>file：文件类型</item>
    /// <item>doc：旧版文档。了解更多，参考[新旧版本文档说明](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/docs/upgraded-docs-access-guide/upgraded-docs-openapi-access-guide)。</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>bitable：多维表格类型</item>
    /// <item>docx：新版文档类型</item>
    /// <item>mindnote：思维笔记类型</item>
    /// <item>slides：幻灯片类型</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>目标文件夹的 token。若传入根文件夹 token，表示复制的新文件将被创建在云空间根目录。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string FolderToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义请求附加参数，用于实现特殊的复制语义</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public Property[]? Extras { get; set; }

    /// <summary>
    /// <para>自定义请求附加参数，用于实现特殊的复制语义</para>
    /// </summary>
    public record Property
    {
        /// <summary>
        /// <para>自定义属性键对象</para>
        /// <para>必填：是</para>
        /// <para>示例值：target_type</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义属性值对象</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
