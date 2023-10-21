using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传素材 请求体
/// <para>将文件、图片、视频等素材文件上传到指定云文档中。素材文件在云空间中不会显示，只会显示在对应云文档中。</para>
/// <para>接口ID：6979562676003831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_all</para>
/// </summary>
public record PostDriveV1MediasUploadAllBodyDto
{
    /// <summary>
    /// <para>文件名。</para>
    /// <para>必填：是</para>
    /// <para>示例值：demo.jpeg</para>
    /// <para>最大长度：250</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点类型，即要将某种类型的素材上传到指定类型的云文档中。例如将一张图片插入到新版文档，则`parent_type`需填写为`docx_image `，再如将一个附件上传到新版文档，则`parent_type`需填写为`docx_file`。</para>
    /// <para>必填：是</para>
    /// <para>示例值：doc_image</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc_image：文档图片。</item>
    /// <item>docx_image：新版文档图片。</item>
    /// <item>sheet_image：电子表格图片。</item>
    /// <item>doc_file：文档文件。</item>
    /// <item>docx_file：新版文档文件。</item>
    /// <item>sheet_file：电子表格文件。</item>
    /// <item>vc_virtual_background：vc虚拟背景(灰度中，暂未开放)。</item>
    /// <item>bitable_image：多维表格图片。</item>
    /// <item>bitable_file：多维表格文件。</item>
    /// <item>moments：同事圈(灰度中，暂未开放)。</item>
    /// <item>ccm_import_open：云文档导入文件。</item>
    /// </list></para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("parent_type")]
    public string ParentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点token: 参考说明[上传点类型及对应标识符（token）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件大小（以字节为单位）。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1024</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>文件adler32校验和（可选）。</para>
    /// <para>必填：否</para>
    /// <para>示例值：12345678</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>
    /// <para>扩展信息(可选)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"test":"test"}</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("extra")]
    public string? Extra { get; set; }
}
