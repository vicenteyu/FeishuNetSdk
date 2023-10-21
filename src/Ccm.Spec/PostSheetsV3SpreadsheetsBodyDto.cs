using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建表格 请求体
/// <para>在指定目录下创建表格{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=sheets&version=v3&resource=spreadsheet&method=create)</para>
/// <para>接口ID：6969763153149476865</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBodyDto
{
    /// <summary>
    /// <para>表格标题</para>
    /// <para>**示例值**："title"</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `255` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>文件夹token，获取方式见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN)</para>
    /// <para>**示例值**："fldcnMsNb*****hIW9IjG1LVswg"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("folder_token")]
    public string? FolderToken { get; set; }
}
