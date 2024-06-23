// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1MediasUploadAllBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传素材 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传素材 请求体
/// <para>将文件、图片、视频等素材上传到指定云文档中。素材将显示在对应云文档中，在云空间中不会显示。</para>
/// <para>接口ID：6979562676003831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_all</para>
/// </summary>
public record PostDriveV1MediasUploadAllBodyDto
{
    /// <summary>
    /// <para>要上传的素材的名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：demo.jpeg</para>
    /// <para>最大长度：250</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点的类型。你可根据上传的素材类型与云文档类型确定上传点类型。例如，要将一张图片插入到新版文档（文件类型为 `docx`）中，需指定上传点为 `docx_image `；要将一个附件上传到新版文档中，需指定上传点为 `docx_file`。</para>
    /// <para>必填：是</para>
    /// <para>示例值：docx_image</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc_image：旧版文档图片</item>
    /// <item>docx_image：新版文档图片</item>
    /// <item>sheet_image：电子表格图片</item>
    /// <item>doc_file：旧版文档文件</item>
    /// <item>docx_file：新版文档文件</item>
    /// <item>sheet_file：电子表格文件</item>
    /// <item>vc_virtual_background：vc 虚拟背景（灰度中，暂未开放）</item>
    /// <item>bitable_image：多维表格图片</item>
    /// <item>bitable_file：多维表格文件</item>
    /// <item>moments：同事圈（灰度中，暂未开放）</item>
    /// <item>ccm_import_open：云文档导入文件</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("parent_type")]
    public string ParentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点的 token，即要上传的云文档的 token，用于指定素材将要上传到的云文档或位置。参考[素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)了解上传点类型与上传点 token 的对应关系</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的大小，单位为字节</para>
    /// <para>必填：是</para>
    /// <para>示例值：1024</para>
    /// <para>最大值：20971520</para>
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>文件的 Adler-32 校验和</para>
    /// <para>必填：否</para>
    /// <para>示例值：3248270248</para>
    /// </summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>
    /// <para>其它扩展信息。详情参考[素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。如果需要跨域路由，需要填写路由的云文档 token，格式为 `{"drive_route_token":"需要路由的云文档的 token"}`</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"test":"test"}</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }
}
