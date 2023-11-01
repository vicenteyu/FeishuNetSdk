using Newtonsoft.Json;
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的名片 请求体
/// <para>名片识别接口，通过上传 JPG / PNG / PDF 等文件类型进行一次性的名片识别。接口适用于20MB以下的文件，适用于英文、日语的名片。</para>
/// <para>接口ID：7205462689421066244</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/document_ai-v1/business_card/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fbusiness_card%2frecognize</para>
/// </summary>
public record PostDocumentAiV1BusinessCardRecognizeBodyDto
{
}
