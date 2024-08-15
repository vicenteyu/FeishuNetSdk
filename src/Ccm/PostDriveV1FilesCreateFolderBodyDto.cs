// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesCreateFolderBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 新建文件夹 请求体
/// <para>该接口用于在用户云空间指定文件夹中创建一个空文件夹。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口不支持并发创建，且调用频率上限为 5QPS 以及 10000次/天。否则会返回 1061045 错误码，可通过稍后重试解决。</para>
/// <para>- 云空间中根目录或文件夹的单层节点上限为 1500 个。超过此限制时，接口将返回 1062507 错误码。可通过新建节点到其它节点中解决。</para>
/// <para>- 云空间中所有层级的节点总和的上限为 40 万个。</para>
/// <para>接口ID：7086652480830914563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/create_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_folder</para>
/// </summary>
public record PostDriveV1FilesCreateFolderBodyDto
{
    /// <summary>
    /// <para>文件夹名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：产品优化项目</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>父文件夹的 token。参数为空字符串时，表示在根目录下创建文件夹。你可参考[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)获取某个文件夹的 token。了解更多，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string FolderToken { get; set; } = string.Empty;
}
