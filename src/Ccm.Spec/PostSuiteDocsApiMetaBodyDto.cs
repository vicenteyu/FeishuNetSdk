using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取元数据 请求体
/// <para>该接口用于根据 token 获取各类文件的元数据。</para>
/// <para>请求用户需要拥有该文件的访问（读）权限</para>
/// <para>接口ID：6907569743420637186</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/obtain-metadata</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjN3UjLzYzN14yM2cTN</para>
/// </summary>
public record PostSuiteDocsApiMetaBodyDto
{
    /// <summary>
    /// <para>请求文档，一次不超过200个</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("request_docs")]
    public RequestDoc[] RequestDocs { get; set; } = Array.Empty<RequestDoc>();

    public record RequestDoc
    {
        /// <summary>
        /// <para>文件的 token，获取方式见[概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/files/guide/introduction)</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("docs_token")]
        public string DocsToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件类型</para>
        /// <para>1) "doc": 飞书文档</para>
        /// <para>2) "sheet": 飞书电子表格</para>
        /// <para>3) "bitable": 飞书多维表格</para>
        /// <para>4) "mindnote": 飞书思维笔记</para>
        /// <para>5) "file": 飞书文件</para>
        /// <para>6) "docx": 飞书新版文档</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("docs_type")]
        public string DocsType { get; set; } = string.Empty;
    }
}
