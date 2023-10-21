using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 分片上传素材（预上传） 请求体
/// <para>发送初始化请求获取上传事务ID和分块策略，目前是以4MB大小进行定长分片。</para>
/// <para>接口ID：6979562676003848220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_prepare</para>
/// </summary>
public record PostDriveV1MediasUploadPrepareBodyDto
{
    /// <summary>
    /// <para>文件名</para>
    /// <para>必填：是</para>
    /// <para>示例值：demo.jpeg</para>
    /// <para>最大长度：250</para>
    /// </summary>
    [JsonProperty("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：doc_image</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc_image：文档图片。</item>
    /// <item>docx_image：新版文档图片</item>
    /// <item>sheet_image：电子表格图片。</item>
    /// <item>doc_file：文档文件。</item>
    /// <item>docx_file：新版文档文件</item>
    /// <item>sheet_file：电子表格文件。</item>
    /// <item>vc_virtual_background：vc虚拟背景(灰度中，暂未开放)。</item>
    /// <item>bitable_image：多维表格图片。</item>
    /// <item>bitable_file：多维表格文件。</item>
    /// <item>moments：同事圈(灰度中，暂未开放)。</item>
    /// <item>ccm_import_open：云文档导入文件。</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("parent_type")]
    public string ParentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点的标识符</para>
    /// <para>必填：是</para>
    /// <para>示例值：doccnFivLCfJfblZjGZtxgabcef</para>
    /// </summary>
    [JsonProperty("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件大小</para>
    /// <para>必填：是</para>
    /// <para>示例值：1024</para>
    /// </summary>
    [JsonProperty("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>扩展信息(可选)</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"test\":\"test\"}</para>
    /// </summary>
    [JsonProperty("extra")]
    public string? Extra { get; set; }
}
