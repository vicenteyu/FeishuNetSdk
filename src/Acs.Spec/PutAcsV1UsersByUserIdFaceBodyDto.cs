using Newtonsoft.Json;
namespace FeishuNetSdk.Acs.Spec;
/// <summary>
/// 上传人脸图片 请求体
/// <para>用户需要录入人脸图片才可以使用门禁考勤机。使用该 API 上传门禁用户的人脸图片。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=acs&version=v1&resource=user.face&method=update)</para>
/// <para>接口ID：6987691292973924353</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser-face%2fupdate</para>
/// </summary>
public record PutAcsV1UsersByUserIdFaceBodyDto
{
    /// <summary>
    /// <para>文件类型,可选的类型有jpg,png</para>
    /// <para>**示例值**："jpg"</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("file_type")]
    public string FileType { get; set; } = string.Empty;

    /// <summary>
    /// <para>带后缀的文件名</para>
    /// <para>**示例值**："efeqz12f.jpg"</para>
    /// <para>必填：是</para>
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;
}
