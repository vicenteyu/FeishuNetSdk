using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 编辑旧版文档内容 请求体
/// <para>在使用此接口前，请仔细阅读[文档概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/docs-doc-overview)和[准备接入文档 API](https://open.feishu.cn/document/ukTMukTMukTM/ugzNzUjL4czM14CO3MTN/guide/getting-start)了解文档调用的规则和约束，确保你的文档数据不会丢失或出错。</para>
/// <para>文档数据结构定义可参考：[文档数据结构概述](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)</para>
/// <para>接口ID：6908984614439813122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/content/batch-update-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYDM2YjL2AjN24iNwYjN</para>
/// </summary>
public record PostDocV2ByDocTokenBatchUpdateBodyDto
{
    /// <summary>
    /// <para>文件的 token，获取方式见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("docToken")]
    public string DocToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档的指定版本，文档新创建后版本号是0，[获取方式](https://open.feishu.cn/document/ukTMukTMukTM/uUDM2YjL1AjN24SNwYjN)，要求&gt;=0，post body json 字段</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("revision")]
    public int Revision { get; set; }

    /// <summary>
    /// <para>post body json， OperationRequest 类型序列化 string 数组</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("requests")]
    public string[] Requests { get; set; } = Array.Empty<string>();
}
