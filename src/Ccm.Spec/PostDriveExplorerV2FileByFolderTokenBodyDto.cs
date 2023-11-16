namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 新建在线文档 请求体
/// <para>在用户云空间指定文件夹中创建旧版文档、电子表格或者多维表格。如果目标文件夹是「我的空间」，则新建的文档会在「我的空间」的「归我所有」列表里。</para>
/// <para>- 云空间中文件夹单层节点上限是 1500 个，超过此限制接口将会返回失败。如有创建大量节点的需求，可以考虑将文档新建到不同文件夹下；</para>
/// <para>- 我们对创建类接口进行了更细粒度的拆分和升级：</para>
/// <para>- 本接口不支持创建[新版文档](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-overview)，如需创建新版文档，请调用[创建新版文档](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/create)接口；</para>
/// <para>- 如需创建电子表格，也可以调用[创建表格](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet/create)接口。</para>
/// <para>接口ID：6907569743419932674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/create-online-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTNzUjL0UzM14CN1MTN</para>
/// </summary>
public record PostDriveExplorerV2FileByFolderTokenBodyDto
{
    /// <summary>
    /// <para>创建文档的标题。注：type 为 "doc" 时不可用（非必填，请求会被过滤），有创建带标题doc文档需求可用 [创建文档](https://open.feishu.cn/document/ukTMukTMukTM/ugDM2YjL4AjN24COwYjN) 接口</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// <para>需要创建文档的类型 "doc" 、 "sheet" or "bitable"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
}
