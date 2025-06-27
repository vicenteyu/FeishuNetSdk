// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDocumentAiV1ContractFieldExtractionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 提取文件中的合同字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ai;

/// <summary>
/// 测试 提取文件中的合同字段 响应体
/// <para>接口ID：7220312184105664515</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/document_ai-v1/contract/field_extraction</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fcontract%2ffield_extraction</para>
/// </summary>
[TestClass]
public class Test_PostDocumentAiV1ContractFieldExtractionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,
"msg":"success",
"data":{"file_id":"121345678",
"price":{"contract_price":200000,
"contract_price_original":"200000",
"text":"本合同项下总金额共计￥200000（贰拾万元整）"},
"time":{"time_start":"2020-07-01",
"time_end":"2022-06-30",
"original_time_start":"2020年07月1日",
"original_time_end":"2022年6月30日",
"text_start":"本协议自有效期自【2020】年【07】月【1】日至【2022】年【6】月【30】日，有效期2年。",
"text_end":"本协议自有效期自【2020】年【07】月【1】日至【2022】年【6】月【30】日，有效期2年。",
"initial_term":{"initial_time":"2",
"initial_unit":"年"},
"text_initial_term":"2年"},
"copy":{"copy_num":2,
"original_copy":"一式贰份",
"key":"协议",
"text":"此协议一式贰份，双方各执壹份，具有同等法律效力。"},
"currency":{"currency_name":"CNY",
"currency_text":"¥"},
"header":"项目活动框架协议",
"body_info":[{
    "body_type": "buy",
    "value": {
        "address": "北京市A区B园4号楼",
        "contacts": "张三",
        "email": "zhangsan.1111@bytedance.com",
        "phone": "13600000000",
        "id_number": "310XXXXXXXXXXXXXXX",
        "legal_representative": "张三",
        "party": "北京字节跳动网络技术有限公司"
    }
}],
"bank_info":[{
    "bank_type": "buy",
    "value": {
        "account_name": "北京字节跳动网络技术有限公司",
        "bank_name": "中国A银行B支行",
        "account_number": "11230xxxxx004701",
        "phone": "010-8xxxx688",
        "contacts": "张三",
        "tax_number": "911101xxxxx684235",
        "address": "A市B区C园D楼3-8",
        "id_number": "11230xxxxx004701",
        "email": "zhangsan.1111@bytedance.com"
    }
}]}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ai.PostDocumentAiV1ContractFieldExtractionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}