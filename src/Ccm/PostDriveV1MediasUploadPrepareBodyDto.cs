// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1MediasUploadPrepareBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>分片上传素材-预上传 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传素材-预上传 请求体
/// <para>发送初始化请求，以获取上传事务 ID 和分片策略，为[上传素材分片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_part)做准备。平台固定以 4MB 的大小对素材进行分片。了解完整的分片上传素材流程，参考[素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。</para>
/// <para>## 注意事项</para>
/// <para>上传事务 ID 和上传进度在 24 小时内有效。请及时保存和恢复上传。</para>
/// <para>## 使用限制</para>
/// <para>该接口调用频率上限为 5 QPS，10000 次/天。</para>
/// <para>接口ID：6979562676003848220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_prepare</para>
/// </summary>
public record PostDriveV1MediasUploadPrepareBodyDto
{
    /// <summary>
    /// <para>素材的文件名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：demo.jpeg</para>
    /// <para>最大长度：250</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点的类型。你可根据上传的文件类型与云文档类型确定上传点类型。例如，要将一张图片插入到新版文档（文件类型为 `docx`）中，需指定上传点为 `docx_image`；要将一个附件上传到新版文档中，需指定上传点为 `docx_file`。</para>
    /// <para>必填：是</para>
    /// <para>示例值：docx_image</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc_image：旧版文档图片</item>
    /// <item>docx_image：新版文档图片</item>
    /// <item>sheet_image：电子表格图片</item>
    /// <item>doc_file：文档文件</item>
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
    /// <para>上传点的 token，即要上传的云文档的 token，用于指定素材将要上传到的云文档或位置。参考 [素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction) 了解上传点类型与上传点 token 的对应关系。</para>
    /// <para>必填：是</para>
    /// <para>示例值：doccnFivLCfJfblZjGZtxgabcef</para>
    /// </summary>
    [JsonPropertyName("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的大小，单位为字节</para>
    /// <para>必填：是</para>
    /// <para>示例值：1024</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>其它扩展信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"test\":\"test\"}</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }
}
